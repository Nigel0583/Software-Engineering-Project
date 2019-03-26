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
    public partial class frmCollectCar : Form
    {
        frmMainMenu parent;

        public frmCollectCar(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.cboCollectCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmCollectCar_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Booking.getBookingInfo(ds);
                for (int i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboCollectCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
        }

        private void btnCollectCar_Click(object sender, EventArgs e)
        {
            if (cboCollectCar.Text.Equals(""))
            {
                MessageBox.Show("Chose booking to collect car", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCollectCar.Focus();
                return;
            }

            Booking bookingStatus = new Booking();

            bookingStatus.setStatus(txtBookingStatus.Text);
            bookingStatus.setBookNo(Convert.ToInt32(txtBookingID.Text));
            bookingStatus.bookingStatus();
            //instantiate  Object
            Cars reCar = new Cars();

            reCar.setAvailability(txtStatusCar.Text);
            reCar.setRegNo(txtReg.Text);

            //INSERT  record into car table
            reCar.collectCar();

            //Display Confirmation Message
            MessageBox.Show("Car " + cboCollectCar.Text + " has been collected", "Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            clearUi();
        }

        private void cboCollectCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboCollectCar.SelectedIndex == -1)
            {
                return;
            }

            //find cust details
            Booking booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboCollectCar.Text));

            if (booking.getCustomerID().Equals(0))
            {
                MessageBox.Show("No details found", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookingID.Focus();
                return;
            }

            //display cust details
            txtBookingID.Text = booking.getBookNo().ToString("00000");
            txtCustomerID.Text = booking.getCustomerID().ToString("00000");
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
    }
}