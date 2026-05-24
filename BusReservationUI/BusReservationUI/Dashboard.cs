using System;
using System.Drawing;
using System.Windows.Forms;

namespace BusReservationUI
{
    public partial class Dashboard : Form
    {
        private readonly Color _clrPassengers = Color.FromArgb(67, 97, 238);
        private readonly Color _clrRoutes = Color.FromArgb(16, 185, 129);
        private readonly Color _clrReservations = Color.FromArgb(236, 72, 153);
        private readonly Color _clrFleet = Color.FromArgb(139, 92, 246);

        public Dashboard()
        {
            InitializeComponent();
        }


        private void btn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                btn.BackColor = Lighten(btn.BackColor, 25);
            }
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                switch (btn.Name)
                {
                    case "btn_Passenegers": btn.BackColor = _clrPassengers; break;
                    case "btn_RoutesandTrips": btn.BackColor = _clrRoutes; break;
                    case "btn_Reservations": btn.BackColor = _clrReservations; break;
                    case "btn_FleetandDrivers": btn.BackColor = _clrFleet; break;
                }
            }
        }

        private static Color Lighten(Color c, int amount) =>
            Color.FromArgb(
                Math.Min(c.R + amount, 255),
                Math.Min(c.G + amount, 255),
                Math.Min(c.B + amount, 255));


        private void NavigateTo(Form next)
        {
            next.StartPosition = FormStartPosition.Manual;
            next.Location = this.Location;
            next.Size = this.Size;
            next.WindowState = this.WindowState;
            next.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e) =>
            NavigateTo(new Passengers());

        private void btn_FleetandDrivers_Click(object sender, EventArgs e) =>
            NavigateTo(new Fleet_and_Drivers());

        private void btn_reservations(object sender, EventArgs e) =>
            NavigateTo(new reservations());

        private void btn_Routes_and_Trips(object sender, EventArgs e) =>
            NavigateTo(new Routes_and_Trips());
    }
}