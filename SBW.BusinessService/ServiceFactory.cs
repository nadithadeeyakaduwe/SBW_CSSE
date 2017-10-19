using SBW.Services;

namespace SBW.BusinessService
{
    public class ServiceFactory
    {
        public static IEmployeeService GetEmployeeSeriveice()
        {
            return new EmployeeService();
        }

        public static ICustomerService GetCustomerSeriveice()
        {
            return new CustomerService();
        }

    }
}
