namespace BusReservationUI
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Accent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Passenegers = new System.Windows.Forms.Button();
            this.btn_RoutesandTrips = new System.Windows.Forms.Button();
            this.btn_Reservations = new System.Windows.Forms.Button();
            this.btn_FleetandDrivers = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.pnl_Header.Controls.Add(this.lbl_Subtitle);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Controls.Add(this.pnl_Accent);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(913, 96);
            this.pnl_Header.TabIndex = 6;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(150)))), ((int)(((byte)(175)))));
            this.lbl_Subtitle.Location = new System.Drawing.Point(21, 62);
            this.lbl_Subtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(381, 20);
            this.lbl_Subtitle.TabIndex = 0;
            this.lbl_Subtitle.Text = "Management Dashboard — select a module to continue";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.White;
            this.lbl_Title.Location = new System.Drawing.Point(16, 12);
            this.lbl_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(409, 40);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "🚌   Bus Reservation System";
            // 
            // pnl_Accent
            // 
            this.pnl_Accent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.pnl_Accent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Accent.Location = new System.Drawing.Point(0, 94);
            this.pnl_Accent.Margin = new System.Windows.Forms.Padding(4);
            this.pnl_Accent.Name = "pnl_Accent";
            this.pnl_Accent.Size = new System.Drawing.Size(913, 2);
            this.pnl_Accent.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btn_Passenegers, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_RoutesandTrips, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_Reservations, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn_FleetandDrivers, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 96);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(913, 483);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // btn_Passenegers
            // 
            this.btn_Passenegers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Passenegers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(108)))), ((int)(((byte)(247)))));
            this.btn_Passenegers.FlatAppearance.BorderSize = 0;
            this.btn_Passenegers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_Passenegers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Passenegers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Passenegers.ForeColor = System.Drawing.Color.White;
            this.btn_Passenegers.Location = new System.Drawing.Point(21, 19);
            this.btn_Passenegers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Passenegers.Name = "btn_Passenegers";
            this.btn_Passenegers.Size = new System.Drawing.Size(427, 215);
            this.btn_Passenegers.TabIndex = 0;
            this.btn_Passenegers.Text = "👥\r\nPassengers";
            this.btn_Passenegers.UseVisualStyleBackColor = false;
            this.btn_Passenegers.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RoutesandTrips
            // 
            this.btn_RoutesandTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_RoutesandTrips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(178)))), ((int)(((byte)(120)))));
            this.btn_RoutesandTrips.FlatAppearance.BorderSize = 0;
            this.btn_RoutesandTrips.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(198)))), ((int)(((byte)(140)))));
            this.btn_RoutesandTrips.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RoutesandTrips.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_RoutesandTrips.ForeColor = System.Drawing.Color.White;
            this.btn_RoutesandTrips.Location = new System.Drawing.Point(464, 19);
            this.btn_RoutesandTrips.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_RoutesandTrips.Name = "btn_RoutesandTrips";
            this.btn_RoutesandTrips.Size = new System.Drawing.Size(428, 215);
            this.btn_RoutesandTrips.TabIndex = 4;
            this.btn_RoutesandTrips.Text = "🗺\r\nRoutes & Trips";
            this.btn_RoutesandTrips.UseVisualStyleBackColor = false;
            this.btn_RoutesandTrips.Click += new System.EventHandler(this.btn_Routes_and_Trips);
            // 
            // btn_Reservations
            // 
            this.btn_Reservations.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(50)))), ((int)(((byte)(130)))));
            this.btn_Reservations.FlatAppearance.BorderSize = 0;
            this.btn_Reservations.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(70)))), ((int)(((byte)(150)))));
            this.btn_Reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Reservations.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_Reservations.ForeColor = System.Drawing.Color.White;
            this.btn_Reservations.Location = new System.Drawing.Point(21, 248);
            this.btn_Reservations.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_Reservations.Name = "btn_Reservations";
            this.btn_Reservations.Size = new System.Drawing.Size(427, 216);
            this.btn_Reservations.TabIndex = 2;
            this.btn_Reservations.Text = "📋\r\nReservations";
            this.btn_Reservations.UseVisualStyleBackColor = false;
            this.btn_Reservations.Click += new System.EventHandler(this.btn_reservations);
            // 
            // btn_FleetandDrivers
            // 
            this.btn_FleetandDrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_FleetandDrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(130)))), ((int)(((byte)(210)))));
            this.btn_FleetandDrivers.FlatAppearance.BorderSize = 0;
            this.btn_FleetandDrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(150)))), ((int)(((byte)(230)))));
            this.btn_FleetandDrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_FleetandDrivers.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btn_FleetandDrivers.ForeColor = System.Drawing.Color.White;
            this.btn_FleetandDrivers.Location = new System.Drawing.Point(464, 248);
            this.btn_FleetandDrivers.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_FleetandDrivers.Name = "btn_FleetandDrivers";
            this.btn_FleetandDrivers.Size = new System.Drawing.Size(428, 216);
            this.btn_FleetandDrivers.TabIndex = 3;
            this.btn_FleetandDrivers.Text = "🚌\r\nFleet & Drivers";
            this.btn_FleetandDrivers.UseVisualStyleBackColor = false;
            this.btn_FleetandDrivers.Click += new System.EventHandler(this.btn_FleetandDrivers_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(913, 579);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(661, 481);
            this.Name = "Dashboard";
            this.Text = "Bus Reservation System";
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Accent;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Button btn_Passenegers;
        private System.Windows.Forms.Button btn_Reservations;
        private System.Windows.Forms.Button btn_FleetandDrivers;
        private System.Windows.Forms.Button btn_RoutesandTrips;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}