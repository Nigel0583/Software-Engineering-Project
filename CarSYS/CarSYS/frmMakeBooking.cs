using System;
using System.Data;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmMakeBooking : Form
    {
        private string cost;
        private readonly frmMainMenu parent;
        private string reg;


        public frmMakeBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            dtpFrom.MinDate = DateTime.Today;
            dtpTo.MinDate = DateTime.Today;
            cboCarCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void frmMakeBooking_Load(object sender, EventArgs e)
        {
            grpChoseCar.Visible = false;
            btnMakeBooking.Visible = false;

            grpChoseCustomer.Visible = false;
            grpMakeBooking.Visible = false;
            txtBookingNo.Text = Booking.nextBookingNo().ToString("00000");

            var ds = new DataSet();

            ds = Rates.getCatID(ds);

            cboCarCategory.Items.Clear();
            try
            {
                
                for (var i = 0; i < ds.Tables["cat"].Rows.Count; i++)
                    cboCarCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0').Trim());

                var dsCust = new DataSet();
                dsCust = Customer.getCustInfo(dsCust);
                for (var i = 0; i < dsCust.Tables["cust"].Rows.Count; i++)
                    cboCustomer.Items.Add(dsCust.Tables[0].Rows[i][0].ToString().PadLeft(3, '0') + " " +
                                          dsCust.Tables[0].Rows[i][1].ToString().Trim());
            }
            catch (Exception)
            {
                Close();
                parent.Visible = true;
            }
        }


        private void btnSelectCar_Click(object sender, EventArgs e)
        {
            grpChoseCar.Visible = true;

            var from = dtpFrom.Value.ToString("yyyy-MM-dd");
            var to = dtpTo.Value.ToString("yyyy-MM-dd");
          
            var ds = new DataSet();

            grdSelectCar.DataSource = Cars.availableForBooking(ds, from, to, cboCarCategory.Text).Tables["bookCar"];
        }

        private void cboCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
         
            if (cboCustomer.SelectedIndex == -1) return;

           
            var rCustomer = new Customer();
            rCustomer.getCustomers(Convert.ToInt32(cboCustomer.Text.Substring(0, 3)));

            if (rCustomer.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFirstName.Focus();
                return;
            }

           
            txtFirstName.Text = rCustomer.getFname();
            txtSurname.Text = rCustomer.getSname();
            txtLicence.Text = rCustomer.getLicence();
            txtPhone.Text = rCustomer.getPhoneNum();
            txtEmail.Text = rCustomer.getEmail();
            txtCustomerID.Text = rCustomer.getCustomerID().ToString("00000");


            grpChoseCustomer.Visible = true;
        }

        private void grdSelectCar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnMakeBooking.Visible = true;
            var from = dtpFrom.Value.ToString("yyyy-MM-dd");
            var to = dtpTo.Value.ToString("yyyy-MM-dd");
            //From https://www.youtube.com/watch?v=SqQAbzDs3jo
            if (e.RowIndex >= 0)
            {
                var view = grdSelectCar.Rows[e.RowIndex];

                reg = view.Cells["RegNo"].Value.ToString();
                txtRegChosen.Text = reg;

                cost = view.Cells["cost"].Value.ToString();
                txtCost.Text = cost;

                var ds = new DataSet();

                grdTotalCost.DataSource = Rates.getBookingCost(ds, to, from, reg).Tables["book"];
            }
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            //From https://www.actiprosoftware.com/community/thread/2078/events-on-cancelbutton-and-formclose
            var cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to cancel?", "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes) ClearUI();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (cboCustomer.Text.Equals(""))
            {
                MessageBox.Show("Chose a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCustomer.Focus();
                return;
            }

            if (cboCarCategory.Text.Equals(""))
            {
                MessageBox.Show("Chose a customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarCategory.Focus();
                return;
            }

            if (txtRegChosen.Text.Equals(""))
            {
                MessageBox.Show("Chose a car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpChoseCar.Focus();
                return;
            }

            var from = dtpFrom.Value.ToString("yyyy-MM-dd");
            var to = dtpTo.Value.ToString("yyyy-MM-dd");
            var total = grdTotalCost.Rows[0].Cells["total"].Value.ToString();
            var totalCost = int.Parse(total);

            var booking = new Booking(Convert.ToInt32(txtBookingNo.Text), Convert.ToInt32(txtCustomerID.Text),
                txtRegChosen.Text, from, to, "B", totalCost);

            //find cust details
            var customer = new Customer();
            customer.getCustomers(Convert.ToInt32(txtCustomerID.Text.Substring(0, 3)));

            booking.addBooking();

            //Display confirmation
            MessageBox.Show(
                "Car with registration:\n" + txtRegChosen.Text + "\nhas been booked by customer:\n" +txtCustomerID.Text,
                "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearUI();
            txtBookingNo.Text = Booking.nextBookingNo().ToString("00000");

            Hide();

            var frmInvoice = new frmInvoice(this);
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
            if (dtpTo.Value < dtpFrom.Value) MessageBox.Show("End date must be greater than Start date");
            grpChoseCar.Visible = false;
            btnMakeBooking.Visible = false;
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
            grpChoseCar.Visible = false;
            btnMakeBooking.Visible = false;
        }

        //From https://stackoverflow.com/questions/1669318/override-standard-close-x-button-in-a-windows-form
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;
        }

        private void cboCarCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpMakeBooking.Visible = true;
            grpChoseCar.Visible = false;
            btnMakeBooking.Visible = false;
        }
    }
}