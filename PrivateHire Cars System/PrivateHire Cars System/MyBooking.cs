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
    public partial class MyBooking : Form
    {
        Database db;
        private int id, driverID;
        private int index = -1;
        private Int32 selectedRowCount = -1;

        public MyBooking()
        {
            InitializeComponent();
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
            getCurrentUser();
        }

        public void getCurrentUser()
        {
            userLabel.Text = Check.currentUser;
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

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }
            else
                Application.Exit();
        }

        private void homeLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Button b = new Button();
            b.HomeBtn(this);
        }
        private void statusButton_Click(object sender, EventArgs e)
        {
            db = new Database();
            if (statusComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a booking status to view.");
            }
            else if (statusComboBox.SelectedItem.ToString() == "Pending")
            {
                bool valid = db.checkBooking(Check.currentUser, "Pending");
                //check if user have any booking status that is pending
                if (valid == true)
                {
                    label3.Visible = false;
                    printButton.Visible = true;
                    viewButton.Visible = true;
                    
                    journeyButton.Visible = true;
                    cancelButton.Visible = true;
                    recordDataGridView.Visible = true;
                    recordDataGridView.DataSource = (db.getBooking(Check.currentUser, "Pending"));
                    recordDataGridView.Columns[0].HeaderText = "Booking ID";
                    recordDataGridView.Columns[1].HeaderText = "Pick Up Location";
                    recordDataGridView.Columns[2].HeaderText = "Destination";
                    recordDataGridView.Columns[3].HeaderText = "Driver ID";
                    recordDataGridView.Columns[4].HeaderText = "Driver Name";
                    recordDataGridView.Columns[5].HeaderText = "Total Payment";
                    recordDataGridView.Columns[7].HeaderText = "Pick Up Date";
                    recordDataGridView.Columns[8].HeaderText = "Payment Type";
                }
                else
                {
                    label3.Visible = true;
                    printButton.Visible = false;
                    viewButton.Visible = false;
                    
                    cancelButton.Visible = false;
                    journeyButton.Visible = false;
                    recordDataGridView.Visible = false;
                }
            }
            else
            {
                bool valid = db.checkBooking(Check.currentUser, "Completed");
                if (valid == true)
                {
                    label3.Visible = false;
                    viewButton.Visible = true;
                    
                    cancelButton.Visible = false;
                    journeyButton.Visible = false;
                    recordDataGridView.Visible = true;
                    printButton.Visible = true;
                    recordDataGridView.DataSource = (db.getBooking(Check.currentUser, "Completed"));
                    recordDataGridView.Columns[0].HeaderText = "Booking ID";
                    recordDataGridView.Columns[1].HeaderText = "Pick Up Location";
                    recordDataGridView.Columns[2].HeaderText = "Destination";
                    recordDataGridView.Columns[3].HeaderText = "Driver ID";
                    recordDataGridView.Columns[4].HeaderText = "Driver Name";
                    recordDataGridView.Columns[5].HeaderText = "Total Payment";
                    recordDataGridView.Columns[7].HeaderText = "Pick Up Date";
                    recordDataGridView.Columns[8].HeaderText = "Payment Type";
                }
                else
                {
                    label3.Visible = true;
                    printButton.Visible = false;
                    viewButton.Visible = false;
                    
                    journeyButton.Visible = false;
                    cancelButton.Visible = false;
                    recordDataGridView.Visible = false;
                }
            }
        }

        private void journeyButton_Click(object sender, EventArgs e)
        {
            selectedRowCount = recordDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            {
                if (selectedRowCount > 0)
                { 
                    if (index >= 0 && statusComboBox.SelectedItem.ToString() == "Pending")
                    {
                        db.updateBookingStatus(id, "Completed");
                        DataTable dt = new DataTable();
                        dt = (db.getBooking(Check.currentUser, "Pending"));
                        recordDataGridView.DataSource = dt;
                        Rating r = new Rating(driverID);
                        if (dt.Rows.Count < 0)
                        {
                            label3.Visible = true;
                            recordDataGridView.Visible = false;
                            viewButton.Visible = false;
                            
                            journeyButton.Visible = false;
                            cancelButton.Visible = false;
                            printButton.Visible = false;
                        }
                        this.Hide();
                        r.ShowDialog();

                        //comes back when user finish rating
                        this.Show();
                        selectedRowCount = -1;
                        index = -1;
                    }
                    else
                    {
                        MessageBox.Show("Please click on the booking column for complete your journey!");
                    }
                }
            }
        }
        private void recordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) //if user click on cell
            {
                index = e.RowIndex;
                DataGridViewRow row = this.recordDataGridView.Rows[e.RowIndex];
                //convert to integer 
                id = Int32.Parse(row.Cells["b_id"].Value.ToString());
                driverID = Int32.Parse(row.Cells["d_id"].Value.ToString());
            }
        }
        private void printButton_Click(object sender, EventArgs e)
        {
            {          //get the row that user selecting
                selectedRowCount = recordDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                {
                    if (selectedRowCount < 0)
                    {
                        return;
                    }
                    else
                    {
                        if (index < 0)
                        {
                            MessageBox.Show("Please click on the booking column");
                        }
                        else
                        {
                            Receipt r = new Receipt(id);
                            this.Hide();
                            r.ShowDialog();
                            //
                            this.Show();
                        }
                    }
                }
            }
        }
        private void viewButton_Click(object sender, EventArgs e)
        {          //get the row that user selecting
            selectedRowCount = recordDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            {
                if (selectedRowCount < 0)
                {
                    return;
                }
                else
                {  
                    if (index < 0)
                    {
                        MessageBox.Show("Please click on the booking column");                        
                    }
                    else
                    {
                        //Assign data source to object d
                        DataGridView d = new DataGridView();
                        d.DataSource = (db.getRating(driverID));

                        //pass DataSource to next form
                        MyBookingDetail bd = new MyBookingDetail(d.DataSource);

                        DataTable table = new DataTable();
                        //getting detail of booking 
                        table = db.getBookingDetail(id, Check.currentUser);

                        bd.detailListView.Columns.Add("Booked Items");
                        bd.detailListView.Columns.Add("Item Details");

                        //to display vertically
                        foreach (DataColumn dataColumn in table.Columns)
                        {
                            ListViewItem item = bd.detailListView.Items.Add(dataColumn.ColumnName);
                            item.SubItems.Add(table.Rows[0][dataColumn.ColumnName].ToString());
                        }

                        this.Close();
                        bd.ShowDialog();
                        selectedRowCount = -1;
                        index = -1;
                    }
                }
            }
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
        private void verifyButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.checkBtn(this);
        }

        private void myBookingButton_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.MyBookingBtn(this);
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            selectedRowCount = recordDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            {
                if (selectedRowCount < 0)
                {
                    return;
                }
                else
                {
                    if (index < 0)
                    {
                        MessageBox.Show("Please click on the booking column");
                    }
                    else
                    {
                       if(MessageBox.Show("Are you confirm to cancel the booking?", "Booking Cancellation",
                            MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                        { 
                            db.cancelBooking(id);
                            bool valid = false;
                            db.VerifyBooking(id);
                            if(valid == true)
                            {
                                MessageBox.Show("Failure to cancel due to technical problems.");
                            }
                            else
                            {
                                MessageBox.Show("Your booking cancellation is successful.");
                                selectedRowCount = -1;
                                index = -1;

                                DataTable dt = (db.getBooking(Check.currentUser, "Pending"));
                                recordDataGridView.DataSource = dt;                               
                                if (dt.Rows.Count < 0)
                                {
                                    label3.Visible = true;
                                    recordDataGridView.Visible = false;
                                    viewButton.Visible = false;
                                    
                                    journeyButton.Visible = false;
                                    cancelButton.Visible = false;
                                    printButton.Visible = false;
                                }
                            }
                        }
                       else
                        {
                            return;
                        }
                    }
                }
            }
        }
    }
}

    
        

              
   
