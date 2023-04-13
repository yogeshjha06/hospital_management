using FireSharp.Response;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//IOT data base
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace sarthi
{
    public partial class ot : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xKEDKwK1gsw0qEoPXdBeQ4VYcID9IvZWqcNVwOD0",
            BasePath = "https://sarthi-1ac50-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;

        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public ot()
        {
            InitializeComponent();
        }

        private void label35_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;
            detail.Text = string.Empty;
            complication.Text = string.Empty;
            otin.Text = string.Empty;
            otout.Text = string.Empty;

            pblock.Checked = false; 
            topical.Checked = false;
        }

        private void pblock_CheckedChanged(object sender, EventArgs e)
        {
            if(pblock.Checked) 
            {
                topical.Checked = false;
            }
        }

        private void topical_CheckedChanged(object sender, EventArgs e)
        {
            if (topical.Checked) 
            {
                pblock.Checked = false; 
            }
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

        private void save_ot_Click(object sender, EventArgs e)
        {
            //add basic details to database
            //save to ot record
            if (mrd.Text != "")
            {
                try
                {

                    SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into ot (time_in, time_out, date, dop, comp, mrd_no) values (@time_in, @time_out, @date, @dop, @comp, @mrd_no)", con);
                    cmd.Parameters.AddWithValue("@time_in", otin.Text);
                    cmd.Parameters.AddWithValue("@time_out", otout.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);
                    cmd.Parameters.AddWithValue("@dop", detail.Text);
                    cmd.Parameters.AddWithValue("@comp", complication.Text);
                    cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    //confermation message

                    MessageBox.Show("OT Application Saved Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data Request Denied! Please check the text filled and try again." + ex);
                }
            }
            else
            {
                MessageBox.Show("Please Enter MRD Number Before Proceeding To Save.");
            }
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
            pnl.DrawToBitmap(memorying, new Rectangle(65, 65, pnl.Width, pnl.Height));
        }
        /// <summary>
        /// printing end
        /// </summary>
        Bitmap bitmap;

        private void print_Click(object sender, EventArgs e)
        {
            //print form
            Print(this.panel2);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print image
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(-10, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 10);
            //print form
            e.Graphics.DrawImage(bitmap, 0, 110);
        }

    }
}
