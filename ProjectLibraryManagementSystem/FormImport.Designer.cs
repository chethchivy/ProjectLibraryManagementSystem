namespace ProjectLibraryManagementSystem
{
    partial class FormImport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImport));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtSearch = new TextBox();
            label14 = new Label();
            groupBox1 = new GroupBox();
            btnUpdateDetail = new Button();
            btnInsertDetail = new Button();
            txtBookQty = new TextBox();
            txtBTitle = new TextBox();
            label13 = new Label();
            cmbBCode = new ComboBox();
            txtUnitPrice = new TextBox();
            txtAmount = new TextBox();
            label1 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            dtpImpDate = new DateTimePicker();
            txtStaffPosition = new TextBox();
            cmbStaffID = new ComboBox();
            cmbSupID = new ComboBox();
            txtSupName = new TextBox();
            txtStaffName = new TextBox();
            txtTotal = new TextBox();
            txtImpID = new TextBox();
            label2 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label15 = new Label();
            label16 = new Label();
            panel2 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            dgvImpDetail = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvImpDetail).BeginInit();
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
            label8.Size = new Size(192, 26);
            label8.TabIndex = 3;
            label8.Text = "IMPORT'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.import_;
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
            panel3.Controls.Add(label14);
            panel3.Controls.Add(groupBox1);
            panel3.Controls.Add(dtpImpDate);
            panel3.Controls.Add(txtStaffPosition);
            panel3.Controls.Add(cmbStaffID);
            panel3.Controls.Add(cmbSupID);
            panel3.Controls.Add(txtSupName);
            panel3.Controls.Add(txtStaffName);
            panel3.Controls.Add(txtTotal);
            panel3.Controls.Add(txtImpID);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(label16);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 585);
            panel3.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(241, 533);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(682, 30);
            txtSearch.TabIndex = 16;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(49, 536);
            label14.Name = "label14";
            label14.Size = new Size(186, 22);
            label14.TabIndex = 38;
            label14.Text = "Search ( Import ID ) : ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(237, 234, 205);
            groupBox1.Controls.Add(btnUpdateDetail);
            groupBox1.Controls.Add(btnInsertDetail);
            groupBox1.Controls.Add(txtBookQty);
            groupBox1.Controls.Add(txtBTitle);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(cmbBCode);
            groupBox1.Controls.Add(txtUnitPrice);
            groupBox1.Controls.Add(txtAmount);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label12);
            groupBox1.Location = new Point(12, 305);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(961, 209);
            groupBox1.TabIndex = 37;
            groupBox1.TabStop = false;
            groupBox1.Text = "Import Detail";
            // 
            // btnUpdateDetail
            // 
            btnUpdateDetail.AutoSize = true;
            btnUpdateDetail.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdateDetail.Cursor = Cursors.Hand;
            btnUpdateDetail.Location = new Point(739, 144);
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
            btnInsertDetail.Location = new Point(501, 146);
            btnInsertDetail.Name = "btnInsertDetail";
            btnInsertDetail.Size = new Size(172, 38);
            btnInsertDetail.TabIndex = 14;
            btnInsertDetail.Text = "Insert";
            btnInsertDetail.UseVisualStyleBackColor = false;
            btnInsertDetail.Click += btnInsertDetail_Click;
            // 
            // txtBookQty
            // 
            txtBookQty.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookQty.Location = new Point(185, 146);
            txtBookQty.Name = "txtBookQty";
            txtBookQty.Size = new Size(255, 38);
            txtBookQty.TabIndex = 11;
            txtBookQty.Tag = "Book Quantity";
            txtBookQty.TextChanged += txtBookQty_TextChanged;
            // 
            // txtBTitle
            // 
            txtBTitle.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBTitle.Location = new Point(185, 91);
            txtBTitle.Name = "txtBTitle";
            txtBTitle.ReadOnly = true;
            txtBTitle.Size = new Size(255, 38);
            txtBTitle.TabIndex = 9;
            txtBTitle.Tag = "Book";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(37, 154);
            label13.Name = "label13";
            label13.Size = new Size(96, 22);
            label13.TabIndex = 22;
            label13.Text = "Book Qty :";
            // 
            // cmbBCode
            // 
            cmbBCode.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBCode.FormattingEnabled = true;
            cmbBCode.ImeMode = ImeMode.NoControl;
            cmbBCode.IntegralHeight = false;
            cmbBCode.Location = new Point(185, 32);
            cmbBCode.MaxDropDownItems = 5;
            cmbBCode.Name = "cmbBCode";
            cmbBCode.Size = new Size(255, 38);
            cmbBCode.TabIndex = 10;
            cmbBCode.Tag = "BookCode";
            cmbBCode.SelectedIndexChanged += cmbBCode_SelectedIndexChanged;
            cmbBCode.KeyDown += cmbBCode_KeyDown;
            cmbBCode.Leave += cmbBCode_Leave;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUnitPrice.Location = new Point(641, 32);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(270, 38);
            txtUnitPrice.TabIndex = 12;
            txtUnitPrice.Tag = "UnitPrice";
            txtUnitPrice.TextChanged += txtUnitPrice_TextChanged;
            // 
            // txtAmount
            // 
            txtAmount.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmount.Location = new Point(641, 91);
            txtAmount.Name = "txtAmount";
            txtAmount.ReadOnly = true;
            txtAmount.Size = new Size(270, 38);
            txtAmount.TabIndex = 13;
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
            label10.Location = new Point(501, 45);
            label10.Name = "label10";
            label10.Size = new Size(106, 22);
            label10.TabIndex = 16;
            label10.Text = "Unit Price : ";
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(501, 99);
            label12.Name = "label12";
            label12.Size = new Size(87, 22);
            label12.TabIndex = 14;
            label12.Text = "Amount : ";
            // 
            // dtpImpDate
            // 
            dtpImpDate.Format = DateTimePickerFormat.Short;
            dtpImpDate.Location = new Point(653, 21);
            dtpImpDate.Name = "dtpImpDate";
            dtpImpDate.Size = new Size(270, 30);
            dtpImpDate.TabIndex = 2;
            dtpImpDate.TabStop = false;
            // 
            // txtStaffPosition
            // 
            txtStaffPosition.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffPosition.Location = new Point(182, 252);
            txtStaffPosition.Name = "txtStaffPosition";
            txtStaffPosition.ReadOnly = true;
            txtStaffPosition.Size = new Size(741, 38);
            txtStaffPosition.TabIndex = 8;
            txtStaffPosition.Tag = "StaffPositon";
            // 
            // cmbStaffID
            // 
            cmbStaffID.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStaffID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbStaffID.FormattingEnabled = true;
            cmbStaffID.IntegralHeight = false;
            cmbStaffID.Location = new Point(182, 188);
            cmbStaffID.MaxDropDownItems = 5;
            cmbStaffID.Name = "cmbStaffID";
            cmbStaffID.Size = new Size(270, 38);
            cmbStaffID.TabIndex = 6;
            cmbStaffID.Tag = "StaffID";
            cmbStaffID.SelectedIndexChanged += cmbStaffID_SelectedIndexChanged;
            // 
            // cmbSupID
            // 
            cmbSupID.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cmbSupID.FormattingEnabled = true;
            cmbSupID.IntegralHeight = false;
            cmbSupID.Location = new Point(182, 129);
            cmbSupID.MaxDropDownItems = 5;
            cmbSupID.Name = "cmbSupID";
            cmbSupID.Size = new Size(270, 38);
            cmbSupID.TabIndex = 4;
            cmbSupID.Tag = "SupplierID";
            cmbSupID.SelectedIndexChanged += cmbSupID_SelectedIndexChanged;
            cmbSupID.KeyDown += cmbSupID_KeyDown;
            cmbSupID.Leave += cmbSupID_Leave;
            // 
            // txtSupName
            // 
            txtSupName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSupName.Location = new Point(653, 129);
            txtSupName.Name = "txtSupName";
            txtSupName.ReadOnly = true;
            txtSupName.Size = new Size(270, 38);
            txtSupName.TabIndex = 5;
            txtSupName.Tag = "Supplier";
            // 
            // txtStaffName
            // 
            txtStaffName.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtStaffName.Location = new Point(653, 188);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.ReadOnly = true;
            txtStaffName.Size = new Size(270, 38);
            txtStaffName.TabIndex = 7;
            txtStaffName.Tag = "Staff Name";
            // 
            // txtTotal
            // 
            txtTotal.Location = new Point(182, 75);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(741, 30);
            txtTotal.TabIndex = 3;
            // 
            // txtImpID
            // 
            txtImpID.Location = new Point(182, 19);
            txtImpID.Name = "txtImpID";
            txtImpID.ReadOnly = true;
            txtImpID.Size = new Size(270, 30);
            txtImpID.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(502, 27);
            label2.Name = "label2";
            label2.Size = new Size(115, 22);
            label2.TabIndex = 35;
            label2.Text = "Import Date :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(49, 83);
            label7.Name = "label7";
            label7.Size = new Size(127, 22);
            label7.TabIndex = 33;
            label7.Text = "Total Amount :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(49, 142);
            label6.Name = "label6";
            label6.Size = new Size(114, 22);
            label6.TabIndex = 31;
            label6.Text = "Supplier ID :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(502, 137);
            label5.Name = "label5";
            label5.Size = new Size(145, 22);
            label5.TabIndex = 29;
            label5.Text = "Supplier Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 201);
            label4.Name = "label4";
            label4.Size = new Size(83, 22);
            label4.TabIndex = 27;
            label4.Text = "Staff ID :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(502, 196);
            label3.Name = "label3";
            label3.Size = new Size(109, 22);
            label3.TabIndex = 25;
            label3.Text = "Staff Name :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(48, 260);
            label15.Name = "label15";
            label15.Size = new Size(133, 22);
            label15.TabIndex = 23;
            label15.Text = "Staff Position : ";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(49, 29);
            label16.Name = "label16";
            label16.Size = new Size(98, 22);
            label16.TabIndex = 20;
            label16.Text = "Import ID :";
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
            panel2.Location = new Point(0, 890);
            panel2.Name = "panel2";
            panel2.Size = new Size(985, 79);
            panel2.TabIndex = 5;
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
            btnUpdate.Location = new Point(234, 17);
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
            btnNew.Location = new Point(419, 17);
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
            btnClose.Location = new Point(604, 17);
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
            btnInsert.Location = new Point(49, 17);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 17;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(237, 234, 224);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(0, 667);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 223);
            panel4.TabIndex = 7;
            // 
            // panel5
            // 
            panel5.Controls.Add(dgvImpDetail);
            panel5.Location = new Point(12, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(961, 223);
            panel5.TabIndex = 0;
            // 
            // dgvImpDetail
            // 
            dgvImpDetail.AllowUserToAddRows = false;
            dgvImpDetail.AllowUserToDeleteRows = false;
            dgvImpDetail.AllowUserToResizeColumns = false;
            dgvImpDetail.AllowUserToResizeRows = false;
            dgvImpDetail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvImpDetail.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 200);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvImpDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvImpDetail.ColumnHeadersHeight = 40;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvImpDetail.DefaultCellStyle = dataGridViewCellStyle2;
            dgvImpDetail.Dock = DockStyle.Fill;
            dgvImpDetail.EnableHeadersVisualStyles = false;
            dgvImpDetail.Location = new Point(0, 0);
            dgvImpDetail.MultiSelect = false;
            dgvImpDetail.Name = "dgvImpDetail";
            dgvImpDetail.ReadOnly = true;
            dgvImpDetail.RowHeadersVisible = false;
            dgvImpDetail.RowHeadersWidth = 51;
            dgvImpDetail.RowTemplate.Height = 29;
            dgvImpDetail.ScrollBars = ScrollBars.Vertical;
            dgvImpDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvImpDetail.Size = new Size(961, 223);
            dgvImpDetail.TabIndex = 41;
            dgvImpDetail.CellClick += dgvImpDetail_CellClick;
            dgvImpDetail.SelectionChanged += dgvImpDetail_SelectionChanged;
            // 
            // FormImport
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(985, 969);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1003, 1100);
            MinimumSize = new Size(1003, 900);
            Name = "FormImport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Import's Information";
            Load += FormImport_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvImpDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label14;
        private GroupBox groupBox1;
        private Button btnUpdateDetail;
        private Button btnInsertDetail;
        private TextBox txtBookQty;
        private TextBox txtBTitle;
        private Label label13;
        private ComboBox cmbBCode;
        private TextBox txtUnitPrice;
        private TextBox txtAmount;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private DateTimePicker dtpImpDate;
        private TextBox txtStaffPosition;
        private ComboBox cmbStaffID;
        private ComboBox cmbSupID;
        private TextBox txtSupName;
        private TextBox txtStaffName;
        private TextBox txtTotal;
        private TextBox txtImpID;
        private Label label2;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label15;
        private Label label16;
        private Panel panel4;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Panel panel5;
        private DataGridView dgvImpDetail;
    }
}