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
    public partial class EmployeeAttendanceForm : Form
    {
        private int EmployeeID { get; set; }
        private SplashForm SplashForm { get; set; }

        public EmployeeAttendanceForm(int employeeID)
        {
            EmployeeID = employeeID;
            InitializeComponent();
        }

        private void EmployeeAttendanceForm_Load(object sender, EventArgs e)
        {
            EmployeeAttendanceDto employeeAttendanceDto = new EmployeeAttendanceDto();

            BackgroundWorker backgroundWorker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = false
            };

            backgroundWorker.DoWork += delegate
            {
                employeeAttendanceDto = getInitialData(EmployeeID);
               
                Thread.Sleep(500);
            };

            backgroundWorker.RunWorkerCompleted += delegate
            {
                loadDataIntoForm(employeeAttendanceDto);
                SplashForm.Close();
            };

            backgroundWorker.RunWorkerAsync();

            SplashForm = new SplashForm();
            SplashForm.lbl_percentage.Visible = false;
            SplashForm.ShowDialog();
        }

        private void loadDataIntoForm(EmployeeAttendanceDto employeeAttendanceDto)
        {
            if (employeeAttendanceDto != null)
            {
                lbl_employeeID.Text = employeeAttendanceDto.EmployeeID.ToString();
                lbl_inTimeValue.Text = employeeAttendanceDto.InTime.ToString();
                lbl_inNoteValue.Text = employeeAttendanceDto.InNote;
                lbl_outTimeValue.Text = employeeAttendanceDto.OutTime.ToString();
                lbl_outNoteValue.Text = employeeAttendanceDto.OutNote;

                dgv_attendanceRecord.DataSource = employeeAttendanceDto.PastAttendanceRecords;

                if (employeeAttendanceDto.InTime != null && employeeAttendanceDto.OutTime == null)
                {
                    btn_punchInOut.Text = "OUT";
                }
                else if (employeeAttendanceDto.InTime == null && employeeAttendanceDto.OutTime == null)
                {
                    btn_punchInOut.Text = "IN";
                }
                else if (employeeAttendanceDto.InTime != null && employeeAttendanceDto.OutTime != null)
                {
                    btn_punchInOut.Text = "IN";
                    btn_punchInOut.Enabled = false;
                }
            }
            else
            {
                btn_punchInOut.Text = "IN";
            }
        }

        private EmployeeAttendanceDto getInitialData(int employeeID)
        {
            EmployeeAttendanceDto employeeAttendanceDto = new EmployeeAttendanceDto();

            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();

            employeeAttendanceDto = service.GetEmployeeAttendanceData(employeeID, DateTime.Today);

            return employeeAttendanceDto;
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_punchInOut_Click(object sender, EventArgs e)
        {
            bool status = true;
            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
            EmployeeAttendanceDto employeeAttendanceDto = new EmployeeAttendanceDto()
            {
                EmployeeID = this.EmployeeID,
                Status = 1,
                ModifiedDate = DateTime.Now
            };

            if (btn_punchInOut.Text == "IN")
            {
                employeeAttendanceDto.InTime = DateTime.Now;
                employeeAttendanceDto.InNote = rtb_note.Text;
                employeeAttendanceDto.DateCreated = DateTime.Now;

                status = service.EmployeePunchInOut(employeeAttendanceDto, "IN");
            }
            else
            {
                employeeAttendanceDto.InTime = Convert.ToDateTime(lbl_inTimeValue.Text);
                employeeAttendanceDto.OutTime = DateTime.Now;
                employeeAttendanceDto.OutNote = rtb_note.Text;

                status = service.EmployeePunchInOut(employeeAttendanceDto, "OUT");
                if (status)
                {
                    btn_punchInOut.Enabled = false;
                }
            }
            if (status)
            {
                btn_punchInOut.Text = btn_punchInOut.Text == "IN" ? "OUT" : "IN";
                Helper.ClearAll(this);
                employeeAttendanceDto = getInitialData(EmployeeID);
                loadDataIntoForm(employeeAttendanceDto);
            }
        }

        /// <summary>
        /// Handles the ValueChanged event of the dtp_pickDate control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void dtp_pickDate_ValueChanged(object sender, EventArgs e)
        {
            EmployeeAttendanceDto employeeAttendanceDto = new EmployeeAttendanceDto();

            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();

            employeeAttendanceDto = service.GetEmployeeAttendanceData(EmployeeID, dtp_pickDate.Value.Date);

            if (employeeAttendanceDto != null)
            {
                dgv_attendanceRecord.DataSource = employeeAttendanceDto.PastAttendanceRecords;
            }
            else
            {
                dgv_attendanceRecord.DataSource = null;
            }
        }
    }
}
