using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmRemoveCustomer : Form
    {
        frmMainMenu parent;

        public frmRemoveCustomer(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        public frmRemoveCustomer()
        {
            InitializeComponent();
        }

        private void frmRemoveCustomer_Load(object sender, EventArgs e)
        {
            this.cboRemoveCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                DataSet ds = new DataSet();
                ds = Customer.getCustInfo(ds);
                for (int i = 0; i < ds.Tables["cust"].Rows.Count; i++)
                    cboRemoveCustomer.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                                                ds.Tables[0].Rows[i][1].ToString());
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


        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (cboRemoveCustomer.Text.Equals(""))
            {
                MessageBox.Show("Chose a customer to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRemoveCustomer.Focus();
                return;
            }

            if (txtUpdate.Text.Equals(""))
            {
                MessageBox.Show("Set current availability to R or A", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtUpdate.Focus();
                return;
            }


            if (!txtUpdate.Text.Equals("R") && !txtUpdate.Text.Equals("A"))
            {
                MessageBox.Show("Invaild Option R or A", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUpdate.Focus();
                return;
            }


            //instantiate Stock Object
            Customer customer = new Customer();

            customer.setStatus(Convert.ToChar(txtUpdate.Text));
            customer.setCustomerID(Convert.ToInt32(txtCustomerID.Text));


            //INSERT Stock record into car table
            customer.removeCustomer();

            //Display Confirmation Message
            MessageBox.Show("Customer " + txtCustomerID.Text + " has been removed", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //reset UI
            grpRemoveCustomer.Visible = false;

            cboRemoveCustomer.SelectedIndex = -1;
        }


        private void cboRemoveCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboRemoveCustomer.SelectedIndex == -1)
            {
                return;
            }

            //find cust details
            Customer rCustomer = new Customer();
            rCustomer.getCustomers(Convert.ToInt32(cboRemoveCustomer.Text.Substring(0, 3)));

            if (rCustomer.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

            //display cust details
            txtFirstName.Text = rCustomer.getFname();
            txtSurname.Text = rCustomer.getSname();
            txtLicence.Text = rCustomer.getLicence();
            txtPhone.Text = rCustomer.getLicence();
            txtEmail.Text = rCustomer.getEmail();
            txtCustomerID.Text = rCustomer.getCustomerID().ToString("00000");


            //display details
            grpRemoveCustomer.Visible = true;
        }
    }
}