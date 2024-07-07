namespace ProjectLibraryManagementSystem
{
    partial class FormRenew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRenew));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            btnSearch = new Button();
            cmbBorrowID = new ComboBox();
            label1 = new Label();
            label11 = new Label();
            cmbBookCode = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label10 = new Label();
            label7 = new Label();
            label6 = new Label();
            label4 = new Label();
            label16 = new Label();
            txtStaffPosition = new TextBox();
            txtStaffName = new TextBox();
            cmbStaffID = new ComboBox();
            txtMemberName = new TextBox();
            cmbMemberID = new ComboBox();
            dtpNewDueDate = new DateTimePicker();
            dtpRenewDate = new DateTimePicker();
            txtRenewID = new TextBox();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Size = new Size(983, 82);
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
            label8.Size = new Size(185, 26);
            label8.TabIndex = 3;
            label8.Text = "RENEW'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.renew;
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
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(983, 669);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnSearch);
            panel5.Controls.Add(cmbBorrowID);
            panel5.Controls.Add(label1);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(cmbBookCode);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label16);
            panel5.Controls.Add(txtStaffPosition);
            panel5.Controls.Add(txtStaffName);
            panel5.Controls.Add(cmbStaffID);
            panel5.Controls.Add(txtMemberName);
            panel5.Controls.Add(cmbMemberID);
            panel5.Controls.Add(dtpNewDueDate);
            panel5.Controls.Add(dtpRenewDate);
            panel5.Controls.Add(txtRenewID);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(983, 669);
            panel5.TabIndex = 1;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(255, 240, 150);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(692, 21);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(146, 42);
            btnSearch.TabIndex = 46;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // cmbBorrowID
            // 
            cmbBorrowID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBorrowID.FormattingEnabled = true;
            cmbBorrowID.IntegralHeight = false;
            cmbBorrowID.Location = new Point(262, 345);
            cmbBorrowID.MaxDropDownItems = 5;
            cmbBorrowID.Name = "cmbBorrowID";
            cmbBorrowID.Size = new Size(574, 42);
            cmbBorrowID.TabIndex = 45;
            cmbBorrowID.SelectedIndexChanged += cmbBorrowID_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(114, 353);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 44;
            label1.Text = "Borrow ID :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(114, 224);
            label11.Name = "label11";
            label11.Size = new Size(112, 22);
            label11.TabIndex = 43;
            label11.Text = "Member ID :";
            // 
            // cmbBookCode
            // 
            cmbBookCode.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBookCode.FormattingEnabled = true;
            cmbBookCode.IntegralHeight = false;
            cmbBookCode.Location = new Point(264, 408);
            cmbBookCode.MaxDropDownItems = 5;
            cmbBookCode.Name = "cmbBookCode";
            cmbBookCode.Size = new Size(574, 42);
            cmbBookCode.TabIndex = 42;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 481);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 41;
            label2.Text = "Staff ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(115, 546);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 40;
            label3.Text = "Staff Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(116, 611);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 39;
            label5.Text = "Staff Position :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(116, 416);
            label10.Name = "label10";
            label10.Size = new Size(110, 22);
            label10.TabIndex = 38;
            label10.Text = "Book Code :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(114, 97);
            label7.Name = "label7";
            label7.Size = new Size(118, 22);
            label7.TabIndex = 37;
            label7.Text = "Renew Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(115, 162);
            label6.Name = "label6";
            label6.Size = new Size(133, 22);
            label6.TabIndex = 36;
            label6.Text = "New DueDate :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(116, 290);
            label4.Name = "label4";
            label4.Size = new Size(138, 22);
            label4.TabIndex = 35;
            label4.Text = "Member Name :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(115, 29);
            label16.Name = "label16";
            label16.Size = new Size(106, 22);
            label16.TabIndex = 34;
            label16.Text = "Renew ID : ";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(263, 603);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(575, 42);
            txtStaffPosition.TabIndex = 9;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(264, 538);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(574, 42);
            txtStaffName.TabIndex = 8;
            // 
            // cmbStaffID
            // 
            cmbStaffID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.IntegralHeight = false;
            cmbStaffID.Location = new Point(264, 473);
            cmbStaffID.MaxDropDownItems = 4;
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(574, 42);
            cmbStaffID.TabIndex = 7;
            cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberName.Location = new Point(263, 282);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(575, 42);
            txtMemberName.TabIndex = 6;
            // 
            // cmbMemberID
            // 
            cmbMemberID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.IntegralHeight = false;
            cmbMemberID.Location = new Point(262, 216);
            cmbMemberID.MaxDropDownItems = 5;
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(576, 42);
            cmbMemberID.TabIndex = 5;
            cmbMemberID.SelectedIndexChanged += cmbMemberID_SelectedIndexChanged;
            cmbMemberID.KeyDown += cmbMemberID_KeyDown;
            cmbMemberID.Leave += cmbMemberID_Leave;
            // 
            // dtpNewDueDate
            // 
            dtpNewDueDate.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpNewDueDate.Format = DateTimePickerFormat.Short;
            dtpNewDueDate.Location = new Point(263, 151);
            dtpNewDueDate.Name = "dtpNewDueDate";
            dtpNewDueDate.Size = new Size(575, 42);
            dtpNewDueDate.TabIndex = 4;
            dtpNewDueDate.TabStop = false;
            // 
            // dtpRenewDate
            // 
            dtpRenewDate.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpRenewDate.Format = DateTimePickerFormat.Short;
            dtpRenewDate.Location = new Point(263, 86);
            dtpRenewDate.Name = "dtpRenewDate";
            dtpRenewDate.Size = new Size(575, 42);
            dtpRenewDate.TabIndex = 3;
            dtpRenewDate.TabStop = false;
            // 
            // txtRenewID
            // 
            txtRenewID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtRenewID.Location = new Point(262, 21);
            txtRenewID.Name = "txtRenewID";
            txtRenewID.PlaceholderText = "RenewID will be auto generate";
            txtRenewID.Size = new Size(407, 42);
            txtRenewID.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnInsert);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 751);
            panel2.Name = "panel2";
            panel2.Size = new Size(983, 90);
            panel2.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(787, 23);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(232, 23);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(417, 23);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 12;
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
            btnClose.Location = new Point(602, 23);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(47, 23);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // FormRenew
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(983, 841);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1001, 888);
            MinimumSize = new Size(1001, 888);
            Name = "FormRenew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Renew's Information";
            Load += FormRenew_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel5;
        private TextBox txtRenewID;
        private DateTimePicker dtpNewDueDate;
        private DateTimePicker dtpRenewDate;
        private ComboBox cmbMemberID;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private ComboBox cmbStaffID;
        private TextBox txtMemberName;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label16;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label10;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Label label11;
        private ComboBox cmbBookCode;
        private ComboBox cmbBorrowID;
        private Label label1;
        private Button btnSearch;
    }
}