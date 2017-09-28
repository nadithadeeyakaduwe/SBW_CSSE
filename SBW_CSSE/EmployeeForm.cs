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

        private void panel_UC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }
    }
}
