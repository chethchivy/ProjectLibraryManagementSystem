namespace ProjectLibraryManagementSystem
{
    partial class FormBorrowExpire
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBorrowExpire));
            dgvBEDisplay = new DataGridView();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtSearch = new TextBox();
            label6 = new Label();
            panel5 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            panel4 = new Panel();
            dtpEBID = new DateTimePicker();
            txtBookTitle = new TextBox();
            txtBorrowExpireID = new TextBox();
            cmbMemberID = new ComboBox();
            cmbBorrowID = new ComboBox();
            lb_BookTitle = new Label();
            lb_MemberID = new Label();
            lb_BorrowID = new Label();
            lb_ExpiredDate = new Label();
            lb_BorrowExpireID = new Label();
            panel2 = new Panel();
            panel6 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvBEDisplay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // dgvBEDisplay
            // 
            dgvBEDisplay.AllowUserToAddRows = false;
            dgvBEDisplay.AllowUserToDeleteRows = false;
            dgvBEDisplay.AllowUserToResizeColumns = false;
            dgvBEDisplay.AllowUserToResizeRows = false;
            dgvBEDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBEDisplay.BackgroundColor = Color.WhiteSmoke;
            dgvBEDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 200);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvBEDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvBEDisplay.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvBEDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            dgvBEDisplay.Dock = DockStyle.Fill;
            dgvBEDisplay.EnableHeadersVisualStyles = false;
            dgvBEDisplay.Location = new Point(0, 0);
            dgvBEDisplay.MultiSelect = false;
            dgvBEDisplay.Name = "dgvBEDisplay";
            dgvBEDisplay.ReadOnly = true;
            dgvBEDisplay.RowHeadersVisible = false;
            dgvBEDisplay.RowHeadersWidth = 51;
            dgvBEDisplay.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvBEDisplay.RowTemplate.Height = 29;
            dgvBEDisplay.ScrollBars = ScrollBars.Vertical;
            dgvBEDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBEDisplay.Size = new Size(961, 275);
            dgvBEDisplay.TabIndex = 1;
            dgvBEDisplay.CellClick += dgvBEDisplay_CellClick;
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
            label8.Size = new Size(291, 26);
            label8.TabIndex = 3;
            label8.Text = "BORROW EXIPRE'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.expire;
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
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 478);
            panel3.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(243, 430);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(704, 30);
            txtSearch.TabIndex = 11;
            txtSearch.Click += txtSearch_Click;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 433);
            label6.Name = "label6";
            label6.Size = new Size(195, 22);
            label6.TabIndex = 29;
            label6.Text = "Search ( MemberID ) : ";
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnNew);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnInsert);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 337);
            panel5.Name = "panel5";
            panel5.Size = new Size(985, 74);
            panel5.TabIndex = 27;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(789, 16);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(146, 42);
            btnLogout.TabIndex = 10;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(234, 16);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(146, 42);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(419, 16);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(146, 42);
            btnNew.TabIndex = 8;
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
            btnClose.Location = new Point(604, 16);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(146, 42);
            btnClose.TabIndex = 9;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(49, 16);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtpEBID);
            panel4.Controls.Add(txtBookTitle);
            panel4.Controls.Add(txtBorrowExpireID);
            panel4.Controls.Add(cmbMemberID);
            panel4.Controls.Add(cmbBorrowID);
            panel4.Controls.Add(lb_BookTitle);
            panel4.Controls.Add(lb_MemberID);
            panel4.Controls.Add(lb_BorrowID);
            panel4.Controls.Add(lb_ExpiredDate);
            panel4.Controls.Add(lb_BorrowExpireID);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 337);
            panel4.TabIndex = 26;
            // 
            // dtpEBID
            // 
            dtpEBID.CustomFormat = "yyyy-MM-dd";
            dtpEBID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dtpEBID.Format = DateTimePickerFormat.Custom;
            dtpEBID.ImeMode = ImeMode.NoControl;
            dtpEBID.Location = new Point(233, 84);
            dtpEBID.Name = "dtpEBID";
            dtpEBID.Size = new Size(325, 38);
            dtpEBID.TabIndex = 26;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookTitle.Location = new Point(233, 281);
            txtBookTitle.Margin = new Padding(4, 3, 4, 3);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(714, 42);
            txtBookTitle.TabIndex = 5;
            // 
            // txtBorrowExpireID
            // 
            txtBorrowExpireID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBorrowExpireID.Location = new Point(233, 23);
            txtBorrowExpireID.Margin = new Padding(4, 3, 4, 3);
            txtBorrowExpireID.Name = "txtBorrowExpireID";
            txtBorrowExpireID.ReadOnly = true;
            txtBorrowExpireID.Size = new Size(325, 42);
            txtBorrowExpireID.TabIndex = 1;
            // 
            // cmbMemberID
            // 
            cmbMemberID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.Location = new Point(233, 212);
            cmbMemberID.Margin = new Padding(4, 3, 4, 3);
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(714, 42);
            cmbMemberID.TabIndex = 4;
            // 
            // cmbBorrowID
            // 
            cmbBorrowID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBorrowID.FormattingEnabled = true;
            cmbBorrowID.Location = new Point(233, 147);
            cmbBorrowID.Margin = new Padding(4, 3, 4, 3);
            cmbBorrowID.Name = "cmbBorrowID";
            cmbBorrowID.Size = new Size(714, 42);
            cmbBorrowID.TabIndex = 3;
            // 
            // lb_BookTitle
            // 
            lb_BookTitle.AutoSize = true;
            lb_BookTitle.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_BookTitle.Location = new Point(40, 289);
            lb_BookTitle.Margin = new Padding(4, 0, 4, 0);
            lb_BookTitle.Name = "lb_BookTitle";
            lb_BookTitle.Size = new Size(105, 22);
            lb_BookTitle.TabIndex = 25;
            lb_BookTitle.Text = "Book Title :";
            // 
            // lb_MemberID
            // 
            lb_MemberID.AutoSize = true;
            lb_MemberID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_MemberID.Location = new Point(38, 220);
            lb_MemberID.Margin = new Padding(4, 0, 4, 0);
            lb_MemberID.Name = "lb_MemberID";
            lb_MemberID.Size = new Size(112, 22);
            lb_MemberID.TabIndex = 24;
            lb_MemberID.Text = "Member ID :";
            // 
            // lb_BorrowID
            // 
            lb_BorrowID.AutoSize = true;
            lb_BorrowID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_BorrowID.Location = new Point(40, 155);
            lb_BorrowID.Margin = new Padding(4, 0, 4, 0);
            lb_BorrowID.Name = "lb_BorrowID";
            lb_BorrowID.Size = new Size(108, 22);
            lb_BorrowID.TabIndex = 23;
            lb_BorrowID.Text = "Borrow ID :";
            // 
            // lb_ExpiredDate
            // 
            lb_ExpiredDate.AutoSize = true;
            lb_ExpiredDate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_ExpiredDate.Location = new Point(40, 92);
            lb_ExpiredDate.Margin = new Padding(4, 0, 4, 0);
            lb_ExpiredDate.Name = "lb_ExpiredDate";
            lb_ExpiredDate.Size = new Size(126, 22);
            lb_ExpiredDate.TabIndex = 22;
            lb_ExpiredDate.Text = "Expired Date :";
            // 
            // lb_BorrowExpireID
            // 
            lb_BorrowExpireID.AutoSize = true;
            lb_BorrowExpireID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lb_BorrowExpireID.Location = new Point(40, 31);
            lb_BorrowExpireID.Margin = new Padding(4, 0, 4, 0);
            lb_BorrowExpireID.Name = "lb_BorrowExpireID";
            lb_BorrowExpireID.Size = new Size(166, 22);
            lb_BorrowExpireID.TabIndex = 21;
            lb_BorrowExpireID.Text = "Borrow Expire ID :";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 234, 224);
            panel2.Controls.Add(panel6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 560);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 293);
            panel2.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Controls.Add(dgvBEDisplay);
            panel6.Location = new Point(11, 5);
            panel6.Name = "panel6";
            panel6.Size = new Size(961, 275);
            panel6.TabIndex = 0;
            // 
            // FormBorrowExpire
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(985, 853);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1003, 1000);
            MinimumSize = new Size(1003, 900);
            Name = "FormBorrowExpire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BorrowExpire's Information";
            Load += FormBorrowExpire_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBEDisplay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
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
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Panel panel4;
        private TextBox txtBookTitle;
        private TextBox txtBorrowExpireID;
        private ComboBox cmbMemberID;
        private ComboBox cmbBorrowID;
        private Label lb_BookTitle;
        private Label lb_MemberID;
        private Label lb_BorrowID;
        private Label lb_ExpiredDate;
        private Label lb_BorrowExpireID;
        private TextBox txtSearch;
        private Label label6;
        private Panel panel6;
        private DataGridView dgvBEDisplay;
        private DateTimePicker dtpEBID;
    }
}