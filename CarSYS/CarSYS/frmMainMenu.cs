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
            this.Hide();
            frmAddcar frmAddcar = new frmAddcar(this);
            frmAddcar.Show();
        }

        private void carTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCarType frmAddCarType = new frmAddCarType(this);
            frmAddCarType.Show();
       
        }

        private void checkCarAvailabilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarAvailability frmCarAvailability = new frmCarAvailability(this);
            frmCarAvailability.Show();

        }

        private void removeCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemove frmRemove = new frmRemove(this);
            frmRemove.Show();
        }

        

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMakeBooking frmMakeBooking = new frmMakeBooking(this);
            frmMakeBooking.Show();

        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCancelBooking frmCancelBooking = new frmCancelBooking(this);
            frmCancelBooking.Show();
        }

        private void returnCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReturnCar frmReturnCar = new frmReturnCar(this);
            frmReturnCar.Show();
        }

        private void collectCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCollectCar frmCollectCar = new frmCollectCar(this);
            frmCollectCar.Show();
        }

        private void revenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRevenueAnalysis frmRevenueAnalysis = new frmRevenueAnalysis(this);
            frmRevenueAnalysis.Show();
        }

        private void carAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCarAnalysis frmCarAnalysis = new frmCarAnalysis(this);
            frmCarAnalysis.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddCustomer frmAddCustomer = new frmAddCustomer(this);
            frmAddCustomer.Show();

        }

        private void updateCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUpdateCustomer frmUpdateCustomer = new frmUpdateCustomer(this);
            frmUpdateCustomer.Show();
        }

        private void removeCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRemoveCustomer frmRemoveCustomer  = new frmRemoveCustomer(this);
            frmRemoveCustomer.Show();

        }
    }
}
