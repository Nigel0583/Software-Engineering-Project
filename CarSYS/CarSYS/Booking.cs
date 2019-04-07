using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    internal class Booking
    {
        private int bookNo;
        private int customerId;
        private string endDate;

        private string regNo;
        private string startDate;
        private string status;

        private decimal total;

        public Booking()
        {
            bookNo = 0;

            total = 0;

            regNo = "";
            startDate = "";
            endDate = "";
            status = "";
        }

        public Booking(int bookNo, int customerId, string regNo, string startDate, string endDate, string status,
            int total)
        {
            this.bookNo = bookNo;
            this.customerId = customerId;

            this.regNo = regNo;
            this.startDate = startDate;
            this.endDate = endDate;
            this.status = status;
            this.total = total;
        }

        public void setCustomerId(int customerId)
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

        public int getCustomerId()
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
                var intNextBookingNo = 1;
                var conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();


                var strSQL = "SELECT MAX(BookingID) FROM bookings";

                var cmd = new OracleCommand(strSQL, conn);


                var dr = cmd.ExecuteReader();

                dr.Read();


                if (!dr.IsDBNull(0))
                    intNextBookingNo = dr.GetInt32(0) + 1;

                //close DB connection
                conn.Close();

                return intNextBookingNo;
            }
            catch (OracleException e)
            {
                //Learned from https://docs.microsoft.com/en-us/dotnet/api/system.data.oracleclient.oracleexception?view=netframework-4.7.2
                MessageBox.Show(
                    "Code: " + e.ErrorCode + "\n Message: " + e.Message +
                    "\n\n An exception occurred.\n Please contact your system administrator.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }
        }

        public void addBooking()
        {
            var conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();

            var insertBooking = "INSERT INTO bookings VALUES(" + bookNo + "," +
                                customerId + ",'" + regNo.ToUpper() + "','" +
                                startDate.ToUpper() + "','" + endDate.ToUpper() + "','" + status +
                                "'," + total + ")";

            var cmd = new OracleCommand(insertBooking, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void deleteBooking()
        {
            //connect to database
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            var strSQL = "DELETE FROM Bookings WHERE BookingID = " + bookNo;

            //Execute the command
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void getBooking(int bookno)
        {
            
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL = "SELECT * FROM bookings WHERE BookingID ='" + bookno + "'";

            var cmd = new OracleCommand(strSQL, myConn);

           
            var dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setBookNo(dr.GetInt32(0));
                setCustomerId(dr.GetInt32(1));
                setRegNo(dr.GetString(2));
                setStartDate(dr.GetString(3));
                setEndDate(dr.GetString(4));
                setStatus(dr.GetString(5));
                setTotal(dr.GetDecimal(6));
            }

           
            myConn.Close();
        }

        public static DataSet getBookingInfo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                var conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                var strSQL =
                    "SELECT BookingID, CustomerID  FROM Bookings WHERE bookingstatus = 'B' ORDER BY BookingID";

                //Create an OracleCommand object and instantiate it 
                var cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                var da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "booking");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch (OracleException e)
            {
                MessageBox.Show(
                    "Code: " + e.ErrorCode + "\n Message: " + e.Message +
                    "\n\n An exception occurred.\n Please contact your system administrator.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataSet getCurrentBookingInfo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                var conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                var strSQL =
                    "SELECT BookingID, CustomerID  FROM Bookings WHERE bookingstatus = 'O' ORDER BY BookingID";

                //Create an OracleCommand object and instantiate it 
                var cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                var da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "booking");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch (OracleException e)
            {
                MessageBox.Show(
                    "Code: " + e.ErrorCode + "\n Message: " + e.Message +
                    "\n\n An exception occurred.\n Please contact your system administrator.", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        public void bookingStatus()
        {
            //connect to database
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            
            var strSQL = "UPDATE bookings SET Bookingstatus = '" + status.ToUpper() + "' WHERE bookingid =" +
                         bookNo;

            //Execute the command
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updateTotal()
        {
            //connect to database
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

           
            var strSQL = "UPDATE bookings SET Total = " + total + " WHERE bookingid =" +
                         bookNo;

            //Execute the command
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void getInvoiceBooking()
        {
            //Conenct to the DB
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL =
                "select * from bookings b, customers c where BookingID = ( select max(BookingID) from bookings ) AND b.customerid = c.customerid";

            var cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            var dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setBookNo(dr.GetInt32(0));
                setCustomerId(dr.GetInt32(1));
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