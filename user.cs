using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//IOT data base
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Amazon;
using Amazon.RDS;
using Amazon.RDS.Model;


namespace sarthi
{
    public partial class user : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xKEDKwK1gsw0qEoPXdBeQ4VYcID9IvZWqcNVwOD0",
            BasePath = "https://sarthi-1ac50-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client; 
        public user()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private async void add_bt_Click_1(object sender, EventArgs e)
        {
            //add new user
            DateTime date = DateTime.Now;

            try
            {
                //db data connection
                SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
                ///start snipit
                // Values to check and insert
                string pname = name.Text;
                string page = age.Text;
                string psex = sex.Text;
                string paddress = address.Text;
                string pcontact = contact.Text;
                string pmrd = mrd.Text;
                string puid = uid.Text;

                string hname = hospital_name.Text;
                string haddress = Hospital_address.Text;
                string hcity = city.Text;
                string hdistrict = district.Text;
                string hpin = pin.Text;
                string hstate = state.Text;


                // SQL query to check if the values exist in the table
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM user_info WHERE mrd = @mrd AND uid = @uid;",con);
                da.SelectCommand.Parameters.AddWithValue("@mrd", pmrd);
                da.SelectCommand.Parameters.AddWithValue("@uid", puid);
                DataTable dt = new DataTable();
                da.Fill(dt);                        
                // Check if the values exist
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Patient allready exist in the database!");
                }
                else
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into user_info (user_name, user_age, user_sex, user_address, user_contact, mrd, uid," +
                        "hospital_name, hospital_address, hospital_city, hospital_district, pin, state, join_Date) values " +
                        "(@user_name, @user_age, @user_sex, @user_address, @user_contact, @mrd, @uid," +
                        "@hospital_name, @hospital_address, @hospital_city, @hospital_district, @pin, @state ,@join_Date)", con);
                    //ad with value data
                    cmd.Parameters.AddWithValue("@user_name", pname);
                    cmd.Parameters.AddWithValue("@user_age", page);
                    cmd.Parameters.AddWithValue("@user_sex", psex);
                    cmd.Parameters.AddWithValue("@user_address", paddress);
                    cmd.Parameters.AddWithValue("@user_contact", pcontact);
                    cmd.Parameters.AddWithValue("@mrd", pmrd);
                    cmd.Parameters.AddWithValue("@uid", puid);
                    cmd.Parameters.AddWithValue("@hospital_name", hname);
                    cmd.Parameters.AddWithValue("@hospital_address", haddress);
                    cmd.Parameters.AddWithValue("@hospital_city", hcity);
                    cmd.Parameters.AddWithValue("@hospital_district", hdistrict);
                    cmd.Parameters.AddWithValue("@pin", hpin);
                    cmd.Parameters.AddWithValue("@state", hstate);
                    cmd.Parameters.AddWithValue("@join_Date", date);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    //text box was cleared after data insered in table 
                    name.Text = string.Empty;
                    age.Text = string.Empty;
                    sex.Text = string.Empty;
                    address.Text = string.Empty;
                    contact.Text = string.Empty;
                    mrd.Text = string.Empty;
                    uid.Text = string.Empty;

                    hospital_name.Text = string.Empty;
                    Hospital_address.Text = string.Empty;
                    city.Text = string.Empty;
                    district.Text = string.Empty;
                    pin.Text = string.Empty;
                    state.Text = string.Empty;
                    //confermation message
                    con.Close();
                    MessageBox.Show("SARTHI: Data Inserted Success!");

                }
                ///end snipit
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Please Fill The Application Before Preceding." + ex);
            }
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void contact_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //refresh button 
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;
            uid.Text = string.Empty;
            //hospital details
            hospital_name.Text = string.Empty;
            Hospital_address.Text = string.Empty;
            district.Text = string.Empty;
            city.Text = string.Empty;
            pin.Text = string.Empty;
            state.Text = string.Empty;
        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }
    }
}
