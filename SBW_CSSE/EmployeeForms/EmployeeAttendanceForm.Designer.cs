namespace SBW.UI.EmployeeForms
{
    partial class EmployeeAttendanceForm
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
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_outNoteValue = new System.Windows.Forms.Label();
            this.lbl_inNoteValue = new System.Windows.Forms.Label();
            this.lbl_outTimeValue = new System.Windows.Forms.Label();
            this.lbl_inTimeValue = new System.Windows.Forms.Label();
            this.lbl_pickDate = new System.Windows.Forms.Label();
            this.dtp_pickDate = new System.Windows.Forms.DateTimePicker();
            this.lbl_attendanceRecord = new System.Windows.Forms.Label();
            this.btn_punchInOut = new System.Windows.Forms.Button();
            this.rtb_note = new System.Windows.Forms.RichTextBox();
            this.lbl_outNote = new System.Windows.Forms.Label();
            this.lbl_inNote = new System.Windows.Forms.Label();
            this.lbl_outTime = new System.Windows.Forms.Label();
            this.lbl_inTime = new System.Windows.Forms.Label();
            this.dgv_attendanceRecord = new System.Windows.Forms.DataGridView();
            this.lbl_employeeID = new System.Windows.Forms.Label();
            this.lbl_note = new System.Windows.Forms.Label();
            this.lbl_colon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendanceRecord)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(968, 503);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 37);
            this.btn_back.TabIndex = 17;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // lbl_outNoteValue
            // 
            this.lbl_outNoteValue.AutoSize = true;
            this.lbl_outNoteValue.Location = new System.Drawing.Point(551, 41);
            this.lbl_outNoteValue.MaximumSize = new System.Drawing.Size(250, 70);
            this.lbl_outNoteValue.Name = "lbl_outNoteValue";
            this.lbl_outNoteValue.Size = new System.Drawing.Size(0, 15);
            this.lbl_outNoteValue.TabIndex = 15;
            // 
            // lbl_inNoteValue
            // 
            this.lbl_inNoteValue.AutoSize = true;
            this.lbl_inNoteValue.Location = new System.Drawing.Point(148, 41);
            this.lbl_inNoteValue.MaximumSize = new System.Drawing.Size(250, 70);
            this.lbl_inNoteValue.Name = "lbl_inNoteValue";
            this.lbl_inNoteValue.Size = new System.Drawing.Size(0, 15);
            this.lbl_inNoteValue.TabIndex = 14;
            // 
            // lbl_outTimeValue
            // 
            this.lbl_outTimeValue.AutoSize = true;
            this.lbl_outTimeValue.Location = new System.Drawing.Point(551, 8);
            this.lbl_outTimeValue.Name = "lbl_outTimeValue";
            this.lbl_outTimeValue.Size = new System.Drawing.Size(0, 15);
            this.lbl_outTimeValue.TabIndex = 13;
            // 
            // lbl_inTimeValue
            // 
            this.lbl_inTimeValue.AutoSize = true;
            this.lbl_inTimeValue.Location = new System.Drawing.Point(148, 8);
            this.lbl_inTimeValue.Name = "lbl_inTimeValue";
            this.lbl_inTimeValue.Size = new System.Drawing.Size(0, 15);
            this.lbl_inTimeValue.TabIndex = 12;
            // 
            // lbl_pickDate
            // 
            this.lbl_pickDate.AutoSize = true;
            this.lbl_pickDate.Location = new System.Drawing.Point(757, 305);
            this.lbl_pickDate.Name = "lbl_pickDate";
            this.lbl_pickDate.Size = new System.Drawing.Size(62, 15);
            this.lbl_pickDate.TabIndex = 11;
            this.lbl_pickDate.Text = "Pick Date :";
            // 
            // dtp_pickDate
            // 
            this.dtp_pickDate.Location = new System.Drawing.Point(835, 299);
            this.dtp_pickDate.Name = "dtp_pickDate";
            this.dtp_pickDate.Size = new System.Drawing.Size(208, 23);
            this.dtp_pickDate.TabIndex = 10;
            this.dtp_pickDate.ValueChanged += new System.EventHandler(this.dtp_pickDate_ValueChanged);
            // 
            // lbl_attendanceRecord
            // 
            this.lbl_attendanceRecord.AutoSize = true;
            this.lbl_attendanceRecord.Location = new System.Drawing.Point(26, 305);
            this.lbl_attendanceRecord.Name = "lbl_attendanceRecord";
            this.lbl_attendanceRecord.Size = new System.Drawing.Size(113, 15);
            this.lbl_attendanceRecord.TabIndex = 9;
            this.lbl_attendanceRecord.Text = "Attendance Records";
            // 
            // btn_punchInOut
            // 
            this.btn_punchInOut.Location = new System.Drawing.Point(426, 257);
            this.btn_punchInOut.Name = "btn_punchInOut";
            this.btn_punchInOut.Size = new System.Drawing.Size(75, 37);
            this.btn_punchInOut.TabIndex = 7;
            this.btn_punchInOut.Text = "IN";
            this.btn_punchInOut.UseVisualStyleBackColor = true;
            this.btn_punchInOut.Click += new System.EventHandler(this.btn_punchInOut_Click);
            // 
            // rtb_note
            // 
            this.rtb_note.Location = new System.Drawing.Point(29, 132);
            this.rtb_note.Name = "rtb_note";
            this.rtb_note.Size = new System.Drawing.Size(473, 105);
            this.rtb_note.TabIndex = 6;
            this.rtb_note.Text = "";
            // 
            // lbl_outNote
            // 
            this.lbl_outNote.AutoSize = true;
            this.lbl_outNote.Location = new System.Drawing.Point(441, 41);
            this.lbl_outNote.Name = "lbl_outNote";
            this.lbl_outNote.Size = new System.Drawing.Size(60, 15);
            this.lbl_outNote.TabIndex = 5;
            this.lbl_outNote.Text = "OUT Note";
            // 
            // lbl_inNote
            // 
            this.lbl_inNote.AutoSize = true;
            this.lbl_inNote.Location = new System.Drawing.Point(26, 41);
            this.lbl_inNote.Name = "lbl_inNote";
            this.lbl_inNote.Size = new System.Drawing.Size(48, 15);
            this.lbl_inNote.TabIndex = 4;
            this.lbl_inNote.Text = "IN Note";
            // 
            // lbl_outTime
            // 
            this.lbl_outTime.AutoSize = true;
            this.lbl_outTime.Location = new System.Drawing.Point(441, 8);
            this.lbl_outTime.Name = "lbl_outTime";
            this.lbl_outTime.Size = new System.Drawing.Size(61, 15);
            this.lbl_outTime.TabIndex = 3;
            this.lbl_outTime.Text = "OUT Time";
            // 
            // lbl_inTime
            // 
            this.lbl_inTime.AutoSize = true;
            this.lbl_inTime.Location = new System.Drawing.Point(26, 8);
            this.lbl_inTime.Name = "lbl_inTime";
            this.lbl_inTime.Size = new System.Drawing.Size(49, 15);
            this.lbl_inTime.TabIndex = 2;
            this.lbl_inTime.Text = "IN Time";
            // 
            // dgv_attendanceRecord
            // 
            this.dgv_attendanceRecord.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_attendanceRecord.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_attendanceRecord.BackgroundColor = System.Drawing.Color.White;
            this.dgv_attendanceRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_attendanceRecord.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_attendanceRecord.GridColor = System.Drawing.Color.White;
            this.dgv_attendanceRecord.Location = new System.Drawing.Point(29, 343);
            this.dgv_attendanceRecord.Name = "dgv_attendanceRecord";
            this.dgv_attendanceRecord.RowHeadersVisible = false;
            this.dgv_attendanceRecord.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_attendanceRecord.Size = new System.Drawing.Size(1014, 140);
            this.dgv_attendanceRecord.TabIndex = 1;
            // 
            // lbl_employeeID
            // 
            this.lbl_employeeID.AutoSize = true;
            this.lbl_employeeID.Location = new System.Drawing.Point(622, 176);
            this.lbl_employeeID.Name = "lbl_employeeID";
            this.lbl_employeeID.Size = new System.Drawing.Size(70, 15);
            this.lbl_employeeID.TabIndex = 18;
            this.lbl_employeeID.Text = "EmployeeID";
            this.lbl_employeeID.Visible = false;
            // 
            // lbl_note
            // 
            this.lbl_note.AutoSize = true;
            this.lbl_note.Location = new System.Drawing.Point(29, 113);
            this.lbl_note.Name = "lbl_note";
            this.lbl_note.Size = new System.Drawing.Size(42, 15);
            this.lbl_note.TabIndex = 19;
            this.lbl_note.Text = "Note : ";
            // 
            // lbl_colon
            // 
            this.lbl_colon.AutoSize = true;
            this.lbl_colon.Location = new System.Drawing.Point(104, 9);
            this.lbl_colon.Name = "lbl_colon";
            this.lbl_colon.Size = new System.Drawing.Size(10, 15);
            this.lbl_colon.TabIndex = 20;
            this.lbl_colon.Text = ":";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = ":";
            // 
            // EmployeeAttendanceForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 552);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_colon);
            this.Controls.Add(this.lbl_note);
            this.Controls.Add(this.lbl_employeeID);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_outNoteValue);
            this.Controls.Add(this.lbl_inTime);
            this.Controls.Add(this.lbl_inNoteValue);
            this.Controls.Add(this.dgv_attendanceRecord);
            this.Controls.Add(this.lbl_outTimeValue);
            this.Controls.Add(this.lbl_outTime);
            this.Controls.Add(this.lbl_inTimeValue);
            this.Controls.Add(this.lbl_inNote);
            this.Controls.Add(this.lbl_pickDate);
            this.Controls.Add(this.lbl_outNote);
            this.Controls.Add(this.dtp_pickDate);
            this.Controls.Add(this.rtb_note);
            this.Controls.Add(this.lbl_attendanceRecord);
            this.Controls.Add(this.btn_punchInOut);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "EmployeeAttendanceForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.EmployeeAttendanceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_attendanceRecord)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_attendanceRecord;
        private System.Windows.Forms.Label lbl_pickDate;
        private System.Windows.Forms.DateTimePicker dtp_pickDate;
        private System.Windows.Forms.Label lbl_attendanceRecord;
        private System.Windows.Forms.Button btn_punchInOut;
        private System.Windows.Forms.RichTextBox rtb_note;
        private System.Windows.Forms.Label lbl_outNote;
        private System.Windows.Forms.Label lbl_inNote;
        private System.Windows.Forms.Label lbl_outTime;
        private System.Windows.Forms.Label lbl_inTime;
        private System.Windows.Forms.Label lbl_outNoteValue;
        private System.Windows.Forms.Label lbl_inNoteValue;
        private System.Windows.Forms.Label lbl_outTimeValue;
        private System.Windows.Forms.Label lbl_inTimeValue;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_employeeID;
        private System.Windows.Forms.Label lbl_note;
        private System.Windows.Forms.Label lbl_colon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
