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
    public partial class application : Form
    {
        /*IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "xKEDKwK1gsw0qEoPXdBeQ4VYcID9IvZWqcNVwOD0",
            BasePath = "https://sarthi-1ac50-default-rtdb.firebaseio.com/",
        };
        IFirebaseClient client;*/
        PrintPreviewDialog prntprvw = new PrintPreviewDialog();
        PrintDocument pntdoc = new PrintDocument();
        public application()
        {
            InitializeComponent();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label37_Click(object sender, EventArgs e)
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
            prntprvw.Document=pntdoc;
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
            memorying=new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(68, 68, pnl.Width,pnl.Height));
        }
        /// <summary>
        /// printing end
        /// </summary>
        Bitmap bitmap;
        private void button2_Click(object sender, EventArgs e)
        {
            //print panel 2 button
            Print(this.panel2);
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

        private void button1_Click(object sender, EventArgs e)
        {
            //refresh button
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;
            temp.Text = string.Empty;
            pr.Text = string.Empty;
            bp.Text = string.Empty;
            vn.Text = string.Empty;
            bcva.Text = string.Empty;
            complains.Text = string.Empty;  
            pasthistory.Text = string.Empty;    
            medicalhistory.Text = string.Empty;
            diagnosis.Text = string.Empty;
            treatment.Text = string.Empty;
            rbs.Text = string.Empty;
            syringing.Text = string.Empty;
            iop.Text    = string.Empty;
            iol.Text = string.Empty;    
            remark.Text = string.Empty; 
            ///checkbox empty
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            checkBox10.Checked = false;
            checkBox11.Checked = false;
            checkBox12.Checked = false;
            checkBox13.Checked = false;
            checkBox14.Checked = false;
            checkBox15.Checked = false;
            checkBox16.Checked = false;
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            //save to database
            //save to application panel
            if (mrd.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into application (mrd_no, dig, trt, date) values (@mrd_no, @dig, @trt, @date)", con);
                    cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
                    cmd.Parameters.AddWithValue("@dig", diagnosis.Text);
                    cmd.Parameters.AddWithValue("@trt", treatment.Text);
                    cmd.Parameters.AddWithValue("@date", dateTimePicker1.Value);


                    cmd.ExecuteNonQuery();

                    con.Close();
                    //confermation message

                    MessageBox.Show("Application Saved Success!");
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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            //print image
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 0, 10);
            //print form
            e.Graphics.DrawImage(bitmap, 0, 110);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mrd_TextChanged(object sender, EventArgs e)
        {
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

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
