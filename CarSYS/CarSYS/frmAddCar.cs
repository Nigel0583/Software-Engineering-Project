﻿using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace CarSYS
{
    public partial class frmAddcar : Form
    {
        private int doors;
        private readonly frmMainMenu parent;

        public frmAddcar(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmAddcar()
        {
            InitializeComponent();
        }


        private void frmAddcar_Load(object sender, EventArgs e)
        {
            loadCombo();
            cboCarCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFuelType.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTransmission.DropDownStyle = ComboBoxStyle.DropDownList;
            numericUpEngine.Increment = 0.1m;
            numericUpEngine.DecimalPlaces = 1;
        }


        public void loadCombo()
        {
            // create instance of data set
            var ds = new DataSet();

            ds = Rates.getCatID(ds);

            //Remove existing items from combo box
            cboCarCategory.Items.Clear();

            //load data from ds 
            try
            {
                for (var i = 0; i < ds.Tables["cat"].Rows.Count; i++)
                    cboCarCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0'));
            }
            catch (Exception)
            {
              
                Close();
                parent.Visible = true;
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            var regNo = txtReg.Text.ToUpper();
            //Validate data
            if (txtMake.Text.Equals(""))
            {
                MessageBox.Show("Car make must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMake.Focus();
                return;
            }

            if (!isValidMakeModel(txtMake.Text))
            {
                MessageBox.Show("Invalid Make", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMake.Focus();
                return;
            }

            if (!isValidMakeModel(txtModel.Text))
            {
                MessageBox.Show("Invalid Model", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }

            if (txtModel.Text.Equals(""))
            {
                MessageBox.Show("Car model must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtModel.Focus();
                return;
            }


            if (!isValidReg(txtReg.Text))
            {
                MessageBox.Show("Car Registration is invalid. NN(N)-XX-N(NNN) ", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtReg.Focus();
                return;
            }

            //check if RegNo already exists
            if (Cars.checkRegExists(regNo))
            {
                MessageBox.Show("Registration number already exists", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtReg.Focus();
                return;
            }

            if (cboCarCategory.Text.Equals(""))
            {
                MessageBox.Show("Chose a car category", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarCategory.Focus();
                return;
            }

            if (cboFuelType.Text.Equals(""))
            {
                MessageBox.Show("Chose fuel type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboFuelType.Focus();
                return;
            }

            if (cboTransmission.Text.Equals(""))
            {
                MessageBox.Show("Chose transmission", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarCategory.Focus();
                return;
            }

            if (rad2door.Checked)
            {
                doors = 2;
            }
            else if (rad4door.Checked)
            {
                doors = 4;
            }
            else
            {
                MessageBox.Show("Chose number of doors", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rad2door.Focus();
                return;
            }

            var extra = "";
            if (chkAddCar.CheckedItems.Count > 0)
                for (var i = 0; i < chkAddCar.CheckedItems.Count; i++)
                    if (extra == "")
                        extra = chkAddCar.CheckedItems[i].ToString();
                    else
                        extra += "," + chkAddCar.CheckedItems[i];

            //Save data in  file 
            var addCar = new Cars(txtMake.Text, txtModel.Text, cboCarCategory.Text, txtReg.Text, cboTransmission.Text,
                cboFuelType.Text, 0, "A", Convert.ToInt32(numericUpDownSeats.Text), Convert.ToInt32(doors), extra,
                Convert.ToDecimal(numericUpEngine.Text),
                Convert.ToInt32(numericUpBags.Text));

            //INSERT car record into cars table
            addCar.addCars();

            //Display confirmation
            MessageBox.Show("Car with Reg " + txtReg.Text + " has been added", "Success", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            //Reset UI
            txtMake.Clear();
            txtModel.Clear();
            txtReg.Clear();
            numericUpBags.ResetText();
            numericUpEngine.ResetText();
            numericUpDownSeats.ResetText();
            chkAddCar.ClearSelected();
            txtMake.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        public bool isValidReg(string regNo)
        {
            var regno = regNo.ToUpper();
            // Define Regex for car reg with 3 digits-two letters-up to 5 digits
            if (Regex.IsMatch(regno,
                "^[0-9]{2}[1-2]{1}[-][KK|WW|C|CE|CN|CW|D|DL|G|KE|KY|L|LD|LH|LK|LM|LS|MH|MN|MO|OY|SO|RN|TN|TS|W|WD|WH|WX]{1,2}[-][0-9]{1,5}$")
            )
                return true;
            return false;
        }


        public bool isValidMakeModel(string m)
        {
            var upper = m.ToUpper();

            if (Regex.IsMatch(upper, "^[a-zA-Z0-9 ]*$"))
                return true;
            return false;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;
        }

        private void RegTextLeave(object sender, EventArgs e)
        {
            if (txtReg.Text.Equals(""))
            {
                txtReg.Text = "NN(N)-X(X)-NNNN";
                txtReg.ForeColor = Color.Silver;
            }
        }

        private void RegTextEnter(object sender, EventArgs e)
        {
            if (txtReg.Text.Equals("NN(N)-X(X)-NNNN"))
            {
                txtReg.Text = "";
                txtReg.ForeColor = Color.Black;
            }
        }
    }
}