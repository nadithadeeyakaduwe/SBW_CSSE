namespace SBW.UI.Sales_n_Profit
{
    public partial class Invoiceform
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoiceform));
            this.dvg_invoice = new System.Windows.Forms.DataGridView();
            this.ItemNo_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Warrenty_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remove_col = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dateTimePicker_invoice_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_invoice_date = new System.Windows.Forms.Label();
            this.lbl_invoice_customername = new System.Windows.Forms.Label();
            this.txtbx_cusName = new System.Windows.Forms.TextBox();
            this.txtbx_cusAdd = new System.Windows.Forms.TextBox();
            this.lbl_invoice_CustomerAdd = new System.Windows.Forms.Label();
            this.txtbx_cusTelephone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbx_invoice_subtotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_product_type = new System.Windows.Forms.Label();
            this.cmbx_invoice_ProductType = new System.Windows.Forms.ComboBox();
            this.btn_invoice_Viewitem = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbx_invoice_advance = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtbx_invoice_totalInvoice = new System.Windows.Forms.TextBox();
            this.btn_invoice_print = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.lbl_Invoice = new System.Windows.Forms.Label();
            this.lbl_invoicenum = new System.Windows.Forms.Label();
            this.txtbx_invoice_invoiceNumber = new System.Windows.Forms.TextBox();
            this.btn_invoice_addItem = new System.Windows.Forms.Button();
            this.cmbx_invoice_ProductName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_invoice_ProductMake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dvg_invoice
            // 
            this.dvg_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_invoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemNo_col,
            this.Description_col,
            this.Qty_col,
            this.Warrenty_col,
            this.Discount_col,
            this.UnitPrice_col,
            this.Amount_col,
            this.Remove_col});
            this.dvg_invoice.Location = new System.Drawing.Point(13, 198);
            this.dvg_invoice.Name = "dvg_invoice";
            this.dvg_invoice.Size = new System.Drawing.Size(994, 151);
            this.dvg_invoice.TabIndex = 0;
            this.dvg_invoice.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dvg_invoice.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_invoice_CellEndEdit);
            this.dvg_invoice.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_invoice_CellEnter);
            this.dvg_invoice.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvg_invoice_CellValueChanged);
            // 
            // ItemNo_col
            // 
            this.ItemNo_col.HeaderText = "Item No";
            this.ItemNo_col.Name = "ItemNo_col";
            // 
            // Description_col
            // 
            this.Description_col.HeaderText = "Description";
            this.Description_col.Name = "Description_col";
            // 
            // Qty_col
            // 
            this.Qty_col.HeaderText = "QTY";
            this.Qty_col.Name = "Qty_col";
            // 
            // Warrenty_col
            // 
            this.Warrenty_col.HeaderText = "Warrenty";
            this.Warrenty_col.Name = "Warrenty_col";
            // 
            // Discount_col
            // 
            this.Discount_col.HeaderText = "Discount";
            this.Discount_col.Name = "Discount_col";
            // 
            // UnitPrice_col
            // 
            this.UnitPrice_col.HeaderText = "Unit Price";
            this.UnitPrice_col.Name = "UnitPrice_col";
            // 
            // Amount_col
            // 
            this.Amount_col.HeaderText = "Amount";
            this.Amount_col.Name = "Amount_col";
            // 
            // Remove_col
            // 
            this.Remove_col.HeaderText = "REMOVE";
            this.Remove_col.Name = "Remove_col";
            this.Remove_col.Text = "REMOVE";
            // 
            // dateTimePicker_invoice_date
            // 
            this.dateTimePicker_invoice_date.Location = new System.Drawing.Point(716, 13);
            this.dateTimePicker_invoice_date.Name = "dateTimePicker_invoice_date";
            this.dateTimePicker_invoice_date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_invoice_date.TabIndex = 2;
            this.dateTimePicker_invoice_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbl_invoice_date
            // 
            this.lbl_invoice_date.AutoSize = true;
            this.lbl_invoice_date.ForeColor = System.Drawing.Color.Black;
            this.lbl_invoice_date.Location = new System.Drawing.Point(602, 17);
            this.lbl_invoice_date.Name = "lbl_invoice_date";
            this.lbl_invoice_date.Size = new System.Drawing.Size(33, 13);
            this.lbl_invoice_date.TabIndex = 3;
            this.lbl_invoice_date.Text = "Date:";
            // 
            // lbl_invoice_customername
            // 
            this.lbl_invoice_customername.AutoSize = true;
            this.lbl_invoice_customername.ForeColor = System.Drawing.Color.Black;
            this.lbl_invoice_customername.Location = new System.Drawing.Point(602, 42);
            this.lbl_invoice_customername.Name = "lbl_invoice_customername";
            this.lbl_invoice_customername.Size = new System.Drawing.Size(85, 13);
            this.lbl_invoice_customername.TabIndex = 4;
            this.lbl_invoice_customername.Text = "Customer Name:";
            // 
            // txtbx_cusName
            // 
            this.txtbx_cusName.Location = new System.Drawing.Point(716, 39);
            this.txtbx_cusName.Name = "txtbx_cusName";
            this.txtbx_cusName.Size = new System.Drawing.Size(291, 20);
            this.txtbx_cusName.TabIndex = 5;
            // 
            // txtbx_cusAdd
            // 
            this.txtbx_cusAdd.Location = new System.Drawing.Point(716, 65);
            this.txtbx_cusAdd.Multiline = true;
            this.txtbx_cusAdd.Name = "txtbx_cusAdd";
            this.txtbx_cusAdd.Size = new System.Drawing.Size(291, 61);
            this.txtbx_cusAdd.TabIndex = 7;
            // 
            // lbl_invoice_CustomerAdd
            // 
            this.lbl_invoice_CustomerAdd.AutoSize = true;
            this.lbl_invoice_CustomerAdd.ForeColor = System.Drawing.Color.Black;
            this.lbl_invoice_CustomerAdd.Location = new System.Drawing.Point(602, 71);
            this.lbl_invoice_CustomerAdd.Name = "lbl_invoice_CustomerAdd";
            this.lbl_invoice_CustomerAdd.Size = new System.Drawing.Size(95, 13);
            this.lbl_invoice_CustomerAdd.TabIndex = 6;
            this.lbl_invoice_CustomerAdd.Text = "Customer Address:";
            // 
            // txtbx_cusTelephone
            // 
            this.txtbx_cusTelephone.Location = new System.Drawing.Point(716, 132);
            this.txtbx_cusTelephone.Name = "txtbx_cusTelephone";
            this.txtbx_cusTelephone.Size = new System.Drawing.Size(150, 20);
            this.txtbx_cusTelephone.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(602, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Telephone:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(224, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Customer Signature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(511, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sellar Signature";
            // 
            // txtbx_invoice_subtotal
            // 
            this.txtbx_invoice_subtotal.Location = new System.Drawing.Point(772, 355);
            this.txtbx_invoice_subtotal.Name = "txtbx_invoice_subtotal";
            this.txtbx_invoice_subtotal.Size = new System.Drawing.Size(235, 20);
            this.txtbx_invoice_subtotal.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(713, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sub Total";
            // 
            // lbl_product_type
            // 
            this.lbl_product_type.AutoSize = true;
            this.lbl_product_type.ForeColor = System.Drawing.Color.Black;
            this.lbl_product_type.Location = new System.Drawing.Point(470, 172);
            this.lbl_product_type.Name = "lbl_product_type";
            this.lbl_product_type.Size = new System.Drawing.Size(71, 13);
            this.lbl_product_type.TabIndex = 14;
            this.lbl_product_type.Text = "Product Type";
            // 
            // cmbx_invoice_ProductType
            // 
            this.cmbx_invoice_ProductType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbx_invoice_ProductType.DisplayMember = "Product_Type";
            this.cmbx_invoice_ProductType.FormattingEnabled = true;
            this.cmbx_invoice_ProductType.Location = new System.Drawing.Point(558, 169);
            this.cmbx_invoice_ProductType.Name = "cmbx_invoice_ProductType";
            this.cmbx_invoice_ProductType.Size = new System.Drawing.Size(205, 21);
            this.cmbx_invoice_ProductType.TabIndex = 22;
            this.cmbx_invoice_ProductType.ValueMember = "Product_Type";
            this.cmbx_invoice_ProductType.SelectedIndexChanged += new System.EventHandler(this.cmbx_invoice_ProductType_SelectedIndexChanged);
            // 
            // btn_invoice_Viewitem
            // 
            this.btn_invoice_Viewitem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoice_Viewitem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice_Viewitem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_invoice_Viewitem.Location = new System.Drawing.Point(891, 167);
            this.btn_invoice_Viewitem.Name = "btn_invoice_Viewitem";
            this.btn_invoice_Viewitem.Size = new System.Drawing.Size(116, 23);
            this.btn_invoice_Viewitem.TabIndex = 23;
            this.btn_invoice_Viewitem.Text = "VIEW";
            this.btn_invoice_Viewitem.UseVisualStyleBackColor = true;
            this.btn_invoice_Viewitem.Click += new System.EventHandler(this.btn_invoice_itemView_Click);
            // 
            // label8
            // 
            this.label8.AutoEllipsis = true;
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(713, 384);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Advance";
            this.label8.UseWaitCursor = true;
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtbx_invoice_advance
            // 
            this.txtbx_invoice_advance.Location = new System.Drawing.Point(772, 381);
            this.txtbx_invoice_advance.Name = "txtbx_invoice_advance";
            this.txtbx_invoice_advance.Size = new System.Drawing.Size(235, 20);
            this.txtbx_invoice_advance.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoEllipsis = true;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(638, 410);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 27;
            this.label9.Text = "Total Invoice Amount";
            this.label9.UseWaitCursor = true;
            // 
            // txtbx_invoice_totalInvoice
            // 
            this.txtbx_invoice_totalInvoice.Location = new System.Drawing.Point(772, 407);
            this.txtbx_invoice_totalInvoice.Name = "txtbx_invoice_totalInvoice";
            this.txtbx_invoice_totalInvoice.Size = new System.Drawing.Size(235, 20);
            this.txtbx_invoice_totalInvoice.TabIndex = 26;
            // 
            // btn_invoice_print
            // 
            this.btn_invoice_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice_print.Location = new System.Drawing.Point(881, 446);
            this.btn_invoice_print.Name = "btn_invoice_print";
            this.btn_invoice_print.Size = new System.Drawing.Size(89, 23);
            this.btn_invoice_print.TabIndex = 28;
            this.btn_invoice_print.Text = "PRINT";
            this.btn_invoice_print.UseVisualStyleBackColor = true;
            this.btn_invoice_print.Click += new System.EventHandler(this.btn_invoice_print_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // lbl_Invoice
            // 
            this.lbl_Invoice.AutoSize = true;
            this.lbl_Invoice.Font = new System.Drawing.Font("Lucida Fax", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Invoice.ForeColor = System.Drawing.Color.Black;
            this.lbl_Invoice.Location = new System.Drawing.Point(10, 13);
            this.lbl_Invoice.Name = "lbl_Invoice";
            this.lbl_Invoice.Size = new System.Drawing.Size(159, 38);
            this.lbl_Invoice.TabIndex = 29;
            this.lbl_Invoice.Text = "INVOICE";
            // 
            // lbl_invoicenum
            // 
            this.lbl_invoicenum.AutoSize = true;
            this.lbl_invoicenum.ForeColor = System.Drawing.Color.Black;
            this.lbl_invoicenum.Location = new System.Drawing.Point(14, 51);
            this.lbl_invoicenum.Name = "lbl_invoicenum";
            this.lbl_invoicenum.Size = new System.Drawing.Size(52, 13);
            this.lbl_invoicenum.TabIndex = 30;
            this.lbl_invoicenum.Text = "Invoice #";
            // 
            // txtbx_invoice_invoiceNumber
            // 
            this.txtbx_invoice_invoiceNumber.Enabled = false;
            this.txtbx_invoice_invoiceNumber.Location = new System.Drawing.Point(69, 48);
            this.txtbx_invoice_invoiceNumber.Name = "txtbx_invoice_invoiceNumber";
            this.txtbx_invoice_invoiceNumber.Size = new System.Drawing.Size(100, 20);
            this.txtbx_invoice_invoiceNumber.TabIndex = 31;
            // 
            // btn_invoice_addItem
            // 
            this.btn_invoice_addItem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_invoice_addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_invoice_addItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_invoice_addItem.Location = new System.Drawing.Point(769, 167);
            this.btn_invoice_addItem.Name = "btn_invoice_addItem";
            this.btn_invoice_addItem.Size = new System.Drawing.Size(116, 23);
            this.btn_invoice_addItem.TabIndex = 32;
            this.btn_invoice_addItem.Text = "ADD";
            this.btn_invoice_addItem.UseVisualStyleBackColor = true;
            this.btn_invoice_addItem.Click += new System.EventHandler(this.btn_invoice_addItem_Click);
            // 
            // cmbx_invoice_ProductName
            // 
            this.cmbx_invoice_ProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbx_invoice_ProductName.DisplayMember = "Product_Type";
            this.cmbx_invoice_ProductName.FormattingEnabled = true;
            this.cmbx_invoice_ProductName.Location = new System.Drawing.Point(338, 169);
            this.cmbx_invoice_ProductName.Name = "cmbx_invoice_ProductName";
            this.cmbx_invoice_ProductName.Size = new System.Drawing.Size(126, 21);
            this.cmbx_invoice_ProductName.TabIndex = 34;
            this.cmbx_invoice_ProductName.ValueMember = "Product_Type";
            this.cmbx_invoice_ProductName.DropDown += new System.EventHandler(this.cmbx_invoice_ProductName_DropDown);
            this.cmbx_invoice_ProductName.SelectedIndexChanged += new System.EventHandler(this.cmbx_invoice_ProductName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(261, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Product Name";
            // 
            // cmbx_invoice_ProductMake
            // 
            this.cmbx_invoice_ProductMake.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbx_invoice_ProductMake.DisplayMember = "Product_Type";
            this.cmbx_invoice_ProductMake.FormattingEnabled = true;
            this.cmbx_invoice_ProductMake.Location = new System.Drawing.Point(91, 169);
            this.cmbx_invoice_ProductMake.Name = "cmbx_invoice_ProductMake";
            this.cmbx_invoice_ProductMake.Size = new System.Drawing.Size(164, 21);
            this.cmbx_invoice_ProductMake.TabIndex = 36;
            this.cmbx_invoice_ProductMake.ValueMember = "Product_Type";
            this.cmbx_invoice_ProductMake.SelectedIndexChanged += new System.EventHandler(this.cmbx_invoice_ProductMake_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(14, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Product Make";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Invoiceform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cmbx_invoice_ProductMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbx_invoice_ProductName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_invoice_addItem);
            this.Controls.Add(this.txtbx_invoice_invoiceNumber);
            this.Controls.Add(this.lbl_invoicenum);
            this.Controls.Add(this.lbl_Invoice);
            this.Controls.Add(this.btn_invoice_print);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtbx_invoice_totalInvoice);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtbx_invoice_advance);
            this.Controls.Add(this.btn_invoice_Viewitem);
            this.Controls.Add(this.cmbx_invoice_ProductType);
            this.Controls.Add(this.lbl_product_type);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtbx_invoice_subtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbx_cusTelephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbx_cusAdd);
            this.Controls.Add(this.lbl_invoice_CustomerAdd);
            this.Controls.Add(this.txtbx_cusName);
            this.Controls.Add(this.lbl_invoice_customername);
            this.Controls.Add(this.lbl_invoice_date);
            this.Controls.Add(this.dateTimePicker_invoice_date);
            this.Controls.Add(this.dvg_invoice);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.MaximumSize = new System.Drawing.Size(1020, 489);
            this.MinimumSize = new System.Drawing.Size(1020, 489);
            this.Name = "Invoiceform";
            this.Size = new System.Drawing.Size(1020, 489);
            this.Load += new System.EventHandler(this.Invoiceform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvg_invoice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dvg_invoice;
        private System.Windows.Forms.DateTimePicker dateTimePicker_invoice_date;
        private System.Windows.Forms.Label lbl_invoice_date;
        private System.Windows.Forms.Label lbl_invoice_customername;
        private System.Windows.Forms.TextBox txtbx_cusName;
        private System.Windows.Forms.TextBox txtbx_cusAdd;
        private System.Windows.Forms.Label lbl_invoice_CustomerAdd;
        private System.Windows.Forms.TextBox txtbx_cusTelephone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbx_invoice_subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_product_type;
        private System.Windows.Forms.ComboBox cmbx_invoice_ProductType;
        private System.Windows.Forms.Button btn_invoice_Viewitem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbx_invoice_advance;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtbx_invoice_totalInvoice;
        private System.Windows.Forms.Button btn_invoice_print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Label lbl_Invoice;
        private System.Windows.Forms.Label lbl_invoicenum;
        private System.Windows.Forms.TextBox txtbx_invoice_invoiceNumber;
        private System.Windows.Forms.Button btn_invoice_addItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Warrenty_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount_col;
        private System.Windows.Forms.DataGridViewButtonColumn Remove_col;
        private System.Windows.Forms.ComboBox cmbx_invoice_ProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_invoice_ProductMake;
        private System.Windows.Forms.Label label6;
    }
}
