namespace SBW.UI.CustomerUserControls
{
    partial class customerLoyaltyCardForm
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
            this.gpb_cuc_loyalty = new System.Windows.Forms.GroupBox();
            this.btn_cusLoy_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_loymem_cardno = new System.Windows.Forms.Label();
            this.btn_loy_update = new System.Windows.Forms.Button();
            this.btn_loy_delete = new System.Windows.Forms.Button();
            this.btn_loy_add = new System.Windows.Forms.Button();
            this.cmb_loy_cardtype = new System.Windows.Forms.ComboBox();
            this.txt_loy_nic = new System.Windows.Forms.TextBox();
            this.lbl_loy_cardtype = new System.Windows.Forms.Label();
            this.lbl_loy_nic = new System.Windows.Forms.Label();
            this.gp_loyaltycard = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_loy_selectCardType = new System.Windows.Forms.ComboBox();
            this.dgv_loyalty_table = new System.Windows.Forms.DataGridView();
            this.gpb_cuc_loyalty.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gp_loyaltycard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loyalty_table)).BeginInit();
            this.SuspendLayout();
            // 
            // gpb_cuc_loyalty
            // 
            this.gpb_cuc_loyalty.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpb_cuc_loyalty.Controls.Add(this.btn_cusLoy_clear);
            this.gpb_cuc_loyalty.Controls.Add(this.groupBox1);
            this.gpb_cuc_loyalty.Controls.Add(this.btn_loy_update);
            this.gpb_cuc_loyalty.Controls.Add(this.btn_loy_delete);
            this.gpb_cuc_loyalty.Controls.Add(this.btn_loy_add);
            this.gpb_cuc_loyalty.Controls.Add(this.cmb_loy_cardtype);
            this.gpb_cuc_loyalty.Controls.Add(this.txt_loy_nic);
            this.gpb_cuc_loyalty.Controls.Add(this.lbl_loy_cardtype);
            this.gpb_cuc_loyalty.Controls.Add(this.lbl_loy_nic);
            this.gpb_cuc_loyalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_cuc_loyalty.Location = new System.Drawing.Point(27, 24);
            this.gpb_cuc_loyalty.Name = "gpb_cuc_loyalty";
            this.gpb_cuc_loyalty.Size = new System.Drawing.Size(970, 243);
            this.gpb_cuc_loyalty.TabIndex = 23;
            this.gpb_cuc_loyalty.TabStop = false;
            this.gpb_cuc_loyalty.Text = "Loyalty Details";
            this.gpb_cuc_loyalty.Enter += new System.EventHandler(this.gpb_cuc_loyalty_Enter);
            // 
            // btn_cusLoy_clear
            // 
            this.btn_cusLoy_clear.Location = new System.Drawing.Point(710, 186);
            this.btn_cusLoy_clear.Name = "btn_cusLoy_clear";
            this.btn_cusLoy_clear.Size = new System.Drawing.Size(89, 29);
            this.btn_cusLoy_clear.TabIndex = 39;
            this.btn_cusLoy_clear.Text = "CLEAR";
            this.btn_cusLoy_clear.UseVisualStyleBackColor = true;
            this.btn_cusLoy_clear.Click += new System.EventHandler(this.btn_cusLoy_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_loymem_cardno);
            this.groupBox1.Location = new System.Drawing.Point(20, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 78);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Card No";
            // 
            // lbl_loymem_cardno
            // 
            this.lbl_loymem_cardno.AutoSize = true;
            this.lbl_loymem_cardno.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loymem_cardno.Location = new System.Drawing.Point(107, 31);
            this.lbl_loymem_cardno.Name = "lbl_loymem_cardno";
            this.lbl_loymem_cardno.Size = new System.Drawing.Size(51, 22);
            this.lbl_loymem_cardno.TabIndex = 0;
            this.lbl_loymem_cardno.Text = "Click\r\n";
            this.lbl_loymem_cardno.Click += new System.EventHandler(this.lbl_loymem_cardno_Click);
            // 
            // btn_loy_update
            // 
            this.btn_loy_update.Location = new System.Drawing.Point(577, 39);
            this.btn_loy_update.Name = "btn_loy_update";
            this.btn_loy_update.Size = new System.Drawing.Size(82, 29);
            this.btn_loy_update.TabIndex = 31;
            this.btn_loy_update.Text = "UPDATE";
            this.btn_loy_update.UseVisualStyleBackColor = true;
            this.btn_loy_update.Click += new System.EventHandler(this.btn_loy_update_Click);
            // 
            // btn_loy_delete
            // 
            this.btn_loy_delete.Location = new System.Drawing.Point(710, 39);
            this.btn_loy_delete.Name = "btn_loy_delete";
            this.btn_loy_delete.Size = new System.Drawing.Size(89, 29);
            this.btn_loy_delete.TabIndex = 30;
            this.btn_loy_delete.Text = "DELETE";
            this.btn_loy_delete.UseVisualStyleBackColor = true;
            // 
            // btn_loy_add
            // 
            this.btn_loy_add.Location = new System.Drawing.Point(447, 39);
            this.btn_loy_add.Name = "btn_loy_add";
            this.btn_loy_add.Size = new System.Drawing.Size(82, 29);
            this.btn_loy_add.TabIndex = 29;
            this.btn_loy_add.Text = "ADD";
            this.btn_loy_add.UseVisualStyleBackColor = true;
            this.btn_loy_add.Click += new System.EventHandler(this.btn_loy_add_Click);
            // 
            // cmb_loy_cardtype
            // 
            this.cmb_loy_cardtype.FormattingEnabled = true;
            this.cmb_loy_cardtype.Location = new System.Drawing.Point(131, 96);
            this.cmb_loy_cardtype.Name = "cmb_loy_cardtype";
            this.cmb_loy_cardtype.Size = new System.Drawing.Size(190, 28);
            this.cmb_loy_cardtype.TabIndex = 33;
            // 
            // txt_loy_nic
            // 
            this.txt_loy_nic.Location = new System.Drawing.Point(131, 45);
            this.txt_loy_nic.Name = "txt_loy_nic";
            this.txt_loy_nic.Size = new System.Drawing.Size(190, 26);
            this.txt_loy_nic.TabIndex = 32;
            this.txt_loy_nic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_loy_nic_KeyPress);
            // 
            // lbl_loy_cardtype
            // 
            this.lbl_loy_cardtype.AutoSize = true;
            this.lbl_loy_cardtype.Location = new System.Drawing.Point(16, 104);
            this.lbl_loy_cardtype.Name = "lbl_loy_cardtype";
            this.lbl_loy_cardtype.Size = new System.Drawing.Size(81, 20);
            this.lbl_loy_cardtype.TabIndex = 21;
            this.lbl_loy_cardtype.Text = "Card Type";
            // 
            // lbl_loy_nic
            // 
            this.lbl_loy_nic.AutoSize = true;
            this.lbl_loy_nic.Location = new System.Drawing.Point(16, 48);
            this.lbl_loy_nic.Name = "lbl_loy_nic";
            this.lbl_loy_nic.Size = new System.Drawing.Size(36, 20);
            this.lbl_loy_nic.TabIndex = 13;
            this.lbl_loy_nic.Text = "NIC";
            // 
            // gp_loyaltycard
            // 
            this.gp_loyaltycard.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gp_loyaltycard.Controls.Add(this.label1);
            this.gp_loyaltycard.Controls.Add(this.cmb_loy_selectCardType);
            this.gp_loyaltycard.Controls.Add(this.dgv_loyalty_table);
            this.gp_loyaltycard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_loyaltycard.Location = new System.Drawing.Point(27, 273);
            this.gp_loyaltycard.MaximumSize = new System.Drawing.Size(970, 400);
            this.gp_loyaltycard.MinimumSize = new System.Drawing.Size(970, 400);
            this.gp_loyaltycard.Name = "gp_loyaltycard";
            this.gp_loyaltycard.Size = new System.Drawing.Size(970, 400);
            this.gp_loyaltycard.TabIndex = 24;
            this.gp_loyaltycard.TabStop = false;
            this.gp_loyaltycard.Text = "Loyalty Card";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 32;
            this.label1.Text = "Select Card Type";
            // 
            // cmb_loy_selectCardType
            // 
            this.cmb_loy_selectCardType.FormattingEnabled = true;
            this.cmb_loy_selectCardType.Items.AddRange(new object[] {
            "All",
            "Gold Customers",
            "Silver Customers",
            "Bronze Customers"});
            this.cmb_loy_selectCardType.Location = new System.Drawing.Point(178, 44);
            this.cmb_loy_selectCardType.Name = "cmb_loy_selectCardType";
            this.cmb_loy_selectCardType.Size = new System.Drawing.Size(190, 28);
            this.cmb_loy_selectCardType.TabIndex = 31;
            this.cmb_loy_selectCardType.Text = "All";
            this.cmb_loy_selectCardType.SelectedIndexChanged += new System.EventHandler(this.combo_grid_SelectedIndexChanged);
            // 
            // dgv_loyalty_table
            // 
            this.dgv_loyalty_table.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_loyalty_table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_loyalty_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_loyalty_table.Location = new System.Drawing.Point(20, 94);
            this.dgv_loyalty_table.Name = "dgv_loyalty_table";
            this.dgv_loyalty_table.ReadOnly = true;
            this.dgv_loyalty_table.Size = new System.Drawing.Size(898, 195);
            this.dgv_loyalty_table.TabIndex = 21;
            this.dgv_loyalty_table.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_loyalty_table_RowHeaderMouseClick);
            // 
            // customerLoyaltyCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gp_loyaltycard);
            this.Controls.Add(this.gpb_cuc_loyalty);
            this.MaximumSize = new System.Drawing.Size(1060, 700);
            this.MinimumSize = new System.Drawing.Size(1060, 700);
            this.Name = "customerLoyaltyCardForm";
            this.Size = new System.Drawing.Size(1060, 700);
            this.Load += new System.EventHandler(this.customerLoyaltyCardForm_Load);
            this.gpb_cuc_loyalty.ResumeLayout(false);
            this.gpb_cuc_loyalty.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gp_loyaltycard.ResumeLayout(false);
            this.gp_loyaltycard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_loyalty_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_cuc_loyalty;
        private System.Windows.Forms.Button btn_cusLoy_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_loymem_cardno;
        private System.Windows.Forms.Button btn_loy_update;
        private System.Windows.Forms.Button btn_loy_delete;
        private System.Windows.Forms.Button btn_loy_add;
        private System.Windows.Forms.ComboBox cmb_loy_cardtype;
        public System.Windows.Forms.TextBox txt_loy_nic;
        private System.Windows.Forms.Label lbl_loy_cardtype;
        private System.Windows.Forms.Label lbl_loy_nic;
        private System.Windows.Forms.GroupBox gp_loyaltycard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_loy_selectCardType;
        public System.Windows.Forms.DataGridView dgv_loyalty_table;
    }
}
