using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.HRMModule
{
    public class Employee : EntityBase
    {
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>
        /// The first name.
        /// </value>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the brithday.
        /// </summary>
        /// <value>
        /// The brithday.
        /// </value>
        public DateTime Brithday { get; set; }

        /// <summary>
        /// Gets or sets the nic.
        /// </summary>
        /// <value>
        /// The nic.
        /// </value>
        public string NIC { get; set; }

        /// <summary>
        /// Gets or sets the email.
        /// </summary>
        /// <value>
        /// The email.
        /// </value>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the mobile number.
        /// </summary>
        /// <value>
        /// The mobile number.
        /// </value>
        public string MobileNumber { get; set; }

        /// <summary>
        /// Gets or sets the address.
        /// </summary>
        /// <value>
        /// The address.
        /// </value>
        public string Address { get; set; }

        /// <summary>
        /// Gets or sets the basic salary.
        /// </summary>
        /// <value>
        /// The basic salary.
        /// </value>
        public decimal BasicSalary { get; set; }

        /// <summary>
        /// Gets or sets the home tel.
        /// </summary>
        /// <value>
        /// The home tel.
        /// </value>
        public string HomeTel { get; set; }

        /// <summary>
        /// Gets or sets the position identifier.
        /// </summary>
        /// <value>
        /// The position identifier.
        /// </value>
        public int PositionID { get; set; }

        /// <summary>
        /// Gets or sets the past experience.
        /// </summary>
        /// <value>
        /// The past experience.
        /// </value>
        public string PastExperience { get; set; }

        /// <summary>
        /// Gets or sets the qualification.
        /// </summary>
        /// <value>
        /// The qualification.
        /// </value>
        public string Qualification { get; set; }

        /// <summary>
        /// Gets or sets the gender.
        /// </summary>
        /// <value>
        /// The gender.
        /// </value>
        public char Gender { get; set; }

        /// <summary>
        /// Gets or sets the civil status.
        /// </summary>
        /// <value>
        /// The civil status.
        /// </value>
        public char CivilStatus { get; set; }

        /// <summary>
        /// Gets or sets the join date.
        /// </summary>
        /// <value>
        /// The join date.
        /// </value>
        public DateTime JoinDate { get; set; }

        /// <summary>
        /// Gets or sets the department identifier.
        /// </summary>
        /// <value>
        /// The department identifier.
        /// </value>
        public int DepartmentID { get; set; }

        /// <summary>
        /// Gets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        
    }
}
