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
    public partial class frmRevenueAnalysis : Form
    {
        frmMainMenu parent;

        public frmRevenueAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            dtpFrom.Format = DateTimePickerFormat.Custom;
            dtpFrom.CustomFormat = "yyyy";
            dtpFrom.ShowUpDown = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
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
            String strSQL = "SELECT SUM(Total), to_Char(TO_DATE(EndDate,'YYYY-MM-DD'),'MM') as Month FROM bookings " +
                            "WHERE EXTRACT(YEAR FROM TO_DATE(EndDate, 'YYYY-MM-DD')) = '" + dtpFrom.Text + "' " +
                            "GROUP BY to_Char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM') " +
                            "ORDER BY to_char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM')";
            DataTable dt = new DataTable();

            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);

            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            try
            {
                da.Fill(dt);
                myConn.Close();
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to complete the search", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }


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
            chtData.Series[0].LegendText = "Income in €";

            chtData.Series["Series1"]["PointWidth"] = ".5";

            chtData.Series["Series1"]["PixelPointWidth"] = "20";
            chtData.Series[0].Points.DataBindXY(N, M);
            chtData.ChartAreas["ChartArea1"].AxisX.LabelStyle.Format = "C";

            //chtSales.Series[0].Points[0] = "XXX";
            //chtData.Series[0].Label = "#VALY";

            chtData.Titles.Add("Yearly Revenue");
            //chtData.ChartAreas[0].AxisX.LabelStyle.si = 5;
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "€'s";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            fillChart();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            chtData.Titles.Clear();
            fillChart();
        }
    }
}