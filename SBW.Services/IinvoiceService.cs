using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SBW.Services
{
    public interface IinvoiceService
    {
        DataTable loadAddItemPopup();
        DataTable loadComboBoxProductType();
        
    }
}
