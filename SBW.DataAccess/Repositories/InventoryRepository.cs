using SBW.Entities.InventoryModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.DataAccess.Repositories
{
    public class InventoryRepository
    {
        public bool addInventory(Inventory inventory)
        {
            bool status = false;
            try
            {
                string query = "INSERT INTO [Stock].[Product] ([Product_Make],[Product_Name],[Product_Type],"
                    + "[Reorder_Level])"
                    + $"VALUES (@make,@name,@type,@reorderLevel)";

                SqlCommand cmd = new SqlCommand(query);
                cmd.Parameters.AddWithValue("@make", inventory.Make);
                cmd.Parameters.AddWithValue("@name", inventory.Name);
                cmd.Parameters.AddWithValue("@type", inventory.Type);
                cmd.Parameters.AddWithValue("@reorderLevel", inventory.ReorderLevel);
                Console.WriteLine("inserting");
                status = Repository.ExecuteQuery(cmd);
                
            }
            catch (SqlException ex)
            {
                Console.WriteLine("exception1");
                if (ex.Number == 2627)
                {                  
                    MessageBox.Show("Product Type already exists.");
                }
            }
            Console.WriteLine("exception2");
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

        public DataTable getDataForCombo(string schemaName,string tableName, string columnName)
        {
            DataTable result = null;

            string query = "SELECT DISTINCT ["+columnName+ "] FROM "+
                            "[" + schemaName + "].[" + tableName + "] ";

            result = Repository.getDataTable(query);

            return result;
        }

        public DataTable getDataForInvoiceAddItemPopup()
        {
            DataTable result = null;

            string query = "SELECT p.Product_Make, p.Product_Name, p.Product_Type, s.Unit_Price, s.Quantity FROM [Stock].[Product] p ,[Stock].[Stock_Details] s WHERE p.Product_ID=s.Product_Id";

            result = Repository.getDataTable(query);

            return result;
        }

        public DataTable getDataForInvoiceAddItemPopup(String type)
        {
            DataTable result = null;

            string query = "SELECT p.Product_Make, p.Product_Name, p.Product_Type, s.Unit_Price, s.Quantity FROM [Stock].[Product] p ,[Stock].[Stock_Details] s WHERE p.Product_ID=s.Product_Id AND p.Product_Type LIKE '%"+type+"%'";

            result = Repository.getDataTable(query);

            return result;
        }

        public bool updateInventory(Inventory inventory)
        {
            bool status = true;

            string query = "UPDATE [Stock].[Product] SET [Reorder_Level] = @reorderLevel WHERE Product_ID = @productId";

            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@productId", inventory.ProductId);
            cmd.Parameters.AddWithValue("@reorderLevel", inventory.ReorderLevel);

            status = Repository.ExecuteQuery(cmd);

            return status;
        }

        public DataTable searchInventory(string searchString)
        {
            DataTable response;

            string query = "SELECT p.Product_ID ,p.Product_Make ,p.Product_Name , p.Product_Type , p.Reorder_Level , p.Quantity FROM [Stock].[Product] p "
                            +"where (p.Product_Make LIKE  '%" + searchString + "%') or(p.Product_Name LIKE  '%" + searchString + "%') "
                            + "or(p.Product_Type LIKE  '%" + searchString + "%')";

            response = Repository.getDataTable(query);
            return response;
        }

    }
}
