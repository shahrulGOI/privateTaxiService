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
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {  //if user click on the textbox/ enter something.
            if (emailTextBox.Text == "Enter your email")
            {
                emailTextBox.Text = "";
                emailTextBox.ForeColor = Color.Black;
            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {  //if user is not entering anything.
            Hint();
        }

        private void pwTextBox_Enter(object sender, EventArgs e)
        {
            if (pwTextBox.Text == "Enter your password")
            {
                pwTextBox.Text = "";
                pwTextBox.PasswordChar = '*';
                pwTextBox.ForeColor = Color.Black;
            }
        }

        private void pwTextBox_Leave(object sender, EventArgs e)
        {
            Hint();
        }

        private void registerLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {  //Calling Register Form and close current form
            Register r = new Register();
            emailTextBox.Clear();
            pwTextBox.Clear();
            Hint();
            this.Hide();
            r.ShowDialog();
            //User will return to here from register form when the dialog result is yes.
            this.Show();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            //declare variables and assign value
            string email = emailTextBox.Text;
            string pw = pwTextBox.Text;

            //if user entered email and pw
            if (email == string.Empty || pw == string.Empty)
            {
                MessageBox.Show("Please enter your email or password.");
            }
            else if (email == "admin@gmail.com" && pw == "admin")
            {
                Check.currentUser = "ADMIN";
                Check.staffCheck = true;
                Home hs = new Home();
                this.Hide();
                hs.Show();
            }
            else
            {
                Database d = new Database();
                //Verify account by calling method from database class.
                bool valid = d.VerifyAccount(email, pw);
                if (valid == true)
                {
                    Check.currentUser = emailTextBox.Text;
                    Home h = new Home();
                    this.Hide();
                    h.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect email or password!");
                }
            }
        }
        private void exitButton_Click(object sender, EventArgs e)
        {  //close program

                Button b = new Button();
            b.ExitBtn();

        }
        public void Hint()
        {   //display the hint of textbox.
            if (pwTextBox.Text == "")
            {
                pwTextBox.Text = "Enter your password";
                pwTextBox.PasswordChar = '\0'; // /0 refer to null character
                pwTextBox.ForeColor = Color.Silver;
            }
            if (emailTextBox.Text == "")
            {
                emailTextBox.Text = "Enter your email";
                emailTextBox.ForeColor = Color.Silver;
            }
        }
    }
}
       

