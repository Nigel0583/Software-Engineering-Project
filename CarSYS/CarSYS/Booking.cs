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
    class Booking
    {
        private int bookNo;
        public int customerId;
        
        private decimal total;
        
        private string regNo;
        private string startDate;
        private string endDate;
        private string status;

        public Booking()
        {
            bookNo = 0;
           
            total = 0;
            
            regNo = "";
            startDate = "";
            endDate = "";
            status = "";
        }

        public Booking(int bookNo, int customerId ,string regNo,string startDate, string endDate, string status,int total) {
            this.bookNo = bookNo;
            this.customerId = customerId;
            
            this.regNo = regNo;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.total = total;

        }

        public void setCustomerid(int customerId)
        {
            this.customerId = customerId;
        }
        public void setBookNo(int bookNo)
        {
            this.bookNo = bookNo;
        }
        public void setTotal(decimal total)
        {
            this.total = total;
        }
        public void setRegNo(string regNo)
        {
            this.regNo = regNo;
        }

        public void setStartDate(string startDate)
        {
            this.startDate = startDate;
        }
        public void setEndDate(string endDate)
        {
            this.endDate = endDate;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }

        public int getBookNo()
        {
            return bookNo;
        }
        public int getCustomerID()
        {
            return customerId;
        }
        public decimal getTotal()
        {
            return total;
        }

        public string getRegNo()
        {
            return regNo;
        }

        public string getStartDate()
        {
            return startDate;
        }

        public string getEndDate()
        {
            return endDate;
        }
        public string getStatus()
        {
            return status;
        }




        public static int nextBookingNo()
        {
            try
            {
                // variable to hold value to be returned
                int intNextBookingNo = 1;

                //Conenct to the DB
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();


                String strSQL = "SELECT MAX(BookingID) FROM bookings";

                OracleCommand cmd = new OracleCommand(strSQL, conn);


                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();


                if (!dr.IsDBNull(0))
                    intNextBookingNo = dr.GetInt32(0) + 1;

                //close DB connection
                conn.Close();

                return intNextBookingNo;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
           
        }

        public void addBooking()
        {
            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();

            String insertBooking = "INSERT INTO bookings VALUES("+ this.bookNo.ToString()+","+this.customerId.ToString()+ ",'"+this.regNo.ToUpper()+"','"+this.startDate.ToUpper()+ "','"+this.endDate.ToUpper()+ "','"+this.status+"',"+this.total.ToString()+")";

            OracleCommand cmd = new OracleCommand(insertBooking, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteBooking()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            String strSQL = "DELETE FROM Bookings WHERE BookingID = "+this.bookNo ;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void getBooking(int bookno)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT * FROM bookings WHERE BookingID ='" + bookno + "'";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setBookNo(dr.GetInt32(0));
                setCustomerid(dr.GetInt32(1));
                setRegNo(dr.GetString(2));
                setStartDate(dr.GetString(3));
                setEndDate(dr.GetString(4));
                setStatus(dr.GetString(5));
                setTotal(dr.GetDecimal(6));
               
            }
            //close DB connection
            myConn.Close();
        }

        public static DataSet getBookingInfo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT BookingID, CustomerID  FROM Bookings WHERE bookingstatus = 'B' ORDER BY BookingID";

                //Create an OracleCommand object and instantiate it 
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "booking");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataSet getCurrentBookingInfo(DataSet DS)
        {
            try
            {


                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT BookingID, CustomerID  FROM Bookings WHERE bookingstatus = 'O' ORDER BY BookingID";

                //Create an OracleCommand object and instantiate it 
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "booking");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public void bookingStatus()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            String strSQL = "UPDATE bookings SET Bookingstatus = '" + this.status.ToUpper() + "' WHERE bookingid =" + this.bookNo ;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
        public void getInvoiceBooking()
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            String strSQL = "select * from bookings b, customers c where BookingID = ( select max(BookingID) from bookings ) AND b.customerid = c.customerid";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setBookNo(dr.GetInt32(0));
                setCustomerid(dr.GetInt32(1));
                setRegNo(dr.GetString(2));
                setStartDate(dr.GetString(3));
                setEndDate(dr.GetString(4));
                setStatus(dr.GetString(5));
                setTotal(dr.GetDecimal(6));
            }
            //close DB connection
            myConn.Close();
        }

    }
}
