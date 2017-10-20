namespace SBW.UI.CustomerUserControls
{
    partial class customerDetailsForm
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
            this.gb_cus_details = new System.Windows.Forms.GroupBox();
            this.rtxtb_cus_address = new System.Windows.Forms.RichTextBox();
            this.btn_cus_clear = new System.Windows.Forms.Button();
            this.btn_cus_delete = new System.Windows.Forms.Button();
            this.btn_cus_update = new System.Windows.Forms.Button();
            this.btn_cus_add = new System.Windows.Forms.Button();
            this.cmb_cus_type = new System.Windows.Forms.ComboBox();
            this.txtb_cus_email = new System.Windows.Forms.TextBox();
            this.txtb_cus_mobile = new System.Windows.Forms.TextBox();
            this.txtb_cus_name = new System.Windows.Forms.TextBox();
            this.lbl_cus_type = new System.Windows.Forms.Label();
            this.lbl_cus_email = new System.Windows.Forms.Label();
            this.lbl_cus_mobile = new System.Windows.Forms.Label();
            this.lbl_cus_address = new System.Windows.Forms.Label();
            this.lbl_cus_name = new System.Windows.Forms.Label();
            this.txtb_cus_nic = new System.Windows.Forms.TextBox();
            this.lbl_cus_nic = new System.Windows.Forms.Label();
            this.lbl_cus_searchkey = new System.Windows.Forms.Label();
            this.gb_cus_mgt = new System.Windows.Forms.GroupBox();
            this.dgv_cus_table = new System.Windows.Forms.DataGridView();
            this.txt_cus_searchkey = new System.Windows.Forms.TextBox();
            this.btn_cus_demo = new System.Windows.Forms.Button();
            this.gb_cus_details.SuspendLayout();
            this.gb_cus_mgt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus_table)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_cus_details
            // 
            this.gb_cus_details.Controls.Add(this.rtxtb_cus_address);
            this.gb_cus_details.Controls.Add(this.btn_cus_clear);
            this.gb_cus_details.Controls.Add(this.btn_cus_delete);
            this.gb_cus_details.Controls.Add(this.btn_cus_update);
            this.gb_cus_details.Controls.Add(this.btn_cus_add);
            this.gb_cus_details.Controls.Add(this.cmb_cus_type);
            this.gb_cus_details.Controls.Add(this.txtb_cus_email);
            this.gb_cus_details.Controls.Add(this.txtb_cus_mobile);
            this.gb_cus_details.Controls.Add(this.txtb_cus_name);
            this.gb_cus_details.Controls.Add(this.lbl_cus_type);
            this.gb_cus_details.Controls.Add(this.lbl_cus_email);
            this.gb_cus_details.Controls.Add(this.lbl_cus_mobile);
            this.gb_cus_details.Controls.Add(this.lbl_cus_address);
            this.gb_cus_details.Controls.Add(this.lbl_cus_name);
            this.gb_cus_details.Controls.Add(this.txtb_cus_nic);
            this.gb_cus_details.Controls.Add(this.lbl_cus_nic);
            this.gb_cus_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_cus_details.Location = new System.Drawing.Point(38, 25);
            this.gb_cus_details.Name = "gb_cus_details";
            this.gb_cus_details.Size = new System.Drawing.Size(835, 225);
            this.gb_cus_details.TabIndex = 0;
            this.gb_cus_details.TabStop = false;
            this.gb_cus_details.Text = "Customer Details";
            // 
            // rtxtb_cus_address
            // 
            this.rtxtb_cus_address.Location = new System.Drawing.Point(149, 126);
            this.rtxtb_cus_address.Name = "rtxtb_cus_address";
            this.rtxtb_cus_address.Size = new System.Drawing.Size(190, 30);
            this.rtxtb_cus_address.TabIndex = 16;
            this.rtxtb_cus_address.Text = "";
            // 
            // btn_cus_clear
            // 
            this.btn_cus_clear.Location = new System.Drawing.Point(713, 172);
            this.btn_cus_clear.Name = "btn_cus_clear";
            this.btn_cus_clear.Size = new System.Drawing.Size(82, 29);
            this.btn_cus_clear.TabIndex = 15;
            this.btn_cus_clear.Text = "CLEAR";
            this.btn_cus_clear.UseVisualStyleBackColor = true;
            this.btn_cus_clear.Click += new System.EventHandler(this.btn_cus_clear_Click);
            // 
            // btn_cus_delete
            // 
            this.btn_cus_delete.Location = new System.Drawing.Point(605, 172);
            this.btn_cus_delete.Name = "btn_cus_delete";
            this.btn_cus_delete.Size = new System.Drawing.Size(82, 29);
            this.btn_cus_delete.TabIndex = 14;
            this.btn_cus_delete.Text = "DELETE";
            this.btn_cus_delete.UseVisualStyleBackColor = true;
            this.btn_cus_delete.Click += new System.EventHandler(this.btn_cus_delete_Click);
            // 
            // btn_cus_update
            // 
            this.btn_cus_update.Location = new System.Drawing.Point(487, 172);
            this.btn_cus_update.Name = "btn_cus_update";
            this.btn_cus_update.Size = new System.Drawing.Size(82, 29);
            this.btn_cus_update.TabIndex = 13;
            this.btn_cus_update.Text = "UPDATE";
            this.btn_cus_update.UseVisualStyleBackColor = true;
            this.btn_cus_update.Click += new System.EventHandler(this.btn_cus_update_Click);
            // 
            // btn_cus_add
            // 
            this.btn_cus_add.Location = new System.Drawing.Point(375, 172);
            this.btn_cus_add.Name = "btn_cus_add";
            this.btn_cus_add.Size = new System.Drawing.Size(82, 29);
            this.btn_cus_add.TabIndex = 12;
            this.btn_cus_add.Text = "ADD";
            this.btn_cus_add.UseVisualStyleBackColor = true;
            this.btn_cus_add.Click += new System.EventHandler(this.btn_cus_add_Click);
            // 
            // cmb_cus_type
            // 
            this.cmb_cus_type.FormattingEnabled = true;
            this.cmb_cus_type.Location = new System.Drawing.Point(605, 84);
            this.cmb_cus_type.Name = "cmb_cus_type";
            this.cmb_cus_type.Size = new System.Drawing.Size(190, 28);
            this.cmb_cus_type.TabIndex = 11;
            // 
            // txtb_cus_email
            // 
            this.txtb_cus_email.Location = new System.Drawing.Point(605, 34);
            this.txtb_cus_email.Name = "txtb_cus_email";
            this.txtb_cus_email.Size = new System.Drawing.Size(190, 26);
            this.txtb_cus_email.TabIndex = 10;
            // 
            // txtb_cus_mobile
            // 
            this.txtb_cus_mobile.Location = new System.Drawing.Point(149, 175);
            this.txtb_cus_mobile.Name = "txtb_cus_mobile";
            this.txtb_cus_mobile.Size = new System.Drawing.Size(190, 26);
            this.txtb_cus_mobile.TabIndex = 9;
            this.txtb_cus_mobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cus_mobileno_KeyPress);
            // 
            // txtb_cus_name
            // 
            this.txtb_cus_name.Location = new System.Drawing.Point(149, 80);
            this.txtb_cus_name.Name = "txtb_cus_name";
            this.txtb_cus_name.Size = new System.Drawing.Size(190, 26);
            this.txtb_cus_name.TabIndex = 7;
            // 
            // lbl_cus_type
            // 
            this.lbl_cus_type.AutoSize = true;
            this.lbl_cus_type.Location = new System.Drawing.Point(483, 92);
            this.lbl_cus_type.Name = "lbl_cus_type";
            this.lbl_cus_type.Size = new System.Drawing.Size(43, 20);
            this.lbl_cus_type.TabIndex = 6;
            this.lbl_cus_type.Text = "Type";
            // 
            // lbl_cus_email
            // 
            this.lbl_cus_email.AutoSize = true;
            this.lbl_cus_email.Location = new System.Drawing.Point(483, 34);
            this.lbl_cus_email.Name = "lbl_cus_email";
            this.lbl_cus_email.Size = new System.Drawing.Size(48, 20);
            this.lbl_cus_email.TabIndex = 5;
            this.lbl_cus_email.Text = "Email";
            // 
            // lbl_cus_mobile
            // 
            this.lbl_cus_mobile.AutoSize = true;
            this.lbl_cus_mobile.Location = new System.Drawing.Point(28, 181);
            this.lbl_cus_mobile.Name = "lbl_cus_mobile";
            this.lbl_cus_mobile.Size = new System.Drawing.Size(79, 20);
            this.lbl_cus_mobile.TabIndex = 4;
            this.lbl_cus_mobile.Text = "Mobile No";
            // 
            // lbl_cus_address
            // 
            this.lbl_cus_address.AutoSize = true;
            this.lbl_cus_address.Location = new System.Drawing.Point(28, 129);
            this.lbl_cus_address.Name = "lbl_cus_address";
            this.lbl_cus_address.Size = new System.Drawing.Size(68, 20);
            this.lbl_cus_address.TabIndex = 3;
            this.lbl_cus_address.Text = "Address";
            // 
            // lbl_cus_name
            // 
            this.lbl_cus_name.AutoSize = true;
            this.lbl_cus_name.Location = new System.Drawing.Point(28, 86);
            this.lbl_cus_name.Name = "lbl_cus_name";
            this.lbl_cus_name.Size = new System.Drawing.Size(51, 20);
            this.lbl_cus_name.TabIndex = 2;
            this.lbl_cus_name.Text = "Name";
            // 
            // txtb_cus_nic
            // 
            this.txtb_cus_nic.Location = new System.Drawing.Point(149, 31);
            this.txtb_cus_nic.Name = "txtb_cus_nic";
            this.txtb_cus_nic.Size = new System.Drawing.Size(190, 26);
            this.txtb_cus_nic.TabIndex = 1;
            this.txtb_cus_nic.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_cus_nic_KeyPress);
            // 
            // lbl_cus_nic
            // 
            this.lbl_cus_nic.AutoSize = true;
            this.lbl_cus_nic.Location = new System.Drawing.Point(28, 34);
            this.lbl_cus_nic.Name = "lbl_cus_nic";
            this.lbl_cus_nic.Size = new System.Drawing.Size(36, 20);
            this.lbl_cus_nic.TabIndex = 0;
            this.lbl_cus_nic.Text = "NIC";
            // 
            // lbl_cus_searchkey
            // 
            this.lbl_cus_searchkey.AutoSize = true;
            this.lbl_cus_searchkey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cus_searchkey.Location = new System.Drawing.Point(28, 16);
            this.lbl_cus_searchkey.Name = "lbl_cus_searchkey";
            this.lbl_cus_searchkey.Size = new System.Drawing.Size(193, 20);
            this.lbl_cus_searchkey.TabIndex = 0;
            this.lbl_cus_searchkey.Text = "Search Key ( NIC / Name )";
            // 
            // gb_cus_mgt
            // 
            this.gb_cus_mgt.Controls.Add(this.btn_cus_demo);
            this.gb_cus_mgt.Controls.Add(this.dgv_cus_table);
            this.gb_cus_mgt.Controls.Add(this.txt_cus_searchkey);
            this.gb_cus_mgt.Controls.Add(this.lbl_cus_searchkey);
            this.gb_cus_mgt.Location = new System.Drawing.Point(38, 256);
            this.gb_cus_mgt.MaximumSize = new System.Drawing.Size(835, 400);
            this.gb_cus_mgt.MinimumSize = new System.Drawing.Size(835, 400);
            this.gb_cus_mgt.Name = "gb_cus_mgt";
            this.gb_cus_mgt.Size = new System.Drawing.Size(835, 400);
            this.gb_cus_mgt.TabIndex = 1;
            this.gb_cus_mgt.TabStop = false;
            // 
            // dgv_cus_table
            // 
            this.dgv_cus_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cus_table.Location = new System.Drawing.Point(32, 66);
            this.dgv_cus_table.Name = "dgv_cus_table";
            this.dgv_cus_table.Size = new System.Drawing.Size(763, 195);
            this.dgv_cus_table.TabIndex = 2;
            this.dgv_cus_table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cus_CellContentClick);
            this.dgv_cus_table.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_cus_table_RowHeaderMouseClick);
            // 
            // txt_cus_searchkey
            // 
            this.txt_cus_searchkey.Location = new System.Drawing.Point(260, 18);
            this.txt_cus_searchkey.MaximumSize = new System.Drawing.Size(190, 26);
            this.txt_cus_searchkey.MinimumSize = new System.Drawing.Size(190, 26);
            this.txt_cus_searchkey.Multiline = true;
            this.txt_cus_searchkey.Name = "txt_cus_searchkey";
            this.txt_cus_searchkey.Size = new System.Drawing.Size(190, 26);
            this.txt_cus_searchkey.TabIndex = 1;
            this.txt_cus_searchkey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cus_searchkey_KeyPress);
            // 
            // btn_cus_demo
            // 
            this.btn_cus_demo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cus_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_cus_demo.Location = new System.Drawing.Point(713, 12);
            this.btn_cus_demo.Name = "btn_cus_demo";
            this.btn_cus_demo.Size = new System.Drawing.Size(82, 29);
            this.btn_cus_demo.TabIndex = 5;
            this.btn_cus_demo.Text = "DEMO";
            this.btn_cus_demo.UseVisualStyleBackColor = true;
            this.btn_cus_demo.Click += new System.EventHandler(this.btn_cus_demo_Click);
            // 
            // customerDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_cus_mgt);
            this.Controls.Add(this.gb_cus_details);
            this.MaximumSize = new System.Drawing.Size(1060, 700);
            this.MinimumSize = new System.Drawing.Size(1060, 700);
            this.Name = "customerDetailsForm";
            this.Size = new System.Drawing.Size(1060, 700);
            this.Load += new System.EventHandler(this.customerDetailsForm_Load);
            this.gb_cus_details.ResumeLayout(false);
            this.gb_cus_details.PerformLayout();
            this.gb_cus_mgt.ResumeLayout(false);
            this.gb_cus_mgt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cus_table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_cus_details;
        private System.Windows.Forms.Label lbl_cus_type;
        private System.Windows.Forms.Label lbl_cus_email;
        private System.Windows.Forms.Label lbl_cus_mobile;
        private System.Windows.Forms.Label lbl_cus_address;
        private System.Windows.Forms.Label lbl_cus_name;
        private System.Windows.Forms.TextBox txtb_cus_nic;
        private System.Windows.Forms.Label lbl_cus_nic;
        private System.Windows.Forms.TextBox txtb_cus_email;
        private System.Windows.Forms.TextBox txtb_cus_mobile;
        private System.Windows.Forms.TextBox txtb_cus_name;
        private System.Windows.Forms.ComboBox cmb_cus_type;
        private System.Windows.Forms.Button btn_cus_clear;
        private System.Windows.Forms.Button btn_cus_delete;
        private System.Windows.Forms.Button btn_cus_update;
        private System.Windows.Forms.Button btn_cus_add;
        private System.Windows.Forms.Label lbl_cus_searchkey;
        private System.Windows.Forms.GroupBox gb_cus_mgt;
        private System.Windows.Forms.DataGridView dgv_cus_table;
        private System.Windows.Forms.TextBox txt_cus_searchkey;
        private System.Windows.Forms.Button btn_cus_demo;
        private System.Windows.Forms.RichTextBox rtxtb_cus_address;
    }
}
