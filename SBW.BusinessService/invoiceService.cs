using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SBW.Services;
using System.Data;
using SBW.DataAccess.Repositories;
using SBW.Entities.SnPModule;
using System.Windows.Forms;

namespace SBW.BusinessService
{
    public class invoiceService : IinvoiceService
    {
        private InventoryRepository inventory;
        private InvoiceRepository invoice;
        public DataTable loadAddItemPopup()
        {
            inventory = new InventoryRepository();
            DataTable dt = inventory.getDataForInvoiceAddItemPopup();
            return dt;
        }
        public DataTable loadComboBoxProductMake() {
            invoice = new InvoiceRepository();
            DataTable dt = invoice.getProdutMake();
            return dt;
        }

        public DataTable loadComboBoxProductName(string name) {
            invoice = new InvoiceRepository();
            DataTable dt = invoice.GetProdutNameForinvoice(name);
            return dt;

        }

        public DataTable loadComboBoxProductName(string make, string name) {
            invoice = new InvoiceRepository();
            DataTable dt = invoice.GetProdutTypesForinvoice(make,name);
            return dt;
        }



        public DataTable SearchProductByType(String type) {
            inventory = new InventoryRepository();
            DataTable dt = inventory.getDataForInvoiceAddItemPopup(type);
            return dt;
        }

        public void addToInvoiceTable(DataGridViewRow ID, DataGridView dgv) {

            DataTable dt = new DataTable();
            DataRow dgvRow = dt.NewRow();

            dgvRow[1] = ID.Cells[0].Value /*+ "-" + ID.Cells[1].Value + "-" + ID.Cells[2].Value*/;
            dgvRow[5] = ID.Cells[3].Value.ToString();
            //int nRow = dgv.CurrentCell.RowIndex;

            //dgv.Rows[nRow].Selected = false;
            //dgv.Rows[++nRow].Selected = true;

            //dgv.Rows[++nRow].Selected.Cells[1].value = ID.Cells[0].Value /*+ "-" + ID.Cells[1].Value + "-" + ID.Cells[2].Value*/;
            //dgvRow[5] = ID.Cells[3].Value.ToString();

            dt.Rows.Add(dgvRow);
            dgv.DataSource = dt;


        }


    }
}
