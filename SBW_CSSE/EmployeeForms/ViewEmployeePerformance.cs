using SBW.BusinessService;
using SBW.Entities.HRMModule;
using SBW.Services;
using SBW.UI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.UI.EmployeeForms
{
    public partial class ViewEmployeePerformance : Form
    {
        private int EmployeeID { get; set; }
        public ViewEmployeePerformance(int id)
        {
            InitializeComponent();
            this.EmployeeID = id;
        }

        private void ViewEmployeePerformance_Load(object sender, EventArgs e)
        {
            SplashForm splashForm = new SplashForm();
            splashForm.lbl_percentage.Visible = false;
            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
            EmployeePerformanceDto employee = null;

            BackgroundWorker backgroundWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };

            backgroundWorker.DoWork += delegate
            {
                backgroundWorker.ReportProgress(100);
                employee = service.GetEmployeePerformanceHistory(this.EmployeeID);
            };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                loadPerformanceDetails(employee);
                splashForm.Close();
            };

            backgroundWorker.RunWorkerAsync();
            splashForm.ShowDialog();
        }

        private void loadPerformanceDetails(EmployeePerformanceDto employee)
        {
            lbl_employeeID.Text = employee.EmployeeDetails.EmployeeID.ToString();
            lbl_nameValue.Text = employee.EmployeeDetails.FullName;
            lbl_epfNoValue.Text = employee.EmployeeDetails.EPFNo.ToString();
            lbl_joinedDateValue.Text = employee.EmployeeDetails.JoinDate.ToString();

            dgv_employeePerformance.DataSource = employee.PerformanceTable;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
