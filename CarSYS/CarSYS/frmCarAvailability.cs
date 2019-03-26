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
    public partial class frmCarAvailability : Form
    {
        frmMainMenu parent;

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
            this.Close();
            parent.Visible = true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string from = dtpFrom.Value.ToString("yyyy-MM-dd");
            string to = dtpTo.Value.ToString("yyyy-MM-dd");
            try
            {
                // create instance of data set
                DataSet ds = new DataSet();

                grdData.DataSource = Cars.checkCarAvailability(ds, from, to).Tables["chkCar"];
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }
        }

        private void frmCarAvailability_Load(object sender, EventArgs e)
        {
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            dtpTo.MinDate = dtpFrom.Value;
        }
    }
}