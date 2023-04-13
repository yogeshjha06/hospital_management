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
    public partial class search : Form
    {
        public search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;

            diagnosis.Text = string.Empty;
            treatment.Text = string.Empty;
            iol.Text = string.Empty;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void mrd_TextChanged(object sender, EventArgs e)
        {
            //mrd_data auto fill code
            SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT [dbo].[user_data].name, [dbo].[user_data].age, [dbo].[user_data].sex, [dbo].[user_data].address,[dbo].[user_data].mobile, [dbo].[user_data].date,  [dbo].[discharge].date_of_s, [dbo].[discharge].date_of_d, [dbo].[discharge].iol, [dbo].[application].dig, [dbo].[application].trt FROM [dbo].[user_data] JOIN [dbo].[discharge] ON [dbo].[discharge].mrd_no=[dbo].[user_data].mrd_no JOIN [dbo].[application] ON [dbo].[application].mrd_no=[dbo].[user_data].mrd_no WHERE [dbo].[user_data].mrd_no=@mrd_no;", con);
            cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                name.Text = reader.GetValue(0).ToString();//name
                age.Text = reader.GetValue(1).ToString();//age
                sex.Text = reader.GetValue(2).ToString();//sex
                address.Text = reader.GetValue(3).ToString();//address
                contact.Text = reader.GetValue(4).ToString();//mobile
                textBox3.Text = reader.GetValue(5).ToString();//date of application


                textBox2.Text = reader.GetValue(6).ToString();//sergery
                textBox1.Text = reader.GetValue(7).ToString();//discharge
                iol.Text = reader.GetValue(8).ToString();//iol power

                diagnosis.Text = reader.GetValue(9).ToString();//dignosis
                treatment.Text = reader.GetValue(10).ToString();//treatment

            }
            con.Close();
        }

        private void print_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {

                

        }

        private void printDocument1_PrintPage_1(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 10, 10);

            e.Graphics.DrawString("\t\t\t  " + "PATIENT INVENTORY", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Red, new Point(60, 120));

            e.Graphics.DrawString("MRD No. : " + "\t " + mrd.Text + " \t\t\t\t  " + "DATE : " + dateTimePicker1.Value, new Font("Segoe UI", 11, FontStyle.Bold), Brushes.Black, new Point(60, 200));

            e.Graphics.DrawString("NAME:  \t " + name.Text + " \t AGE:  " + age.Text + "\t SEX: \t" + sex.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 300));

            e.Graphics.DrawString("ADDRESS:  \t " + address.Text + " \t CONTACT:  " + contact.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 330));//

            e.Graphics.DrawString("Date of Application: " + textBox3.Text , new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(60, 360));

            e.Graphics.DrawString("Date of Sergery:  \t " + textBox2.Text + " \t Date of Discharge:  " + textBox1.Text , new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(60, 390));

            e.Graphics.DrawString("Diagnosis:  \t " + diagnosis.Text , new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(60, 420));

            e.Graphics.DrawString("Treatment:  \t " + treatment.Text, new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(60, 450));

            e.Graphics.DrawString("IOL:  \t " + iol.Text, new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Red, new Point(60, 480));

            e.Graphics.DrawString("\t\t\t\t\t\t\t\t\t\t\t______________________", new Font("Segoe UI", 9, FontStyle.Bold), Brushes.Black, new Point(60, 920));
            e.Graphics.DrawString("\t\t\t\t\t\t\t\t            " + "SIGNATURE", new Font("Segoe UI", 12, FontStyle.Bold), Brushes.Black, new Point(60, 940));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //mrd_data auto fill code
            SqlConnection con = new SqlConnection("Server=tcp:college1.database.windows.net,1433;Initial Catalog=ganesh_db;Persist Security Info=False;User ID=college_login;Password=Yogesh@1221;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            con.Open();
            

            SqlCommand cmd = new SqlCommand("DELETE FROM [dbo].[user_data] WHERE mrd_no=@mrd_no;", con);
            cmd.Parameters.AddWithValue("@mrd_no", mrd.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Patient Removed From Our Database!");
            name.Text = string.Empty;
            age.Text = string.Empty;
            sex.Text = string.Empty;
            address.Text = string.Empty;
            contact.Text = string.Empty;
            mrd.Text = string.Empty;

            diagnosis.Text = string.Empty;
            treatment.Text = string.Empty;
            iol.Text = string.Empty;

            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            con.Close();
        }
    }
}
