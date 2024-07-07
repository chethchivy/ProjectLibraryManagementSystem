namespace ProjectLibraryManagementSystem
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            ptbShow = new PictureBox();
            ptbHide = new PictureBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbShow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbHide).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(237, 234, 224);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(578, 281);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.user;
            pictureBox2.Location = new Point(113, 178);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(117, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(236, 208);
            label1.Name = "label1";
            label1.Size = new Size(178, 38);
            label1.TabIndex = 0;
            label1.Text = "User Login";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.libray_management_system_high_resolution_logo_transparent;
            pictureBox1.Location = new Point(0, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(578, 92);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(237, 234, 224);
            panel2.Controls.Add(ptbShow);
            panel2.Controls.Add(ptbHide);
            panel2.Controls.Add(btnLogin);
            panel2.Controls.Add(txtPassword);
            panel2.Controls.Add(txtUsername);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            panel2.Location = new Point(0, 281);
            panel2.Name = "panel2";
            panel2.Size = new Size(578, 352);
            panel2.TabIndex = 1;
            // 
            // ptbShow
            // 
            ptbShow.BackColor = Color.White;
            ptbShow.Image = Properties.Resources.hide;
            ptbShow.Location = new Point(504, 163);
            ptbShow.Name = "ptbShow";
            ptbShow.Size = new Size(26, 22);
            ptbShow.SizeMode = PictureBoxSizeMode.Zoom;
            ptbShow.TabIndex = 60;
            ptbShow.TabStop = false;
            ptbShow.Click += ptbShow_Click;
            // 
            // ptbHide
            // 
            ptbHide.BackColor = Color.White;
            ptbHide.Image = Properties.Resources.show;
            ptbHide.Location = new Point(504, 163);
            ptbHide.Name = "ptbHide";
            ptbHide.Size = new Size(26, 22);
            ptbHide.SizeMode = PictureBoxSizeMode.Zoom;
            ptbHide.TabIndex = 59;
            ptbHide.TabStop = false;
            ptbHide.Visible = false;
            ptbHide.Click += ptbHide_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Enabled = false;
            btnLogin.Location = new Point(28, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(524, 48);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Font = new Font("Khmer OS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(28, 150);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = " Enter your password";
            txtPassword.Size = new Size(524, 48);
            txtPassword.TabIndex = 2;
            txtPassword.TextChanged += TextBox_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.WhiteSmoke;
            txtUsername.Font = new Font("Khmer OS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.Location = new Point(28, 55);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = " Enter your username";
            txtUsername.Size = new Size(524, 48);
            txtUsername.TabIndex = 1;
            txtUsername.TextChanged += TextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(28, 124);
            label3.Name = "label3";
            label3.Size = new Size(102, 23);
            label3.TabIndex = 0;
            label3.Text = "Password :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(28, 29);
            label2.Name = "label2";
            label2.Size = new Size(112, 23);
            label2.TabIndex = 0;
            label2.Text = "Username : ";
            // 
            // FormLogin
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(578, 633);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(596, 680);
            MinimumSize = new Size(596, 680);
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form Login";
            Load += FormLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbShow).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbHide).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Label label1;
        private TextBox txtUsername;
        private Label label3;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private PictureBox ptbHide;
        private PictureBox ptbShow;
    }
}