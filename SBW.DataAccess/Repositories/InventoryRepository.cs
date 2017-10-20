using SBW.Entities.InventoryModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class InventoryRepository
    {
        public bool addInventory(Inventory inventory)
        {
            bool status = true;
            string query = "INSERT INTO [Stock].[Product] ([Product_Make],[Product_Name],[Product_Type],"
                + "[Reorder_Level])"
                + $"VALUES (@make,@name,@type,@reorderLevel)";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@make", inventory.Make);
            cmd.Parameters.AddWithValue("@name", inventory.Name);
            cmd.Parameters.AddWithValue("@type", inventory.Type);
            cmd.Parameters.AddWithValue("@reorderLevel", inventory.ReorderLevel);

            status = Repository.ExecuteQuery(cmd);

            return status;
        }

        public DataTable viewInventoryItems()
        {
            DataTable Response;
            string query = "SELECT p.Product_ID ,p.Product_Make ,p.Product_Name , p.Product_Type , p.Reorder_Level , p.Quantity FROM [Stock].[Product] p";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public bool deleteInventory(int productId)
        {
            bool status = true;

            string query1 = $"DELETE FROM [Stock].[Stock_Details] WHERE Product_ID = {productId}";
            string query2 = $"DELETE FROM [Stock].[Product] WHERE Product_ID = {productId}";

            status = Repository.ExecuteQuery(query2);
            return status;
        }

    }
}
