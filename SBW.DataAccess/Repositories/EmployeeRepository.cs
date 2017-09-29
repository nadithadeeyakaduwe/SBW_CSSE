using SBW.Core;
using SBW.Entities.HRMModule;
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
        //SqlConnection con = ConnectionManager.getConnection();

        //public string getEmployeeName(int id)
        //{
        //    string result = string.Empty;
        //    string query = $"SELECT Name FROM [HRM].[Employee] WHERE EmployeeID = {id}";

        //    SqlCommand cmd = new SqlCommand(query, con);

        //    con.Open();
        //    try
        //    {
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        if (reader.HasRows)
        //        {
        //            reader.Read();
        //            result = reader.GetValue(0).ToString();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        result = "error";
        //        MessageBoxHelper.showError(Properties.Resources.ConnectionError);
        //        LogHelper.Log(ex.ToString());
        //    }
        //    con.Close();
        //    return result;
        //}

        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool addEmployee(Employee employee)
        {
            bool status = true;
            string query = "INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],"
                +"[NIC],[HomeTelNo],[MobileNumber],[Gender],[MaritalStatus],[PositionID],"
                +"[DepartmentID],[CurrentSalary],[PastExperience],[Qualification],[JoinDate],"
                +"[Status],[ModifiedDate],[DateCreated]) "
                + $"VALUES (@fullname,@address,@email,@bday,@nic,@hometel,@mobile,@gender,@civilstatus,@positionID,@deptId,@basicSal,@pastExp,"
                +"@qualification,@joinDate,@status,GETDATE(),GETDATE())";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@fullname", employee.FullName);
            cmd.Parameters.AddWithValue("@address", employee.Address);
            cmd.Parameters.AddWithValue("@email", employee.Email);
            cmd.Parameters.AddWithValue("@bday", employee.Brithday);
            cmd.Parameters.AddWithValue("@nic", employee.NIC);
            cmd.Parameters.AddWithValue("@hometel", employee.HomeTel);
            cmd.Parameters.AddWithValue("@mobile", employee.MobileNumber);
            cmd.Parameters.AddWithValue("@gender", employee.Gender);
            cmd.Parameters.AddWithValue("@civilstatus", employee.CivilStatus);
            cmd.Parameters.AddWithValue("@positionID", employee.PositionID);
            cmd.Parameters.AddWithValue("@deptId", employee.DepartmentID);
            cmd.Parameters.AddWithValue("@basicSal", employee.BasicSalary);
            cmd.Parameters.AddWithValue("@pastExp", employee.PastExperience);
            cmd.Parameters.AddWithValue("@qualification", employee.Qualification);
            cmd.Parameters.AddWithValue("@joinDate", employee.JoinDate);
            cmd.Parameters.AddWithValue("@status", employee.Status);
            
            status = Repository.insert(query, cmd);
            
            return status;
        }
    }
}
