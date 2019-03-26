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
    public partial class frmMakeBooking : Form
    {
        frmMainMenu parent;
        string reg;
        string cost;


        public frmMakeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            dtpFrom.MinDate = DateTime.Today;
            dtpTo.MinDate = DateTime.Today;
            this.cboCarCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            txtBookingNo.Text = Booking.nextBookingNo().ToString("00000");

            // create instance of data set
            DataSet ds = new DataSet();

            ds = Rates.getCatID(ds);

            //Remove existing items from combo box
            cboCarCategory.Items.Clear();
            try
            {
                //load data from ds to cbo
                for (int i = 0; i < ds.Tables["cat"].Rows.Count; i++)
                    cboCarCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0').Trim());

                DataSet dsCust = new DataSet();
                dsCust = Customer.getCustInfo(dsCust);
                for (int i = 0; i < dsCust.Tables["cust"].Rows.Count; i++)
                    cboCustomer.Items.Add(dsCust.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                                          dsCust.Tables[0].Rows[i][1].ToString().Trim());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
        }


        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            string from = dtpFrom.Value.ToString("yyyy-MM-dd");
            string to = dtpTo.Value.ToString("yyyy-MM-dd");
            // create instance of data set
            DataSet ds = new DataSet();

            grdSelectCar.DataSource = Cars.availableForBooking(ds, from, to, cboCarCategory.Text).Tables["bookCar"];
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboCustomer.SelectedIndex == -1)
            {
                return;
            }

            //find cust details
            Customer rCustomer = new Customer();
            rCustomer.getCustomers(Convert.ToInt32(cboCustomer.Text.Substring(0, 3)));

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
            txtPhone.Text = rCustomer.getPhoneNum();
            txtEmail.Text = rCustomer.getEmail();
            txtCustomerID.Text = rCustomer.getCustomerID().ToString("00000");


            //display details
            grpChoseCar.Visible = true;
        }

        private void grdSelectCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string from = dtpFrom.Value.ToString("yyyy-MM-dd");
            string to = dtpTo.Value.ToString("yyyy-MM-dd");
            //From https://www.youtube.com/watch?v=SqQAbzDs3jo
            if (e.RowIndex >= 0)
            {
                DataGridViewRow view = this.grdSelectCar.Rows[e.RowIndex];

                reg = view.Cells["RegNo"].Value.ToString();
                txtRegChosen.Text = reg;

                cost = view.Cells["cost"].Value.ToString();
                txtCost.Text = cost;

                DataSet ds = new DataSet();

                grdTotalCost.DataSource = Rates.getBookingCost(ds, to, from, reg).Tables["book"];
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            //From https://www.actiprosoftware.com/community/thread/2078/events-on-cancelbutton-and-formclose
            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to cancel?", "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes)
            {
                ClearUI();
            }
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            string from = dtpFrom.Value.ToString("yyyy-MM-dd");
            string to = dtpTo.Value.ToString("yyyy-MM-dd");
            string total = grdTotalCost.Rows[0].Cells["total"].Value.ToString();
            int totalCost = Int32.Parse(total);

            Booking booking = new Booking(Convert.ToInt32(txtBookingNo.Text), Convert.ToInt32(txtCustomerID.Text),
                txtRegChosen.Text, from, to, "B", totalCost);

            //find cust details
            Customer customer = new Customer();
            customer.getCustomers(Convert.ToInt32(txtCustomerID.Text.Substring(0, 3)));

            booking.addBooking();

            //Display confirmation
            MessageBox.Show("Car Reg " + txtRegChosen.Text + ", Customer" + txtCustomerID.Text, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUI();
            txtBookingNo.Text = Booking.nextBookingNo().ToString("00000");

            this.Hide();

            frmInvoice frmInvoice = new frmInvoice(this);
            frmInvoice.Show();
        }

        private void ClearUI()
        {
            txtCustomerID.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLicence.Clear();
            txtPhone.Clear();
            txtRegChosen.Clear();
            txtSurname.Clear();
            dtpFrom.ResetText();
            dtpTo.ResetText();
            cboCarCategory.ResetText();
            cboCustomer.ResetText();
            grdSelectCar.DataSource = null;
            grdSelectCar.Rows.Clear();
            grdTotalCost.DataSource = null;
            grdTotalCost.Rows.Clear();
            txtCost.Clear();
            cboCustomer.SelectedIndex = -1;
            cboCarCategory.SelectedIndex = -1;
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTo.Value < dtpFrom.Value)
            {
                MessageBox.Show("End date must be greater than Start date");
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        private void cboCarCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}