using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Drawing.Text;

namespace SBW.UI
{
    
    public partial class MainForm : Form
    {
        /// <summary>
        /// The timer
        /// </summary>
        Timer timer = new Timer()
        {
            Interval = 1000,
            Enabled = true
        };

        /// <summary>
        /// Initializes a new instance of the <see cref="MainForm"/> class.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the MainForm control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadDigitalClock();
            loadFont();
            AllocFont(font, lbl_clock, 24);
        }

        /// <summary>
        /// Handles the Click event of the btn_employeeMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_employeeMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_employeeMain.Top);
            loadMainForm(new EmployeeForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_customerMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_customerMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_customerMain.Top);
            loadMainForm(new CustomerForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_InventoryMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_InventoryMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_InventoryMain.Top);
            loadMainForm(new InventoryForm());
        }

        /// <summary>
        /// Handles the Click event of the btn_salesMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_salesMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_salesMain.Top);
            loadMainForm(new SalesNProfit());
        }

        /// <summary>
        /// Handles the Click event of the btn_settingsMain control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_settingsMain_Click(object sender, EventArgs e)
        {
            showSelectedMenu(btn_settingsMain.Top);
        }

        /// <summary>
        /// Handles the Click event of the pbx_logo control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void pbx_logo_Click(object sender, EventArgs e)
        {
            panel_main.Controls.Clear();
        }

        /// <summary>
        /// Loads the main form.
        /// </summary>
        /// <param name="form">The form.</param>
        private void loadMainForm(Form form)
        {
            panel_main.Controls.Clear();
            form.TopLevel = false;
            panel_main.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
        /// <summary>
        /// Shows the selected menu.
        /// </summary>
        /// <param name="top">The top.</param>
        private void showSelectedMenu(int top)
        {
            panel_sidebar.Top = top;
        }

        /// <summary>
        /// Loads the digital clock.
        /// </summary>
        private void loadDigitalClock()
        {
            timer.Tick += (tSender, ev) =>
            {
                lbl_clock.Text = DateTime.Now.ToString("hh:mm:ss tt");
            };
        }

        /// <summary>
        /// Handles the Click event of the btn_logout control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        #region Loading the Font of the Digital Clock

        [DllImport("gdi32.dll")]
        private static extern IntPtr AddFontMemResourceEx(IntPtr pbFont, uint cbFont, IntPtr pdv, [In] ref uint pcFonts);

        FontFamily ff;
        Font font;

        private void AllocFont(Font f, Control c, float size)
        {
            FontStyle fontStyle = FontStyle.Regular;

            c.Font = new Font(ff, size, fontStyle);
        }

        private void loadFont()
        {
            byte[] fontArray = Properties.Resources.digital_7__mono_;
            int dataLength = Properties.Resources.digital_7__mono_.Length;

            IntPtr ptrData = Marshal.AllocCoTaskMem(dataLength);
            Marshal.Copy(fontArray, 0, ptrData, dataLength);
            uint cFonts = 0;
            AddFontMemResourceEx(ptrData, (uint)fontArray.Length, IntPtr.Zero, ref cFonts);

            PrivateFontCollection pfc = new PrivateFontCollection();

            pfc.AddMemoryFont(ptrData, dataLength);

            Marshal.FreeCoTaskMem(ptrData);

            ff = pfc.Families[0];

            font = new Font(ff, 15f, FontStyle.Regular);
        }

        #endregion
    }
}
