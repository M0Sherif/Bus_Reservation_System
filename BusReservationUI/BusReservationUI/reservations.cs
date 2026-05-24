using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusReservationUI
{
    public partial class reservations : Form
    {
        public reservations()
        {
            InitializeComponent();
            ShowReservations();
        }

        string connectionString = @"Data Source=.;Initial Catalog=BusReservationDB;Integrated Security=True";

        private void Btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                int Seat_Number = int.Parse(textseatnum.Text);
                int Passenger_ID = int.Parse(textpassengerID.Text);
                int Trip_Id = int.Parse(texttripID.Text);

                DateTime Reservation_date = DateTime.Now;

                String query = "INSERT INTO RESERVE(Passenger_ID, Trip_Id, Seat_Number, Reservation_date) VALUES (@PID, @TID, @Seat, @Date)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@PID", Passenger_ID);
                    cmd.Parameters.AddWithValue("@TID", Trip_Id);
                    cmd.Parameters.AddWithValue("@Seat", Seat_Number);
                    cmd.Parameters.AddWithValue("@Date", Reservation_date);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Reservation saved successfully for: " + Reservation_date.ToString("g"));
                ShowReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message);
            }
        }

    
        // UPDATE RESERVATION 
        private void Btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                int Seat_Number = int.Parse(textseatnum.Text);
                int Passenger_ID = int.Parse(textpassengerID.Text);
                int Trip_Id = int.Parse(texttripID.Text);

                string query = "UPDATE RESERVE SET Seat_Number = @Seat WHERE Passenger_ID = @PID AND Trip_Id = @TID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@Seat", Seat_Number);
                    cmd.Parameters.AddWithValue("@PID", Passenger_ID);
                    cmd.Parameters.AddWithValue("@TID", Trip_Id);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        MessageBox.Show("Reservation updated successfully!");
                    else
                        MessageBox.Show("No reservation found for this Passenger and Trip.");
                }
                ShowReservations();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating reservation: " + ex.Message);
            }
        }

        // DELETE / CANCEL RESERVATION
        private void Btn_cancel_Click(object sender, EventArgs e)
        {
            try
            {
                int Passenger_ID = int.Parse(textpassengerID.Text);
                int Trip_Id = int.Parse(texttripID.Text);

                //confirmation pop-up so they don't accidentally delete
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to cancel this reservation?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dialogResult == DialogResult.Yes)
                {
                    string query = "DELETE FROM RESERVE WHERE Passenger_ID = @PID AND Trip_Id = @TID";

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@PID", Passenger_ID);
                        cmd.Parameters.AddWithValue("@TID", Trip_Id);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Reservation canceled successfully!");
                    ShowReservations();

                    // Clear the textboxes after deletion
                    textpassengerID.Clear();
                    texttripID.Clear();
                    textseatnum.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error canceling reservation: " + ex.Message);
            }
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();

            dash.StartPosition = FormStartPosition.Manual;
            dash.Location = this.Location;
            dash.Size = this.Size;
            dash.WindowState = this.WindowState;

            dash.Show();
            this.Hide();
        }

        private void textseatnum_TextChanged(object sender, EventArgs e)
        {
        }

        private void textpassengerID_TextChanged(object sender, EventArgs e)
        {
        }

        private void texttripID_TextChanged(object sender, EventArgs e)
        {
        }

        // GRID CLICK Fills the textboxes automatically
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Make sure the user didn't click the column headers
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

                textpassengerID.Text = row.Cells["Passenger_ID"].Value.ToString();
                texttripID.Text = row.Cells["Trip_Id"].Value.ToString();
                textseatnum.Text = row.Cells["Seat_Number"].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ShowReservations()
        {
            try
            {
                string query = "SELECT * FROM RESERVE";
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dataGridView1.DataSource = dt;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // Added this to fix the gray space!
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid: " + ex.Message);
            }
        }
    }
}