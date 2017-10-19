namespace SBW.UI
{
    partial class SplashForm
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
            this.pbx_loadingGif = new System.Windows.Forms.PictureBox();
            this.lbl_percentage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loadingGif)).BeginInit();
            this.SuspendLayout();
            // 
            // pbx_loadingGif
            // 
            this.pbx_loadingGif.BackColor = System.Drawing.Color.Transparent;
            this.pbx_loadingGif.Image = global::SBW.UI.Properties.Resources.loading_gif;
            this.pbx_loadingGif.Location = new System.Drawing.Point(342, 123);
            this.pbx_loadingGif.Name = "pbx_loadingGif";
            this.pbx_loadingGif.Size = new System.Drawing.Size(298, 296);
            this.pbx_loadingGif.TabIndex = 0;
            this.pbx_loadingGif.TabStop = false;
            // 
            // lbl_percentage
            // 
            this.lbl_percentage.AutoSize = true;
            this.lbl_percentage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_percentage.Location = new System.Drawing.Point(473, 288);
            this.lbl_percentage.Name = "lbl_percentage";
            this.lbl_percentage.Size = new System.Drawing.Size(26, 15);
            this.lbl_percentage.TabIndex = 1;
            this.lbl_percentage.Text = "0 %";
            // 
            // LoadingUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1060, 552);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_percentage);
            this.Controls.Add(this.pbx_loadingGif);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1060, 552);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1060, 552);
            this.Name = "LoadingUC";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.pbx_loadingGif)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbx_loadingGif;
        public System.Windows.Forms.Label lbl_percentage;
    }
}
