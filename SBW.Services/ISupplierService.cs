using SBW.Entities.InventoryModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Services
{
    public interface ISupplierService
    {
        DataTable ViewSupplierDetails();

        bool AddSupplier(Supplier supplier);

        bool UpdateSupplier(Supplier supplier);

        DataTable ViewSuppliedProducts(String supplierId);

    }
}
