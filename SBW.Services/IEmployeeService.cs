using SBW.Entities.HRMModule;
using System.Data;

namespace SBW.Services
{
    public interface IEmployeeService
    {
        //string getEmployeeName(int id);

        /// <summary>
        /// Adds the or update employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        bool AddOrUpdateEmployee(Employee employee);

        /// <summary>
        /// Views the employees with titles and the respective department.
        /// </summary>
        /// <returns>
        /// returns a datatable with the details included to show on the data grid view
        /// </returns>
        DataTable ViewEmployeesWithTitles();

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns>
        /// Object of Employee
        /// </returns>
        Employee GetEmployee(int employeeId);

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        bool DeleteEmployee(int employeeId);

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        void UpdateEmployee(Employee employee);

        /// <summary>
        /// Searches the employee.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        DataTable SearchEmployee(string searchString);
    }
}
