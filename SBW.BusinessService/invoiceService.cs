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
        private InventoryRepository inv;
        public DataTable loadAddItemPopup()
        {
            inv = new InventoryRepository();
            DataTable dt = inv.getDataForInvoiceAddItemPopup();
            return dt;
        }
        public DataTable loadComboBoxProductMake() {
            InvoiceRepository InvoiceR = new InvoiceRepository();
            DataTable dt = InvoiceR.getProdutMake();
            return dt;
        }
        public DataTable SearchProductByType(String type) {
            InventoryRepository IR = inv = new InventoryRepository();
            DataTable dt = IR.getDataForInvoiceAddItemPopup(type);
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
