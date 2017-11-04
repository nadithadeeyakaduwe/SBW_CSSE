using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBW.BusinessService;
using SBW.Entities.CustomerModule;
using System.Data;
using System.Data.SqlClient;
using SBW.DataAccess.Repositories;
using SBW.Services;

namespace SBW.UnitTesting
{
    [TestClass]
    public class CustomerServiceTests
    {
        ICustomerService service = ServiceFactory.GetCustomerSeriveice();
        Customer customer = new Customer();

        [TestMethod]
        public void AddNewCustomer()
        {
            //Arrange
            customer.NIC = "955544433v";
            customer.Name = "Perera K.M";
            customer.Address = "12,Lellupitiya,Rathnapura";
            customer.Phone = "0778451258";
            customer.Email = "perera@gmail.com";
            customer.CustomerType = "Regular";
            customer.Rate = 0;

            //Act
            bool addSuccess = service.AddNewCustomer(customer);

            //Assert
            if (addSuccess) {
                string query = $"select cu.NIC,cu.Name,cu.Email,cu.Address,cu.Rate,cu.CustomerType,cc.ContactNo from [Consumer].[Customer] cu,[Consumer].[CustomerContact] cc where cu.NIC=cc.NIC and cu.NIC = {customer.NIC}";
                SqlCommand cmd = new SqlCommand(query);

                SqlDataReader reader;
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    Assert.IsTrue(true);
                }
                else
                {
                    Assert.Fail();
                }
            }           
        }

        public void UpdateCustomer()
        {
            //Arrange
            customer.NIC = "915482674v";
            customer.Name = "Sajith S.L";
            customer.Address = "12,Lellupitiya,Rathnapura";
            customer.Phone = "0766124588";
            customer.Email = "sajitha@gmail.com";
            customer.CustomerType = "Regular";
            customer.Rate = 0;

            //Act
            bool updateSuccess = service.UpdateCustomer(customer);

            //Assert
            if (updateSuccess)
            {
                bool status = false;
                string customerQuery = "UPDATE [Consumer].[Customer] SET Address='" + customer.Address + "' where NIC = '" + customer.NIC + "'";
              
                bool s1 = Repository.ExecuteQuery(customerQuery);
              
                if (s1 == true)
                {
                    status = true;
                }

                if (status == true) {
                     string query = $"select cu.Address from [Consumer].[Customer] cu where cu.NIC = {customer.NIC}";
                    SqlCommand cmd = new SqlCommand(query);

                    //Assert.Equals();
                }
               
            }
        }
    }
}