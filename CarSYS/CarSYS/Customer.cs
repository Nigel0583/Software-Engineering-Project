using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    internal class Customer
    {
        private string address;
        private string country;
        private int CustomerID;
        private string DOB;
        private string email;
        private string fName;
        private string licence;
        private string phoneNum;
        private string postcode;
        private string sName;
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
            fName = fname;
            sName = sname;
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
            fName = fname;
        }

        public string getFname()
        {
            return fName;
        }

        public void setSname(string sname)
        {
            sName = sname;
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
            DOB = dob;
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
                var intNextCustomerID = 1;

                //Conenct to the DB
                var conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();


                var strSQL = "SELECT MAX(CustomerID) FROM customers";

                var cmd = new OracleCommand(strSQL, conn);


                var dr = cmd.ExecuteReader();

                dr.Read();


                if (!dr.IsDBNull(0))
                    intNextCustomerID = dr.GetInt32(0) + 1;

                //close DB connection
                conn.Close();

                return intNextCustomerID;
            }
            catch (OracleException e)
            {
                
                MessageBox.Show("Code: "+ e.ErrorCode+ "\n Message: "+ e.Message+ "\n\n An exception occurred.\n Please contact your system administrator.", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return 0;
            }
        }

        public static bool checkEmailExists(string Email)
        {
            try
            {
                var exists = false;

                var conn = new OracleConnection(CarSysConnect.oradb);
                conn.Open();

                var strSQL = "SELECT * FROM customers WHERE Email ='" + Email + "'";

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

        public void getCustomers(int cust)
        {
        
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL = "SELECT * FROM customers WHERE CustomerID =" + cust;

            var cmd = new OracleCommand(strSQL, myConn);

         
            var dr = cmd.ExecuteReader();


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

          
            myConn.Close();
        }

        public void addCustomer()
        {
            var conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();


            var insert = "INSERT INTO customers VALUES(" + CustomerID + ",'" + email.ToLower() +
                         "','" + licence.ToUpper() + "','" + fName.ToUpper() + "','" +
                         sName.ToUpper() + "','" + address.ToUpper() + "','" + country.ToUpper() +
                         "','" +
                         postcode.ToUpper() + "','" + phoneNum + "','" + DOB + "','" + status +
                         "')";

            var cmd = new OracleCommand(insert, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public static DataSet getCustInfo(DataSet DS)
        {
            try
            {
            
                var conn = new OracleConnection(CarSysConnect.oradb);

                var strSQL = "SELECT CustomerID, email FROM Customers WHERE status  = 'A' ORDER BY CustomerID";

                var cmd = new OracleCommand(strSQL, conn);

                var da = new OracleDataAdapter(cmd);

                da.Fill(DS, "cust");

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

        public static DataSet getCustInfoToUp(DataSet DS)
        {
            try
            {
            
                var conn = new OracleConnection(CarSysConnect.oradb);

                var strSQL =
                    "SELECT CustomerID, email FROM Customers WHERE status  = 'A' OR status  = 'R' ORDER BY CustomerID";

                var cmd = new OracleCommand(strSQL, conn);

                var da = new OracleDataAdapter(cmd);

                da.Fill(DS, "cust");

               
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

        public void removeCustomer()
        {
          
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

           
            var strSQL = "UPDATE customers SET status = '" + status + "' WHERE customerID ='" +
                         CustomerID + "'";

         
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

           
            myConn.Close();
        }

        public void updateCustomer()
        {
            
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

           
            var strSQL = "UPDATE customers SET email = '" + email.ToLower() + "', LicenceNum = '" +
                         licence.ToUpper() + "', Fname = '" + fName.ToUpper() + "', Sname = '" +
                         sName.ToUpper() + "', Address = '" + address.ToUpper() +
                         "', Country='" + country.ToUpper() + "', Postcode ='" + postcode.ToUpper() +
                         "', DOB = '" + DOB + "',Status='" + status + "' WHERE CustomerID = " +
                         CustomerID;

          
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

           
            myConn.Close();
        }

        public void getCustomerInvoice()
        {
            
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL =
                "select * from customers c,  bookings b  where BookingID = ( select max(BookingID) from bookings ) AND b.customerid = c.customerid";

            var cmd = new OracleCommand(strSQL, myConn);

           
            var dr = cmd.ExecuteReader();


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

           
            myConn.Close();
        }
    }
}