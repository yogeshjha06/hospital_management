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
using static System.Windows.Forms.AxHost;

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
            //Print(this.panel2);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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

            dischargetime.Text = string.Empty;
            diagnosis.Text = string.Empty;  
            treatment.Text = string.Empty;

            room.Text = string.Empty;
            type.Text = string.Empty;
            attending.Text = string.Empty;  
            admission.Text = string.Empty;  
            emergencycontact.Text = string.Empty;
            primarydoctor.Text = string.Empty;

            date.Value = DateTime.Now;
            dateofadm.Value = DateTime.Now;
            dateofsurgery.Value = DateTime.Now;

            premed.Text = string.Empty;
            postmed .Text = string.Empty;

            //hospital details
            hospital_name.Text = string.Empty;
            hospital_address.Text = string.Empty;
            district.Text = string.Empty;
            city.Text = string.Empty;
            pin.Text = string.Empty;
            state.Text = string.Empty;
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
            //save to discharge panel
            if (mrd.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into discharge (discharge_mrd, date_application, date_surgery, date_discharge, time, diagnosis, treatment, room, room_type, attending_doctor, reason_admit, emergency_contact, main_doctor, medication, post_medication, hospital_name, h_address, district, city, pin, state) " +
                        "values (@discharge_mrd, @date_application, @date_surgery, @date_discharge, @time, @diagnosis, @treatment, @room, @room_type, @attending_doctor, @reason_admit, @emergency_contact, " +
                        "@main_doctor, @medication, @post_medication, @hospital_name, @h_address, @district, @city, @pin, @state)", con);
                    
                    cmd.Parameters.AddWithValue("@discharge_mrd", mrd.Text);
                    cmd.Parameters.AddWithValue("@date_application", dateofadm.Value);
                    cmd.Parameters.AddWithValue("@date_surgery", dateofsurgery.Value);
                    cmd.Parameters.AddWithValue("@date_discharge", date.Value);
                    cmd.Parameters.AddWithValue("@time", dischargetime.Text);
                    cmd.Parameters.AddWithValue("@diagnosis", diagnosis.Text);
                    cmd.Parameters.AddWithValue("@treatment", treatment.Text);
                    cmd.Parameters.AddWithValue("@room", room.Text);
                    cmd.Parameters.AddWithValue("@room_type", type.Text);
                    cmd.Parameters.AddWithValue("@attending_doctor", attending.Text);
                    cmd.Parameters.AddWithValue("@reason_admit", admission.Text);
                    cmd.Parameters.AddWithValue("@emergency_contact", emergencycontact.Text);
                    //mdic info
                    cmd.Parameters.AddWithValue("@main_doctor", primarydoctor.Text);
                    cmd.Parameters.AddWithValue("@medication", premed.Text);
                    cmd.Parameters.AddWithValue("@post_medication", postmed.Text);
                    //patient hospital info
                    cmd.Parameters.AddWithValue("@hospital_name", hospital_name.Text);
                    cmd.Parameters.AddWithValue("@h_address", hospital_address.Text);
                    cmd.Parameters.AddWithValue("@district", district.Text);
                    cmd.Parameters.AddWithValue("@city", city.Text);
                    cmd.Parameters.AddWithValue("@pin", pin.Text);
                    cmd.Parameters.AddWithValue("@state", state.Text);

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
            
        }

        private void diagnosis_TextChanged(object sender, EventArgs e)
        {

        }

        private void discharge_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
            dateofadm.Value = DateTime.Now;
            dateofsurgery.Value = DateTime.Now;
            AutoScroll = true;
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            // Create a new font and brush for drawing text
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;


            e.Graphics.DrawString("\t\t\t   DISCHARGE FORM", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));

            string currentdate = DateTime.Now.ToString();

            // Draw the details on the form
            int x = 60;
            int y = 160;
            e.Graphics.DrawString($"Date: {currentdate}", textFont, brush, x, y);
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

            //Admission Details:
            y += 30;
            e.Graphics.DrawString("Admission Details", subHeaderFont, brush, x, y);
            y += 20;            
            e.Graphics.DrawString($"Date of Admission\t: {dateofadm.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Date of Surgery\t\t: {dateofsurgery.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Date of Discharge\t: {date.Text}", textFont, brush, x, y);
            y += 30;


            //Discharge Details
            e.Graphics.DrawString("Discharge Details", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Diagnosis\t: {diagnosis.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Treatment\t: {treatment.Text}", textFont, brush, x, y);
            y += 30;

            //Patient Summary
            e.Graphics.DrawString("Patient Summary", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Room Number\t: {room.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Room Type\t: {type.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Attending Physician\t: {attending.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Reason for Admission\t: {admission.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Emergency Contact\t: {emergencycontact.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Primary Physician\t: {primarydoctor.Text}", textFont, brush, x, y);
            y += 30;

            //Post-Discharge Instructions
            e.Graphics.DrawString("Post-Discharge Instructions", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Discharge Instructions\t\t:..................................................................................................", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Discharge Destination (Home/Rehabilitation Facility/Other)\t: .......................................................", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Transportation Arrangements\t:..................................................................................................", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"On treatment Medication\t\t: {premed.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Post-Discharge Medication\t: {postmed.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Follow-up Appointments\t\t:..................................................................................................", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Special Instructions (if any)\t:..................................................................................................", textFont, brush, x, y);
            y += 30;


            e.Graphics.DrawString($"Patient Signature \t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Witness Signature \t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Healthcare Provider Signature \t: ___________________________ Date \t: _______________", textFont, brush, x, y);
            y += 40;
            e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);
        }

        private void search_Click(object sender, EventArgs e)
        {
            //search data from user_info
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
