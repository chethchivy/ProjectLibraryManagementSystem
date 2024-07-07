namespace ProjectLibraryManagementSystem
{
    partial class FormBorrow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrow));
            dgvBorrowDisplay = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            btnUpdateDetail = new Button();
            btnInsertDetail = new Button();
            txtBTitle = new TextBox();
            cmbBCode = new ComboBox();
            label1 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            label11 = new Label();
            panel3 = new Panel();
            txtSearch = new TextBox();
            label14 = new Label();
            groupBox1 = new GroupBox();
            dtpDueDate = new DateTimePicker();
            dtpBorrowDate = new DateTimePicker();
            cmbStaffID = new ComboBox();
            cmbMemberID = new ComboBox();
            txtStaffName = new TextBox();
            txtStaffPosition = new TextBox();
            txtMemberName = new TextBox();
            txtBorrowID = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label16 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBorrowDisplay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBorrowDisplay
            // 
            dgvBorrowDisplay.AllowUserToAddRows = false;
            dgvBorrowDisplay.AllowUserToDeleteRows = false;
            dgvBorrowDisplay.AllowUserToResizeColumns = false;
            dgvBorrowDisplay.AllowUserToResizeRows = false;
            dgvBorrowDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBorrowDisplay.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 200);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBorrowDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBorrowDisplay.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBorrowDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBorrowDisplay.Dock = DockStyle.Fill;
            dgvBorrowDisplay.EnableHeadersVisualStyles = false;
            dgvBorrowDisplay.Location = new Point(0, 0);
            dgvBorrowDisplay.MultiSelect = false;
            dgvBorrowDisplay.Name = "dgvBorrowDisplay";
            dgvBorrowDisplay.ReadOnly = true;
            dgvBorrowDisplay.RowHeadersVisible = false;
            dgvBorrowDisplay.RowHeadersWidth = 51;
            dgvBorrowDisplay.RowTemplate.Height = 29;
            dgvBorrowDisplay.ScrollBars = ScrollBars.Vertical;
            dgvBorrowDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBorrowDisplay.Size = new Size(961, 238);
            dgvBorrowDisplay.TabIndex = 44;
            dgvBorrowDisplay.CellContentClick += dgvBorrowDisplay_CellContentClick;
            dgvBorrowDisplay.SelectionChanged += dgvBorrowDisplay_SelectionChanged;
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
            label8.Size = new Size(202, 26);
            label8.TabIndex = 3;
            label8.Text = "BORROW'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.borrow;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(96, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnUpdateDetail
            // 
            btnUpdateDetail.AutoSize = true;
            btnUpdateDetail.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdateDetail.Cursor = Cursors.Hand;
            btnUpdateDetail.Location = new Point(739, 140);
            btnUpdateDetail.Name = "btnUpdateDetail";
            btnUpdateDetail.Size = new Size(172, 38);
            btnUpdateDetail.TabIndex = 12;
            btnUpdateDetail.Text = "Update";
            btnUpdateDetail.UseVisualStyleBackColor = false;
            btnUpdateDetail.Click += btnUpdateDetail_Click;
            // 
            // btnInsertDetail
            // 
            btnInsertDetail.AutoSize = true;
            btnInsertDetail.BackColor = Color.FromArgb(255, 240, 150);
            btnInsertDetail.Cursor = Cursors.Hand;
            btnInsertDetail.Location = new Point(501, 142);
            btnInsertDetail.Name = "btnInsertDetail";
            btnInsertDetail.Size = new Size(172, 38);
            btnInsertDetail.TabIndex = 11;
            btnInsertDetail.Text = "Insert";
            btnInsertDetail.UseVisualStyleBackColor = false;
            btnInsertDetail.Click += btnInsertDetail_Click;
            // 
            // txtBTitle
            // 
            txtBTitle.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBTitle.Location = new Point(170, 94);
            txtBTitle.Name = "txtBTitle";
            txtBTitle.ReadOnly = true;
            txtBTitle.Size = new Size(741, 38);
            txtBTitle.TabIndex = 8;
            // 
            // cmbBCode
            // 
            cmbBCode.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBCode.FormattingEnabled = true;
            cmbBCode.IntegralHeight = false;
            cmbBCode.Location = new Point(170, 32);
            cmbBCode.MaxDropDownItems = 4;
            cmbBCode.Name = "cmbBCode";
            cmbBCode.Size = new Size(270, 38);
            cmbBCode.TabIndex = 10;
            cmbBCode.SelectedIndexChanged += cmbBookTitle_SelectedIndexChanged;
            cmbBCode.Leave += cmbBCode_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 45);
            label1.Name = "label1";
            label1.Size = new Size(110, 22);
            label1.TabIndex = 17;
            label1.Text = "Book Code :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(490, 40);
            label10.Name = "label10";
            label10.Size = new Size(100, 22);
            label10.TabIndex = 16;
            label10.Text = "Due Date : ";
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
            panel2.Location = new Point(0, 838);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 79);
            panel2.TabIndex = 41;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(789, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 18;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(234, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 15;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(419, 17);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 16;
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
            btnClose.Location = new Point(604, 17);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 17;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(49, 17);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 14;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(36, 99);
            label11.Name = "label11";
            label11.Size = new Size(105, 22);
            label11.TabIndex = 15;
            label11.Text = "Book Title :";
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 234, 224);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dtpBorrowDate);
            panel3.Controls.Add(cmbStaffID);
            panel3.Controls.Add(cmbMemberID);
            panel3.Controls.Add(txtStaffName);
            panel3.Controls.Add(txtStaffPosition);
            panel3.Controls.Add(txtMemberName);
            panel3.Controls.Add(txtBorrowID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label16);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 518);
            panel3.TabIndex = 42;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(251, 467);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(672, 30);
            txtSearch.TabIndex = 13;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 470);
            label14.Name = "label14";
            label14.Size = new Size(196, 22);
            label14.TabIndex = 38;
            label14.Text = "Search ( Borrow ID ) : ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(237, 234, 205);
            groupBox1.Controls.Add(dtpDueDate);
            groupBox1.Controls.Add(btnUpdateDetail);
            groupBox1.Controls.Add(btnInsertDetail);
            groupBox1.Controls.Add(txtBTitle);
            groupBox1.Controls.Add(cmbBCode);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 198);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrow Detail";
            // 
            // dtpDueDate
            // 
            dtpDueDate.CustomFormat = "dd-MM-yyyy";
            dtpDueDate.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDueDate.Format = DateTimePickerFormat.Custom;
            dtpDueDate.Location = new Point(596, 29);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(315, 38);
            dtpDueDate.TabIndex = 9;
            dtpDueDate.TabStop = false;
            // 
            // dtpBorrowDate
            // 
            dtpBorrowDate.CustomFormat = "dd-MM-yyyy";
            dtpBorrowDate.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpBorrowDate.Format = DateTimePickerFormat.Custom;
            dtpBorrowDate.Location = new Point(653, 21);
            dtpBorrowDate.Name = "dtpBorrowDate";
            dtpBorrowDate.Size = new Size(270, 38);
            dtpBorrowDate.TabIndex = 2;
            dtpBorrowDate.TabStop = false;
            // 
            // cmbStaffID
            // 
            cmbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.IntegralHeight = false;
            cmbStaffID.Location = new Point(182, 134);
            cmbStaffID.MaxDropDownItems = 5;
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(270, 38);
            cmbStaffID.TabIndex = 5;
            cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
            // 
            // cmbMemberID
            // 
            cmbMemberID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.IntegralHeight = false;
            cmbMemberID.Location = new Point(182, 75);
            cmbMemberID.MaxDropDownItems = 5;
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(270, 38);
            cmbMemberID.TabIndex = 3;
            cmbMemberID.SelectedIndexChanged += cmbMemberID_SelectedIndexChanged;
            cmbMemberID.KeyDown += cmbMemberID_KeyDown;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(653, 134);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(270, 38);
            txtStaffName.TabIndex = 6;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(182, 188);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(741, 38);
            txtStaffPosition.TabIndex = 7;
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberName.Location = new Point(653, 75);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(270, 38);
            txtMemberName.TabIndex = 4;
            // 
            // txtBorrowID
            // 
            txtBorrowID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowID.Location = new Point(182, 19);
            txtBorrowID.Name = "txtBorrowID";
            txtBorrowID.ReadOnly = true;
            txtBorrowID.Size = new Size(270, 38);
            txtBorrowID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 27);
            label2.Name = "label2";
            label2.Size = new Size(125, 22);
            label2.TabIndex = 35;
            label2.Text = "Borrow Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 83);
            label7.Name = "label7";
            label7.Size = new Size(112, 22);
            label7.TabIndex = 33;
            label7.Text = "Member ID :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 142);
            label6.Name = "label6";
            label6.Size = new Size(83, 22);
            label6.TabIndex = 31;
            label6.Text = "Staff ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 83);
            label5.Name = "label5";
            label5.Size = new Size(143, 22);
            label5.TabIndex = 29;
            label5.Text = "Member Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 197);
            label4.Name = "label4";
            label4.Size = new Size(128, 22);
            label4.TabIndex = 27;
            label4.Text = "Staff Position :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 142);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 25;
            label3.Text = "Staff Name :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(49, 29);
            label16.Name = "label16";
            label16.Size = new Size(108, 22);
            label16.TabIndex = 20;
            label16.Text = "Borrow ID :";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(237, 234, 224);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 600);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 238);
            panel4.TabIndex = 43;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvBorrowDisplay);
            panel5.Location = new Point(12, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(961, 238);
            panel5.TabIndex = 0;
            // 
            // FormBorrow
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(985, 917);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1003, 1000);
            MinimumSize = new Size(1003, 900);
            Name = "FormBorrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow's Information";
            Load += FormBorrow_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBorrowDisplay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Button btnUpdateDetail;
        private Button btnInsertDetail;
        private TextBox txtBTitle;
        private ComboBox cmbBCode;
        private Label label1;
        private Label label10;
        private Panel panel2;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Label label11;
        private Panel panel3;
        private TextBox txtSearch;
        private Label label14;
        private GroupBox groupBox1;
        private DateTimePicker dtpBorrowDate;
        private ComboBox cmbStaffID;
        private ComboBox cmbMemberID;
        private TextBox txtStaffName;
        private TextBox txtStaffPosition;
        private TextBox txtMemberName;
        private TextBox txtBorrowID;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label16;
        private Panel panel4;
        private DateTimePicker dtpDueDate;
        private Panel panel5;
        private DataGridView dgvBorrowDisplay;
    }
}