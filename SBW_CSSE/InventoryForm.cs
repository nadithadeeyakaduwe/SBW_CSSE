using SBW.UI.Common;
using SBW.UI.InventoryUserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SBW.UI
{
    public partial class InventoryForm : Form
    {
        public InventoryForm()
        {
            InitializeComponent();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_inventoryUC_Click(object sender, EventArgs e)
        {
            //Helper.ShowForm(new InventoryDetailsForm());
            loadForm(new InventoryDetailsForm());
        }

        private void btn_supplierUC_Click(object sender, EventArgs e)
        {
            //loadUserControl(new SupplierDetailsForm());
        }

        private void btn_stockUC_Click(object sender, EventArgs e)
        {
            //loadUserControl(new StockDetailsForm());
        }

        private void loadUserControl(Form userControl)
        {
            panel_InventoryForm.Controls.Clear();
            //userControl.TopLevel = false;
            panel_InventoryForm.Controls.Add(userControl);
            userControl.Dock = DockStyle.Fill;
            userControl.Show();
        }

        private void loadForm(Form form)
        {
            panel_InventoryForm.Controls.Clear();
            form.TopLevel = false;
            panel_InventoryForm.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }


    }
}
