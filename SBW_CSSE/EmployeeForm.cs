using SBW.UI.EmployeeUserControls;
using System;
using System.Windows.Forms;

namespace SBW.UI
{
    public partial class EmployeeForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeForm"/> class.
        /// </summary>
        public EmployeeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the btn_addEmployeeUC control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_addEmployeeUC_Click(object sender, EventArgs e)
        {
            loadUserControl(new AddEmployeeForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_viewEmployee control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_viewEmployee_Click(object sender, EventArgs e)
        {
            loadForm(new ViewEmployeesForm());
        }


        /// <summary>
        /// Loads the user control.
        /// </summary>
        /// <param name="userControl">The user control.</param>
        private void loadUserControl(UserControl userControl)
        {
            panel_UC.Controls.Clear();
            panel_UC.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        /// <summary>
        /// Loads the main form.
        /// </summary>
        /// <param name="form">The form.</param>
        private void loadForm(Form form)
        {
            panel_UC.Controls.Clear();
            form.TopLevel = false;
            panel_UC.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


    }
}
