using PrivateHire_Cars_System.myclass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PrivateHire_Cars_System
{
    class Database
    {
        private string host = "localhost";
        private string db = "privatehirecar";
        private string port = "3306";
        private string username = "root";
        private string pass = "";
        private MySqlConnection myconn;
        public MySqlDataReader read;

        public string enquiry_question;
        public string enquiry_type;
        public string enquiry_reply;

        public string b_pickupAdd;
        public string b_dropoffAdd;
        public DateTime b_pickupDate;
        public DateTime b_createDate;
        public int b_numOfPpl = 1;
        public int b_cabSize = 1;
        public string b_cabType;
        public int b_finalSize;
        public string b_paymentType;
        public decimal b_carFee = 1.00m;
        public string b_service;
        public decimal b_serviceFee = 1.00m;
        public string b_extraService;
        public decimal b_extraServiceFee = 1.00m;
        public decimal b_discount15 = 1.00m;
        public decimal b_total = 1.00m;
        public string b_status;
        public int c_id;

        public int d_id;
        public string d_name;
        public string d_gender;
        public string cab_brand;
        public string cab_colour;
        public string cab_plate;
        public int cab_size;
        public int cab_price;


        public Database()
        {
            string conn = "datasource=" + host + ";database=" + db + ";port=" + port +
                ";username=" + username + ";password=" + pass + ";SslMode=none";
            myconn = new MySqlConnection(conn);
        }

        public string GetConnection()
        {
            return "datasource=" + host + ";database=" + db + ";port=" + port +
                ";username=" + username + ";password=" + pass + ";SslMode=none";
        }


        public void create_enquiry()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO enquiry(`enquiry_question`,`enquiry_type`,`enquiry_reply`) VALUES(@enqQ, @enqT, @enqR)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;

                cmd.Parameters.Add("@enqQ", MySqlDbType.VarChar).Value = enquiry_question;
                cmd.Parameters.Add("@enqT", MySqlDbType.VarChar).Value = enquiry_type;
                cmd.Parameters.Add("@enqR", MySqlDbType.VarChar).Value = enquiry_reply;

                cmd.ExecuteNonQuery();
                myconn.Close();
            }
        }

        public void reply_enquiry(string s, int x)
        {
            myconn.Open();
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "Update enquiry SET enquiry_reply =@reply  WHERE enquiry_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myconn;
                    cmd.Parameters.Add("@reply", MySqlDbType.VarChar).Value = s;
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = x;

                    cmd.ExecuteNonQuery();
                    myconn.Close();
                }
            }
        }

        public DataTable getEnquiry(string v1)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT enquiry_id, enquiry_question, enquiry_reply FROM enquiry WHERE enquiry_type = @type";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@type", v1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

        public void create_booking()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO booking(`c_id`,`d_id`,`b_pickupAdd`,`b_dropoffAdd`,`b_pickupDate`,`b_createDate`,`b_numOfPpl`,`b_cabSize`,`" +
                    "b_cabType`,`b_paymentType`,`b_carFee`,`b_service`,`b_serviceFee`,`b_extraService`,`b_extraServiceFee`,`b_discount15`,`b_total`,`b_status`" +
                    ") VALUES(@cID, @dID, @bPickAdd, @bDropAdd,@bPickDate, @bCreDa,@bNumP, @bCaSi,@bCaTy, @bPayTy, @bCaFe, @bSer" +
                    ",@bSerFee, @bxSer, @bxSerFee,@bDis, @bTotal,@bSta)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;

                cmd.Parameters.Add("@cID", MySqlDbType.Int32).Value = c_id;
                cmd.Parameters.Add("@dID", MySqlDbType.Int32).Value = d_id;
                cmd.Parameters.Add("@bPickAdd", MySqlDbType.VarChar).Value = b_pickupAdd;
                cmd.Parameters.Add("@bDropAdd", MySqlDbType.VarChar).Value = b_dropoffAdd;
                cmd.Parameters.Add("@bPickDate", MySqlDbType.DateTime).Value = b_pickupDate;
                cmd.Parameters.Add("@bCreDa", MySqlDbType.DateTime).Value = b_createDate;
                cmd.Parameters.Add("@bNumP", MySqlDbType.Int32).Value = b_numOfPpl;
                cmd.Parameters.Add("@bCaSi", MySqlDbType.Int32).Value = b_finalSize;
                cmd.Parameters.Add("@bCaTy", MySqlDbType.VarChar).Value = b_cabType;
                cmd.Parameters.Add("@bPayTy", MySqlDbType.VarChar).Value = b_paymentType;
                cmd.Parameters.Add("@bCaFe", MySqlDbType.Decimal).Value = b_carFee;
                cmd.Parameters.Add("@bSer", MySqlDbType.VarChar).Value = b_service;
                cmd.Parameters.Add("@bSerFee", MySqlDbType.Decimal).Value = b_serviceFee;
                cmd.Parameters.Add("@bxSer", MySqlDbType.VarChar).Value = b_extraService;
                cmd.Parameters.Add("@bxSerFee", MySqlDbType.Decimal).Value = b_extraServiceFee;
                cmd.Parameters.Add("@bDis", MySqlDbType.Decimal).Value = b_discount15;
                cmd.Parameters.Add("@bTotal", MySqlDbType.Decimal).Value = b_total;
                cmd.Parameters.Add("@bSta", MySqlDbType.VarChar).Value = b_status;

                cmd.ExecuteNonQuery();
                myconn.Close();
            }
        }

        public void create_driver()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "INSERT INTO driver(`d_name`,`d_gender`,`cab_brand`,`cab_colour`,`cab_plate`,`" +
                    "cab_size`,`cab_price`)" +
                    "VALUES( @dName,@dGen, @cabBra,@cabCo, @cabPla,@cabSi,@cabPri)";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;

                cmd.Parameters.Add("@dName", MySqlDbType.VarChar).Value = d_name;
                cmd.Parameters.Add("@dGen", MySqlDbType.VarChar).Value = d_gender;
                cmd.Parameters.Add("@cabBra", MySqlDbType.VarChar).Value = cab_brand;
                cmd.Parameters.Add("@cabCo", MySqlDbType.VarChar).Value = cab_colour;
                cmd.Parameters.Add("@cabPla", MySqlDbType.VarChar).Value = cab_plate;
                cmd.Parameters.Add("@cabSi", MySqlDbType.Int32).Value = cab_size;
                cmd.Parameters.Add("@cabPri", MySqlDbType.Int32).Value = cab_price;


                cmd.ExecuteNonQuery();
                myconn.Close();
            }
        }

        public void getDriver()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT d_id FROM driver WHERE cab_size =" + Check.b_cabSize + " ORDER BY RAND() LIMIT 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    Check.d_id = read.GetInt32("d_id");
                    //dget_name = read.GetString("d_name");
                    //dget_gender = read.GetString("d_gender");
                }

                read.Close();
                myconn.Close();
            }
        }

        public void staffGetCustomer()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT c_id FROM customer WHERE c_email =" + " '" + Check.customerEmail + "' " + "LIMIT 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    Check.c_id = read.GetInt32("c_id");
                }

                read.Close();
                myconn.Close();
            }
        }

        public void getCustomer()
        {
            myconn.Open();
            using (MySqlCommand cmd = new MySqlCommand())
            {
                cmd.CommandText = "SELECT c_id FROM customer WHERE c_email =" + " '" + Check.currentUser + "' " + "LIMIT 1";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = myconn;
                read = cmd.ExecuteReader();

                if (read.Read())
                {
                    Check.c_id = read.GetInt32("c_id");
                }

                read.Close();
                myconn.Close();
            }
        }

        public bool VerifyAccount(string email, string pw)
        {
            using (myconn)
            {
                myconn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `customer` WHERE `c_email` = @email AND `c_pw` = @pw", myconn))
                {

                    da.SelectCommand.Parameters.AddWithValue("@email", email);
                    da.SelectCommand.Parameters.AddWithValue("@pw", pw);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //check if the account is valid
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }          
        }

        public bool VerifyExistUser(string email)
        {
            using (myconn)
            {
                myconn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `customer` WHERE `c_email` = @email", myconn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@email", email);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //check if the account is valid
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public bool checkBooking(string v1, string v2)
        {
            using (myconn)
            {
                myconn.Open();

                using (MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT booking.* FROM `booking` JOIN `customer` " +
                    "WHERE booking.c_id = customer.c_id AND customer.c_email = @email AND b_status = @status", myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@email", v1);
                    adapter.SelectCommand.Parameters.AddWithValue("@status", v2);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    //check if there is booking records
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public DataTable getBooking(string v1, string v2)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT b_id, b_pickUpAdd, b_dropoffAdd,driver.d_id, driver.d_name, b_total," +
                    " b_createDate, b_pickupDate, b_paymentType FROM booking, driver,customer" +
                    " WHERE booking.c_id = customer.c_id AND booking.d_id = driver.d_id AND " +
                    "customer.c_email = @email AND b_status = @status ORDER BY b_id";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@email", v1);
                    adapter.SelectCommand.Parameters.AddWithValue("@status", v2);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable getBookingDetail(int v1, string v2)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT booking.*, driver.d_name FROM booking, driver, customer WHERE" +
                    " booking.d_id = driver.d_id AND b_id = @id AND customer.c_email = @email";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", v1);
                    adapter.SelectCommand.Parameters.AddWithValue("@email", v2);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable getRating(int v1)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT rating_id, customer.c_name, rating.d_id, driver.d_name, driver_rating, " +
                    "cab_rating, comments FROM rating INNER JOIN customer ON rating.c_id = customer.c_id " +
                    "INNER JOIN driver ON rating.d_id = driver.d_id WHERE rating.d_id = @id";

                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@id", v1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public void updateBookingStatus(int v1, string s)
        {
            myconn.Open();
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "Update booking SET b_status =@status WHERE b_id = @id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myconn;
                    cmd.Parameters.Add("@status", MySqlDbType.VarChar).Value = s;
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = v1;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                }
            }
        }
        public bool VerifyDriverCab(string v1)
        {
            using (myconn)
            {
                myconn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `driver` WHERE `cab_plate` = @plate", myconn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@plate", v1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //check if the account is valid
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public void cancelBooking(int v1)
        {
            myconn.Open();
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    cmd.CommandText = "DELETE FROM booking WHERE b_id =@id";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = myconn;
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = v1;
                    cmd.ExecuteNonQuery();
                    myconn.Close();
                }
            }
        }
        public bool VerifyBooking(int v1)
        {
            using (myconn)
            {
                myconn.Open();

                using (MySqlDataAdapter da = new MySqlDataAdapter("SELECT * FROM `booking` WHERE `b_id` = @id", myconn))
                {
                    da.SelectCommand.Parameters.AddWithValue("@id", v1);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    //check if the account is valid
                    if (dt.Rows.Count > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
        public DataTable getDriverCab(int v1)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT * FROM driver WHERE cab_size = @s ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@s", v1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public DataTable getCustomerList(string v1)
        {
            using (myconn)
            {
                myconn.Open();
                string s = "SELECT c_id, c_name, c_email, c_phone, c_gender FROM customer WHERE c_email = @s ";
                using (MySqlDataAdapter adapter = new MySqlDataAdapter(s, myconn))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@s", v1);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }

    }
}

