using System;
using System.Windows.Forms;
using SBW.Entities.HRMModule;
using SBW.Services;
using SBW.BusinessService;
using System.Collections.Generic;
using System.Linq;
using SBW.UI.Common;
using SBW.Core;

namespace SBW.UI.EmployeeForms
{
    public partial class AddEmployeeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEmployeeForm"/> class.
        /// </summary>
        public AddEmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Gets the employee gender.
        /// </summary>
        /// <value>
        /// The employee gender.
        /// </value>
        private char EmployeeGender
        {
            get
            {
                return rbtn_female.Checked == true ? 'F' : 'M';
            }
        }

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
        /// Handles the Click event of the btn_clear control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            Helper.ClearAll(this);
        }

        /// <summary>
        /// Handles the Click event of the btn_save control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_save_Click(object sender, EventArgs e)
        {
            bool isEmpty = this.checkIsEmpty();
            bool isDataValid = ValidationHelper.IsValidNIC(tb_nic.Text) && ValidationHelper.IsValidEmail(tb_email.Text);
            DialogResult dialogResult = MessageBoxHelper.GetConfirmation(CommonResources.AddEmployeeConfirmation);

            if(dialogResult == DialogResult.OK)
            {
                if (isEmpty)
                {
                    MessageBox.Show(CommonResources.EmptyFieldsError);
                }
                else if (!isDataValid)
                {
                    MessageBoxHelper.ShowError(CommonResources.NicEmailError);
                }
                else if (!ValidationHelper.IsOkToRecruite(dtp_dob.Value))
                {
                    MessageBoxHelper.ShowError(CommonResources.AgeError);
                }
                else
                {
                    this.saveEmployee();
                }
            }
        }

        /// <summary>
        /// Saves the employee.
        /// </summary>
        private void saveEmployee()
        {
            bool isSuccess = true;

            Employee employee = new Employee()
            {
                FullName = tb_fullName.Text,
                Address = rtb_address.Text,
                BasicSalary = Convert.ToDecimal(tb_basicSalary.Text),
                EPFNo = Convert.ToInt32(tb_epfNo.Text),
                Email = tb_email.Text,
                HomeTel = tb_homeTel.Text,
                MobileNumber = tb_mobile.Text,
                PositionID = Convert.ToInt32(cb_position.SelectedValue),
                PastExperience = rtb_pastExperience.Text,
                Qualification = rtb_qualification.Text,
                NIC = tb_nic.Text,
                Gender = this.EmployeeGender,
                CivilStatus = this.EmployeeCivilStatus,
                Brithday = dtp_dob.Value,
                JoinDate = dtp_joinDate.Value.Date,
                DepartmentID = Convert.ToInt32(cb_department.SelectedValue)
            };

            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();

            isSuccess = service.AddEmployee(employee);

            if (isSuccess == true)
            {
                Helper.ClearAll(this);
            }
        }

        /// <summary>
        /// Checks the is empty.
        /// </summary>
        /// <returns></returns>
        private bool checkIsEmpty()
        {
            bool isEmpty = false;

            foreach (TextBox tb in Controls.OfType<TextBox>())
            {
                if (string.IsNullOrEmpty(tb.Text.Trim()))
                {
                    isEmpty = true;
                    break;
                }
            }

            if (isEmpty)
            {
                if (string.IsNullOrEmpty(rtb_address.Text.Trim()))
                {
                    isEmpty = true;
                }
            }

            return isEmpty;
        }

        /// <summary>
        /// Handles the Click event of the btn_demo control.
        /// Fills All the necessary details to show a DEMO
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_demo_Click(object sender, EventArgs e)
        {
            tb_fullName.Text = "Test Employee";
            rtb_address.Text = "addressAddresss";
            tb_basicSalary.Text = "25000.00";
            tb_epfNo.Text = "24";
            tb_email.Text = "test@gmail.com";
            tb_homeTel.Text = "0112729729";
            tb_mobile.Text = "0741258963";
            cb_position.SelectedIndex = 0;
            cb_department.SelectedIndex = 0;
            rtb_pastExperience.Text = string.Empty;
            rtb_qualification.Text = string.Empty;
            tb_nic.Text = "95025763";
            rbtn_male.Checked = true;
            rbtn_female.Checked = false;
            rbtn_married.Checked = false;
            rbtn_single.Checked = true;
            dtp_dob.Value = DateTime.Today;
            dtp_joinDate.Value = DateTime.Today;
        }

        /// <summary>
        /// Loads the components.
        /// </summary>
        private void loadComponents()
        {
            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();

            cb_position.DataSource = service.LoadComboBox("Position");
            cb_position.ValueMember = "PositionID";
            cb_position.DisplayMember = "Name";

            cb_department.DataSource = service.LoadComboBox("Department");
            cb_department.ValueMember = "DepartmentID";
            cb_department.DisplayMember = "Name";

            //dtp_joinDate.MinDate = DateTime.Today;
        }

        /// <summary>
        /// Handles the KeyPress event of the tb_basicSalary control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void tb_basicSalary_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsMoneyTextBox(e.KeyChar, tb_basicSalary.Text))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the tb_mobile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void tb_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the tb_homeTel control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void tb_homeTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the KeyPress event of the tb_epfNo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs"/> instance containing the event data.</param>
        private void tb_epfNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!ValidationHelper.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the Load event of the AddEmployeeForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {
            this.loadComponents();
        }
    }
}
