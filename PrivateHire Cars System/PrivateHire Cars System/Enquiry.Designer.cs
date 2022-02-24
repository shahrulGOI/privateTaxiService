namespace PrivateHire_Cars_System
{
    partial class Enquiry
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label11 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.enquiryTextBox = new System.Windows.Forms.RichTextBox();
            this.enquiryDataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.replyButton = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDataGridView)).BeginInit();
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
            this.label11.Size = new System.Drawing.Size(241, 63);
            this.label11.TabIndex = 24;
            this.label11.Text = "Enquiry";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "General Enquiry",
            "Trip Enquiry"});
            this.typeComboBox.Location = new System.Drawing.Point(169, 155);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(257, 29);
            this.typeComboBox.TabIndex = 25;
            this.typeComboBox.Text = "Select type of enquiry";
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.addButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.Location = new System.Drawing.Point(842, 629);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(159, 47);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add Enquiry";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Visible = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // enquiryTextBox
            // 
            this.enquiryTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.enquiryTextBox.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryTextBox.Location = new System.Drawing.Point(169, 491);
            this.enquiryTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.enquiryTextBox.Name = "enquiryTextBox";
            this.enquiryTextBox.Size = new System.Drawing.Size(831, 132);
            this.enquiryTextBox.TabIndex = 0;
            this.enquiryTextBox.Text = "";
            this.enquiryTextBox.Visible = false;
            // 
            // enquiryDataGridView
            // 
            this.enquiryDataGridView.AllowUserToAddRows = false;
            this.enquiryDataGridView.AllowUserToDeleteRows = false;
            this.enquiryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.enquiryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.enquiryDataGridView.BackgroundColor = System.Drawing.Color.FloralWhite;
            this.enquiryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.enquiryDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.enquiryDataGridView.Location = new System.Drawing.Point(170, 203);
            this.enquiryDataGridView.MultiSelect = false;
            this.enquiryDataGridView.Name = "enquiryDataGridView";
            this.enquiryDataGridView.ReadOnly = true;
            this.enquiryDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.enquiryDataGridView.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.AntiqueWhite;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.enquiryDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.enquiryDataGridView.RowTemplate.Height = 24;
            this.enquiryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.enquiryDataGridView.Size = new System.Drawing.Size(830, 189);
            this.enquiryDataGridView.TabIndex = 30;
            this.enquiryDataGridView.Visible = false;
            this.enquiryDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.enquiryDataGridView_CellContentClick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(164, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 63);
            this.label2.TabIndex = 31;
            this.label2.Text = "Add Your Question Here:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(170, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(830, 170);
            this.label3.TabIndex = 32;
            this.label3.Text = "There is no enquiry yet.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // replyButton
            // 
            this.replyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.replyButton.FlatAppearance.BorderSize = 0;
            this.replyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.replyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.replyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.replyButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replyButton.ForeColor = System.Drawing.Color.White;
            this.replyButton.Location = new System.Drawing.Point(177, 629);
            this.replyButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.replyButton.Name = "replyButton";
            this.replyButton.Size = new System.Drawing.Size(159, 47);
            this.replyButton.TabIndex = 34;
            this.replyButton.Text = "Add Reply";
            this.replyButton.UseVisualStyleBackColor = false;
            this.replyButton.Visible = false;
            this.replyButton.Click += new System.EventHandler(this.replyButton_Click);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Firebrick;
            this.topPanel.Controls.Add(this.userLabel);
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(157, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(856, 71);
            this.topPanel.TabIndex = 36;
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
            this.label1.Size = new System.Drawing.Size(610, 71);
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
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(157, 687);
            this.sidePanel.TabIndex = 35;
            // 
            // verifyButton
            // 
            this.verifyButton.FlatAppearance.BorderSize = 0;
            this.verifyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.verifyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.verifyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verifyButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verifyButton.ForeColor = System.Drawing.Color.White;
            this.verifyButton.Location = new System.Drawing.Point(-2, 512);
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
            this.exitButton.Location = new System.Drawing.Point(-2, 580);
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
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(157, 108);
            this.homePanel.TabIndex = 9;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox2.Image = global::PrivateHire_Cars_System.Properties.Resources.Car_Logo;
            this.pictureBox2.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 71);
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
            this.homeLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.homeLinkLabel_LinkClicked_1);
            // 
            // enquiryButton
            // 
            this.enquiryButton.BackColor = System.Drawing.Color.Orange;
            this.enquiryButton.Enabled = false;
            this.enquiryButton.FlatAppearance.BorderSize = 0;
            this.enquiryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.enquiryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.enquiryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enquiryButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquiryButton.ForeColor = System.Drawing.Color.White;
            this.enquiryButton.Location = new System.Drawing.Point(-1, 294);
            this.enquiryButton.Name = "enquiryButton";
            this.enquiryButton.Size = new System.Drawing.Size(159, 62);
            this.enquiryButton.TabIndex = 6;
            this.enquiryButton.Text = "Enquiry";
            this.enquiryButton.UseVisualStyleBackColor = false;
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
            this.myBookingButton.FlatAppearance.BorderSize = 0;
            this.myBookingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.myBookingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.myBookingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myBookingButton.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.myBookingButton.ForeColor = System.Drawing.Color.White;
            this.myBookingButton.Location = new System.Drawing.Point(-1, 226);
            this.myBookingButton.Name = "myBookingButton";
            this.myBookingButton.Size = new System.Drawing.Size(159, 62);
            this.myBookingButton.TabIndex = 5;
            this.myBookingButton.Text = "My Booking";
            this.myBookingButton.UseVisualStyleBackColor = true;
            this.myBookingButton.Click += new System.EventHandler(this.myBookingButton_Click);
            // 
            // Enquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1013, 687);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.replyButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.enquiryDataGridView);
            this.Controls.Add(this.enquiryTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label11);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Enquiry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Enquiry";
            ((System.ComponentModel.ISupportInitialize)(this.enquiryDataGridView)).EndInit();
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.sidePanel.ResumeLayout(false);
            this.homePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox enquiryTextBox;
        private System.Windows.Forms.DataGridView enquiryDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button replyButton;
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