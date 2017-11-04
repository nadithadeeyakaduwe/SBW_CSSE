using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SBW.Entities.CustomerModule;
using System.Data;

namespace SBW.Services
{
    public interface ICustomerService
    {
        //CRUD operations for the customer
        bool AddNewCustomer(Customer customer);
        bool UpdateCustomer(Customer customer);
        bool DeleteCustomer(string NIC);
        DataTable SearchCustomer(string searchString);

        //get customer details into grid view
        DataTable ViewCustomerDetails();

        //get customer loyalty card details into grid view
        DataTable ViewCustomerLoyaltyDetails(string cardType);


        //CRUD operations for the customer Loyalty card
        bool AddLoyaltyCustomer(Customer custome);
        bool UpdateLoyaltyCard(Customer customes);
        bool DeleteLoyaltyCard(string NIC);
        bool CheckForCustomerAvailability(string customerNIC);

        //rating customer
        void Rating();

        //set cardtype according to rating
        string SetCardType(string NIC);

        //show messagge when customer reach to change the loyalty card type
        void ChangeCardType(string nic);

        //add points to loyalty card when invoice generate
        void LoyaltyCardAddPoints(double Invoice_Amount, string NIC);

        //get customer email for a given nic
        string GetCustomerEmail(string nic);

        DataTable LoadNicComboBox(string schemaName, string tableName, string columnName);
    }
}
