using SBW.BusinessService;
using SBW.DataAccess.Repositories;
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
        public string getEmployeeName(int id)
        {
            EmployeeRepository repo = new EmployeeRepository();

            return repo.getEmployeeName(id);
        }
    }
}
