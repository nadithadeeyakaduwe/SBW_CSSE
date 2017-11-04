using SBW.Entities.CustomerModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class CustomerRepository
    {
        public bool addCustomer(Customer customer)
        {
            bool status = false;

            try
            {
                string customerQuery = "INSERT INTO [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType])"
                                    + $"VALUES (@nic,@name,@email,@address,@rate,@customerType)";

                string customerContactQuery = "INSERT INTO [Consumer].[CustomerContact] ([NIC],[ContactNo])"
                                               + $"VALUES (@nic,@contactNo)";

                SqlCommand cmd1 = new SqlCommand(customerQuery);
                cmd1.Parameters.AddWithValue("@nic", customer.NIC);
                cmd1.Parameters.AddWithValue("@name", customer.Name);
                cmd1.Parameters.AddWithValue("@email", customer.Email);
                cmd1.Parameters.AddWithValue("@address", customer.Address);
                cmd1.Parameters.AddWithValue("@rate", customer.Rate);
                cmd1.Parameters.AddWithValue("@customerType", customer.CustomerType);

                SqlCommand cmd2 = new SqlCommand(customerContactQuery);
                cmd2.Parameters.AddWithValue("@nic", customer.NIC);
                cmd2.Parameters.AddWithValue("@contactNo", customer.Phone);

                bool s1 = Repository.ExecuteQuery(cmd1);
                bool s2 = Repository.ExecuteQuery(cmd2);

                if (s1 == true && s2 == true)
                {
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            return status;
        }

        public DataTable viewCustomerDetails()
        {
            DataTable Response;
            string query = "select cu.NIC,cu.Name,cu.Email,cu.Address,cu.Rate,cu.CustomerType,cc.ContactNo from [Consumer].[Customer] cu,[Consumer].[CustomerContact] cc where cu.NIC=cc.NIC order by Rate";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public bool updateCustomer(Customer customer)
        {
            bool status = false;

            string customerQuery = "UPDATE [Consumer].[Customer] SET Name = '" + customer.Name + "',Email='" + customer.Email + "',Address='" + customer.Address + "',Rate=" + customer.Rate + ",CustomerType='" + customer.CustomerType + "' where NIC = '" + customer.NIC + "'";

            string customerContactQuery = "UPDATE [Consumer].[CustomerContact] SET ContactNo = '" + customer.Phone + "' where NIC = '" + customer.NIC + "'";

            bool s1 = Repository.ExecuteQuery(customerQuery);
            bool s2 = Repository.ExecuteQuery(customerContactQuery);
            if (s1 == true && s2 == true)
            {
                status = true;
            }
            return status;
        }

        public bool deleteCustomer(string NIC)
        {

            bool status = false;

            string customerQuery = "DELETE FROM [Consumer].[Customer]"
                                    + " where NIC = '" + NIC + "'";

            string customerContactQuery = "DELETE FROM [Consumer].[CustomerContact]"
                                           + "where NIC = '" + NIC + "'";

            bool s2 = Repository.ExecuteQuery(customerContactQuery);
            bool s1 = Repository.ExecuteQuery(customerQuery);
            if (s1 == true && s2 == true)
            {
                status = true;
            }
            return status;
        }

        public DataTable searchCustomer(string searchString)
        {
            DataTable response;

            string query = "select cu.NIC,cu.Name,cu.Email,cu.Address,cu.Rate,cu.CustomerType,cc.ContactNo from [Consumer].[Customer] cu, [Consumer].[CustomerContact] cc where (cu.NIC = cc.NIC  and cu.NIC LIKE  '%" + searchString + "%') or(cu.NIC = cc.NIC  and cu.Name LIKE  '%" + searchString + "%') ";

            response = Repository.getDataTable(query);
            return response;
        }

        public DataTable viewCustomerLoyaltyDetails(string cardType)
        {
            DataTable Response;

            string str_all = "select cu.Name, cusl.NIC, cusl.Card_No, cusl.Card_Points, cusl.CardType  from [Consumer].[CustomerLoyaltyCard] cusl,[Consumer].[Customer] cu where cusl.NIC=cu.NIC and cu.CustomerType = 'Loyalty'";
            string str_Gold = "select cu.Name, cusl.NIC, cusl.Card_No, cusl.Card_Points, cusl.CardType  from [Consumer].[CustomerLoyaltyCard] cusl,[Consumer].[Customer] cu where cusl.NIC=cu.NIC AND cusl.CardType = 'Gold'";
            string str_Silver = "select cu.Name, cusl.NIC, cusl.Card_No, cusl.Card_Points, cusl.CardType  from [Consumer].[CustomerLoyaltyCard] cusl,[Consumer].[Customer] cu where cusl.NIC=cu.NIC AND cusl.CardType = 'Silver'";
            string str_Bronze = "select cu.Name, cusl.NIC, cusl.Card_No, cusl.Card_Points, cusl.CardType  from [Consumer].[CustomerLoyaltyCard] cusl,[Consumer].[Customer] cu where cusl.NIC=cu.NIC AND cusl.CardType = 'Bronze'";

            if (cardType == "All")
            {
                Response = Repository.getDataTable(str_all);
            }
            else if (cardType == "GOLD Customers")
            {
                Response = Repository.getDataTable(str_Gold);
            }
            else if (cardType == "Silver Customers")
            {
                Response = Repository.getDataTable(str_Silver);
            }
            else
                Response = Repository.getDataTable(str_Bronze);

            return Response;
        }


        public bool checkForCustomerAvailability(string customerNIC)
        {
            bool status = false;

            try
            {
                string customerQuery = "select NIC from [Consumer].[Customer] where NIC = '" + customerNIC + "'";

                SqlCommand cmd = new SqlCommand(customerQuery);               
                var nicObj = Repository.ExecuteScalar(cmd);

                if (nicObj != null)
                {
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return status;
        }

        public bool AddLoyaltyCustomer(Customer customer)
        {
            bool status = false;

            try
            {
                string loyaltyCustomerQuery = "INSERT INTO [Consumer].[CustomerLoyaltyCard]([NIC],[Card_No],[Card_Points] ,[CardType])"
                    + $"VALUES (@nic,@cardNo,@cardPoints,@cardType)";

                string updateCardTypeQqery = "UPDATE [Consumer].[Customer] SET CustomerType = 'Loyalty' where NIC = '" + customer.NIC + "'";


                SqlCommand cmd1 = new SqlCommand(loyaltyCustomerQuery);
                cmd1.Parameters.AddWithValue("@nic", customer.NIC);
                cmd1.Parameters.AddWithValue("@cardNo", customer.CardNo);
                cmd1.Parameters.AddWithValue("@cardPoints", customer.CardPoints);
                cmd1.Parameters.AddWithValue("@cardType", customer.CardType);

                SqlCommand cmd2 = new SqlCommand(updateCardTypeQqery);
             
                bool s1 = Repository.ExecuteQuery(cmd1);
                bool s2 = Repository.ExecuteQuery(cmd2);

                if (s1 == true && s2 == true)
                {
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return status;
        }

        public bool UpdateLoyaltyCard(Customer customer)
        {
            bool status = false;
            try
            {              
                string customerLoyaltyQuery = "UPDATE [Consumer].[CustomerLoyaltyCard] SET Card_No = '" + customer.CardNo + "',NIC ='" + customer.NIC + "',Card_Points ='" + customer.CardPoints + "',CardType ='" + customer.CardType + "' where NIC = '" + customer.NIC + "'";
   
                bool s1 = Repository.ExecuteQuery(customerLoyaltyQuery);
                if (s1)
                {
                    status = true;
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return status;
        }

        public string getCustomerEmail(string nic)
        {
            string email = null;
            try
            {
                string emailQuery = "select Email from Consumer.Customer where NIC = '" + nic + "'";

                SqlCommand cmd = new SqlCommand(emailQuery);
                var emailObj = Repository.ExecuteScalar(cmd);
              
                if (emailObj != null)
                {
                    email = emailObj.ToString();
                }                
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            return email;
        }

        public DataTable getNICsForCombo(string schemaName, string tableName, string columnName)
        {
            DataTable result = null;

            string query = "SELECT DISTINCT [" + columnName + "] FROM " +
                            "[" + schemaName + "].[" + tableName + "] ";

            result = Repository.getDataTable(query);

            return result;
        }


    }    
}
