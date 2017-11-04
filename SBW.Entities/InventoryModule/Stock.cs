using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.InventoryModule
{
    public class Stock
    {
        public int StockId { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal BuyingDiscount { get; set; }
        public int Quantity { get; set; }
        public DateTime date { get; set; }
    }
}
