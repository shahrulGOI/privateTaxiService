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
    public partial class Home : Form
    {
        public string user;

        public Home()
        {
            InitializeComponent();
            userLabel.Text = Check.currentUser;
            if (Check.currentUser == "ADMIN")
            {
                regButton.Visible = true;
                cabButton.Visible = true;
                myBookingButton.Enabled = false;
                verifyButton.Visible = true;
                customerEmailTextBox.Visible = true;
                label3.Visible = true;

            }
            else
            {
                regButton.Visible = false;
                cabButton.Visible = false;
                myBookingButton.Enabled = true;
                verifyButton.Visible = false;
                customerEmailTextBox.Visible = false;
                label3.Visible = false;

            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
        }

        private void taxiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pickLabel.Visible = true;
            pickPanel.Visible = true;
            dropLabel.Visible = true;
            generalDropPanel.Visible = true;
            if (Check.currentUser == "ADMIN")
            {
                proceedButton.Visible = false;
                staffProceedButton.Visible = true;
            }
            else
            {
                staffProceedButton.Visible = false;
                proceedButton.Visible = true;
            }

            if (taxiComboBox.SelectedIndex == 0)
            {
                dCityComboBox.Items.Add("Sepang");
                dPComboBox.Items.Add("64000");
                pCityComboBox.Items.Add("Sepang");
                pPostComboBox.Items.Add("64000");
            }
            else
            {
                dCityComboBox.Items.Remove("Sepang");
                dPComboBox.Items.Remove("64000");
                pCityComboBox.Items.Remove("Sepang");
                pPostComboBox.Items.Remove("64000");
            }
        }


        private void logOutButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.LogOutBtn(this);
        }

        private void myBookingButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this page?", "Leave Page",
        MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                Button b = new Button();
                b.MyBookingBtn(this);
            }
        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this page?", "Leave Page",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            else
            {
                Button b = new Button();
                b.EnquiryBtn(this);
            }
        }

        private void proceedButton_Click(object sender, EventArgs e)
        {
            if (pAdressTextBox.Text == String.Empty || dAdressTextBox.Text == String.Empty ||
                pPostComboBox.SelectedIndex < 0 || pCityComboBox.SelectedIndex < 0 ||
                pStateComboBox.SelectedIndex < 0 || dCityComboBox.SelectedIndex < 0 ||
                dPComboBox.SelectedIndex < 0 || dSComboBox.SelectedIndex < 0 )
            {
                    MessageBox.Show("All field are required to fill in!");
            }
            else
            {
                Check.pickAdd = pAdressTextBox.Text + ", " + pPostComboBox.SelectedItem.ToString() + ", " +
                 pCityComboBox.SelectedItem.ToString() + ", " + pStateComboBox.SelectedItem.ToString();
                Check.dropAdd = dAdressTextBox.Text + ", " + dPComboBox.SelectedItem.ToString() + ", " +
                dCityComboBox.SelectedItem.ToString() + ", " + dSComboBox.SelectedItem.ToString();

                Check.taxiType = taxiComboBox.SelectedItem.ToString();
                Check.b_cabType = Check.taxiType;

                Check.getTotalprice();

                Check.b_carFee = Check.basePrice;

                Check.subTotal = Check.b_carFee;

                //creating an object for new booking
                NewBooking n = new NewBooking();
                //pass the item index for taxi type through method
                n.TaxiCBValue = taxiComboBox.SelectedIndex;
                this.Hide();
                n.Show();
            }
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  //refresh the form
            this.Controls.Clear();
            InitializeComponent();
        }

        private void cabButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.cabBtn(this);
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.regBtn(this);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.checkBtn(this);
        }

        private void staffProceedButton_Click(object sender, EventArgs e)
        {
            string customer = Check.customerEmail;
            //check if there is empty field

            if (pAdressTextBox.Text == String.Empty || dAdressTextBox.Text == String.Empty ||
                pPostComboBox.SelectedIndex < 0 || pCityComboBox.SelectedIndex < 0 ||
                pStateComboBox.SelectedIndex < 0 || dCityComboBox.SelectedIndex < 0 ||
                dPComboBox.SelectedIndex < 0 || dSComboBox.SelectedIndex < 0 || customerEmailTextBox.Text == String.Empty)
            {
                MessageBox.Show("All field are required to fill in!");
            }
            else
            {
                Database db = new Database();
                bool valid = db.VerifyExistUser(customerEmailTextBox.Text);
                if (valid == true)
                {
                    Check.customerEmail = customerEmailTextBox.Text;
                    MessageBox.Show("Email is valid");
                    Check.pickAdd = pAdressTextBox.Text + ", " + pPostComboBox.SelectedItem.ToString() + ", " +
                    pCityComboBox.SelectedItem.ToString() + ", " + pStateComboBox.SelectedItem.ToString();
                    Check.dropAdd = dAdressTextBox.Text + ", " + dPComboBox.SelectedItem.ToString() + ", " +
                    dCityComboBox.SelectedItem.ToString() + ", " + dSComboBox.SelectedItem.ToString();

                    Check.taxiType = taxiComboBox.SelectedItem.ToString();
                    Check.b_cabType = Check.taxiType;

                    Check.getTotalprice();

                    Check.b_carFee = Check.basePrice;

                    Check.subTotal = Check.b_carFee;

                    //creating an object for new booking
                    NewBooking n = new NewBooking();
                    //pass the item index for taxi type through method
                    n.TaxiCBValue = taxiComboBox.SelectedIndex;
                    this.Hide();
                    n.Show();
                }
                else
                {
                    MessageBox.Show("Email is not valid, unable to process booking");
                    Check.customerEmail = "";
                }
            }
        }
    }
}
