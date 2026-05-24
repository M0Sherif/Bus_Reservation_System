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
    public partial class Passengers : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=BusReservationDB;Integrated Security=True";

        public Passengers()
        {
            InitializeComponent();
        }

        private void Passengers_Load(object sender, EventArgs e)
        {
            LoadPassengerData();
        }

        // ==========================================
        // ADD BUTTON LOGIC
        // ==========================================
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
               //Grab the data from your text boxes and date picker
                string firstName = txt_Firstname.Text;
                string lastName = txt_Lastname.Text;
                string phone = txt_Phone.Text;
                string email = txt_Email.Text;
                DateTime dob = dtp_Dateofbirth.Value;

                //The SQL Insert Command 
                string query = "INSERT INTO PASSENGER (First_Name, Last_Name, Date_of_Birth, Phone, Email) VALUES (@FName, @LName, @DOB, @Phone, @Email)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);

                    //Bind the parameters
                    cmd.Parameters.AddWithValue("@FName", firstName);
                    cmd.Parameters.AddWithValue("@LName", lastName);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Email", email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Passenger added successfully!");

                //Refresh the grid
                LoadPassengerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding passenger: " + ex.Message);
            }
        }

        private void LoadPassengerData()
        {
            string query = "SELECT Passenger_ID, First_Name, Last_Name, Date_of_Birth, Phone, Email FROM PASSENGER";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable passengerTable = new DataTable();
                    adapter.Fill(passengerTable);

                    dgv_Passengers.DataSource = passengerTable;
                    dgv_Passengers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();

            dash.StartPosition = FormStartPosition.Manual;
            dash.Location = this.Location;
            dash.Size = this.Size;
            dash.WindowState = this.WindowState;

            dash.Show();
            this.Hide();
            this.Hide();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (dgv_Passengers.CurrentRow == null)
            {
                MessageBox.Show("Please select a passenger from the table first.");
                return;
            }

            int passengerID = Convert.ToInt32(dgv_Passengers.CurrentRow.Cells["Passenger_ID"].Value);

            string query = @"UPDATE PASSENGER 
                     SET First_Name = @FName, Last_Name = @LName, 
                         Date_of_Birth = @DOB, Phone = @Phone, Email = @Email 
                     WHERE Passenger_ID = @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@FName", txt_Firstname.Text);
                    cmd.Parameters.AddWithValue("@LName", txt_Lastname.Text);
                    cmd.Parameters.AddWithValue("@DOB", dtp_Dateofbirth.Value);
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@Email", txt_Email.Text);
                    cmd.Parameters.AddWithValue("@ID", passengerID);

                    conn.Open();
                    int rows = cmd.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Passenger updated successfully!");
                        LoadPassengerData();
                    }
                    else
                    {
                        MessageBox.Show("Passenger not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating passenger: " + ex.Message);
            }
        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (dgv_Passengers.CurrentRow == null)
            {
                MessageBox.Show("Please select a passenger from the table first.");
                return;
            }

            int passengerID = Convert.ToInt32(dgv_Passengers.CurrentRow.Cells["Passenger_ID"].Value);

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this passenger?\nThis will also delete any reservations tied to them.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                string query = @"
            DELETE FROM RESERVE    WHERE Passenger_ID = @ID;
            DELETE FROM PASSENGER  WHERE Passenger_ID = @ID;";

                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@ID", passengerID);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Passenger deleted successfully!");
                        LoadPassengerData();
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                        MessageBox.Show("Cannot delete — this passenger has linked records. Remove them first.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting passenger: " + ex.Message);
                }
            }
        }
        private void dgv_Passengers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Passengers.Rows[e.RowIndex];

                txt_Firstname.Text = row.Cells["First_Name"].Value.ToString();
                txt_Lastname.Text = row.Cells["Last_Name"].Value.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value.ToString();
                txt_Email.Text = row.Cells["Email"].Value.ToString();

                if (DateTime.TryParse(row.Cells["Date_of_Birth"].Value.ToString(), out DateTime dob))
                    dtp_Dateofbirth.Value = dob;
            }
        }

        private void Passengers_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void dgv_Passengers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgv_Passengers_AutoSizeColumnModeChanged(object sender, DataGridViewAutoSizeColumnModeEventArgs e)
        {
        }

        private void pnl_Fields_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}