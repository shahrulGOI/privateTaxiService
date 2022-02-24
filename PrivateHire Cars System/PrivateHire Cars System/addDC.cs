using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrivateHire_Cars_System.myclass;

namespace PrivateHire_Cars_System
{
    public partial class addDC : Form
    {
        Database db = new Database();
        public addDC()
        {
            InitializeComponent();
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

        private void addButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text == string.Empty || plateTextBox.Text == string.Empty ||
                genderComboBox.SelectedIndex < 0 || priceComboBox.SelectedIndex < 0 ||
                brandComboBox.SelectedIndex < 0 || colourComboBox.SelectedIndex < 0 ||
                sizeCombo.SelectedIndex < 0)
            {
                MessageBox.Show("All fields are required to fill in.");
            }

            else
            {
                if (MessageBox.Show("Are you sure you want the data entered is correct?", "Enter Driver",
                     MessageBoxButtons.YesNo) != DialogResult.Yes)
                {
                    return;
                }
                else
                {
                    //check if driver is existing in database
                    bool valid = db.VerifyDriverCab(plateTextBox.Text);
                    if (valid == true)
                    {
                        MessageBox.Show("The car plate has been used!");
                    }
                    else
                    {
                        db.d_name = nameTextBox.Text;
                        db.d_gender = genderComboBox.Text;
                        db.cab_brand = brandComboBox.Text;
                        db.cab_colour = colourComboBox.Text;
                        db.cab_plate = plateTextBox.Text;
                        db.cab_size = Int32.Parse(sizeCombo.Text);
                        db.cab_price = Int32.Parse(priceComboBox.Text);

                        db.create_driver();

                        addDC b = new addDC();
                        this.Close();
                        b.Show();
                    }
                }
            }
        }
        
        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button b = new Button();
            b.HomeBtn(this);
        }

        private void enquiryButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.EnquiryBtn(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
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

        private void regButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.regBtn(this);
        }

        private void myBookingButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.MyBookingBtn(this);
        }
    }
}
