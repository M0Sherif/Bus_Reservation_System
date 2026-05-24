using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusReservationUI
{
    public partial class Routes_and_Trips : Form
    {
        string connectionString = "Server=localhost;Database=BusReservationDB;Integrated Security=True;";

        // This remembers which trip you clicked on!
        private int selectedTripId = 0;

        public Routes_and_Trips()
        {
            InitializeComponent();
        }

        private void LoadGridData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    SELECT 
                        t.Trip_ID, 
                        t.Route_Code, 
                        r.Destination, 
                        r.Distance, 
                        t.Departure_DateTime, 
                        t.Arrival_DateTime, 
                        t.Price 
                    FROM TRIP t
                    JOIN ROUTE r ON t.Route_Code = r.Route_Code;";

                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgv_RoutesTrips.DataSource = dt;
                dgv_RoutesTrips.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadRoutesDropdown()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "SELECT Route_Code FROM ROUTE";
                SqlCommand cmd = new SqlCommand(query, conn);
                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    cmb_RouteCode.Items.Clear();
                    while (reader.Read())
                    {
                        cmb_RouteCode.Items.Add(reader["Route_Code"].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading routes: " + ex.Message);
                }
            }
        }

        private void Routes_and_Trips_Load(object sender, EventArgs e)
        {
            LoadGridData();
            LoadRoutesDropdown();
        }

        // --- ROUTE MANAGEMENT BUTTONS ---

        private void btn_AddRoute_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO ROUTE (Route_Code, Destination, Distance) VALUES (@Code, @Dest, @Dist)";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@Code", txt_RouteCode.Text);
                cmd.Parameters.AddWithValue("@Dest", txt_Destination.Text);
                cmd.Parameters.AddWithValue("@Dist", Convert.ToDecimal(txt_Distance.Text));

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Route Added Successfully!");
                    LoadGridData();
                    LoadRoutesDropdown();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_UpdateRoute_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = "UPDATE ROUTE SET Destination = @Dest, Distance = @Dist WHERE Route_Code = @Code";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Code", txt_RouteCode.Text);
                    cmd.Parameters.AddWithValue("@Dest", txt_Destination.Text);
                    cmd.Parameters.AddWithValue("@Dist", Convert.ToDecimal(txt_Distance.Text));

                    try
                    {
                        conn.Open();
                        int rows = cmd.ExecuteNonQuery();
                        if (rows > 0)
                        {
                            MessageBox.Show("Route Updated Successfully!");
                            LoadGridData();
                        }
                        else
                        {
                            MessageBox.Show("Route Code not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating route: " + ex.Message);
                    }
                }
            }
        }

        private void btn_DeleteRoute_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this route?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM ROUTE WHERE Route_Code = @Code";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Code", txt_RouteCode.Text);

                        try
                        {
                            conn.Open();
                            int rows = cmd.ExecuteNonQuery();
                            if (rows > 0)
                            {
                                MessageBox.Show("Route Deleted Successfully!");
                                LoadGridData();
                                LoadRoutesDropdown();
                            }
                            else
                            {
                                MessageBox.Show("Route Code not found.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            if (ex.Number == 547)
                                MessageBox.Show("Cannot delete this route because there are trips assigned to it. Delete the trips first!");
                            else
                                MessageBox.Show("Database error: " + ex.Message);
                        }
                    }
                }
            }
        }

        // --- TRIP MANAGEMENT BUTTONS ---

        private void btn_AddTrip_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    INSERT INTO TRIP (Price, Arrival_DateTime, Departure_DateTime, Route_Code) 
                    VALUES (@Price, @Arrival, @Departure, @RouteCode)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txt_Price.Text));
                    cmd.Parameters.AddWithValue("@Arrival", dtp_Arrival.Value);
                    cmd.Parameters.AddWithValue("@Departure", dtp_Departure.Value);
                    cmd.Parameters.AddWithValue("@RouteCode", cmb_RouteCode.SelectedItem.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trip Added Successfully!");
                        LoadGridData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding trip: " + ex.Message);
                    }
                }
            }
        }

        private void btn_UpdateTrip_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0)
            {
                MessageBox.Show("Please select a trip from the table to update.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string query = @"
                    UPDATE TRIP 
                    SET Price = @Price, Arrival_DateTime = @Arrival, Departure_DateTime = @Departure, Route_Code = @RouteCode 
                    WHERE Trip_ID = @TripID";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TripID", selectedTripId);
                    cmd.Parameters.AddWithValue("@Price", Convert.ToDecimal(txt_Price.Text));
                    cmd.Parameters.AddWithValue("@Arrival", dtp_Arrival.Value);
                    cmd.Parameters.AddWithValue("@Departure", dtp_Departure.Value);
                    cmd.Parameters.AddWithValue("@RouteCode", cmb_RouteCode.SelectedItem.ToString());

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Trip Updated Successfully!");
                        LoadGridData();
                        selectedTripId = 0; // Reset after updating
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating trip: " + ex.Message);
                    }
                }
            }
        }

        private void btn_DeleteTrip_Click(object sender, EventArgs e)
        {
            if (selectedTripId == 0)
            {
                MessageBox.Show("Please select a trip from the table to delete.");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this trip? This will also delete any bus assignments and reservations tied to it.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (dialogResult == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string query = @"
                DELETE FROM RESERVE WHERE Trip_ID = @TripID;
                DELETE FROM ASSIGNED_TO WHERE Trip_ID = @TripID;
                DELETE FROM TRIP WHERE Trip_ID = @TripID;
            ";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@TripID", selectedTripId);

                        try
                        {
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Trip and all associated records deleted successfully!");

                            LoadGridData();
                            txt_Price.Clear(); // Clear the price box instead
                            selectedTripId = 0; // Reset the selected ID
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error deleting trip: " + ex.Message);
                        }
                    }
                }
            }
        }

        // --- GRID CLICK EVENT ---
        private void dgv_RoutesTrips_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_RoutesTrips.Rows[e.RowIndex];

                // Save the Trip_ID
                selectedTripId = Convert.ToInt32(row.Cells["Trip_ID"].Value);

                txt_RouteCode.Text = row.Cells["Route_Code"].Value.ToString();
                txt_Destination.Text = row.Cells["Destination"].Value.ToString();
                txt_Distance.Text = row.Cells["Distance"].Value.ToString();
                txt_Price.Text = row.Cells["Price"].Value.ToString();
                cmb_RouteCode.SelectedItem = row.Cells["Route_Code"].Value.ToString();

                if (DateTime.TryParse(row.Cells["Arrival_DateTime"].Value.ToString(), out DateTime arrival))
                    dtp_Arrival.Value = arrival;

                if (DateTime.TryParse(row.Cells["Departure_DateTime"].Value.ToString(), out DateTime departure))
                    dtp_Departure.Value = departure;
            }
        }

        // --- BACK BUTTON ---
        private void btn_Back_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();

            dash.StartPosition = FormStartPosition.Manual;
            dash.Location = this.Location;
            dash.Size = this.Size;
            dash.WindowState = this.WindowState;

            dash.Show();
            this.Hide();
        }
    }
}