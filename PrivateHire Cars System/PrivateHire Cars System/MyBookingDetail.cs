using System;
using PrivateHire_Cars_System.myclass;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PrivateHire_Cars_System
{
    public partial class MyBookingDetail : Form
    {
        public MyBookingDetail(object Da)
        {
            InitializeComponent();
            Clear();
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
            cDataGridView.DataSource = Da;
            ViewComment();
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
        public void Clear()
        {
            detailListView.Items.Clear();
            detailListView.Columns.Clear();
        }

        private void backButton_Click(object sender, EventArgs e)
        {  //return back to MyBooking Form
            this.DialogResult = DialogResult.Yes;
            var b = new MyBooking();
            b.Closed += (s, args) => this.Close();
            b.Show();
        }

        public void ViewDetail()
        {
        }

        public void ViewComment()
        {
            cDataGridView.Columns[0].HeaderText = "Index";
            cDataGridView.Columns[1].HeaderText = "User";
            cDataGridView.Columns[2].HeaderText = "Driver ID";
            cDataGridView.Columns[3].HeaderText = "Driver Name";
            cDataGridView.Columns[4].HeaderText = "Driver Rating";
            cDataGridView.Columns[5].HeaderText = "Cab Rating";
            cDataGridView.Columns[6].HeaderText = "Comments";
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Home h = new Home();
            this.Close();
            h.Show();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.LogOutBtn(this);
        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.EnquiryBtn(this);
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.regBtn(this);

        }

        private void cabButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.cabBtn(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
        }

        private void myBookingButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.MyBookingBtn(this);
        }
    }
}
