DROP TABLE bookings;
DROP TABLE customers;
DROP TABLE cars;
DROP TABLE rates;


--
-- Table structure for table rates
--

CREATE TABLE rates (
  CatID CHAR(4) NOT NULL,
   Description CHAR(200) NOT NULL,
   Cost NUMERIC(5) NOT NULL,
    CONSTRAINT pk_CatID PRIMARY KEY (CatID)
   );

--
-- Table structure for table cars
--

CREATE TABLE cars (
  Make CHAR(15) NOT NULL,
  Model CHAR(15) NOT NULL,
  CatID CHAR(4) NOT NULL,
  RegNo CHAR(15) NOT NULL,
  Transmission CHAR(12) NOT NULL,
  Fuel CHAR(10) NOT NULL,
  Mileage DECIMAL(7) DEFAULT '0' NOT NULL,
  Availability CHAR(3) NOT NULL,
  NumSeats NUMERIC(5) NOT NULL,
  NumDoors NUMERIC(7) NOT NULL,
  Extras CHAR(65) NOT NULL,
  EngSize numeric(5,2) NOT NULL,
  NumBags NUMERIC(5) NOT NULL,
  CONSTRAINT pk_RegNo PRIMARY KEY (RegNo),
  CONSTRAINT fk_CatID FOREIGN KEY (CatID) REFERENCES rates
);

--
-- Table structure for table customers
--

CREATE TABLE customers(
  CustomerID NUMERIC(3) NOT NULL,
  Email char(40) NOT NULL,
  LicenceNum CHAR(12) NOT NULL,
  Fname CHAR(20) NOT NULL,
  Sname CHAR(20) NOT NULL,
  Address CHAR(100) NOT NULL,
  Country CHAR(56) NOT NULL,
  Postcode CHAR(18) NOT NULL,
  PhoneNum CHAR(15) NOT NULL,
  DOB CHAR(10) NOT NULL,
  Status CHAR(2) DEFAULT 'A' NOT NULL,
  CONSTRAINT pk_CustomerID PRIMARY KEY (CustomerID)
);

--
-- Table structure for table bookings
--

CREATE TABLE bookings(
  BookingID NUMERIC(3) NOT NULL,
  CustomerID NUMERIC(3) NOT NULL,
  RegNo CHAR(15) NOT NULL,
  StartDate CHAR(10) NOT NULL,
  EndDate CHAR(10) NOT NULL,
  BookingStatus  char (3) NOT NULL,
  Total NUMERIC(4) NOT NULL,
  CONSTRAINT fk_RegNo FOREIGN KEY (RegNo) REFERENCES cars,
  CONSTRAINT fk_CustomerID FOREIGN KEY (CustomerID) REFERENCES customers
);

