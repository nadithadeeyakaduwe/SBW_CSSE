namespace SBW.UI
{
    partial class CustomerForm
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
            this.btn_customerUC = new System.Windows.Forms.Button();
            this.btn_emailUC = new System.Windows.Forms.Button();
            this.btn_loyaltycardUC = new System.Windows.Forms.Button();
            this.btn_reportUC = new System.Windows.Forms.Button();
            this.panel_customerform = new System.Windows.Forms.Panel();
            this.panel_customerform.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_customerUC
            // 
            this.btn_customerUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customerUC.Location = new System.Drawing.Point(204, 81);
            this.btn_customerUC.Name = "btn_customerUC";
            this.btn_customerUC.Size = new System.Drawing.Size(184, 100);
            this.btn_customerUC.TabIndex = 0;
            this.btn_customerUC.Text = "CUSTOMER";
            this.btn_customerUC.UseVisualStyleBackColor = true;
            this.btn_customerUC.Click += new System.EventHandler(this.btn_customerUC_Click);
            // 
            // btn_emailUC
            // 
            this.btn_emailUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_emailUC.Location = new System.Drawing.Point(204, 296);
            this.btn_emailUC.Name = "btn_emailUC";
            this.btn_emailUC.Size = new System.Drawing.Size(184, 100);
            this.btn_emailUC.TabIndex = 1;
            this.btn_emailUC.Text = "EMAIL";
            this.btn_emailUC.UseVisualStyleBackColor = true;
            this.btn_emailUC.Click += new System.EventHandler(this.btn_emailUC_Click);
            // 
            // btn_loyaltycardUC
            // 
            this.btn_loyaltycardUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_loyaltycardUC.Location = new System.Drawing.Point(635, 81);
            this.btn_loyaltycardUC.Name = "btn_loyaltycardUC";
            this.btn_loyaltycardUC.Size = new System.Drawing.Size(184, 100);
            this.btn_loyaltycardUC.TabIndex = 2;
            this.btn_loyaltycardUC.Text = "LOYALTY CARD";
            this.btn_loyaltycardUC.UseVisualStyleBackColor = true;
            this.btn_loyaltycardUC.Click += new System.EventHandler(this.btn_loyaltycardUC_Click);
            // 
            // btn_reportUC
            // 
            this.btn_reportUC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reportUC.Location = new System.Drawing.Point(635, 296);
            this.btn_reportUC.Name = "btn_reportUC";
            this.btn_reportUC.Size = new System.Drawing.Size(184, 100);
            this.btn_reportUC.TabIndex = 3;
            this.btn_reportUC.Text = "REPORT";
            this.btn_reportUC.UseVisualStyleBackColor = true;
            // 
            // panel_customerform
            // 
            this.panel_customerform.Controls.Add(this.btn_customerUC);
            this.panel_customerform.Controls.Add(this.btn_emailUC);
            this.panel_customerform.Controls.Add(this.btn_reportUC);
            this.panel_customerform.Controls.Add(this.btn_loyaltycardUC);
            this.panel_customerform.Location = new System.Drawing.Point(12, 12);
            this.panel_customerform.MaximumSize = new System.Drawing.Size(1020, 489);
            this.panel_customerform.MinimumSize = new System.Drawing.Size(1020, 489);
            this.panel_customerform.Name = "panel_customerform";
            this.panel_customerform.Size = new System.Drawing.Size(1020, 489);
            this.panel_customerform.TabIndex = 4;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 514);
            this.Controls.Add(this.panel_customerform);
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "CustomerForm";
            this.Text = "Customer";
            this.panel_customerform.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_customerUC;
        private System.Windows.Forms.Button btn_emailUC;
        private System.Windows.Forms.Button btn_loyaltycardUC;
        private System.Windows.Forms.Button btn_reportUC;
        private System.Windows.Forms.Panel panel_customerform;
    }
}