--Create the Database
CREATE DATABASE BusReservationDB;
GO

USE BusReservationDB;
GO

-- Independent Tables
CREATE TABLE PASSENGER (
    Passenger_ID INT PRIMARY KEY IDENTITY(1,1),
    First_Name VARCHAR(50) NOT NULL,
    Last_Name VARCHAR(50) NOT NULL,
    Date_of_Birth DATE,
    Phone VARCHAR(20),
    Email VARCHAR(100)
);

CREATE TABLE ROUTE (
    Route_Code VARCHAR(20) PRIMARY KEY,
    Destination VARCHAR(100) NOT NULL,
    Distance DECIMAL(10,2)
);

CREATE TABLE DRIVER (
    Driver_ID INT PRIMARY KEY IDENTITY(1,1),
    Name VARCHAR(100) NOT NULL,
    Phone VARCHAR(20),
    License_Number VARCHAR(50) UNIQUE NOT NULL
);

--Dependent Tables
CREATE TABLE BUS (
    Plate_Number VARCHAR(20) PRIMARY KEY,
    Capacity INT NOT NULL,
    Driver_ID INT FOREIGN KEY REFERENCES DRIVER(Driver_ID)
);

CREATE TABLE TRIP (
    Trip_ID INT PRIMARY KEY IDENTITY(1,1),
    Price DECIMAL(10,2) NOT NULL,
    Arrival_DateTime DATETIME NOT NULL,
    Departure_DateTime DATETIME NOT NULL,
    Route_Code VARCHAR(20) FOREIGN KEY REFERENCES ROUTE(Route_Code)
);

--(Junctions & Multi-valued)
CREATE TABLE COLOR (
    Bus_color VARCHAR(30),
    Plate_Number VARCHAR(20) FOREIGN KEY REFERENCES BUS(Plate_Number),
    PRIMARY KEY (Bus_color, Plate_Number) -- Composite Primary Key
);

CREATE TABLE ASSIGNED_TO (
    Trip_ID INT FOREIGN KEY REFERENCES TRIP(Trip_ID),
    Plate_Number VARCHAR(20) FOREIGN KEY REFERENCES BUS(Plate_Number),
    PRIMARY KEY (Trip_ID, Plate_Number) -- Composite Primary Key
);

CREATE TABLE RESERVE (
    Passenger_ID INT FOREIGN KEY REFERENCES PASSENGER(Passenger_ID),
    Trip_ID INT FOREIGN KEY REFERENCES TRIP(Trip_ID),
    Seat_Number INT NOT NULL,
    Reservation_Date DATE NOT NULL,
    PRIMARY KEY (Passenger_ID, Trip_ID) -- Composite Primary Key
);
GO


-- DATA SEEDING

INSERT INTO PASSENGER (First_Name, Last_Name, Date_of_Birth, Phone, Email) 
VALUES 
('Ahmed', 'Tarek', '2000-05-14', '01012345678', 'AT@gmail.com'),
('Ali', 'Hesham', '1998-11-22', '01198765432', 'AH@hotmail.com'),
('Mahmoud', 'Nasser', '2002-01-30', '01234567890', 'MN@yahoo.com'),
('Yousef', 'Hesham', '2000-01-30', '01274555800', 'YH@gmail.com');

INSERT INTO ROUTE (Route_Code, Destination, Distance) 
VALUES 
('CAI-ALX', 'Alexandria', 220.50),
('CAI-HRG', 'Hurghada', 460.00),
('CAI-SSH', 'Sharm El Sheikh', 500.00);

INSERT INTO DRIVER (Name, Phone, License_Number) 
VALUES 
('Ehab Galal', '01511223344', 'LIC-998877'),
('Hossam Hassan', '01055667788', 'LIC-554433'),
('Hossam El Badry', '01299887766', 'LIC-112233');

INSERT INTO BUS (Plate_Number, Capacity, Driver_ID) 
VALUES 
('ABC-123', 50, 1),
('XYZ-987', 30, 2),
('LMN-456', 50, 3);

INSERT INTO TRIP (Price, Arrival_DateTime, Departure_DateTime, Route_Code) 
VALUES 
(150.00, '2026-05-10 11:30:00', '2026-05-10 09:00:00', 'CAI-ALX'),
(350.00, '2026-05-11 15:30:00', '2026-05-11 08:00:00', 'CAI-HRG'),
(400.00, '2026-05-12 18:00:00', '2026-05-12 10:00:00', 'CAI-SSH');

INSERT INTO COLOR (Bus_color, Plate_Number) 
VALUES 
('White', 'ABC-123'),
('Blue', 'XYZ-987'),
('Red', 'LMN-456');

INSERT INTO ASSIGNED_TO (Trip_ID, Plate_Number) 
VALUES 
(1, 'ABC-123'),
(2, 'XYZ-987'),
(3, 'LMN-456');

INSERT INTO RESERVE (Passenger_ID, Trip_ID, Seat_Number, Reservation_Date) 
VALUES 
(1, 1, 14, '2026-05-01'), -- Ahmed books Trip 1, Seat 14
(2, 2, 5, '2026-05-02'),  -- Ali books Trip 2, Seat 5
(3, 3, 22, '2026-05-03'); -- Mahmoud books Trip 3, Seat 22
GO