namespace PrivateHire_Cars_System
{
    partial class MyBooking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.journeyButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.statusButton = new System.Windows.Forms.Button();
            this.recordDataGridView = new System.Windows.Forms.DataGridView();
            this.viewButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.userLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.verifyButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cabButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            this.homePanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.homeLinkLabel = new System.Windows.Forms.LinkLabel();
            this.enquiryButton = new System.Windows.Forms.Button();
            this.regButton = new System.Windows.Forms.Button();
            this.myBookingButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).BeginInit();
            this.topPanel.SuspendLayout();
            this.sidePanel.SuspendLayout();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(163, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(356, 63);
            this.label11.TabIndex = 25;
            this.label11.Text = "My Booking Records";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusComboBox
            // 
            this.statusComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Completed",
            "Pending"});
            this.statusComboBox.Location = new System.Drawing.Point(164, 137);
            this.statusComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(259, 29);
            this.statusComboBox.Sorted = true;
            this.statusComboBox.TabIndex = 27;
            this.statusComboBox.Text = "Select Booking Status";
            // 
            // journeyButton
            // 
            this.journeyButton.BackColor = System.Drawing.Color.Pink;
            this.journeyButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.journeyButton.FlatAppearance.BorderSize = 0;
            this.journeyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.journeyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.journeyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.journeyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.journeyButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.journeyButton.ForeColor = System.Drawing.Color.Black;
            this.journeyButton.Location = new System.Drawing.Point(784, 188);
            this.journeyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.journeyButton.Name = "journeyButton";
            this.journeyButton.Size = new System.Drawing.Size(177, 43);
            this.journeyButton.TabIndex = 30;
            this.journeyButton.Text = "Journey Complete";
            this.journeyButton.UseVisualStyleBackColor = false;
            this.journeyButton.Visible = false;
            this.journeyButton.Click += new System.EventHandler(this.journeyButton_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(169, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(829, 170);
            this.label3.TabIndex = 33;
            this.label3.Text = "There is no record yet.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusButton
            // 
            this.statusButton.BackColor = System.Drawing.Color.FloralWhite;
            this.statusButton.FlatAppearance.BorderSize = 0;
            this.statusButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.statusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.statusButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.statusButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusButton.ForeColor = System.Drawing.Color.Black;
            this.statusButton.Location = new System.Drawing.Point(455, 130);
            this.statusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.statusButton.Name = "statusButton";
            this.statusButton.Size = new System.Drawing.Size(204, 43);
            this.statusButton.TabIndex = 35;
            this.statusButton.Text = "Check Status";
            this.statusButton.UseVisualStyleBackColor = false;
            this.statusButton.Click += new System.EventHandler(this.statusButton_Click);
            // 
            // recordDataGridView
            // 
            this.recordDataGridView.AllowUserToAddRows = false;
            this.recordDataGridView.AllowUserToDeleteRows = false;
            this.recordDataGridView.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.recordDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.recordDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.recordDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.recordDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.recordDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.recordDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.recordDataGridView.Location = new System.Drawing.Point(164, 249);
            this.recordDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.recordDataGridView.MultiSelect = false;
            this.recordDataGridView.Name = "recordDataGridView";
            this.recordDataGridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FloralWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.recordDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.recordDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.OldLace;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.recordDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.recordDataGridView.RowTemplate.Height = 24;
            this.recordDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.recordDataGridView.Size = new System.Drawing.Size(835, 426);
            this.recordDataGridView.TabIndex = 37;
            this.recordDataGridView.Visible = false;
            this.recordDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordDataGridView_CellContentClick);
            // 
            // viewButton
            // 
            this.viewButton.BackColor = System.Drawing.Color.Pink;
            this.viewButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.viewButton.FlatAppearance.BorderSize = 0;
            this.viewButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.viewButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.viewButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.viewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.viewButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.Black;
            this.viewButton.Location = new System.Drawing.Point(163, 190);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(177, 43);
            this.viewButton.TabIndex = 38;
            this.viewButton.Text = "View Details";
            this.viewButton.UseVisualStyleBackColor = false;
            this.viewButton.Visible = false;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // printButton
            // 
            this.printButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.printButton.FlatAppearance.BorderSize = 0;
            this.printButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.printButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.printButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.ForeColor = System.Drawing.Color.White;
            this.printButton.Location = new System.Drawing.Point(783, 94);
            this.printButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(177, 43);
            this.printButton.TabIndex = 39;
            this.printButton.Text = "Print Receipt";
            this.printButton.UseVisualStyleBackColor = false;
            this.printButton.Visible = false;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Pink;
            this.cancelButton.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.cancelButton.FlatAppearance.BorderSize = 0;
            this.cancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.cancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(575, 188);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(177, 46);
            this.cancelButton.TabIndex = 40;
            this.cancelButton.Text = "Cancel Booking";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Firebrick;
            this.topPanel.Controls.Add(this.userLabel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(157, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(856, 71);
            this.topPanel.TabIndex = 42;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.userLabel.Location = new System.Drawing.Point(623, 32);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(79, 20);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "userLabel";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "PrivateHire Car System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidePanel.Controls.Add(this.verifyButton);
            this.sidePanel.Controls.Add(this.exitButton);
            this.sidePanel.Controls.Add(this.cabButton);
            this.sidePanel.Controls.Add(this.logOutButton);
            this.sidePanel.Controls.Add(this.homePanel);
            this.sidePanel.Controls.Add(this.enquiryButton);
            this.sidePanel.Controls.Add(this.regButton);
            this.sidePanel.Controls.Add(this.myBookingButton);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(157, 687);
            this.sidePanel.TabIndex = 41;
            // 
            // verifyButton
            // 
            this.verifyButton.FlatAppearance.BorderSize = 0;
            this.verifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.verifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.verifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Location = new System.Drawing.Point(-3, 512);
            this.verifyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.Size = new System.Drawing.Size(159, 62);
            this.verifyButton.TabIndex = 12;
            this.verifyButton.Text = "Verify Cab Status";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(-3, 580);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(159, 62);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cabButton
            // 
            this.cabButton.FlatAppearance.BorderSize = 0;
            this.cabButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cabButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.cabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cabButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cabButton.ForeColor = System.Drawing.Color.White;
            this.cabButton.Location = new System.Drawing.Point(-1, 430);
            this.cabButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cabButton.Name = "cabButton";
            this.cabButton.Size = new System.Drawing.Size(159, 76);
            this.cabButton.TabIndex = 11;
            this.cabButton.Text = "Add Driver and Cab";
            this.cabButton.UseVisualStyleBackColor = true;
            this.cabButton.Visible = false;
            this.cabButton.Click += new System.EventHandler(this.cabButton_Click);
            // 
            // logOutButton
            // 
            this.logOutButton.FlatAppearance.BorderSize = 0;
            this.logOutButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.logOutButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.logOutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOutButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOutButton.ForeColor = System.Drawing.Color.White;
            this.logOutButton.Location = new System.Drawing.Point(-1, 158);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(159, 62);
            this.logOutButton.TabIndex = 10;
            this.logOutButton.Text = "Log Out";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // homePanel
            // 
            this.homePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.homePanel.Controls.Add(this.pictureBox2);
            this.homePanel.Controls.Add(this.homeLinkLabel);
            this.homePanel.Location = new System.Drawing.Point(0, 0);
            this.homePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(157, 108);
            this.homePanel.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = global::PrivateHire_Cars_System.Properties.Resources.Car_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(157, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // homeLinkLabel
            // 
            this.homeLinkLabel.ActiveLinkColor = System.Drawing.Color.Blue;
            this.homeLinkLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.homeLinkLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.homeLinkLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.homeLinkLabel.LinkColor = System.Drawing.Color.White;
            this.homeLinkLabel.Location = new System.Drawing.Point(0, 73);
            this.homeLinkLabel.Name = "homeLinkLabel";
            this.homeLinkLabel.Size = new System.Drawing.Size(155, 33);
            this.homeLinkLabel.TabIndex = 9;
            this.homeLinkLabel.TabStop = true;
            this.homeLinkLabel.Text = "Home";
            this.homeLinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLinkLabel.VisitedLinkColor = System.Drawing.Color.White;
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked);
            // 
            // enquiryButton
            // 
            this.enquiryButton.FlatAppearance.BorderSize = 0;
            this.enquiryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enquiryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.enquiryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enquiryButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryButton.ForeColor = System.Drawing.Color.White;
            this.enquiryButton.Location = new System.Drawing.Point(-1, 294);
            this.enquiryButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.enquiryButton.Name = "enquiryButton";
            this.enquiryButton.Size = new System.Drawing.Size(159, 62);
            this.enquiryButton.TabIndex = 6;
            this.enquiryButton.Text = "Enquiry";
            this.enquiryButton.UseVisualStyleBackColor = true;
            this.enquiryButton.Click += new System.EventHandler(this.enquiryButton_Click);
            // 
            // regButton
            // 
            this.regButton.FlatAppearance.BorderSize = 0;
            this.regButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.regButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.regButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.regButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regButton.ForeColor = System.Drawing.Color.White;
            this.regButton.Location = new System.Drawing.Point(-1, 362);
            this.regButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(159, 62);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Register Customer";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Visible = false;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // myBookingButton
            // 
            this.myBookingButton.BackColor = System.Drawing.Color.Orange;
            this.myBookingButton.Enabled = false;
            this.myBookingButton.FlatAppearance.BorderSize = 0;
            this.myBookingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myBookingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.myBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBookingButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBookingButton.ForeColor = System.Drawing.Color.White;
            this.myBookingButton.Location = new System.Drawing.Point(-1, 226);
            this.myBookingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.myBookingButton.Name = "myBookingButton";
            this.myBookingButton.Size = new System.Drawing.Size(159, 62);
            this.myBookingButton.TabIndex = 5;
            this.myBookingButton.Text = "My Booking";
            this.myBookingButton.UseVisualStyleBackColor = false;
            this.myBookingButton.Click += new System.EventHandler(this.myBookingButton_Click);
            // 
            // MyBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.journeyButton);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.recordDataGridView);
            this.Controls.Add(this.statusButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBooking";
            ((System.ComponentModel.ISupportInitialize)(this.recordDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button journeyButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button statusButton;
        private System.Windows.Forms.DataGridView recordDataGridView;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button cabButton;
        private System.Windows.Forms.Button logOutButton;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel homeLinkLabel;
        private System.Windows.Forms.Button enquiryButton;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Button myBookingButton;
    }
}