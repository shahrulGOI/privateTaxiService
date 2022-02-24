using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrivateHire_Cars_System
{
    class Button
    {
        public void ExitBtn()
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
             MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)

                return; 
           else
                Application.Exit();

        }

        public void EnquiryBtn(Form f)
        {
                Enquiry e = new Enquiry();
                f.Hide();
                e.Show();
        }
        public void MyBookingBtn(Form f)
        {
                MyBooking m = new MyBooking();
                f.Hide();
                m.Show();
        }
        public void LogOutBtn(Form f)
        {
            if (MessageBox.Show("Are you sure you want to log out?", "Log Out",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login l = new Login();
                f.Hide();
                l.Show();
            }
        }
        public void HomeBtn(Form f)
        {
            Home h = new Home();
            f.Hide();
            h.Show();
        }

        public void cabBtn(Form f)
        {
            addDC dc = new addDC();
            f.Hide();
            dc.Show();
        }

        public void regBtn(Form f)
        {
            Register r = new Register();
            f.Hide();
            r.Show();
        }

        public void checkBtn(Form f)
        {
            AdminCheck ac = new AdminCheck();
            f.Hide();
            ac.Show();
        }
    }
}
