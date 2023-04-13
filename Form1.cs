using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sarthi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread thread = new Thread(new ThreadStart(start));
            thread.Start();
            Thread.Sleep(1000);
            thread.Abort();
            InitializeComponent();           
        }
        public void start()
        {
            Application.Run(new splash());
        }
        public void loadform(object Form)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(f);
            this.panel3.Tag = f;
            f.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void application_but_Click(object sender, EventArgs e)
        {
            loadform(new application());
        }

        private void user_details_but_Click(object sender, EventArgs e)
        {
            loadform(new user());
        }

        private void ot_but_Click(object sender, EventArgs e)
        {
            loadform(new ot());
        }

        private void discharge_but_Click(object sender, EventArgs e)
        {
            loadform(new discharge());
        }

        private void consent_but_Click(object sender, EventArgs e)
        {
            loadform(new consent());
        }

        private void help_but_Click(object sender, EventArgs e)
        {
            loadform(new help());
        }

        private void user_details_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            user_details_but.BackColor = Color.White;
            user_details_but.ForeColor = Color.Black;
            //inactive button
            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void application_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            application_but.BackColor = Color.White;
            application_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void ot_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            ot_but.BackColor = Color.White;
            ot_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void discharge_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            discharge_but.BackColor = Color.White;
            discharge_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void consent_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            consent_but.BackColor = Color.White;
            consent_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void declaration_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            declaration_but.BackColor = Color.White;
            declaration_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            help_but.BackColor = Color.MediumSlateBlue;
            help_but.ForeColor = Color.White;
        }

        private void help_but_MouseClick(object sender, MouseEventArgs e)
        {
            //active button
            help_but.BackColor = Color.White;
            help_but.ForeColor = Color.Black;
            //inactive button
            user_details_but.BackColor = Color.MediumSlateBlue;
            user_details_but.ForeColor = Color.White;

            application_but.BackColor = Color.MediumSlateBlue;
            application_but.ForeColor = Color.White;

            ot_but.BackColor = Color.MediumSlateBlue;
            ot_but.ForeColor = Color.White;

            discharge_but.BackColor = Color.MediumSlateBlue;
            discharge_but.ForeColor = Color.White;

            consent_but.BackColor = Color.MediumSlateBlue;
            consent_but.ForeColor = Color.White;

            declaration_but.BackColor = Color.MediumSlateBlue;
            declaration_but.ForeColor = Color.White;
        }

        private void declaration_but_Click(object sender, EventArgs e)
        {
            loadform(new search());
            
        }
    }
}
