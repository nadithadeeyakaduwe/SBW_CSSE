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

        //get customer details into grid view
        DataTable ViewCustomerDetails();

        //CRUD operations for the customer Loyalty card
        bool AddLoyaltyCustomer(Customer custome);
        bool UpdateLoyaltyCard(Customer customes);
        bool DeleteLoyaltyCard(string NIC);

        //rating customer
        void Rating();

        //set cardtype according to rating
        string SetCardType(string NIC);

        //show messagge when customer reach to change the loyalty card type
        void ChangeCardType(string nic);

        //add points to loyalty card when invoice generate
        void LoyaltyCardAddPoints(double Invoice_Amount, string NIC);
    }
}
