using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using SBW.Entities.CustomerModule;
using SBW.BusinessService;
using SBW.Services;
using System.Data.SqlClient;

namespace SBW.UI.CustomerUserControls
{
    public partial class customerDetailsForm : UserControl
    {
        ICustomerService service;

        public customerDetailsForm()
        {
            InitializeComponent();
        }

        private void customerDetailsForm_Load(object sender, EventArgs e)
        {
            service = ServiceFactory.GetCustomerSeriveice();

            DataTable dt = null;

            dt = service.ViewCustomerDetails();

            dgv_cus_table.DataSource = dt;
        }

        //ADD button implementation
        private void btn_cus_add_Click(object sender, EventArgs e)
        {
            if (CustomerValidation())
            {
                if (IsValidEmail(txtb_cus_email.Text) == false)
                {
                    MessageBox.Show("Please Enter Valid Email");
                }
                else
                {
                    saveCustomer();
                }
            }
            else
                MessageBox.Show("Add customer request cannot complete. Please fill valid data");

            //CustomerFillGrid();
        }

        private void saveCustomer() {
            Customer customer = new Customer();

            customer.NIC = txtb_cus_nic.Text;
            customer.CustomrName = txtb_cus_name.Text;
            customer.Address = rtxtb_cus_address.Text;
            customer.Phone = txtb_cus_mobile.Text;
            customer.Email = txtb_cus_email.Text;
            customer.CustomerType = cmb_cus_type.Text;

            //show the confirmation dialog box
            DialogResult dr;
            dr = MessageBox.Show("Do you want to save the record", "Confirm", MessageBoxButtons.YesNo);
            if (dr.ToString() == "Yes")
            {
                try
                {
                    service = ServiceFactory.GetCustomerSeriveice();
                    bool result = service.AddNewCustomer(customer);

                    if (result)
                    {
                        //MessageBox.Show("Successfully Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //redirect to loyalty card tab
                        if (cmb_cus_type.Text == "Loyalty")
                        {
                            customerLoyaltyCardForm clf = new customerLoyaltyCardForm();
                            clf.Show();
                        }                     
                    }
                    //Clear();


                }
                catch (ApplicationException appEx)
                {
                    MessageBox.Show(appEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //Clear();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("This customer is alreay exist, please add new customer ");
                        //Violation of primary key. Handle Exception
                        //Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Clear();
            }
        }

        //customer feilds validation
        public bool CustomerValidation()
        {
            bool status = false;

            if (txtb_cus_nic.Text == "")
                MessageBox.Show("Please fill the Customer NIC field");
            else if (txtb_cus_nic.TextLength != 10)
                MessageBox.Show("Required Length of Customer NIC is wrong");
            else if (!txtb_cus_nic.ToString().EndsWith("v") || txtb_cus_nic.ToString().EndsWith("V"))
                MessageBox.Show("please end the Customer NIC with letter 'v' or 'V'");
            else if (txtb_cus_name.Text == "")
                MessageBox.Show("Please fill the Customer name field");
            else if (rtxtb_cus_address.Text == "")
                MessageBox.Show("Please fill the Customer Address field");
            else if (txtb_cus_mobile.Text == "")
                MessageBox.Show("Please fill the mobile No field");
            else if (txtb_cus_mobile.TextLength != 10)
                MessageBox.Show("Please enter valid mobile no");
            else if (txtb_cus_email.Text == "")
                MessageBox.Show("Please fill the email address field");
            //else if (txtb_cus_rate.Text == "")
            //  MessageBox.Show("Please fill the customer Rate field");
            // else if (Convert.ToInt32(txtb_cus_rate.Text) < 0)
            //   MessageBox.Show("Please enter only positive values for the Rate feild");
            else if (cmb_cus_type.Text == "")
                MessageBox.Show("Please select the Customer Type (Loyalty/Regular) ");
            else
            {
                status = true;
            }
            return status;
        }

        //email validation
        public bool IsValidEmail(string email)
        {
            string Email = email;
            string pattern = null;
            pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";

            if (Regex.IsMatch(Email, pattern))
            {
                //MessageBox.Show("Valid Email address ");
                return true;
            }
            else
            {
                // MessageBox.Show("Not a valid Email address ");
                return false;
            }
        }

        private void btn_cus_demo_Click(object sender, EventArgs e)
        {
            txtb_cus_nic.Text = "955544433v";
            txtb_cus_name.Text = "Perera K.M";
            rtxtb_cus_address.Text = "12,Lellupitiya,Rathnapura";
            txtb_cus_mobile.Text = "0778451258";
            txtb_cus_email.Text = "perera@gmail.com";
            cmb_cus_type.Text = "Regular";
            //txtb_cus_rate.Text = "1";
        }

        //Clear Customer feilds
        //public void Clear()
        //{
        //    txtb_cus_nic.Clear();
        //    txtb_cus_name.Clear();
        //    rtb_cus_address.Clear();
        //    txtb_cus_mobileno.Clear();
        //    txtb_cus_email.Clear();
        //    cmb_cus_type.SelectedIndex = -1;
        //    // txtb_cus_rate.Clear();
        //    txt_loy_nic.Clear();
        //    cmb_loy_cardtype.SelectedIndex = -1;
        //    lbl_loymem_cardno.Text = "Click";
        //    cmb_email_nic.Text = "";

        //    txtb_cus_nic.Enabled = true;
        //    txt_loy_nic.Enabled = true;

        //    txt_email_address.Clear();
        //    txt_email_subject.Clear();
        //    rtb_cus_email_body.Clear();

        //}

    }
}
