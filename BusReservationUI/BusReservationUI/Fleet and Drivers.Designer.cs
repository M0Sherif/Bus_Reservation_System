namespace BusReservationUI
{
    partial class Fleet_and_Drivers
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fleet_and_Drivers));
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_Subtitle = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.pnl_Divider = new System.Windows.Forms.Panel();
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.dgv_Fleet = new System.Windows.Forms.DataGridView();
            this.pnl_Actions = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_Addbus = new System.Windows.Forms.Button();
            this.btn_Updatebus = new System.Windows.Forms.Button();
            this.btn_Deletebus = new System.Windows.Forms.Button();
            this.pnl_FormCard = new System.Windows.Forms.Panel();
            this.tbl_Fields = new System.Windows.Forms.TableLayoutPanel();
            this.labelplate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_Platenumber = new System.Windows.Forms.TextBox();
            this.txt_Capacity = new System.Windows.Forms.TextBox();
            this.txt_Color = new System.Windows.Forms.TextBox();
            this.cmb_Assigneddriver = new System.Windows.Forms.ComboBox();
            this.pnl_TopBar = new System.Windows.Forms.Panel();
            this.btn_Managedrivers = new System.Windows.Forms.Button();
            this.pnl_Header.SuspendLayout();
            this.pnl_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fleet)).BeginInit();
            this.pnl_Actions.SuspendLayout();
            this.pnl_FormCard.SuspendLayout();
            this.tbl_Fields.SuspendLayout();
            this.pnl_TopBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Header
            // 
            this.pnl_Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_Header.Controls.Add(this.lbl_Subtitle);
            this.pnl_Header.Controls.Add(this.lbl_Title);
            this.pnl_Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Header.Location = new System.Drawing.Point(0, 0);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(933, 87);
            this.pnl_Header.TabIndex = 2;
            // 
            // lbl_Subtitle
            // 
            this.lbl_Subtitle.AutoSize = true;
            this.lbl_Subtitle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Subtitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.lbl_Subtitle.Location = new System.Drawing.Point(27, 58);
            this.lbl_Subtitle.Name = "lbl_Subtitle";
            this.lbl_Subtitle.Size = new System.Drawing.Size(313, 20);
            this.lbl_Subtitle.TabIndex = 0;
            this.lbl_Subtitle.Text = "Manage your bus fleet and driver assignments";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold);
            this.lbl_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.lbl_Title.Location = new System.Drawing.Point(24, 16);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(254, 40);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "🚐  Fleet & Drivers";
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btn_back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_back.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            this.btn_back.Location = new System.Drawing.Point(806, 28);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(97, 27);
            this.btn_back.TabIndex = 0;
            this.btn_back.Text = "← Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // pnl_Divider
            // 
            this.pnl_Divider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.pnl_Divider.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Divider.Location = new System.Drawing.Point(0, 87);
            this.pnl_Divider.Name = "pnl_Divider";
            this.pnl_Divider.Size = new System.Drawing.Size(933, 10);
            this.pnl_Divider.TabIndex = 1;
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_Main.Controls.Add(this.dgv_Fleet);
            this.pnl_Main.Controls.Add(this.pnl_Actions);
            this.pnl_Main.Controls.Add(this.pnl_FormCard);
            this.pnl_Main.Controls.Add(this.pnl_TopBar);
            this.pnl_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Main.Location = new System.Drawing.Point(0, 97);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(20, 0, 20, 16);
            this.pnl_Main.Size = new System.Drawing.Size(933, 563);
            this.pnl_Main.TabIndex = 0;
            // 
            // dgv_Fleet
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(27)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.dgv_Fleet.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Fleet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Fleet.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.dgv_Fleet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Fleet.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(163)))), ((int)(((byte)(184)))));
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fleet.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Fleet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Fleet.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Fleet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Fleet.EnableHeadersVisualStyles = false;
            this.dgv_Fleet.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.dgv_Fleet.Location = new System.Drawing.Point(20, 171);
            this.dgv_Fleet.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.dgv_Fleet.MultiSelect = false;
            this.dgv_Fleet.Name = "dgv_Fleet";
            this.dgv_Fleet.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Fleet.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Fleet.RowHeadersWidth = 36;
            this.dgv_Fleet.RowTemplate.Height = 34;
            this.dgv_Fleet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Fleet.Size = new System.Drawing.Size(893, 376);
            this.dgv_Fleet.TabIndex = 11;
            this.dgv_Fleet.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Fleet_CellClick);
            this.dgv_Fleet.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Fleet_CellContentClick);
            // 
            // pnl_Actions
            // 
            this.pnl_Actions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_Actions.Controls.Add(this.button2);
            this.pnl_Actions.Controls.Add(this.btn_Addbus);
            this.pnl_Actions.Controls.Add(this.btn_Updatebus);
            this.pnl_Actions.Controls.Add(this.btn_Deletebus);
            this.pnl_Actions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Actions.Location = new System.Drawing.Point(20, 115);
            this.pnl_Actions.Name = "pnl_Actions";
            this.pnl_Actions.Size = new System.Drawing.Size(893, 56);
            this.pnl_Actions.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(670, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(213, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "👤Manage drivers";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_Managedrivers_Click);
            // 
            // btn_Addbus
            // 
            this.btn_Addbus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(185)))), ((int)(((byte)(129)))));
            this.btn_Addbus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Addbus.FlatAppearance.BorderSize = 0;
            this.btn_Addbus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(211)))), ((int)(((byte)(153)))));
            this.btn_Addbus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Addbus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Addbus.ForeColor = System.Drawing.Color.White;
            this.btn_Addbus.Location = new System.Drawing.Point(0, 10);
            this.btn_Addbus.Name = "btn_Addbus";
            this.btn_Addbus.Size = new System.Drawing.Size(120, 36);
            this.btn_Addbus.TabIndex = 8;
            this.btn_Addbus.Text = "＋  Add Bus";
            this.btn_Addbus.UseVisualStyleBackColor = false;
            this.btn_Addbus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Updatebus
            // 
            this.btn_Updatebus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(97)))), ((int)(((byte)(238)))));
            this.btn_Updatebus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Updatebus.FlatAppearance.BorderSize = 0;
            this.btn_Updatebus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.btn_Updatebus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Updatebus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Updatebus.ForeColor = System.Drawing.Color.White;
            this.btn_Updatebus.Location = new System.Drawing.Point(130, 10);
            this.btn_Updatebus.Name = "btn_Updatebus";
            this.btn_Updatebus.Size = new System.Drawing.Size(130, 36);
            this.btn_Updatebus.TabIndex = 9;
            this.btn_Updatebus.Text = "✏  Update Bus";
            this.btn_Updatebus.UseVisualStyleBackColor = false;
            this.btn_Updatebus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Deletebus
            // 
            this.btn_Deletebus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.btn_Deletebus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Deletebus.FlatAppearance.BorderSize = 0;
            this.btn_Deletebus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(113)))), ((int)(((byte)(113)))));
            this.btn_Deletebus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Deletebus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.btn_Deletebus.ForeColor = System.Drawing.Color.White;
            this.btn_Deletebus.Location = new System.Drawing.Point(270, 10);
            this.btn_Deletebus.Name = "btn_Deletebus";
            this.btn_Deletebus.Size = new System.Drawing.Size(130, 36);
            this.btn_Deletebus.TabIndex = 10;
            this.btn_Deletebus.Text = "🗑  Delete Bus";
            this.btn_Deletebus.UseVisualStyleBackColor = false;
            this.btn_Deletebus.Click += new System.EventHandler(this.button5_Click);
            // 
            // pnl_FormCard
            // 
            this.pnl_FormCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.pnl_FormCard.Controls.Add(this.tbl_Fields);
            this.pnl_FormCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_FormCard.Location = new System.Drawing.Point(20, 10);
            this.pnl_FormCard.Name = "pnl_FormCard";
            this.pnl_FormCard.Padding = new System.Windows.Forms.Padding(14, 10, 14, 10);
            this.pnl_FormCard.Size = new System.Drawing.Size(893, 105);
            this.pnl_FormCard.TabIndex = 13;
            // 
            // tbl_Fields
            // 
            this.tbl_Fields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.tbl_Fields.ColumnCount = 4;
            this.tbl_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Fields.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbl_Fields.Controls.Add(this.labelplate, 0, 0);
            this.tbl_Fields.Controls.Add(this.label7, 1, 0);
            this.tbl_Fields.Controls.Add(this.label6, 2, 0);
            this.tbl_Fields.Controls.Add(this.label5, 3, 0);
            this.tbl_Fields.Controls.Add(this.txt_Platenumber, 0, 1);
            this.tbl_Fields.Controls.Add(this.txt_Capacity, 1, 1);
            this.tbl_Fields.Controls.Add(this.txt_Color, 2, 1);
            this.tbl_Fields.Controls.Add(this.cmb_Assigneddriver, 3, 1);
            this.tbl_Fields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_Fields.Location = new System.Drawing.Point(14, 10);
            this.tbl_Fields.Name = "tbl_Fields";
            this.tbl_Fields.RowCount = 2;
            this.tbl_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tbl_Fields.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl_Fields.Size = new System.Drawing.Size(865, 85);
            this.tbl_Fields.TabIndex = 0;
            // 
            // labelplate
            // 
            this.labelplate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelplate.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.labelplate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.labelplate.Location = new System.Drawing.Point(6, 0);
            this.labelplate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 2);
            this.labelplate.Name = "labelplate";
            this.labelplate.Size = new System.Drawing.Size(204, 24);
            this.labelplate.TabIndex = 0;
            this.labelplate.Text = "PLATE NUMBER";
            this.labelplate.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label7.Location = new System.Drawing.Point(222, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 2);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(204, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "CAPACITY";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label6.Location = new System.Drawing.Point(438, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 2);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(204, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "COLOR";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(116)))), ((int)(((byte)(139)))));
            this.label5.Location = new System.Drawing.Point(654, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "ASSIGNED DRIVER";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // txt_Platenumber
            // 
            this.txt_Platenumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Platenumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Platenumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Platenumber.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Platenumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Platenumber.Location = new System.Drawing.Point(6, 26);
            this.txt_Platenumber.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_Platenumber.Name = "txt_Platenumber";
            this.txt_Platenumber.Size = new System.Drawing.Size(204, 30);
            this.txt_Platenumber.TabIndex = 4;
            // 
            // txt_Capacity
            // 
            this.txt_Capacity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Capacity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Capacity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Capacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Capacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Capacity.Location = new System.Drawing.Point(222, 26);
            this.txt_Capacity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_Capacity.Name = "txt_Capacity";
            this.txt_Capacity.Size = new System.Drawing.Size(204, 30);
            this.txt_Capacity.TabIndex = 5;
            // 
            // txt_Color
            // 
            this.txt_Color.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.txt_Color.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Color.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txt_Color.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.txt_Color.Location = new System.Drawing.Point(438, 26);
            this.txt_Color.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.txt_Color.Name = "txt_Color";
            this.txt_Color.Size = new System.Drawing.Size(204, 30);
            this.txt_Color.TabIndex = 6;
            // 
            // cmb_Assigneddriver
            // 
            this.cmb_Assigneddriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.cmb_Assigneddriver.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmb_Assigneddriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_Assigneddriver.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmb_Assigneddriver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(232)))), ((int)(((byte)(240)))));
            this.cmb_Assigneddriver.FormattingEnabled = true;
            this.cmb_Assigneddriver.Location = new System.Drawing.Point(654, 26);
            this.cmb_Assigneddriver.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cmb_Assigneddriver.Name = "cmb_Assigneddriver";
            this.cmb_Assigneddriver.Size = new System.Drawing.Size(205, 31);
            this.cmb_Assigneddriver.TabIndex = 7;
            this.cmb_Assigneddriver.SelectedIndexChanged += new System.EventHandler(this.cmb_Assigneddriver_SelectedIndexChanged);
            // 
            // pnl_TopBar
            // 
            this.pnl_TopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.pnl_TopBar.Controls.Add(this.btn_Managedrivers);
            this.pnl_TopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_TopBar.Location = new System.Drawing.Point(20, 0);
            this.pnl_TopBar.Name = "pnl_TopBar";
            this.pnl_TopBar.Size = new System.Drawing.Size(893, 10);
            this.pnl_TopBar.TabIndex = 14;
            // 
            // btn_Managedrivers
            // 
            this.btn_Managedrivers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Managedrivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(92)))), ((int)(((byte)(246)))));
            this.btn_Managedrivers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Managedrivers.FlatAppearance.BorderSize = 0;
            this.btn_Managedrivers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(119)))), ((int)(((byte)(252)))));
            this.btn_Managedrivers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Managedrivers.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Managedrivers.ForeColor = System.Drawing.Color.White;
            this.btn_Managedrivers.Location = new System.Drawing.Point(1433, 10);
            this.btn_Managedrivers.Name = "btn_Managedrivers";
            this.btn_Managedrivers.Size = new System.Drawing.Size(160, 36);
            this.btn_Managedrivers.TabIndex = 1;
            this.btn_Managedrivers.Text = "👤  Manage Drivers";
            this.btn_Managedrivers.UseVisualStyleBackColor = false;
            this.btn_Managedrivers.Click += new System.EventHandler(this.btn_Managedrivers_Click);
            // 
            // Fleet_and_Drivers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(23)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(933, 660);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.pnl_Main);
            this.Controls.Add(this.pnl_Divider);
            this.Controls.Add(this.pnl_Header);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(720, 520);
            this.Name = "Fleet_and_Drivers";
            this.Text = "Fleet & Drivers";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fleet_and_Drivers_FormClosed);
            this.Load += new System.EventHandler(this.Fleet_and_Drivers_Load);
            this.pnl_Header.ResumeLayout(false);
            this.pnl_Header.PerformLayout();
            this.pnl_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Fleet)).EndInit();
            this.pnl_Actions.ResumeLayout(false);
            this.pnl_FormCard.ResumeLayout(false);
            this.tbl_Fields.ResumeLayout(false);
            this.tbl_Fields.PerformLayout();
            this.pnl_TopBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Header;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_Subtitle;
        private System.Windows.Forms.Panel pnl_Divider;
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_TopBar;
        private System.Windows.Forms.Panel pnl_FormCard;
        private System.Windows.Forms.TableLayoutPanel tbl_Fields;
        private System.Windows.Forms.Panel pnl_Actions;
        private System.Windows.Forms.DataGridView dgv_Fleet;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_Managedrivers;
        private System.Windows.Forms.Label labelplate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_Platenumber;
        private System.Windows.Forms.TextBox txt_Capacity;
        private System.Windows.Forms.TextBox txt_Color;
        private System.Windows.Forms.ComboBox cmb_Assigneddriver;
        private System.Windows.Forms.Button btn_Addbus;
        private System.Windows.Forms.Button btn_Updatebus;
        private System.Windows.Forms.Button btn_Deletebus;
        private System.Windows.Forms.Button button2;
    }
}