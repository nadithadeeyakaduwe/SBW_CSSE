using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.SnPModule
{
    public class InvoiceDetails
    {
        public int itemNo { set; get; }
        public int invoiceNo { set; get; }
        public String productDescription { set; get; }
        public int qty { set; get; }
        public decimal unitPrice { set; get; }
        public decimal discount { set; get; }
        public String warrenty { set; get; }
        public decimal amount { set; get; }
    }
}
