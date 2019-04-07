using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmAddCarType : Form
    {
        private readonly frmMainMenu parent;

        public frmAddCarType(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmAddCarType_Load(object sender, EventArgs e)
        {
            numericUpRate.Increment = 5.0m;
            numericUpRate.DecimalPlaces = 2;
        }

        private void btnAdd_CLick(object sender, EventArgs e)
        {
            //Validate data
            if (txtCarType.Text.Equals(""))
            {
                MessageBox.Show("Car type field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCarType.Focus();
                return;
            }

            //check if category already exists
            if (Rates.checkCategoryExists(txtCarType.Text))
            {
                MessageBox.Show("Category ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCarType.Focus();
                return;
            }


            if (!isValidType(txtCarType.Text))
            {
                MessageBox.Show("Car type is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCarType.Focus();
                return;
            }

            if (!isValidDesc(txtDesc.Text))
            {
                MessageBox.Show("Description field is invalid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Description field must be entered", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            if (numericUpRate.Text.Equals(""))
            {
                MessageBox.Show("Rate field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpRate.Focus();
                return;
            }

            if (numericUpRate.Value < 0)
            {
                MessageBox.Show("Rate field must be greater than zero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpRate.Focus();
                return;
            }

            try
            {
                //Save data in rate file 

                var myRate = new Rates(txtCarType.Text, txtDesc.Text, Convert.ToDecimal(numericUpRate.Text));


              
                myRate.addRates();

                //Display confirmation
                MessageBox.Show("Car Type Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Reset UI

                txtCarType.Clear();
                txtDesc.Clear();
                numericUpRate.ResetText();
                txtCarType.Focus();
            }
            catch (Exception)
            {
                
                Close();
                parent.Visible = true;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        public bool isValidType(string type)
        {
            var ty = type.ToUpper();

            if (Regex.IsMatch(ty, "^[A-Za-z]+$"))
                return true;
            return false;
        }

        public bool isValidDesc(string desc)
        {
            var des = desc.ToUpper();

            if (Regex.IsMatch(des, "^[0-9A-Za-z. ]+$"))
                return true;
            return false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;
        }
    }
}