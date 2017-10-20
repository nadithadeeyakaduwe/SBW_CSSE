using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.CustomerModule
{
    public class Customer
    {
        public string NIC { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string CustomerType { get; set; }
        public int Rate { get; set; }
        public string CardType { get; set; }
        public int CardPoints { get; set; }
        public string CardNo { get; set; }
    }
}
