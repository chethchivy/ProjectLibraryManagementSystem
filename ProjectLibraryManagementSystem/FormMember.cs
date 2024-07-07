using ProjectLibraryManagementSystem.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormMember : Form
    {
        private Timer loginTimer = null!;
        public FormMember()
        {
            InitializeComponent();
            Helper.AttachNavigationEvents(this);
            Helper.LoadProvinceComboBox(cmbProvince);
        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vGetMemberIDName";
            Helper.LoadListBoxData(ltbMemberDisplay, query, "MemberName");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vGetMemberIDName";
            if (Helper.ValidateTextBoxes(txtMemFname, txtMemLname, txtPhoneNumber))
            {
                if (TryParseMemberInputs(out Member newMember))
                {
                    bool isSuccess = Member.InsertMember(newMember, ptbPhoto);
                    if (isSuccess)
                    {
                        MessageBox.Show("Member inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.LoadListBoxData(ltbMemberDisplay, query, "MemberName");
                        Helper.ClearControls(this);
                        ptbPhoto.Image = null;
                    }
                }
            }
        }
        public bool TryParseMemberInputs(out Member member)
        {
            member = new Member();
            bool isValid = true;
            member.FirstName = txtMemFname.Text;
            member.LastName = txtMemLname.Text;
            if (rdbFemale.Checked)
            {
                member.Sex = rdbFemale.Text;
            }
            else
            {
                member.Sex = rdbMale.Text;
            }
            if (DateTime.TryParse(dtpBirthdate.Value.ToString(), out DateTime birthDate) && birthDate < DateTime.Now)
            {
                member.BirthDate = birthDate;
            }
            else
            {
                isValid = false;
                MessageBox.Show("Invalid BirthDate. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbSangkat.SelectedItem != null)
            {
                member.Sangkat = cmbSangkat.SelectedItem.ToString();
            }
            else
            {
                member.Sangkat = null;
            }
            if (cmbKhann.SelectedItem != null)
            {
                member.Khann = cmbKhann.SelectedItem.ToString();
            }
            else
            {
                member.Khann = null; // or some default value
            }
            if (cmbProvince.SelectedItem != null)
            {
                member.Province = cmbProvince.SelectedItem.ToString();
            }
            else
            {
                member.Province = null; // or some default value
            }

            if (member.Photo != null)
            {
                member.Photo = ptbPhoto.Image;
            }

            member.PhoneNumber = txtPhoneNumber.Text;

            return isValid;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM vGetMemberIDName";
            if (Helper.ValidateTextBoxes(txtMemFname, txtMemLname, txtPhoneNumber))
            {
                if (TryParseMemberInputs(out Member newMember))
                {
                    if (int.TryParse(txtMemberID.Text, out int memberID))
                    {
                        newMember.MemberID = memberID;
                    }
                    else
                    {
                        MessageBox.Show("Invalid Member ID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    bool isSuccess = Member.UpdateMemberByID(newMember, ptbPhoto);
                    if (isSuccess)
                    {
                        MessageBox.Show("Member Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.LoadListBoxData(ltbMemberDisplay, query, "MemberName");
                        Helper.ClearControls(this);
                        ptbPhoto.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Member was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            ptbPhoto.Image = null;
        }
        private void RetrieveMemberDetails(string? memberName)
        {
            Member member = new Member();
            Member.RetrieveMemberDetails(memberName, member);

            txtMemberID.Text = member.MemberID.ToString();
            txtMemFname.Text = member.FirstName;
            txtMemLname.Text = member.LastName;
            if (member.Sex != null && (member.Sex.ToString().Trim() == "F" || member.Sex.ToString().Trim() == "ស្រី"))
            {
                rdbFemale.Checked = true;
            }
            else
            {
                rdbMale.Checked = true;
            }
            DateTime validDate = member.BirthDate;

            if (validDate < dtpBirthdate.MinDate || validDate > dtpBirthdate.MaxDate)
            {
                MessageBox.Show("Invalid BirthDate", "Error BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Warning); // or any other default value within the valid range
            }
            else
            {
                dtpBirthdate.Value = validDate;
            }
            cmbProvince.Text = member.Province;
            cmbKhann.Text = member.Khann;
            cmbSangkat.Text = member.Sangkat;
            txtPhoneNumber.Text = member.PhoneNumber;
            if (member != null && member.Photo != null)
            {
                ptbPhoto.Image = member.Photo;
            }
            else
            {
                ptbPhoto.Image = null;
            }
        }
        private void ltbMemberDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbMemberDisplay.SelectedItem != null)
            {
                string? selectedMember = ltbMemberDisplay.SelectedItem.ToString();
                RetrieveMemberDetails(selectedMember);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            Member.SearchMember(searchTerm, ltbMemberDisplay);
        }

        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbKhann.Items.Clear();
            if (cmbProvince.SelectedItem != null)
            {
                int selectedProvinceID = ((KeyValuePair<int, string>)cmbProvince.SelectedItem).Key;
                Helper.LoadDistrictComboBox(selectedProvinceID, cmbKhann);
            }
            cmbKhann.Text = "";
            cmbSangkat.Text = "";
        }

        private void cmbKhann_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSangkat.Items.Clear();
            if (cmbKhann.SelectedItem != null)
            {
                int selectedKhannID = ((KeyValuePair<int, string>)cmbKhann.SelectedItem).Key;
                Helper.LoadCommuneComboBox(selectedKhannID, cmbSangkat);
            }
            cmbSangkat.Text = "";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                bool result = Member.SearchMember(searchTerm, ltbMemberDisplay);
                if (!result)
                {
                    MessageBox.Show($"No Member found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            Helper.SelectPhoto(openFileDialogPhoto, ptbPhoto);
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
