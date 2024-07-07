using Microsoft.VisualBasic;
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
    public partial class FormBorrow : Form
    {
        private Timer loginTimer = null!;
        private bool isInsertButtonClicked = true;
        private DataTable? borrowDetailsTable;
        private DataTable? searchBorrow;
        private BindingSource borrowBindingSource = new BindingSource();
        private int borrowedBookCountInSession = 0;
        public FormBorrow()
        {
            InitializeComponent();
            InitializeBookDetailsTable();
            BindDataToDataGridView();
            Helper.AttachNavigationEvents(this);
        }
        private void FormBorrow_Load(object sender, EventArgs e)
        {
            LoadMemberCmb();
            LoadStaffCmb();
            LoadBookCodeCmb();

            dgvBorrowDisplay.AutoGenerateColumns = false;
            dgvBorrowDisplay.Columns.Clear();

            dgvBorrowDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BookCode", DataPropertyName = "BookCode" });
            dgvBorrowDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Book Title", DataPropertyName = "BookTitle" });
            dgvBorrowDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BorrowDate", DataPropertyName = "BorrowDate" });
            dgvBorrowDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DueDate", DataPropertyName = "DueDate" });


            dgvBorrowDisplay.ClearSelection();
            Helper.ClearControls(this);
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            txtMemberName.TextChanged += txtMemberName_TextChanged!;
            cmbBCode.TextChanged += cmbBCode_TextChanged!;
            txtMemberName.Text = " ";
        }
        private void LoadMemberCmb()
        {
            string query = "SELECT * FROM vGetMemberIDName";
            Helper.LoadCombobox(query, "MemberID", "MemberID", cmbMemberID);
        }
        private void LoadStaffCmb()
        {
            string query = "SELECT * FROM vGetStaffIDNamePosition";
            Helper.LoadCombobox(query, "StaffID", "StaffID", cmbStaffID);
        }
        private void LoadBookCodeCmb()
        {
            string query = "SELECT * FROM vGetBookTitle";
            Helper.LoadCombobox(query, "BookCode", "BookCode", cmbBCode);
        }
        private void InitializeBookDetailsTable()
        {
            borrowDetailsTable = new DataTable();
            borrowDetailsTable.Columns.Add("BookCode", typeof(int));
            borrowDetailsTable.Columns.Add("BookTitle", typeof(string));
            borrowDetailsTable.Columns.Add("BorrowDate", typeof(DateTime));
            borrowDetailsTable.Columns.Add("DueDate", typeof(DateTime));
        }
        private void AddBorrowDetail(BorrowDetail bd)
        {
            DataRow row = borrowDetailsTable?.NewRow()!;
            if (bd?.bookCode != null)
                row["BookCode"] = bd.bookCode;
            else
                row["BookCode"] = DBNull.Value;

            // BookTitle
            if (bd?.bookTitle != null)
                row["BookTitle"] = bd.bookTitle;
            else
                row["BookTitle"] = DBNull.Value;

            // BorrowDate
            if (bd?.borrowDate != null)
                row["BorrowDate"] = bd.borrowDate;
            else
                row["BorrowDate"] = DBNull.Value;
            // DueDate
            if (bd?.dueDate != null)
                row["DueDate"] = bd.dueDate;
            else
                row["DueDate"] = DBNull.Value;

            borrowDetailsTable?.Rows.Add(row);
            RefreshDataGridView();
        }
        private void BindDataToDataGridView()
        {
            string query = "SELECT * FROM vBorrowDetails;";
            DataTable dataTable = Borrow.GetBorrowDetails(query);
            //borrowDetailsTable = dataTable;
            dgvBorrowDisplay.DataSource = dataTable;
        }
        private BorrowDetail CreateBorrowDetail()
        {
            int bCode;
            if (cmbBCode.Text == DBNull.Value.ToString() || string.IsNullOrWhiteSpace(cmbBCode.Text))
            {
                MessageBox.Show("Please enter a book Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
            else if (!int.TryParse(cmbBCode.Text, out bCode))
            {
                MessageBox.Show("Invalid Book Code. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
            string bTitle = txtBTitle.Text;
            if (string.IsNullOrWhiteSpace(bTitle))
            {
                MessageBox.Show("Please enter a book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
            DateTime dueDate = dtpDueDate.Value;
            DateTime borrowDate = dtpBorrowDate.Value;
            return new BorrowDetail
            {
                bookCode = bCode,
                bookTitle = bTitle,
                borrowDate = borrowDate,
                dueDate = dueDate
            };
        }

        private Borrow CreateBorrow()
        {
            DateTime borrowDate;
            if (!DateTime.TryParse(dtpBorrowDate.Value.ToString(), out borrowDate))
            {
                MessageBox.Show("Invalid Borrow Date.");
                return null!;
            }

            int memberID;
            if (cmbMemberID.Text == null || !int.TryParse(cmbMemberID.Text, out memberID))
            {
                MessageBox.Show("Invalid Member ID.");
                return null!;
            }

            short staffID;
            if (cmbStaffID.SelectedValue == null || cmbStaffID.SelectedValue == DBNull.Value || !short.TryParse(cmbStaffID.SelectedValue.ToString(), out staffID))
            {
                MessageBox.Show("Invalid Staff ID.");
                return null!;
            }

            string staffName = txtStaffName.Text;
            string staffPosition = txtStaffPosition.Text;
            string memberName = txtMemberName.Text;
            return new Borrow
            {
                borrowDate = borrowDate,
                memberID = memberID,
                staffID = staffID,
                staffName = staffName,
                staffPosition = staffPosition,
                memberName = memberName
            };
        }

        private void RefreshDataGridView()
        {
            dgvBorrowDisplay.DataSource = null;
            dgvBorrowDisplay.DataSource = borrowDetailsTable;
        }

        private void cmbBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBCode.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbBCode.SelectedItem;
                string bookTilte = selectedRow["BookTitle"].ToString()!;
                txtBTitle.Text = bookTilte;
            }
        }

        private void cmbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMemberID.SelectedValue != null)
            {
                int selectedMemberID = (int)cmbMemberID.SelectedValue;
                DataRowView selectedRow = (DataRowView)cmbMemberID.SelectedItem;
                string memberName = selectedRow["MemberName"].ToString()!;
                txtMemberName.Text = memberName;
            }
        }

        private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStaffID.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbStaffID.SelectedItem;
                string staffName = selectedRow["StaffName"].ToString()!;
                string staffPosition = selectedRow["StaffPosition"].ToString()!;
                txtStaffName.Text = staffName;
                txtStaffPosition.Text = staffPosition;
            }
        }
        private void dgvBorrowDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.AttachNavigationEvents(dgvBorrowDisplay);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvBorrowDisplay.SelectionChanged += dgvBorrowDisplay_SelectionChanged!;
                dgvBorrowDisplay_SelectionChanged(sender, e);
            }
        }
        private void dgvBorrowDisplay_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBorrowDisplay.SelectedRows.Count > 0)
            {
                if (isInsertButtonClicked == true)
                {
                    DataGridViewRow selectedRow = dgvBorrowDisplay.SelectedRows[0];
                    DataRowView? rowView = selectedRow.DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        DataRow row = rowView.Row;
                        DisplayBorrow(row);
                    }
                }
                else
                {
                    DataGridViewRow selectedRow = dgvBorrowDisplay.SelectedRows[0];
                    txtBTitle.Text = selectedRow.Cells[1].Value.ToString();
                    cmbBCode.Text = selectedRow.Cells[0].Value.ToString();
                    dtpDueDate.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (borrowDetailsTable != null)
            {
                borrowDetailsTable.Clear();
            }

            // Refresh the DataGridView to reflect the changes
            RefreshDataGridView();
            txtMemberName.TextChanged -= txtMemberName_TextChanged!;
            BindDataToDataGridView();
            Helper.ClearControls(this);
            dgvBorrowDisplay.ClearSelection();
            EnableControl();
            txtMemberName.TextChanged += txtMemberName_TextChanged!;
        }
        private void DisplayBorrow(DataRow row)
        {
            txtBorrowID.Text = row[0].ToString();
            dtpBorrowDate.Value = DateTime.Parse(row["BorrowDate"].ToString()!);
            cmbMemberID.Text = row["MemberID"].ToString();
            txtMemberName.Text = row["MemberName"].ToString();
            cmbStaffID.Text = row["StaffID"].ToString();
            txtStaffName.Text = row["StaffName"].ToString();
            txtStaffPosition.Text = row["StaffPosition"].ToString();
            txtBTitle.Text = row["BookTitle"].ToString();
            cmbBCode.Text = row["BookCode"].ToString();
            dtpDueDate.Value = DateTime.Parse(row["DueDate"].ToString()!);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int borrowID;
            if (int.TryParse(txtSearch.Text.Trim(), out borrowID))
            {
                string query = "SELECT * FROM fnSearchBorrowByBorrowID(@BorrowID)";
                searchBorrow = Helper.SearchByID(query, "@BorrowID", borrowID); ;
                //DataTable resultTable = Helper.SearchByID(query, "@BorrowID", borrowID);
                dgvBorrowDisplay.DataSource = null;
                dgvBorrowDisplay.DataSource = searchBorrow;
            }
            else
            {
                return;
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int borrowID;
                if (int.TryParse(txtSearch.Text.Trim(), out borrowID))
                {
                    string query = "SELECT * FROM fnSearchBorrowByBorrowID(@BorrowID)";
                    DataTable resultTable = Helper.SearchByID(query, "@BorrowID", borrowID);

                    if (resultTable != null && resultTable.Rows.Count > 0)
                    {
                        dgvBorrowDisplay.DataSource = null;
                        dgvBorrowDisplay.DataSource = resultTable;
                    }
                    else
                    {
                        MessageBox.Show($"No records found for the provided Borrow ID {borrowID}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer value for Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void cmbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                cmbMemberID_Leave(sender, e);
                e.SuppressKeyPress = true;
            }
        }
        private void EnableControl()
        {
            cmbStaffID.Enabled = true;
            cmbMemberID.Enabled = true;
            cmbBCode.Enabled = true;
            dgvBorrowDisplay.Enabled = true;
            dtpBorrowDate.Enabled = true;
            dtpDueDate.Enabled = true;
            btnInsertDetail.Enabled = true;
            btnUpdateDetail.Enabled = true;
            btnInsert.Enabled = true;
            btnUpdate.Enabled = true;
        }

        private void btnInsertDetail_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cmbMemberID.Text.Trim(), out int memberID))
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMemberID.Focus();
                return;
            }

            // Get the count of borrowed books from the database
            int borrowedBookCountFromDatabase = Borrow.GetBorowedBookCount(memberID);

            // Calculate the total number of borrowed books
            int totalBorrowedBooks = borrowedBookCountFromDatabase + borrowedBookCountInSession;

            // Check if the member has reached the borrow limit
            if (totalBorrowedBooks > 5)
            {
                MessageBox.Show("Member has reached the borrow limit and cannot borrow more items.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMemberID.Focus();
                isInsertButtonClicked = true;
                return;
            }
            /////////////////////////////////////////////////////////////////////////
            BorrowDetail borrowDetail = CreateBorrowDetail();

            if (borrowDetail == null)
                return;
            if (borrowDetailsTable == null)
            {
                InitializeBookDetailsTable();
            }
            if (Helper.IsBookAlreadyInDetails(borrowDetail.bookCode, borrowDetailsTable!))
            {
                MessageBox.Show("This book has already been added to the borrow details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(txtBorrowID.Text))
            {
                isInsertButtonClicked = false;
                AddBorrowDetail(borrowDetail);

                borrowedBookCountInSession++;
                borrowBindingSource.DataSource = borrowDetailsTable;

                RefreshDataGridView();
                cmbStaffID.Enabled = false;
                cmbMemberID.Enabled = false;
            }
            else
            {
                if (!int.TryParse(txtBorrowID.Text, out int borrowID) || borrowID <= 0)
                {
                    MessageBox.Show("Please enter a valid Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBorrowID.Focus();
                }
                borrowDetail.borrowId = borrowID;
                borrowDetail.bookCode = int.Parse(cmbBCode.Text);
                if (!Helper.IsBookAlreadyInDetails(borrowDetail.bookCode, searchBorrow!))
                {
                    if (searchBorrow == null)
                    {
                        MessageBox.Show($"Please search before insert more to Existed DATA.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    bool isSuccess = BorrowDetail.InsertBorrowDetail(borrowDetail);
                    if (isSuccess)
                    {
                        isInsertButtonClicked = false;
                        string query = "SELECT * FROM fnSearchBorrowByBorrowID(@BorrowID)";
                        DataTable resultTable = Helper.SearchByID(query, "@BorrowID", borrowDetail.borrowId);
                        dgvBorrowDisplay.DataSource = null;
                        dgvBorrowDisplay.DataSource = resultTable;

                        cmbStaffID.Enabled = false;
                        cmbMemberID.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("BorrowDetail was not inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("This book has already been added to the borrow details.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            isInsertButtonClicked = true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Borrow borrow = CreateBorrow();
            if (borrowBindingSource.Current == null)
            {
                MessageBox.Show("Please enter borrow details first.");
                return;
            }

            if (borrow != null)
            {
                if (borrowDetailsTable?.Rows.Count == 0)
                {
                    MessageBox.Show("Please insert at least one book detail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowsAffected;
                int borrowID = Borrow.InsertBorrowWithDetails(borrow, borrowDetailsTable!, out rowsAffected);

                MessageBox.Show($"Borrow record created with ID: {borrowID}. Rows affected: {rowsAffected}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                borrowDetailsTable!.Clear();
                borrowBindingSource.ResetBindings(false);
                BindDataToDataGridView();
            }
            cmbStaffID.Enabled = true;
            cmbMemberID.Enabled = true;
            Helper.ClearControls(this);
            dgvBorrowDisplay.ClearSelection();

            isInsertButtonClicked = true;
        }
        private void UpdateBorrowDetail(BorrowDetail borrowData)
        {
            try
            {
                borrowData = CreateBorrowDetail();

                if (borrowData != null)
                {
                    if (string.IsNullOrEmpty(txtBorrowID.Text.Trim()))
                    {
                        DataRow[] rows = borrowDetailsTable!.Select($"BookCode = {borrowData.bookCode}");
                        if (rows.Length > 0)
                        {
                            DataRow row = rows[0];

                            row["BookTitle"] = borrowData.bookTitle ?? (object)DBNull.Value;
                            row["DueDate"] = borrowData.dueDate;

                            RefreshDataGridView();
                        }
                        else
                        {
                            MessageBox.Show("Book not found in the details table.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (!int.TryParse(txtBorrowID.Text, out int borrowID) || borrowID <= 0)
                        {
                            MessageBox.Show("Please enter a valid Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtBorrowID.Focus();
                        }
                        borrowData.borrowId = borrowID;
                        bool isSuccess = BorrowDetail.UpdateBorrowDetail(borrowData);
                        if (isSuccess)
                        {
                            MessageBox.Show("BorrowDetail Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            string query = "SELECT * FROM fnSearchBorrowByBorrowID(@BorrowID)";
                            DataTable resultTable = Helper.SearchByID(query, "@BorrowID", borrowData.borrowId);
                            dgvBorrowDisplay.DataSource = null;
                            dgvBorrowDisplay.DataSource = resultTable;
                        }
                        else
                        {
                            MessageBox.Show("BorrowDetail was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            isInsertButtonClicked = false;
            BorrowDetail borrowDetail = CreateBorrowDetail();
            if (borrowDetail == null)
                return;

            UpdateBorrowDetail(borrowDetail);

            cmbStaffID.Enabled = false;
            cmbMemberID.Enabled = false;
            isInsertButtonClicked = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Borrow borrow = CreateBorrow();
            int borrowID;
            if (!int.TryParse(txtBorrowID.Text, out borrowID) || string.IsNullOrWhiteSpace(txtBorrowID.Text.Trim()))
            {
                MessageBox.Show("Invalid BorrowID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                borrow.borrowID = borrowID;
                if (borrow != null)
                {
                    bool isSuccess = Borrow.UpdateBorrow(borrow);
                    if (isSuccess)
                    {
                        MessageBox.Show($"Borrow record updated with ID: {borrowID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error update Borrow Record with ID: {borrowID}.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    borrowBindingSource.ResetBindings(false);
                    BindDataToDataGridView();
                }
            }

            cmbStaffID.Enabled = true;
            cmbMemberID.Enabled = true;
            Helper.ClearControls(this);
            dgvBorrowDisplay.ClearSelection();

            isInsertButtonClicked = true;
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

        private void cmbMemberID_Leave(object sender, EventArgs e)
        {
            Helper.ValidateAndFetchData(cmbMemberID, txtMemberName, "MemberID", "MemberName");
        }

        private void cmbBCode_Leave(object sender, EventArgs e)
        {
            Helper.ValidateAndFetchData(cmbBCode, txtBTitle, "BookCode", "BookTitle");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtMemberName_TextChanged(object sender, EventArgs e)
        {
            cmbBCode_TextChanged(sender, e);
        }

        private void cmbBCode_TextChanged(object sender, EventArgs e)
        {
            //int memberID, bookCode;
            //if (!string.IsNullOrWhiteSpace(cmbBCode.Text.Trim()) && !string.IsNullOrWhiteSpace(cmbMemberID.Text.Trim()))
            //{
            //    if (int.TryParse(cmbMemberID.Text.Trim(), out memberID) && int.TryParse(cmbBCode.Text.Trim(), out bookCode))
            //    {
            //        bool hasExpired;
            //        if (!Helper.CheckBorrowExpired(memberID, bookCode, out hasExpired))
            //        {
            //            EnableControl();
            //            Helper.SetFocusToControl(this, cmbStaffID);
            //            return;
            //        }

            //        if (hasExpired)
            //        {
            //            MessageBox.Show("Your Borrowed Book was Expired.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            //DisableControl();
            //            Helper.SetFocusToControl(this, cmbMemberID);
            //            cmbBCode.TextChanged -= cmbBCode_TextChanged!;
            //            return;
            //        }
            //    }
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
