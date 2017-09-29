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
    }
}
