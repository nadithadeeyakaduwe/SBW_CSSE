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
    public partial class ViewEmployeesForm : Form
    {
        /// <summary>
        /// The service
        /// </summary>
        private IEmployeeService service;

        /// <summary>
        /// Initializes a new instance of the <see cref="ViewEmployeesForm"/> class.
        /// </summary>
        public ViewEmployeesForm()
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

            //DataTable dt = null;
            //LoadingUC loadingForm = new LoadingUC();
            //loadingForm.Show();

            //BackgroundWorker backgroundWorker = new BackgroundWorker()
            //{
            //    WorkerReportsProgress = true,
            //    WorkerSupportsCancellation = false
            //};

            //ProgressChangedEventHandler progressChangedEventHandler = (bgSender, ev) =>
            //{
            //    loadingForm.lbl_percentage.Text = $"{ev.ProgressPercentage.ToString()} %";
            //};

            //backgroundWorker.DoWork += delegate
            //{
            //    service = ServiceFactory.GetEmployeeSeriveice();

            //    dt = service.ViewEmployeesWithTitles();
            //};

            //backgroundWorker.RunWorkerCompleted += delegate
            //{
            //    dgv_employeeWithTitles.DataSource = dt;
            //    loadingForm.Hide();
            //};
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dgv_employeeWithTitles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgv_employeeWithTitles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();

            int EmployeeID = Convert.ToInt32(dgv_employeeWithTitles.Rows[e.RowIndex].Cells[0].Value.ToString());

            Employee employee = service.GetEmployee(EmployeeID);

            if (employee != null)
            {
                loadForm(new ViewEmployeeDetailForm(employee));
            }
        }

        /// <summary>
        /// Loads the form.
        /// </summary>
        /// <param name="form">The form.</param>
        private void loadForm(Form form)
        {
            panel1.Controls.Clear();
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            panel1.Controls.Add(form);
            form.Dock = DockStyle.Fill;
            form.TopMost = true;
            form.Show();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();
            if (string.IsNullOrEmpty(tb_search.Text))
            {
                dgv_employeeWithTitles.DataSource = service.ViewEmployeesWithTitles();
            }
            else
            {
                dgv_employeeWithTitles.DataSource = service.SearchEmployee(tb_search.Text);
            }
            
        }
    }
}
