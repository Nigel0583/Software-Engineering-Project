using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    internal class Rates
    {
        private string catId;
        private decimal cost;
        private string description;

        public Rates()
        {
            catId = "";
            description = "";
            cost = 0;
        }

        public Rates(string catId, string description, decimal cost)
        {
            this.catId = catId;
            this.description = description;
            this.cost = cost;
        }

        public void setCatId(string catId)
        {
            this.catId = catId;
        }

        public void setCost(decimal cost)
        {
            this.cost = cost;
        }

        public void setDescription(string description)
        {
            this.description = description;
        }

        public decimal getCost()
        {
            return cost;
        }


        public static bool checkCategoryExists(string CatId)
        {
            try
            {
                var exists = false;

                var conn = new OracleConnection(CarSysConnect.oradb);

                conn.Open();

                var strSQL = "SELECT * FROM rates WHERE CatID ='" + CatId + "'";

                var cmd = new OracleCommand(strSQL, conn);

                var dr = cmd.ExecuteReader();

                if (dr.Read()) exists = true;

                return exists;
            }
            catch (OracleException e)
            {
                
                MessageBox.Show("Code: "+ e.ErrorCode+ "\n Message: "+ e.Message+ "\n\n An exception occurred.\n Please contact your system administrator.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }


        public static DataSet getCatID(DataSet DS)
        {
            try
            {
                var conn = new OracleConnection(CarSysConnect.oradb);

                var strSQL = "SELECT CatID FROM Rates ORDER BY CatID";

                var cmd = new OracleCommand(strSQL, conn);

                var da = new OracleDataAdapter(cmd);

                da.Fill(DS, "cat");

                conn.Close();

                return DS;
            }
            catch (OracleException e)
            {
                
                MessageBox.Show("Code: "+ e.ErrorCode+ "\n Message: "+ e.Message+ "\n\n An exception occurred.\n Please contact your system administrator.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }


        public void addRates()
        {
            try
            {
                var conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();

                var insertRates = "INSERT INTO rates VALUES('" + catId.ToUpper() +
                                  "','" + description.ToUpper() + "'," + cost + ")";

                var cmd = new OracleCommand(insertRates, conn);
                cmd.ExecuteNonQuery();

                conn.Close();
            }
            catch (OracleException e)
            {
                
                MessageBox.Show("Code: "+ e.ErrorCode+ "\n Message: "+ e.Message+ "\n\n An exception occurred.\n Please contact your system administrator.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                
            }
        }

        public static DataSet getBookingCost(DataSet DS, string start, string end, string reg)
        {
            var conn = new OracleConnection(CarSysConnect.oradb);


            //Define the SQL Query to retrieve the data
            var strSQL = "SELECT ((TO_DATE('" + start + "', 'yyyy-MM-dd')+1)- TO_DATE('" + end +
                         "', 'yyyy-MM-dd')) * ra.COST AS Total from rates ra, cars ca WHERE RegNo = '" + reg +
                         "' AND ca.CatID = ra.CatID";

            var cmd = new OracleCommand(strSQL, conn);

            var da = new OracleDataAdapter(cmd);

            da.Fill(DS, "book");

            conn.Close();

            return DS;
        }

        public void getInvoicePerDay()
        {
           
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL =
                "select * from rates r,  bookings b, cars c  where BookingID = ( select max(BookingID) from bookings ) AND b.regno = c.regno AND r.catid = c.catid";

            var cmd = new OracleCommand(strSQL, myConn);

            var dr = cmd.ExecuteReader();


            if (dr.Read()) setCost(dr.GetDecimal(2));

            myConn.Close();
        }
    }
}