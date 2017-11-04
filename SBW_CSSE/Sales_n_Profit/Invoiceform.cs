using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.UI.InventoryUserControls;
using SBW.BusinessService;

namespace SBW.UI.Sales_n_Profit
{
    public partial class Invoiceform : UserControl
    {
        public Invoiceform()
        {
            InitializeComponent();
        }

        private void Invoiceform_Load(object sender, EventArgs e)
        {
            invoiceService Is = new invoiceService();
            cmbx_invoice_ProductMake.DataSource = Is.loadComboBoxProductMake();
            cmbx_invoice_ProductMake.ValueMember = "Product_Make";
            cmbx_invoice_ProductMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbx_invoice_ProductMake.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbx_invoice_ProductMake.AutoCompleteSource = AutoCompleteSource.ListItems;

            txtbx_invoice_invoiceNumber.Text = Is.fillInvoiceNumber().ToString();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        Bitmap bmp;

        private void btn_invoice_print_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width,this.Size.Height,g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
          

        }

        private void btn_invoice_itemView_Click(object sender, EventArgs e)
        {
            var popup = new inviocAddItemPopup(this);
            popup.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmbx_invoice_ProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbx_invoice_ProductName_DropDown(object sender, EventArgs e)
        {
          
        }

        private void cmbx_invoice_ProductMake_SelectedIndexChanged(object sender, EventArgs e)
        {
            invoiceService Is = new invoiceService();
            cmbx_invoice_ProductName.DataSource = Is.loadComboBoxProductName(cmbx_invoice_ProductMake.Text);
            cmbx_invoice_ProductName.ValueMember = "Product_Name";
            cmbx_invoice_ProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbx_invoice_ProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbx_invoice_ProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cmbx_invoice_ProductName_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            invoiceService Is = new invoiceService();
            cmbx_invoice_ProductType.DataSource = Is.loadComboBoxProductName(cmbx_invoice_ProductMake.Text,cmbx_invoice_ProductName.Text);
            cmbx_invoice_ProductType.ValueMember = "Product_Type";
            cmbx_invoice_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbx_invoice_ProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbx_invoice_ProductType.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void btn_invoice_addItem_Click(object sender, EventArgs e)
        {
            invoiceService Is = new invoiceService();
            dvg_invoice = Is.fillInvoiceTable(cmbx_invoice_ProductMake.Text,cmbx_invoice_ProductName.Text,cmbx_invoice_ProductType.Text, dvg_invoice);
        }

        private void dvg_invoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
