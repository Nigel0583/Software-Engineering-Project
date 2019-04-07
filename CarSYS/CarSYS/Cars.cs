using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CarSYS
{
    internal class Cars
    {
        private string availability;
        private string catId;
        private int doors;
        private decimal engSize;
        private string extras;
        private string fuel;
        private string make;
        private decimal mileage;
        private string model;
        private int numBags;
        private int numSeats;
        private string regNo;
        private string transmission;


        public Cars()
        {
            make = "";
            model = "";
            catId = "";
            regNo = "";
            transmission = "";
            fuel = "";
            mileage = 0;
            availability = "";
            numSeats = 0;
            doors = 0;
        }

        public Cars(string make, string model, string catId, string regNo, string transmission, string fuel,
            decimal mileage, string availability, int numSeats, int doors, string extras, decimal engSize, int numBags)
        {
            this.make = make;
            this.model = model;
            this.catId = catId;
            this.regNo = regNo;
            this.transmission = transmission;
            this.fuel = fuel;
            this.mileage = mileage;
            this.availability = availability;
            this.numSeats = numSeats;
            this.doors = doors;
            this.extras = extras;
            this.engSize = engSize;
            this.numBags = numBags;
        }

        public void setMake(string make)
        {
            this.make = make;
        }

        public string getMake()
        {
            return make;
        }

        public void setModel(string model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return model;
        }

        public void setCatID(string CatID)
        {
            catId = CatID;
        }

        public string getCatID()
        {
            return catId;
        }

        public void setRegNo(string regNo)
        {
            this.regNo = regNo;
        }

        public string getReg()
        {
            return regNo;
        }

        public void setFuel(string fuel)
        {
            this.fuel = fuel;
        }

        public string getFuel()
        {
            return fuel;
        }

        public void setMileage(decimal mileage)
        {
            this.mileage = mileage;
        }

        public decimal getMileage()
        {
            return mileage;
        }

        public void setTransmission(string transmission)
        {
            this.transmission = transmission;
        }

        public string getTransmission()
        {
            return transmission;
        }

        public void setAvailability(string availability)
        {
            this.availability = availability;
        }

        public string getAvailability()
        {
            return availability;
        }


        public void setDoors(int doors)
        {
            this.doors = doors;
        }

        public int getDoors()
        {
            return doors;
        }

        public void setEngSize(decimal engSize)
        {
            this.engSize = engSize;
        }

        public decimal getEngSize()
        {
            return engSize;
        }

        public void setNumSeat(int numSeats)
        {
            this.numSeats = numSeats;
        }

        public decimal getNumSeat()
        {
            return numSeats;
        }

        public void setNumBags(int numBags)
        {
            this.numBags = numBags;
        }

        public int getNumBags()
        {
            return numBags;
        }

        public void setExtras(string extras)
        {
            this.extras = extras;
        }

        public string getExtras()
        {
            return extras;
        }


        public void getCars(string reg)
        {
            //Conenct to the DB
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();


            var strSQL = "SELECT * FROM Cars WHERE RegNo ='" + reg + "'";

            var cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            var dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                setMake(dr.GetString(0));
                setModel(dr.GetString(1));
                setRegNo(dr.GetString(3));
                setAvailability(dr.GetString(7));
            }

            //close DB connection
            myConn.Close();
        }

        public static bool checkRegExists(string RegNo)
        {
            var exists = false;

            var conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();

            //Define the SQL Query to retrieve the data
            var strSQL = "SELECT * FROM Cars WHERE RegNo ='" + RegNo + "'";

            //Create an OracleCommand object and instantiate it
            var cmd = new OracleCommand(strSQL, conn);

            //Create an oracleAdapter to hold the result of the executed OracleCommand
            var dr = cmd.ExecuteReader();

            if (dr.Read()) exists = true;

            return exists;
        }


        public static DataSet checkCarAvailability(DataSet DS, string start, string end)
        {
            try
            {
                var conn = new OracleConnection(CarSysConnect.oradb);


                //Define the SQL Query to retrieve the data
                var strSQL =
                    "SELECT ra.Cost, ra.Description,Make,Model,cars.CATID,NumSeats,Transmission,Fuel, RegNo,Extras FROM rates ra, cars " +
                    "WHERE ra.CatID = cars.CatID AND Availability ='A' AND RegNo NOT IN(SELECT RegNo FROM bookings WHERE bookings.BookingStatus= 'R' AND StartDate >= '" +
                         start + "' AND EndDate <= '" + end + "' OR '" + start + "' BETWEEN StartDate AND EndDate)";

                var cmd = new OracleCommand(strSQL, conn);

                //cmd.CommandType = CommandType.Text;
                var da = new OracleDataAdapter(cmd);

                da.Fill(DS, "chkCar");

                conn.Close();

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

        public static DataSet getRegNo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                var conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                var strSQL = "SELECT RegNo FROM Cars ORDER BY RegNo";

                //Create an OracleCommand object and instantiate it
                var cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                var da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "reg");

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


        public void addCars()
        {
            var conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();

            var insertCars = "INSERT INTO cars VALUES('" + make.ToUpper() + "','" + model.ToUpper() +
                             "','" + catId.ToUpper() + "','" +
                             regNo.ToUpper() + "','" + transmission.ToUpper() + "','" +
                             fuel.ToUpper() + "'," + mileage + ",'" + availability + "'," +
                             numSeats + "," + doors + ",'" +
                             extras + "'," + engSize + "," + numBags + ")";

            var cmd = new OracleCommand(insertCars, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        }

        public void removeCar()
        {
            //connect to database
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            var strSQL = "UPDATE cars SET Availability = '" + availability.ToUpper() + "' WHERE RegNo ='" +
                         regNo + "'";

            //Execute the command
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static DataSet availableForBooking(DataSet DS, string start, string end, string catid)
        {
            var conn = new OracleConnection(CarSysConnect.oradb);


            //Define the SQL Query to retrieve the data
            var strSQL = "SELECT ra.Cost,ra.CatID,Make,Model,RegNo FROM rates ra, cars WHERE ra.catid ='" + catid +
                         "' AND ra.CatID = cars.CatID AND Availability ='A' AND RegNo NOT IN(SELECT RegNo FROM bookings WHERE bookings.BookingStatus= 'R' AND StartDate >= '" +
                         start + "' AND EndDate <= '" + end + "' OR '" + start + "' BETWEEN StartDate AND EndDate   )";

            var cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            var da = new OracleDataAdapter(cmd);

            da.Fill(DS, "bookCar");

            conn.Close();

            return DS;
        }

        public void collectCar()
        {
            //connect to database
            var myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            var strSQL = "UPDATE cars SET Availability = '" + availability.ToUpper() + "' WHERE RegNo ='" +
                         regNo + "'";

            //Execute the command
            var cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }
    }
}