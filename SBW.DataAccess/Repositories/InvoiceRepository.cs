using SBW.Core;
using SBW.Entities.SnPModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class InvoiceRepository
    {

        static SqlConnection con = ConnectionManager.getConnection();
        

        public bool addInvoice(InvoiceHeader IH, InvoiceDetails ID) {
            bool status = true;


            try
            {
                string invoiceHeaderQuery = "INSERT INTO [Accounts].[Invoice_Header] ([SDate],[Customer_Name],[Customer_Address],[Customer_Telephone])"
                                        + $"VALUES (@date,@cusname,@cusaddress,@telephone,@totamount)";

                string invoiceDetailQuery = "[Accounts].[Invoice_Details]([Invoice_No],[Product_Description],[QTY],[Unit_Price],[Discount],[Warrenty],[Amount])"
                                        + $"VALUES (@invoicenumber,@productdescription,@qty,@unitprice,@discount,@warrenty,@amount)";

                SqlCommand cm1 = new SqlCommand(invoiceHeaderQuery);
                cm1.Parameters.AddWithValue("@date", IH.sDate);
                cm1.Parameters.AddWithValue("@cusname", IH.customerName);
                cm1.Parameters.AddWithValue("@cusaddress", IH.customerAddress);
                cm1.Parameters.AddWithValue("@telephone", IH.customerTelephone);
                cm1.Parameters.AddWithValue("@totamount", IH.totalAmount);


                SqlCommand cm2 = new SqlCommand(invoiceDetailQuery);
                cm2.Parameters.AddWithValue("@invoicenumber", ID.invoiceNo);
                cm2.Parameters.AddWithValue("@productdescription", ID.productDescription);
                cm2.Parameters.AddWithValue("@qty", ID.qty);
                cm2.Parameters.AddWithValue("@unitprice", ID.unitPrice);
                cm2.Parameters.AddWithValue("@discount", ID.discount);
                cm2.Parameters.AddWithValue("@warrenty", ID.warrenty);
                cm2.Parameters.AddWithValue("@amount", ID.amount);

                bool s1 = Repository.ExecuteQuery(cm1);
                bool s2 = Repository.ExecuteQuery(cm2);

                if (s1 == true && s2 == true)
                {
                    status = true;
                }
            }
            catch(SqlException ex)
            {
                throw ex;
            }

            return status;
        }






        public DataTable getProdutMake()
        {
            DataTable Response;
            string query = "SELECT DISTINCT p.Product_Make FROM [Stock].[Product] p";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public DataTable GetProdutTypesForinvoice(string make, string name)
        {
            DataTable Response;
            string query = "SELECT p.Product_Type FROM [Stock].[Product] p where p.Product_Make = '"+make+"' AND p.Product_Name = '"+name+"'";

            Response = Repository.getDataTable(query);

            return Response;
        }

        public DataTable GetProdutNameForinvoice(string make)
        {
            DataTable Response;
            string query = "SELECT DISTINCT p.Product_Name FROM [Stock].[Product] p where p.Product_Make = '" + make + "'" ;

            Response = Repository.getDataTable(query);

            return Response;
        }

        public int GetNextInvoiceNumber() {

            int invoiceNum = 0;
            string query = "SELECT [Invoice_No] FROM [Accounts].[Invoice_Header] ORDER BY [Invoice_No] DESC LIMIT 1";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader;
            cmd.Connection = con;

            try
            {
                Repository.openConnection();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // read first row
                    invoiceNum = reader.GetInt32(0);
                }

            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.ToString());
                invoiceNum = 0;
            }
            finally
            {
                Repository.closeConnection();
            }

           
            return invoiceNum+1;

        }

        public decimal GetUnitpriceforProduct(string type)
        {

            decimal unitPrice = 0;
            string query = "SELECT TOP 1 s.Unit_Price FROM [Stock].[Stock_Details] s, [Stock].[Product] p WHERE s.[Product_ID]=p.[Product_ID] AND p.[Product_Type] = '"+type+ "' ORDER BY s.Unit_Price DESC";
            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader;
            cmd.Connection = con;

            try
            {
                Repository.openConnection();

                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read(); // read first row
                    unitPrice = reader.GetDecimal(0);
                }

            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.ToString());
                unitPrice = 0;
            }
            finally
            {
                Repository.closeConnection();
            }


            return unitPrice;

        }






    }
}
