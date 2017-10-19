using SBW.Entities.CustomerModule;
using System;
using System.Collections.Generic;
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

            string customerQuery = "INSERT INTO [Consumer].[Customer] ([NIC],[Name],[Email],[Address],[Rate],[CustomerType])"
                                    + $"VALUES (@nic,@name,@email,@address,@rate,@customerType)";

            string customerContactQuery = "INSERT INTO [Consumer].[CustomerContact] ([NIC],[ContactNo])"
                                           + $"VALUES (@nic,@contactNo)";

            SqlCommand cmd1 = new SqlCommand(customerQuery);
            cmd1.Parameters.AddWithValue("@nic", customer.NIC);
            cmd1.Parameters.AddWithValue("@name", customer.CustomrName);
            cmd1.Parameters.AddWithValue("@email", customer.Email);
            cmd1.Parameters.AddWithValue("@address", customer.Address);
            cmd1.Parameters.AddWithValue("@rate", customer.Rate);
            cmd1.Parameters.AddWithValue("@customerType", customer.CustomerType);

            SqlCommand cmd2 = new SqlCommand(customerQuery);
            cmd2.Parameters.AddWithValue("@nic", customer.NIC);
            cmd2.Parameters.AddWithValue("@contactNo", customer.Phone);

            status = Repository.ExecuteQuery(cmd1);
            status = Repository.ExecuteQuery(cmd2);
            return status;
        }

        public bool updateCustomer(Customer customer)
        {
            bool status = false;

            string customerQuery = "UPDATE [Consumer].[Customer] SET ([Name],[Email],[Address],[Rate],[CustomerType])"
                                    + $"VALUES (@name,@email,@address,@rate,@customerType) WHERE [NIC] = {customer.NIC}";

            string customerContactQuery = "UPDATE [Consumer].[CustomerContact] SET ([NIC],[ContactNo])"
                                           + $"VALUES (@nic,@contactNo) WHERE [NIC] = {customer.NIC}";
            SqlCommand cmd1 = new SqlCommand(customerQuery);
            cmd1.Parameters.AddWithValue("@name", customer.CustomrName);
            cmd1.Parameters.AddWithValue("@email", customer.Email);
            cmd1.Parameters.AddWithValue("@address", customer.Address);
            cmd1.Parameters.AddWithValue("@rate", customer.Rate);
            cmd1.Parameters.AddWithValue("@customerType", customer.CustomerType);

            SqlCommand cmd2 = new SqlCommand(customerQuery);
            cmd2.Parameters.AddWithValue("@contactNo", customer.Phone);

            Repository.ExecuteQuery(cmd1);
            Repository.ExecuteQuery(cmd2);

            status = true;

            return status;
        }


        public bool deleteCustomer(string NIC)
        {

            bool status = false;

            string customerQuery = "DELETE FROM [Consumer].[Customer]"
                                    + $"WHERE [NIC] = {NIC}";

            string customerContactQuery = "DELETE FROM [Consumer].[CustomerContact]"
                                           + $"WHERE [NIC] = {NIC}";


            status = Repository.ExecuteQuery(customerQuery);
            status = Repository.ExecuteQuery(customerContactQuery);
            return status;
            ///////////////check delete method here and repository.cs ddletecus()
        }
          
        
    }
}
