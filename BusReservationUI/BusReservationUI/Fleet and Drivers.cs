using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BusReservationUI
{
    public partial class Fleet_and_Drivers : Form
    {
        private readonly string connectionString =
            @"Data Source=.;Initial Catalog=BusReservationDB;Integrated Security=True";

        // Resting colors for hover restore
        private readonly Color _clrAdd = Color.FromArgb(16, 185, 129);
        private readonly Color _clrUpdate = Color.FromArgb(67, 97, 238);
        private readonly Color _clrDelete = Color.FromArgb(239, 68, 68);
        private readonly Color _clrManage = Color.FromArgb(139, 92, 246);

        public Fleet_and_Drivers()
        {
            InitializeComponent();
            WireHoverEffects();
        }

        // ─── Hover effects ────────────────────────────────────────────────────

        private void WireHoverEffects()
        {
            Button[] btns = { btn_Addbus, btn_Updatebus, btn_Deletebus, btn_Managedrivers };
            foreach (var b in btns)
            {
                b.MouseEnter += btn_MouseEnter;
                b.MouseLeave += btn_MouseLeave;
            }
        }

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
                btn.BackColor = Lighten(btn.BackColor, 22);
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "btn_Addbus": btn.BackColor = _clrAdd; break;
                    case "btn_Updatebus": btn.BackColor = _clrUpdate; break;
                    case "btn_Deletebus": btn.BackColor = _clrDelete; break;
                    case "btn_Managedrivers": btn.BackColor = _clrManage; break;
                }
            }
        }

        private static Color Lighten(Color c, int amount) =>
            Color.FromArgb(
                Math.Min(c.R + amount, 255),
                Math.Min(c.G + amount, 255),
                Math.Min(c.B + amount, 255));

        // ─── Load ─────────────────────────────────────────────────────────────

        private void Fleet_and_Drivers_Load(object sender, EventArgs e)
        {

            btn_Managedrivers.Left = pnl_TopBar.ClientSize.Width - btn_Managedrivers.Width;

            LoadFleetData();
            LoadDriverComboBox();
        }

        private void LoadFleetData()
        {
            string query = @"
                SELECT 
                    B.Plate_Number  AS [Plate Number], 
                    B.Capacity, 
                    C.Bus_color     AS [Color], 
                    D.Name          AS [Driver Name], 
                    D.License_Number AS [License Number]
                FROM BUS B
                INNER JOIN DRIVER D ON B.Driver_ID = D.Driver_ID
                LEFT JOIN  COLOR  C ON B.Plate_Number = C.Plate_Number";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgv_Fleet.DataSource = table;
                dgv_Fleet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void LoadDriverComboBox()
        {
            string query = "SELECT Driver_ID, Name FROM DRIVER";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable table = new DataTable();
                adapter.Fill(table);
                cmb_Assigneddriver.DataSource = table;
                cmb_Assigneddriver.DisplayMember = "Name";
                cmb_Assigneddriver.ValueMember = "Driver_ID";
                cmb_Assigneddriver.SelectedIndex = -1;
            }
        }

        // ─── Navigation ───────────────────────────────────────────────────────

        private void NavigateTo(Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Location = this.Location;
            next.Size = this.Size;
            next.WindowState = this.WindowState;
            next.Show();
            this.Hide();
        }

        private void btn_back_Click(object sender, EventArgs e) =>
            NavigateTo(new Dashboard());

        private void btn_Managedrivers_Click(object sender, EventArgs e) =>
            NavigateTo(new Manage_drivers());

        private void Fleet_and_Drivers_FormClosed(object sender, FormClosedEventArgs e) =>
            Application.Exit();

        // ─── Add Bus ──────────────────────────────────────────────────────────

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Assigneddriver.SelectedIndex == -1)
                { MessageBox.Show("Please select a driver from the list."); return; }

                string plateNumber = txt_Platenumber.Text;
                int capacity = int.Parse(txt_Capacity.Text);
                string color = txt_Color.Text;
                int driverId = Convert.ToInt32(cmb_Assigneddriver.SelectedValue);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO BUS (Plate_Number, Capacity, Driver_ID) VALUES (@Plate, @Capacity, @DriverID)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Plate", plateNumber);
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@DriverID", driverId);
                        cmd.ExecuteNonQuery();
                    }
                    using (SqlCommand cmd = new SqlCommand(
                        "INSERT INTO COLOR (Plate_Number, Bus_color) VALUES (@Plate, @Color)", conn))
                    {
                        cmd.Parameters.AddWithValue("@Plate", plateNumber);
                        cmd.Parameters.AddWithValue("@Color", color);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bus added successfully!");
                LoadFleetData();
            }
            catch (Exception ex) { MessageBox.Show("Error adding bus: " + ex.Message); }
        }

        // ─── Update Bus ───────────────────────────────────────────────────────

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Platenumber.Text))
            { MessageBox.Show("Please select a bus from the table first."); return; }
            if (cmb_Assigneddriver.SelectedIndex == -1)
            { MessageBox.Show("Please select a driver."); return; }

            try
            {
                string plateNumber = txt_Platenumber.Text;
                int capacity = int.Parse(txt_Capacity.Text);
                string color = txt_Color.Text;
                int driverId = Convert.ToInt32(cmb_Assigneddriver.SelectedValue);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    int rows;
                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE BUS SET Capacity = @Capacity, Driver_ID = @DriverID WHERE Plate_Number = @Plate", conn))
                    {
                        cmd.Parameters.AddWithValue("@Capacity", capacity);
                        cmd.Parameters.AddWithValue("@DriverID", driverId);
                        cmd.Parameters.AddWithValue("@Plate", plateNumber);
                        rows = cmd.ExecuteNonQuery();
                    }

                    if (rows == 0)
                    {
                        MessageBox.Show(
                            "Could not find that Plate Number in the database.\n\n" +
                            "Note: You cannot change a bus's Plate Number. Delete the old bus and add a new one.",
                            "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    using (SqlCommand cmd = new SqlCommand(
                        "UPDATE COLOR SET Bus_color = @Color WHERE Plate_Number = @Plate", conn))
                    {
                        cmd.Parameters.AddWithValue("@Color", color);
                        cmd.Parameters.AddWithValue("@Plate", plateNumber);
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Bus updated successfully!");
                LoadFleetData();
            }
            catch (Exception ex) { MessageBox.Show("Error updating bus: " + ex.Message); }
        }

        // ─── Delete Bus ───────────────────────────────────────────────────────

        private void button5_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Platenumber.Text))
            { MessageBox.Show("Please select a bus from the table first."); return; }

            if (MessageBox.Show("Are you sure you want to delete this bus?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                != DialogResult.Yes) return;

            try
            {
                string plateNumber = txt_Platenumber.Text;
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(@"
                    DELETE FROM ASSIGNED_TO WHERE Plate_Number = @Plate;
                    DELETE FROM COLOR         WHERE Plate_Number = @Plate;
                    DELETE FROM BUS           WHERE Plate_Number = @Plate;", conn))
                {
                    cmd.Parameters.AddWithValue("@Plate", plateNumber);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Bus deleted successfully!");
                LoadFleetData();
                txt_Platenumber.Clear();
                txt_Capacity.Clear();
                txt_Color.Clear();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("Cannot delete — this bus is linked to other records. Remove them first.");
                else
                    MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex) { MessageBox.Show("Error deleting bus: " + ex.Message); }
        }

        // ─── Grid row click → populate fields ────────────────────────────────

        private void dgv_Fleet_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            DataGridViewRow row = dgv_Fleet.Rows[e.RowIndex];
            txt_Platenumber.Text = row.Cells["Plate Number"].Value.ToString();
            txt_Capacity.Text = row.Cells["Capacity"].Value.ToString();
            txt_Color.Text = row.Cells["Color"].Value.ToString();
            cmb_Assigneddriver.Text = row.Cells["Driver Name"].Value.ToString();
        }

        // ─── Stubs ────────────────────────────────────────────────────────────
        private void dgv_Fleet_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void cmb_Assigneddriver_SelectedIndexChanged(object sender, EventArgs e) { }
        private void btn_Deletebus_Click(object sender, EventArgs e) { }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}