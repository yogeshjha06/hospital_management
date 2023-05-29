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
            doctor.Text = string.Empty;

            dateDischarge.Text = string.Empty;
            dateSurgery.Text = string.Empty;
            dateApplication.Text = string.Empty;


            //medical info
            compliance.Text = string.Empty;
            pastHistory.Text = string.Empty;
            medRecord.Text = string.Empty;

            //investigation
            Blood.Text = string.Empty;
            urine.Text = string.Empty;
            image.Text = string.Empty;
            ecg.Text = string.Empty;
            pulmonary.Text = string.Empty;
            colonoscopy.Text = string.Empty;

            //hospital record
            hospital.Text = string.Empty;
            pin.Text = string.Empty;
            state.Text = string.Empty;

            //allergies
            food.Text = string.Empty;
            med.Text = string.Empty;
            env.Text = string.Empty;
            insect.Text = string.Empty;
            latex.Text = string.Empty;
            chemical.Text = string.Empty;

            date.Value = DateTime.Now;

            label6.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox2.Visible = false;
            groupBox7.Visible = false;
            groupBox9.Visible = false;
        }

        private void mrd_TextChanged(object sender, EventArgs e)
        {

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
            //print search evidance
            Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
            e.Graphics.DrawImage(bm, 10, 10);
            // Create a new font and brush for drawing text
            Font headerFont = new Font("Arial", 14, FontStyle.Bold);
            Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
            Font textFont = new Font("Arial", 10);
            Brush brush = Brushes.Black;


            e.Graphics.DrawString("\t\t\tPATIENT INVENTORY", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));


            // Draw the details on the form
            int x = 60;
            int y = 160;
            e.Graphics.DrawString($"Date: {date.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString("Personal Information", subHeaderFont, brush, x, y);
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

            //CURRENT STATISTICS
            y += 30;
            e.Graphics.DrawString("Current Statistics", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Date of Application\t: {dateApplication.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Date of Surgery\t\t: {dateSurgery.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Date of Discharge\t: {dateDischarge.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Diagnosis\t\t: {diagnosis.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Treatment\t\t: {treatment.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Doctor\t\t\t: {doctor.Text}", textFont, brush, x, y);
            y += 30;

            //medical information
            e.Graphics.DrawString("Medical Information", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Compliance\t\t: {compliance.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Past History\t\t: {pastHistory.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Medical Record\t\t: {medRecord.Text}", textFont, brush, x, y);
            y += 30;

            //Investigations
            e.Graphics.DrawString("Investigations", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Blood Test\t\t: {Blood.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Urine Test\t\t: {urine.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Imaging Test\t\t: {image.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"EKG/ECG\t\t: {ecg.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Pulmonary function\t: {pulmonary.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Colonoscopy\t\t: {colonoscopy.Text}", textFont, brush, x, y);
            y += 30;

            //Medical Allergies
            e.Graphics.DrawString("Medical Allergies", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Food allergies\t\t: {food.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Medication allergies\t: {med.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Environmental allergies\t: {env.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Insect allergies\t\t: {insect.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Latex allergy\t\t: {latex.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Chemical allergies\t: {chemical.Text}", textFont, brush, x, y);
            y += 30;

            //Hospital record
            e.Graphics.DrawString("Hospital Records", subHeaderFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Hospital Name\t: {hospital.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"Pin\t\t: {pin.Text}", textFont, brush, x, y);
            y += 20;
            e.Graphics.DrawString($"State\t\t: {state.Text}", textFont, brush, x, y);
            y += 50;
            e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //visible data
            label6.Visible = true;
            groupBox5.Visible = true;
            groupBox6.Visible = true;
            groupBox3.Visible = true;
            groupBox2.Visible = true;
            groupBox7.Visible = true;
            groupBox9.Visible = true;
            //mrd_data auto fill code

            //fetch code
            SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT user_info.user_name, user_info.user_age, user_info.user_sex, user_info.user_address, " +
                "user_info.user_contact, user_info.mrd, user_info.hospital_name, user_info.pin, user_info.state, user_info.join_Date," +
                "application.a_diagnosis, application.a_treatment, application.a_complains, application.a_pasthistory, application.a_medrecord," +
                "application.a_diagnosis, application.blood, application.urine, application.imaging, application.ecg, application.pulmonary, " +
                "application.colonoscopy, application.food, application.medication, application.environment, application.insect, application.latex, " +
                "application.chemical, discharge.date_surgery, discharge.date_discharge, discharge.main_doctor " +
                "FROM user_info JOIN application ON user_info.mrd = application.application_mrd JOIN discharge ON application.application_mrd = discharge.discharge_mrd " +
                "Where user_info.mrd=@mrd;", con);
            
            cmd.Parameters.AddWithValue("@mrd", mrd.Text);

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                //personal information
                name.Text = reader.GetValue(0).ToString();//name
                age.Text = reader.GetValue(1).ToString();//age
                sex.Text = reader.GetValue(2).ToString();//sex
                address.Text = reader.GetValue(3).ToString();//address
                contact.Text = reader.GetValue(4).ToString();//mobile
                //info date
                dateApplication.Text = reader.GetValue(9).ToString();
                dateSurgery.Text = reader.GetValue(28).ToString();
                dateDischarge.Text = reader.GetValue(29).ToString();
                //basic info
                diagnosis.Text = reader.GetValue(10).ToString();    
                treatment.Text = reader.GetValue(11).ToString();
                doctor.Text = reader.GetValue(30).ToString();
                //medical info
                compliance.Text = reader.GetValue(12).ToString();
                pastHistory.Text = reader.GetValue(13).ToString();
                medRecord.Text = reader.GetValue(14).ToString();
                //investigation info
                Blood.Text = reader.GetValue(16).ToString();
                urine.Text = reader.GetValue(17).ToString();
                image.Text = reader.GetValue(18).ToString();
                ecg.Text = reader.GetValue(19).ToString();
                pulmonary.Text = reader.GetValue(20).ToString();
                colonoscopy.Text = reader.GetValue(21).ToString();
                //hospital information
                hospital.Text = reader.GetValue(6).ToString();//in patient default hospital name
                pin.Text = reader.GetValue(7).ToString();//default pin
                state.Text = reader.GetValue(8).ToString();// default state
                //allergies of patient
                food.Text = reader.GetValue(22).ToString();
                med.Text = reader.GetValue(23).ToString();
                env.Text = reader.GetValue(24).ToString();
                insect.Text = reader.GetValue(25).ToString();
                latex.Text = reader.GetValue(26).ToString();
                chemical.Text = reader.GetValue(27).ToString();
            }
            con.Close();

        }

        private void search_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }
    }
}
