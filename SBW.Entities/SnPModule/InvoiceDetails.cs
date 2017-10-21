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
        public float unitPrice { set; get; }
        public float discount { set; get; }
        public String warrenty { set; get; }
        public float amount { set; get; }
    }
}
