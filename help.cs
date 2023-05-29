using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sarthi
{
    public partial class help : Form
    {
        public help()
        {
            InitializeComponent();
        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void help_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            role.Text = string.Empty;
            pin.Text = string.Empty;
            phone.Text = string.Empty;
            hospital.Text = string.Empty;
            details.Text = string.Empty;
            issue.Text = string.Empty;
            state.Text = string.Empty;
        }

        private void send_Click(object sender, EventArgs e)
        {
            //send token message help

            DateTime date = DateTime.Now;

            try
            {
                //db data connection
                SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
                ///start snipit
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into help (help_name, help_role, help_phone, help_pin, help_hospital, help_state, issue," +
                        "details, application_Date) values " +
                        "(@help_name, @help_role, @help_phone, @help_pin, @help_hospital, @help_state, @issue," +
                        "@details, @application_Date)", con);

                    //ad with value data
                    cmd.Parameters.AddWithValue("@help_name", name.Text);
                    cmd.Parameters.AddWithValue("@help_role", role.Text);
                    cmd.Parameters.AddWithValue("@help_phone", phone.Text);
                    cmd.Parameters.AddWithValue("@help_pin", pin.Text);
                    cmd.Parameters.AddWithValue("@help_hospital", hospital.Text);
                    cmd.Parameters.AddWithValue("@help_state", state.Text);
                    cmd.Parameters.AddWithValue("@issue", issue.Text);
                    cmd.Parameters.AddWithValue("@details", details.Text);
                    cmd.Parameters.AddWithValue("@application_Date", date);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    //text box was cleared after data insered in table 
                    name.Text = string.Empty;
                    role.Text = string.Empty;
                    phone.Text = string.Empty;
                    hospital.Text = string.Empty;
                    issue.Text = string.Empty;
                    details.Text = string.Empty;
                    pin.Text = string.Empty;
                    state.Text = string.Empty;
                    //confermation message
                    con.Close();
                    MessageBox.Show("SARTHI: Message has been received to our team, we will contact you soon!");

                }
                ///end snipit
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception Fatel Error :-  " + ex);
            }
        }
    }
}
