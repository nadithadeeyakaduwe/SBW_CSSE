using SBW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBW.Entities.InventoryModule;
using System.Data;
using SBW.Core;
using SBW.DataAccess.Repositories;

namespace SBW.BusinessService
{
    public class InventoryService : IInventoryService
    {
        private InventoryRepository repo;

        public bool AddInventory(Inventory inventory)
        {
            bool status = true;
            repo = new InventoryRepository();

            status = repo.addInventory(inventory);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBInsertError);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBInsertSuccess);     
            }

            return status;
        }

        public DataTable ViewInventoryItems()
        {
            DataTable Result = null;

            repo = new InventoryRepository();

            Result = repo.viewInventoryItems();

            if (Result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }
            return Result;
        }

        public bool DeleteInventory(int productId)
        {
            bool status = true;

            repo = new InventoryRepository();

            status = repo.deleteInventory(productId);

            if (!status)
            {
                MessageBoxHelper.ShowError(CommonResource.DBDeleteError);
            }

            return status;
        }
    }
}
