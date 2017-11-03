﻿using SBW.BusinessService;
using SBW.Entities.HRMModule;
using SBW.Services;
using SBW.UI.Common;
using System;
using System.ComponentModel;
using System.Data;
using System.Threading;
using System.Windows.Forms;

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

        private Form childForm = null;

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
                Thread.Sleep(500);
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
                childForm = new ViewEmployeeDetailForm(employee);
                childForm.Owner = this;
                //childForm.FormClosed += new FormClosedEventHandler(form_FormClosed);
                Helper.ShowForm(childForm);
            }
        }

        /// <summary>
        /// Handles the FormClosed event of the form control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.refreshCurrentEmployees();
        }

        /// <summary>
        /// Handles the Click event of the btn_search control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btn_promote control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the btn_performanceHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_performanceHistory_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(dgv_employeeWithTitles.CurrentRow.Cells["dgvCol_EmployeeID"].Value.ToString());
            Helper.ShowForm(new ViewEmployeePerformance(employeeID));
        }

        /// <summary>
        /// Handles the Click event of the btn_giveIncrement control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_giveIncrement_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(dgv_employeeWithTitles.CurrentRow.Cells["dgvCol_EmployeeID"].Value.ToString());
            Helper.ShowForm(new EmployeeIncrementForm(employeeID), FormStartPosition.CenterScreen);
        }

        /// <summary>
        /// Handles the Click event of the btn_attendance control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_attendance_Click(object sender, EventArgs e)
        {
            int employeeID = Convert.ToInt32(dgv_employeeWithTitles.CurrentRow.Cells["dgvCol_EmployeeID"].Value.ToString());
            Helper.ShowForm(new EmployeeAttendanceForm(employeeID));
        }

        public void refreshCurrentEmployees()
        {
            service = ServiceFactory.GetEmployeeSeriveice();
            dgv_employeeWithTitles.DataSource = service.ViewEmployeesWithTitles();
        }
    }
}
