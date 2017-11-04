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

        public DataGridView fillInvoiceTable(string make, string name, string type, DataGridView dgv) {
            int itemNo = dgv.RowCount;
            //dgv.ColumnCount = 8;
            dgv.Rows[itemNo-1].Cells[0].Value =  (itemNo + 1).ToString();
            dgv.Rows[itemNo-1].Cells[1].Value = $"{make} {name} {type}";

            invoice = new InvoiceRepository();

            dgv.Rows[itemNo-1].Cells[5].Value = invoice.GetUnitpriceforProduct(type).ToString();

            //dgv[itemNo, 0].Value = (itemNo + 1).ToString();
            //dgv[itemNo, 1].Value = $"{make} {name} {type}";
            //dgv[itemNo, 5].Value = invoice.GetUnitpriceforProduct(type);


            return dgv;
        }

        public int fillInvoiceNumber() {
            int invoiceNum = invoice.GetNextInvoiceNumber();
            return invoiceNum;

        }


    }
}
