using PrivateHire_Cars_System.myclass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateHire_Cars_System
{
    public partial class NewBooking : Form
    {
        //declare variables
        private string passengerNum, cabSize, service;
        private decimal cabFees, serviceFees;
        public NewBooking()
        {
            InitializeComponent();

            getCurrentUser();

            getCurrentBookingLocation();

            pickUpDate.MinDate = DateTime.Today;
            pickUpTime.MinDate = DateTime.Today;
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
        public void getCurrentUser()
        {
            userLabel.Text = Check.currentUser;
        }

        public void getCurrentBookingLocation()
        {
            pickUpLabel.Text = Check.pickAdd;
            dropOffLabel.Text = Check.dropAdd;
        }

        public int TaxiCBValue { get; set; }

        private void NewBooking_Load(object sender, EventArgs e)
        {
            //add services depend on the type of taxi selected
            if (TaxiCBValue == 0)
            {
                serviceComboBox.Items.Add("Airport and Hotel Transfers");
                serviceComboBox.Items.Add("Meet and Greet at Airports");
            }
            else
            {
                serviceComboBox.Items.Add("Local Area Journeys");
                serviceComboBox.Items.Add("Long Distance Journeys");
                serviceComboBox.Items.Add("Driver and Car for Daily Hire");
            }
        }

        private void cabComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {                  
            if (cabComboBox.SelectedItem.ToString() == "4")
            {
                cabFees = 35.00m;
            }

            else if (cabComboBox.SelectedItem.ToString() == "7")
            {
                cabFees = 55.00m;
            }

            else
            { 
                cabFees = 60.00m;
            }

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            Home h = new Home();
            h.Show();
        }

        private void tbsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Check.b_extraService = "Text Back Service";
            Check.b_extraServiceFee = 0.25m;
            Check.b_extraServiceFee = Math.Truncate(Check.b_extraServiceFee * 100) / 100;
        }

        private void cbsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Check.b_extraService = "Call Back Service";
            Check.b_extraServiceFee = 1.00m;
            Check.b_extraServiceFee = Math.Truncate(Check.b_extraServiceFee * 100) / 100;
        }

        private void emailRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Check.b_extraService = "Email Service";
            Check.b_extraServiceFee = 0m;
            Check.b_extraServiceFee = Math.Truncate(Check.b_extraServiceFee * 100) / 100;

        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.checkBtn(this);
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            Button b = new Button();
            b.LogOutBtn(this);
        }

        private void myBookingButton_Click_1(object sender, EventArgs e)
        {
            Button b = new Button();
            b.MyBookingBtn(this);
        }

        private void enquiryButton_Click_1(object sender, EventArgs e)
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

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {   //return to home
            this.DialogResult = DialogResult.OK;
        }

        private void serviceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookingPanel.Visible = true;
            proceedButton.Visible = true;

            if (serviceComboBox.SelectedItem.ToString() == "Airport and Hotel Transfers")
            {
                Check.b_tripType = "Airport and Hotel Transfers";
                serviceFees= 50m;
            }

            else if (serviceComboBox.SelectedItem.ToString() == "Meet and Greet at Airports")
            {
                Check.b_tripType = "Meet and Greet at Airports";
                serviceFees = 25m;
            }

            else if (serviceComboBox.SelectedItem.ToString() == "Local Area Journeys")
            {
                Check.b_tripType = "Local Area Journeys";
                serviceFees = 15m;
            }

            else if (serviceComboBox.SelectedItem.ToString() == "Long Distance Journeys")
            {
                Check.b_tripType = "Long Distance Journeys";
                serviceFees = 30m;
            }

            else if (serviceComboBox.SelectedItem.ToString() == "Driver and Car for Daily Hire")
            {
                Check.b_tripType = "Driver and Car for Daily Hire";
                serviceFees = 60m;

            }

        }

        private void proceedButton_Click(object sender, EventArgs e)
        {

            //check if user did not select anything
            if ( peopleComboBox.SelectedIndex < 0 || cabComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please make sure everything is set.", "Adding Failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                Focus();
            }
            else
            {              
                DateTime date = pickUpDate.Value.Date + pickUpTime.Value.TimeOfDay;
                passengerNum = peopleComboBox.SelectedItem.ToString();
                cabSize = cabComboBox.SelectedItem.ToString();
                service = serviceComboBox.SelectedItem.ToString();

                if (MessageBox.Show("Are you confirm to add this booking?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Check.b_service = serviceComboBox.SelectedItem.ToString();
                    Check.b_pickupDate = date;

                    Check.b_numOfPpl = Int32.Parse(peopleComboBox.SelectedItem.ToString());
                    Check.b_cabSize = Int32.Parse(cabComboBox.SelectedItem.ToString());

                    Check.subTotal += cabFees + Check.b_extraServiceFee + serviceFees;
                    Check.b_tripFare += serviceFees + cabFees;

                    Check.totalPrice = Check.subTotal;
                    Check.totalPrice = Math.Round(Check.totalPrice * 100) / 100;

                    Check.b_status = "Pending";
                    Check.b_createDate = DateTime.Today.Date;

                    var b = new PaymentDetail();
                    this.Hide();
                    b.Show();
                }
                else
                {
                    return;
                }
            }
        }
    }
}
