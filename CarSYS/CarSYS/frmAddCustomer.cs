using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace CarSYS
{
    public partial class frmAddCustomer : Form
    {
        
        frmMainMenu parent;
        public frmAddCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }
        public frmAddCustomer()
        {
            InitializeComponent();
        }

        private void frmAddCustomer_Load(object sender, EventArgs e)
        {

            
            txtCustomerID.Text = Customer.nextCustomerID().ToString("00000");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string DOB = dtpCustomer.Value.ToString("yyyy-MM-dd");
            //validate data

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
                MessageBox.Show("Less than 25 Years are not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpCustomer.Focus();
                return;
            }

            if (Customer.checkEmailExists(txtEmail.Text))
            {
                MessageBox.Show("Email  already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Eamil is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return;
            }

            try
            {
                Customer customer = new Customer(Convert.ToInt32(txtCustomerID.Text), txtEmail.Text, txtLicence.Text, txtFirstName.Text, txtSurname.Text, txtAddress.Text, txtCountry.Text, txtZipCode.Text, txtPhone.Text, DOB, 'A');

                customer.addCustomer();

                MessageBox.Show("Customer " + txtCustomerID.Text + " Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearUI();
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
           
        }

        //From https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }

            
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
            input.ToUpper();

            if ((Regex.IsMatch(input, "^[0-9A-Za-z.,'-_ ]+$")))
            {
                return true;
            }
            else
                return false;
        }
        public Boolean isValidLetterOnly(String type)
        {
            type.ToUpper();

            if ((Regex.IsMatch(type, "^[A-Za-z]+$")))
            {
                return true;
            }
            else
                return false;
        }
       

        public void clearUI()
        {
            //Rest UI
            txtAddress.Clear();
            txtCountry.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLicence.Clear();

            txtPhone.Clear();
            txtSurname.Clear();
            txtZipCode.Clear();

            txtCustomerID.Text = Customer.nextCustomerID().ToString("00000");
            txtFirstName.Focus();
        }

    }
}
