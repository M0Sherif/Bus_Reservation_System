
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
    public partial class Manage_drivers : Form
    {
        string connectionString = @"Data Source=.;Initial Catalog=BusReservationDB;Integrated Security=True";

        // This remembers which driver you clicked on for Updates and Deletions!
        private int selectedDriverId = 0;

        public Manage_drivers()
        {
            InitializeComponent();
            LoadDriverData(); // Loads the grid immediately when the page opens
        }

        // ==========================================
        // DATABASE LOADING LOGIC
        // ==========================================
        private void LoadDriverData()
        {
            try
            {
                string query = "SELECT Driver_ID, Name, License_Number, Phone FROM DRIVER";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        dataGridView1.DataSource = dt;

                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading grid: " + ex.Message);
            }
        }

        // ADD DRIVER
        private void btn_Add_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "INSERT INTO DRIVER (Name, License_Number, Phone) VALUES (@Name, @License, @Phone)";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@License", txt_Licensenumber.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Driver added successfully!");
                LoadDriverData(); // Refresh grid
                ClearForm();      // Empty textboxes
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding driver: " + ex.Message);
            }
        }

        // UPDATE DRIVER
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == 0)
            {
                MessageBox.Show("Please select a driver from the grid first.");
                return;
            }

            try
            {
                string query = "UPDATE DRIVER SET Name = @Name, License_Number = @License, Phone = @Phone WHERE Driver_ID = @ID";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
                    cmd.Parameters.AddWithValue("@License", txt_Licensenumber.Text);
                    cmd.Parameters.AddWithValue("@Phone", txt_Phone.Text);
                    cmd.Parameters.AddWithValue("@ID", selectedDriverId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Driver updated successfully!");
                LoadDriverData();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating driver: " + ex.Message);
            }
        }

        // DELETE DRIVER
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (selectedDriverId == 0)
            {
                MessageBox.Show("Please select a driver from the grid first.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this driver?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        string query = "DELETE FROM DRIVER WHERE Driver_ID = @ID;";
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@ID", selectedDriverId);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Driver deleted successfully!");
                    LoadDriverData();
                    ClearForm();
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547) // Foreign Key Violation
                        MessageBox.Show("Cannot delete — this driver is currently assigned to a bus! Please reassign the bus or delete the bus first.");
                    else
                        MessageBox.Show("Database error: " + ex.Message);
                }
            }
        }

        // GRID CLICK EVENT
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                selectedDriverId = Convert.ToInt32(row.Cells["Driver_ID"].Value);

                txt_Name.Text = row.Cells["Name"].Value.ToString();
                txt_Licensenumber.Text = row.Cells["License_Number"].Value.ToString();
                txt_Phone.Text = row.Cells["Phone"].Value.ToString();
            }
        }

        // BACK BUTTON (Returns to Fleet & Drivers)
        private void btn_back_Click(object sender, EventArgs e)
        {
            Fleet_and_Drivers fleetScreen = new Fleet_and_Drivers();

            fleetScreen.StartPosition = FormStartPosition.Manual;
            fleetScreen.Location = this.Location;
            fleetScreen.Size = this.Size;
            fleetScreen.WindowState = this.WindowState;

            fleetScreen.Show();
            this.Hide();
        }

        //method to empty the textboxes
        private void ClearForm()
        {
            txt_Name.Clear();
            txt_Licensenumber.Clear();
            txt_Phone.Clear();
            selectedDriverId = 0;
        }

        // EMPTY AUTO-GENERATED EVENTS
        private void button2_Click(object sender, EventArgs e) { }
        private void txt_Phone_TextChanged(object sender, EventArgs e) { }
        private void txt_Name_TextChanged(object sender, EventArgs e) { }
        private void txt_Licensenumber_TextChanged(object sender, EventArgs e) { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Title_Click(object sender, EventArgs e)
        {

        }
    }
}
