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
using SBW.UI;
using SBW.Core;
using SBW.DataAccess.Enum;

namespace SBW.UI.EmployeeForms
{
    public partial class EmployeePromotionForm : Form
    {
        private Employee employee;
        public SplashForm SplashForm { get; private set; }
        public EmployeePromotionForm(Employee emp)
        {
            InitializeComponent();
            this.employee = emp;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeePromotionForm_Load(object sender, EventArgs e)
        {
            DataTable positionTable = null;

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
                backgroundWorker.ReportProgress(100);
                positionTable = getPositionData();

            };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                loadComponents(positionTable);
                loadCurrentEmployeeDetails(employee);
                this.HideProgress();
            };

            backgroundWorker.ProgressChanged += progressChangedEventHandler;
            backgroundWorker.RunWorkerAsync();

            this.ShowProgress();
        }

        /// <summary>
        /// Hides the progress.
        /// </summary>
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
        private void loadCurrentEmployeeDetails(Employee emp)
        {
            lbl_employeeNo.Text = emp.EmployeeID.ToString();
            lbl_epfNoValue.Text = emp.EPFNo.ToString();
            lbl_nameValue.Text = emp.FullName;
            lbl_oldPositionValue.Text = emp.Position;
            lbl_currentSalaryValue.Text = emp.BasicSalary.ToString();
        }

        private DataTable getPositionData()
        {
            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
            return service.LoadComboBox("Position"); ;
        }
        private void loadComponents(DataTable positionData)
        {
            cb_newPosition.DataSource = positionData;
            cb_newPosition.ValueMember = "PositionID";
            cb_newPosition.DisplayMember = "Name";
        }

        private void btn_promote_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tb_newSalary.Text))
            {
                MessageBoxHelper.ShowError(Common.CommonResources.EmptySalaryError);
            }
            else if ((lbl_oldPositionValue.Text.Equals(cb_newPosition.Text)))
            {
                MessageBoxHelper.ShowError(Common.CommonResources.PromotionPositionSameError);
            }
            else
            {
                bool status = true;

                IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
                EmployeePromotion promotion = new EmployeePromotion()
                {
                    EmployeeID = Convert.ToInt32(lbl_employeeNo.Text),
                    NewPositionID = Convert.ToInt32(cb_newPosition.SelectedValue.ToString()),
                    Reason = rtb_reason.Text,
                    NewSalary = Convert.ToDecimal(tb_newSalary.Text),
                    Status = (int)WellknownEmployeePerformanceStatus.IsPromotion
                };

                status = service.PromoteEmployee(promotion);

                if (status)
                {
                    this.Close();
                }
            }
        }
    }
}
