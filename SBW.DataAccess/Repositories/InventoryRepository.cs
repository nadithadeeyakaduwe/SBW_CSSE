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

            bool s1 = Repository.ExecuteQuery(query1);
            bool s2 = Repository.ExecuteQuery(query2);

            if (s1 == true && s2 == true)
            {
                status = true;
            }
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

        public DataTable viewStockDetails()
        {
            DataTable Response;
            string query = "SELECT p.Product_ID ,p.Product_Make ,p.Product_Name , p.Product_Type , s.Stock_Id, "
                            +"s.Supplier_ID, s.Quantity, s.Unit_Price, s.Buying_Discount, s.Date "
                            + "FROM [Stock].[Product] p, [Stock].[Stock_Details] s where p.Product_ID=s.Product_ID";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public DataTable searchStock(string make, string name, string type)
        {
            DataTable response;

            string query = "SELECT p.Product_ID ,p.Product_Make ,p.Product_Name , p.Product_Type , s.Stock_Id, "
                            + "s.Supplier_ID, s.Quantity, s.Unit_Price, s.Buying_Discount, s.Date "
                            + "FROM [Stock].[Product] p, [Stock].[Stock_Details] s where p.Product_ID=s.Product_ID and "
                            + "p.Product_Make='"+make+ "' and p.Product_Name='" + name + "' and p.Product_Type='" + type + "'";

            response = Repository.getDataTable(query);
            return response;
        }

        public DataTable getNamesForCombo(string make)
        {
            DataTable result = null;

            string query = "SELECT DISTINCT Product_Name from [Stock].[Product] where Product_Make='"+make+"' ";

            result = Repository.getDataTable(query);

            return result;
        }

        public DataTable getTypesForCombo(string make,string name)
        {
            DataTable result = null;

            string query = "SELECT DISTINCT Product_Type from [Stock].[Product] where Product_Make='" + make + "' "
                            +"and Product_Name='"+ name + "' ";

            result = Repository.getDataTable(query);

            return result;
        }


        public bool addStock(Inventory inventory,Stock stock,Supplier supplier)
        {
            bool status = false;
            try
            {
                string query1 = "select Product_ID from [Stock].[Product] where Product_Type=@type";

                string query2 = "INSERT INTO [Stock].[Stock_Details] ([Product_ID],[Supplier_ID],[Quantity],[Unit_Price],[Buying_Discount],[Date])"
                                + $"VALUES(@pId,@sId,@qty,@unitPrice,@buyingDiscount,@date)";
                string query3 = "select sum(s.Quantity) from [Stock].[Stock_Details] s, [Stock].[Product] p where s.Product_ID=p.Product_ID and p.Product_Type=@type";
                string query4 = "update [Stock].[Product] set Quantity=@qty where Product_Type=@type ";

                SqlCommand cmd1 = new SqlCommand(query1);
                cmd1.Parameters.AddWithValue("@type", inventory.Type);
                var pidObj = Repository.ExecuteScalar(cmd1);
                int productId = Convert.ToInt32(pidObj);

                SqlCommand cmd2 = new SqlCommand(query2);
                cmd2.Parameters.AddWithValue("@pId", productId);
                cmd2.Parameters.AddWithValue("@sId", supplier.SupplierId);
                cmd2.Parameters.AddWithValue("@qty", stock.Quantity);
                cmd2.Parameters.AddWithValue("@unitPrice", stock.UnitPrice);
                cmd2.Parameters.AddWithValue("@buyingDiscount", stock.BuyingDiscount);
                cmd2.Parameters.AddWithValue("@date", stock.date);
                bool status1 = Repository.ExecuteQuery(cmd2);

                SqlCommand cmd3 = new SqlCommand(query3);
                cmd3.Parameters.AddWithValue("@type", inventory.Type);
                var qtyObj = Repository.ExecuteScalar(cmd3);
                int totQty = Convert.ToInt32(qtyObj);

                SqlCommand cmd4 = new SqlCommand(query4);
                cmd4.Parameters.AddWithValue("@qty", totQty);
                cmd4.Parameters.AddWithValue("@type", inventory.Type);
                bool status2 = Repository.ExecuteQuery(cmd4);

                if (status1 == true && status2 == true)
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


    }
}
