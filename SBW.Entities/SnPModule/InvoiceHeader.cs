using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.SnPModule
{
    public class InvoiceHeader
    {
        public int invoiceNo { set; get; }
        public DateTime sDate { set; get; }
        public String customerName { set; get; }
        public String customerAddress { set; get; }
        public String customerTelephone { set; get; }
        public decimal totalAmount { set; get; }

    }
}
