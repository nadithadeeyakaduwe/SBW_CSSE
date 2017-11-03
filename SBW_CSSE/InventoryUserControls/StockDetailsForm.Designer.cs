namespace SBW.UI.InventoryUserControls
{
    partial class StockDetailsForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.ltb_stockUC = new System.Windows.Forms.ListBox();
            this.btn_stockUC_demo = new System.Windows.Forms.Button();
            this.btn_stockUC_clear = new System.Windows.Forms.Button();
            this.btn_stockUC_delete = new System.Windows.Forms.Button();
            this.btn_stockUC_update = new System.Windows.Forms.Button();
            this.btn_stockUC_add = new System.Windows.Forms.Button();
            this.dgv_stockUC_stock = new System.Windows.Forms.DataGridView();
            this.txtINsupplier = new System.Windows.Forms.ComboBox();
            this.lblINsupplier = new System.Windows.Forms.Label();
            this.btn_stockUC_search = new System.Windows.Forms.Button();
            this.cmb_stockUC_type = new System.Windows.Forms.ComboBox();
            this.cmb_stockUC_name = new System.Windows.Forms.ComboBox();
            this.cmb_stockUC_make = new System.Windows.Forms.ComboBox();
            this.lbl_stockUC_date = new System.Windows.Forms.Label();
            this.dtp_stockUC = new System.Windows.Forms.DateTimePicker();
            this.txt_stockUC_qty = new System.Windows.Forms.TextBox();
            this.lbl_stockUC_qty = new System.Windows.Forms.Label();
            this.txt_stockUC_discount = new System.Windows.Forms.TextBox();
            this.lbl_stockUC_discount = new System.Windows.Forms.Label();
            this.txt_stockUC_unitPrice = new System.Windows.Forms.TextBox();
            this.lbl_stockUC_unitPrice = new System.Windows.Forms.Label();
            this.lbl_stockUC_type = new System.Windows.Forms.Label();
            this.lbl_stockUC_Name = new System.Windows.Forms.Label();
            this.lbl_stockUC_make = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockUC_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox9);
            this.groupBox1.Controls.Add(this.btn_stockUC_demo);
            this.groupBox1.Controls.Add(this.btn_stockUC_clear);
            this.groupBox1.Controls.Add(this.btn_stockUC_delete);
            this.groupBox1.Controls.Add(this.btn_stockUC_update);
            this.groupBox1.Controls.Add(this.btn_stockUC_add);
            this.groupBox1.Controls.Add(this.dgv_stockUC_stock);
            this.groupBox1.Controls.Add(this.txtINsupplier);
            this.groupBox1.Controls.Add(this.lblINsupplier);
            this.groupBox1.Controls.Add(this.btn_stockUC_search);
            this.groupBox1.Controls.Add(this.cmb_stockUC_type);
            this.groupBox1.Controls.Add(this.cmb_stockUC_name);
            this.groupBox1.Controls.Add(this.cmb_stockUC_make);
            this.groupBox1.Controls.Add(this.lbl_stockUC_date);
            this.groupBox1.Controls.Add(this.dtp_stockUC);
            this.groupBox1.Controls.Add(this.txt_stockUC_qty);
            this.groupBox1.Controls.Add(this.lbl_stockUC_qty);
            this.groupBox1.Controls.Add(this.txt_stockUC_discount);
            this.groupBox1.Controls.Add(this.lbl_stockUC_discount);
            this.groupBox1.Controls.Add(this.txt_stockUC_unitPrice);
            this.groupBox1.Controls.Add(this.lbl_stockUC_unitPrice);
            this.groupBox1.Controls.Add(this.lbl_stockUC_type);
            this.groupBox1.Controls.Add(this.lbl_stockUC_Name);
            this.groupBox1.Controls.Add(this.lbl_stockUC_make);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.MaximumSize = new System.Drawing.Size(1080, 489);
            this.groupBox1.MinimumSize = new System.Drawing.Size(1080, 489);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1080, 489);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.ltb_stockUC);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(768, 191);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(285, 233);
            this.groupBox9.TabIndex = 32;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Re-order Inventory List";
            // 
            // ltb_stockUC
            // 
            this.ltb_stockUC.FormattingEnabled = true;
            this.ltb_stockUC.ItemHeight = 20;
            this.ltb_stockUC.Location = new System.Drawing.Point(6, 23);
            this.ltb_stockUC.MultiColumn = true;
            this.ltb_stockUC.Name = "ltb_stockUC";
            this.ltb_stockUC.Size = new System.Drawing.Size(253, 204);
            this.ltb_stockUC.TabIndex = 0;
            // 
            // btn_stockUC_demo
            // 
            this.btn_stockUC_demo.Location = new System.Drawing.Point(644, 416);
            this.btn_stockUC_demo.Name = "btn_stockUC_demo";
            this.btn_stockUC_demo.Size = new System.Drawing.Size(82, 29);
            this.btn_stockUC_demo.TabIndex = 31;
            this.btn_stockUC_demo.Text = "DEMO";
            this.btn_stockUC_demo.UseVisualStyleBackColor = true;
            // 
            // btn_stockUC_clear
            // 
            this.btn_stockUC_clear.Location = new System.Drawing.Point(521, 416);
            this.btn_stockUC_clear.Name = "btn_stockUC_clear";
            this.btn_stockUC_clear.Size = new System.Drawing.Size(82, 29);
            this.btn_stockUC_clear.TabIndex = 30;
            this.btn_stockUC_clear.Text = "CLEAR";
            this.btn_stockUC_clear.UseVisualStyleBackColor = true;
            this.btn_stockUC_clear.Click += new System.EventHandler(this.btn_stockUC_clear_Click);
            // 
            // btn_stockUC_delete
            // 
            this.btn_stockUC_delete.Location = new System.Drawing.Point(392, 416);
            this.btn_stockUC_delete.Name = "btn_stockUC_delete";
            this.btn_stockUC_delete.Size = new System.Drawing.Size(82, 29);
            this.btn_stockUC_delete.TabIndex = 29;
            this.btn_stockUC_delete.Text = "DELETE";
            this.btn_stockUC_delete.UseVisualStyleBackColor = true;
            // 
            // btn_stockUC_update
            // 
            this.btn_stockUC_update.Location = new System.Drawing.Point(260, 416);
            this.btn_stockUC_update.Name = "btn_stockUC_update";
            this.btn_stockUC_update.Size = new System.Drawing.Size(82, 29);
            this.btn_stockUC_update.TabIndex = 28;
            this.btn_stockUC_update.Text = "UPDATE";
            this.btn_stockUC_update.UseVisualStyleBackColor = true;
            // 
            // btn_stockUC_add
            // 
            this.btn_stockUC_add.Location = new System.Drawing.Point(135, 416);
            this.btn_stockUC_add.Name = "btn_stockUC_add";
            this.btn_stockUC_add.Size = new System.Drawing.Size(82, 29);
            this.btn_stockUC_add.TabIndex = 27;
            this.btn_stockUC_add.Text = "ADD";
            this.btn_stockUC_add.UseVisualStyleBackColor = true;
            this.btn_stockUC_add.Click += new System.EventHandler(this.btn_stockUC_add_Click);
            // 
            // dgv_stockUC_stock
            // 
            this.dgv_stockUC_stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_stockUC_stock.Location = new System.Drawing.Point(15, 191);
            this.dgv_stockUC_stock.Name = "dgv_stockUC_stock";
            this.dgv_stockUC_stock.Size = new System.Drawing.Size(736, 219);
            this.dgv_stockUC_stock.TabIndex = 26;
            // 
            // txtINsupplier
            // 
            this.txtINsupplier.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtINsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtINsupplier.FormattingEnabled = true;
            this.txtINsupplier.Location = new System.Drawing.Point(723, 140);
            this.txtINsupplier.Name = "txtINsupplier";
            this.txtINsupplier.Size = new System.Drawing.Size(66, 28);
            this.txtINsupplier.TabIndex = 25;
            // 
            // lblINsupplier
            // 
            this.lblINsupplier.AutoSize = true;
            this.lblINsupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINsupplier.Location = new System.Drawing.Point(610, 145);
            this.lblINsupplier.Name = "lblINsupplier";
            this.lblINsupplier.Size = new System.Drawing.Size(88, 20);
            this.lblINsupplier.TabIndex = 24;
            this.lblINsupplier.Text = "Supplier ID";
            // 
            // btn_stockUC_search
            // 
            this.btn_stockUC_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stockUC_search.Location = new System.Drawing.Point(789, 37);
            this.btn_stockUC_search.Name = "btn_stockUC_search";
            this.btn_stockUC_search.Size = new System.Drawing.Size(88, 29);
            this.btn_stockUC_search.TabIndex = 23;
            this.btn_stockUC_search.Text = "SEARCH";
            this.btn_stockUC_search.UseVisualStyleBackColor = true;
            this.btn_stockUC_search.Click += new System.EventHandler(this.btn_stockUC_search_Click);
            // 
            // cmb_stockUC_type
            // 
            this.cmb_stockUC_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stockUC_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockUC_type.FormattingEnabled = true;
            this.cmb_stockUC_type.Location = new System.Drawing.Point(604, 37);
            this.cmb_stockUC_type.Name = "cmb_stockUC_type";
            this.cmb_stockUC_type.Size = new System.Drawing.Size(130, 28);
            this.cmb_stockUC_type.TabIndex = 22;
            // 
            // cmb_stockUC_name
            // 
            this.cmb_stockUC_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stockUC_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockUC_name.FormattingEnabled = true;
            this.cmb_stockUC_name.Location = new System.Drawing.Point(343, 37);
            this.cmb_stockUC_name.Name = "cmb_stockUC_name";
            this.cmb_stockUC_name.Size = new System.Drawing.Size(130, 28);
            this.cmb_stockUC_name.TabIndex = 21;
            this.cmb_stockUC_name.SelectedIndexChanged += new System.EventHandler(this.cmb_stockUC_name_SelectedIndexChanged);
            // 
            // cmb_stockUC_make
            // 
            this.cmb_stockUC_make.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_stockUC_make.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_stockUC_make.FormattingEnabled = true;
            this.cmb_stockUC_make.Location = new System.Drawing.Point(68, 37);
            this.cmb_stockUC_make.Name = "cmb_stockUC_make";
            this.cmb_stockUC_make.Size = new System.Drawing.Size(130, 28);
            this.cmb_stockUC_make.TabIndex = 20;
            this.cmb_stockUC_make.SelectedIndexChanged += new System.EventHandler(this.cmb_stockUC_make_SelectedIndexChanged);
            // 
            // lbl_stockUC_date
            // 
            this.lbl_stockUC_date.AutoSize = true;
            this.lbl_stockUC_date.Location = new System.Drawing.Point(283, 148);
            this.lbl_stockUC_date.Name = "lbl_stockUC_date";
            this.lbl_stockUC_date.Size = new System.Drawing.Size(44, 20);
            this.lbl_stockUC_date.TabIndex = 19;
            this.lbl_stockUC_date.Text = "Date";
            // 
            // dtp_stockUC
            // 
            this.dtp_stockUC.Location = new System.Drawing.Point(352, 145);
            this.dtp_stockUC.Name = "dtp_stockUC";
            this.dtp_stockUC.Size = new System.Drawing.Size(200, 26);
            this.dtp_stockUC.TabIndex = 18;
            // 
            // txt_stockUC_qty
            // 
            this.txt_stockUC_qty.Location = new System.Drawing.Point(98, 145);
            this.txt_stockUC_qty.Name = "txt_stockUC_qty";
            this.txt_stockUC_qty.Size = new System.Drawing.Size(100, 26);
            this.txt_stockUC_qty.TabIndex = 17;
            this.txt_stockUC_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockUC_qty_KeyPress);
            // 
            // lbl_stockUC_qty
            // 
            this.lbl_stockUC_qty.AutoSize = true;
            this.lbl_stockUC_qty.Location = new System.Drawing.Point(12, 148);
            this.lbl_stockUC_qty.Name = "lbl_stockUC_qty";
            this.lbl_stockUC_qty.Size = new System.Drawing.Size(68, 20);
            this.lbl_stockUC_qty.TabIndex = 16;
            this.lbl_stockUC_qty.Text = "Quantity";
            // 
            // txt_stockUC_discount
            // 
            this.txt_stockUC_discount.Location = new System.Drawing.Point(413, 95);
            this.txt_stockUC_discount.Name = "txt_stockUC_discount";
            this.txt_stockUC_discount.Size = new System.Drawing.Size(100, 26);
            this.txt_stockUC_discount.TabIndex = 15;
            this.txt_stockUC_discount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockUC_discount_KeyPress);
            // 
            // lbl_stockUC_discount
            // 
            this.lbl_stockUC_discount.AutoSize = true;
            this.lbl_stockUC_discount.Location = new System.Drawing.Point(283, 98);
            this.lbl_stockUC_discount.Name = "lbl_stockUC_discount";
            this.lbl_stockUC_discount.Size = new System.Drawing.Size(124, 20);
            this.lbl_stockUC_discount.TabIndex = 14;
            this.lbl_stockUC_discount.Text = "Buying Discount";
            // 
            // txt_stockUC_unitPrice
            // 
            this.txt_stockUC_unitPrice.Location = new System.Drawing.Point(98, 95);
            this.txt_stockUC_unitPrice.Name = "txt_stockUC_unitPrice";
            this.txt_stockUC_unitPrice.Size = new System.Drawing.Size(100, 26);
            this.txt_stockUC_unitPrice.TabIndex = 13;
            this.txt_stockUC_unitPrice.TextChanged += new System.EventHandler(this.txt_inventoryUC_reorder_TextChanged);
            this.txt_stockUC_unitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_stockUC_unitPrice_KeyPress);
            // 
            // lbl_stockUC_unitPrice
            // 
            this.lbl_stockUC_unitPrice.AutoSize = true;
            this.lbl_stockUC_unitPrice.Location = new System.Drawing.Point(12, 98);
            this.lbl_stockUC_unitPrice.Name = "lbl_stockUC_unitPrice";
            this.lbl_stockUC_unitPrice.Size = new System.Drawing.Size(77, 20);
            this.lbl_stockUC_unitPrice.TabIndex = 12;
            this.lbl_stockUC_unitPrice.Text = "Unit Price";
            this.lbl_stockUC_unitPrice.Click += new System.EventHandler(this.lbl_inventoryUC_reorderLevel_Click);
            // 
            // lbl_stockUC_type
            // 
            this.lbl_stockUC_type.AutoSize = true;
            this.lbl_stockUC_type.Location = new System.Drawing.Point(553, 45);
            this.lbl_stockUC_type.Name = "lbl_stockUC_type";
            this.lbl_stockUC_type.Size = new System.Drawing.Size(43, 20);
            this.lbl_stockUC_type.TabIndex = 10;
            this.lbl_stockUC_type.Text = "Type";
            // 
            // lbl_stockUC_Name
            // 
            this.lbl_stockUC_Name.AutoSize = true;
            this.lbl_stockUC_Name.Location = new System.Drawing.Point(283, 45);
            this.lbl_stockUC_Name.Name = "lbl_stockUC_Name";
            this.lbl_stockUC_Name.Size = new System.Drawing.Size(51, 20);
            this.lbl_stockUC_Name.TabIndex = 8;
            this.lbl_stockUC_Name.Text = "Name";
            // 
            // lbl_stockUC_make
            // 
            this.lbl_stockUC_make.AutoSize = true;
            this.lbl_stockUC_make.Location = new System.Drawing.Point(12, 45);
            this.lbl_stockUC_make.Name = "lbl_stockUC_make";
            this.lbl_stockUC_make.Size = new System.Drawing.Size(48, 20);
            this.lbl_stockUC_make.TabIndex = 6;
            this.lbl_stockUC_make.Text = "Make";
            // 
            // StockDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 451);
            this.Controls.Add(this.groupBox1);
            this.Name = "StockDetailsForm";
            this.Load += new System.EventHandler(this.StockDetailsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_stockUC_stock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_stockUC_type;
        private System.Windows.Forms.Label lbl_stockUC_Name;
        private System.Windows.Forms.Label lbl_stockUC_make;
        private System.Windows.Forms.TextBox txt_stockUC_unitPrice;
        private System.Windows.Forms.Label lbl_stockUC_unitPrice;
        private System.Windows.Forms.TextBox txt_stockUC_discount;
        private System.Windows.Forms.Label lbl_stockUC_discount;
        private System.Windows.Forms.Label lbl_stockUC_date;
        private System.Windows.Forms.DateTimePicker dtp_stockUC;
        private System.Windows.Forms.TextBox txt_stockUC_qty;
        private System.Windows.Forms.Label lbl_stockUC_qty;
        private System.Windows.Forms.ComboBox cmb_stockUC_type;
        private System.Windows.Forms.ComboBox cmb_stockUC_name;
        private System.Windows.Forms.ComboBox cmb_stockUC_make;
        private System.Windows.Forms.Button btn_stockUC_search;
        private System.Windows.Forms.ComboBox txtINsupplier;
        private System.Windows.Forms.Label lblINsupplier;
        private System.Windows.Forms.DataGridView dgv_stockUC_stock;
        private System.Windows.Forms.Button btn_stockUC_demo;
        private System.Windows.Forms.Button btn_stockUC_clear;
        private System.Windows.Forms.Button btn_stockUC_delete;
        private System.Windows.Forms.Button btn_stockUC_update;
        private System.Windows.Forms.Button btn_stockUC_add;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox ltb_stockUC;
    }
}
