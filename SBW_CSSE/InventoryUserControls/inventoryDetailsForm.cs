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
using SBW.UI.Common;
using SBW.Entities.InventoryModule;

namespace SBW.UI.InventoryUserControls
{
    public partial class InventoryDetailsForm : Form
    {
        private IInventoryService service;

        public InventoryDetailsForm()
        {
            InitializeComponent();
        }

        private void InventoryDetailsForm_Load(object sender, EventArgs e)
        {
            service = ServiceFactory.GetInventoryService();

            DataTable dt = null;

            dt = service.ViewInventoryItems();

            dgv_inventoryUC.DataSource = dt;
        }

        //ADD button click event
        private void btn_inventoryUC_add_Click(object sender, EventArgs e)
        {
            if (InventoryValidation())
            {
                addInventory();
            }
        }

        private void addInventory()
        {
            bool isSuccess = true;

            Inventory inventory = new Inventory()
            {
                Make = cmb_inventoryUC_make.Text,
                Name = cmb_inventoryUC_Name.Text,
                Type = cmb_inventoryUC_type.Text,
                ReorderLevel = Convert.ToInt32(txt_inventoryUC_reorder.Text)
 
            };

            DialogResult dr;
            dr = MessageBox.Show("Do you want to save the record", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                IInventoryService service = ServiceFactory.GetInventoryService();

                isSuccess = service.AddInventory(inventory);

                if (isSuccess == true)
                {
                    dgv_inventoryUC.DataSource = service.ViewInventoryItems();
                    Helper.ClearAll(this);
                }
            }
            else
            {
                MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clear();
            }
        }

        //validation for inventory fields
        public bool InventoryValidation()
        {
            bool status = false;

            if (cmb_inventoryUC_make.Text == "")
                MessageBox.Show("Please fill the Product Make");

            else if (cmb_inventoryUC_Name.Text == "")
                MessageBox.Show("Please fill the Product Name");

            else if (cmb_inventoryUC_type.Text == "")
                MessageBox.Show("Please fill the Product Type");

            else if (Convert.ToInt32(txt_inventoryUC_reorder.Text) <= 0 )
            {
                MessageBox.Show("Please enter a valid amount for Reorder Level");
                txt_inventoryUC_reorder.Clear();
            }

            else
            {
                status = true;
            }
            return status;
        }

        //key press event for reorder level
        private void txt_inventoryUC_reorder_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        //DELETE button click event
        private void btn_inventoryUC_delete_Click(object sender, EventArgs e)
        {
            bool status = true;

            service = ServiceFactory.GetInventoryService();

            DialogResult dr;
            dr = MessageBox.Show("Do you want to delete the record", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                status = service.DeleteInventory(Convert.ToInt32(lbl_inventoryUC_pId.Text));

                if (status)
                {
                    dgv_inventoryUC.DataSource = service.ViewInventoryItems();
                }
            }
            else
                MessageBox.Show("Record is not deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        //grid row click event
        private void dgv_inventoryUC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            lbl_inventoryUC_pId.Text = dgv_inventoryUC.Rows[e.RowIndex].Cells[0].Value.ToString();
            cmb_inventoryUC_make.Text = dgv_inventoryUC.Rows[e.RowIndex].Cells[1].Value.ToString();
            cmb_inventoryUC_Name.Text = dgv_inventoryUC.Rows[e.RowIndex].Cells[2].Value.ToString();
            cmb_inventoryUC_type.Text = dgv_inventoryUC.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_inventoryUC_reorder.Text = dgv_inventoryUC.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

    }
}
