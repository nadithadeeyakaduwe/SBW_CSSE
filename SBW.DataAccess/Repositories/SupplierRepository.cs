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
    public class SupplierRepository
    {
        public DataTable viewSupplierDetails()
        {
            DataTable Response;
            string query = " select sp.Supplier_ID,sp.Name,sp.Address,sp.email,sc.ContactNo from [Stock].[Supplier_Details] sp,[Stock].[SupplierContact] sc where sp.Supplier_ID=sc.SupplierID ";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public bool addSupplier(Supplier supplier)
        {
            bool status = false;
            try
            {
                string query1 = "INSERT INTO [Stock].[Supplier_Details] ([Name],[Address],[email])"
                    + $"VALUES(@name,@address,@email)";
                string query2 = "select Supplier_ID from [Stock].[Supplier_Details] where Name=@name and Address=@address";
                string query3 = "insert into [Stock].[SupplierContact] ([SupplierID], [ContactNo]) "
                    + $"values(@supplierId,@contactNo)";

                SqlCommand cmd1 = new SqlCommand(query1);
                cmd1.Parameters.AddWithValue("@name", supplier.Name);
                cmd1.Parameters.AddWithValue("@address", supplier.Address);
                cmd1.Parameters.AddWithValue("@email", supplier.email);

                bool status1 = Repository.ExecuteQuery(cmd1);

                SqlCommand cmd2 = new SqlCommand(query2);
                cmd2.Parameters.AddWithValue("@name", supplier.Name);
                cmd2.Parameters.AddWithValue("@address", supplier.Address);

                var obj = Repository.ExecuteScalar(cmd2);
                int supplierId = Convert.ToInt32(obj);

                SqlCommand cmd3 = new SqlCommand(query3);
                cmd3.Parameters.AddWithValue("@supplierId", supplierId);
                cmd3.Parameters.AddWithValue("@contactNo", supplier.ContactNo);

                bool status2 = Repository.ExecuteQuery(cmd3);

                if (status1 == true && status2 == true)
                {
                    status = true;
                }

            }
            catch (SqlException ex)
            {
                //Console.WriteLine("exception1");
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Supplier already exists.");
                }
            }
            //Console.WriteLine("exception2");
            return status;
        }

        public bool updateSupplier(Supplier supplier)
        {
            bool status = true;

            string query1 = "UPDATE [Stock].[Supplier_Details] SET [Name] = @name, [Address]= @address, [email]=@email WHERE Supplier_ID = @supplierId";
            string query2 = "UPDATE [Stock].[SupplierContact] SET [ContactNo] = @contactNo WHERE SupplierID = @supplierId";


            SqlCommand cmd1 = new SqlCommand(query1);
            cmd1.Parameters.AddWithValue("@name", supplier.Name);
            cmd1.Parameters.AddWithValue("@address", supplier.Address);
            cmd1.Parameters.AddWithValue("@email", supplier.email);
            cmd1.Parameters.AddWithValue("@supplierId", supplier.SupplierId);

            SqlCommand cmd2 = new SqlCommand(query2);
            cmd2.Parameters.AddWithValue("@supplierId", supplier.SupplierId);
            cmd2.Parameters.AddWithValue("@contactNo", supplier.ContactNo);

            bool status1 = Repository.ExecuteQuery(cmd1);
            bool status2 = Repository.ExecuteQuery(cmd2);

            if (status1 == true && status2 == true)
            {
                status = true;
            }

            return status;
        }

        public DataTable viewSuppliedProducts(String supplierId)
        {
            DataTable Response;
            string query = " select * from [Stock].[Product] sp,[Stock].[Stock_Details] ss where sp.Product_ID=ss.Product_ID and ss.Supplier_ID ='"+supplierId+"' ";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public bool deleteSupplier(int supplierId)
        {
            bool status = true;

            string query1 = $"DELETE FROM [Stock].[SupplierContact] WHERE SupplierID = {supplierId}";
            string query2 = $"DELETE FROM [Stock].[Supplier_Details] WHERE Supplier_ID = {supplierId}";       

            bool status1 = Repository.ExecuteQuery(query1);
            bool status2 = Repository.ExecuteQuery(query2);

            if (status1 == true && status2 == true)
            {
                status = true;
            }

            return status;
        }

        public DataTable searchSupplier(string searchString)
        {
            DataTable response;

            string query = "SELECT ss.Supplier_ID ,ss.Name ,ss.Address , ss.email , sc.ContactNo FROM [Stock].[Supplier_Details] ss, [Stock].[SupplierContact] sc "
                            + "where (ss.Supplier_ID=sc.SupplierID and ss.Name LIKE '%" + searchString + "%') ";

            response = Repository.getDataTable(query);
            return response;
        }

    }
}
