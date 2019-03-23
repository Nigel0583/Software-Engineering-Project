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
    class Cars
    {
        private string make;
        private string model;
        private string CatID;
        private string regNo;
        private string transmission;
        private string fuel;
        private decimal mileage;
        private string availability;
        private int numSeats;
        private string extras;
        private int doors;
        private decimal engSize;
        private int numBags;
        

        public Cars()
        {
            make = "";
            model = "";
            CatID = "";
            regNo = "";
            transmission = "";
            fuel = "";
            mileage = 0;
            availability = "";
            numSeats = 0;
            doors = 0;
        }

        public Cars(string make, string model, string CatID, string regNo,  string transmission, string fuel, decimal mileage, string availability, int numSeats,int doors, string extras, decimal engSize, int numBags)
        {
            this.make = make;
            this.model = model;
            this.CatID = CatID;
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

        public void setMake(String make)
        {
            this.make = make;
        }

        public string getMake()
        {
            return make;
        }
        public void setModel(String model)
        {
            this.model = model;
        }

        public string getModel()
        {
            return model;
        }
        public void setCatID(String CatID)
        {
            this.CatID = CatID;
        }
        public string getCatID()
        {
            return CatID;
        }
        public void setRegNo(String regNo)
        {
            this.regNo = regNo;
        }
        public string getReg()
        {
            return regNo;
        }

        public void setFuel(String fuel)
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
        public void setTransmission(String transmission)
        {
            this.transmission = transmission;
        }
        public string getTransmission()
        {
            return transmission;
        }

        public void setAvailability(String availability)
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
        public void setExtras(String extras)
        {
            this.extras = extras;
        }
        public string getExtras()
        {
            return extras;
        }


        public void getCars(String reg)
        {
            //Conenct to the DB
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            
            String strSQL = "SELECT * FROM Cars WHERE RegNo ='" + reg +"'";
                
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            
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
        public static Boolean checkRegExists(String RegNo)
        {
            Boolean exists = false;

            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();

            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT * FROM Cars WHERE RegNo ='" + RegNo + "'";

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


        public static DataSet checkCarAvailability(DataSet DS, String start, String end)
        {
            try
            {
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);


                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT ra.Cost, ra.Description,Make,Model,cars.CATID,NumSeats,Transmission,Fuel, RegNo,Extras FROM rates ra, cars WHERE ra.CatID = cars.CatID AND Availability = " +
                    "'A' AND RegNo NOT IN(SELECT RegNo FROM bookings WHERE bookings.BookingStatus= 'R' AND StartDate >= '" +
                    start + "' AND EndDate <= '" + end + "' OR '" + start + "' BETWEEN StartDate AND EndDate)";

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //cmd.CommandType = CommandType.Text;
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                da.Fill(DS, "chkCar");

                conn.Close();

                return DS;
            }
            catch
            {
                MessageBox.Show("Sorry, Unable to connect to database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
            

        }

        public static DataSet getRegNo(DataSet DS)
        {
            try
            {
                //create an OracleConnection object using the connection string defined in static class CarSysConnect
                OracleConnection conn = new OracleConnection(CarSysConnect.oradb);

                //Define the SQL Query to retrieve the data
                String strSQL = "SELECT RegNo FROM Cars ORDER BY RegNo";

                //Create an OracleCommand object and instantiate it
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Create an oracleAdapter to hold the result of the executed OracleCommand
                OracleDataAdapter da = new OracleDataAdapter(cmd);

                //Fill the DataSet DS with the query result
                da.Fill(DS, "reg");

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


        public void addCars()
        {
            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);
            conn.Open();
          
            String insertCars = "INSERT INTO cars VALUES('" +this.make.ToUpper() + "','"+this.model.ToUpper() + "','"+this.CatID.ToUpper() + "','"+
                this.regNo.ToUpper() + "','"+this.transmission.ToUpper()+"','"+this.fuel.ToUpper()+"',"+this.mileage+",'"+this.availability+"',"+this.numSeats+","+this.doors+",'"+
                this.extras+"',"+this.engSize+","+this.numBags+")";

            OracleCommand cmd = new OracleCommand(insertCars, conn);
            cmd.ExecuteNonQuery();

            conn.Close();

        }

        public void removeCar()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            String strSQL = "UPDATE cars SET Availability = '" + this.availability.ToUpper() + "' WHERE RegNo ='"+ this.regNo+"'";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }

        public static DataSet availableForBooking(DataSet DS, String start, String end, String catid)
        {

            OracleConnection conn = new OracleConnection(CarSysConnect.oradb);


            //Define the SQL Query to retrieve the data
            String strSQL = "SELECT ra.Cost,ra.CatID,Make,Model,RegNo FROM rates ra, cars WHERE ra.catid ='" + catid + 
                "' AND ra.CatID = cars.CatID AND Availability ='A' AND RegNo NOT IN(SELECT RegNo FROM bookings WHERE bookings.BookingStatus= 'R' AND StartDate >= '" + 
                start + "' AND EndDate <= '" + end + "' OR '" + start + "' BETWEEN StartDate AND EndDate)";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //cmd.CommandType = CommandType.Text;
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(DS, "bookCar");

            conn.Close();

            return DS;

        }

        public void collectCar()
        {
            //connect to database
            OracleConnection myConn = new OracleConnection(CarSysConnect.oradb);
            myConn.Open();

            //Define SQL query to INSERT car record
            String strSQL = "UPDATE cars SET Availability = '" + this.availability.ToUpper() + "' WHERE RegNo ='" + this.regNo + "'";

            //Execute the command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //close DB connection
            myConn.Close();
        }


    }
}