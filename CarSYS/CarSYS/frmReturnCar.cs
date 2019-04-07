using System;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmReturnCar : Form
    {
        private readonly frmMainMenu parent;

        public frmReturnCar(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            cboReturnCar.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void frmReturnCar_Load(object sender, EventArgs e)
        {
            grpReturnCar.Visible = false;
            loadData();
        }

        private void btnReturnCar_Click(object sender, EventArgs e)
        {
            if (cboReturnCar.Text.Equals(""))
            {
                MessageBox.Show("Chose to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReturnCar.Focus();
                return;
            }

            var endDate = DateTime.ParseExact(txtEndDate.Text.Trim(), "yyyy-MM-dd",
                CultureInfo.InvariantCulture);


            if (DateTime.Today > endDate)
            {
                MessageBox.Show("This should be a late return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnLateReturn.Focus();
                return;
            }

            updateBookingCar();
            cboReturnCar.Items.Clear();
            loadData();
        }

        private void cboReturnCar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboReturnCar.SelectedIndex == -1) return;

            var booking = new Booking();
            booking.getBooking(Convert.ToInt32(cboReturnCar.Text));

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

            grpReturnCar.Visible = true;
          
            cboReturnCar.Visible = true;
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
            cboReturnCar.ResetText();
            cboReturnCar.SelectedIndex = -1;
        }

        private void btnLateReturn_Click(object sender, EventArgs e)
        {
            if (cboReturnCar.Text.Equals(""))
            {
                MessageBox.Show("Chose to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboReturnCar.Focus();
                return;
            }

            var today = DateTime.Today.ToString("yyyy-MM-dd");
            //From https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-date-and-time-format-strings
            var endDate = DateTime.ParseExact(txtEndDate.Text, "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
            var startDate = DateTime.ParseExact(txtStartDate.Text, "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
            var todayDate = DateTime.ParseExact(today, "yyyy-MM-dd",
                CultureInfo.InvariantCulture);

            if (DateTime.Today < endDate)
            {
                MessageBox.Show("This should be a normal return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnReturnCar.Focus();
                return;
            }
          
            var from = startDate.ToString("yyyy-MM-dd");
            var to = todayDate.ToString("yyyy-MM-dd");

            var ds = new DataSet();
            grdTotalCost.DataSource = Rates.getBookingCost(ds, to, from, txtReg.Text).Tables["book"];
            var tot = new Booking();
            string total = grdTotalCost.Rows[0].Cells[0].Value.ToString();
            tot.setTotal(Convert.ToDecimal(total));
            tot.setBookNo(Convert.ToInt32(txtBookingID.Text));
            tot.updateTotal();

            updateBookingCar();
        }

        public void updateBookingCar()
        {
            var bookingStatus = new Booking();

            bookingStatus.setStatus(txtBookingStatus.Text);
            bookingStatus.setBookNo(Convert.ToInt32(txtBookingID.Text));
            bookingStatus.bookingStatus();
           
            var reCar = new Cars();

            reCar.setAvailability(txtStatusCar.Text);
            reCar.setRegNo(txtReg.Text);

            reCar.collectCar();

            MessageBox.Show("Car with registration " + txtReg.Text + " has been returned", "Confirmation", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            print();
        }

        public void print()
        {
            //From https://www.youtube.com/watch?v=nAI-1w9MhwE
            pdReturn.Document = pdtReturn;
            if (pdReturn.ShowDialog() == DialogResult.OK) pdtReturn.Print();
        }

        private void pdtReturn_PrintPage(object sender, PrintPageEventArgs e)
        {
            //From https://www.codeproject.com/Tips/453871/Simple-Receipt-Like-Printing-Using-the-Csharp-Prin
            var dir = Path.GetDirectoryName(Application.ExecutablePath);
            var filename = Path.Combine(dir, @"logo.png");
            var imageFile = Image.FromFile(filename);

            var graphics = e.Graphics;


            var font = new Font("Courier New", 10);
            var fontHeight = font.GetHeight();
            var startX = 50;
            var startY = 55;
            var offset = 40;
            e.Graphics.DrawImage(imageFile, new PointF(0.0F, 0.0F));
            offset = offset + 20;

            graphics.DrawString("Car rental Receipt", new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphics.DrawString("Booking No:" + txtBookingID.Text,
                new Font("Courier New", 14),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            graphics.DrawString("Customer No :" + txtCustomerID.Text,
                new Font("Courier New", 12),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            var underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 20;

            graphics.DrawString("From " + txtStartDate.Text + " To " + txtEndDate.Text, new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;
            var total = "Total Amount to Pay Before fee = " + txtTotal.Text;
            graphics.DrawString(total, new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + offset);

            offset = offset + 20;
            underLine = "------------------------------------------";
            graphics.DrawString(underLine, new Font("Courier New", 10),
                new SolidBrush(Color.Black), startX, startY + offset);
            offset = offset + 20;

            var endDate = DateTime.ParseExact(txtEndDate.Text, "yyyy-MM-dd",
                CultureInfo.InvariantCulture);
            
            if (DateTime.Today < endDate)
            {
                offset = offset + 20;
                var grossTotal = "Total Amount to Pay = " + txtTotal.Text;

                graphics.DrawString(grossTotal, new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
            }
            else
            {

                string totalPay = grdTotalCost.Rows[0].Cells[0].Value.ToString();
                offset = offset + 20;
                var grossTotal = "Total Amount to Pay = " + totalPay;

                graphics.DrawString(grossTotal, new Font("Courier New", 10),
                    new SolidBrush(Color.Black), startX, startY + offset);
                offset = offset + 20;
            }

            clearUi();
        }

        public void loadData()
        {
            try
            {
                var ds = new DataSet();
                ds = Booking.getCurrentBookingInfo(ds);
                for (var i = 0; i < ds.Tables["booking"].Rows.Count; i++)
                    cboReturnCar.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(0, '0').Trim());
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