using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Entities.InventoryModule
{
    public class Inventory
    {
        public int ProductId { get; set; }
        public string Make { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int ReorderLevel { get; set; }
        public int Quantity { get; set; }
    }
}
