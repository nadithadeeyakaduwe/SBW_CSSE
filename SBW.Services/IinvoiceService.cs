using SBW.Entities.SnPModule;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.Services
{
    public interface IinvoiceService
    {
        DataTable loadAddItemPopup();
        DataTable loadComboBoxProductMake();
        DataTable SearchProductByType(String type);
        void addToInvoiceTable(DataGridViewRow ID, DataGridView dgv);
        
    } 
}
