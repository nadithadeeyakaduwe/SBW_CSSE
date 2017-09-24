using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.HRMModule
{
    public class Employee : EntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime Brithday { get; set; }

        public string NIC { get; set; }

        public string Email { get; set; }

        public string MobileNumber { get; set; }

        public string Address { get; set; }

    }
}
