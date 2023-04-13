using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sarthi
{
    public partial class discharge : Form
    {
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public discharge()
        {
            InitializeComponent();
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// print start
        ///
        /// </summary>
        public void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panel2 = pnl;
            getprintarea(pnl);
            prntprvw.Document = pntdoc;
            pntdoc.PrintPage += new PrintPageEventHandler(pntdoc_printpage);
            prntprvw.ShowDialog();

        }
        public void pntdoc_printpage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.panel2.Width / 2), this.panel2.Location.Y);
        }
        Bitmap memorying;
        public void getprintarea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(68, 68, pnl.Width, pnl.Height));
        }
        /// <summary>
        /// printing end
        /// </summary>
        Bitmap bitmap;

        private void print_Click(object sender, EventArgs e)
        {
            ///PRINT BUTTON
            Print(this.panel2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ///refresh
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;

            iol.Text = string.Empty;
            diagnosis.Text = string.Empty;  
            treatment.Text = string.Empty;
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

        private void save_ot_Click(object sender, EventArgs e)
        {
            //save to database 
            //save to discharge panel
            if (mrd.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into discharge (mrd_no, date_of_s, date_of_d, iol) values (@mrd_no, @date_of_s, @date_of_d, @iol)", con);
                    cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
                    cmd.Parameters.AddWithValue("@date_of_s",dateTimePicker2.Value);
                    cmd.Parameters.AddWithValue("@date_of_d", dateTimePicker3.Value);
                    cmd.Parameters.AddWithValue("@iol", iol.Text);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    //confermation message

                    MessageBox.Show("Discharege Application Saved Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data Request Denied! Please check the text filled and try again." + ex);
                }
            }
            else
            {
                MessageBox.Show("Please Enter 'MRD Number' Before Proceeding To Save.");
            }
        }

        private void mrd_TextChanged(object sender, EventArgs e)
        {
            //mrd_data auto fill code
            SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from user_data where mrd_no=@mrd_no", con);
            cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader.GetValue(1).ToString();//name
                age.Text = reader.GetValue(2).ToString();//age
                sex.Text = reader.GetValue(3).ToString();//sex
                address.Text = reader.GetValue(4).ToString();//address
                contact.Text = reader.GetValue(5).ToString();//mobile
            }
            con.Close();
        }

        private void diagnosis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
