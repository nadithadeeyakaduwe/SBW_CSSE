using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBW.Entities.CustomerModule;
using SBW.Services;
using SBW.BusinessService;

namespace SBW_CSSE_Tests
{
    [TestClass]
    public class SarangaBatteryWorksTests
    {
        [TestMethod]
        public void AddNewCustomer()
        {
            //Arrange
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            ICustomerService service = ServiceFactory.GetCustomerSeriveice();

            customer1.NIC = "908323102v";
            customer1.Name = "S.W.Saranaga";
            customer1.Address = "110/2 , New Kandy Rd, Malabe";
            customer1.Phone = "0752323232";
            customer1.Email = "sarangasw@gmail.com";
            customer1.CustomerType = "Regular";


            //act
            bool addSuccess = service.AddNewCustomer(customer1);
            if (addSuccess) {
               customer2 = service.getCustomer(customer1.NIC);
            }
      
            // assert             
            Assert.AreEqual( customer1 , customer2);

        }
    }
}
