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

        DataTable LoadComboBox(string schemaName,string tableName, string columnName);

        bool UpdateInventory(Inventory inventory);
        DataTable SearchInventory(string searchString);

        DataTable ViewStockDetails();
        DataTable SearchStock(string make, string name, string type);

        DataTable getNamesForCombo(string make);
        DataTable getTypesForCombo(string make, string name);

        bool AddStock(Inventory inventory, Stock stock, Supplier supplier);

    }
}
