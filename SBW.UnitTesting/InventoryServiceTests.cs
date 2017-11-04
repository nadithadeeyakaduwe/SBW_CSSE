using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBW.Entities.InventoryModule;
using SBW.Services;
using SBW.BusinessService;
using System.Data.SqlClient;

namespace SBW.UnitTesting
{
    [TestClass]
    public class InventoryServiceTests
    {
        IInventoryService service = ServiceFactory.GetInventoryService();

        [TestMethod]
        public void AddInventoryTest()
        {
            Inventory inventory = new Inventory()
            {
                Make = "TestMake",
                Name = "TestName",
                Type = "TestType",
                ReorderLevel = 5

            };

            bool status = service.AddInventory(inventory);

            if (status == true)
            {
                string query= $"SELECT * FROM [Stock].[Product] WHERE Product_Type = {inventory.Type}";

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
    }
}
