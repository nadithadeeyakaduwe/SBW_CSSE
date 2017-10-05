using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.Entities.HRMModule;
using SBW.Services;
using SBW.BusinessService;

namespace SBW.UI.EmployeeUserControls
{
    public partial class ViewEmployeeDetailForm : Form
    {
        /// <summary>
        /// The service
        /// </summary>
        private IEmployeeService service;

        /// <summary>
        /// Gets the employee civil status.
        /// </summary>
        /// <value>
        /// The employee civil status.
        /// </value>
        private char EmployeeCivilStatus
        {
            get
            {
                return rbtn_single.Checked ? 'S' : 'M';
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewEmployeeDetailForm"/> class.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public ViewEmployeeDetailForm(Employee employee)
        {
            InitializeComponent();
            FillEmployeeDetails(employee);
        }

        /// <summary>
        /// Fills the employee details.
        /// </summary>
        /// <param name="emp">The emp.</param>
        private void FillEmployeeDetails(Employee emp)
        {
            lbl_empNo.Text = emp.EmployeeID.ToString();
            tb_fullName.Text = emp.FullName;
            rtb_address.Text = emp.Address;
            tb_basicSalary.Text = emp.BasicSalary.ToString();
            tb_epfNo.Text = emp.EPFNo.ToString();
            tb_email.Text = emp.Email;
            tb_homeTel.Text = emp.HomeTel;
            tb_mobile.Text = emp.MobileNumber;
            tb_position.Text = emp.Position;
            tb_department.Text = emp.Department;
            rtb_pastExperience.Text = emp.PastExperience;
            rtb_qualification.Text = emp.Qualification;
            tb_nic.Text = emp.NIC;
            if (emp.Gender == 'M')
            {
                rbtn_male.Checked = true;
            }
            else
            {
                rbtn_female.Checked = true;
            }
            if (emp.CivilStatus == 'M')
            {
                rbtn_married.Checked = true;
            }
            else
            {
                rbtn_single.Checked = true;
            }
            dtp_dob.Value = emp.Brithday;
            dtp_joinDate.Value = emp.JoinDate;
        }

        /// <summary>
        /// Handles the Click event of the btn_back control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_back_Click(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the btn_delete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_delete_Click(object sender, EventArgs e)
        {
            bool status = true;

            service = ServiceFactory.GetEmployeeSeriveice();

            status = service.DeleteEmployee(Convert.ToInt32(lbl_empNo.Text));

            if(status)
            {
                btn_delete.Enabled = false;
                btn_update.Enabled = false;
                // OR find a way to open the previous form.
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee
            {
                EmployeeID = Convert.ToInt32(lbl_empNo.Text),
                MobileNumber = tb_mobile.Text,
                HomeTel = tb_homeTel.Text,
                Address = rtb_address.Text,
                CivilStatus = this.EmployeeCivilStatus,
                BasicSalary = Convert.ToDecimal(tb_basicSalary.Text),
                PastExperience = rtb_pastExperience.Text,
                Qualification = rtb_qualification.Text,
                Email = tb_email.Text,
                EPFNo = Convert.ToInt32(tb_epfNo.Text)
            };

            service = ServiceFactory.GetEmployeeSeriveice();

            service.UpdateEmployee(employee);
        }
    }
}
