using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SBW.BusinessService;
using SBW.Core;
using SBW.DataAccess.Repositories;
using SBW.Entities.CustomerModule;
using SBW.Services;
using System.Data;

namespace SBW.BusinessService
{
    public class CustomerService : ICustomerService
    {
        private CustomerRepository customerRepository;

        //Add new customer
        public bool AddNewCustomer(Customer customer)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.addCustomer(customer);

            Console.WriteLine(status);
            if (!status){
                MessageBoxHelper.ShowError(CommonResource.DBInsertError);
            }
            else{
                MessageBoxHelper.Show(CommonResource.DBInsertSuccess);
            }

            return status;
        }

        public DataTable ViewCustomerDetails() {
            DataTable result = null;

            customerRepository = new CustomerRepository();

            result = customerRepository.viewCustomerDetails();

            if (result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }
            return result;
        }

        //update Customer
        public bool UpdateCustomer(Customer customer)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.updateCustomer(customer);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBUpdateError);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBUpdateSuccess);
            }

            return status;
        }

        //Delete customer
        public bool DeleteCustomer(string NIC)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.deleteCustomer(NIC);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBDeleteError);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBDeleteSuccess);
            }

            return status;
           
        }

        public bool AddLoyaltyCustomer(Customer custome)
        {
            throw new NotImplementedException();
        }


        public bool UpdateLoyaltyCard(Customer customes)
        {
            throw new NotImplementedException();
        }


        public bool DeleteLoyaltyCard(string NIC)
        {
            throw new NotImplementedException();
        }

        public void ChangeCardType(string nic)
        {
            throw new NotImplementedException();
        }

        
        public void LoyaltyCardAddPoints(double Invoice_Amount, string NIC)
        {
            throw new NotImplementedException();
        }

        public void Rating()
        {
            throw new NotImplementedException();
        }

        public string SetCardType(string NIC)
        {
            throw new NotImplementedException();
        }       

    }
}
