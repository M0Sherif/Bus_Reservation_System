# Bus Reservation System

## Project Description
This project is a Bus Reservation System application with a graphical user interface developed using **C# (Windows Forms)** and a backend database implemented in **Microsoft SQL Server**.

The system allows users to manage and streamline bus reservations by keeping track of buses, drivers, routes, trips, passengers, and their bookings. 

---

## Features
1. **Dashboard:** Overview of system statistics and quick actions.
2. **Manage Passengers:** Add, view, and manage passenger details.
3. **Manage Drivers:** Register new drivers and view their license details.
4. **Fleet and Drivers:** Manage the bus fleet, including bus capacity, color, and assign them to specific drivers.
5. **Routes and Trips:** Define routes (with distances and destinations) and schedule trips with departure/arrival times and prices.
6. **Reservations:** Book seats for passengers on specific trips.

---

## Database Design

The database (`BusReservationDB`) consists of several relational tables:
- **Independent Tables:** `PASSENGER`, `ROUTE`, `DRIVER`
- **Dependent Tables:** `BUS` (depends on `DRIVER`), `TRIP` (depends on `ROUTE`)
- **Junctions/Multi-valued:** `COLOR` (Bus colors), `ASSIGNED_TO` (Buses assigned to trips), `RESERVE` (Passenger bookings for trips)

---

## Project Structure

- `BusReservationDB.sql` → SQL script to create the database schema, tables, and seed initial data.
- `BusReservationUI/` → Contains the C# Windows Forms application source code.
  - `Dashboard.cs` → Main dashboard interface
  - `Passengers.cs` → Interface for managing passengers
  - `Manage drivers.cs` → Interface for driver management
  - `Fleet and Drivers.cs` → Interface for bus fleet management
  - `Routes and Trips.cs` → Interface for defining routes and scheduling trips
  - `reservations.cs` → Interface for handling passenger bookings

---

## Technologies Used
- C# (.NET Windows Forms)
- Microsoft SQL Server (T-SQL)

---

## How to Run

### 1. Database Setup
1. Open SQL Server Management Studio (SSMS).
2. Open the `BusReservationDB.sql` file.
3. Execute the script to create the database, tables, and insert the seed data.

### 2. Application Setup
1. Open the solution file `BusReservationUI.sln` in **Visual Studio**.
2. Ensure the connection string in the application (like `App.config` or inside the forms) points to your local SQL Server instance.
3. Build and Run the project.
