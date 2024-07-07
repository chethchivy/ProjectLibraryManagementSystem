namespace ProjectLibraryManagementSystem
{
    partial class FormSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSupplier));
            dgvSupDisplay = new DataGridView();
            ColSupID = new DataGridViewTextBoxColumn();
            ColSupName = new DataGridViewTextBoxColumn();
            ColSupAddr = new DataGridViewTextBoxColumn();
            ColPhone1 = new DataGridViewTextBoxColumn();
            ColPhone2 = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            txtPhone2 = new TextBox();
            label5 = new Label();
            txtPhone1 = new TextBox();
            label4 = new Label();
            txtSupName = new TextBox();
            txtSupAddr = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtSupID = new TextBox();
            label1 = new Label();
            panel4 = new Panel();
            panel5 = new Panel();
            btnLogout = new Button();
            btnUpdate = new Button();
            btnNew = new Button();
            btnClose = new Button();
            btnInsert = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            txtSearch = new TextBox();
            label6 = new Label();
            panel6 = new Panel();
            panel7 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvSupDisplay).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // dgvSupDisplay
            // 
            dgvSupDisplay.AllowUserToAddRows = false;
            dgvSupDisplay.AllowUserToDeleteRows = false;
            dgvSupDisplay.AllowUserToResizeColumns = false;
            dgvSupDisplay.AllowUserToResizeRows = false;
            dgvSupDisplay.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSupDisplay.BackgroundColor = Color.WhiteSmoke;
            dgvSupDisplay.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 240, 200);
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSupDisplay.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSupDisplay.ColumnHeadersHeight = 40;
            dgvSupDisplay.Columns.AddRange(new DataGridViewColumn[] { ColSupID, ColSupName, ColSupAddr, ColPhone1, ColPhone2 });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvSupDisplay.DefaultCellStyle = dataGridViewCellStyle2;
            dgvSupDisplay.Dock = DockStyle.Fill;
            dgvSupDisplay.EnableHeadersVisualStyles = false;
            dgvSupDisplay.Location = new Point(0, 0);
            dgvSupDisplay.MultiSelect = false;
            dgvSupDisplay.Name = "dgvSupDisplay";
            dgvSupDisplay.RowHeadersVisible = false;
            dgvSupDisplay.RowHeadersWidth = 51;
            dgvSupDisplay.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgvSupDisplay.RowTemplate.Height = 29;
            dgvSupDisplay.ScrollBars = ScrollBars.Vertical;
            dgvSupDisplay.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSupDisplay.Size = new Size(986, 271);
            dgvSupDisplay.TabIndex = 1;
            dgvSupDisplay.TabStop = false;
            dgvSupDisplay.CellClick += dgvSupDisplay_CellClick;
            // 
            // ColSupID
            // 
            ColSupID.HeaderText = "SupplierID";
            ColSupID.MinimumWidth = 6;
            ColSupID.Name = "ColSupID";
            // 
            // ColSupName
            // 
            ColSupName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSupName.HeaderText = "Supplier Name";
            ColSupName.MinimumWidth = 6;
            ColSupName.Name = "ColSupName";
            // 
            // ColSupAddr
            // 
            ColSupAddr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColSupAddr.HeaderText = "Supplier Address";
            ColSupAddr.MinimumWidth = 6;
            ColSupAddr.Name = "ColSupAddr";
            // 
            // ColPhone1
            // 
            ColPhone1.HeaderText = "Phone Number1";
            ColPhone1.MinimumWidth = 6;
            ColPhone1.Name = "ColPhone1";
            // 
            // ColPhone2
            // 
            ColPhone2.HeaderText = "Phone Number2";
            ColPhone2.MinimumWidth = 6;
            ColPhone2.Name = "ColPhone2";
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
            panel1.Size = new Size(1010, 82);
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
            label8.Size = new Size(214, 26);
            label8.TabIndex = 3;
            label8.Text = "SUPPLIER'S FORM";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.supplier;
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
            panel3.Controls.Add(txtPhone2);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(txtPhone1);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtSupName);
            panel3.Controls.Add(txtSupAddr);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(txtSupID);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 82);
            panel3.Name = "panel3";
            panel3.Size = new Size(1010, 247);
            panel3.TabIndex = 4;
            // 
            // txtPhone2
            // 
            txtPhone2.Location = new Point(679, 189);
            txtPhone2.Margin = new Padding(3, 4, 3, 4);
            txtPhone2.Name = "txtPhone2";
            txtPhone2.Size = new Size(292, 30);
            txtPhone2.TabIndex = 5;
            txtPhone2.Tag = "Phone Number2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(528, 197);
            label5.Name = "label5";
            label5.Size = new Size(147, 22);
            label5.TabIndex = 18;
            label5.Text = "Phone Number2 :";
            // 
            // txtPhone1
            // 
            txtPhone1.Location = new Point(198, 189);
            txtPhone1.Margin = new Padding(3, 4, 3, 4);
            txtPhone1.Name = "txtPhone1";
            txtPhone1.Size = new Size(291, 30);
            txtPhone1.TabIndex = 4;
            txtPhone1.Tag = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 197);
            label4.Name = "label4";
            label4.Size = new Size(147, 22);
            label4.TabIndex = 16;
            label4.Text = "Phone Number1 :";
            // 
            // txtSupName
            // 
            txtSupName.Location = new Point(198, 74);
            txtSupName.Margin = new Padding(3, 4, 3, 4);
            txtSupName.Name = "txtSupName";
            txtSupName.Size = new Size(291, 30);
            txtSupName.TabIndex = 2;
            txtSupName.Tag = "Supplier Name";
            // 
            // txtSupAddr
            // 
            txtSupAddr.Location = new Point(198, 132);
            txtSupAddr.Margin = new Padding(3, 4, 3, 4);
            txtSupAddr.Name = "txtSupAddr";
            txtSupAddr.Size = new Size(773, 30);
            txtSupAddr.TabIndex = 3;
            txtSupAddr.Tag = "Supplier Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 140);
            label3.Name = "label3";
            label3.Size = new Size(159, 22);
            label3.TabIndex = 13;
            label3.Text = "Supplier Address :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 82);
            label2.Name = "label2";
            label2.Size = new Size(140, 22);
            label2.TabIndex = 12;
            label2.Text = "Supplier Name :";
            // 
            // txtSupID
            // 
            txtSupID.Location = new Point(198, 19);
            txtSupID.Margin = new Padding(3, 4, 3, 4);
            txtSupID.Name = "txtSupID";
            txtSupID.ReadOnly = true;
            txtSupID.Size = new Size(170, 30);
            txtSupID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(114, 22);
            label1.TabIndex = 10;
            label1.Text = "Supplier ID :";
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button3);
            panel4.Controls.Add(button4);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 329);
            panel4.Name = "panel4";
            panel4.Size = new Size(1010, 79);
            panel4.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(237, 234, 224);
            panel5.Controls.Add(btnLogout);
            panel5.Controls.Add(btnUpdate);
            panel5.Controls.Add(btnNew);
            panel5.Controls.Add(btnClose);
            panel5.Controls.Add(btnInsert);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(1010, 85);
            panel5.TabIndex = 16;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(200, 50, 10);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(798, 19);
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
            btnUpdate.Location = new Point(243, 19);
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
            btnNew.Location = new Point(428, 19);
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
            btnClose.Location = new Point(613, 19);
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
            btnInsert.Location = new Point(58, 19);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(146, 42);
            btnInsert.TabIndex = 6;
            btnInsert.Text = "Insert";
            btnInsert.UseVisualStyleBackColor = false;
            btnInsert.Click += btnInsert_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(255, 240, 150);
            button1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(240, 13);
            button1.Name = "button1";
            button1.Size = new Size(146, 44);
            button1.TabIndex = 18;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(426, 13);
            button2.Name = "button2";
            button2.Size = new Size(146, 44);
            button2.TabIndex = 19;
            button2.Text = "New";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(200, 50, 10);
            button3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(612, 13);
            button3.Name = "button3";
            button3.Size = new Size(146, 44);
            button3.TabIndex = 20;
            button3.Text = "Log Out";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(255, 240, 150);
            button4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(54, 13);
            button4.Name = "button4";
            button4.Size = new Size(146, 44);
            button4.TabIndex = 17;
            button4.Text = "Insert";
            button4.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 234, 224);
            panel2.Controls.Add(txtSearch);
            panel2.Controls.Add(label6);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 408);
            panel2.Name = "panel2";
            panel2.Size = new Size(1010, 68);
            panel2.TabIndex = 6;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Khmer OS", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.Location = new Point(236, 19);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(735, 38);
            txtSearch.TabIndex = 11;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(33, 22);
            label6.Name = "label6";
            label6.Size = new Size(197, 22);
            label6.TabIndex = 17;
            label6.Text = "Search ( SupplierID ) : ";
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(237, 234, 224);
            panel6.Controls.Add(panel7);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 476);
            panel6.Name = "panel6";
            panel6.Size = new Size(1010, 283);
            panel6.TabIndex = 7;
            // 
            // panel7
            // 
            panel7.Controls.Add(dgvSupDisplay);
            panel7.Location = new Point(12, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(986, 271);
            panel7.TabIndex = 0;
            // 
            // FormSupplier
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1010, 759);
            Controls.Add(panel6);
            Controls.Add(panel2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(1028, 806);
            MinimumSize = new Size(1028, 806);
            Name = "FormSupplier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Supplier's Information";
            Load += FormSupplier_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSupDisplay).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private PictureBox pictureBox1;
        private Panel panel3;
        private TextBox txtPhone2;
        private Label label5;
        private TextBox txtPhone1;
        private Label label4;
        private TextBox txtSupName;
        private TextBox txtSupAddr;
        private Label label3;
        private Label label2;
        private TextBox txtSupID;
        private Label label1;
        private Panel panel4;
        private Panel panel5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnLogout;
        private Button btnUpdate;
        private Button btnNew;
        private Button btnClose;
        private Button btnInsert;
        private Panel panel2;
        private TextBox txtSearch;
        private Label label6;
        private Panel panel6;
        private Panel panel7;
        private DataGridViewTextBoxColumn ColSupID;
        private DataGridViewTextBoxColumn ColSupName;
        private DataGridViewTextBoxColumn ColSupAddr;
        private DataGridViewTextBoxColumn ColPhone1;
        private DataGridViewTextBoxColumn ColPhone2;
        private DataGridView dgvSupDisplay;
    }
}