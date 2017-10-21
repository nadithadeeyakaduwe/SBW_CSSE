using SBW.BusinessService;
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
        public inviocAddItemPopup()
        {
            InitializeComponent();
        }

        private void inventryAddItemPopup_Load(object sender, EventArgs e)
        {
            dgv_invoiceAddItemPopup.DataSource = ins.loadAddItemPopup();
        }

        private void txtbx_invenrtyAddItemPopup_ItemType_KeyPress(object sender, KeyPressEventArgs e)
        {
            dgv_invoiceAddItemPopup.DataSource = ins.SearchProductByType(txtbx_invenrtyAddItemPopup_ItemType.Text);

        }
    }
}
