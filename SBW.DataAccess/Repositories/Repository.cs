using SBW.Core;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static bool insert(string query)
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
            con.Close();

            return status;
        }

        public static bool insert(string query, SqlCommand cmd)
        {
            bool status = false;
            //cmd.CommandText = query;
            cmd.Connection = con;

            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    status = true;
                }
            }
            catch (Exception ex)
            {
                LogHelper.Log(ex.ToString());
            }
            con.Close();

            return status;
        }
    }
}
