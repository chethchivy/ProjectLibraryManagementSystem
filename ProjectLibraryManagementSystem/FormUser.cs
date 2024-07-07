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
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormUser : Form
    {
        private List<Staff> staffLists = null!;
        private Timer loginTimer = null!;
        public FormUser()
        {
            InitializeComponent();
            Helper.AttachNavigationEvents(this);
        }

        private void cboStaffID_Leave(object sender, EventArgs e)
        {
            Helper.ValidateCmbStaffSelection(staffLists, cboStaffID, txtStaffName, txtStaffPosition);
        }
        private void FormUser_Load(object sender, EventArgs e)
        {
            staffLists = new List<Staff>();
            Helper.LoadStaffData(staffLists, cboStaffID);
            cboStaffID.Refresh();
            //cboStaffID.Leave += new EventHandler(cboStaffID_Leave!);
            cboStaffID.SelectedIndex = -1;
            string query = "SELECT * FROM vGetUserIDName";
            Helper.LoadListBoxData(ltbDisplay, query, "UserName");
        }
        public bool TryParseUserInputs(out User user)
        {
            user = new User();
            bool isValid = true;
            user.UserName = txtUserName.Text;
            user.Password = txtPassword.Text;
            if (cboStaffID.SelectedItem != null)
            {
                user.StaffID = (short)cboStaffID.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please Select StaffID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            user.StaffName = txtStaffName.Text;
            user.StaffPosition = txtStaffPosition.Text;
            return isValid;
        }

        private void cboStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboStaffID.SelectedItem is Staff selectedStaff)
            {
                txtStaffName.Text = selectedStaff.StaffName;
                txtStaffPosition.Text = selectedStaff.StaffPosition;
            }
            else
            {
                txtStaffName.Text = "";
                txtStaffPosition.Text = "";
            }
        }

        private void RetrieveUserDetails(string? userName)
        {
            User user = new User();
            User.RetrieveUserDetails(userName, user);

            txtUserID.Text = user.UserID.ToString();
            txtUserName.Text = user.UserName;
            txtPassword.Text = user.Password;
            cboStaffID.Text = user.StaffID.ToString();
            txtStaffName.Text = user.StaffName;
            txtStaffPosition.Text = user.StaffPosition;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            ptbHide_Click(sender, e);
            string query = "SELECT * FROM vGetUserIDName";
            if (Helper.ValidateTextBoxes(txtUserName, txtPassword))
            {
                if (TryParseUserInputs(out User newUser))
                {
                    bool isSuccess = User.InsertUser(newUser);
                    if (isSuccess)
                    {
                        MessageBox.Show("User inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.LoadListBoxData(ltbDisplay, query, "UserName");
                        Helper.ClearControls(this);
                    }
                    else
                    {
                        MessageBox.Show("This User was already Exited. User was not inserted...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            ptbHide_Click(sender, e);
            string query = "SELECT * FROM vGetUserIDName";
            if (Helper.ValidateTextBoxes(txtUserName, txtPassword))
            {
                if (TryParseUserInputs(out User newUser))
                {
                    if (int.TryParse(txtUserID.Text, out int userID))
                    {
                        newUser.UserID = userID;
                        bool isSuccess = User.UpdateUserByID(newUser);
                        if (isSuccess)
                        {
                            MessageBox.Show("User Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Helper.LoadListBoxData(ltbDisplay, query, "UserName");
                            Helper.ClearControls(this);
                        }
                        else
                        {
                            MessageBox.Show("User was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid User ID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            cboStaffID.Enabled = true;
            cboStaffID.SelectedIndex = -1;
            ptbHide_Click(sender, e);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ltbDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            ptbHide_Click(sender, e);
            if (ltbDisplay.SelectedItem != null)
            {
                string? selectedUser = ltbDisplay.SelectedItem.ToString();
                RetrieveUserDetails(selectedUser);
                cboStaffID.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            User.SearchUser(searchTerm, ltbDisplay);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                bool result = User.SearchUser(searchTerm, ltbDisplay);
                if (!result)
                {
                    MessageBox.Show($"No User found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                }
                e.SuppressKeyPress = true;
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

        private void cboStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboStaffID_Leave(sender, e);
        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Close();
                loginTimer = new Timer();
                loginTimer.Interval = 200;
                loginTimer.Start();
                loginTimer.Tick += LoginTimer_Tick!;
            }
            else
            {
                return;
            }
        }
    }
}
