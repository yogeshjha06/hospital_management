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
        public string food_allergies = "Null";
        public string med_allergies = "Null";
        public string env_allergies = "Null";
        public string insect_allergies = "Null";
        public string latex_allergies = "Null";
        public string chem_allergies = "Null";
        public string is_insure = "Null";
        public string patient_type = "Null";


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
            //Print(this.panel2);
            //data print
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
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
            //refresh button'
            colonoscopy.Text = string.Empty;
            pulmonary.Text = string.Empty;
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
            compliance.Text = string.Empty;  
            pastHistory.Text = string.Empty;    
            medicalHistory.Text = string.Empty;
            diagnosis.Text = string.Empty;
            treatment.Text = string.Empty;
            bloot_test.Text = string.Empty;
            imaging.Text = string.Empty;
            urine_test.Text    = string.Empty;
            ecg.Text = string.Empty;    
            remark.Text = string.Empty; 
            ///checkbox empty
            foodyes.Checked = false;
            foodno.Checked = false;
            medicationno.Checked = false;
            medicationyes.Checked = false;
            insectno.Checked = false;
            insectyes.Checked = false;
            envno.Checked = false;
            envyes.Checked = false;
            chemicalno.Checked = false;
            chemicalyes.Checked = false;
            outpatient.Checked = false;
            inpatient.Checked = false;
            insuranceno.Checked = false;
            insuranceyes.Checked = false;
            latexno.Checked = false;
            latexyes.Checked = false;
            //hospital details
            hospital_name.Text = string.Empty;
            hospital_address.Text = string.Empty;
            district.Text = string.Empty;
            city.Text = string.Empty;
            pin.Text = string.Empty;
            state.Text = string.Empty;

            date.Value = DateTime.Now;
        }

        private void add_bt_Click(object sender, EventArgs e)
        {
            //save to database
            //save to application panel
            if (mrd.Text != "")
            {

                try
                {
                    SqlConnection con = new SqlConnection("Data Source=sarthi.cxcgwnmhdykd.eu-north-1.rds.amazonaws.com,1433;Initial Catalog=db_cemrs;User ID=admin;Password=yogesh123");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("insert into application (a_complains, a_pasthistory, a_medrecord, a_temp, a_pr, a_bp, a_vn, a_remark, a_bcva," +
                        " a_diagnosis, a_treatment, food, medication, environment, insect, latex, chemical, insurance, inpatient, " +
                        "blood, imaging, pulmonary, urine, ecg, colonoscopy, " +
                        "hospital, h_address, h_district, h_city, pin, h_state, application_Date, application_mrd) " +
                        "" +
                        "" +
                        "values (@a_complains, @a_pasthistory, @a_medrecord, @a_temp, @a_pr, @a_bp, @a_vn, @a_remark, @a_bcva," 
                        +" @a_diagnosis, @a_treatment, @food, @medication, @environment, @insect, @latex, @chemical, @insurance, @inpatient, "
                        +"@blood, @imaging, @pulmonary, @urine, @ecg, @colonoscopy,"+
                        "@hospital, @h_address, @h_district, @h_city, @pin, @h_state, @application_Date, @application_mrd)", con);
                    
                    //inserting basic application info
                    cmd.Parameters.AddWithValue("@a_complains", compliance.Text);
                    cmd.Parameters.AddWithValue("@a_pasthistory", pastHistory.Text);
                    cmd.Parameters.AddWithValue("@a_medrecord", medicalHistory.Text);
                    cmd.Parameters.AddWithValue("@a_temp", temp.Text);
                    cmd.Parameters.AddWithValue("@a_pr", pr.Text);
                    cmd.Parameters.AddWithValue("@a_bp", bp.Text);
                    cmd.Parameters.AddWithValue("@a_vn", vn.Text);
                    cmd.Parameters.AddWithValue("@a_remark", remark.Text);
                    cmd.Parameters.AddWithValue("@a_bcva", bcva.Text);
                    //insertingmajor info
                    cmd.Parameters.AddWithValue("@a_diagnosis", diagnosis.Text);
                    cmd.Parameters.AddWithValue("@a_treatment", treatment.Text);
                    //patient allergies info
                    cmd.Parameters.AddWithValue("@food", food_allergies);
                    cmd.Parameters.AddWithValue("@medication", med_allergies);
                    cmd.Parameters.AddWithValue("@environment", env_allergies);
                    cmd.Parameters.AddWithValue("@insect", insect_allergies);
                    cmd.Parameters.AddWithValue("@latex", latex_allergies);
                    cmd.Parameters.AddWithValue("@chemical", chem_allergies);
                    cmd.Parameters.AddWithValue("@insurance", is_insure);
                    cmd.Parameters.AddWithValue("@inpatient", patient_type);
                    //patient test info
                    cmd.Parameters.AddWithValue("@blood", bloot_test.Text);
                    cmd.Parameters.AddWithValue("@imaging", imaging.Text);
                    cmd.Parameters.AddWithValue("@pulmonary", pulmonary.Text);
                    cmd.Parameters.AddWithValue("@urine", urine_test.Text);
                    cmd.Parameters.AddWithValue("@ecg", ecg.Text);
                    cmd.Parameters.AddWithValue("@colonoscopy", colonoscopy.Text);
                    //patient hospital info
                    cmd.Parameters.AddWithValue("@hospital", hospital_name.Text);
                    cmd.Parameters.AddWithValue("@h_address", hospital_address.Text);
                    cmd.Parameters.AddWithValue("@h_district", district.Text);
                    cmd.Parameters.AddWithValue("@h_city", city.Text);
                    cmd.Parameters.AddWithValue("@pin", pin.Text);
                    cmd.Parameters.AddWithValue("@h_state", state.Text);
                    cmd.Parameters.AddWithValue("@application_Date", date.Value);
                    cmd.Parameters.AddWithValue("@application_mrd", mrd.Text);//forgen key of patient

                    //run command
                    cmd.ExecuteNonQuery();
                    //connection closed safely
                    con.Close();
                    //confermation message

                    MessageBox.Show("SARTHI: Application Saved Success!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid Data Request Denied! Please check the text filled and try again.  ( " + ex+" )");
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

            if (!string.IsNullOrEmpty(mrd.Text))
            {

                Bitmap bm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                pictureBox1.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height));
                e.Graphics.DrawImage(bm, 10, 10);
                // Create a new font and brush for drawing text
                Font headerFont = new Font("Arial", 14, FontStyle.Bold);
                Font subHeaderFont = new Font("Arial", 12, FontStyle.Bold);
                Font textFont = new Font("Arial", 10);
                Brush brush = Brushes.Black;
             

                e.Graphics.DrawString("\t\t\t   Application Form", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Red, new Point(60, 110));

                
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

                //medical information
                y += 30;
                e.Graphics.DrawString("Medical Information", subHeaderFont, brush, x, y);
                y += 20;               
                e.Graphics.DrawString($"Compliance\t: {compliance.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Past History\t: {pastHistory.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Medical Record\t: {medicalHistory.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Temp\t: {temp.Text}    B.P.\t: {bp.Text}     P.R.\t: {pr.Text}     VN\t: {vn.Text}       BCVA\t: {bcva.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Remark\t: {remark.Text}", textFont, brush, x, y);
                y += 30;
                //Investigations record
                e.Graphics.DrawString("Investigations", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Blood Test\t\t: {bloot_test.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Urine Test\t\t: {urine_test.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Imaging Test\t\t: {imaging.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"EKG/ECG\t\t: {ecg.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Pulmonary function\t: {pulmonary.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Colonoscopy\t\t: {colonoscopy.Text}", textFont, brush, x, y);
                y += 30;

                //Medical History
                e.Graphics.DrawString("Medical History", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Food allergies\t\t: {food_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Medication allergies\t: {med_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Environmental allergies\t: {env_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Insect allergies\t\t: {insect_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Latex allergy\t\t: {latex_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Chemical allergies\t: {chem_allergies}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Insurance\t\t: {is_insure}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"InPatient\t\t: {patient_type}", textFont, brush, x, y);
                y += 30;
                //Hospital record
                e.Graphics.DrawString("Summary", subHeaderFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Diagnosis\t: {diagnosis.Text}", textFont, brush, x, y);
                y += 20;
                e.Graphics.DrawString($"Treatment\t: {treatment.Text}", textFont, brush, x, y);
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
                y += 50;
                e.Graphics.DrawString($"© Sarthi CEMRS 2023-25", textFont, Brushes.Indigo, x, y);
            }
            else
            {
                MessageBox.Show("Please Enter 'MRD Number' Before Proceeding To Print Application Form.");
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mrd_TextChanged(object sender, EventArgs e)
        {           
            
        }

        private void age_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void outpatient_CheckedChanged(object sender, EventArgs e)
        {
            if(outpatient.Checked)
            {
                inpatient.Checked = false;
                outpatientrecord.Visible = true;
                AutoScroll=true;
                patient_type = "out_patient";
            }
            if (outpatient.Checked==false)
            {
                outpatientrecord.Visible = false;
                AutoScroll = false;
            }
        }

        private void inpatient_CheckedChanged(object sender, EventArgs e)
        {
            if (inpatient.Checked)
            {
                outpatient.Checked = false;
                outpatientrecord.Visible = false;
                AutoScroll = false;
                patient_type = "in_patient";
            }
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (char.IsLetter(ch))
            {
                e.Handled = true;
            }
        }

        private void foodno_CheckedChanged(object sender, EventArgs e)
        {
            if (foodno.Checked)
            {
                foodyes.Checked = false;
                food_allergies = "No";
            }
        }

        private void foodyes_CheckedChanged(object sender, EventArgs e)
        {
            if (foodyes.Checked)
            {
                foodno.Checked = false;
                food_allergies = "Yes";
            }
        }

        private void medicationno_CheckedChanged(object sender, EventArgs e)
        {
            if (medicationno.Checked)
            {
                medicationyes.Checked = false;
                med_allergies = "No";
            }
        }

        private void medicationyes_CheckedChanged(object sender, EventArgs e)
        {
            if (medicationyes.Checked)
            {
                medicationno.Checked = false;
                med_allergies = "Yes";
            }
        }

        private void envno_CheckedChanged(object sender, EventArgs e)
        {
            if (envno.Checked)
            {
                envyes.Checked = false;
                env_allergies = "No";
            }
        }

        private void envyes_CheckedChanged(object sender, EventArgs e)
        {
            if (envyes.Checked)
            {
                envno.Checked = false;
                env_allergies = "Yes";
            }
        }

        private void insectno_CheckedChanged(object sender, EventArgs e)
        {
            if (insectno.Checked)
            {
                insectyes.Checked = false;
                insect_allergies = "No";
            }
        }

        private void insectyes_CheckedChanged(object sender, EventArgs e)
        {
            if (insectyes.Checked)
            {
                insectno.Checked = false;
                insect_allergies = "Yes";
            }
        }

        private void latexno_CheckedChanged(object sender, EventArgs e)
        {
            if (latexno.Checked)
            {
                latexyes.Checked = false;
                latex_allergies = "No";
            }
        }

        private void latexyes_CheckedChanged(object sender, EventArgs e)
        {
            if (latexyes.Checked)
            {
                latexno.Checked = false;
                latex_allergies = "Yes";
            }
        }

        private void chemicalno_CheckedChanged(object sender, EventArgs e)
        {
            if (chemicalno.Checked)
            {
                chemicalyes.Checked = false;
                chem_allergies = "No";
            }
        }

        private void chemicalyes_CheckedChanged(object sender, EventArgs e)
        {
            if (chemicalyes.Checked)
            {
                chemicalno.Checked = false;
                chem_allergies = "Yes";
            }
        }

        private void insuranceno_CheckedChanged(object sender, EventArgs e)
        {
            if (insuranceno.Checked)
            {
                insuranceyes.Checked = false;
                is_insure = "No";
            }
        }

        private void insuranceyes_CheckedChanged(object sender, EventArgs e)
        {
            if (insuranceyes.Checked)
            {
                insuranceno.Checked = false;
                is_insure = "Yes";
            }
        }

        private void application_Load(object sender, EventArgs e)
        {
            date.Value = DateTime.Now;
        }

        private void search_Click(object sender, EventArgs e)
        {
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
