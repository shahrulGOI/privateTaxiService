namespace PrivateHire_Cars_System
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerLinkLabel = new System.Windows.Forms.LinkLabel();
            this.exitButton = new System.Windows.Forms.Button();
            this.pwTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(537, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.registerLinkLabel);
            this.panel1.Controls.Add(this.exitButton);
            this.panel1.Controls.Add(this.pwTextBox);
            this.panel1.Controls.Add(this.emailTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 322);
            this.panel1.TabIndex = 1;
            // 
            // registerLinkLabel
            // 
            this.registerLinkLabel.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.registerLinkLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerLinkLabel.LinkColor = System.Drawing.SystemColors.HighlightText;
            this.registerLinkLabel.Location = new System.Drawing.Point(3, 130);
            this.registerLinkLabel.Name = "registerLinkLabel";
            this.registerLinkLabel.Size = new System.Drawing.Size(293, 33);
            this.registerLinkLabel.TabIndex = 5;
            this.registerLinkLabel.TabStop = true;
            this.registerLinkLabel.Text = "Click here to register account";
            this.registerLinkLabel.VisitedLinkColor = System.Drawing.Color.Silver;
            this.registerLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.registerLinkLabel_LinkClicked);
            // 
            // exitButton
            // 
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(153, 253);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(224, 51);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // pwTextBox
            // 
            this.pwTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.pwTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.pwTextBox.Location = new System.Drawing.Point(119, 64);
            this.pwTextBox.Multiline = true;
            this.pwTextBox.Name = "pwTextBox";
            this.pwTextBox.Size = new System.Drawing.Size(333, 36);
            this.pwTextBox.TabIndex = 4;
            this.pwTextBox.Text = "Enter your password";
            this.pwTextBox.Enter += new System.EventHandler(this.pwTextBox_Enter);
            this.pwTextBox.Leave += new System.EventHandler(this.pwTextBox_Leave);
            // 
            // emailTextBox
            // 
            this.emailTextBox.AccessibleDescription = "";
            this.emailTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.emailTextBox.Location = new System.Drawing.Point(119, 17);
            this.emailTextBox.Multiline = true;
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(333, 36);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.Tag = "";
            this.emailTextBox.Text = "Enter your email";
            this.emailTextBox.Enter += new System.EventHandler(this.emailTextBox_Enter);
            this.emailTextBox.Leave += new System.EventHandler(this.emailTextBox_Leave);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(4, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // loginButton
            // 
            this.loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Salmon;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.Location = new System.Drawing.Point(153, 186);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(224, 51);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "Sign In";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Firebrick;
            this.topPanel.Controls.Add(this.label4);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(537, 35);
            this.topPanel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(525, 35);
            this.label4.TabIndex = 0;
            this.label4.Text = "PrivateHire Car System";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(537, 517);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox pwTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.LinkLabel registerLinkLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label label4;
    }
}