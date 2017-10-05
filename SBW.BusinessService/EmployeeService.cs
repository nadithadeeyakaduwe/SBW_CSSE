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
        public bool AddOrUpdateEmployee(Employee employee)
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
                result.Brithday = (DateTime) dt.Rows[0][4]; ;
                result.NIC = dt.Rows[0][5].ToString();
                result.HomeTel = dt.Rows[0][6].ToString();
                result.MobileNumber = dt.Rows[0][7].ToString();
                result.Gender = dt.Rows[0][8].ToString().FirstOrDefault();
                result.CivilStatus = dt.Rows[0][9].ToString().FirstOrDefault();
                result.EPFNo = Convert.ToInt32(dt.Rows[0][10].ToString());
                result.PositionID = Convert.ToInt32(dt.Rows[0][11].ToString());
                result.DepartmentID = Convert.ToInt32(dt.Rows[0][12].ToString());
                result.BasicSalary = (decimal) dt.Rows[0][13];
                result.PastExperience = dt.Rows[0][14].ToString();
                result.Qualification = dt.Rows[0][15].ToString();
                result.JoinDate = (DateTime) dt.Rows[0][16];
                result.Status = Convert.ToInt32(dt.Rows[0][17].ToString());
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

            if(dt == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }

            return dt;
        }
    }
}
