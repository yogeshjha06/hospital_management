using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
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
            form_name = "PATIENT CONSENT FORM";            
            a = 1;
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //print decleration
            form_name = "PATIENT DECLARATION FORM";
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

            father.Text = string.Empty;
            relation.Text = string.Empty;
            emergency_contact.Text = string.Empty;
            operation.Text = string.Empty;

            date.Value = DateTime.Now;
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
            /*SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
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
            con.Close();*/
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void consent_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            if (a == 1)
            {
                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bm, 10, 10);
                // Create a new font and brush for drawing text
                Font headerFont = new Font("Arial", 14, FontStyle.Bold);
                Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
                Font textFont = new Font("Arial", 10);
                Brush brush = Brushes.Black;


                e.Graphics.DrawString("\t\t\t   CONSENT FORM", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));


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

                //Emergency Contact:
                y += 30;
                e.Graphics.DrawString("Emergency Contact", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Emergency Contact's Name\t: {father.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Relationship to Patient\t\t: {relation.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Emergency Contact Number\t: {emergency_contact.Text}", textFont, brush, x, y);
                y += 30;
                //Operation/Procedure Details
                e.Graphics.DrawString("Operation/Procedure Details", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Details\t: {operation.Text}", textFont, brush, x, y);
                y += 30;

                //Consent:
                e.Graphics.DrawString("Consent", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"I {name.Text},\n" +
                    $"\t Hereby grant my informed consent for the operation/procedure mentioned above. I have had an opportunity\n" +
                    $"to discuss the operation/procedure with my healthcare provider, who has answered all my questions to\n" +
                    $"my satisfaction. I understand the risks, benefits, and alternatives associated with this \n" +
                    $"operation/procedure.", textFont, brush, x, y);
                y += 100;
                e.Graphics.DrawString($"I acknowledge that no guarantees or assurances have been made to me regarding the outcome of the \n" +
                    $"operation/procedure. I understand that unforeseen circumstances may arise during the operation/procedure that could \n" +
                    $"necessitate changes to the planned course of action.", textFont, brush, x, y);
                y += 60;
                e.Graphics.DrawString($"I understand that I have the right to withdraw my consent at any time before the operation/procedure \n" +
                    $"begins. I also understand that I may request additional information or clarification about the operation/procedure from \n" +
                    $"my healthcare provider.", textFont, brush, x, y);
                y += 60;
                e.Graphics.DrawString($"By signing below, I acknowledge that I have read and understood the information provided in this consent\n" +
                    $"form. I agree to undergo the operation/procedure and accept any associated risks.", textFont, brush, x, y);
                y += 50;
                e.Graphics.DrawString($"Patient Signature\t\t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Witness Signature\t\t: ___________________________ Date \t: _______________", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Healthcare Provider Signature \t: ___________________________ Date \t: _______________", textFont, brush, x, y);
                y += 50;
                e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);
            }
            else if(a==2)
            {
                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bm, 10, 10);
                // Create a new font and brush for drawing text
                Font headerFont = new Font("Arial", 14, FontStyle.Bold);
                Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
                Font textFont = new Font("Arial", 10);
                Brush brush = Brushes.Black;


                e.Graphics.DrawString("\t\t\t   DECLARATION FORM", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));


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

                //Emergency Contact:
                y += 30;
                e.Graphics.DrawString("Emergency Contact", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Emergency Contact's Name\t: {father.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Relationship to Patient\t\t: {relation.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Emergency Contact Number\t: {emergency_contact.Text}", textFont, brush, x, y);
                y += 30;
                //Operation/Procedure Details
                e.Graphics.DrawString("Operation/Procedure Details", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Details\t: {operation.Text}", textFont, brush, x, y);
                y += 30;

                //Consent:
                e.Graphics.DrawString("Declaration", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"I {name.Text}, {relation.Text}'s name: {father.Text}\n" +
                    $"\t Hereby grant my informed declaration for the operation/procedure mentioned above. I have had an opportunity\n" +
                    $"to discuss the operation/procedure with my healthcare provider, who has answered all my questions to\n" +
                    $"my satisfaction. I understand the risks, benefits, and alternatives associated with this \n" +
                    $"operation/procedure.", textFont, brush, x, y);
                y += 100;
                e.Graphics.DrawString($"By signing below, I acknowledge that I have read and understood the information provided in this consent\n" +
                    $"form. I agree to undergo the operation/procedure and accept any associated risks.", textFont, brush, x, y);
                y += 50;
                e.Graphics.DrawString($"Patient Signature\t\t\t: ___________________________ Date\t: _______________", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Witness Signature\t\t: ___________________________ Date\t: _______________", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Healthcare Provider Signature\t: ___________________________ Date\t: _______________", textFont, brush, x, y);
                y += 50;
                e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);


            }
        }
    }
}
