using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace sarthi
{
    
    public partial class consent : Form
    {
        public string form_name,form_dis;
        public int a;
        public consent()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            //print consent
            form_name = "CONSENT FORM";
            form_dis=label1.Text;
            a = 1;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //print decleration
            form_name = "DECLARATION FORM";
            //form_dis = label2.Text;
            a = 2;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //refresh button
            name.Text = string.Empty;   
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;
        }

        private void age_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void contact_TextChanged(object sender, EventArgs e)
        {

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

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (a == 1)
            {
                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bm, 10, 10);

                e.Graphics.DrawString("\t\t\t " + form_name, new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Red, new Point(60, 110));
                e.Graphics.DrawString("MRD NUMBER:\t " + mrd.Text + " \t\t NAME: " + name.Text + "\t\t AGE: \t" + age.Text + "\t\t SEX: \t" + sex.Text, new Font("Segoe UI", 9, FontStyle.Regular), Brushes.Black, new Point(60, 170));
                e.Graphics.DrawString("ADDRESS:\t " + address.Text + " \t\t MOBILE: " + contact.Text + "\t\t DATE: \t" + dateTimePicker1.Value, new Font("Segoe UI", 9, FontStyle.Regular), Brushes.Black, new Point(60, 200));
                e.Graphics.DrawString("ऑपरेशन के लिए सहमति", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 260));
                e.Graphics.DrawString(form_dis, new Font("Segoe UI", 9, FontStyle.Regular), Brushes.Black, new Point(100, 320));
            }
            else if(a==2)
            {
                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bm, 10, 10);

                e.Graphics.DrawString("\t\t\t  " + form_name, new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Red, new Point(60, 120));

                e.Graphics.DrawString("MRD No. : " + "\t " + mrd.Text + " \t\t\t\t  " + "DATE : " + " : " + dateTimePicker1.Value, new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Black, new Point(60, 200));

                e.Graphics.DrawString("मैं \t " + name.Text + " \t पिता " + textBox1.Text + "\t पता \t" + address.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 300));

                e.Graphics.DrawString("रहने वाला हूँ| मेरा मोतियाबिंद का ऑपरेशन श्री गणेश आई हॉस्पिटल में हुआ है। मेरे द्वारा दिया गया \n\nमोबईल नम्बर" + contact.Text + "जो मेरा खुद का है / परिवार में " + textBox2.Text + " है,/ मेरे गाँव \n\nमुखिया / सरपंच / सहीया / वार्ड सदस्य का है एवं ऑपरेशन के लिए मुझसे किसी भी प्रकार को कोई भी \n\nराशी नही ली गई है। ", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 350));


                e.Graphics.DrawString("\t\t\t\t\t\t\t\t\t\t\t______________________", new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, new Point(60, 920));
                e.Graphics.DrawString("\t\t\t\t\t\t\t\t            " + "हस्ताक्षर", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 940));
                //
            }
        }
    }
}
