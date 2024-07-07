namespace ProjectLibraryManagementSystem
{
    partial class FormReturn
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReturn));
            dgvReturnDisplay = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            panel6 = new Panel();
            txtSearch = new TextBox();
            label14 = new Label();
            panel5 = new Panel();
            groupBox1 = new GroupBox();
            cmbBorrowID = new ComboBox();
            label15 = new Label();
            checkRipped = new CheckBox();
            txtFineAmount = new TextBox();
            label13 = new Label();
            dtpDueDate = new DateTimePicker();
            label12 = new Label();
            dtpBorrowDate = new DateTimePicker();
            btnUpdateDetail = new Button();
            btnInsertDetail = new Button();
            txtBookCode = new TextBox();
            cmbBookTitle = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            dtpReturnDate = new DateTimePicker();
            cmbStaffID = new ComboBox();
            cmbMemberID = new ComboBox();
            txtStaffName = new TextBox();
            txtStaffPosition = new TextBox();
            txtMemberName = new TextBox();
            txtReturnID = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label16 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvReturnDisplay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel7.SuspendLayout();
            panel8.SuspendLayout();
            panel6.SuspendLayout();
            panel5.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReturnDisplay
            // 
            dgvReturnDisplay.AllowUserToAddRows = false;
            dgvReturnDisplay.AllowUserToDeleteRows = false;
            dgvReturnDisplay.AllowUserToResizeColumns = false;
            dgvReturnDisplay.AllowUserToResizeRows = false;
            dgvReturnDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReturnDisplay.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 200);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReturnDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReturnDisplay.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReturnDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReturnDisplay.Dock = DockStyle.Fill;
            dgvReturnDisplay.EnableHeadersVisualStyles = false;
            dgvReturnDisplay.Location = new Point(0, 0);
            dgvReturnDisplay.MultiSelect = false;
            dgvReturnDisplay.Name = "dgvReturnDisplay";
            dgvReturnDisplay.RowHeadersVisible = false;
            dgvReturnDisplay.RowHeadersWidth = 51;
            dgvReturnDisplay.RowTemplate.Height = 29;
            dgvReturnDisplay.ScrollBars = ScrollBars.Vertical;
            dgvReturnDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReturnDisplay.Size = new Size(961, 239);
            dgvReturnDisplay.TabIndex = 45;
            dgvReturnDisplay.CellContentClick += dgvReturnDisplay_CellContentClick;
            dgvReturnDisplay.SelectionChanged += dgvReturnDisplay_SelectionChanged;
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
            panel1.Size = new Size(985, 82);
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
            label8.Size = new Size(196, 26);
            label8.TabIndex = 3;
            label8.Text = "RETURN'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._return;
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
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 812);
            panel3.TabIndex = 6;
            // 
            // panel7
            // 
            panel7.Controls.Add(panel8);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(0, 573);
            panel7.Name = "panel7";
            panel7.Size = new Size(985, 239);
            panel7.TabIndex = 3;
            // 
            // panel8
            // 
            panel8.Controls.Add(dgvReturnDisplay);
            panel8.Location = new Point(12, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(961, 239);
            panel8.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.Controls.Add(txtSearch);
            panel6.Controls.Add(label14);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 516);
            panel6.Name = "panel6";
            panel6.Size = new Size(985, 57);
            panel6.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(257, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(666, 30);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(55, 16);
            label14.Name = "label14";
            label14.Size = new Size(186, 22);
            label14.TabIndex = 40;
            label14.Text = "Search ( Return ID ) : ";
            // 
            // panel5
            // 
            panel5.Controls.Add(groupBox1);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 256);
            panel5.Name = "panel5";
            panel5.Size = new Size(985, 260);
            panel5.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(237, 234, 205);
            groupBox1.Controls.Add(cmbBorrowID);
            groupBox1.Controls.Add(label15);
            groupBox1.Controls.Add(checkRipped);
            groupBox1.Controls.Add(txtFineAmount);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(dtpBorrowDate);
            groupBox1.Controls.Add(btnUpdateDetail);
            groupBox1.Controls.Add(btnInsertDetail);
            groupBox1.Controls.Add(txtBookCode);
            groupBox1.Controls.Add(cmbBookTitle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 256);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Detail";
            // 
            // cmbBorrowID
            // 
            cmbBorrowID.Enabled = false;
            cmbBorrowID.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBorrowID.FormattingEnabled = true;
            cmbBorrowID.IntegralHeight = false;
            cmbBorrowID.Location = new Point(170, 36);
            cmbBorrowID.MaxDropDownItems = 4;
            cmbBorrowID.Name = "cmbBorrowID";
            cmbBorrowID.Size = new Size(278, 35);
            cmbBorrowID.TabIndex = 22;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(36, 101);
            label15.Name = "label15";
            label15.Size = new Size(110, 22);
            label15.TabIndex = 22;
            label15.Text = "Book Code :";
            // 
            // checkRipped
            // 
            checkRipped.AutoSize = true;
            checkRipped.Location = new Point(36, 208);
            checkRipped.Name = "checkRipped";
            checkRipped.Size = new Size(155, 26);
            checkRipped.TabIndex = 12;
            checkRipped.Text = "Ripped Or Lost";
            checkRipped.UseVisualStyleBackColor = true;
            // 
            // txtFineAmount
            // 
            txtFineAmount.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtFineAmount.Location = new Point(626, 146);
            txtFineAmount.Name = "txtFineAmount";
            txtFineAmount.ReadOnly = true;
            txtFineAmount.Size = new Size(285, 35);
            txtFineAmount.TabIndex = 13;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(490, 154);
            label13.Name = "label13";
            label13.Size = new Size(121, 22);
            label13.TabIndex = 21;
            label13.Text = "Fine Amount :";
            // 
            // dtpDueDate
            // 
            dtpDueDate.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDueDate.Format = DateTimePickerFormat.Short;
            dtpDueDate.Location = new Point(626, 88);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(285, 35);
            dtpDueDate.TabIndex = 11;
            dtpDueDate.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(490, 99);
            label12.Name = "label12";
            label12.Size = new Size(100, 22);
            label12.TabIndex = 19;
            label12.Text = "Due Date : ";
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBorrowDate.Format = DateTimePickerFormat.Short;
            dtpBorrowDate.Location = new Point(626, 29);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(285, 35);
            dtpBorrowDate.TabIndex = 9;
            dtpBorrowDate.TabStop = false;
            // 
            // btnUpdateDetail
            // 
            btnUpdateDetail.AutoSize = true;
            btnUpdateDetail.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdateDetail.Cursor = Cursors.Hand;
            btnUpdateDetail.Location = new Point(739, 201);
            btnUpdateDetail.Name = "btnUpdateDetail";
            btnUpdateDetail.Size = new Size(172, 38);
            btnUpdateDetail.TabIndex = 15;
            btnUpdateDetail.Text = "Update";
            btnUpdateDetail.UseVisualStyleBackColor = false;
            btnUpdateDetail.Click += btnUpdateDetail_Click;
            // 
            // btnInsertDetail
            // 
            btnInsertDetail.AutoSize = true;
            btnInsertDetail.BackColor = Color.FromArgb(255, 240, 150);
            btnInsertDetail.Cursor = Cursors.Hand;
            btnInsertDetail.Location = new Point(501, 203);
            btnInsertDetail.Name = "btnInsertDetail";
            btnInsertDetail.Size = new Size(172, 38);
            btnInsertDetail.TabIndex = 14;
            btnInsertDetail.Text = "Insert";
            btnInsertDetail.UseVisualStyleBackColor = false;
            btnInsertDetail.Click += btnInsertDetail_Click;
            // 
            // txtBookCode
            // 
            txtBookCode.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookCode.Location = new Point(170, 91);
            txtBookCode.Name = "txtBookCode";
            txtBookCode.ReadOnly = true;
            txtBookCode.Size = new Size(278, 35);
            txtBookCode.TabIndex = 8;
            // 
            // cmbBookTitle
            // 
            cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBookTitle.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBookTitle.FormattingEnabled = true;
            cmbBookTitle.IntegralHeight = false;
            cmbBookTitle.Location = new Point(170, 146);
            cmbBookTitle.MaxDropDownItems = 4;
            cmbBookTitle.Name = "cmbBookTitle";
            cmbBookTitle.Size = new Size(278, 35);
            cmbBookTitle.TabIndex = 10;
            cmbBookTitle.TextChanged += cmbBookTitle_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 17;
            label1.Text = "Borrow ID :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(490, 40);
            label10.Name = "label10";
            label10.Size = new Size(130, 22);
            label10.TabIndex = 16;
            label10.Text = "Borrow Date : ";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(37, 154);
            label11.Name = "label11";
            label11.Size = new Size(105, 22);
            label11.TabIndex = 15;
            label11.Text = "Book Title :";
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpReturnDate);
            panel4.Controls.Add(cmbStaffID);
            panel4.Controls.Add(cmbMemberID);
            panel4.Controls.Add(txtStaffName);
            panel4.Controls.Add(txtStaffPosition);
            panel4.Controls.Add(txtMemberName);
            panel4.Controls.Add(txtReturnID);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label16);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 256);
            panel4.TabIndex = 0;
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpReturnDate.Format = DateTimePickerFormat.Short;
            dtpReturnDate.Location = new Point(661, 25);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(270, 35);
            dtpReturnDate.TabIndex = 2;
            dtpReturnDate.TabStop = false;
            // 
            // cmbStaffID
            // 
            cmbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffID.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.IntegralHeight = false;
            cmbStaffID.Location = new Point(190, 138);
            cmbStaffID.MaxDropDownItems = 4;
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(270, 35);
            cmbStaffID.TabIndex = 5;
            cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
            // 
            // cmbMemberID
            // 
            cmbMemberID.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.IntegralHeight = false;
            cmbMemberID.Location = new Point(190, 84);
            cmbMemberID.MaxDropDownItems = 5;
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(270, 35);
            cmbMemberID.TabIndex = 3;
            cmbMemberID.SelectedIndexChanged += cmbMemberID_SelectedIndexChanged;
            cmbMemberID.KeyDown += cmbMemberID_KeyDown;
            cmbMemberID.Leave += cmbMemberID_Leave;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(661, 138);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(270, 35);
            txtStaffName.TabIndex = 6;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(190, 195);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(741, 35);
            txtStaffPosition.TabIndex = 7;
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberName.Location = new Point(661, 79);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(270, 35);
            txtMemberName.TabIndex = 4;
            // 
            // txtReturnID
            // 
            txtReturnID.Font = new Font("Khmer OS Siemreap", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtReturnID.Location = new Point(190, 23);
            txtReturnID.Name = "txtReturnID";
            txtReturnID.ReadOnly = true;
            txtReturnID.Size = new Size(270, 35);
            txtReturnID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(510, 34);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 49;
            label2.Text = "Return Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 90);
            label7.Name = "label7";
            label7.Size = new Size(112, 22);
            label7.TabIndex = 48;
            label7.Text = "Member ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 149);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 47;
            label6.Text = "Staff ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(510, 90);
            label5.Name = "label5";
            label5.Size = new Size(143, 22);
            label5.TabIndex = 46;
            label5.Text = "Member Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 208);
            label4.Name = "label4";
            label4.Size = new Size(128, 22);
            label4.TabIndex = 45;
            label4.Text = "Staff Position :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(510, 149);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 44;
            label3.Text = "Staff Name :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(57, 36);
            label16.Name = "label16";
            label16.Size = new Size(98, 22);
            label16.TabIndex = 43;
            label16.Text = "Return ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 234, 224);
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnInsert);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 894);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 90);
            panel2.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(788, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(233, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(418, 23);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 19;
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
            btnClose.Location = new Point(603, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 20;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(48, 23);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // FormReturn
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(985, 984);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1003, 1031);
            MinimumSize = new Size(1003, 950);
            Name = "FormReturn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return's Information";
            Load += FormReturn_Load;
            ((System.ComponentModel.ISupportInitialize)dgvReturnDisplay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel5.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Panel panel2;
        private Panel panel4;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Panel panel5;
        private DateTimePicker dtpReturnDate;
        private ComboBox cmbStaffID;
        private ComboBox cmbMemberID;
        private TextBox txtStaffName;
        private TextBox txtStaffPosition;
        private TextBox txtMemberName;
        private TextBox txtReturnID;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label16;
        private GroupBox groupBox1;
        private DateTimePicker dtpBorrowDate;
        private Button btnUpdateDetail;
        private Button btnInsertDetail;
        private TextBox txtBookCode;
        private ComboBox cmbBookTitle;
        private Label label1;
        private Label label10;
        private Label label11;
        private Panel panel6;
        private CheckBox checkRipped;
        private TextBox txtFineAmount;
        private Label label13;
        private DateTimePicker dtpDueDate;
        private Label label12;
        private Panel panel7;
        private TextBox txtSearch;
        private Label label14;
        private Panel panel8;
        private ComboBox cmbBorrowID;
        private Label label15;
        private DataGridView dgvReturnDisplay;
    }
}