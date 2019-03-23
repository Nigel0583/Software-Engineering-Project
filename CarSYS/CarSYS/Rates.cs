using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Windows.Forms;

namespace CarSYS
{
    class Rates
    {
        private string catID;
        private string description;
        private decimal cost;

        public Rates()
        {
            catID = "";
            description = "";
            cost = 0;
           
        }

        public Rates(string catID, string description, decimal cost)
        {
            this.catID = catID;
            this.description = description;
            this.cost = cost;
        }

        public void setCatId(String CatID)
        {
            this.catID = CatID;
        }

        public void setCost(decimal Cost)
        {
            this.cost = Cost;
        }

        public void setDescription(String Description)
        {
            this.description = Description;
        }

        public decimal getCost()
        {
            return cost;
        }

        
    public static Boolean checkCategoryExists(String CatId)
        {
            try
            {
                Boolean exists = false;

                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                conn.Open();

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT * FROM rates WHERE CatID ='" + CatId + "'";

                //Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    exists = true;
                }

                return exists;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
            }
          

    public static DataSet getCatID(DataSet DS)
        {

            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT CatID FROM Rates ORDER BY CatID";

                //Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "cat");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null ;
            }
            
        }


        public  void addRates()
        {
            try
            {
                //connect to database
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();

                //Define SQL query to INSERT rate record
                String insertRates = "INSERT INTO rates VALUES('" + this.catID.ToUpper() +
                    "','" + this.description.ToUpper() + "'," + this.cost + ")";

                //Execute the command
                OracleCommand cmd = new OracleCommand(insertRates, conn);
                cmd.ExecuteNonQuery();

                //close DB connection
                conn.Close();

            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        public static DataSet getBookingCost(DataSet DS, String start, String end, String reg)
        {

            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);


            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT ((TO_DATE('"+start+"', 'yyyy-MM-dd')+1)- TO_DATE('"+end+"', 'yyyy-MM-dd')) * ra.COST AS Total from rates ra, cars ca WHERE RegNo = '"+reg+
                "' AND ca.CatID = ra.CatID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "book");

            conn.Close();

            return DS;

        }

        public void getInvoicePerDay()
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            String strSQL = "select * from rates r,  bookings b, cars c  where BookingID = ( select max(BookingID) from bookings ) AND b.regno = c.regno AND r.catid = c.catid";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setCost(dr.GetDecimal(2));
                
            }
            //close DB connection
            myConn.Close();
        }
    }
}
