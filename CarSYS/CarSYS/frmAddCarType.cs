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
    public partial class frmAddCarType : Form
    {
        frmMainMenu parent;
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
            if (txtCarType.Text.Equals("") )
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
                MessageBox.Show("Description field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;

            }
            if (numericUpRate.Text.Equals("") )
            {
                MessageBox.Show("Rate field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                numericUpRate.Focus();
                return;

            }



            try
            {
                //Save data in rate file 

                Rates myRate = new Rates(txtCarType.Text, txtDesc.Text, Convert.ToDecimal(numericUpRate.Text));


                //INSERT Stock record into stock table
                myRate.addRates();

                //Display confirmation
                MessageBox.Show("Car Type Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                //Reset UI

                txtCarType.Clear();
                txtDesc.Clear();
                numericUpRate.ResetText();
                txtCarType.Focus();
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
        public Boolean isValidType(String type)
        {
            type.ToUpper();
          
            if ((Regex.IsMatch(type, "^[A-Za-z]+$")))
            {
                return true;
            }
            else
                return false;
        }

        public Boolean isValidDesc(String desc)
        {
            desc.ToUpper();

            if ((Regex.IsMatch(desc, "^[0-9A-Za-z. ]+$")))
            {
                return true;
            }
            else
                return false;
        }


        
    }
}



