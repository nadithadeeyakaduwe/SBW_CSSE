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
           
            if (!status){
                MessageBoxHelper.ShowError(CommonResource.PrimaryKeyViolationError1);
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
        public bool DeleteCustomer(string NIC, string cusType)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.deleteCustomer(NIC, cusType);

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

        //search customer by nic or name
        public DataTable SearchCustomer(string searchString)
        {
            DataTable dt = new DataTable();
            customerRepository = new CustomerRepository();

            dt = customerRepository.searchCustomer(searchString);

            if (dt == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }

            return dt;
        }

        ///Loyalty card
        
        public DataTable ViewCustomerLoyaltyDetails(string cardType)
        {
            DataTable result = null;

            customerRepository = new CustomerRepository();

            result = customerRepository.viewCustomerLoyaltyDetails(cardType);

            if (result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }
            return result;
        }

        public bool AddLoyaltyCustomer(Customer customer)
        {
            bool status = false;
            customerRepository = new CustomerRepository();
           
            status = customerRepository.AddLoyaltyCustomer(customer);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.PrimaryKeyViolationError2);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBInsertSuccess);
            }

            return status;
        }

        public bool UpdateLoyaltyCardDetails(Customer customer)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.UpdateLoyaltyCard(customer);

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


        public bool DeleteLoyaltyCardDetails(string NIC)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.deleteLoyaltyCardDetails(NIC);

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

        public bool CheckForCustomerAvailability(string customerNIC)
        {
            bool status = false;
            customerRepository = new CustomerRepository();

            status = customerRepository.checkForCustomerAvailability(customerNIC);
           
            return status;           
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

        //retrieve customer email address for a nic
        public string GetCustomerEmail(string nic)
        {
            string email;
            customerRepository = new CustomerRepository();

            email = customerRepository.getCustomerEmail(nic);

            return email;
        }

        //load all existing nics for the combo box in email section
        public DataTable LoadNicComboBox(string schemaName, string tableName, string columnName)
        {
            DataTable result = null;
            customerRepository = new CustomerRepository();

            result = customerRepository.getNICsForCombo(schemaName, tableName, columnName);

            return result;
        }

    }
}
