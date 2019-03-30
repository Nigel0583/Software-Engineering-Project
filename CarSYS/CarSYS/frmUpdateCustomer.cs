using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmUpdateCustomer : Form
    {
        frmMainMenu parent;

        public frmUpdateCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmUpdateCustomer()
        {
            InitializeComponent();
        }

        private void frmUpdateCustomer_Load(object sender, EventArgs e)
        {
            grpUpdateCustomer.Visible = false;
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboUpdateCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DOB = dtpCustomer.Value.ToString("yyyy-MM-dd");
            //if resetting combo, ignore
            if (cboUpdateCustomer.SelectedIndex == -1)
            {
                return;
            }

            //find cust details
            Customer uCustomer = new Customer();
            uCustomer.getCustomers(Convert.ToInt32(cboUpdateCustomer.Text.Substring(0, 3)));

            if (uCustomer.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            //display cust details
            txtFirstName.Text = uCustomer.getFname().Trim();
            txtSurname.Text = uCustomer.getSname().Trim();
            txtLicence.Text = uCustomer.getLicence().Trim();
            txtPhone.Text = uCustomer.getLicence().Trim();
            txtEmail.Text = uCustomer.getEmail().Trim();
            txtCustomerID.Text = uCustomer.getCustomerID().ToString("00000").Trim();
            txtAddress.Text = uCustomer.getAddress().Trim();
            txtCountry.Text = uCustomer.getCountry().Trim();
            txtZipCode.Text = uCustomer.getPostcode().Trim();
            dtpCustomer.Text = uCustomer.getDOB().Trim();
            //dtpCustomer.Value = Convert.ToDateTime(uCustomer.getDOB().ToString());
            //textBox1.Text = uCustomer.getDOB();
            txtStatus.Text = uCustomer.getStatus().ToString().Trim();


            //display details
            grpUpdateCustomer.Visible = true;
        }

        private void btnUpdCustomer_Click(object sender, EventArgs e)
        {
         
            if (cboUpdateCustomer.Text.Equals(""))
            {
                MessageBox.Show("Chose a customer to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboUpdateCustomer.Focus();
                return;
            }

            //validate data
            if (txtStatus.Text.Equals(""))
            {
                MessageBox.Show("Status must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStatus.Focus();
                return;
            }
            string stat = txtStatus.Text.ToUpper();

            if (txtFirstName.Text.Equals(""))
            {
                MessageBox.Show("First name must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (!isValidLetter(txtFirstName.Text))
            {
                MessageBox.Show("First name is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            if (txtSurname.Text.Equals(""))
            {
                MessageBox.Show("Surname must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (!isValidLetter(txtSurname.Text))
            {
                MessageBox.Show("Surname name is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return;
            }

            if (txtLicence.Text.Equals(""))
            {
                MessageBox.Show("Licence number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicence.Focus();
                return;
            }

            if (!isvalidLicence(txtLicence.Text))
            {
                MessageBox.Show("Licence is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLicence.Focus();
                return;
            }

            if (txtPhone.Text.Equals(""))
            {
                MessageBox.Show("Phone number must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (!isvalidPhone(txtPhone.Text))
            {
                MessageBox.Show("Invalid phone number ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return;
            }

            if (txtAddress.Text.Equals(""))
            {
                MessageBox.Show("Address must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (!isValidLetter(txtAddress.Text))
            {
                MessageBox.Show("Address is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAddress.Focus();
                return;
            }

            if (txtCountry.Text.Equals(""))
            {
                MessageBox.Show("Country must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCountry.Focus();
                return;
            }

            if (!isValidLetterOnly(txtCountry.Text))
            {
                MessageBox.Show("Country is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCountry.Focus();
                return;
            }

            if (txtZipCode.Text.Equals(""))
            {
                MessageBox.Show("Zip code must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();
                return;
            }

            if (!isValidLetter(txtZipCode.Text))
            {
                MessageBox.Show("Zip code is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtZipCode.Focus();
                return;
            }

            if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if ((DateTime.Now.Subtract(dtpCustomer.Value).Days) / (365) < 25)
            {
                MessageBox.Show("Less than 25 Years are not allowed", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                dtpCustomer.Focus();
                return;
            }

            /*  if (Customer.checkEmailExists(txtEmail.Text))
              {
                  MessageBox.Show("Email  already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                  txtEmail.Focus();
                  return;
              }*/

            if (!frmAddCustomer.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Eamil is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            string dob = dtpCustomer.Value.ToString("yyyy-MM-dd");
            //instantiate  Object
            Customer customer = new Customer();

            customer.setFname(txtFirstName.Text);
            customer.setSname(txtSurname.Text);
            customer.setLicence(txtLicence.Text);
            customer.setPhoneNum(txtPhone.Text);
            customer.setEmail(txtEmail.Text);
            customer.setAddress(txtAddress.Text);
            customer.setCountry(txtCountry.Text);
            customer.setPostcode(txtZipCode.Text);
            customer.setDOB(dob);
            customer.setStatus(Convert.ToChar(stat));
            customer.setCustomerID(Convert.ToInt32(txtCustomerID.Text));


            //INSERT Stock record into car table
            customer.updateCustomer();

            //Display Confirmation Message
            MessageBox.Show("Customer " + txtCustomerID.Text + " has been updated", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpUpdateCustomer.Visible = false;

            cboUpdateCustomer.SelectedIndex = -1;
            clearUi();
            loadData();
           
        }


        public Boolean isvalidLicence(String licence)
        {
            if ((Regex.IsMatch(licence, @"^[a-zA-Z0-9]+$")))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean isvalidPhone(String phone)
        {
            //Regex from http://regexlib.com/REDetails.aspx?regexp_id=73
            if ((Regex.IsMatch(phone, @"^(\(?\+?[0-9]*\)?)?[0-9_\- \(\)]*$")))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean isValidLetter(String input)
        {
            string inp = input.ToUpper();

            if ((Regex.IsMatch(inp, "^[0-9A-Za-z.,'-_ ]+$")))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean isValidLetterOnly(String type)
        {
            string ty = type.ToUpper();

            if ((Regex.IsMatch(ty, "^[A-Za-z]+$")))
            {
                return true;
            }
            else
                return false;
        }


        public void clearUi()
        {
            //Rest UI
            txtAddress.Clear();
            txtCountry.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLicence.Clear();
            txtStatus.Clear();
            txtPhone.Clear();
            txtSurname.Clear();
            txtZipCode.Clear();

            txtCustomerID.Text = Customer.nextCustomerID().ToString("00000");
            txtFirstName.Focus();
        }

        public void loadData()
        {
            cboUpdateCustomer.Items.Clear();
            this.cboUpdateCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                DataSet ds = new DataSet();
                ds = Customer.getCustInfoToUp(ds);
                for (int i = 0; i < ds.Tables["cust"].Rows.Count; i++)
                    cboUpdateCustomer.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                                                ds.Tables[0].Rows[i][1].ToString());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;


        }
    }
}