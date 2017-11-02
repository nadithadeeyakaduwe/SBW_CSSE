using SBW.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using SBW.Core;
using SBW.DataAccess.Repositories;
using SBW.Entities.InventoryModule;

namespace SBW.BusinessService
{
    public class SupplierService : ISupplierService
    {
        private SupplierRepository repo;

        public DataTable ViewSupplierDetails()
        {
            DataTable Result = null;

            repo = new SupplierRepository();

            Result = repo.viewSupplierDetails();

            if (Result == null)
            {
                MessageBoxHelper.ShowError(CommonResource.DBRetrieveError);
            }
            return Result;
        }

        public bool AddSupplier(Supplier supplier)
        {
            bool status = true;
            repo = new SupplierRepository();

            status = repo.addSupplier(supplier);

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

        public bool UpdateSupplier(Supplier supplier)
        {
            bool status = true;

            repo = new SupplierRepository();

            status = repo.updateSupplier(supplier);

            if (status)
            {
                MessageBoxHelper.Show(CommonResource.DBUpdateSuccess);
            }
            else
            {
                MessageBoxHelper.Show(CommonResource.DBUpdateError);
            }
            return status;
        }

        public DataTable ViewSuppliedProducts(String supplierId)
        {
            DataTable Result = null;

            repo = new SupplierRepository();

            Result = repo.viewSuppliedProducts(supplierId);

            return Result;
        }

    }
}
