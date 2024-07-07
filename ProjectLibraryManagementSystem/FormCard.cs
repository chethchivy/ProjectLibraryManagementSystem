using Microsoft.VisualBasic.ApplicationServices;
using ProjectLibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormCard : Form
    {
        private Timer loginTimer = null!;
        private List<Staff> staffLists = null!;
        private List<Member> memberLists = null!;
        public FormCard()
        {
            InitializeComponent();
            Helper.AttachNavigationEvents(this);
        }

        private void cmbStaffID_Leave(object sender, EventArgs e)
        {
            Helper.ValidateCmbStaffSelection(staffLists, cmbStaffID, txtStaffName, txtStaffPosition);
        }
        private void cmbMemberID_Leave(object sender, EventArgs e)
        {
            Helper.ValidateCmbMemberSelection(memberLists, cmbMemberID, txtMemberName);
        }
        private void FormCard_Load(object sender, EventArgs e)
        {
            memberLists = new List<Member>();
            staffLists = new List<Staff>();
            Helper.LoadMemberData(memberLists, cmbMemberID);
            Helper.LoadStaffData(staffLists, cmbStaffID);
            cmbMemberID.Refresh();
            cmbStaffID.Refresh();
            //cmbStaffID.Leave += new EventHandler(cmbStaffID_Leave!);
            //cmbMemberID.Leave += new EventHandler(cmbMemberID_Leave!);
            cmbMemberID.SelectedIndex = -1;
            cmbStaffID.SelectedIndex = -1;
            string query = "SELECT * FROM vGetCardIDMemName";
            Helper.LoadListBoxData(ltbCardDisplay, query, "MemberName");
        }
        public bool TryParseCardInputs(out Card card)
        {
            card = new Card();
            bool isValid = true;
            if (DateTime.TryParse(dtpCreateCard.Value.ToString(), out DateTime creatdDate) && creatdDate <= DateTime.Now)
            {
                card.CreateDate = creatdDate;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Invalid Create Date. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DateTime.TryParse(dtpExpireCard.Value.ToString(), out DateTime expiredDate) && expiredDate > DateTime.Now)
            {
                card.ExpiredDate = expiredDate;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Invalid Expired Date. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbMemberID.SelectedItem != null)
            {
                card.MemberID = (int)cmbMemberID.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please Select MemberID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            card.MemberName = txtMemberName.Text;
            if (cmbStaffID.SelectedItem != null)
            {
                card.StaffID = (short)cmbStaffID.SelectedValue;
            }
            else
            {
                MessageBox.Show("Please Select StaffID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            card.StaffName = txtStaffName.Text;
            card.StaffPosition = txtStaffPosition.Text;
            return isValid;
        }

        private void cmbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMemberID.SelectedItem is Member selectedMember)
            {
                txtMemberName.Text = selectedMember.MemberName;
            }
            else
            {
                txtMemberName.Text = "";
            }
        }

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStaffID.SelectedItem is Staff selectedStaff)
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
        private void RetrieveCardDetails(string? memberName)
        {
            Card card = new Card();
            Card.RetrieveCardDetails(memberName, card);

            txtCardID.Text = card.CardID.ToString();
            dtpCreateCard.Text = card.CreateDate.ToString();
            dtpExpireCard.Text = card.ExpiredDate.ToString();
            cmbMemberID.Text = card.MemberID.ToString();
            txtMemberName.Text = card.MemberName;
            cmbStaffID.Text = card.StaffID.ToString();
            txtStaffName.Text = card.StaffName;
            txtStaffPosition.Text = card.StaffPosition;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vGetCardIDMemName";
            if (Helper.ValidateTextBoxes(txtMemberName, txtStaffName, txtStaffPosition))
            {
                if (TryParseCardInputs(out Card newCard))
                {
                    bool isSuccess = Card.InsertCard(newCard);
                    if (isSuccess)
                    {
                        MessageBox.Show("Card inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.LoadListBoxData(ltbCardDisplay, query, "MemberName");
                        Helper.ClearControls(this);
                    }
                    else
                    {
                        MessageBox.Show("This Card was already Exited. Card was not inserted...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vGetCardIDMemName";
            if (Helper.ValidateTextBoxes(txtMemberName, txtStaffName, txtStaffPosition))
            {
                if (TryParseCardInputs(out Card newCard))
                {
                    if (int.TryParse(txtCardID.Text, out int cardID))
                    {
                        newCard.CardID = cardID;
                        bool isSuccess = Card.UpdateCardByID(newCard);
                        if (isSuccess)
                        {
                            MessageBox.Show("Card Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Helper.LoadListBoxData(ltbCardDisplay, query, "MemberName");
                            Helper.ClearControls(this);
                        }
                        else
                        {
                            MessageBox.Show("Card was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Card ID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            cmbMemberID.Enabled = true;
            cmbMemberID.SelectedIndex = -1;
            cmbStaffID.Enabled = true;
            cmbStaffID.SelectedIndex = -1;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ltbCardDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbCardDisplay.SelectedItem != null)
            {
                string? selectedCard = ltbCardDisplay.SelectedItem.ToString();
                RetrieveCardDetails(selectedCard);
                cmbStaffID.Enabled = false;
                cmbMemberID.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            Card.SearchCard(searchTerm, ltbCardDisplay);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                bool result = Card.SearchCard(searchTerm, ltbCardDisplay);
                if (!result)
                {
                    MessageBox.Show($"No Card found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void cmbStaffID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbStaffID_Leave(sender, e);
        }

        private void cmbMemberID_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMemberID_Leave(sender, e);
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
