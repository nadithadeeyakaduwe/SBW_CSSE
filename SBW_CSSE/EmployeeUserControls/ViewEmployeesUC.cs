using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.Services;
using SBW.BusinessService;
using SBW.Entities.HRMModule;

namespace SBW.UI.EmployeeUserControls
{
    public partial class ViewEmployeesUC : UserControl
    {
        /// <summary>
        /// The service
        /// </summary>
        private IEmployeeService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewEmployeesUC"/> class.
        /// </summary>
        public ViewEmployeesUC()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ViewEmployeesUC control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ViewEmployeesUC_Load(object sender, EventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();

            dgv_employeeWithTitles.DataSource = service.ViewEmployeesWithTitles();
        }

        private void dgv_employeeWithTitles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();

            int EmployeeID = Convert.ToInt32(dgv_employeeWithTitles.Rows[e.RowIndex].Cells[0].Value.ToString());

            //Employee employee = service.GetEmployee(EmployeeID);

            
        }
    }
}
