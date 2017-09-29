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
    }
}
