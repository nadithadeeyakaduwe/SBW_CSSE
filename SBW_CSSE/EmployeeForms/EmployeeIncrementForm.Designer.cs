namespace SBW.UI.EmployeeForms
{
    partial class EmployeeIncrementForm
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
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.tb_newSalary = new System.Windows.Forms.TextBox();
            this.lbl_currentSalValue = new System.Windows.Forms.Label();
            this.lbl_epfNoValue = new System.Windows.Forms.Label();
            this.lbl_newSalary = new System.Windows.Forms.Label();
            this.lbl_currentSal = new System.Windows.Forms.Label();
            this.lbl_epfNo = new System.Windows.Forms.Label();
            this.lbl_reason = new System.Windows.Forms.Label();
            this.rtb_reason = new System.Windows.Forms.RichTextBox();
            this.lbl_requredMark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(78, 255);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(89, 46);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(235, 255);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(89, 46);
            this.btn_confirm.TabIndex = 6;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // tb_newSalary
            // 
            this.tb_newSalary.Location = new System.Drawing.Point(176, 112);
            this.tb_newSalary.Name = "tb_newSalary";
            this.tb_newSalary.Size = new System.Drawing.Size(174, 23);
            this.tb_newSalary.TabIndex = 5;
            this.tb_newSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_newSalary_KeyPress);
            // 
            // lbl_currentSalValue
            // 
            this.lbl_currentSalValue.AutoSize = true;
            this.lbl_currentSalValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentSalValue.Location = new System.Drawing.Point(176, 67);
            this.lbl_currentSalValue.Name = "lbl_currentSalValue";
            this.lbl_currentSalValue.Size = new System.Drawing.Size(81, 15);
            this.lbl_currentSalValue.TabIndex = 4;
            this.lbl_currentSalValue.Text = "Current Salary";
            // 
            // lbl_epfNoValue
            // 
            this.lbl_epfNoValue.AutoSize = true;
            this.lbl_epfNoValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_epfNoValue.Location = new System.Drawing.Point(176, 20);
            this.lbl_epfNoValue.Name = "lbl_epfNoValue";
            this.lbl_epfNoValue.Size = new System.Drawing.Size(45, 15);
            this.lbl_epfNoValue.TabIndex = 3;
            this.lbl_epfNoValue.Text = "EPF No";
            // 
            // lbl_newSalary
            // 
            this.lbl_newSalary.AutoSize = true;
            this.lbl_newSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_newSalary.Location = new System.Drawing.Point(23, 114);
            this.lbl_newSalary.Name = "lbl_newSalary";
            this.lbl_newSalary.Size = new System.Drawing.Size(65, 15);
            this.lbl_newSalary.TabIndex = 2;
            this.lbl_newSalary.Text = "New Salary";
            // 
            // lbl_currentSal
            // 
            this.lbl_currentSal.AutoSize = true;
            this.lbl_currentSal.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_currentSal.Location = new System.Drawing.Point(23, 67);
            this.lbl_currentSal.Name = "lbl_currentSal";
            this.lbl_currentSal.Size = new System.Drawing.Size(81, 15);
            this.lbl_currentSal.TabIndex = 1;
            this.lbl_currentSal.Text = "Current Salary";
            // 
            // lbl_epfNo
            // 
            this.lbl_epfNo.AutoSize = true;
            this.lbl_epfNo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_epfNo.Location = new System.Drawing.Point(23, 20);
            this.lbl_epfNo.Name = "lbl_epfNo";
            this.lbl_epfNo.Size = new System.Drawing.Size(45, 15);
            this.lbl_epfNo.TabIndex = 0;
            this.lbl_epfNo.Text = "EPF No";
            // 
            // lbl_reason
            // 
            this.lbl_reason.AutoSize = true;
            this.lbl_reason.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reason.Location = new System.Drawing.Point(23, 171);
            this.lbl_reason.Name = "lbl_reason";
            this.lbl_reason.Size = new System.Drawing.Size(45, 15);
            this.lbl_reason.TabIndex = 8;
            this.lbl_reason.Text = "Reason";
            // 
            // rtb_reason
            // 
            this.rtb_reason.Location = new System.Drawing.Point(176, 171);
            this.rtb_reason.Name = "rtb_reason";
            this.rtb_reason.Size = new System.Drawing.Size(174, 60);
            this.rtb_reason.TabIndex = 9;
            this.rtb_reason.Text = "";
            // 
            // lbl_requredMark
            // 
            this.lbl_requredMark.AutoSize = true;
            this.lbl_requredMark.ForeColor = System.Drawing.Color.Red;
            this.lbl_requredMark.Location = new System.Drawing.Point(352, 119);
            this.lbl_requredMark.Name = "lbl_requredMark";
            this.lbl_requredMark.Size = new System.Drawing.Size(12, 15);
            this.lbl_requredMark.TabIndex = 10;
            this.lbl_requredMark.Text = "*";
            // 
            // EmployeeIncrementForm
            // 
            this.AcceptButton = this.btn_confirm;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(379, 309);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_requredMark);
            this.Controls.Add(this.rtb_reason);
            this.Controls.Add(this.lbl_reason);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.lbl_epfNo);
            this.Controls.Add(this.tb_newSalary);
            this.Controls.Add(this.lbl_currentSal);
            this.Controls.Add(this.lbl_currentSalValue);
            this.Controls.Add(this.lbl_newSalary);
            this.Controls.Add(this.lbl_epfNoValue);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeIncrementForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.EmployeeIncrementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_epfNo;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.TextBox tb_newSalary;
        private System.Windows.Forms.Label lbl_currentSalValue;
        private System.Windows.Forms.Label lbl_epfNoValue;
        private System.Windows.Forms.Label lbl_newSalary;
        private System.Windows.Forms.Label lbl_currentSal;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_reason;
        private System.Windows.Forms.RichTextBox rtb_reason;
        private System.Windows.Forms.Label lbl_requredMark;
    }
}
