using System;
using System.Data;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmCancelBooking : Form
    {
        private readonly frmMainMenu parent;

        public frmCancelBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            cboCancelBooking.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            grpCancelBooking.Visible = false;
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (cboCancelBooking.Text.Equals(""))
            {
                MessageBox.Show("Chose booking to cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCancelBooking.Focus();
                return;
            }

            var cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to delete this booking?", "Cancel",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes)
            {
                //instantiate Stock Object
                var cancelBooking = new Booking();

                cancelBooking.setBookNo(Convert.ToInt32(txtBookingID.Text));
                cancelBooking.setCustomerId(Convert.ToInt32(txtCustomerID.Text));

                cancelBooking.deleteBooking();


                MessageBox.Show("Booking No. " + txtBookingID.Text + " has been canelled", "Confirmation",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            clearUi();
            cboCancelBooking.Items.Clear();
            loadData();
        }

        private void cboRemoveCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpCancelBooking.Visible = true;
            
            if (cboCancelBooking.SelectedIndex == -1) return;

            //find cust details
            var booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboCancelBooking.Text));

            if (booking.getCustomerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            //display cust details
            txtBookingID.Text = booking.getBookNo().ToString("00000");
            txtCustomerID.Text = booking.getCustomerId().ToString("00000");
            txtReg.Text = booking.getRegNo();
            txtStartDate.Text = booking.getStartDate();
            txtEndDate.Text = booking.getEndDate();
            txtStatus.Text = booking.getStatus();
            txtTotal.Text = booking.getTotal().ToString();


            //display details
            grpCancelBooking.Visible = true;
        }

        private void clearUi()
        {
            txtCustomerID.Clear();
            txtBookingID.Clear();
            txtEndDate.Clear();
            txtReg.Clear();
            txtStartDate.Clear();
            txtStatus.Clear();
            txtTotal.Clear();
            cboCancelBooking.ResetText();
            cboCancelBooking.SelectedIndex = -1;
        }

        public void loadData()
        {
            cboCancelBooking.Items.Clear();
            try
            {
                var ds = new DataSet();
                ds = Booking.getBookingInfo(ds);
                for (var i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboCancelBooking.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
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