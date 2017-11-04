﻿using SBW.Entities.SnPModule;
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
        DataTable loadComboBoxProductName(string name);
        DataTable loadComboBoxProductName(string make, string name);
        DataTable SearchProductByType(String type);
        void addToInvoiceTable(DataGridViewRow ID, DataGridView dgv);
        DataGridView fillInvoiceTable(string make, string name, string type, DataGridView dgv);
        int fillInvoiceNumber();
        bool addInvoiceHeader(InvoiceHeader inHeader);
        bool addInvoicedetails(InvoiceDetails inDetails);

    }
}
