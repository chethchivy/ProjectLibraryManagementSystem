namespace ProjectLibraryManagementSystem
{
    partial class FormStaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStaff));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            panel8 = new Panel();
            checkStopWork = new CheckBox();
            txtPersonalTel = new TextBox();
            label18 = new Label();
            txtSalary = new TextBox();
            txtContactTel = new TextBox();
            label14 = new Label();
            dtpHiredDate = new DateTimePicker();
            label15 = new Label();
            label17 = new Label();
            panel7 = new Panel();
            groupBox1 = new GroupBox();
            cmbSangkat = new ComboBox();
            label13 = new Label();
            label12 = new Label();
            txtStreetNo = new TextBox();
            cmbStaffKhann = new ComboBox();
            cmbStaffProvince = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            txtHouseNo = new TextBox();
            panel6 = new Panel();
            txtStaffPosition = new TextBox();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnChoosePhoto = new Button();
            ptbPhoto = new PictureBox();
            label11 = new Label();
            dtpBirthdate = new DateTimePicker();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label16 = new Label();
            txtStaffID = new TextBox();
            panel4 = new Panel();
            ltbStaffDisplay = new ListBox();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            cmbStaffSangkat = new ComboBox();
            openFileDialogPhoto = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            panel7.SuspendLayout();
            groupBox1.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPhoto).BeginInit();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 240, 200);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1006, 82);
            panel1.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(114, 50);
            label9.Name = "label9";
            label9.Size = new Size(282, 17);
            label9.TabIndex = 4;
            label9.Text = "@Copyright ISAD-SLS-G25-GROUP4 (2024)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(114, 15);
            label8.Name = "label8";
            label8.Size = new Size(172, 26);
            label8.TabIndex = 3;
            label8.Text = "STAFF'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.staff;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 234, 224);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(1006, 715);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(panel8);
            panel5.Controls.Add(panel7);
            panel5.Controls.Add(panel6);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(273, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(733, 715);
            panel5.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(checkStopWork);
            panel8.Controls.Add(txtPersonalTel);
            panel8.Controls.Add(label18);
            panel8.Controls.Add(txtSalary);
            panel8.Controls.Add(txtContactTel);
            panel8.Controls.Add(label14);
            panel8.Controls.Add(dtpHiredDate);
            panel8.Controls.Add(label15);
            panel8.Controls.Add(label17);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(0, 533);
            panel8.Name = "panel8";
            panel8.Size = new Size(733, 182);
            panel8.TabIndex = 2;
            // 
            // checkStopWork
            // 
            checkStopWork.AutoSize = true;
            checkStopWork.Location = new Point(495, 131);
            checkStopWork.Name = "checkStopWork";
            checkStopWork.Size = new Size(144, 26);
            checkStopWork.TabIndex = 17;
            checkStopWork.Text = "Stopped Work";
            checkStopWork.UseVisualStyleBackColor = true;
            // 
            // txtPersonalTel
            // 
            txtPersonalTel.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPersonalTel.Location = new Point(495, 25);
            txtPersonalTel.Name = "txtPersonalTel";
            txtPersonalTel.Size = new Size(206, 38);
            txtPersonalTel.TabIndex = 14;
            txtPersonalTel.Tag = "Personal Telephone";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(376, 34);
            label18.Name = "label18";
            label18.Size = new Size(121, 22);
            label18.TabIndex = 83;
            label18.Text = "Personal Tel :";
            // 
            // txtSalary
            // 
            txtSalary.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.Location = new Point(142, 77);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(223, 38);
            txtSalary.TabIndex = 15;
            txtSalary.Tag = "Salary";
            // 
            // txtContactTel
            // 
            txtContactTel.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtContactTel.Location = new Point(142, 25);
            txtContactTel.Name = "txtContactTel";
            txtContactTel.Size = new Size(223, 38);
            txtContactTel.TabIndex = 13;
            txtContactTel.Tag = "Contact Telephone";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(28, 81);
            label14.Name = "label14";
            label14.Size = new Size(72, 22);
            label14.TabIndex = 80;
            label14.Text = "Salary :";
            // 
            // dtpHiredDate
            // 
            dtpHiredDate.CustomFormat = "yyyy-MM-dd";
            dtpHiredDate.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpHiredDate.Format = DateTimePickerFormat.Custom;
            dtpHiredDate.Location = new Point(142, 127);
            dtpHiredDate.Name = "dtpHiredDate";
            dtpHiredDate.Size = new Size(223, 38);
            dtpHiredDate.TabIndex = 16;
            dtpHiredDate.TabStop = false;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(28, 30);
            label15.Name = "label15";
            label15.Size = new Size(112, 22);
            label15.TabIndex = 79;
            label15.Text = "Contact Tel :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(28, 135);
            label17.Name = "label17";
            label17.Size = new Size(109, 22);
            label17.TabIndex = 78;
            label17.Text = "Hired Date :";
            // 
            // panel7
            // 
            panel7.Controls.Add(groupBox1);
            panel7.Dock = DockStyle.Top;
            panel7.Location = new Point(0, 336);
            panel7.Name = "panel7";
            panel7.Size = new Size(733, 197);
            panel7.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(237, 234, 205);
            groupBox1.Controls.Add(cmbSangkat);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtStreetNo);
            groupBox1.Controls.Add(cmbStaffKhann);
            groupBox1.Controls.Add(cmbStaffProvince);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtHouseNo);
            groupBox1.Location = new Point(5, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(725, 183);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Address";
            // 
            // cmbSangkat
            // 
            cmbSangkat.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSangkat.FormattingEnabled = true;
            cmbSangkat.IntegralHeight = false;
            cmbSangkat.Location = new Point(489, 134);
            cmbSangkat.MaxDropDownItems = 5;
            cmbSangkat.Name = "cmbSangkat";
            cmbSangkat.Size = new Size(206, 38);
            cmbSangkat.TabIndex = 85;
            cmbSangkat.Tag = "Sangkat";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(388, 139);
            label13.Name = "label13";
            label13.Size = new Size(82, 22);
            label13.TabIndex = 84;
            label13.Text = "Sangkat :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(388, 37);
            label12.Name = "label12";
            label12.Size = new Size(96, 22);
            label12.TabIndex = 83;
            label12.Text = "Street No :";
            // 
            // txtStreetNo
            // 
            txtStreetNo.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStreetNo.Location = new Point(490, 32);
            txtStreetNo.Name = "txtStreetNo";
            txtStreetNo.Size = new Size(205, 38);
            txtStreetNo.TabIndex = 9;
            // 
            // cmbStaffKhann
            // 
            cmbStaffKhann.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffKhann.FormattingEnabled = true;
            cmbStaffKhann.IntegralHeight = false;
            cmbStaffKhann.Location = new Point(160, 134);
            cmbStaffKhann.MaxDropDownItems = 5;
            cmbStaffKhann.Name = "cmbStaffKhann";
            cmbStaffKhann.Size = new Size(206, 38);
            cmbStaffKhann.TabIndex = 11;
            cmbStaffKhann.Tag = "Khann";
            // 
            // cmbStaffProvince
            // 
            cmbStaffProvince.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffProvince.FormattingEnabled = true;
            cmbStaffProvince.IntegralHeight = false;
            cmbStaffProvince.Location = new Point(160, 83);
            cmbStaffProvince.MaxDropDownItems = 5;
            cmbStaffProvince.Name = "cmbStaffProvince";
            cmbStaffProvince.Size = new Size(535, 38);
            cmbStaffProvince.TabIndex = 10;
            cmbStaffProvince.Tag = "Province";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 139);
            label2.Name = "label2";
            label2.Size = new Size(76, 22);
            label2.TabIndex = 79;
            label2.Text = "Khann : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 37);
            label3.Name = "label3";
            label3.Size = new Size(100, 22);
            label3.TabIndex = 78;
            label3.Text = "House No :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 88);
            label5.Name = "label5";
            label5.Size = new Size(141, 22);
            label5.TabIndex = 77;
            label5.Text = "Province / City :";
            // 
            // txtHouseNo
            // 
            txtHouseNo.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtHouseNo.Location = new Point(160, 32);
            txtHouseNo.Name = "txtHouseNo";
            txtHouseNo.Size = new Size(205, 38);
            txtHouseNo.TabIndex = 8;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtStaffPosition);
            panel6.Controls.Add(rdbMale);
            panel6.Controls.Add(rdbFemale);
            panel6.Controls.Add(txtFirstName);
            panel6.Controls.Add(txtLastName);
            panel6.Controls.Add(btnChoosePhoto);
            panel6.Controls.Add(ptbPhoto);
            panel6.Controls.Add(label11);
            panel6.Controls.Add(dtpBirthdate);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(label4);
            panel6.Controls.Add(label16);
            panel6.Controls.Add(txtStaffID);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(733, 336);
            panel6.TabIndex = 0;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(165, 286);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.Size = new Size(535, 38);
            txtStaffPosition.TabIndex = 79;
            txtStaffPosition.Tag = "Staff Position";
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(264, 187);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(62, 26);
            rdbMale.TabIndex = 78;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Checked = true;
            rdbFemale.Location = new Point(165, 187);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(49, 26);
            rdbFemale.TabIndex = 77;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFirstName.Location = new Point(165, 82);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(303, 38);
            txtFirstName.TabIndex = 3;
            txtFirstName.Tag = "FirstName";
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtLastName.Location = new Point(165, 133);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(304, 38);
            txtLastName.TabIndex = 4;
            txtLastName.Tag = "LastName";
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.BackColor = Color.FromArgb(255, 240, 150);
            btnChoosePhoto.Cursor = Cursors.Hand;
            btnChoosePhoto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePhoto.Location = new Point(533, 194);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(167, 31);
            btnChoosePhoto.TabIndex = 76;
            btnChoosePhoto.Text = "Choose Image";
            btnChoosePhoto.UseVisualStyleBackColor = false;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // ptbPhoto
            // 
            ptbPhoto.BorderStyle = BorderStyle.FixedSingle;
            ptbPhoto.Location = new Point(533, 27);
            ptbPhoto.Name = "ptbPhoto";
            ptbPhoto.Size = new Size(167, 161);
            ptbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPhoto.TabIndex = 75;
            ptbPhoto.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 189);
            label11.Name = "label11";
            label11.Size = new Size(79, 22);
            label11.TabIndex = 74;
            label11.Text = "Gender :";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CustomFormat = "yyyy-MM-dd";
            dtpBirthdate.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthdate.Format = DateTimePickerFormat.Custom;
            dtpBirthdate.Location = new Point(165, 234);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(535, 38);
            dtpBirthdate.TabIndex = 6;
            dtpBirthdate.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 291);
            label10.Name = "label10";
            label10.Size = new Size(122, 22);
            label10.TabIndex = 73;
            label10.Text = "Staff Positon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 87);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 72;
            label7.Text = "FirstName : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 138);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 71;
            label6.Text = "LastName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 243);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 70;
            label4.Text = "BirthDate :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 43);
            label16.Name = "label16";
            label16.Size = new Size(88, 22);
            label16.TabIndex = 69;
            label16.Text = "Staff ID : ";
            // 
            // txtStaffID
            // 
            txtStaffID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffID.Location = new Point(165, 30);
            txtStaffID.Name = "txtStaffID";
            txtStaffID.ReadOnly = true;
            txtStaffID.Size = new Size(303, 38);
            txtStaffID.TabIndex = 2;
            txtStaffID.Tag = "Staff ID";
            // 
            // panel4
            // 
            panel4.Controls.Add(ltbStaffDisplay);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(273, 715);
            panel4.TabIndex = 0;
            // 
            // ltbStaffDisplay
            // 
            ltbStaffDisplay.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ltbStaffDisplay.FormattingEnabled = true;
            ltbStaffDisplay.ItemHeight = 34;
            ltbStaffDisplay.Location = new Point(33, 93);
            ltbStaffDisplay.Name = "ltbStaffDisplay";
            ltbStaffDisplay.Size = new Size(235, 582);
            ltbStaffDisplay.TabIndex = 8;
            ltbStaffDisplay.SelectedIndexChanged += ltbStaffDisplay_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(33, 43);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(237, 38);
            txtSearch.TabIndex = 1;
            txtSearch.Tag = "search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 18);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 7;
            label1.Text = "Search :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnInsert);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 797);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 90);
            panel2.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(800, 24);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 24;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(245, 24);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 21;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(430, 24);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 22;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(615, 24);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 23;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(60, 24);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 20;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // cmbStaffSangkat
            // 
            cmbStaffSangkat.Location = new Point(0, 0);
            cmbStaffSangkat.Name = "cmbStaffSangkat";
            cmbStaffSangkat.Size = new Size(121, 28);
            cmbStaffSangkat.TabIndex = 0;
            // 
            // openFileDialogPhoto
            // 
            openFileDialogPhoto.Filter = "PNG File|*.png|JPG File|*.jpg|All File|*.*";
            // 
            // FormStaff
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1006, 887);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1024, 934);
            MinimumSize = new Size(1024, 934);
            Name = "FormStaff";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Staff's Information";
            Load += FormStaff_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel7.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPhoto).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Button btnLogOut;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private Panel panel6;
        private TextBox txtSearch;
        private ListBox ltbMemberDisplay;
        private Label label1;
        private Button btnChoosePhoto;
        private PictureBox ptbPhoto;
        private ComboBox cmbStaffSangkat;
        private TextBox txtMemLname;
        private Label label11;
        private DateTimePicker dtpBirthdate;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label16;
        private TextBox txtMemFname;
        private TextBox txtStaffID;
        private Panel panel7;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtHouseNo;
        private Label label12;
        private TextBox txtStreetNo;
        private ComboBox cmbStaffKhann;
        private ComboBox cmbStaffProvince;
        private Label label13;
        private Panel panel8;
        private TextBox txtSalary;
        private TextBox txtContactTel;
        private Label label14;
        private DateTimePicker dtpHiredDate;
        private Label label15;
        private Label label17;
        private CheckBox checkStopWork;
        private TextBox txtPersonalTel;
        private Label label18;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private ListBox ltbStaffDisplay;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private TextBox txtStaffPosition;
        private OpenFileDialog openFileDialogPhoto;
        private ComboBox cmbSangkat;
    }
}