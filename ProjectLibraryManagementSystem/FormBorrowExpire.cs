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
    public partial class FormBorrowExpire : Form
    {
        private Timer loginTimer = null!;
        BindingSource bindingSource;
        DataTable dataTable;
        public FormBorrowExpire()
        {
            InitializeComponent();
            dataTable = BorrowExpire.LoadData();
            bindingSource = new BindingSource();
            bindingSource.DataSource = dataTable;
            dgvBEDisplay.DataSource = dataTable;
            dgvBEDisplay.ClearSelection();
            Helper.AttachNavigationEvents(this);
        }
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }
        private void dgvBEDisplay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvBEDisplay.SelectionChanged += DgvBEDisplay_SelectionChanged;
        }

        private void DgvBEDisplay_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvBEDisplay.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvBEDisplay.SelectedRows[0];

                txtBorrowExpireID.Text = selectedRow.Cells["BorrowExpireID"].Value.ToString();
                dtpEBID.Value = Convert.ToDateTime(selectedRow.Cells["ExpiredDate"].Value);
                cmbBorrowID.Text = selectedRow.Cells["BorrowID"].Value.ToString();
                cmbMemberID.Text = selectedRow.Cells["MemberID"].Value.ToString();
                txtBookTitle.Text = selectedRow.Cells["BookTitle"].Value.ToString();
            }
        }

        private bool ValidateInput()
        {
            // Check if BorrowExpireID is a valid integer
            if (!int.TryParse(txtBorrowExpireID.Text, out int borrowExpireID))
            {
                MessageBox.Show("BorrowExpireID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if ExpiredDate is a valid date
            if (!DateTime.TryParse(dtpEBID.Value.ToString(), out DateTime expireDate))
            {
                MessageBox.Show("ExpiredDate must be a valid date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if BorrowID is a valid integer
            if (!int.TryParse(cmbBorrowID.Text, out int borrowID))
            {
                MessageBox.Show("BorrowID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if MemberID is a valid integer
            if (!int.TryParse(cmbMemberID.Text, out int memberID))
            {
                MessageBox.Show("MemberID must be a valid integer.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Check if BookTitle is not empty
            if (string.IsNullOrWhiteSpace(txtBookTitle.Text))
            {
                MessageBox.Show("BookTitle cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true; // All validations passed
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            cmbBorrowID.Text = "";
            cmbMemberID.Text = "";
            dgvBEDisplay.ClearSelection();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int memberID;
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                dataTable = BorrowExpire.LoadData();
                dgvBEDisplay.DataSource = dataTable;
                btnNew_Click(sender, e);
                return;
            }
            else
            {
                if (!int.TryParse(txtSearch.Text, out memberID))
                {
                    return;
                }
                else
                {
                    dataTable = BorrowExpire.Search(memberID);
                    if (dataTable != null)
                    {
                        dgvBEDisplay.DataSource = null;
                        dgvBEDisplay.DataSource = dataTable;
                    }
                }
            }

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int memberID;
                if (int.TryParse(txtSearch.Text.Trim(), out memberID))
                {
                    DataTable dataTable = BorrowExpire.Search(memberID);

                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        dgvBEDisplay.DataSource = null;
                        dgvBEDisplay.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show($"No records found for the provided Borrow ID {memberID}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer value for Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void FormBorrowExpire_Load(object sender, EventArgs e)
        {
            dgvBEDisplay.SelectionChanged += DgvBEDisplay_SelectionChanged;
            dgvBEDisplay.ClearSelection();
            btnInsert.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            btnNew_Click(sender, e);
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
