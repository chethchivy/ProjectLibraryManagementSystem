using Microsoft.Identity.Client.NativeInterop;
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
    public partial class FormReturn : Form
    {
        private bool isInsertButtonClicked = true;
        private bool isCalculatingFine = false;
        private DataTable? returnDetailsTable;
        private BindingSource borrowBindingSource = new BindingSource();
        private Timer loginTimer = null!;
        public FormReturn()
        {
            InitializeComponent();
            InitializeReturnDetailsTable();
            BindDataToDataGridView();
        }
        private void FormReturn_Load(object sender, EventArgs e)
        {
            LoadMemberCmb();
            LoadStaffCmb();
            cmbStaffID.Refresh();
            cmbBorrowID.SelectedIndexChanged += (s, e) => ShowFineAmount();
            txtBookCode.TextChanged += (s, e) => ShowFineAmount();
            dtpReturnDate.ValueChanged += (s, e) => ShowFineAmount();
            checkRipped.CheckedChanged += (s, e) => ShowFineAmount();

            dgvReturnDisplay.AutoGenerateColumns = false;
            dgvReturnDisplay.Columns.Clear();
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BorrowID", DataPropertyName = "BorrowID" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BookCode", DataPropertyName = "BookCode" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Book Title", DataPropertyName = "BookTitle" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BorrowDate", DataPropertyName = "BorrowDate" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "DueDate", DataPropertyName = "DueDate" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Ripped", DataPropertyName = "Ripped" });
            dgvReturnDisplay.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "FineAmount", DataPropertyName = "FineAmount" });
            dgvReturnDisplay.Columns[1].Visible = false;

            Helper.ClearControls(this);
            dgvReturnDisplay.ClearSelection();
            dtpReturnDate.Value = DateTime.Now;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
            cmbBorrowID.Text = "";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            BindDataToDataGridView();
            Helper.ClearControls(this);
            dgvReturnDisplay.ClearSelection();
            isInsertButtonClicked = true;
            cmbMemberID.Enabled = true;
            cmbStaffID.Enabled = true;
            dtpReturnDate.Value = DateTime.Now;
            dtpBorrowDate.Value = DateTime.Now;
            dtpDueDate.Value = DateTime.Now;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMemberID.SelectedValue != null)
            {
                int selectedMemberID = (int)cmbMemberID.SelectedValue;
                DataRowView selectedRow = (DataRowView)cmbMemberID.SelectedItem;
                string memberName = selectedRow["MemberName"].ToString()!;
                txtMemberName.Text = memberName;
                cmbBorrowID.Text = "";

                PopulateBookTitleComboBox(selectedMemberID);
                //string query = "SELECT * FROM fnGetBorrowByMemberID(@MemberID)";
                ////string query = "SELECT BorrowID FROM fnGetBorrowByMemberID(@MemberID)";
                //DataTable resultTable = Helper.SearchByID(query, "@MemberID", selectedMemberID);
                //Helper.ShowInCombobox(resultTable, cmbBookTitle, "BookTitle");
                ////cmbBookTitle_SelectedIndexChanged(sender, e);
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

        private void cmbBookTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBookTitle_TextChanged(sender, e);
        }
        private void GetBorrowAndDueDate()
        {
            if (int.TryParse(cmbBorrowID.Text, out int borrowID) && int.TryParse(txtBookCode.Text, out int bookCode))
            {
                ReturnDetail detail = Return.GetBorrowAndDueDateByBorrowID(borrowID, bookCode);
                if (detail != null)
                {
                    dtpDueDate.Text = detail.dueDate.ToString("yyyy-MM-dd");
                    dtpBorrowDate.Text = detail.borrowDate.ToString("yyyy-MM-dd");
                }
                else
                {
                    //MessageBox.Show("No Return details found for the given BorrowID and BookCode.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtpBorrowDate.Text = string.Empty;
                    dtpDueDate.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please enter valid BorrowID and BookCode.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public static decimal CalculateFine(int borrowID, int bookCode, DateTime dueDate, DateTime returnDate, bool isRipped)
        {
            decimal fineAmount = 0;
            if (isRipped)
            {
                fineAmount = Return.GetBookPriceByBookCode(bookCode);
            }
            else
            {
                decimal lateFee = Return.GetLateFeeByBookCode(bookCode);
                if (returnDate <= dueDate)
                {
                    return 0; // No fine if returned on or before the due date
                }

                int daysLate = (returnDate - dueDate).Days;
                fineAmount = daysLate * lateFee;

            }
            return fineAmount;
        }
        private void ShowFineAmount()
        {
            if (isCalculatingFine)
                return;

            isCalculatingFine = true;

            if (int.TryParse(cmbBorrowID.Text, out int borrowID) && int.TryParse(txtBookCode.Text, out int bookCode) && DateTime.TryParse(dtpDueDate.Text, out DateTime dueDate) && DateTime.TryParse(dtpReturnDate.Text, out DateTime returnDate))
            {
                try
                {
                    bool isRipped = checkRipped.Checked;
                    decimal fineAmount = CalculateFine(borrowID, bookCode, dueDate, returnDate, isRipped);
                    txtFineAmount.Text = fineAmount.ToString("F2");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error calculating fine amount: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtFineAmount.Text = string.Empty;
            }
            isCalculatingFine = false;
        }
        private void InitializeReturnDetailsTable()
        {
            returnDetailsTable = new DataTable();
            returnDetailsTable.Columns.Add("BorrowID", typeof(int));
            returnDetailsTable.Columns.Add("BookCode", typeof(int));
            returnDetailsTable.Columns.Add("BookTitle", typeof(string));
            returnDetailsTable.Columns.Add("BorrowDate", typeof(DateTime));
            returnDetailsTable.Columns.Add("DueDate", typeof(DateTime));
            returnDetailsTable.Columns.Add("Ripped", typeof(bool));
            returnDetailsTable.Columns.Add("FineAmount", typeof(decimal));
        }
        private void AddReturnDetail(ReturnDetail rd)
        {
            DataRow row = returnDetailsTable!.NewRow();
            row["BorrowID"] = rd.borrowID;
            row["BookCode"] = rd.bookCode;
            row["BookTitle"] = rd.bookTitle;
            row["BorrowDate"] = rd.borrowDate;
            row["DueDate"] = rd.dueDate;
            //row["ReturnDate"] = rd.returnDate;
            row["Ripped"] = rd.checkRipped;
            row["FineAmount"] = rd.fineAmount;

            returnDetailsTable.Rows.Add(row);
            RefreshDataGridView(); // Assuming this method refreshes the DataGridView
        }
        private void BindDataToDataGridView()
        {
            string query = "SELECT * FROM vReturnDetails;";
            DataTable dataTable = Helper.ReadData(query);
            //borrowDetailsTable = dataTable;
            dgvReturnDisplay.DataSource = dataTable;
        }
        private void RefreshDataGridView()
        {
            dgvReturnDisplay.DataSource = null;
            dgvReturnDisplay.DataSource = returnDetailsTable;
        }
        private ReturnDetail CreateReturnDetail()
        {
            int borrowID;
            if (cmbBorrowID.Text == null || cmbBorrowID.SelectedValue == DBNull.Value || !int.TryParse(cmbBorrowID.Text, out borrowID))
            {
                MessageBox.Show("Invalid Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBorrowID.Focus();
                return null!;
            }
            int bCode;
            if (txtBookCode.Text == DBNull.Value.ToString() || string.IsNullOrWhiteSpace(txtBookCode.Text))
            {
                MessageBox.Show("Please enter a book code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookCode.Focus();
                return null!;
            }
            else
            {
                bCode = Convert.ToInt32(txtBookCode.Text);
            }
            string bTitle = cmbBookTitle.Text;
            if (string.IsNullOrWhiteSpace(bTitle))
            {
                MessageBox.Show("Please enter a book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBookTitle.Focus();
                return null!;
            }
            DateTime dueDate = dtpDueDate.Value;
            DateTime borrowDate = dtpBorrowDate.Value;

            bool isRipped;
            if (checkRipped.Checked)
            {
                isRipped = true;
            }
            else
            {
                isRipped = false;
            }
            decimal fineAmount = 0;
            if (string.IsNullOrWhiteSpace(txtFineAmount.Text))
            {
                MessageBox.Show("Please enter a fine amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFineAmount.Focus();
                return null!;
            }

            if (!decimal.TryParse(txtFineAmount.Text, out fineAmount))
            {
                MessageBox.Show("Invalid fine amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null!;
            }
            // Add new
            if (txtReturnID.Text == DBNull.Value.ToString() || string.IsNullOrWhiteSpace(txtReturnID.Text))
            {
                return new ReturnDetail
                {
                    borrowID = borrowID,
                    bookCode = bCode,
                    bookTitle = bTitle,
                    borrowDate = borrowDate,
                    dueDate = dueDate,
                    checkRipped = isRipped,
                    fineAmount = fineAmount
                };
            }
            else
            {
                int returnID;
                if (!int.TryParse(txtReturnID.Text, out returnID))
                {
                    MessageBox.Show("Invalid Return ID. Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null!;
                }
                return new ReturnDetail
                {
                    returnID = returnID,
                    borrowID = borrowID,
                    bookCode = bCode,
                    bookTitle = bTitle,
                    borrowDate = borrowDate,
                    dueDate = dueDate,
                    checkRipped = isRipped,
                    fineAmount = fineAmount
                };
            }
        }
        private Return CreateReturn()
        {
            DateTime returnDate = dtpReturnDate.Value;

            int memberID;
            if (cmbMemberID.SelectedValue == null || cmbMemberID.SelectedValue == DBNull.Value || !int.TryParse(cmbMemberID.Text.ToString(), out memberID))
            {
                MessageBox.Show("Invalid Member ID.");
                cmbMemberID.Focus();
                return null!;
            }

            short staffID;
            if (cmbStaffID.SelectedValue == null || cmbStaffID.SelectedValue == DBNull.Value || !short.TryParse(cmbStaffID.Text.ToString(), out staffID))
            {
                MessageBox.Show("Invalid Staff ID.");
                cmbStaffID.Focus();
                return null!;
            }
            return new Return
            {
                ReturnDate = returnDate,
                memberID = memberID,
                staffID = staffID
            };
        }
        private void btnInsertDetail_Click(object sender, EventArgs e)
        {
            isInsertButtonClicked = false;
            ReturnDetail returnDetail = CreateReturnDetail();
            if (returnDetail == null)
                return;
            if (returnDetailsTable == null)
            {
                InitializeReturnDetailsTable();
            }
            if (string.IsNullOrEmpty(txtReturnID.Text))
            {
                AddReturnDetail(returnDetail);

                borrowBindingSource.DataSource = returnDetailsTable;

                RefreshDataGridView();
            }
            else
            {
                if (!int.TryParse(txtReturnID.Text, out int returnID) || returnID <= 0)
                {
                    MessageBox.Show("Please enter a valid Return ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtReturnID.Focus();
                }
                int borrowID = int.Parse(cmbBorrowID.Text);
                int bookCode = int.Parse(txtBookCode.Text);
                int memberID = int.Parse(cmbMemberID.Text);
                bool isSuccess = ReturnDetail.InsertReturnDetail(returnDetail);
                if (isSuccess)
                {
                    isInsertButtonClicked = false;
                    Helper.DeleteBookFromBorrowDetail(borrowID, bookCode);
                    string query = "SELECT * FROM fnSearchReturnByReturnID(@ReturnID)";
                    DataTable resultTable = Helper.SearchByID(query, "@ReturnID", returnID);
                    dgvReturnDisplay.DataSource = null;
                    dgvReturnDisplay.DataSource = resultTable;

                    cmbBookTitle.Text = "";
                    txtBookCode.Text = "";
                    PopulateBookTitleComboBox(memberID);

                    cmbStaffID.Enabled = false;
                    cmbMemberID.Enabled = false;
                }
                else
                {
                    MessageBox.Show("ReturnDetail was not inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            //cmbStaffID.Enabled = false;
            //cmbMemberID.Enabled = false;
        }
        private void PopulateBookTitleComboBox(int memberID)
        {
            string query = "SELECT * FROM fnGetBorrowByMemberID(@MemberID)";
            DataTable bookTitles = Helper.SearchByID(query, "@MemberID", memberID);
            cmbBookTitle.DataSource = bookTitles;
            cmbBookTitle.DisplayMember = "BookTitle"; // Replace with actual column name
            cmbBookTitle.ValueMember = "BookCode"; // Replace with actual column name
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Return r = CreateReturn();
            if (borrowBindingSource.Current == null)
            {
                MessageBox.Show("Please enter Return details first.");
                return;
            }

            if (r != null)
            {
                if (returnDetailsTable!.Rows.Count == 0)
                {
                    MessageBox.Show("Please insert at least one book detail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowsAffected;
                int returnID = Return.InsertReturnWithDetails(r, returnDetailsTable, out rowsAffected);

                decimal totalFineAmount = returnDetailsTable.AsEnumerable().Sum(row => row.Field<decimal>("FineAmount"));

                MessageBox.Show($"Return record created with ID: {returnID}. Rows affected: {rowsAffected}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormInvoice invoiceForm = new FormInvoice(r.memberID, r.staffID, returnID, totalFineAmount);
                invoiceForm.ShowDialog();

                returnDetailsTable.Clear();
                borrowBindingSource.ResetBindings(false);
                BindDataToDataGridView();
                Helper.ClearControls(this);
                dgvReturnDisplay.ClearSelection();
                isInsertButtonClicked = true;
            }
            cmbStaffID.Enabled = true;
            cmbMemberID.Enabled = true;

            isInsertButtonClicked = false;
        }

        private void dgvReturnDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.AttachNavigationEvents(dgvReturnDisplay);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDown;
                dgvReturnDisplay.SelectionChanged += dgvReturnDisplay_SelectionChanged!;
                //cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDownList;
                //dgvReturnDisplay_SelectionChanged(sender, e);
            }
        }
        private void DisplayReturn(DataRow row)
        {
            txtReturnID.Text = row[0].ToString();
            dtpReturnDate.Value = DateTime.Parse(row["ReturnDate"].ToString()!);
            cmbMemberID.Text = row["MemberID"].ToString();
            txtMemberName.Text = row["MemberName"].ToString();
            cmbStaffID.Text = row["StaffID"].ToString();
            txtStaffName.Text = row["StaffName"].ToString();
            txtStaffPosition.Text = row["StaffPosition"].ToString();
            cmbBorrowID.Text = row["BorrowID"].ToString();
            txtBookCode.Text = row["BookCode"].ToString();
            cmbBookTitle.Text = row["BookTitle"].ToString();
            dtpBorrowDate.Value = DateTime.Parse(row["BorrowDate"].ToString()!);
            dtpDueDate.Value = DateTime.Parse(row["DueDate"].ToString()!);
            txtFineAmount.Text = row["FineAmount"].ToString();
            if (row.Table.Columns.Contains("Ripped") && row["Ripped"] != DBNull.Value)
            {
                checkRipped.Checked = Convert.ToBoolean(row["Ripped"]);
            }
            else
            {
                checkRipped.Checked = false; // or set to an appropriate default value
            }
        }
        private void dgvReturnDisplay_SelectionChanged(object sender, EventArgs e)
        {
            //cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDown;
            if (dgvReturnDisplay.SelectedRows.Count > 0)
            {
                cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDown;
                if (isInsertButtonClicked == true)
                {
                    DataGridViewRow selectedRow = dgvReturnDisplay.SelectedRows[0];
                    DataRowView? rowView = selectedRow.DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        DataRow row = rowView.Row;
                        DisplayReturn(row);
                    }
                }
                else
                {
                    DataGridViewRow selectedRow = dgvReturnDisplay.SelectedRows[0];
                    cmbBorrowID.Text = selectedRow.Cells[0].Value.ToString();
                    txtBookCode.Text = selectedRow.Cells[1].Value.ToString();
                    cmbBookTitle.Text = selectedRow.Cells[2].Value.ToString();
                    dtpBorrowDate.Value = Convert.ToDateTime(selectedRow.Cells[3].Value);
                    dtpDueDate.Value = Convert.ToDateTime(selectedRow.Cells[4].Value);
                    if (selectedRow.Cells[5].Value != DBNull.Value)
                    {
                        checkRipped.Checked = Convert.ToBoolean(selectedRow.Cells[5].Value);
                    }
                    else
                    {
                        checkRipped.Checked = false; // Default value if the cell is null
                    }
                    txtFineAmount.Text = selectedRow.Cells[6].Value.ToString();
                }
            }
            else
            {
                cmbBookTitle.DropDownStyle = ComboBoxStyle.DropDownList;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int returnID;
            if (string.IsNullOrEmpty(txtSearch.Text))
            {
                btnNew_Click(sender, e);
            }
            else
            {
                if (int.TryParse(txtSearch.Text.Trim(), out returnID))
                {
                    string query = "SELECT * FROM fnSearchReturnByReturnID(@ReturnID)";
                    DataTable resultTable = Helper.SearchByID(query, "@ReturnID", returnID);
                    dgvReturnDisplay.DataSource = null;
                    dgvReturnDisplay.DataSource = resultTable;
                }
                else
                {
                    return;
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int returnID;
                if (string.IsNullOrEmpty(txtSearch.Text))
                {
                    MessageBox.Show("Please Enter Return ID to search : ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNew_Click(sender, e);
                }
                else
                {
                    if (int.TryParse(txtSearch.Text.Trim(), out returnID))
                    {
                        string query = "SELECT * FROM fnSearchReturnByReturnID(@ReturnID)";
                        DataTable resultTable = Helper.SearchByID(query, "@ReturnID", returnID);

                        if (resultTable != null && resultTable.Rows.Count > 0)
                        {
                            dgvReturnDisplay.DataSource = null;
                            dgvReturnDisplay.DataSource = resultTable;
                        }
                        else
                        {
                            MessageBox.Show($"No records found for the provided Return ID {returnID}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid integer value for Return ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                e.SuppressKeyPress = true;
            }
        }

        private void cmbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                DataTable resultTable;
                bool isValidate = Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
                if (isValidate)
                {
                    Helper.ShowInCombobox(resultTable, cmbBookTitle, "BookTitle");
                    //Helper.ShowInCombobox(resultTable, cmbBorrowID, "BorrowID");
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbMemberID_Leave(object sender, EventArgs e)
        {
            DataTable resultTable;
            bool isValidate = Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
            if (isValidate)
            {
                Helper.ShowInCombobox(resultTable, cmbBookTitle, "BookTitle");
            }
            cmbBookTitle.SelectedIndexChanged += cmbBookTitle_SelectedIndexChanged!;
        }
        private void UpdateReturnDetail(ReturnDetail returnData)
        {
            try
            {
                returnData = CreateReturnDetail();

                if (returnData != null)
                {
                    if (!int.TryParse(txtReturnID.Text, out int returnID) || returnID <= 0)
                    {
                        MessageBox.Show("Please enter a valid Return ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtReturnID.Focus();
                    }
                    returnData.returnID = returnID;
                    bool isSuccess = ReturnDetail.UpdateReturnDetail(returnData);
                    if (isSuccess)
                    {
                        MessageBox.Show("ReturnDetail Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string query = "SELECT * FROM fnSearchReturnByReturnID(@ReturnID)";
                        DataTable resultTable = Helper.SearchByID(query, "@ReturnID", returnData.returnID);
                        dgvReturnDisplay.DataSource = null;
                        dgvReturnDisplay.DataSource = resultTable;
                    }
                    else
                    {
                        MessageBox.Show("Returnetail was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            checkRipped.CheckedChanged += (s, e) => ShowFineAmount();
            ReturnDetail returnDetail = CreateReturnDetail();
            int returnID;
            if (!int.TryParse(txtReturnID.Text, out returnID))
            {
                MessageBox.Show("Please input correct ReturnID.........", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (returnDetail == null)
                return;
            UpdateReturnDetail(returnDetail);

            cmbStaffID.Enabled = false;
            cmbMemberID.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Return returnData = CreateReturn();
            int returnID;
            if (!int.TryParse(txtReturnID.Text, out returnID) || string.IsNullOrWhiteSpace(txtReturnID.Text.Trim()))
            {
                MessageBox.Show("Invalid ReturnID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                returnData.returnID = returnID;
                if (returnData != null)
                {
                    bool isSuccess = Return.UpdateReturn(returnData);
                    if (isSuccess)
                    {
                        MessageBox.Show($"Return record updated with ID: {returnID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show($"Error update Return Record with ID: {returnID}.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    borrowBindingSource.ResetBindings(false);
                    BindDataToDataGridView();
                }
            }
            cmbStaffID.Enabled = true;
            cmbMemberID.Enabled = true;
            Helper.ClearControls(this);
            dgvReturnDisplay.ClearSelection();

            isInsertButtonClicked = true;
        }

        private void cmbBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (cmbBookTitle.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbBookTitle.SelectedItem;
                int bookCode = (int)selectedRow["BookCode"];
                // string bookCode = selectedRow["BookCode"].ToString()!;
                txtBookCode.Text = bookCode.ToString();
                string query = "SELECT * FROM fnGetBorrowIDByBookCode(@BookCode)";
                DataTable resultTable = Helper.SearchByID(query, "@BookCode", bookCode);
                Helper.ShowInCombobox(resultTable, cmbBorrowID, "BorrowID");
                GetBorrowAndDueDate();
            }
        }

        private void FormReturn_MaximumSizeChanged(object sender, EventArgs e)
        {

        }
    }
}
