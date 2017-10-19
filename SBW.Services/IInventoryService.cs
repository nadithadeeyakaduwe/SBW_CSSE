using SBW.Entities.InventoryModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Services
{
    public interface IInventoryService
    {
        DataTable ViewInventoryItems();
        bool AddInventory(Inventory inventory);
        bool DeleteInventory(int productId);
    }
}
