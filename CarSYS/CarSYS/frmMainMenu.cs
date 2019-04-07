using System;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void bookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void addCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmAddcar = new frmAddcar(this);
            frmAddcar.Show();
        }

        private void carTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmAddCarType = new frmAddCarType(this);
            frmAddCarType.Show();
        }

        private void checkCarAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmCarAvailability = new frmCarAvailability(this);
            frmCarAvailability.Show();
        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmRemove = new frmRemove(this);
            frmRemove.Show();
        }


        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmMakeBooking = new frmMakeBooking(this);
            frmMakeBooking.Show();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmCancelBooking = new frmCancelBooking(this);
            frmCancelBooking.Show();
        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmReturnCar = new frmReturnCar(this);
            frmReturnCar.Show();
        }

        private void collectCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmCollectCar = new frmCollectCar(this);
            frmCollectCar.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmRevenueAnalysis = new frmRevenueAnalysis(this);
            frmRevenueAnalysis.Show();
        }

        private void carAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmCarAnalysis = new frmCarAnalysis(this);
            frmCarAnalysis.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {
        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmAddCustomer = new frmAddCustomer(this);
            frmAddCustomer.Show();
        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmUpdateCustomer = new frmUpdateCustomer(this);
            frmUpdateCustomer.Show();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var frmRemoveCustomer = new frmRemoveCustomer(this);
            frmRemoveCustomer.Show();
        }
    }
}