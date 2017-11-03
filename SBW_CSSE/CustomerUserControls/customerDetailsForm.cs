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
            CustomerFillGrid();

            dgv_cus_table.Columns[2].Width = 150;
            dgv_cus_table.Columns[3].Width = 200;

            cmb_cus_type.Items.Add("Regular");
            cmb_cus_type.Items.Add("Loyalty");
            cmb_cus_type.SelectedIndex = 0;
            cmb_cus_type.Enabled = true;

            btn_cus_update.Enabled = false;
            btn_cus_delete.Enabled = false;
        }

        //customer fillgrid
        public void CustomerFillGrid()
        {
            try
            {
                service = ServiceFactory.GetCustomerSeriveice();
                DataTable dt = new DataTable();
                dt = service.ViewCustomerDetails();
                dgv_cus_table.DataSource = dt;
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
                    addCustomerDetails();
                }
            }
            else
                MessageBox.Show("Add customer request cannot complete. Please fill valid data");

            CustomerFillGrid();
        }

        private void addCustomerDetails() {
            Customer customer = new Customer();

            customer.NIC = txtb_cus_nic.Text;
            customer.Name = txtb_cus_name.Text;
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
                        //redirect to loyalty card tab
                        if (cmb_cus_type.Text == "Loyalty")
                        {
                            customerLoyaltyCardForm clf = new customerLoyaltyCardForm();
                            clf.Show();
                            customerDetailsForm cdf = new customerDetailsForm();
                            cdf.Hide();

                        }                     
                    }
                    Clear();


                }
                catch (ApplicationException appEx)
                {
                    MessageBox.Show(appEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Clear();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                    {
                        MessageBox.Show("This customer is alreay exist, please add new customer ");
                        //Violation of primary key. Handle Exception
                        Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Record is not saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
        }

        private void btn_cus_update_Click(object sender, EventArgs e)
        {
            DialogResult dr;
         
            if (CustomerValidation())
            {
                dr = MessageBox.Show("Do you want to update the record", "Confirm", MessageBoxButtons.YesNo);
                if (dr.ToString() == "Yes")
                {
                    if (IsValidEmail(txtb_cus_email.Text) == false)
                    {
                        MessageBox.Show("Please Enter Valid Email");
                    }
                    else
                    {
                        updateCustomerDetails();
                    }
                }
                else
                {
                    MessageBox.Show("Record is not updated", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                }
            }
            //else
            //    MessageBox.Show("Record updation request can not be completed", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

            CustomerFillGrid();
            Clear();

            btn_cus_add.Enabled = true;
            cmb_cus_type.SelectedIndex = -1;
            cmb_cus_type.Enabled = true;
        }

        private void updateCustomerDetails() {
            Customer customer = new Customer();

            //txtb_cus_rate.Text = "0";

            customer.NIC = txtb_cus_nic.Text;
            customer.Name = txtb_cus_name.Text;
            customer.Address = rtxtb_cus_address.Text;
            customer.Phone = txtb_cus_mobile.Text;
            customer.Email = txtb_cus_email.Text;
            customer.CustomerType = cmb_cus_type.Text;
            //customer.Rate = Convert.ToInt32(txtb_cus_rate.Text);

            try
            {
                service = ServiceFactory.GetCustomerSeriveice();
                bool result = service.UpdateCustomer(customer);
               
                if (result)
                {
                    CustomerFillGrid();
                }             
            }
            catch (ApplicationException appEx)
            {
                MessageBox.Show(appEx.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btn_cus_delete_Click(object sender, EventArgs e)
        {        
            //show the confirmation dialog box
            DialogResult dr;
            dr = MessageBox.Show("Do you want to delete the record", "Confirm", MessageBoxButtons.YesNo);
            if (dr.ToString() == "Yes")
            {
                deleteCustomerDetails();
            }
            else
                MessageBox.Show("Record is not deleted", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);


            Clear();
            btn_cus_add.Enabled = true;
        }

        private void deleteCustomerDetails() {
            try
            {
                string nic = txtb_cus_nic.Text;
                string cusType = cmb_cus_type.Text;

                service = ServiceFactory.GetCustomerSeriveice();
                bool result = service.DeleteCustomer(nic, cusType);
               
                if (result)
                {
                   CustomerFillGrid();
                }                   
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //search customer by name or nic to key press event
        private void txt_cus_searchkey_KeyPress(object sender, KeyPressEventArgs e)
        {
            string searchString = txt_cus_searchkey.Text;

            service = ServiceFactory.GetCustomerSeriveice();
            dgv_cus_table.DataSource = service.SearchCustomer(searchString);
        }

        //nic field validation
        private void txtb_cus_nic_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)Keys.Back || e.KeyChar == 'v' || e.KeyChar == 'V')
            {
                e.Handled = false; //Do not reject the input
            }
            else
            {
                e.Handled = true; //Reject the input
            }
        }

        //mobile field validation
        private void txtb_cus_mobileno_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
            if (txtb_cus_mobile.Text.Length > 9 && ch != 8)
                e.Handled = true;
        }

        //select nic cell value into text feild
        private void dgv_cus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = dgv_cus_table.CurrentCell.RowIndex;
            //int columnindex = dgv_cus_table.CurrentCell.ColumnIndex;
            string nic = dgv_cus_table.Rows[rowindex].Cells[0].Value.ToString();

            txtb_cus_nic.Text = nic;
        }

        //pass values to text feilds from grid view
        private void dgv_cus_table_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_cus_add.Enabled = false;
            btn_cus_update.Enabled = true;
            btn_cus_delete.Enabled = true;

            try
            {
                string nic = ((DataGridView)sender).Rows[e.RowIndex].Cells[0].Value.ToString();
                string name = ((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value.ToString();
                string email = ((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value.ToString();
                string address = ((DataGridView)sender).Rows[e.RowIndex].Cells[3].Value.ToString();
                int rate = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[4].Value);
                string type = ((DataGridView)sender).Rows[e.RowIndex].Cells[5].Value.ToString();
                string contactNo = ((DataGridView)sender).Rows[e.RowIndex].Cells[6].Value.ToString();



                txtb_cus_nic.Text = nic;
                txtb_cus_name.Text = name;
                txtb_cus_email.Text = email;
                rtxtb_cus_address.Text = address;
                // txtb_cus_rate.Text = (rate).ToString();
                cmb_cus_type.Text = type;
                txtb_cus_mobile.Text = contactNo;

                txtb_cus_nic.Enabled = false;
                if (cmb_cus_type.Text == "Loyalty")
                {
                    cmb_cus_type.Enabled = false;
                }
                else
                    cmb_cus_type.Enabled = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Clear Customer feilds
        public void Clear()
        {
            txtb_cus_nic.Clear();
            txtb_cus_name.Clear();
            rtxtb_cus_address.Clear();
            txtb_cus_mobile.Clear();
            txtb_cus_email.Clear();
            cmb_cus_type.SelectedIndex = -1;
            //// txtb_cus_rate.Clear();
            //txt_loy_nic.Clear();
            //cmb_loy_cardtype.SelectedIndex = -1;
            //lbl_loymem_cardno.Text = "Click";
            //cmb_email_nic.Text = "";



            txtb_cus_nic.Enabled = true;
            btn_cus_add.Enabled = true;
            cmb_cus_type.Enabled = true;

            btn_cus_update.Enabled = false;
            btn_cus_delete.Enabled = false;

            CustomerFillGrid();
            
            //txt_loy_nic.Enabled = true;

            ////email feilds clear
            //txt_email_address.Clear();
            //txt_email_subject.Clear();
            //rtb_cus_email_body.Clear();

        }

        private void btn_cus_clear_Click(object sender, EventArgs e)
        {
            Clear();
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
    }
}
