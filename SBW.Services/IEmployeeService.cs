using SBW.Entities.HRMModule;

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
    }
}
