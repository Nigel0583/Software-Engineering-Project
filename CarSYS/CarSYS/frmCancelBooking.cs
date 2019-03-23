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
    public partial class frmCancelBooking : Form
    {
        frmMainMenu parent;
        public frmCancelBooking(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            this.cboCancelBooking.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                ds = Booking.getBookingInfo(ds);
                for (int i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboCancelBooking.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
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

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

            if (cboCancelBooking.Text.Equals(""))
            {
                MessageBox.Show("Chose booking to cancel", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCancelBooking.Focus();
                return;

            }

            DialogResult cancel = new DialogResult();
            cancel = MessageBox.Show("Do you want to delete this booking?", "Cancel",
                     MessageBoxButtons.YesNo,
                     MessageBoxIcon.Warning,
                     MessageBoxDefaultButton.Button2);
            if (cancel == DialogResult.Yes)
            {
                
                //instantiate Stock Object
                Booking cancelBooking = new Booking();

                cancelBooking.setBookNo(Convert.ToInt32(txtBookingID.Text));
                cancelBooking.setCustomerid(Convert.ToInt32(txtCustomerID.Text));

                cancelBooking.deleteBooking();

                
                MessageBox.Show("Booking " + txtBookingID.Text + " has been canelled", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                

            }
            ClearUI();


        }

        private void cboRemoveCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if resetting combo, ignore
            if (cboCancelBooking.SelectedIndex == -1)
            {
                return;
            }
            //find cust details
            Booking booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboCancelBooking.Text));

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
            grpCancelBooking.Visible = true;
        }
        private void ClearUI()
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
    }
}
