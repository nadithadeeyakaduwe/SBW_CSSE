using SBW.BusinessService;
using SBW.Core;
using SBW.Entities.HRMModule;
using SBW.Services;
using SBW.UI.Common;
using System;
using System.Windows.Forms;

namespace SBW.UI.EmployeeForms
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
            this.Close();
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

            if (status)
            {
                ViewEmployeesForm viewEmployeesForm = (ViewEmployeesForm)this.Owner;
                viewEmployeesForm.refreshCurrentEmployees();
                this.Close();
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_update control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_update_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = DialogResult.No;

            dialogResult = MessageBoxHelper.GetConfirmation(CommonResources.UpdateEmployeeeConfirmation);

            if (dialogResult.Equals(DialogResult.Yes))
            {
                if (!ValidationHelper.IsValidEmail(tb_email.Text))
                {
                    MessageBoxHelper.ShowError(CommonResources.EmailError);
                }
                else
                {
                    Employee employee = new Employee
                    {
                        EmployeeID = Convert.ToInt32(lbl_empNo.Text),
                        MobileNumber = tb_mobile.Text,
                        HomeTel = tb_homeTel.Text,
                        Address = rtb_address.Text,
                        CivilStatus = this.EmployeeCivilStatus,
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
        private void tb_epfNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
