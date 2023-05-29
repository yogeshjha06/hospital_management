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
            postdetails.Text = string.Empty;
            complication.Text = string.Empty;
            actiontaken.Text = string.Empty;

            otin.Text = string.Empty;
            otout.Text = string.Empty;
            anaesthesia.Text = string.Empty;

            room.Text = string.Empty;
            doctorname.Text = string.Empty;

            hospital_name.Text = string.Empty;
            hospital_address.Text = string.Empty;
            district.Text = string.Empty;
            city.Text = string.Empty;
            pin.Text = string.Empty;
            state.Text = string.Empty;

            date.Value = DateTime.Now;
        }

        private void pblock_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void topical_CheckedChanged(object sender, EventArgs e)
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

        private void mrd_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void save_ot_Click(object sender, EventArgs e)
        {
            //save to ot record
            if (mrd.Text != "")
            {
                try
                {
                    //aws connection string
                    SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into ot (ot_mrd, pre_diagnosis, post_diagnosis, complications, action, time_in, time_out, anaesthesia, room, doctor, hospital_name, h_address, district, city, pin, state, application_Date) " +
                        "values (@ot_mrd, @pre_diagnosis, @post_diagnosis, @complications, @action, @time_in, @time_out, @anaesthesia, @room, @doctor, @hospital_name, @h_address, @district, @city, @pin, @state, @application_Date)", con);
                    
                    cmd.Parameters.AddWithValue("@ot_mrd", mrd.Text);
                    cmd.Parameters.AddWithValue("@pre_diagnosis", detail.Text);
                    cmd.Parameters.AddWithValue("@post_diagnosis", postdetails.Text);
                    cmd.Parameters.AddWithValue("@complications", complication.Text);
                    cmd.Parameters.AddWithValue("@action", actiontaken.Text);
                    cmd.Parameters.AddWithValue("@time_in", otin.Text);
                    cmd.Parameters.AddWithValue("@time_out", otout.Text);
                    cmd.Parameters.AddWithValue("@anaesthesia", anaesthesia.Text);
                    cmd.Parameters.AddWithValue("@room", room.Text);
                    cmd.Parameters.AddWithValue("@doctor", doctorname.Text);
                    cmd.Parameters.AddWithValue("@hospital_name", hospital_name.Text);
                    cmd.Parameters.AddWithValue("@h_address", hospital_address.Text);
                    cmd.Parameters.AddWithValue("@district", district.Text);
                    cmd.Parameters.AddWithValue("@city", city.Text);
                    cmd.Parameters.AddWithValue("@pin", pin.Text);
                    cmd.Parameters.AddWithValue("@state", state.Text);
                    cmd.Parameters.AddWithValue("@application_Date", date.Value);

                    //run command 
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
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //print image
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            // Create a new font and brush for drawing text
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;


            e.Graphics.DrawString("\t\t\t   OPERATION FORM", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));


            // Draw the details on the form
            int x = 60;
            int y = 160;
            e.Graphics.DrawString($"Date: {date.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString("Patient's Information", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Name\t: {name.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Age\t: {age.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Sex\t: {sex.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"MRD\t: {mrd.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Address\t: {address.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Contact\t: {contact.Text}", textFont, brush, x, y);

            //Procedure Details
            y += 30;
            e.Graphics.DrawString("Procedure Details", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Pre-operative Diagnosis\t: {detail.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Post-operative Diagnosis\t: {postdetails.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Complications\t\t: {complication.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Actions taken\t\t: {actiontaken.Text}", textFont, brush, x, y);
            y += 30;
            //Intra-operative Details
            e.Graphics.DrawString("Intra-operative Details", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Start Time\t\t: {otin.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"End Time\t\t: {otout.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Anesthesia Used\t\t: {anaesthesia.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Room Number/Name\t: {room.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Surgeon/Physician Name\t: {doctorname.Text}", textFont, Brushes.Indigo, x, y);
            y += 30;

            //Hospital record
            e.Graphics.DrawString("Hospital Records", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Hospital Name\t: {hospital_name.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Address\t\t: {hospital_address.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"District\t\t: {district.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"City\t\t: {city.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Pin\t\t: {pin.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"State\t\t: {state.Text}", textFont, brush, x, y);
            y += 30;


            //Post-operative Instructions
            e.Graphics.DrawString("Post-operative Instructions", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Recovery Room Time \t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Vital Signs (at specified intervals) \t: _______________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Pain Management \t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Activity Restrictions \t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Wound Care \t\t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Medication Instructions \t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Follow-up Appointments \t: ______________________________________________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Discharge Instructions \t: ______________________________________________", textFont, brush, x, y);
            y += 40;

            e.Graphics.DrawString($"Patient Signature \t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Witness Signature \t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Healthcare Provider Signature \t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 50;
            e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);
        }

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void ot_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
        }

        private void search_Click(object sender, EventArgs e)
        {
            //search user from ot table
            SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
            con.Open();

            SqlCommand cmd = new SqlCommand("select * from user_info where mrd=@mrd", con);
            cmd.Parameters.AddWithValue("@mrd", mrd.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //personal information
                name.Text = reader.GetValue(1).ToString();//name
                age.Text = reader.GetValue(2).ToString();//age
                sex.Text = reader.GetValue(3).ToString();//sex
                address.Text = reader.GetValue(4).ToString();//address
                contact.Text = reader.GetValue(5).ToString();//mobile
                //hospital information
                hospital_name.Text = reader.GetValue(8).ToString();//in patient default hospital name
                hospital_address.Text = reader.GetValue(9).ToString();//default hospital address
                city.Text = reader.GetValue(10).ToString();//default city of hospital
                district.Text = reader.GetValue(11).ToString();//default district
                pin.Text = reader.GetValue(12).ToString();//default pin
                state.Text = reader.GetValue(13).ToString();// default state
            }
            con.Close();
        }
    }
}
