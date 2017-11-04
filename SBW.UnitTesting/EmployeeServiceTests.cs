using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBW.BusinessService;
using SBW.DataAccess;
using SBW.Entities.HRMModule;
using SBW.Services;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.UnitTesting
{
    [TestClass()]
    public class EmployeeServiceTests
    {
        [TestMethod()]
        public void AddEmployeeTest()
        {
            Employee employee = new Employee()
            {
                FullName = "Test Employee",
                Address = "addressAddresss",
                BasicSalary = Convert.ToDecimal("25000.00"),
                EPFNo = 24,
                Email = "test@gmail.com",
                HomeTel = "0112729729",
                MobileNumber = "0741258963",
                PositionID = 1,
                PastExperience = "Past Experience",
                Qualification = "Qualifications",
                NIC = "950325598V",
                Gender = 'M',
                CivilStatus = 'S',
                Brithday = DateTime.Today,
                JoinDate = DateTime.Today,
                DepartmentID = 0
            };

            IEmployeeService service = ServiceFactory.GetEmployeeSeriveice();
            if (service.AddEmployee(employee))
            {
                string query = $"SELECT * FROM [HRM].[Employee] WHERE EPFNo = {employee.EPFNo}";

                string connectionString = @"Data Source=.\ESHANSQLEXP;Initial Catalog=SarangaBatteryWork;User Id=sa;Password=10170545";
                SqlConnection con = new SqlConnection(connectionString);

                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader;
                try
                {
                    con.Open();
                    reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        Assert.IsTrue(true);
                    }
                }
                catch
                {
                    Assert.Fail();
                }
                finally
                {
                    con.Close();
                }
            }
            else
            {
                Assert.Fail();
            }
        }
    }
}