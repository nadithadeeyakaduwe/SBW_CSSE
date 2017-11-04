using SBW.BusinessService;
using SBW.UI.Sales_n_Profit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.UI.InventoryUserControls
{
    public partial class inviocAddItemPopup : Form
    {
        invoiceService ins = new invoiceService();
        private Invoiceform IF;

        //public inviocAddItemPopup()
        //{
        //    InitializeComponent();
        //}

        public inviocAddItemPopup(Invoiceform IF)
        {
            InitializeComponent();
            this.IF = IF;
        }

        private void inventryAddItemPopup_Load(object sender, EventArgs e)
        {
            dgv_invoiceAddItemPopup.DataSource = ins.loadAddItemPopup();
        }

        private void txtbx_invenrtyAddItemPopup_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_invoiceAddItemPopup.DataSource = ins.SearchProductByType(txtbx_invenrtyAddItemPopup_ItemType.Text);

        }

        public void dgv_invoiceAddItemPopup_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            Invoiceform IF = new Invoiceform();
            ins.addToInvoiceTable(dgv_invoiceAddItemPopup.CurrentRow, IF.dvg_invoice);
            this.Close();
        }
    }
}
