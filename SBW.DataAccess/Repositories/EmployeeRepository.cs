using SBW.Core;
using SBW.DataAccess.Enum;
using SBW.Entities.HRMModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.DataAccess.Repositories
{
    public class EmployeeRepository
    {
        /// <summary>
        /// Adds the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool addEmployee(Employee employee)
        {
            bool status = true;
            string query = "INSERT INTO [HRM].[Employee] ([Name],[Address],[Email],[DOB],"
                + "[NIC],[HomeTelNo],[MobileNumber],[Gender],[CivilStatus],[EpfNo],[PositionID],"
                + "[DepartmentID],[BasicSalary],[PastExperience],[Qualification],[JoinDate],"
                + "[Status],[ModifiedDate],[DateCreated]) "
                + $"VALUES (@fullname,@address,@email,@bday,@nic,@hometel,@mobile,@gender,@civilstatus,@epf,@positionID,@deptId,@basicSal,@pastExp,"
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
            cmd.Parameters.AddWithValue("@epf", employee.EPFNo);
            cmd.Parameters.AddWithValue("@positionID", employee.PositionID);
            cmd.Parameters.AddWithValue("@deptId", employee.DepartmentID);
            cmd.Parameters.AddWithValue("@basicSal", employee.BasicSalary);
            cmd.Parameters.AddWithValue("@pastExp", employee.PastExperience);
            cmd.Parameters.AddWithValue("@qualification", employee.Qualification);
            cmd.Parameters.AddWithValue("@joinDate", employee.JoinDate);
            cmd.Parameters.AddWithValue("@status", employee.Status);
            
            status = Repository.ExecuteQuery(cmd);
            
            return status;
        }

        /// <summary>
        /// Views the employees with titles.
        /// </summary>
        /// <returns></returns>
        public DataTable viewEmployeesWithTitles()
        {
            DataTable Response;
            string query = "SELECT e.EmployeeID As EmployeeID,e.EpfNo AS EpfNo, e.Name As Name, p.Name AS Title, d.Name AS Department FROM [HRM].[Employee] e"
                +" INNER JOIN[HRM].[Position] p ON p.PositionID = e.PositionID"
                +" INNER JOIN[HRM].[Department] d ON e.DepartmentID = d.DepartmentID WHERE e.Status = "+ (int)WellknownEmployeeStatus.Active;

            Response = Repository.getDataTable(query);

            return Response;
        }

        /// <summary>
        /// Gets the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public DataTable getEmployee(int employeeId)
        {
            DataTable response = null;
            string query = "SELECT e.[EmployeeID],e.[Name],e.[Address],e.[Email],e.[DOB],e.[NIC],e.[HomeTelNo],e.[MobileNumber],e.[Gender],e.[CivilStatus],"
                + "e.[EpfNo],e.[PositionID],e.[DepartmentID],e.[BasicSalary],e.[PastExperience],e.[Qualification],e.[JoinDate],e.[Status],p.[Name],d.[Name]"
                + $" FROM [HRM].[Employee] e, [HRM].[Department] d, [HRM].[Position] p WHERE e.EmployeeID = {employeeId} AND p.PositionID = e.PositionID"
                + " AND d.DepartmentID = e.DepartmentID";

            response = Repository.getDataTable(query);

            return response;
        }

        /// <summary>
        /// Deletes the employee.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns></returns>
        public bool deleteEmployee(int employeeId)
        {
            bool status = true;

            string query = $"UPDATE [HRM].[Employee] SET[Status] = {(int)WellknownEmployeeStatus.Unemployeed},"
                +$" [ModifiedDate] = GETDATE() WHERE EmployeeID = {employeeId}";

            status = Repository.ExecuteQuery(query);

            return status;
        }

        /// <summary>
        /// Updates the employee.
        /// </summary>
        /// <param name="employee">The employee.</param>
        /// <returns></returns>
        public bool updateEmployee(Employee employee)
        {
            bool status = true;

            string query = "UPDATE [HRM].[Employee] SET [Address] = @address, [Email] = @email," 
                +" [HomeTelNo] = @home, [MobileNumber] = @mobile, [CivilStatus] = @civilstatus, [EpfNo] = @epfno,"
                +" [PastExperience] = @pastexp, [Qualification] = @qualification,"
                +" [Status] = @status ,[ModifiedDate] = GETDATE() WHERE EmployeeID = @empNo";

            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@address", employee.Address);
            cmd.Parameters.AddWithValue("@email", employee.Email);
            cmd.Parameters.AddWithValue("@home", employee.HomeTel);
            cmd.Parameters.AddWithValue("@mobile", employee.MobileNumber);
            cmd.Parameters.AddWithValue("@civilstatus", employee.CivilStatus);
            cmd.Parameters.AddWithValue("@epfno", employee.EPFNo);
            cmd.Parameters.AddWithValue("@status", employee.Status);
            cmd.Parameters.AddWithValue("@empNo", employee.EmployeeID);
            cmd.Parameters.AddWithValue("@pastexp", employee.PastExperience);
            cmd.Parameters.AddWithValue("@qualification", employee.Qualification);

            status = Repository.ExecuteQuery(cmd);

            return status;
        }

        /// <summary>
        /// Searches the employee.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        public DataTable searchEmployee(string searchString)
        {
            DataTable response = null;

            string query = "SELECT e.EmployeeID As EmployeeID,e.EpfNo AS EpfNo, e.Name As Name, p.Name AS Title,"
                + " d.Name AS Department FROM [HRM].[Employee] e INNER JOIN[HRM].[Position] p"
                + " ON p.PositionID = e.PositionID INNER JOIN[HRM].[Department] d"
                + " ON e.DepartmentID = d.DepartmentID WHERE e.Status = " + (int)WellknownEmployeeStatus.Active
                +$" AND (e.Name LIKE '%{searchString}%' OR e.NIC LIKE '{searchString}%')";

            response = Repository.getDataTable(query);

            return response;
        }

        /// <summary>
        /// Gets the position for combo.
        /// </summary>
        /// <returns></returns>
        public DataTable getPositionForCombo()
        {
            DataTable result = null;

            string query = "SELECT [PositionID], [Name] FROM [HRM].[Position] WHERE [Status] = " + (int)WellknownPositionStatus.Active;

            result = Repository.getDataTable(query);

            return result;
        }

        /// <summary>
        /// Gets the department for combo.
        /// </summary>
        /// <returns></returns>
        public DataTable getDepartmentForCombo()
        {
            DataTable result = null;

            string query = "SELECT [DepartmentID], [Name] FROM [HRM].[Department] WHERE [Status] = " + (int)WellknownDepartmentStatus.Active;

            result = Repository.getDataTable(query);

            return result;
        }

        /// <summary>
        /// Promotes the employee.
        /// </summary>
        /// <param name="promotionDto">The promotion dto.</param>
        /// <returns></returns>
        public bool promoteEmployee(EmployeePromotionDto promotionDto)
        {
            bool status = true;

            SqlCommand cmd = new SqlCommand()
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "[HRM].[PromoteEmployee]"
            };

            cmd.Parameters.AddWithValue("@EmployeeID", promotionDto.EmployeeID);
            cmd.Parameters.AddWithValue("@NewPositionID", promotionDto.NewPositionID);
            cmd.Parameters.AddWithValue("@NewSalary", promotionDto.NewSalary);
            cmd.Parameters.AddWithValue("@Reason", promotionDto.Reason);
            cmd.Parameters.AddWithValue("@Status", promotionDto.Status);

            status = Repository.ExecuteQuery(cmd);

            return status;
        }

        /// <summary>
        /// Gets the promotion details.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public DataTable getPromotionDetails(int employeeID)
        {
            DataTable result = null;

            string query = "SELECT [EffectiveDate],po.Name AS 'NewPosition',p.Name AS 'OldPosition',ep.[OldSalary],ep.[NewSalary],ep.[Status],ep.[Reason]"
                + " FROM [HRM].[EmployeePerformance] ep INNER JOIN HRM.Position p ON ep.OldPosition = p.PositionID"
                + " INNER JOIN HRM.Position po ON ep.NewPosition = po.PositionID"
                +$" WHERE ep.[EmployeeID] = {employeeID}";

            result = Repository.getDataTable(query);

            return result;
        }

        /// <summary>
        /// Gets the employeeattendance.
        /// </summary>
        /// <param name="employeeID">The employee identifier.</param>
        /// <param name="date">The date.</param>
        /// <returns></returns>
        public DataTable getEmployeeattendance(int employeeID, DateTime date)
        {
            DataTable response = null;

            string query = "SELECT [EmployeeID],[InTime],[InNote],[OutTime],[OutNote],[Duration],[LateTime],[Status],[ModifiedDate],[DateCreated]"
                +$" FROM [HRM].[EmployeeAttendance] WHERE [EmployeeID] = @empID AND CAST([InTime] AS DATE) = @date";

            SqlCommand cmd = new SqlCommand(query);
            cmd.Parameters.AddWithValue("@empID", employeeID);
            cmd.Parameters.Add(new SqlParameter("@date", date));
            //cmd.Parameters.AddWithValue("@date", date);

            response = Repository.getDataTable(cmd);

            return response;
        }

        public bool punchIn(EmployeeAttendanceDto employeeAttendanceDto)
        {
            bool status = true;
            string query = "INSERT INTO [HRM].[EmployeeAttendance] ([EmployeeID],[InTime],[InNote],[Status],[ModifiedDate],[DateCreated])"
                + " VALUES (@empID,@inTime,@inNote,@status,@modifiedDt,@DtCreated)";

            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@empID", employeeAttendanceDto.EmployeeID);
            cmd.Parameters.AddWithValue("@inTime", employeeAttendanceDto.InTime);
            cmd.Parameters.AddWithValue("@inNote", employeeAttendanceDto.InNote);
            cmd.Parameters.AddWithValue("@modifiedDt", employeeAttendanceDto.ModifiedDate);
            cmd.Parameters.AddWithValue("@DtCreated", employeeAttendanceDto.DateCreated);
            cmd.Parameters.AddWithValue("@status", employeeAttendanceDto.Status);

            status = Repository.ExecuteQuery(cmd);

            return status;
        }

        public bool punchOut(EmployeeAttendanceDto employeeAttendanceDto)
        {
            bool status = true;

            string query = "UPDATE [HRM].[EmployeeAttendance] SET [OutTime] = @outTime, [OutNote] = @outNote, [Status] = @status, [ModifiedDate] = @modifiedDt"
                + " WHERE [EmployeeID] = @empID AND CAST([InTime] AS DATE) = @inDate";

            SqlCommand cmd = new SqlCommand(query);

            cmd.Parameters.AddWithValue("@empID", employeeAttendanceDto.EmployeeID);
            cmd.Parameters.AddWithValue("@outTime", employeeAttendanceDto.OutTime);
            cmd.Parameters.AddWithValue("@outNote", employeeAttendanceDto.OutNote);
            cmd.Parameters.AddWithValue("@modifiedDt", employeeAttendanceDto.ModifiedDate);
            cmd.Parameters.AddWithValue("@status", employeeAttendanceDto.Status);
            cmd.Parameters.Add(new SqlParameter("@inDate", DateTime.Today));

            status = Repository.ExecuteQuery(cmd);

            return status;
        }
    }
}
