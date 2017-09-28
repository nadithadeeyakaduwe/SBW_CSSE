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

namespace SBW.BusinessService
{
    public class EmployeeService : IEmployeeService
    {
        //public string getEmployeeName(int id)
        //{
        //    EmployeeRepository repo = new EmployeeRepository();

        //    return repo.getEmployeeName(id);
        //}

        /// <summary>
        /// Adds the or update employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool AddOrUpdateEmployee(Employee employee)
        {
            bool status = true; 
            EmployeeRepository repo = new EmployeeRepository();

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
    }
}
