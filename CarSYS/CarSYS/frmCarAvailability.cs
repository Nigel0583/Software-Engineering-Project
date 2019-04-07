using System;
using System.Data;
using System.Windows.Forms;

namespace CarSYS
{
    public partial class frmCarAvailability : Form
    {
        private readonly frmMainMenu parent;

        public frmCarAvailability(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            // Set the MinDate
            dtpFrom.MinDate = DateTime.Today;
            dtpTo.MinDate = DateTime.Today;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            var from = dtpFrom.Value.ToString("yyyy-MM-dd");
            var to = dtpTo.Value.ToString("yyyy-MM-dd");
            try
            {
               
                var ds = new DataSet();

                grdData.DataSource = Cars.checkCarAvailability(ds, from, to).Tables["chkCar"];
            }
            catch (Exception)
            {
                
               
                Close();
                parent.Visible = true;
            }
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;
        }

    }
}