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
    public partial class frmRemove : Form
    {
        frmMainMenu parent;
        public frmRemove(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.cboRemoveCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmRemove_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Cars.getRegNo(ds);
                for (int i = 0; i < ds.Tables["reg"].Rows.Count; i++)
                    cboRemoveCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
            
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            if (cboRemoveCar.Text.Equals(""))
            {
                MessageBox.Show("Chose a car to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCar.Focus();
                return;

            }

            if (txtCurrentAvailability.Text.Equals(""))
            {
                MessageBox.Show("Set current availability to R or A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrentAvailability.Focus();
                return;

            }

            if (txtCurrentAvailability.Text.Trim().Equals("O"))
            {
                MessageBox.Show("You cannot remove car "+cboRemoveCar.Text+" since it is currently been rented", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCar.Focus();
                return;
            }

            if (!txtUpdate.Text.Equals("R") && !txtUpdate.Text.Equals("A"))
            {
                MessageBox.Show("Invaild Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCar.Focus();
                return;
            }

            //instantiate  Object
            Cars reCar = new Cars();

            reCar.setAvailability(txtUpdate.Text);
            reCar.setRegNo(cboRemoveCar.Text);
            
            //remove  record into car table
            reCar.removeCar();

            //Display Confirmation Message
            MessageBox.Show("Car " +cboRemoveCar.Text+ " has been removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpRemoveCar.Visible = false;

            cboRemoveCar.SelectedIndex = -1;

        }
       
        private void cboRemoveCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboRemoveCar.SelectedIndex == -1)
            {
                return;
            }
            //find car details
            Cars rCars = new Cars();
            rCars.getCars(cboRemoveCar.Text);

            if (rCars.getReg().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMake.Focus();
                return;
            }

            //display car details
            txtMake.Text = rCars.getMake();
            txtModel.Text = rCars.getModel();
            txtReg.Text = rCars.getReg();
            txtCurrentAvailability.Text = rCars.getAvailability();


            //display details
            grpRemoveCar.Visible = true;
        }

       
    }
}
