using System;
using System.Windows.Forms;

namespace SBW.UI
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the Click event of the btn_employeeMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_employeeMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_employeeMain.Top);
            loadMainForm(new EmployeeForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_customerMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_customerMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_customerMain.Top);
            loadMainForm(new CustomerForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_InventoryMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_InventoryMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_InventoryMain.Top);
            loadMainForm(new InventoryForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_salesMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_salesMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_salesMain.Top);
            loadMainForm(new SalesNProfit());
        }

        /// <summary>
        /// Handles the Click event of the btn_settingsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_settingsMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_settingsMain.Top);
        }

        /// <summary>
        /// Handles the Click event of the pbx_logo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pbx_logo_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
        }

        /// <summary>
        /// Loads the main form.
        /// </summary>
        /// <param name="form">The form.</param>
        private void loadMainForm(Form form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        /// <summary>
        /// Shows the selected menu.
        /// </summary>
        /// <param name="top">The top.</param>
        private void showSelectedMenu(int top)
        {
            panel_sidebar.Top = top;
        }
    }
}
