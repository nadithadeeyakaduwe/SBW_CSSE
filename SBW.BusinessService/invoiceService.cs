using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBW.Services;
using System.Data;
using SBW.DataAccess.Repositories;

namespace SBW.BusinessService
{
    public class invoiceService : IinvoiceService
    {
        private InventoryRepository inv;
        public DataTable loadAddItemPopup()
        {
            inv = new InventoryRepository();
            DataTable dt = inv.getDataForInvoiceAddItemPopup();
            return dt;
        }
        public DataTable loadComboBoxProductType() {
            InvoiceRepository InvoiceR = new InvoiceRepository();
            DataTable dt = InvoiceR.GetProdutTypes();
            return dt;
        }
        public DataTable SearchProductByType(String type) {
            InventoryRepository IR = inv = new InventoryRepository();
            DataTable dt = IR.getDataForInvoiceAddItemPopup(type);
            return dt;
        }


    }
}
