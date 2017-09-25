using SBW.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class EmployeeRepository
    {
        SqlConnection con = ConnectionManager.getConnection();

        public string getEmployeeName(int id)
        {
            string result = string.Empty;
            string query = $"SELECT Name FROM [HRM].[Employee] WHERE EmployeeID = {id}";

            SqlCommand cmd = new SqlCommand(query, con);

            con.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    result = reader.GetValue(0).ToString();
                }
            }
            catch (Exception ex)
            {
                result = "error";
                MessageBoxHelper.showError(Properties.Resources.ConnectionError);
                LogHelper.Log(ex.ToString());
            }
            con.Close();
            return result;
        }
    }
}
