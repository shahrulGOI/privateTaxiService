using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrivateHire_Cars_System.myclass;
using System.Windows.Forms;

namespace PrivateHire_Cars_System
{
    public partial class AdminCheck : Form
    {
        private DataTable dt;
        private Database db;
    
        public AdminCheck()
        {
            InitializeComponent();
            Hint();
            userLabel.Text = Check.currentUser;
            if (Check.currentUser == "ADMIN")
            {
                regButton.Visible = true;
                cabButton.Visible = true;
                myBookingButton.Enabled = false;
                verifyButton.Visible = true;
            }
            else
            {
                regButton.Visible = false;
                cabButton.Visible = false;
                myBookingButton.Enabled = true;
                verifyButton.Visible = false;
            }
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please enter the customer name!");
            }
            else
            { 
                db = new Database();
                dt = new DataTable();
                Check.verifyEmail= nameTextBox.Text;
               
                cusDataGridView.DataSource = db.getCustomerList(Check.verifyEmail);
                cusDataGridView.Columns[0].HeaderText = "Index";
                cusDataGridView.Columns[1].HeaderText = "Name";
                cusDataGridView.Columns[2].HeaderText = "Email";
                cusDataGridView.Columns[3].HeaderText = "Contact.No";
                cusDataGridView.Columns[4].HeaderText = "Gender";
            }

        }

        private void cDCButton_Click(object sender, EventArgs e)
        {
            if (dcComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select the size of minicab.");
            }
            else
            {
                db = new Database();
                dt = new DataTable();
                Check.verifyCab = Int32.Parse(dcComboBox.SelectedItem.ToString());
                  
                
                dcDataGridView.DataSource = db.getDriverCab(Check.verifyCab);
                dcDataGridView.Columns[0].HeaderText = "Index";
                dcDataGridView.Columns[1].HeaderText = "Name";
                dcDataGridView.Columns[2].HeaderText = "Gender";
                dcDataGridView.Columns[3].HeaderText = "MiniCab Brand";
                dcDataGridView.Columns[4].HeaderText = "MiniCab Colour";
                dcDataGridView.Columns[5].HeaderText = "MiniCab Plate";
                dcDataGridView.Columns[6].HeaderText = "MiniCab Size";
                dcDataGridView.Columns[7].HeaderText = "MiniCab Price";
            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button b = new Button();
            b.HomeBtn(this);
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.LogOutBtn(this);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.checkBtn(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
            
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.regBtn(this);
        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.EnquiryBtn(this);
        }

        public void Hint()
        {   //display the hint of textbox.
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Search by email";
                nameTextBox.ForeColor = Color.Silver;
            }
        }

        private void cabButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.cabBtn(this);
        }

        private void nameTextBox_Leave(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "")
            {
                nameTextBox.Text = "Search by email";
                nameTextBox.ForeColor = Color.Silver;
            }
        }

        private void nameTextBox_Enter(object sender, EventArgs e)
        {
            if (nameTextBox.Text == "Search by email")
            {
                nameTextBox.Text = "";
                nameTextBox.ForeColor = Color.Black;
            }
        }
    }
}
