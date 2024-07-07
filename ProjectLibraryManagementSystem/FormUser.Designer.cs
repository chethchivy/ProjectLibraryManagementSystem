namespace ProjectLibraryManagementSystem
{
    partial class FormUser
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnLogout = new Button();
            btnNew = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            btnClose = new Button();
            panel3 = new Panel();
            ptbHide = new PictureBox();
            ptbShow = new PictureBox();
            txtStaffName = new TextBox();
            ltbDisplay = new ListBox();
            cboStaffID = new ComboBox();
            txtUserID = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtStaffPosition = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtSearch = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHide).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbShow).BeginInit();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 96);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(147, 55);
            label9.Name = "label9";
            label9.Size = new Size(282, 17);
            label9.TabIndex = 2;
            label9.Text = "@Copyright ISAD-SLS-G25-GROUP4 (2024)";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(147, 20);
            label8.Name = "label8";
            label8.Size = new Size(163, 26);
            label8.TabIndex = 1;
            label8.Text = "USER'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(36, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(94, 75);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(btnLogout);
            panel2.Controls.Add(btnNew);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(btnInsert);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 78);
            panel2.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(637, 17);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(106, 39);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnNew
            // 
            btnNew.BackColor = Color.LightGray;
            btnNew.Cursor = Cursors.Hand;
            btnNew.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnNew.Location = new Point(333, 17);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(106, 39);
            btnNew.TabIndex = 18;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = false;
            btnNew.Click += btnNew_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(181, 17);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 39);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.BackColor = Color.FromArgb(255, 240, 150);
            btnInsert.Cursor = Cursors.Hand;
            btnInsert.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInsert.Location = new Point(29, 17);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(106, 39);
            btnInsert.TabIndex = 16;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.LightGray;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnClose.ForeColor = Color.Black;
            btnClose.Location = new Point(485, 17);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(106, 39);
            btnClose.TabIndex = 19;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(237, 234, 224);
            panel3.Controls.Add(ptbHide);
            panel3.Controls.Add(ptbShow);
            panel3.Controls.Add(txtStaffName);
            panel3.Controls.Add(ltbDisplay);
            panel3.Controls.Add(cboStaffID);
            panel3.Controls.Add(txtUserID);
            panel3.Controls.Add(txtUserName);
            panel3.Controls.Add(txtPassword);
            panel3.Controls.Add(txtStaffPosition);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSearch);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 96);
            panel3.Name = "panel3";
            panel3.Size = new Size(776, 496);
            panel3.TabIndex = 2;
            // 
            // ptbHide
            // 
            ptbHide.BackColor = Color.White;
            ptbHide.Image = Properties.Resources.show;
            ptbHide.Location = new Point(704, 243);
            ptbHide.Name = "ptbHide";
            ptbHide.Size = new Size(26, 22);
            ptbHide.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHide.TabIndex = 58;
            ptbHide.TabStop = false;
            ptbHide.Visible = false;
            ptbHide.Click += ptbHide_Click;
            // 
            // ptbShow
            // 
            ptbShow.BackColor = Color.White;
            ptbShow.Image = Properties.Resources.hide;
            ptbShow.Location = new Point(704, 243);
            ptbShow.Name = "ptbShow";
            ptbShow.Size = new Size(26, 22);
            ptbShow.SizeMode = PictureBoxSizeMode.Zoom;
            ptbShow.TabIndex = 57;
            ptbShow.TabStop = false;
            ptbShow.Click += ptbShow_Click;
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(464, 351);
            txtStaffName.Multiline = true;
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(278, 40);
            txtStaffName.TabIndex = 47;
            txtStaffName.Tag = "StaffName";
            // 
            // ltbDisplay
            // 
            ltbDisplay.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ltbDisplay.FormattingEnabled = true;
            ltbDisplay.ItemHeight = 30;
            ltbDisplay.Location = new Point(37, 113);
            ltbDisplay.Name = "ltbDisplay";
            ltbDisplay.Size = new Size(262, 334);
            ltbDisplay.TabIndex = 56;
            ltbDisplay.SelectedIndexChanged += ltbDisplay_SelectedIndexChanged;
            // 
            // cboStaffID
            // 
            cboStaffID.AllowDrop = true;
            cboStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStaffID.Font = new Font("Times New Roman", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            cboStaffID.FormattingEnabled = true;
            cboStaffID.IntegralHeight = false;
            cboStaffID.ItemHeight = 26;
            cboStaffID.Location = new Point(464, 293);
            cboStaffID.MaxDropDownItems = 5;
            cboStaffID.Name = "cboStaffID";
            cboStaffID.Size = new Size(278, 34);
            cboStaffID.TabIndex = 46;
            cboStaffID.SelectedIndexChanged += cboStaffID_SelectedIndexChanged;
            cboStaffID.SelectionChangeCommitted += cboStaffID_SelectionChangeCommitted;
            // 
            // txtUserID
            // 
            txtUserID.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserID.Location = new Point(464, 113);
            txtUserID.Multiline = true;
            txtUserID.Name = "txtUserID";
            txtUserID.ReadOnly = true;
            txtUserID.Size = new Size(278, 40);
            txtUserID.TabIndex = 43;
            txtUserID.UseWaitCursor = true;
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUserName.Location = new Point(464, 173);
            txtUserName.Multiline = true;
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(278, 40);
            txtUserName.TabIndex = 44;
            txtUserName.Tag = "UserName";
            txtUserName.UseWaitCursor = true;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(464, 233);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(278, 40);
            txtPassword.TabIndex = 45;
            txtPassword.Tag = "Password";
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(464, 417);
            txtStaffPosition.Multiline = true;
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(278, 40);
            txtStaffPosition.TabIndex = 48;
            txtStaffPosition.Tag = "StaffPosition";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(322, 131);
            label7.Name = "label7";
            label7.Size = new Size(88, 22);
            label7.TabIndex = 55;
            label7.Text = "User ID : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(322, 191);
            label6.Name = "label6";
            label6.Size = new Size(109, 22);
            label6.TabIndex = 54;
            label6.Text = "UserName : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(322, 251);
            label5.Name = "label5";
            label5.Size = new Size(99, 22);
            label5.TabIndex = 53;
            label5.Text = "Password :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(322, 427);
            label4.Name = "label4";
            label4.Size = new Size(123, 22);
            label4.TabIndex = 52;
            label4.Text = "StaffPosition :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(322, 365);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 51;
            label3.Text = "StaffName :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(322, 305);
            label2.Name = "label2";
            label2.Size = new Size(78, 22);
            label2.TabIndex = 50;
            label2.Text = "StaffID :";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(37, 62);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Enter UserID or UserName";
            txtSearch.Size = new Size(262, 34);
            txtSearch.TabIndex = 42;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 35);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 49;
            label1.Text = "Search : ";
            // 
            // FormUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(776, 670);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(794, 717);
            MinimumSize = new Size(794, 717);
            Name = "FormUser";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "User's Information";
            Load += FormUser_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbHide).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label9;
        private Label label8;
        private Panel panel3;
        private TextBox txtStaffName;
        private ListBox ltbDisplay;
        private ComboBox cboStaffID;
        private TextBox txtUserID;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtStaffPosition;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtSearch;
        private Label label1;
        private Button btnLogout;
        private Button btnNew;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnClose;
        private PictureBox ptbHide;
        private PictureBox ptbShow;
    }
}