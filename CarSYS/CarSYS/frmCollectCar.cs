using System;
using System.Data;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmCollectCar : Form
    {
        private readonly frmMainMenu parent;

        public frmCollectCar(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            cboCollectCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void frmCollectCar_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {
            if (cboCollectCar.Text.Equals(""))
            {
                MessageBox.Show("Chose booking to collect car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCollectCar.Focus();
                return;
            }

            var bookingStatus = new Booking();

            bookingStatus.setStatus(txtBookingStatus.Text);
            bookingStatus.setBookNo(Convert.ToInt32(txtBookingID.Text));
            bookingStatus.bookingStatus();
            
            var reCar = new Cars();

            reCar.setAvailability(txtStatusCar.Text);
            reCar.setRegNo(txtReg.Text);

           
            reCar.collectCar();

            //Display Confirmation Message
            MessageBox.Show("Car " + cboCollectCar.Text + " has been collected", "Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            clearUi();
            cboCollectCar.Items.Clear();
            loadData();
        }

        private void cboCollectCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            grpCollectCar.Visible = true;
          
            if (cboCollectCar.SelectedIndex == -1) return;

           
            var booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboCollectCar.Text));

            if (booking.getCustomerId().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

           
            txtBookingID.Text = booking.getBookNo().ToString("00000");
            txtCustomerID.Text = booking.getCustomerId().ToString("00000");
            txtReg.Text = booking.getRegNo();
            txtStartDate.Text = booking.getStartDate();
            txtEndDate.Text = booking.getEndDate();
            txtStatus.Text = booking.getStatus();
            txtTotal.Text = booking.getTotal().ToString();


            //display details
            cboCollectCar.Visible = true;
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
            cboCollectCar.ResetText();
            cboCollectCar.SelectedIndex = -1;
        }

        public void loadData()
        {
            grpCollectCar.Visible = false;
            try
            {
                var ds = new DataSet();
                ds = Booking.getBookingInfo(ds);
                for (var i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboCollectCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
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