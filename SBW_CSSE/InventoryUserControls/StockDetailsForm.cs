using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.Services;
using SBW.BusinessService;
using SBW.Entities.InventoryModule;

namespace SBW.UI.InventoryUserControls
{
    public partial class StockDetailsForm : Form
    {
        private IInventoryService service;

        public StockDetailsForm()
        {
            InitializeComponent();
        }

        private void lbl_inventoryUC_reorderLevel_Click(object sender, EventArgs e)
        {

        }

        private void txt_inventoryUC_reorder_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void StockDetailsForm_Load(object sender, EventArgs e)
        {
            service = ServiceFactory.GetInventoryService();
            FillStockGrid();
            btn_stockUC_update.Enabled = false;
            btn_stockUC_delete.Enabled = false;

            cmb_stockUC_make.DataSource = service.LoadComboBox("Stock", "Product", "Product_Make");
            cmb_stockUC_make.DisplayMember = "Product_Make";
            cmb_stockUC_make.SelectedIndex = -1;

            txtINsupplier.DataSource = service.LoadComboBox("Stock", "Supplier_Details", "Supplier_ID");
            txtINsupplier.DisplayMember = "Supplier_ID";
            txtINsupplier.SelectedIndex = -1;

        }

        //Filling Stock Grid
        public void FillStockGrid()
        {
            service = ServiceFactory.GetInventoryService();

            DataTable dt = null;

            dt = service.ViewStockDetails();

            dgv_stockUC_stock.DataSource = dt;

        }

        private void btn_stockUC_search_Click(object sender, EventArgs e)
        {
            string make = cmb_stockUC_make.Text;
            string name = cmb_stockUC_name.Text;
            string type = cmb_stockUC_type.Text;

            service = ServiceFactory.GetInventoryService();

            dgv_stockUC_stock.DataSource = service.SearchStock(make, name, type);
        }

        private void cmb_stockUC_make_SelectedIndexChanged(object sender, EventArgs e)
        {
            service = ServiceFactory.GetInventoryService();

            cmb_stockUC_name.Text = "";
            cmb_stockUC_type.Text = "";
            string make = cmb_stockUC_make.Text;

            cmb_stockUC_name.DataSource = service.getNamesForCombo(make);
            cmb_stockUC_name.DisplayMember = "Product_Name";
            cmb_stockUC_name.SelectedIndex = -1;

        }

        private void cmb_stockUC_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            service = ServiceFactory.GetInventoryService();
            
            cmb_stockUC_type.Text = "";
            string make = cmb_stockUC_make.Text;
            string name = cmb_stockUC_name.Text;

            cmb_stockUC_type.DataSource = service.getTypesForCombo(make,name);
            cmb_stockUC_type.DisplayMember = "Product_Type";
            cmb_stockUC_type.SelectedIndex = -1;
        }

        //Clear Inventory
        public void ClearStock()
        {
            cmb_stockUC_make.DataSource = service.LoadComboBox("Stock", "Product", "Product_Make");
            cmb_stockUC_make.DisplayMember = "Product_Make";
            cmb_stockUC_make.SelectedIndex = -1;

            txt_stockUC_unitPrice.Text = "";

            txt_stockUC_discount.Text = "";

            txt_stockUC_qty.Text = "";

            dtp_stockUC.Value = DateTime.Now;

            txtINsupplier.SelectedIndex = -1;

            FillStockGrid();

        }

        private void btn_stockUC_clear_Click(object sender, EventArgs e)
        {
            ClearStock();
        }

        //Add Stock 
        private void addStock()
        {
            bool isSuccess = true;

            Stock stock = new Stock()
            {
                UnitPrice = Convert.ToDecimal(txt_stockUC_unitPrice.Text),
                BuyingDiscount = Convert.ToDecimal(txt_stockUC_discount.Text),
                Quantity = Convert.ToInt32(txt_stockUC_qty.Text),
                date = Convert.ToDateTime(dtp_stockUC.Text)
            };

            Inventory inv = new Inventory()
            {
                Type = cmb_stockUC_type.Text
            };

            Supplier sup = new Supplier()
            {
                SupplierId = Convert.ToInt32(txtINsupplier.Text)
            };

            DialogResult dr;
            dr = MessageBox.Show("Do you want to save the record", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                IInventoryService service = ServiceFactory.GetInventoryService();

                isSuccess = service.AddStock(inv, stock, sup);

                if (isSuccess == true)
                {
                    FillStockGrid();
                    ClearStock();
                }
            }
            else
            {
                MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearStock();
            }
        }

        //validation for stock fields
        public bool StockValidation()
        {
            bool status = false;

            if (cmb_stockUC_make.Text == "")
                MessageBox.Show("Please fill the Product Make");

            else if (cmb_stockUC_name.Text == "")
                MessageBox.Show("Please fill the Product Name");

            else if (cmb_stockUC_type.Text == "")
                MessageBox.Show("Please fill the Product Type");

            else if (txt_stockUC_unitPrice.Text == "")
                MessageBox.Show("Please fill the unit price");

            else if (Convert.ToInt32(txt_stockUC_unitPrice.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid amount for unit price");
                txt_stockUC_unitPrice.Clear();
            }

            else if (txt_stockUC_discount.Text == "")
                MessageBox.Show("Please fill the discount");

            else if (Convert.ToInt32(txt_stockUC_discount.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid amount for discount");
                txt_stockUC_discount.Clear();
            }

            else if (txt_stockUC_qty.Text == "")
                MessageBox.Show("Please fill the quantity");

            else if (Convert.ToInt32(txt_stockUC_qty.Text) <= 0)
            {
                MessageBox.Show("Please enter a valid amount for quantity");
                txt_stockUC_qty.Clear();
            }

            else if (txtINsupplier.Text == "")
                MessageBox.Show("Please fill the supplier");

            else
            {
                status = true;
            }
            return status;
        }

        private void txt_stockUC_unitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_stockUC_discount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txt_stockUC_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void btn_stockUC_add_Click(object sender, EventArgs e)
        {
            if(StockValidation()){
                addStock();
            }
        }

        private void btn_stockUC_demo_Click(object sender, EventArgs e)
        {
            cmb_stockUC_make.Text = "Exide";
            cmb_stockUC_name.Text = "Car Battery";
            cmb_stockUC_type.Text = "55D23R/L";
            txt_stockUC_unitPrice.Text = "9000";
            txt_stockUC_discount.Text = "5";
            txt_stockUC_qty.Text = "7";
            txtINsupplier.Text = "2";
        }
    }
}
