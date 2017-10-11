using SBW.Core;
using System;
using System.Data;
using System.Data.SqlClient;

namespace SBW.DataAccess.Repositories
{
    public class Repository
    {
        /// <summary>
        /// Setting up the connection with the sql srver
        /// </summary>
        static SqlConnection con = ConnectionManager.getConnection();

        /// <summary>
        /// Inserts the specified query.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns></returns>
        public static bool ExecuteQuery(string query)
        {
            bool status = false;
            SqlCommand cmd = new SqlCommand(query,con);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    status = true;
                }
            }
            catch(Exception ex)
            {
                LogHelper.Log(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            

            return status;
        }

        /// <summary>
        /// Inserts the specified query with query parameters.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <param name="cmd">The command.</param>
        /// <returns></returns>
        public static bool ExecuteQuery(SqlCommand cmd)
        {
            bool status = false;
            cmd.Connection = con;
            int NoOfRowsExecuted;
            try
            {
                con.Open();
                NoOfRowsExecuted = cmd.ExecuteNonQuery();

                if (NoOfRowsExecuted > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.ToString());
            }
            finally
            {
                con.Close();
            }
            

            return status;
        }

        /// <summary>
        /// Gets the data table.
        /// </summary>
        /// <param name="query">The query.</param>
        /// <returns>
        /// returns data using a DataTable
        /// /returns>
        public static DataTable getDataTable(string query)
        {
            DataTable dataTable = new DataTable();
            SqlDataReader reader;
            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            catch(Exception ex)
            {
                LogHelper.Log(ex.ToString());
                dataTable = null;
            }
            finally
            {
                con.Close();
            }

            return dataTable;
        }

    }
}
