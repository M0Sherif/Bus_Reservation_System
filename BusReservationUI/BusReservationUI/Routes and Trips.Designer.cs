namespace BusReservationUI
{
    partial class Routes_and_Trips
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Routes_and_Trips));
            this.dgv_RoutesTrips = new System.Windows.Forms.DataGridView();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.pnl_Divider = new System.Windows.Forms.Panel();
            this.pnl_Routes = new System.Windows.Forms.Panel();
            this.lbl_RouteSection = new System.Windows.Forms.Label();
            this.labelRouteCode = new System.Windows.Forms.Label();
            this.txt_RouteCode = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.labelDistance = new System.Windows.Forms.Label();
            this.txt_Distance = new System.Windows.Forms.TextBox();
            this.btn_AddRoute = new System.Windows.Forms.Button();
            this.btn_UpdateRoute = new System.Windows.Forms.Button();
            this.btn_DeleteRoute = new System.Windows.Forms.Button();
            this.pnl_Trips = new System.Windows.Forms.Panel();
            this.lbl_TripSection = new System.Windows.Forms.Label();
            this.labelArrivalDateTime = new System.Windows.Forms.Label();
            this.dtp_Arrival = new System.Windows.Forms.DateTimePicker();
            this.labelDepartureTime = new System.Windows.Forms.Label();
            this.dtp_Departure = new System.Windows.Forms.DateTimePicker();
            this.labelAssignedRoute = new System.Windows.Forms.Label();
            this.cmb_RouteCode = new System.Windows.Forms.ComboBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.txt_Price = new System.Windows.Forms.TextBox();
            this.labelTripID = new System.Windows.Forms.Label();
            this.txt_TripID = new System.Windows.Forms.TextBox();
            this.btn_AddTrip = new System.Windows.Forms.Button();
            this.btn_UpdateTrip = new System.Windows.Forms.Button();
            this.btn_DeleteTrip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoutesTrips)).BeginInit();
            this.pnl_Header.SuspendLayout();
            this.pnl_Routes.SuspendLayout();
            this.pnl_Trips.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_RoutesTrips
            // 
            this.dgv_RoutesTrips.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(38)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_RoutesTrips.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_RoutesTrips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_RoutesTrips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_RoutesTrips.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.dgv_RoutesTrips.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_RoutesTrips.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.dgv_RoutesTrips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_RoutesTrips.ColumnHeadersHeight = 36;
            this.dgv_RoutesTrips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_RoutesTrips.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_RoutesTrips.EnableHeadersVisualStyles = false;
            this.dgv_RoutesTrips.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dgv_RoutesTrips.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(60)))), ((int)(((byte)(85)))));
            this.dgv_RoutesTrips.Location = new System.Drawing.Point(24, 325);
            this.dgv_RoutesTrips.MultiSelect = false;
            this.dgv_RoutesTrips.Name = "dgv_RoutesTrips";
            this.dgv_RoutesTrips.ReadOnly = true;
            this.dgv_RoutesTrips.RowHeadersVisible = false;
            this.dgv_RoutesTrips.RowHeadersWidth = 51;
            this.dgv_RoutesTrips.RowTemplate.Height = 34;
            this.dgv_RoutesTrips.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_RoutesTrips.Size = new System.Drawing.Size(1092, 330);
            this.dgv_RoutesTrips.TabIndex = 0;
            this.dgv_RoutesTrips.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_RoutesTrips_CellClick);
            // 
            // btn_Back
            // 
            this.btn_Back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_Back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btn_Back.Location = new System.Drawing.Point(1034, 30);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(90, 30);
            this.btn_Back.TabIndex = 1;
            this.btn_Back.Text = "<- Back";
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.btn_Back_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_Header.Controls.Add(this.lbl_Subtitle);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(1140, 90);
            this.pnl_Header.TabIndex = 5;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl_Subtitle.Location = new System.Drawing.Point(27, 56);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(339, 20);
            this.lbl_Subtitle.TabIndex = 0;
            this.lbl_Subtitle.Text = "Routes & Trips — manage routes and schedule trips";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lbl_Title.Location = new System.Drawing.Point(24, 14);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(344, 40);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Bus Reservation System";
            // 
            // pnl_Divider
            // 
            this.pnl_Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.pnl_Divider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Divider.Location = new System.Drawing.Point(0, 90);
            this.pnl_Divider.Name = "pnl_Divider";
            this.pnl_Divider.Size = new System.Drawing.Size(1140, 3);
            this.pnl_Divider.TabIndex = 4;
            // 
            // pnl_Routes
            // 
            this.pnl_Routes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.pnl_Routes.Controls.Add(this.lbl_RouteSection);
            this.pnl_Routes.Controls.Add(this.labelRouteCode);
            this.pnl_Routes.Controls.Add(this.txt_RouteCode);
            this.pnl_Routes.Controls.Add(this.labelDestination);
            this.pnl_Routes.Controls.Add(this.txt_Destination);
            this.pnl_Routes.Controls.Add(this.labelDistance);
            this.pnl_Routes.Controls.Add(this.txt_Distance);
            this.pnl_Routes.Controls.Add(this.btn_AddRoute);
            this.pnl_Routes.Controls.Add(this.btn_UpdateRoute);
            this.pnl_Routes.Controls.Add(this.btn_DeleteRoute);
            this.pnl_Routes.Location = new System.Drawing.Point(24, 109);
            this.pnl_Routes.Name = "pnl_Routes";
            this.pnl_Routes.Size = new System.Drawing.Size(510, 200);
            this.pnl_Routes.TabIndex = 3;
            // 
            // lbl_RouteSection
            // 
            this.lbl_RouteSection.AutoSize = true;
            this.lbl_RouteSection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_RouteSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lbl_RouteSection.Location = new System.Drawing.Point(16, 12);
            this.lbl_RouteSection.Name = "lbl_RouteSection";
            this.lbl_RouteSection.Size = new System.Drawing.Size(158, 19);
            this.lbl_RouteSection.TabIndex = 0;
            this.lbl_RouteSection.Text = "ROUTE MANAGEMENT";
            // 
            // labelRouteCode
            // 
            this.labelRouteCode.AutoSize = true;
            this.labelRouteCode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelRouteCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelRouteCode.Location = new System.Drawing.Point(16, 42);
            this.labelRouteCode.Name = "labelRouteCode";
            this.labelRouteCode.Size = new System.Drawing.Size(90, 20);
            this.labelRouteCode.TabIndex = 1;
            this.labelRouteCode.Text = "Route Code";
            // 
            // txt_RouteCode
            // 
            this.txt_RouteCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_RouteCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_RouteCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_RouteCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_RouteCode.Location = new System.Drawing.Point(145, 39);
            this.txt_RouteCode.Name = "txt_RouteCode";
            this.txt_RouteCode.Size = new System.Drawing.Size(180, 29);
            this.txt_RouteCode.TabIndex = 8;
            // 
            // labelDestination
            // 
            this.labelDestination.AutoSize = true;
            this.labelDestination.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDestination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelDestination.Location = new System.Drawing.Point(16, 74);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(90, 20);
            this.labelDestination.TabIndex = 9;
            this.labelDestination.Text = "Destination";
            // 
            // txt_Destination
            // 
            this.txt_Destination.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destination.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Destination.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Destination.Location = new System.Drawing.Point(145, 71);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(180, 29);
            this.txt_Destination.TabIndex = 7;
            // 
            // labelDistance
            // 
            this.labelDistance.AutoSize = true;
            this.labelDistance.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDistance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelDistance.Location = new System.Drawing.Point(16, 106);
            this.labelDistance.Name = "labelDistance";
            this.labelDistance.Size = new System.Drawing.Size(69, 20);
            this.labelDistance.TabIndex = 10;
            this.labelDistance.Text = "Distance";
            // 
            // txt_Distance
            // 
            this.txt_Distance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Distance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Distance.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Distance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Distance.Location = new System.Drawing.Point(145, 103);
            this.txt_Distance.Name = "txt_Distance";
            this.txt_Distance.Size = new System.Drawing.Size(180, 29);
            this.txt_Distance.TabIndex = 6;
            // 
            // btn_AddRoute
            // 
            this.btn_AddRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btn_AddRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddRoute.FlatAppearance.BorderSize = 0;
            this.btn_AddRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btn_AddRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AddRoute.ForeColor = System.Drawing.Color.White;
            this.btn_AddRoute.Location = new System.Drawing.Point(16, 148);
            this.btn_AddRoute.Name = "btn_AddRoute";
            this.btn_AddRoute.Size = new System.Drawing.Size(100, 30);
            this.btn_AddRoute.TabIndex = 11;
            this.btn_AddRoute.Text = "+ Add";
            this.btn_AddRoute.UseVisualStyleBackColor = false;
            this.btn_AddRoute.Click += new System.EventHandler(this.btn_AddRoute_Click);
            // 
            // btn_UpdateRoute
            // 
            this.btn_UpdateRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_UpdateRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateRoute.FlatAppearance.BorderSize = 0;
            this.btn_UpdateRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btn_UpdateRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateRoute.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateRoute.Location = new System.Drawing.Point(126, 148);
            this.btn_UpdateRoute.Name = "btn_UpdateRoute";
            this.btn_UpdateRoute.Size = new System.Drawing.Size(100, 30);
            this.btn_UpdateRoute.TabIndex = 12;
            this.btn_UpdateRoute.Text = "Update";
            this.btn_UpdateRoute.UseVisualStyleBackColor = false;
            this.btn_UpdateRoute.Click += new System.EventHandler(this.btn_UpdateRoute_Click);
            // 
            // btn_DeleteRoute
            // 
            this.btn_DeleteRoute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.btn_DeleteRoute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteRoute.FlatAppearance.BorderSize = 0;
            this.btn_DeleteRoute.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.btn_DeleteRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteRoute.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteRoute.Location = new System.Drawing.Point(236, 148);
            this.btn_DeleteRoute.Name = "btn_DeleteRoute";
            this.btn_DeleteRoute.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteRoute.TabIndex = 13;
            this.btn_DeleteRoute.Text = "Delete";
            this.btn_DeleteRoute.UseVisualStyleBackColor = false;
            this.btn_DeleteRoute.Click += new System.EventHandler(this.btn_DeleteRoute_Click);
            // 
            // pnl_Trips
            // 
            this.pnl_Trips.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.pnl_Trips.Controls.Add(this.lbl_TripSection);
            this.pnl_Trips.Controls.Add(this.labelArrivalDateTime);
            this.pnl_Trips.Controls.Add(this.dtp_Arrival);
            this.pnl_Trips.Controls.Add(this.labelDepartureTime);
            this.pnl_Trips.Controls.Add(this.dtp_Departure);
            this.pnl_Trips.Controls.Add(this.labelAssignedRoute);
            this.pnl_Trips.Controls.Add(this.cmb_RouteCode);
            this.pnl_Trips.Controls.Add(this.labelPrice);
            this.pnl_Trips.Controls.Add(this.txt_Price);
            this.pnl_Trips.Controls.Add(this.labelTripID);
            this.pnl_Trips.Controls.Add(this.txt_TripID);
            this.pnl_Trips.Controls.Add(this.btn_AddTrip);
            this.pnl_Trips.Controls.Add(this.btn_UpdateTrip);
            this.pnl_Trips.Controls.Add(this.btn_DeleteTrip);
            this.pnl_Trips.Location = new System.Drawing.Point(554, 109);
            this.pnl_Trips.Name = "pnl_Trips";
            this.pnl_Trips.Size = new System.Drawing.Size(522, 200);
            this.pnl_Trips.TabIndex = 2;
            // 
            // lbl_TripSection
            // 
            this.lbl_TripSection.AutoSize = true;
            this.lbl_TripSection.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lbl_TripSection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.lbl_TripSection.Location = new System.Drawing.Point(16, 12);
            this.lbl_TripSection.Name = "lbl_TripSection";
            this.lbl_TripSection.Size = new System.Drawing.Size(143, 19);
            this.lbl_TripSection.TabIndex = 0;
            this.lbl_TripSection.Text = "TRIP MANAGEMENT";
            // 
            // labelArrivalDateTime
            // 
            this.labelArrivalDateTime.AutoSize = true;
            this.labelArrivalDateTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelArrivalDateTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelArrivalDateTime.Location = new System.Drawing.Point(16, 42);
            this.labelArrivalDateTime.Name = "labelArrivalDateTime";
            this.labelArrivalDateTime.Size = new System.Drawing.Size(135, 20);
            this.labelArrivalDateTime.TabIndex = 1;
            this.labelArrivalDateTime.Text = "Arrival Date/Time";
            // 
            // dtp_Arrival
            // 
            this.dtp_Arrival.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dtp_Arrival.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dtp_Arrival.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dtp_Arrival.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dtp_Arrival.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.dtp_Arrival.CustomFormat = "yyyy-MM-dd HH:mm";
            this.dtp_Arrival.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Arrival.Location = new System.Drawing.Point(16, 62);
            this.dtp_Arrival.Name = "dtp_Arrival";
            this.dtp_Arrival.Size = new System.Drawing.Size(200, 22);
            this.dtp_Arrival.TabIndex = 14;
            // 
            // labelDepartureTime
            // 
            this.labelDepartureTime.AutoSize = true;
            this.labelDepartureTime.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelDepartureTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelDepartureTime.Location = new System.Drawing.Point(234, 42);
            this.labelDepartureTime.Name = "labelDepartureTime";
            this.labelDepartureTime.Size = new System.Drawing.Size(119, 20);
            this.labelDepartureTime.TabIndex = 15;
            this.labelDepartureTime.Text = "Departure Time";
            // 
            // dtp_Departure
            // 
            this.dtp_Departure.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtp_Departure.Location = new System.Drawing.Point(234, 62);
            this.dtp_Departure.Name = "dtp_Departure";
            this.dtp_Departure.ShowUpDown = true;
            this.dtp_Departure.Size = new System.Drawing.Size(180, 22);
            this.dtp_Departure.TabIndex = 15;
            // 
            // labelAssignedRoute
            // 
            this.labelAssignedRoute.AutoSize = true;
            this.labelAssignedRoute.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelAssignedRoute.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelAssignedRoute.Location = new System.Drawing.Point(16, 98);
            this.labelAssignedRoute.Name = "labelAssignedRoute";
            this.labelAssignedRoute.Size = new System.Drawing.Size(119, 20);
            this.labelAssignedRoute.TabIndex = 16;
            this.labelAssignedRoute.Text = "Assigned Route";
            // 
            // cmb_RouteCode
            // 
            this.cmb_RouteCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmb_RouteCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_RouteCode.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.cmb_RouteCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmb_RouteCode.FormattingEnabled = true;
            this.cmb_RouteCode.Location = new System.Drawing.Point(16, 118);
            this.cmb_RouteCode.Name = "cmb_RouteCode";
            this.cmb_RouteCode.Size = new System.Drawing.Size(160, 29);
            this.cmb_RouteCode.TabIndex = 17;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelPrice.Location = new System.Drawing.Point(196, 98);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(43, 20);
            this.labelPrice.TabIndex = 18;
            this.labelPrice.Text = "Price";
            // 
            // txt_Price
            // 
            this.txt_Price.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Price.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Price.Location = new System.Drawing.Point(196, 118);
            this.txt_Price.Name = "txt_Price";
            this.txt_Price.Size = new System.Drawing.Size(130, 29);
            this.txt_Price.TabIndex = 8;
            // 
            // labelTripID
            // 
            this.labelTripID.AutoSize = true;
            this.labelTripID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.labelTripID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.labelTripID.Location = new System.Drawing.Point(346, 98);
            this.labelTripID.Name = "labelTripID";
            this.labelTripID.Size = new System.Drawing.Size(104, 20);
            this.labelTripID.TabIndex = 19;
            this.labelTripID.Text = "Trip ID (auto)";
            // 
            // txt_TripID
            // 
            this.txt_TripID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(55)))));
            this.txt_TripID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TripID.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.txt_TripID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.txt_TripID.Location = new System.Drawing.Point(346, 118);
            this.txt_TripID.Name = "txt_TripID";
            this.txt_TripID.ReadOnly = true;
            this.txt_TripID.Size = new System.Drawing.Size(130, 29);
            this.txt_TripID.TabIndex = 19;
            // 
            // btn_AddTrip
            // 
            this.btn_AddTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btn_AddTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_AddTrip.FlatAppearance.BorderSize = 0;
            this.btn_AddTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btn_AddTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AddTrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_AddTrip.ForeColor = System.Drawing.Color.White;
            this.btn_AddTrip.Location = new System.Drawing.Point(16, 158);
            this.btn_AddTrip.Name = "btn_AddTrip";
            this.btn_AddTrip.Size = new System.Drawing.Size(100, 30);
            this.btn_AddTrip.TabIndex = 20;
            this.btn_AddTrip.Text = "+ Add";
            this.btn_AddTrip.UseVisualStyleBackColor = false;
            this.btn_AddTrip.Click += new System.EventHandler(this.btn_AddTrip_Click);
            // 
            // btn_UpdateTrip
            // 
            this.btn_UpdateTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_UpdateTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_UpdateTrip.FlatAppearance.BorderSize = 0;
            this.btn_UpdateTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btn_UpdateTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateTrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_UpdateTrip.ForeColor = System.Drawing.Color.White;
            this.btn_UpdateTrip.Location = new System.Drawing.Point(126, 158);
            this.btn_UpdateTrip.Name = "btn_UpdateTrip";
            this.btn_UpdateTrip.Size = new System.Drawing.Size(100, 30);
            this.btn_UpdateTrip.TabIndex = 21;
            this.btn_UpdateTrip.Text = "Update";
            this.btn_UpdateTrip.UseVisualStyleBackColor = false;
            this.btn_UpdateTrip.Click += new System.EventHandler(this.btn_UpdateTrip_Click);
            // 
            // btn_DeleteTrip
            // 
            this.btn_DeleteTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(72)))), ((int)(((byte)(153)))));
            this.btn_DeleteTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_DeleteTrip.FlatAppearance.BorderSize = 0;
            this.btn_DeleteTrip.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(91)))), ((int)(((byte)(151)))));
            this.btn_DeleteTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DeleteTrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_DeleteTrip.ForeColor = System.Drawing.Color.White;
            this.btn_DeleteTrip.Location = new System.Drawing.Point(236, 158);
            this.btn_DeleteTrip.Name = "btn_DeleteTrip";
            this.btn_DeleteTrip.Size = new System.Drawing.Size(100, 30);
            this.btn_DeleteTrip.TabIndex = 22;
            this.btn_DeleteTrip.Text = "Delete";
            this.btn_DeleteTrip.UseVisualStyleBackColor = false;
            this.btn_DeleteTrip.Click += new System.EventHandler(this.btn_DeleteTrip_Click);
            // 
            // Routes_and_Trips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1140, 680);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.dgv_RoutesTrips);
            this.Controls.Add(this.pnl_Trips);
            this.Controls.Add(this.pnl_Routes);
            this.Controls.Add(this.pnl_Divider);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(900, 580);
            this.Name = "Routes_and_Trips";
            this.Text = "Bus Reservation — Routes & Trips";
            this.Load += new System.EventHandler(this.Routes_and_Trips_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RoutesTrips)).EndInit();
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Routes.ResumeLayout(false);
            this.pnl_Routes.PerformLayout();
            this.pnl_Trips.ResumeLayout(false);
            this.pnl_Trips.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RoutesTrips;
        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Panel pnl_Divider;
        private System.Windows.Forms.Panel pnl_Routes;
        private System.Windows.Forms.Panel pnl_Trips;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Label lbl_RouteSection;
        private System.Windows.Forms.Label lbl_TripSection;
        private System.Windows.Forms.TextBox txt_Distance;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.TextBox txt_RouteCode;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.Label labelDistance;
        private System.Windows.Forms.Label labelRouteCode;
        private System.Windows.Forms.Button btn_DeleteRoute;
        private System.Windows.Forms.Button btn_UpdateRoute;
        private System.Windows.Forms.Button btn_AddRoute;
        private System.Windows.Forms.Button btn_DeleteTrip;
        private System.Windows.Forms.Button btn_UpdateTrip;
        private System.Windows.Forms.Button btn_AddTrip;
        private System.Windows.Forms.TextBox txt_Price;
        private System.Windows.Forms.Label labelArrivalDateTime;
        private System.Windows.Forms.Label labelDepartureTime;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.DateTimePicker dtp_Arrival;
        private System.Windows.Forms.DateTimePicker dtp_Departure;
        private System.Windows.Forms.Label labelAssignedRoute;
        private System.Windows.Forms.ComboBox cmb_RouteCode;
        private System.Windows.Forms.TextBox txt_TripID;
        private System.Windows.Forms.Label labelTripID;
    }
}