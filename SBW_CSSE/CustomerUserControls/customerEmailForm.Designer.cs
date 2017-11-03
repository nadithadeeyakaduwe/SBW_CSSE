namespace SBW.UI.CustomerUserControls
{
    partial class customerEmailForm
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
            this.lbl_email_nic = new System.Windows.Forms.Label();
            this.cmb_email_nic = new System.Windows.Forms.ComboBox();
            this.gp_cus_email1 = new System.Windows.Forms.GroupBox();
            this.txt_email_subject = new System.Windows.Forms.TextBox();
            this.txt_email_address = new System.Windows.Forms.TextBox();
            this.lbl_cus_email_address = new System.Windows.Forms.Label();
            this.lbl_cus_email_subject = new System.Windows.Forms.Label();
            this.gp_cus_email2 = new System.Windows.Forms.GroupBox();
            this.btn_email_demo = new System.Windows.Forms.Button();
            this.rtb_cus_email_body = new System.Windows.Forms.RichTextBox();
            this.btn_cusEmail_clear = new System.Windows.Forms.Button();
            this.btn_cus_email_send = new System.Windows.Forms.Button();
            this.gp_cus_email1.SuspendLayout();
            this.gp_cus_email2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_email_nic
            // 
            this.lbl_email_nic.AutoSize = true;
            this.lbl_email_nic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email_nic.Location = new System.Drawing.Point(29, 23);
            this.lbl_email_nic.Name = "lbl_email_nic";
            this.lbl_email_nic.Size = new System.Drawing.Size(109, 20);
            this.lbl_email_nic.TabIndex = 10;
            this.lbl_email_nic.Text = "Customer NIC";
            // 
            // cmb_email_nic
            // 
            this.cmb_email_nic.FormattingEnabled = true;
            this.cmb_email_nic.Location = new System.Drawing.Point(156, 22);
            this.cmb_email_nic.Name = "cmb_email_nic";
            this.cmb_email_nic.Size = new System.Drawing.Size(190, 21);
            this.cmb_email_nic.TabIndex = 13;
            this.cmb_email_nic.DropDown += new System.EventHandler(this.cmb_email_nic_DropDown);
            this.cmb_email_nic.SelectedIndexChanged += new System.EventHandler(this.cmb_email_nic_SelectedIndexChanged);
            this.cmb_email_nic.ValueMemberChanged += new System.EventHandler(this.cmb_email_nic_ValueMemberChanged);
            this.cmb_email_nic.DockChanged += new System.EventHandler(this.cmb_email_nic_DockChanged);
            this.cmb_email_nic.TextChanged += new System.EventHandler(this.cmb_email_nic_TextChanged);
            // 
            // gp_cus_email1
            // 
            this.gp_cus_email1.Controls.Add(this.txt_email_subject);
            this.gp_cus_email1.Controls.Add(this.txt_email_address);
            this.gp_cus_email1.Controls.Add(this.lbl_cus_email_address);
            this.gp_cus_email1.Controls.Add(this.lbl_cus_email_subject);
            this.gp_cus_email1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cus_email1.Location = new System.Drawing.Point(28, 82);
            this.gp_cus_email1.Name = "gp_cus_email1";
            this.gp_cus_email1.Size = new System.Drawing.Size(872, 155);
            this.gp_cus_email1.TabIndex = 14;
            this.gp_cus_email1.TabStop = false;
            this.gp_cus_email1.Text = "New Message";
            // 
            // txt_email_subject
            // 
            this.txt_email_subject.Location = new System.Drawing.Point(128, 103);
            this.txt_email_subject.Name = "txt_email_subject";
            this.txt_email_subject.Size = new System.Drawing.Size(722, 26);
            this.txt_email_subject.TabIndex = 6;
            // 
            // txt_email_address
            // 
            this.txt_email_address.Location = new System.Drawing.Point(128, 39);
            this.txt_email_address.Name = "txt_email_address";
            this.txt_email_address.Size = new System.Drawing.Size(722, 26);
            this.txt_email_address.TabIndex = 5;
            this.txt_email_address.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_email_address_KeyPress);
            // 
            // lbl_cus_email_address
            // 
            this.lbl_cus_email_address.AutoSize = true;
            this.lbl_cus_email_address.Location = new System.Drawing.Point(11, 40);
            this.lbl_cus_email_address.Name = "lbl_cus_email_address";
            this.lbl_cus_email_address.Size = new System.Drawing.Size(111, 20);
            this.lbl_cus_email_address.TabIndex = 0;
            this.lbl_cus_email_address.Text = "Email Address";
            // 
            // lbl_cus_email_subject
            // 
            this.lbl_cus_email_subject.AutoSize = true;
            this.lbl_cus_email_subject.Location = new System.Drawing.Point(11, 104);
            this.lbl_cus_email_subject.Name = "lbl_cus_email_subject";
            this.lbl_cus_email_subject.Size = new System.Drawing.Size(63, 20);
            this.lbl_cus_email_subject.TabIndex = 1;
            this.lbl_cus_email_subject.Text = "Subject";
            // 
            // gp_cus_email2
            // 
            this.gp_cus_email2.Controls.Add(this.btn_email_demo);
            this.gp_cus_email2.Controls.Add(this.rtb_cus_email_body);
            this.gp_cus_email2.Controls.Add(this.btn_cusEmail_clear);
            this.gp_cus_email2.Controls.Add(this.btn_cus_email_send);
            this.gp_cus_email2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_cus_email2.Location = new System.Drawing.Point(28, 259);
            this.gp_cus_email2.Name = "gp_cus_email2";
            this.gp_cus_email2.Size = new System.Drawing.Size(872, 275);
            this.gp_cus_email2.TabIndex = 15;
            this.gp_cus_email2.TabStop = false;
            this.gp_cus_email2.Text = "Message Content";
            // 
            // btn_email_demo
            // 
            this.btn_email_demo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_email_demo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_email_demo.Location = new System.Drawing.Point(780, 166);
            this.btn_email_demo.Name = "btn_email_demo";
            this.btn_email_demo.Size = new System.Drawing.Size(86, 30);
            this.btn_email_demo.TabIndex = 18;
            this.btn_email_demo.Text = "DEMO";
            this.btn_email_demo.UseVisualStyleBackColor = true;
            this.btn_email_demo.Click += new System.EventHandler(this.btn_email_demo_Click);
            // 
            // rtb_cus_email_body
            // 
            this.rtb_cus_email_body.Location = new System.Drawing.Point(14, 46);
            this.rtb_cus_email_body.Name = "rtb_cus_email_body";
            this.rtb_cus_email_body.Size = new System.Drawing.Size(746, 206);
            this.rtb_cus_email_body.TabIndex = 0;
            this.rtb_cus_email_body.Text = " ";
            // 
            // btn_cusEmail_clear
            // 
            this.btn_cusEmail_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cusEmail_clear.Location = new System.Drawing.Point(780, 130);
            this.btn_cusEmail_clear.Name = "btn_cusEmail_clear";
            this.btn_cusEmail_clear.Size = new System.Drawing.Size(86, 30);
            this.btn_cusEmail_clear.TabIndex = 17;
            this.btn_cusEmail_clear.Text = "CLEAR";
            this.btn_cusEmail_clear.UseVisualStyleBackColor = true;
            this.btn_cusEmail_clear.Click += new System.EventHandler(this.btn_cusEmail_clear_Click);
            // 
            // btn_cus_email_send
            // 
            this.btn_cus_email_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cus_email_send.Location = new System.Drawing.Point(780, 46);
            this.btn_cus_email_send.Name = "btn_cus_email_send";
            this.btn_cus_email_send.Size = new System.Drawing.Size(86, 30);
            this.btn_cus_email_send.TabIndex = 16;
            this.btn_cus_email_send.Text = "SEND";
            this.btn_cus_email_send.UseVisualStyleBackColor = true;
            this.btn_cus_email_send.Click += new System.EventHandler(this.btn_cus_email_send_Click);
            // 
            // customerEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gp_cus_email2);
            this.Controls.Add(this.gp_cus_email1);
            this.Controls.Add(this.cmb_email_nic);
            this.Controls.Add(this.lbl_email_nic);
            this.Name = "customerEmailForm";
            this.Size = new System.Drawing.Size(931, 708);
            this.Load += new System.EventHandler(this.customerEmailForm_Load);
            this.gp_cus_email1.ResumeLayout(false);
            this.gp_cus_email1.PerformLayout();
            this.gp_cus_email2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_email_nic;
        private System.Windows.Forms.ComboBox cmb_email_nic;
        private System.Windows.Forms.GroupBox gp_cus_email1;
        private System.Windows.Forms.TextBox txt_email_subject;
        private System.Windows.Forms.TextBox txt_email_address;
        private System.Windows.Forms.Label lbl_cus_email_address;
        private System.Windows.Forms.Label lbl_cus_email_subject;
        private System.Windows.Forms.GroupBox gp_cus_email2;
        private System.Windows.Forms.RichTextBox rtb_cus_email_body;
        private System.Windows.Forms.Button btn_cus_email_send;
        private System.Windows.Forms.Button btn_cusEmail_clear;
        private System.Windows.Forms.Button btn_email_demo;
    }
}
