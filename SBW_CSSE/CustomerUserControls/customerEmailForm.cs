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
using System.Net.Mail;
using SBW.UI.Common;

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
            //cmb_email_nic.SelectedIndex = -1;
            //txt_email_address.Clear();
            //txt_email_subject.Clear();
            Clear();
        }

        private void btn_email_demo_Click(object sender, EventArgs e)
        {
            cmb_email_nic.Text = "985645451v";
            txt_email_address.Text = "tharakamadushanki@gmail.com";
            txt_email_subject.Text = "Test Mail";
            rtb_cus_email_body.Text = "Hello tharka, This is for testing SMTP mail from GMAIL";
        }

        private void cmb_email_nic_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txt_email_address.Text = "";
            if (cmb_email_nic.Text != "")
            {
                service = ServiceFactory.GetCustomerSeriveice();
                string email = service.GetCustomerEmail(cmb_email_nic.Text);
                
                txt_email_address.Text = email;
            }
        }

        private void customerEmailForm_Load(object sender, EventArgs e)
        {
            service = ServiceFactory.GetCustomerSeriveice();
            DataTable dt = new DataTable();
            dt = service.LoadNicComboBox("Consumer", "Customer", "NIC");
            cmb_email_nic.DataSource = dt;
            cmb_email_nic.DisplayMember = "NIC";

            cmb_email_nic.SelectedIndex = -1;
            txt_email_address.Text = "";
        }

        private void cmb_email_nic_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmb_email_nic_DropDown(object sender, EventArgs e)
        {
        }

        private void cmb_email_nic_DockChanged(object sender, EventArgs e)
        {
        }

        private void cmb_email_nic_ValueMemberChanged(object sender, EventArgs e)
        {
        }

        private void txt_email_address_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool result1 = service.CheckForCustomerAvailability(cmb_email_nic.Text);
            if (!result1)
            {
                MessageBox.Show("This customer is not an existing customer, please enter NIC of existing customer");
            }
           
            if (cmb_email_nic.Text == "")
            {
                MessageBox.Show("Please fill the NIC field");
            }
        }

        private void btn_cus_email_send_Click(object sender, EventArgs e)
        {
            try
            {              
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("sarangabatteryworks123@gmail.com");
                //mail.To.Add("megacooleng@gmail.com");
                //mail.Subject = "Test Mail";
                //mail.Body = "This is for testing SMTP mail from GMAIL";
           
                if (txt_email_address.Text != " ")
                {
                    if (ValidationHelper.IsValidEmail(txt_email_address.Text) == false)
                    {
                        MessageBox.Show("Please Enter Valid Email");
                    }
                    else
                    {
                        //mail.To.Add("sarangabatteryworks123@gmail.com");
                        mail.To.Add(txt_email_address.Text);
                        mail.Subject = txt_email_subject.Text;
                        mail.Body = rtb_cus_email_body.Text;

                        string username = "sarangabatteryworks123@gmail.com";
                        string password = "iqlcspagsxrcbawz";

                        SmtpServer.Port = 587;
                        SmtpServer.Credentials = new System.Net.NetworkCredential(username, password);
                        SmtpServer.EnableSsl = true;

                        SmtpServer.Send(mail);
                        MessageBox.Show("Successfully Sent");
                    }
                }
                else
                    MessageBox.Show("Please fill a Email Address feild");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Clear();
        }

        //email feilds clear
        public void Clear() {
            cmb_email_nic.SelectedIndex = -1;
            txt_email_address.Clear();
            txt_email_subject.Clear();
            rtb_cus_email_body.Clear();
        }


    }
}
