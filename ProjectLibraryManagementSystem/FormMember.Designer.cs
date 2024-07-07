namespace ProjectLibraryManagementSystem
{
    partial class FormMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMember));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            panel3 = new Panel();
            panel5 = new Panel();
            rdbMale = new RadioButton();
            rdbFemale = new RadioButton();
            btnChoosePhoto = new Button();
            ptbPhoto = new PictureBox();
            cmbSangkat = new ComboBox();
            txtMemLname = new TextBox();
            label11 = new Label();
            cmbProvince = new ComboBox();
            label2 = new Label();
            dtpBirthdate = new DateTimePicker();
            label3 = new Label();
            label5 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label16 = new Label();
            txtPhoneNumber = new TextBox();
            cmbKhann = new ComboBox();
            txtMemFname = new TextBox();
            txtMemberID = new TextBox();
            panel4 = new Panel();
            ltbMemberDisplay = new ListBox();
            txtSearch = new TextBox();
            label1 = new Label();
            openFileDialogPhoto = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPhoto).BeginInit();
            panel4.SuspendLayout();
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
            label8.Size = new Size(203, 26);
            label8.TabIndex = 3;
            label8.Text = "MEMBER'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.member;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            panel2.Location = new Point(0, 751);
            panel2.Margin = new Padding(4, 3, 4, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(1006, 79);
            panel2.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(800, 18);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 15;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(245, 18);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(430, 18);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 13;
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
            btnClose.Location = new Point(615, 18);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 14;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(60, 18);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 234, 224);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(1006, 669);
            panel3.TabIndex = 4;
            // 
            // panel5
            // 
            panel5.Controls.Add(rdbMale);
            panel5.Controls.Add(rdbFemale);
            panel5.Controls.Add(btnChoosePhoto);
            panel5.Controls.Add(ptbPhoto);
            panel5.Controls.Add(cmbSangkat);
            panel5.Controls.Add(txtMemLname);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(cmbProvince);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(dtpBirthdate);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(txtPhoneNumber);
            panel5.Controls.Add(cmbKhann);
            panel5.Controls.Add(txtMemFname);
            panel5.Controls.Add(txtMemberID);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(330, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(676, 669);
            panel5.TabIndex = 1;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Location = new Point(290, 276);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(62, 26);
            rdbMale.TabIndex = 80;
            rdbMale.Text = "ប្រុស";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Checked = true;
            rdbFemale.Location = new Point(191, 276);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(49, 26);
            rdbFemale.TabIndex = 79;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "ស្រី";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // btnChoosePhoto
            // 
            btnChoosePhoto.BackColor = Color.FromArgb(255, 240, 150);
            btnChoosePhoto.Cursor = Cursors.Hand;
            btnChoosePhoto.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePhoto.Location = new Point(470, 258);
            btnChoosePhoto.Name = "btnChoosePhoto";
            btnChoosePhoto.Size = new Size(167, 31);
            btnChoosePhoto.TabIndex = 62;
            btnChoosePhoto.Text = "Choose Image";
            btnChoosePhoto.UseVisualStyleBackColor = false;
            btnChoosePhoto.Click += btnChoosePhoto_Click;
            // 
            // ptbPhoto
            // 
            ptbPhoto.BorderStyle = BorderStyle.FixedSingle;
            ptbPhoto.Location = new Point(470, 77);
            ptbPhoto.Name = "ptbPhoto";
            ptbPhoto.Size = new Size(167, 175);
            ptbPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            ptbPhoto.TabIndex = 61;
            ptbPhoto.TabStop = false;
            // 
            // cmbSangkat
            // 
            cmbSangkat.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSangkat.FormattingEnabled = true;
            cmbSangkat.IntegralHeight = false;
            cmbSangkat.Location = new Point(193, 533);
            cmbSangkat.MaxDropDownItems = 5;
            cmbSangkat.Name = "cmbSangkat";
            cmbSangkat.Size = new Size(453, 42);
            cmbSangkat.TabIndex = 7;
            // 
            // txtMemLname
            // 
            txtMemLname.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemLname.Location = new Point(192, 210);
            txtMemLname.Name = "txtMemLname";
            txtMemLname.Size = new Size(213, 42);
            txtMemLname.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(33, 280);
            label11.Name = "label11";
            label11.Size = new Size(79, 22);
            label11.TabIndex = 60;
            label11.Text = "Gender :";
            // 
            // cmbProvince
            // 
            cmbProvince.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbProvince.FormattingEnabled = true;
            cmbProvince.IntegralHeight = false;
            cmbProvince.Location = new Point(193, 403);
            cmbProvince.MaxDropDownItems = 5;
            cmbProvince.Name = "cmbProvince";
            cmbProvince.Size = new Size(453, 42);
            cmbProvince.TabIndex = 9;
            cmbProvince.SelectedIndexChanged += cmbProvince_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 476);
            label2.Name = "label2";
            label2.Size = new Size(71, 22);
            label2.TabIndex = 59;
            label2.Text = "Khann :";
            // 
            // dtpBirthdate
            // 
            dtpBirthdate.CustomFormat = "dd-MM-yyyy";
            dtpBirthdate.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBirthdate.Format = DateTimePickerFormat.Custom;
            dtpBirthdate.Location = new Point(191, 335);
            dtpBirthdate.Name = "dtpBirthdate";
            dtpBirthdate.Size = new Size(453, 42);
            dtpBirthdate.TabIndex = 6;
            dtpBirthdate.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 541);
            label3.Name = "label3";
            label3.Size = new Size(82, 22);
            label3.TabIndex = 58;
            label3.Text = "Sangkat :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 606);
            label5.Name = "label5";
            label5.Size = new Size(137, 22);
            label5.TabIndex = 57;
            label5.Text = "Phone Number :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(35, 411);
            label10.Name = "label10";
            label10.Size = new Size(131, 22);
            label10.TabIndex = 56;
            label10.Text = "Province/City :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 153);
            label7.Name = "label7";
            label7.Size = new Size(109, 22);
            label7.TabIndex = 55;
            label7.Text = "FirstName : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 218);
            label6.Name = "label6";
            label6.Size = new Size(100, 22);
            label6.TabIndex = 54;
            label6.Text = "LastName :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 346);
            label4.Name = "label4";
            label4.Size = new Size(98, 22);
            label4.TabIndex = 53;
            label4.Text = "BirthDate :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(34, 85);
            label16.Name = "label16";
            label16.Size = new Size(117, 22);
            label16.TabIndex = 52;
            label16.Text = "Member ID : ";
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(192, 598);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(454, 42);
            txtPhoneNumber.TabIndex = 10;
            // 
            // cmbKhann
            // 
            cmbKhann.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbKhann.FormattingEnabled = true;
            cmbKhann.IntegralHeight = false;
            cmbKhann.Location = new Point(193, 468);
            cmbKhann.MaxDropDownItems = 5;
            cmbKhann.Name = "cmbKhann";
            cmbKhann.Size = new Size(453, 42);
            cmbKhann.TabIndex = 8;
            cmbKhann.SelectedIndexChanged += cmbKhann_SelectedIndexChanged;
            // 
            // txtMemFname
            // 
            txtMemFname.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemFname.Location = new Point(191, 145);
            txtMemFname.Name = "txtMemFname";
            txtMemFname.Size = new Size(214, 42);
            txtMemFname.TabIndex = 3;
            // 
            // txtMemberID
            // 
            txtMemberID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberID.Location = new Point(191, 77);
            txtMemberID.Name = "txtMemberID";
            txtMemberID.ReadOnly = true;
            txtMemberID.Size = new Size(214, 42);
            txtMemberID.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(ltbMemberDisplay);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(330, 669);
            panel4.TabIndex = 0;
            // 
            // ltbMemberDisplay
            // 
            ltbMemberDisplay.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ltbMemberDisplay.FormattingEnabled = true;
            ltbMemberDisplay.ItemHeight = 34;
            ltbMemberDisplay.Location = new Point(24, 85);
            ltbMemberDisplay.Name = "ltbMemberDisplay";
            ltbMemberDisplay.Size = new Size(282, 548);
            ltbMemberDisplay.TabIndex = 5;
            ltbMemberDisplay.SelectedIndexChanged += ltbMemberDisplay_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(24, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(282, 38);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 3;
            label1.Text = "Search :";
            // 
            // openFileDialogPhoto
            // 
            openFileDialogPhoto.Filter = "PNG File|*.png|JPG File|*.jpg|All File|*.*";
            // 
            // FormMember
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1006, 830);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1024, 877);
            MinimumSize = new Size(1024, 877);
            Name = "FormMember";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member's Information";
            Load += FormMember_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbPhoto).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel5;
        private Panel panel4;
        private ListBox ltbMemberDisplay;
        private TextBox txtSearch;
        private Label label1;
        private TextBox txtPhoneNumber;
        private ComboBox cmbKhann;
        private TextBox txtMemFname;
        private ComboBox cmbProvince;
        private DateTimePicker dtpBirthdate;
        private TextBox txtMemberID;
        private Label label11;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label16;
        private ComboBox cmbSangkat;
        private TextBox txtMemLname;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private PictureBox ptbPhoto;
        private Button btnChoosePhoto;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private OpenFileDialog openFileDialogPhoto;
    }
}