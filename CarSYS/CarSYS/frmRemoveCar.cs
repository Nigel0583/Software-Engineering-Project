using System;
using System.Data;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmRemove : Form
    {
        private readonly frmMainMenu parent;

        public frmRemove(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            cboRemoveCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmRemove_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Close();
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
                MessageBox.Show("Set current availability to R or A", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtCurrentAvailability.Focus();
                return;
            }

            if (txtCurrentAvailability.Text.Trim().Equals("O"))
            {
                MessageBox.Show("You cannot remove car " + cboRemoveCar.Text + " since it is currently been rented",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCar.Focus();
                return;
            }

            if (!txtUpdate.Text.Equals("R") && !txtUpdate.Text.Equals("A"))
            {
                MessageBox.Show("Invaild Option", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCar.Focus();
                return;
            }

            
          

            var cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to remove car"+ txtReg.Text+"?", "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes)
            {
                var reCar = new Cars();

                reCar.setAvailability(txtUpdate.Text);
                reCar.setRegNo(cboRemoveCar.Text);
                //remove  record into car table
                reCar.removeCar();

                //Display Confirmation Message
                MessageBox.Show("Car " + cboRemoveCar.Text + " has been removed", "Confirmation", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                cboRemoveCar.SelectedIndex = -1;
                cboRemoveCar.Items.Clear();
                loadData();
            }

           
        }

        private void cboRemoveCar_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cboRemoveCar.SelectedIndex == -1) return;

            //find car details
            var rCars = new Cars();
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

        public void loadData()
        {
            grpRemoveCar.Visible = false;
            try
            {
                var ds = new DataSet();
                ds = Cars.getRegNo(ds);
                for (var i = 0; i < ds.Tables["reg"].Rows.Count; i++)
                    cboRemoveCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
            }
            catch (Exception)
            {
                Close();
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