namespace sarthi
{
    partial class user
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label sexLabel;
            System.Windows.Forms.Label contactLabel;
            System.Windows.Forms.Label ageLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label mrdLabel;
            System.Windows.Forms.Label label5;
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.district = new System.Windows.Forms.TextBox();
            this.city = new System.Windows.Forms.TextBox();
            this.pin = new System.Windows.Forms.TextBox();
            this.Hospital_address = new System.Windows.Forms.TextBox();
            this.state = new System.Windows.Forms.TextBox();
            this.hospital_name = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.sex = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.mrd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uid = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            sexLabel = new System.Windows.Forms.Label();
            contactLabel = new System.Windows.Forms.Label();
            ageLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            mrdLabel = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox8
            // 
            this.groupBox8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox8.Controls.Add(this.pictureBox1);
            this.groupBox8.Location = new System.Drawing.Point(12, 12);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(1004, 112);
            this.groupBox8.TabIndex = 72;
            this.groupBox8.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::sarthi.Properties.Resources.Header1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(6, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(992, 92);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.add_bt);
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Location = new System.Drawing.Point(244, 500);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(513, 74);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::sarthi.Properties.Resources.refresh__3_;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(24, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "    Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // add_bt
            // 
            this.add_bt.BackColor = System.Drawing.Color.RoyalBlue;
            this.add_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_bt.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_bt.ForeColor = System.Drawing.Color.White;
            this.add_bt.Image = global::sarthi.Properties.Resources.add_user;
            this.add_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_bt.Location = new System.Drawing.Point(357, 19);
            this.add_bt.Name = "add_bt";
            this.add_bt.Size = new System.Drawing.Size(119, 41);
            this.add_bt.TabIndex = 15;
            this.add_bt.Text = "Add";
            this.add_bt.UseVisualStyleBackColor = false;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(label7);
            this.groupBox2.Controls.Add(this.hospital_name);
            this.groupBox2.Controls.Add(this.state);
            this.groupBox2.Controls.Add(label3);
            this.groupBox2.Controls.Add(label8);
            this.groupBox2.Controls.Add(this.Hospital_address);
            this.groupBox2.Controls.Add(this.pin);
            this.groupBox2.Controls.Add(label2);
            this.groupBox2.Controls.Add(label6);
            this.groupBox2.Controls.Add(this.city);
            this.groupBox2.Controls.Add(this.district);
            this.groupBox2.Controls.Add(label1);
            this.groupBox2.Location = new System.Drawing.Point(244, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 218);
            this.groupBox2.TabIndex = 332;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(20, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(39, 23);
            label1.TabIndex = 26;
            label1.Text = "City";
            // 
            // district
            // 
            this.district.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.district.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.district.Location = new System.Drawing.Point(334, 135);
            this.district.MaxLength = 50;
            this.district.Name = "district";
            this.district.Size = new System.Drawing.Size(142, 30);
            this.district.TabIndex = 11;
            // 
            // city
            // 
            this.city.AutoCompleteCustomSource.AddRange(new string[] {
            "Ranchi",
            "Jamshedpur",
            "Dhanbad",
            "Bokaro Steel City",
            "Deoghar",
            "Phusro–Bermo–Bokaro Thermal",
            "Hazaribagh",
            "Giridih",
            "Medininagar",
            "Chirkunda",
            "Ramgarh",
            "Mumbai",
            "Delhi",
            "Kolkata",
            "Chennai",
            "Bangalore",
            "Hyderabad",
            "Ahmedabad",
            "Pune",
            "Surat",
            "Jaipur",
            "Kanpur",
            "Lucknow",
            "Nagpur",
            "Indore",
            "Patna",
            "Bhopal",
            "Thane",
            "Vadodara",
            "Visakhapatnam",
            "Pimpri-Chinchwad"});
            this.city.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.city.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.city.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.city.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.city.Location = new System.Drawing.Point(122, 134);
            this.city.MaxLength = 50;
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(112, 30);
            this.city.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label6.Location = new System.Drawing.Point(257, 173);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(48, 23);
            label6.TabIndex = 28;
            label6.Text = "State";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(20, 101);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(70, 23);
            label2.TabIndex = 25;
            label2.Text = "Address";
            // 
            // pin
            // 
            this.pin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pin.Location = new System.Drawing.Point(122, 170);
            this.pin.MaxLength = 6;
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(112, 30);
            this.pin.TabIndex = 12;
            this.pin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pin_KeyPress);
            // 
            // Hospital_address
            // 
            this.Hospital_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hospital_address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hospital_address.Location = new System.Drawing.Point(122, 98);
            this.Hospital_address.MaxLength = 500;
            this.Hospital_address.Name = "Hospital_address";
            this.Hospital_address.Size = new System.Drawing.Size(354, 30);
            this.Hospital_address.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label8.Location = new System.Drawing.Point(20, 173);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(34, 23);
            label8.TabIndex = 30;
            label8.Text = "Pin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(20, 65);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(56, 23);
            label3.TabIndex = 24;
            label3.Text = "Name";
            // 
            // state
            // 
            this.state.AutoCompleteCustomSource.AddRange(new string[] {
            "Andhra Pradesh",
            "Arunachal Pradesh",
            "Assam",
            "Bihar",
            "Chhattisgarh",
            "Goa",
            "Gujarat",
            "Haryana",
            "Himachal Pradesh",
            "Jharkhand",
            "Karnataka",
            "Kerala",
            "Madhya Pradesh",
            "Maharastra",
            "Manipur",
            "Meghalaya",
            "Mizoram",
            "Nagaland",
            "Odisha",
            "Punjab",
            "Rajsthan",
            "Sikkim",
            "Tamil Nadu",
            "Telangana",
            "Tripura",
            "Uttarakhand",
            "Uttar Pradesh",
            "West Bengal"});
            this.state.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.state.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.state.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.state.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.state.Location = new System.Drawing.Point(334, 171);
            this.state.MaxLength = 50;
            this.state.Name = "state";
            this.state.Size = new System.Drawing.Size(142, 30);
            this.state.TabIndex = 13;
            // 
            // hospital_name
            // 
            this.hospital_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hospital_name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospital_name.Location = new System.Drawing.Point(122, 62);
            this.hospital_name.MaxLength = 200;
            this.hospital_name.Name = "hospital_name";
            this.hospital_name.Size = new System.Drawing.Size(354, 30);
            this.hospital_name.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label7.Location = new System.Drawing.Point(257, 137);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(63, 23);
            label7.TabIndex = 32;
            label7.Text = "District";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(196, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 28);
            this.label9.TabIndex = 34;
            this.label9.Text = "Hospital Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.uid);
            this.groupBox3.Controls.Add(nameLabel);
            this.groupBox3.Controls.Add(mrdLabel);
            this.groupBox3.Controls.Add(this.sex);
            this.groupBox3.Controls.Add(addressLabel);
            this.groupBox3.Controls.Add(this.mrd);
            this.groupBox3.Controls.Add(sexLabel);
            this.groupBox3.Controls.Add(this.name);
            this.groupBox3.Controls.Add(this.address);
            this.groupBox3.Controls.Add(this.contact);
            this.groupBox3.Controls.Add(this.age);
            this.groupBox3.Controls.Add(ageLabel);
            this.groupBox3.Controls.Add(contactLabel);
            this.groupBox3.Location = new System.Drawing.Point(244, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(513, 279);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            // 
            // sex
            // 
            this.sex.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female",
            "Other"});
            this.sex.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sex.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.sex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sex.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.Location = new System.Drawing.Point(334, 94);
            this.sex.MaxLength = 8;
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(142, 30);
            this.sex.TabIndex = 3;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            addressLabel.Location = new System.Drawing.Point(20, 132);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(70, 23);
            addressLabel.TabIndex = 11;
            addressLabel.Text = "Address";
            // 
            // sexLabel
            // 
            sexLabel.AutoSize = true;
            sexLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sexLabel.Location = new System.Drawing.Point(279, 96);
            sexLabel.Name = "sexLabel";
            sexLabel.Size = new System.Drawing.Size(36, 23);
            sexLabel.TabIndex = 9;
            sexLabel.Text = "Sex";
            // 
            // address
            // 
            this.address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.address.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(122, 129);
            this.address.MaxLength = 200;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(354, 30);
            this.address.TabIndex = 4;
            // 
            // age
            // 
            this.age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.age.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(122, 93);
            this.age.MaxLength = 3;
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(132, 30);
            this.age.TabIndex = 2;
            this.age.TextChanged += new System.EventHandler(this.age_TextChanged);
            this.age.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.age_KeyPress);
            // 
            // contactLabel
            // 
            contactLabel.AutoSize = true;
            contactLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactLabel.Location = new System.Drawing.Point(20, 168);
            contactLabel.Name = "contactLabel";
            contactLabel.Size = new System.Drawing.Size(70, 23);
            contactLabel.TabIndex = 13;
            contactLabel.Text = "Contact";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ageLabel.Location = new System.Drawing.Point(20, 96);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new System.Drawing.Size(40, 23);
            ageLabel.TabIndex = 7;
            ageLabel.Text = "Age";
            // 
            // contact
            // 
            this.contact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contact.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(122, 165);
            this.contact.MaxLength = 10;
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(354, 30);
            this.contact.TabIndex = 5;
            this.contact.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.contact_KeyPress);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(122, 57);
            this.name.MaxLength = 100;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(354, 30);
            this.name.TabIndex = 1;
            // 
            // mrd
            // 
            this.mrd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mrd.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mrd.Location = new System.Drawing.Point(122, 201);
            this.mrd.MaxLength = 15;
            this.mrd.Name = "mrd";
            this.mrd.Size = new System.Drawing.Size(354, 30);
            this.mrd.TabIndex = 6;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nameLabel.Location = new System.Drawing.Point(20, 60);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(56, 23);
            nameLabel.TabIndex = 5;
            nameLabel.Text = "Name";
            // 
            // mrdLabel
            // 
            mrdLabel.AutoSize = true;
            mrdLabel.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            mrdLabel.Location = new System.Drawing.Point(20, 204);
            mrdLabel.Name = "mrdLabel";
            mrdLabel.Size = new System.Drawing.Size(47, 23);
            mrdLabel.TabIndex = 15;
            mrdLabel.Text = "MRD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 28);
            this.label4.TabIndex = 17;
            this.label4.Text = "User Details";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // uid
            // 
            this.uid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.Location = new System.Drawing.Point(122, 237);
            this.uid.MaxLength = 15;
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(354, 30);
            this.uid.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label5.Location = new System.Drawing.Point(20, 240);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(39, 23);
            label5.TabIndex = 20;
            label5.Text = "UID";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1004, 622);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1028, 779);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user";
            this.Load += new System.EventHandler(this.user_Load);
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox hospital_name;
        private System.Windows.Forms.TextBox state;
        private System.Windows.Forms.TextBox Hospital_address;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.TextBox district;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox sex;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox contact;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox mrd;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}