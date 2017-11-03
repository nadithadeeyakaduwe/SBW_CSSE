using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SBW.Services;
using SBW.BusinessService;

namespace SBW.UI.CustomerUserControls
{
    public partial class customerEmailForm : UserControl
    {
        ICustomerService service;

        public customerEmailForm()
        {
            InitializeComponent();
        }

        private void btn_cusEmail_clear_Click(object sender, EventArgs e)
        {

        }

        private void btn_email_demo_Click(object sender, EventArgs e)
        {
            cmb_email_nic.Text = "985645451v";
            txt_email_address.Text = "tharakamadushanki@gmail.com";
            txt_email_subject.Text = "Test Mail";
            rtb_cus_email_body.Text = "Hello tharka, This is for testing SMTP mail from GMAIL";
        }

        //private void txt_email_address_MouseClick(object sender, MouseEventArgs e)
        //{

        //    if (cmb_email_nic.Text != "")
        //    {
        //        service = ServiceFactory.GetCustomerSeriveice();
        //        string email = service.GetCustomerEmail(cmb_email_nic.Text);
               
        //    }
        //    else
        //        MessageBox.Show("Please fill the NIC field");
        //}
    }
}
