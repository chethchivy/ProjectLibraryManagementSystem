using ProjectLibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibraryManagementSystem
{
    public partial class FormLogin : Form
    {
        public FormMain formMain { get; set; } = null!;
        public FormLogin()
        {
            InitializeComponent();
            Helper.AttachNavigationEvents(this);
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ActiveControl = btnLogin;
            this.FormClosing += LoginForm_FormClosing!;

        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.DialogResult != DialogResult.OK && formMain != null)
            {
                formMain.Close();
            }
        }
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            btnLogin.Enabled = !string.IsNullOrWhiteSpace(txtUsername.Text) &&
                                !string.IsNullOrWhiteSpace(txtPassword.Text);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;


            if (User.ValidateUser(username, password))
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error Validate User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Clear();
                txtPassword.Clear();
            }
        }

        private void ptbShow_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '\0';
            ptbShow.Visible = false;
            ptbHide.Visible = true;
        }

        private void ptbHide_Click(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
            ptbHide.Visible = false;
            ptbShow.Visible = true;
        }
    }
}
