namespace SBW.UI.Sales_n_Profit
{
    partial class OldBattery
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_old_battery_add = new System.Windows.Forms.Button();
            this.txtbx_oldbattery_batchNo = new System.Windows.Forms.TextBox();
            this.lbl_batchNo = new System.Windows.Forms.Label();
            this.lbl_numOfBatteries = new System.Windows.Forms.Label();
            this.txtbx_numberOfBatteries = new System.Windows.Forms.TextBox();
            this.lbl_oldbatery_price = new System.Windows.Forms.Label();
            this.txtbx_oldbattery_price = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_old_battery_add
            // 
            this.btn_old_battery_add.Location = new System.Drawing.Point(544, 107);
            this.btn_old_battery_add.Name = "btn_old_battery_add";
            this.btn_old_battery_add.Size = new System.Drawing.Size(103, 38);
            this.btn_old_battery_add.TabIndex = 0;
            this.btn_old_battery_add.Text = "Add Batery Batch";
            this.btn_old_battery_add.UseVisualStyleBackColor = true;
            // 
            // txtbx_oldbattery_batchNo
            // 
            this.txtbx_oldbattery_batchNo.Location = new System.Drawing.Point(79, 56);
            this.txtbx_oldbattery_batchNo.Name = "txtbx_oldbattery_batchNo";
            this.txtbx_oldbattery_batchNo.Size = new System.Drawing.Size(100, 20);
            this.txtbx_oldbattery_batchNo.TabIndex = 1;
            // 
            // lbl_batchNo
            // 
            this.lbl_batchNo.AutoSize = true;
            this.lbl_batchNo.Location = new System.Drawing.Point(21, 59);
            this.lbl_batchNo.Name = "lbl_batchNo";
            this.lbl_batchNo.Size = new System.Drawing.Size(52, 13);
            this.lbl_batchNo.TabIndex = 2;
            this.lbl_batchNo.Text = "Batch No";
            this.lbl_batchNo.Click += new System.EventHandler(this.lbl_batchNo_Click);
            // 
            // lbl_numOfBatteries
            // 
            this.lbl_numOfBatteries.AutoSize = true;
            this.lbl_numOfBatteries.Location = new System.Drawing.Point(215, 59);
            this.lbl_numOfBatteries.Name = "lbl_numOfBatteries";
            this.lbl_numOfBatteries.Size = new System.Drawing.Size(97, 13);
            this.lbl_numOfBatteries.TabIndex = 4;
            this.lbl_numOfBatteries.Text = "Number of Bateries";
            // 
            // txtbx_numberOfBatteries
            // 
            this.txtbx_numberOfBatteries.Location = new System.Drawing.Point(318, 56);
            this.txtbx_numberOfBatteries.Name = "txtbx_numberOfBatteries";
            this.txtbx_numberOfBatteries.Size = new System.Drawing.Size(100, 20);
            this.txtbx_numberOfBatteries.TabIndex = 3;
            // 
            // lbl_oldbatery_price
            // 
            this.lbl_oldbatery_price.AutoSize = true;
            this.lbl_oldbatery_price.Location = new System.Drawing.Point(444, 59);
            this.lbl_oldbatery_price.Name = "lbl_oldbatery_price";
            this.lbl_oldbatery_price.Size = new System.Drawing.Size(79, 13);
            this.lbl_oldbatery_price.TabIndex = 6;
            this.lbl_oldbatery_price.Text = "Purchese Price";
            // 
            // txtbx_oldbattery_price
            // 
            this.txtbx_oldbattery_price.Location = new System.Drawing.Point(547, 56);
            this.txtbx_oldbattery_price.Name = "txtbx_oldbattery_price";
            this.txtbx_oldbattery_price.Size = new System.Drawing.Size(100, 20);
            this.txtbx_oldbattery_price.TabIndex = 5;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(680, 221);
            this.dataGridView1.TabIndex = 7;
            // 
            // OldBattery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 422);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_oldbatery_price);
            this.Controls.Add(this.txtbx_oldbattery_price);
            this.Controls.Add(this.lbl_numOfBatteries);
            this.Controls.Add(this.txtbx_numberOfBatteries);
            this.Controls.Add(this.lbl_batchNo);
            this.Controls.Add(this.txtbx_oldbattery_batchNo);
            this.Controls.Add(this.btn_old_battery_add);
            this.Name = "OldBattery";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_old_battery_add;
        private System.Windows.Forms.TextBox txtbx_oldbattery_batchNo;
        private System.Windows.Forms.Label lbl_batchNo;
        private System.Windows.Forms.Label lbl_numOfBatteries;
        private System.Windows.Forms.TextBox txtbx_numberOfBatteries;
        private System.Windows.Forms.Label lbl_oldbatery_price;
        private System.Windows.Forms.TextBox txtbx_oldbattery_price;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}