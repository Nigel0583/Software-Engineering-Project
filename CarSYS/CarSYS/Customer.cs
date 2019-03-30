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
    class Customer
    {
        private int CustomerID;
        private string email;
        private string licence;
        private string fName;
        private string sName;
        private string address;
        private string country;
        private string postcode;
        private string phoneNum;
        private string DOB;
        private char status;

        public Customer()
        {
            CustomerID = 0;
            email = "";
            licence = "";
            fName = "";
            sName = "";
            address = "";
            country = "";
            postcode = "";
            phoneNum = "";
            DOB = "";
            status = ' ';
        }

        public Customer(int CustomerID, string email, string licence, string fname, string sname, string address,
            string country, string postcode, string phoneNum, string DOB, char status)
        {
            this.CustomerID = CustomerID;
            this.email = email;
            this.licence = licence;
            this.fName = fname;
            this.sName = sname;
            this.address = address;
            this.country = country;
            this.postcode = postcode;
            this.phoneNum = phoneNum;
            this.DOB = DOB;
            this.status = status;
        }

        public void setCustomerID(int CustomerID)
        {
            this.CustomerID = CustomerID;
        }

        public int getCustomerID()
        {
            return CustomerID;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getEmail()
        {
            return email;
        }

        public void setLicence(string licence)
        {
            this.licence = licence;
        }

        public string getLicence()
        {
            return licence;
        }

        public void setFname(string fname)
        {
            this.fName = fname;
        }

        public string getFname()
        {
            return fName;
        }

        public void setSname(string sname)
        {
            this.sName = sname;
        }

        public string getSname()
        {
            return sName;
        }

        public void setAddress(string address)
        {
            this.address = address;
        }

        public string getAddress()
        {
            return address;
        }

        public void setCountry(string country)
        {
            this.country = country;
        }

        public string getCountry()
        {
            return country;
        }

        public void setPostcode(string postcode)
        {
            this.postcode = postcode;
        }

        public string getPostcode()
        {
            return postcode;
        }

        public void setPhoneNum(string phoneNum)
        {
            this.phoneNum = phoneNum;
        }

        public string getPhoneNum()
        {
            return phoneNum;
        }

        public void setDOB(string dob)
        {
            this.DOB = dob;
        }

        public string getDOB()
        {
            return DOB;
        }

        public void setStatus(char status)
        {
            this.status = status;
        }

        public char getStatus()
        {
            return status;
        }

        public static int nextCustomerID()
        {
            try
            {
                // variable to hold value to be returned
                int intNextCustomerID = 1;

                //Conenct to the DB
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();


                String strSQL = "SELECT MAX(CustomerID) FROM customers";

                OracleCommand cmd = new OracleCommand(strSQL, conn);


                OracleDataReader dr = cmd.ExecuteReader();

                dr.Read();


                if (!dr.IsDBNull(0))
                    intNextCustomerID = dr.GetInt32(0) + 1;

                //close DB connection
                conn.Close();

                return intNextCustomerID;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return 0;
            }
        }

        public static Boolean checkEmailExists(String Email)
        {
            try
            {
                Boolean exists = false;

                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT * FROM customers WHERE Email ='" + Email + "'";

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
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return false;
            }
        }

        public void getCustomers(int cust)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            String strSQL = "SELECT * FROM customers WHERE CustomerID =" + cust ;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setCustomerID(dr.GetInt32(0));
                setEmail(dr.GetString(1));
                setLicence(dr.GetString(2));
                setFname(dr.GetString(3));
                setSname(dr.GetString(4));
                setAddress(dr.GetString(5));
                setCountry(dr.GetString(6));
                setPhoneNum(dr.GetString(8));
                setPostcode(dr.GetString(7));
                setDOB(dr.GetString(9));

                //setStatus(dr.GetChar(10));
            }

            //close DB connection
            myConn.Close();
        }

        public void addCustomer()
        {
            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();


            String insert = "INSERT INTO customers VALUES(" + this.CustomerID.ToString() + ",'" + this.email.ToLower() +
                            "','" + this.licence.ToUpper() + "','" + this.fName.ToUpper() + "','" +
                            this.sName.ToUpper() + "','" + this.address.ToUpper() + "','" + this.country.ToUpper() +
                            "','" +
                            this.postcode.ToUpper() + "','" + this.phoneNum + "','" + this.DOB + "','" + this.status +
                            "')";

            OracleCommand cmd = new OracleCommand(insert, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getCustInfo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT CustomerID, email FROM Customers WHERE status  = 'A' ORDER BY CustomerID";

                //Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "cust");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        public static DataSet getCustInfoToUp(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT CustomerID, email FROM Customers WHERE status  = 'A' OR status  = 'R' ORDER BY CustomerID";

                //Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "cust");

                //close the DB Connection
                conn.Close();

                //Return the Dataset with the required data to the windows form which executed this method
                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return null;
            }
        }

        public void removeCustomer()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            String strSQL = "UPDATE customers SET status = '" + this.status + "' WHERE customerID ='" +
                            this.CustomerID + "'";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void updateCustomer()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT stock record
            String strSQL = "UPDATE customers SET email = '" + this.email.ToLower() + "', LicenceNum = '" +
                            this.licence.ToUpper() + "', Fname = '" + this.fName.ToUpper() + "', Sname = '" +
                            this.sName.ToUpper() + "', Address = '" + this.address.ToUpper() +
                            "', Country='" + this.country.ToUpper() + "', Postcode ='" + this.postcode.ToUpper() +
                            "', DOB = '" + this.DOB + "',Status='" + this.status + "' WHERE CustomerID = " +
                            this.CustomerID;

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public void getCustomerInvoice()
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            String strSQL =
                "select * from customers c,  bookings b  where BookingID = ( select max(BookingID) from bookings ) AND b.customerid = c.customerid";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setEmail(dr.GetString(1));
                setLicence(dr.GetString(2));
                setFname(dr.GetString(3));
                setSname(dr.GetString(4));
                setAddress(dr.GetString(5));
                setCountry(dr.GetString(6));
                setPostcode(dr.GetString(7));
            }

            //close DB connection
            myConn.Close();
        }
    }
}