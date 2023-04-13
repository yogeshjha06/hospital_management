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
            //this.tableBindingSource.AddNew();
            //add new user
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];//date
            try
            {
                //local db data connection
                SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                con.Open();
                

                SqlCommand cmd = new SqlCommand("insert into user_data values (@name, @age, @sex, @address, @mobile, @mrd_no, @uid, @date, @status)", con);
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@age", age.Text);
                cmd.Parameters.AddWithValue("@sex", sex.Text);
                cmd.Parameters.AddWithValue("@address", address.Text);
                cmd.Parameters.AddWithValue("@mobile", contact.Text);
                cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
                cmd.Parameters.AddWithValue("@uid", uid.Text);
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@status", 0);


                cmd.ExecuteNonQuery();

                con.Close();
                //text box was cleared after data insered in table 
                name.Text =string.Empty; 
                age.Text =string.Empty; 
                sex.Text = string.Empty;
                address.Text = string.Empty;
                contact.Text = string.Empty;
                mrd.Text = string.Empty;
                uid.Text = string.Empty;
                //confermation message

                MessageBox.Show("Data Inserted Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: Please Fill The Application Before Preceding.  " + ex);
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
        }

        private void user_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
            if(client == null)
            {
                MessageBox.Show("Error: Please connect to the internet. ");
            }
            else 
            {
               
            }
        }
    }
}
