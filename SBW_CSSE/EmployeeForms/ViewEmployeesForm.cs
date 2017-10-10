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
using System.Threading;
using SBW.UI.Common;

namespace SBW.UI.EmployeeForms
{
    public partial class ViewEmployeesForm : Form
    {
        /// <summary>
        /// The service
        /// </summary>
        private IEmployeeService service;

        /// <summary>
        /// The main panel x coordinate
        /// </summary>
        private const int MAIN_PANEL_X_COORDINATE = 260;

        /// <summary>
        /// The main panel y coordinate
        /// </summary>
        private const int MAIN_PANEL_Y_COORDINATE = 180;

        /// <summary>
        /// Gets the splash form.
        /// </summary>
        /// <value>
        /// The splash form.
        /// </value>
        public SplashForm SplashForm { get; private set; }

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

            DataTable dt = null;

            BackgroundWorker backgroundWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };

            ProgressChangedEventHandler progressChangedEventHandler = (bgSender, ev) =>
            {
                if (this.SplashForm != null)
                {
                    this.SplashForm.lbl_percentage.Text = $"{ev.ProgressPercentage.ToString()} %";
                }
            };

            backgroundWorker.DoWork += delegate
            {
                backgroundWorker.ReportProgress(50, ServiceFactory.GetEmployeeSeriveice());

                backgroundWorker.ReportProgress(100);
                dt = service.ViewEmployeesWithTitles();
            };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                dgv_employeeWithTitles.DataSource = dt;

                this.HideProgress();
            };

            backgroundWorker.ProgressChanged += progressChangedEventHandler;
            backgroundWorker.RunWorkerAsync();

            this.ShowProgress();
        }

        private void HideProgress()
        {
            if (this.SplashForm != null)
            {
                this.SplashForm.Close();
                this.SplashForm = null;
            }
        }
 
        /// <summary>
        /// Shows the progress.
        /// </summary>
        private void ShowProgress()
        {
            this.SplashForm = new SplashForm();
            this.SplashForm.ShowDialog();
        }

        /// <summary>
        /// Handles the CellDoubleClick event of the dgv_employeeWithTitles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DataGridViewCellEventArgs"/> instance containing the event data.</param>
        private void dgv_employeeWithTitles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();

            int EmployeeID = Convert.ToInt32(dgv_employeeWithTitles.Rows[e.RowIndex].Cells["dgvCol_EmployeeID"].Value.ToString());

            Employee employee = service.GetEmployee(EmployeeID);

            if (employee != null)
            {
                Helper.ShowForm(new ViewEmployeeDetailForm(employee));
            }
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

        private void btn_promote_Click(object sender, EventArgs e)
        {
            service = ServiceFactory.GetEmployeeSeriveice();
            int EmployeeID = Convert.ToInt32(dgv_employeeWithTitles.CurrentRow.Cells["dgvCol_EmployeeID"].Value.ToString());

            Employee employee = service.GetEmployee(EmployeeID);

            if (employee != null)
            {
                Helper.ShowForm(new EmployeePromotionForm(employee));
            }
        }
    }
}
