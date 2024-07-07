namespace ProjectLibraryManagementSystem
{
    partial class FormCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCard));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            dtpExpireCard = new DateTimePicker();
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
            dtpCreateCard = new DateTimePicker();
            txtCardID = new TextBox();
            panel4 = new Panel();
            ltbCardDisplay = new ListBox();
            txtSearch = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnClose = new Button();
            btnNew = new Button();
            btnInsert = new Button();
            btnUpdate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
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
            panel1.Size = new Size(886, 82);
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
            label8.Size = new Size(271, 26);
            label8.TabIndex = 3;
            label8.Text = "MEMBER CARD'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.card;
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
            panel3.Size = new Size(886, 561);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(dtpExpireCard);
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
            panel5.Controls.Add(dtpCreateCard);
            panel5.Controls.Add(txtCardID);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(319, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(567, 561);
            panel5.TabIndex = 1;
            // 
            // dtpExpireCard
            // 
            dtpExpireCard.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpExpireCard.Format = DateTimePickerFormat.Short;
            dtpExpireCard.Location = new Point(174, 174);
            dtpExpireCard.Name = "dtpExpireCard";
            dtpExpireCard.Size = new Size(362, 42);
            dtpExpireCard.TabIndex = 4;
            dtpExpireCard.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 377);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 78;
            label2.Text = "Staff ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 442);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 77;
            label3.Text = "Staff Name :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(28, 507);
            label5.Name = "label5";
            label5.Size = new Size(128, 22);
            label5.TabIndex = 76;
            label5.Text = "Staff Position :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 312);
            label10.Name = "label10";
            label10.Size = new Size(138, 22);
            label10.TabIndex = 75;
            label10.Text = "Member Name :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 120);
            label7.Name = "label7";
            label7.Size = new Size(115, 22);
            label7.TabIndex = 74;
            label7.Text = "Create Date :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 185);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 73;
            label6.Text = "Expire Date : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 247);
            label4.Name = "label4";
            label4.Size = new Size(112, 22);
            label4.TabIndex = 72;
            label4.Text = "Member ID :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(27, 52);
            label16.Name = "label16";
            label16.Size = new Size(95, 22);
            label16.TabIndex = 71;
            label16.Text = "Card ID  : ";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(175, 499);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(363, 42);
            txtStaffPosition.TabIndex = 9;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(176, 434);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(362, 42);
            txtStaffName.TabIndex = 8;
            // 
            // cmbStaffID
            // 
            cmbStaffID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.IntegralHeight = false;
            cmbStaffID.Location = new Point(176, 369);
            cmbStaffID.MaxDropDownItems = 5;
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(362, 42);
            cmbStaffID.TabIndex = 7;
            cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
            cmbStaffID.SelectionChangeCommitted += cmbStaffID_SelectionChangeCommitted;
            // 
            // txtMemberName
            // 
            txtMemberName.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtMemberName.Location = new Point(175, 304);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.ReadOnly = true;
            txtMemberName.Size = new Size(363, 42);
            txtMemberName.TabIndex = 6;
            // 
            // cmbMemberID
            // 
            cmbMemberID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            cmbMemberID.FormattingEnabled = true;
            cmbMemberID.IntegralHeight = false;
            cmbMemberID.Location = new Point(176, 239);
            cmbMemberID.MaxDropDownItems = 5;
            cmbMemberID.Name = "cmbMemberID";
            cmbMemberID.Size = new Size(362, 42);
            cmbMemberID.TabIndex = 5;
            cmbMemberID.SelectedIndexChanged += cmbMemberID_SelectedIndexChanged;
            cmbMemberID.SelectionChangeCommitted += cmbMemberID_SelectionChangeCommitted;
            // 
            // dtpCreateCard
            // 
            dtpCreateCard.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            dtpCreateCard.Format = DateTimePickerFormat.Short;
            dtpCreateCard.Location = new Point(175, 109);
            dtpCreateCard.Name = "dtpCreateCard";
            dtpCreateCard.Size = new Size(362, 42);
            dtpCreateCard.TabIndex = 3;
            dtpCreateCard.TabStop = false;
            // 
            // txtCardID
            // 
            txtCardID.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCardID.Location = new Point(174, 44);
            txtCardID.Name = "txtCardID";
            txtCardID.ReadOnly = true;
            txtCardID.Size = new Size(149, 42);
            txtCardID.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(ltbCardDisplay);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(319, 561);
            panel4.TabIndex = 0;
            // 
            // ltbCardDisplay
            // 
            ltbCardDisplay.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ltbCardDisplay.FormattingEnabled = true;
            ltbCardDisplay.ItemHeight = 34;
            ltbCardDisplay.Location = new Point(30, 100);
            ltbCardDisplay.Name = "ltbCardDisplay";
            ltbCardDisplay.Size = new Size(262, 412);
            ltbCardDisplay.TabIndex = 59;
            ltbCardDisplay.SelectedIndexChanged += ltbCardDisplay_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(30, 49);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter CardID or MemberName";
            txtSearch.Size = new Size(262, 34);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 22);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 58;
            label1.Text = "Search : ";
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnClose);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnUpdate);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 643);
            panel2.Name = "panel2";
            panel2.Size = new Size(886, 90);
            panel2.TabIndex = 5;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(714, 25);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(142, 39);
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(543, 25);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(142, 39);
            btnClose.TabIndex = 13;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(372, 25);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(142, 39);
            btnNew.TabIndex = 12;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(30, 25);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(142, 39);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(201, 25);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(142, 39);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // FormCard
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(886, 733);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(904, 780);
            MinimumSize = new Size(904, 780);
            Name = "FormCard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Card's Information";
            Load += FormCard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
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
        private Panel panel5;
        private Panel panel4;
        private ListBox ltbCardDisplay;
        private TextBox txtSearch;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label10;
        private Label label7;
        private Label label6;
        private Label label4;
        private Label label16;
        private TextBox txtStaffPosition;
        private TextBox txtStaffName;
        private ComboBox cmbStaffID;
        private TextBox txtMemberName;
        private ComboBox cmbMemberID;
        private DateTimePicker dtpCreateCard;
        private TextBox txtCardID;
        private DateTimePicker dtpExpireCard;
        private Button btnLogout;
        private Button btnClose;
        private Button btnNew;
        private Button btnInsert;
        private Button btnUpdate;
    }
}