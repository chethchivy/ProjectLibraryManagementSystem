namespace ProjectLibraryManagementSystem
{
    partial class FormBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBook));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel5 = new Panel();
            txtBookQty = new TextBox();
            txtPublishYear = new TextBox();
            txtLateFee = new TextBox();
            txtAuthor = new TextBox();
            txtGenres = new TextBox();
            txtPrice = new TextBox();
            txtBookTitle = new TextBox();
            txtBookCode = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label10 = new Label();
            label11 = new Label();
            panel4 = new Panel();
            ltbBookDisplay = new ListBox();
            txtSearch = new TextBox();
            label1 = new Label();
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
            panel1.Size = new Size(985, 82);
            panel1.TabIndex = 0;
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
            label8.Size = new Size(167, 26);
            label8.TabIndex = 3;
            label8.Text = "BOOK'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.book1;
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
            panel3.Size = new Size(985, 597);
            panel3.TabIndex = 6;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtBookQty);
            panel5.Controls.Add(txtPublishYear);
            panel5.Controls.Add(txtLateFee);
            panel5.Controls.Add(txtAuthor);
            panel5.Controls.Add(txtGenres);
            panel5.Controls.Add(txtPrice);
            panel5.Controls.Add(txtBookTitle);
            panel5.Controls.Add(txtBookCode);
            panel5.Controls.Add(label2);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label10);
            panel5.Controls.Add(label11);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(368, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(617, 597);
            panel5.TabIndex = 1;
            // 
            // txtBookQty
            // 
            txtBookQty.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookQty.Location = new Point(183, 376);
            txtBookQty.Margin = new Padding(2);
            txtBookQty.Name = "txtBookQty";
            txtBookQty.Size = new Size(402, 42);
            txtBookQty.TabIndex = 7;
            // 
            // txtPublishYear
            // 
            txtPublishYear.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublishYear.Location = new Point(183, 308);
            txtPublishYear.Margin = new Padding(2);
            txtPublishYear.Name = "txtPublishYear";
            txtPublishYear.Size = new Size(402, 42);
            txtPublishYear.TabIndex = 6;
            // 
            // txtLateFee
            // 
            txtLateFee.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtLateFee.Location = new Point(182, 444);
            txtLateFee.Margin = new Padding(2);
            txtLateFee.Name = "txtLateFee";
            txtLateFee.Size = new Size(403, 42);
            txtLateFee.TabIndex = 8;
            // 
            // txtAuthor
            // 
            txtAuthor.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtAuthor.Location = new Point(183, 240);
            txtAuthor.Margin = new Padding(2);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(402, 42);
            txtAuthor.TabIndex = 5;
            // 
            // txtGenres
            // 
            txtGenres.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtGenres.Location = new Point(182, 172);
            txtGenres.Margin = new Padding(2);
            txtGenres.Name = "txtGenres";
            txtGenres.Size = new Size(403, 42);
            txtGenres.TabIndex = 4;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(182, 512);
            txtPrice.Margin = new Padding(2);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(403, 42);
            txtPrice.TabIndex = 9;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookTitle.Location = new Point(182, 104);
            txtBookTitle.Margin = new Padding(2);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(403, 42);
            txtBookTitle.TabIndex = 3;
            // 
            // txtBookCode
            // 
            txtBookCode.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtBookCode.Location = new Point(182, 36);
            txtBookCode.Margin = new Padding(2);
            txtBookCode.Name = "txtBookCode";
            txtBookCode.ReadOnly = true;
            txtBookCode.Size = new Size(222, 42);
            txtBookCode.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 520);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(63, 22);
            label2.TabIndex = 25;
            label2.Text = "Price :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(40, 452);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 22);
            label3.TabIndex = 24;
            label3.Text = "Late Fee :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 384);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(139, 22);
            label7.TabIndex = 23;
            label7.Text = "Book Quantity : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 316);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(121, 22);
            label6.TabIndex = 22;
            label6.Text = "Publish Year :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(40, 248);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 22);
            label5.TabIndex = 21;
            label5.Text = "Author :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(40, 180);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(77, 22);
            label4.TabIndex = 20;
            label4.Text = "Genres :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(40, 112);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(105, 22);
            label10.TabIndex = 19;
            label10.Text = "Book Title :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(40, 44);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(110, 22);
            label11.TabIndex = 18;
            label11.Text = "Book Code :";
            // 
            // panel4
            // 
            panel4.Controls.Add(ltbBookDisplay);
            panel4.Controls.Add(txtSearch);
            panel4.Controls.Add(label1);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(368, 597);
            panel4.TabIndex = 0;
            // 
            // ltbBookDisplay
            // 
            ltbBookDisplay.Font = new Font("Khmer OS", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            ltbBookDisplay.FormattingEnabled = true;
            ltbBookDisplay.ItemHeight = 34;
            ltbBookDisplay.Location = new Point(26, 85);
            ltbBookDisplay.Name = "ltbBookDisplay";
            ltbBookDisplay.Size = new Size(317, 480);
            ltbBookDisplay.TabIndex = 5;
            ltbBookDisplay.SelectedIndexChanged += ltbBookDisplay_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(26, 41);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(317, 38);
            txtSearch.TabIndex = 1;
            txtSearch.Tag = "search";
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 16);
            label1.Name = "label1";
            label1.Size = new Size(75, 22);
            label1.TabIndex = 3;
            label1.Text = "Search :";
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
            panel2.Location = new Point(0, 679);
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
            btnLogout.TabIndex = 14;
            btnLogout.Text = "Log Out";
            btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 240, 150);
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdate.Location = new Point(233, 23);
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
            btnNew.Location = new Point(418, 23);
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
            btnClose.Location = new Point(603, 23);
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
            btnInsert.Location = new Point(48, 23);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 10;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // FormBook
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(985, 769);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(1003, 816);
            MinimumSize = new Size(1003, 816);
            Name = "FormBook";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Book's Information";
            Load += FormBook_Load;
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
        private PictureBox pictureBox1;
        private Label label9;
        private Label label8;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Panel panel4;
        private TextBox txtBookQty;
        private TextBox txtPublishYear;
        private TextBox txtLateFee;
        private TextBox txtAuthor;
        private TextBox txtGenres;
        private TextBox txtPrice;
        private TextBox txtBookTitle;
        private TextBox txtBookCode;
        private Label label2;
        private Label label3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label10;
        private Label label11;
        private ListBox ltbBookDisplay;
        private TextBox txtSearch;
        private Label label1;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
    }
}