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
    public partial class Enquiry : Form
    {
        Database db = new Database();
        private int index = -1;
        private int id;
        private Int32 selectedRowCount =-1;
        public Enquiry()
        {
            InitializeComponent();
            userLabel.Text = Check.currentUser;
            if (Check.currentUser == "ADMIN")
            {
                label2.Text = "Type Your Reply Here:";
                regButton.Visible = true;
                cabButton.Visible = true;
                myBookingButton.Enabled = false;
                verifyButton.Visible = true;
            }
            else
            {
                label2.Text = "Add Your Question Here:";
                regButton.Visible = false;
                cabButton.Visible = false;
                myBookingButton.Enabled = true;
                verifyButton.Visible = false;
            }

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (enquiryTextBox.Text == string.Empty)
            {
                MessageBox.Show("Please insert your question.");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want submit the enquiry?", "Confirm to Submit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    setEnquiry();
                    MessageBox.Show("Enquiry is successfully submitted.");
                }
                else
                {
                    return;
                }

                this.Hide();
                var b = new Enquiry();
                b.Closed += (s, args) => this.Close();
                b.Show();
            }
        }

        public void setEnquiry()
        {
            string str = "There is no reply yet";
            db.enquiry_type = typeComboBox.Text;
            db.enquiry_question = enquiryTextBox.Text;
            db.enquiry_reply = str;

            db.create_enquiry();
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this page?", "Leave",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                this.Hide();
                var b = new Home();
                b.Closed += (s, args) => this.Close();
                b.Show();
            }
        }

        private void myBookingButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to leave this page?", "Leave",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
            {
                var b = new MyBooking();
                b.Closed += (s, args) => this.Close();
                b.Show();
            }
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                var b = new Login();
                b.Closed += (s, args) => this.Close();
                b.Show();
            }
            else
            {
                return;
            }
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = -1;
            selectedRowCount = -1;
            label2.Visible = true;
            enquiryDataGridView.Visible = true;
            enquiryTextBox.Visible = true;
            label3.Visible = false;
            if (Check.currentUser == "ADMIN")
            {
                addButton.Visible = false;
                replyButton.Visible = true;
            }
            else
            {
                addButton.Visible = true;
                replyButton.Visible = false;
            }

            if (typeComboBox.SelectedIndex == 0) //general enquiry
            {
                string v = typeComboBox.SelectedItem.ToString();
                enquiryDataGridView.DataSource = db.getEnquiry(v);
                enquiryDataGridView.Columns[0].HeaderText = "Index";
                enquiryDataGridView.Columns[1].HeaderText = "Question";
                enquiryDataGridView.Columns[2].HeaderText = "Reply";

            }
            else
            {
                string v = typeComboBox.SelectedItem.ToString();
                enquiryDataGridView.DataSource = db.getEnquiry(v);
                enquiryDataGridView.Columns[0].HeaderText = "Index";
                enquiryDataGridView.Columns[1].HeaderText = "Question";
                enquiryDataGridView.Columns[2].HeaderText = "Reply";
            }
        }

        private void enquiryDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //if user click on cell
            {
                index = e.RowIndex;
                DataGridViewRow row = this.enquiryDataGridView.Rows[e.RowIndex];
                //convert to integer 
                id = Int32.Parse(row.Cells["enquiry_id"].Value.ToString());
            }
        }

        private void replyButton_Click(object sender, EventArgs e)
        {
            if (enquiryTextBox.Text != string.Empty)
            {
                selectedRowCount = enquiryDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                {
                    if (selectedRowCount < 0)
                    {
                        MessageBox.Show("Erm");
                    }
                    else
                    {
                        if (index < 0)
                        {
                            MessageBox.Show("Please click on the enquiry column");
                        }
                        else
                        {
                            db.reply_enquiry(enquiryTextBox.Text, id);
                            MessageBox.Show("Your reply is added successfully.");

                            this.Hide();
                            var b = new Enquiry();
                            b.Closed += (s, args) => this.Close();
                            b.Show();
                        }
                    }
                }
            }
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.LogOutBtn(this);
        }

        private void myBookingButton_Click(object sender, EventArgs e)
        {
          Button b = new Button();
          b.MyBookingBtn(this);

        }

        private void regButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.regBtn(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.ExitBtn();
        }

        private void cabButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.cabBtn(this);
        }

        private void verifyButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.checkBtn(this);
        }

        private void homeLinkLabel_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button b = new Button();
            b.HomeBtn(this);
        }
    }
}
