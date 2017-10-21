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
    public partial class SupplierDetailsForm : Form
    {
        private ISupplierService service;

        public SupplierDetailsForm()
        {
            InitializeComponent();
        }

        private void lbl_supplierUC_name_Click(object sender, EventArgs e)
        {

        }

        //Filling Supplier Grid
        public void FillSupplierGrid()
        {
            service = ServiceFactory.GetSupplierService();

            DataTable dt = null;

            dt = service.ViewSupplierDetails();

            dgv_supplierUC.DataSource = dt;

        }

        //Supplier Form Load
        private void SupplierDetailsForm_Load(object sender, EventArgs e)
        {
            FillSupplierGrid();

            btn_supplierUC_update.Enabled = false;
            btn_supplierUC_delete.Enabled = false;
        }

        //ADD button click event
        private void btn_supplierUC_add_Click(object sender, EventArgs e)
        {
            if (SupplierValidation())
            {
                addSupplier();
            }
        }

        //Validation for Supplier fields
        public bool SupplierValidation()
        {
            bool status = false;

            if (txt_supplierUC_name.Text == "")
                MessageBox.Show("Please fill the Supplier Name");

            else if (rtxt_supplierUC_address.Text == "")
                MessageBox.Show("Please fill the Supplier Address");

            else if (txt_supplierUC_email.Text == "")
                MessageBox.Show("Please fill the email");

            else if (txt_supplierUC_contact.Text == "")
                MessageBox.Show("Please fill the Contact No");
            else if (txt_supplierUC_contact.TextLength != 10)
                MessageBox.Show("Please enter a valid contact no");

            else
            {
                status = true;
            }
            return status;
        }

        //key press event for supplier contact no
        private void txt_supplierUC_contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (txt_supplierUC_contact.Text.Length > 9 && ch != 8)
                e.Handled = true;
        }

        //ADD Supplier
        private void addSupplier()
        {
            bool isSuccess = true;

            Supplier supplier = new Supplier()
            {
                Name = txt_supplierUC_name.Text,
                Address = rtxt_supplierUC_address.Text,
                email = txt_supplierUC_email.Text,
                ContactNo = txt_supplierUC_contact.Text
            };

            DialogResult dr;
            dr = MessageBox.Show("Do you want to save the record", "Confirm", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                ISupplierService service = ServiceFactory.GetSupplierService();

                isSuccess = service.AddSupplier(supplier);

                if (isSuccess == true)
                {
                    FillSupplierGrid();
                    ClearSup();
                }
            }
            else
            {
                MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearSup();
            }
        }


        //Clear Supplier
        public void ClearSup()
        {

            txt_supplierUC_name.Clear();
            
            rtxt_supplierUC_address.Clear();
            txt_supplierUC_contact.Clear();
            txt_supplierUC_email.Clear();

            btn_supplierUC_update.Enabled = false;
            btn_supplierUC_delete.Enabled = false;
            btn_supplierUC_add.Enabled = true;

        }

        //Supplier row click event
        private void dgv_supplierUC_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txt_supplierUC_name.Text = dgv_supplierUC.Rows[e.RowIndex].Cells[1].Value.ToString();
            rtxt_supplierUC_address.Text = dgv_supplierUC.Rows[e.RowIndex].Cells[2].Value.ToString();
            txt_supplierUC_email.Text = dgv_supplierUC.Rows[e.RowIndex].Cells[3].Value.ToString();
            txt_supplierUC_contact.Text = dgv_supplierUC.Rows[e.RowIndex].Cells[4].Value.ToString();

            btn_supplierUC_update.Enabled = true;
            btn_supplierUC_delete.Enabled = true;
            btn_supplierUC_add.Enabled = false;

        }

        private void btn_supplierUC_clear_Click(object sender, EventArgs e)
        {
            ClearSup();
        }
    }
}
