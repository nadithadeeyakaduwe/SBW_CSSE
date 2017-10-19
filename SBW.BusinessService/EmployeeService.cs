using SBW.BusinessService;
using SBW.Core;
using SBW.DataAccess.Repositories;
using SBW.Entities.HRMModule;
using SBW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Threading;
using SBW.DataAccess.Enum;

namespace SBW.BusinessService
{
    public class EmployeeService : IEmployeeService
    {
        /// <summary>
        /// The Employee repository
        /// </summary>
        private EmployeeRepository repo;

        /// <summary>
        /// Adds the or update employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool AddEmployee(Employee employee)
        {
            bool status = true;
            repo = new EmployeeRepository();

            status = repo.addEmployee(employee);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBInsertError);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBInsertSuccess);
            }

            return status;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns>
        /// Object of Employee
        /// </returns>
        public Employee GetEmployee(int employeeId)
        {
            DataTable dt = null;
            Employee result = new Employee();

            repo = new EmployeeRepository();

            dt = repo.getEmployee(employeeId);

            if (dt == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
                result = null;
            }
            else
            {
                result.EmployeeID = Convert.ToInt32(dt.Rows[0][0].ToString());
                result.FullName = dt.Rows[0][1].ToString();
                result.Address = dt.Rows[0][2].ToString();
                result.Email = dt.Rows[0][3].ToString();
                result.Brithday = (DateTime)dt.Rows[0][4]; ;
                result.NIC = dt.Rows[0][5].ToString();
                result.HomeTel = dt.Rows[0][6].ToString();
                result.MobileNumber = dt.Rows[0][7].ToString();
                result.Gender = dt.Rows[0][8].ToString().FirstOrDefault();
                result.CivilStatus = dt.Rows[0][9].ToString().FirstOrDefault();
                result.EPFNo = Convert.ToInt32(dt.Rows[0][10].ToString());
                result.PositionID = Convert.ToInt32(dt.Rows[0][11].ToString());
                result.DepartmentID = Convert.ToInt32(dt.Rows[0][12].ToString());
                result.BasicSalary = (decimal)dt.Rows[0][13];
                result.PastExperience = dt.Rows[0][14].ToString();
                result.Qualification = dt.Rows[0][15].ToString();
                result.JoinDate = (DateTime)dt.Rows[0][16];
                result.Status = Convert.ToInt32(dt.Rows[0][17].ToString());
                result.Position = dt.Rows[0][18].ToString();
                result.Department = dt.Rows[0][19].ToString();
            }

            return result;
        }

        /// <summary>
        /// Views the employees with titles and the respective department.
        /// </summary>
        /// <returns>
        /// returns a datatable with the details included to show on the data grid view
        /// </returns>
        public DataTable ViewEmployeesWithTitles()
        {
            DataTable Result = null;

            repo = new EmployeeRepository();

            Result = repo.viewEmployeesWithTitles();

            if (Result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }
            return Result;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public bool DeleteEmployee(int employeeId)
        {
            bool status = true;

            repo = new EmployeeRepository();

            status = repo.deleteEmployee(employeeId);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBDeleteError);
            }

            return status;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        public void UpdateEmployee(Employee employee)
        {
            bool status = true;

            repo = new EmployeeRepository();

            status = repo.updateEmployee(employee);

            if (status)
            {
                MessageBoxHelper.Show(CommonResource.DBUpdateSuccess);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBUpdateError);
            }

        }

        /// <summary>
        /// Searches the employee.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns>
        /// returns a data table with searched employees
        /// </returns>
        public DataTable SearchEmployee(string searchString)
        {
            DataTable dt = null;

            repo = new EmployeeRepository();

            dt = repo.searchEmployee(searchString);

            if (dt == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }

            return dt;
        }

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        /// <param name="tableName">Name of the table.</param>
        /// <returns></returns>
        public DataTable LoadComboBox(string tableName)
        {
            DataTable result = null;
            repo = new EmployeeRepository();

            if (tableName.Equals("Position"))
            {
                result = repo.getPositionForCombo();
            }
            else if (tableName.Equals("Department"))
            {
                result = repo.getDepartmentForCombo();
            }

            if (result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }

            return result;
        }

        /// <summary>
        /// Promotes the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public bool PromoteEmployee(EmployeePromotionDto promotionDto)
        {
            bool status = true;

            repo = new EmployeeRepository();

            status = repo.promoteEmployee(promotionDto);

            if (status)
            {
                if (promotionDto.Status == (int)WellknownEmployeePerformanceStatus.IsPromotion)
                {
                    MessageBoxHelper.Show(CommonResource.PromotionSuccess);
                }
                else
                {
                    MessageBoxHelper.Show(CommonResource.IncrementSuccess);
                }
            }
            else
            {
                if (promotionDto.Status == (int)WellknownEmployeePerformanceStatus.IsPromotion)
                {
                    MessageBoxHelper.Show(CommonResource.PromotionError);
                }
                else
                {
                    MessageBoxHelper.Show(CommonResource.IncrementError);
                }
            }

            return status;
        }

        /// <summary>
        /// Gets the employee performance history asynchronous.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns></returns>
        public EmployeePerformanceDto GetEmployeePerformanceHistory(int employeeID)
        {
            EmployeePerformanceDto result = new EmployeePerformanceDto();

            repo = new EmployeeRepository();

            result.EmployeeDetails = GetEmployee(employeeID);

            result.PerformanceTable = repo.getPromotionDetails(employeeID);

            if (result.EmployeeDetails == null || result.PerformanceTable == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }

            result.PerformanceTable.Columns.Add("temp", typeof(string));

            foreach (DataRow row in result.PerformanceTable.Rows)
            {
                int status = row.Field<int>("Status");
                string value = Enum.GetName(typeof(WellknownEmployeePerformanceStatus), status);

                row.SetField("temp", value);
            }

            result.PerformanceTable.Columns.Remove("Status");
            result.PerformanceTable.Columns["temp"].ColumnName = "Status";

            return result;
        }

        /// <summary>
        /// Gets the employee attendance details.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="date"></param>
        /// <returns></returns>
        public EmployeeAttendanceDto GetEmployeeAttendanceData(int employeeID, DateTime date)
        {
            DataTable todaysRecord = null;
            repo = new EmployeeRepository();
            EmployeeAttendanceDto result = null;

            todaysRecord = repo.getEmployeeattendance(employeeID, date);


            if (todaysRecord.Rows.Count > 0)
            {
                result = new EmployeeAttendanceDto();
                result.EmployeeID = employeeID;
                result.InTime = todaysRecord.Rows[0].Field<DateTime>("InTime");
                result.InNote = todaysRecord.Rows[0].Field<string>("InNote") == null ? string.Empty : todaysRecord.Rows[0].Field<string>("InNote");
                result.OutTime = todaysRecord.Rows[0].Field<DateTime?>("OutTime") == null ? (DateTime?)null : todaysRecord.Rows[0].Field<DateTime>("OutTime");
                result.OutNote = todaysRecord.Rows[0].Field<string>("OutNote") == null ? string.Empty : todaysRecord.Rows[0].Field<string>("OutNote");
                result.LateTime = todaysRecord.Rows[0].Field<TimeSpan>("LateTime") == null ? (TimeSpan?)null : todaysRecord.Rows[0].Field<TimeSpan>("LateTime");

                if (todaysRecord.Rows[0]["Duration"] != DBNull.Value)
                {
                    result.Duration = todaysRecord.Rows[0].Field<double>("Duration");
                }
                else
                {
                    result.Duration = null;
                }

                result.Status = todaysRecord.Rows[0].Field<int>("Status");
                result.PastAttendanceRecords = todaysRecord;
            }
            return result;
        }

        /// <summary>
        /// Employees the punch in out.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="activity">The activity.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public bool EmployeePunchInOut(EmployeeAttendanceDto employeeAttendanceDto, string activity)
        {
            bool status = true;
            string error = string.Empty;
            repo = new EmployeeRepository();

            if (activity.Equals("IN"))
            {
                status = repo.punchIn(employeeAttendanceDto);
                error = CommonResource.PunchInError;
            }
            else
            {
                status = repo.punchOut(employeeAttendanceDto);
                error = CommonResource.PunchOutError;
            }

            if (!status)
            {
                MessageBoxHelper.ShowError(error);
            }

            return status;
        }
    }
}
