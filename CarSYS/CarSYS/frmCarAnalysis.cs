using System;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    public partial class frmCarAnalysis : Form
    {
        private readonly frmMainMenu parent;

        public frmCarAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy";
            dtpDate.ShowUpDown = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            parent.Visible = true;
        }

        private void frmCarAnalysis_Load(object sender, EventArgs e)
        {
            dtpDate.Format = DateTimePickerFormat.Custom;
            dtpDate.CustomFormat = "yyyy";
            cboCarCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            // create instance of data set
            var ds = new DataSet();

            ds = Rates.getCatID(ds);

          
            cboCarCategory.Items.Clear();
            try
            {
              
                for (var i = 0; i < ds.Tables["cat"].Rows.Count; i++)
                    cboCarCategory.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(3, '0').Trim());
            }
            catch (Exception)
            {
                
               
                Close();
                parent.Visible = true;
            }
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

        public string getMonth(int month)
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
            var strSQL =
                "SELECT COUNT(c.catid) ,to_Char(TO_DATE(EndDate,'YYYY-MM-DD'),'MM') FROM bookings   LEFT JOIN  cars c  ON c.catid = '" +
                cboCarCategory.Text + "'" +
                " WHERE BOOKINGSTATUS = 'R' AND EXTRACT(YEAR FROM TO_DATE(EndDate, 'YYYY-MM-DD')) = '" + dtpDate.Text +
                "' AND bookings.REGNO = c.REGNO " +
                "GROUP BY to_Char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM') " +
                "ORDER BY to_char(TO_DATE(EndDate, 'YYYY-MM-DD'), 'MM')";


            var dt = new DataTable();

            var myConn = new OracleConnection(CarSysConnect.oradb);

            var cmd = new OracleCommand(strSQL, myConn);
            var da = new OracleDataAdapter(cmd);

            da.Fill(dt);
            myConn.Close();

            var N = new string[dt.Rows.Count];
            var M = new decimal[dt.Rows.Count];

            for (var i = 0; i < dt.Rows.Count; i++)
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

            

            chtData.Titles.Add("Yearly Car Type Analyse");
           
            chtData.ChartAreas[0].AxisX.Title = "MONTH";
            chtData.ChartAreas[0].AxisY.Title = "No. Car Type";
            chtData.Series[0].IsVisibleInLegend = false;


            chtData.Visible = true;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;
            parent.Visible = true;
        }
    }
}