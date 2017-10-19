using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.BusinessService;
using SBW.Services;
using SBW.Entities.HRMModule;
using SBW.DataAccess.Enum;
using SBW.Core;

namespace SBW.UI.EmployeeForms
{
    public partial class EmployeeIncrementForm : Form
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        private int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the employee.
        /// </summary>
        /// <value>
        /// The employee.
        /// </value>
        private Employee Employee { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeIncrementForm"/> class.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public EmployeeIncrementForm(int id)
        {
            this.EmployeeID = id;
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the EmployeeIncrementForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void EmployeeIncrementForm_Load(object sender, EventArgs e)
        {
            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
            Employee = service.GetEmployee(EmployeeID);
            lbl_epfNoValue.Text = Employee.EPFNo.ToString();
            lbl_currentSalValue.Text = Employee.BasicSalary.ToString();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_newSalary.Text))
            {
                MessageBoxHelper.ShowWarning(this, Common.CommonResources.EmptyFieldsError);
            }
            else
            {
                IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
                EmployeePromotionDto promotion = new EmployeePromotionDto()
                {
                    EmployeeID = this.EmployeeID,
                    NewPositionID = Employee.PositionID,
                    NewSalary = Convert.ToDecimal(tb_newSalary.Text),
                    Reason = rtb_reason.Text,
                    Status = (int)WellknownEmployeePerformanceStatus.IsIncrement
                };

                if (service.PromoteEmployee(promotion))
                {
                    this.Close();
                }
            }
        }
    }
}
