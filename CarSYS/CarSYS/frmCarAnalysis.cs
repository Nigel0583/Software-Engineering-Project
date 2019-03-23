using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    public partial class frmCarAnalysis : Form
    {
        frmMainMenu parent;
        public frmCarAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
            
        }

        private void btnCarType_Click(object sender, EventArgs e)
        {
            chtData.Titles.Clear();
            if (cboCarCategory.Text.Equals(""))
            {
                MessageBox.Show("Please chose a car type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboCarCategory.Focus();
                return;

            }

            fillChart();
        }
        public String getMonth(int month)
        {
            switch (month)
            {
                case 1:
                    {
                        return "JAN";

                    }
                case 2:
                    {
                        return "FEB";

                    }
                case 3:
                    {
                        return "MAR";

                    }
                case 4:
                    {
                        return "APR";

                    }
                case 5:
                    {
                        return "MAY";

                    }
                case 6:
                    {
                        return "JUN";

                    }
                case 7:
                    {
                        return "JUL";

                    }
                case 8:
                    {
                        return "AUG";

                    }
                case 9:
                    {
                        return "SEP";

                    }
                case 10:
                    {
                        return "OCT";

                    }
                case 11:
                    {
                        return "NOV";

                    }
                case 12:
                    {
                        return "DEC";

                    }
                default: return "OTH";

            }
        }
        private void fillChart()
        {
            string from = dtpDate.Value.ToString("yyyy");
            
            String strSQL = "SELECT COUNT(cars.catid), to_Char(TO_DATE(EndDate,'YYYY-MM-DD'),'MM') FROM rates ra, cars, bookings " +
                "WHERE ra.catid = '"+ cboCarCategory.Text + "' AND  ra.catid  = cars.CatID AND bookings.bookingstatus = 'R' AND" +
                " cars.RegNo IN(SELECT bookings.RegNo FROM bookings WHERE  EndDate LIKE '" + from + "%') " +
                "GROUP BY to_Char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM') " +
                "ORDER BY to_char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM')";


            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            myConn.Close();

            string[] N = new string[dt.Rows.Count];
            decimal[] M = new decimal[dt.Rows.Count];

            for (int i = 0; i < dt.Rows.Count; i++)
            {

                N[i] = getMonth(Convert.ToInt32(dt.Rows[i][1]));
                M[i] = Convert.ToDecimal(dt.Rows[i][0]);
            }

            //order the arrays N and M

            chtData.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtData.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtData.Series[0].LegendText = "No. Car Type";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

            chtData.Titles.Add("Yearly Car Type Analyse");
            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "No. Car Type";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }

        private void frmCarAnalysis_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy";
            this.cboCarCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            // create instance of data set
            DataSet ds = new DataSet();

            ds = Rates.getCatID(ds);

            //Remove existing items from combo box
            cboCarCategory.Items.Clear();
            try
            {
                //load data from ds to cbo
                for (int i = 0; i < ds.Tables["cat"].Rows.Count; i++)
                    cboCarCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0').Trim());
            }
            catch
            {
                this.Close();
                parent.Visible = true;
            }

            
        }

        private void cboCarCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
