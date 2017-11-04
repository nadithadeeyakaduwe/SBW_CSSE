﻿using System;
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
using SBW.Entities.SnPModule;
using SBW.UI.Common;

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

        //Bitmap bmp;

        private void btn_invoice_print_Click(object sender, EventArgs e)
        {
            invoiceService Is = new invoiceService();
            bool hstatus = Is.addInvoiceHeader(this.getinvoiceHeader());

            int row = 0;
            bool status = true;

            foreach (DataGridViewRow r in dvg_invoice.Rows)
            {
                if (r.Cells[0].Value == null)
                    break;
                else
                {
                    
                    int temp= r.Index;
                    bool dstatus = Is.addInvoicedetails(this.getinvoiceDetails(temp));
                    row++;
                    if (!dstatus)
                        status = false;

                }
            }


            if (status == true && hstatus == true)
            {
                MessageBox.Show("Scussessfully Invoiced!!!");
                Helper.ClearAll(this);
                dvg_invoice.DataSource = null;
                dvg_invoice.Rows.Clear();
                Invoiceform_Load(sender, e);
            }
            else
                MessageBox.Show("Invoicing Unsuccessful!!!");


            

            //Graphics g = this.CreateGraphics();
            //bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            //Graphics mg = Graphics.FromImage(bmp);
            //mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            //printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // e.Graphics.DrawImage(bmp, 0, 0);
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
            cmbx_invoice_ProductType.DataSource = Is.loadComboBoxProductName(cmbx_invoice_ProductMake.Text, cmbx_invoice_ProductName.Text);
            cmbx_invoice_ProductType.ValueMember = "Product_Type";
            cmbx_invoice_ProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            cmbx_invoice_ProductType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbx_invoice_ProductType.AutoCompleteSource = AutoCompleteSource.ListItems;


        }

        private void btn_invoice_addItem_Click(object sender, EventArgs e)
        {
            invoiceService Is = new invoiceService();
            dvg_invoice = Is.fillInvoiceTable(cmbx_invoice_ProductMake.Text, cmbx_invoice_ProductName.Text, cmbx_invoice_ProductType.Text, dvg_invoice);
        }

        private void dvg_invoice_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_invoice_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvg_invoice_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal unitprice = 0, discount = 0, amount = 0;
            int qty = 0;

            if (dvg_invoice.Rows[e.RowIndex].Cells[5].Value == null || dvg_invoice.Rows[e.RowIndex].Cells[4].Value == null)
            {
                unitprice = 0;
                discount = 0;
            }
            else
            {
                unitprice = decimal.Parse(dvg_invoice.Rows[e.RowIndex].Cells[5].Value.ToString());
                discount = decimal.Parse(dvg_invoice.Rows[e.RowIndex].Cells[4].Value.ToString());
                qty = Int32.Parse(dvg_invoice.Rows[e.RowIndex].Cells[2].Value.ToString());
            }

            amount = (unitprice - (unitprice * discount / 100)) * qty;

            dvg_invoice.Rows[e.RowIndex].Cells[6].Value = amount.ToString();


            decimal sum = 0;
            for (int i = 0; i < dvg_invoice.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(dvg_invoice.Rows[i].Cells[6].Value);
            }
            txtbx_invoice_subtotal.Text = sum.ToString();





        }

        private void txtbx_invoice_advance_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbx_invoice_totalInvoice_MouseClick(object sender, MouseEventArgs e)
        {
            decimal subTot = Convert.ToDecimal(txtbx_invoice_subtotal.Text);
            decimal advance = Convert.ToDecimal(txtbx_invoice_advance.Text);

            txtbx_invoice_totalInvoice.Text = (subTot - advance).ToString();
        }

        public InvoiceHeader getinvoiceHeader()
        {
            InvoiceHeader ih = new InvoiceHeader();
            ih.invoiceNo = Convert.ToInt32(txtbx_invoice_invoiceNumber.Text);
            ih.sDate = dateTimePicker_invoice_date.Value;
            ih.customerName = txtbx_cusName.Text;
            ih.customerAddress = txtbx_cusAdd.Text;
            ih.customerTelephone = txtbx_cusTelephone.Text;
            ih.totalAmount = Convert.ToDecimal(txtbx_invoice_totalInvoice.Text);

            return ih;

        }

        public InvoiceDetails getinvoiceDetails(int r)
        {
            InvoiceDetails id = new InvoiceDetails();
            //id.itemNo = Convert.ToInt32(dvg_invoice.Rows[r].Cells[0].Value);
            id.invoiceNo = Convert.ToInt32(txtbx_invoice_invoiceNumber.Text);
            id.productDescription = dvg_invoice.Rows[r].Cells[1].Value.ToString();
            id.qty = Convert.ToInt32(dvg_invoice.Rows[r].Cells[2].Value);
            id.unitPrice = Convert.ToDecimal(dvg_invoice.Rows[r].Cells[5].Value);
            id.discount = Convert.ToDecimal(dvg_invoice.Rows[r].Cells[4].Value);
            id.warrenty = dvg_invoice.Rows[r].Cells[3].Value.ToString();
            id.amount = Convert.ToDecimal(dvg_invoice.Rows[r].Cells[6].Value);

            return id;

        }










    }



}

