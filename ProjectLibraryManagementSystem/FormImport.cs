using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using ProjectLibraryManagementSystem;
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
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormImport : Form
    {
        private Timer loginTimer = null!;
        private bool isInsertButtonClicked = true;
        private DataTable? importDetailsTable;
        private BindingSource importBindingSource = new BindingSource();
        public FormImport()
        {
            InitializeComponent();
            InitializeBookDetailsTable();
            LoadSupplierCmb();
            LoadStaffCmb();
            LoadBookCodeCmb();
            BindDataToDataGridView();
            Helper.ClearControls(this);
        }

        private void FormImport_Load(object sender, EventArgs e)
        {
            cmbStaffID.Refresh();
            cmbSupID.Refresh();
            cmbBCode.Refresh();

            dgvImpDetail.AutoGenerateColumns = false;
            dgvImpDetail.Columns.Clear();

            dgvImpDetail.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "BookCode", DataPropertyName = "BookCode" });
            dgvImpDetail.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Book Title", DataPropertyName = "BookTitle" });
            dgvImpDetail.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "ImportQty", DataPropertyName = "ImportQty" });
            dgvImpDetail.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "UnitPrice", DataPropertyName = "UnitPrice" });
            dgvImpDetail.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Amount", DataPropertyName = "Amount" });


            dgvImpDetail.ClearSelection();
            Helper.ClearControls(this);

            Helper.AttachNavigationEvents(this);
        }
        private void InitializeBookDetailsTable()
        {
            importDetailsTable = new DataTable();
            importDetailsTable.Columns.Add("BookCode", typeof(int));
            importDetailsTable.Columns.Add("BookTitle", typeof(string));
            importDetailsTable.Columns.Add("ImportQty", typeof(byte)); // Ensure these columns exist
            importDetailsTable.Columns.Add("UnitPrice", typeof(decimal));
            importDetailsTable.Columns.Add("Amount", typeof(decimal));
        }
        private void AddImportDetail(ImportDetail id)
        {
            DataRow row = importDetailsTable!.NewRow();
            if (id?.BookCode != null)
                row["BookCode"] = id.BookCode;
            else
                row["BookCode"] = DBNull.Value;

            // BookTitle
            if (id?.BookTitle != null)
                row["BookTitle"] = id.BookTitle;
            else
                row["BookTitle"] = DBNull.Value;

            // BorrowDate
            if (id?.ImportQty != null)
                row["ImportQty"] = id.ImportQty;
            else
                row["ImportQty"] = DBNull.Value;
            // DueDate
            if (id?.UnitPrice != null)
                row["UnitPrice"] = id.UnitPrice;
            else
                row["UnitPrice"] = DBNull.Value;
            if (id?.Amount != null)
                row["Amount"] = id.Amount;
            else
                row["Amount"] = DBNull.Value;

            importDetailsTable.Rows.Add(row);
            RefreshDataGridView(); // Assuming this method refreshes the DataGridView
        }
        private void BindDataToDataGridView()
        {
            string query = "SELECT * FROM vImportDetails;";
            DataTable dataTable = Import.GetImportDetails(query);
            dgvImpDetail.DataSource = dataTable;
        }
        private Import CreateImport()
        {
            short staffID;
            byte supplierID;
            decimal totalAmount;
            DateTime importDate;
            string staffName, staffPosition, supplierName;

            if (string.IsNullOrEmpty(cmbStaffID.Text))
            {
                MessageBox.Show("Please Select Staff ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbStaffID.Focus();
                return null!;
            }
            else
            {
                if (!short.TryParse(cmbStaffID.Text, out staffID))
                {
                    MessageBox.Show("Invalid Staff ID format.");
                    cmbStaffID.Focus();
                }
            }
            staffName = txtStaffName.Text;
            staffPosition = txtStaffPosition.Text;


            if (string.IsNullOrEmpty(cmbSupID.Text))
            {
                MessageBox.Show("Please Select Supplier ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSupID.Focus();
                return null!;
            }
            else
            {
                if (!byte.TryParse(cmbSupID.Text, out supplierID))
                {
                    MessageBox.Show("Invalid Supplier ID format.");
                    cmbSupID.Focus();
                    return null!;
                }
            }
            supplierName = txtSupName.Text;
            importDate = DateTime.Now;
            if (!decimal.TryParse(txtTotal.Text, out totalAmount))
            {
                MessageBox.Show("Please Input Validate TotalAmount.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null!;
            }

            return new Import
            {
                ImportDate = importDate,
                TotalAmount = totalAmount,
                StaffID = staffID,
                StaffName = staffName,
                StaffPosition = staffPosition,
                SupplierID = supplierID,
                SupplierName = supplierName,

            };
        }

        private ImportDetail CreateImportDetail()
        {
            int bookCode = 0;
            if (string.IsNullOrEmpty(cmbBCode.Text))
            {
                MessageBox.Show("Please Select Book Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbBCode.Focus();
            }
            else
            {
                if (!int.TryParse(cmbBCode.Text, out bookCode))
                {
                    MessageBox.Show("Invalid Book Code format.");
                    cmbBCode.Focus();
                }
            }
            bool hasBook = Helper.IsBookAlreadyInDetails(bookCode, importDetailsTable!);
            if (!hasBook)
            {
                MessageBox.Show("This Book Code already exists in the import details list.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBCode.Focus();
                return null!;
            }
            string bookTile = null!;
            if (string.IsNullOrEmpty(txtBTitle.Text))
            {
                MessageBox.Show("Invalid Book Title format.");
                txtBTitle.Focus();
            }
            else
            {
                bookTile = txtBTitle.Text;
            }
            // Validate and parse ImportQty
            byte importQty;
            if (!byte.TryParse(txtBookQty.Text, out importQty))
            {
                MessageBox.Show("Invalid Book Quantity format.");
                txtBookQty.Focus();
            }
            // Validate and parse UnitPrice
            decimal unitPrice;
            if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice))
            {
                MessageBox.Show("Invalid Unit Price format.");
            }
            decimal amount = importQty * unitPrice;
            //txtAmount.Text = amount.ToString("F");

            return new ImportDetail
            {
                BookCode = bookCode,
                BookTitle = bookTile,
                ImportQty = importQty,
                UnitPrice = unitPrice,
                Amount = amount
            };
        }

        private void RefreshDataGridView()
        {
            dgvImpDetail.DataSource = null;
            dgvImpDetail.DataSource = importDetailsTable;
        }
        private void LoadSupplierCmb()
        {
            string query = "SELECT * FROM vGetSuppliersName";
            Helper.LoadCombobox(query, "SupplierID", "SupplierID", cmbSupID);
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
        private decimal CalculateTotalAmount(DataTable importDetailsTable)
        {
            decimal totalAmount = 0;

            foreach (DataRow row in importDetailsTable.Rows)
            {
                if (row["Amount"] != DBNull.Value)
                {
                    totalAmount += Convert.ToDecimal(row["Amount"]);
                }
            }

            return totalAmount;
        }
        private void btnInsertDetail_Click(object sender, EventArgs e)
        {
            isInsertButtonClicked = false;
            ImportDetail impDetail = CreateImportDetail();

            if (impDetail == null)
                return;
            if (string.IsNullOrEmpty(txtImpID.Text))
            {
                AddImportDetail(impDetail);
                decimal totalAmount = CalculateTotalAmount(importDetailsTable!);
                txtTotal.Text = totalAmount.ToString("F2");

                importBindingSource.DataSource = importDetailsTable;

                RefreshDataGridView();
            }
            else
            {
                if (!int.TryParse(txtImpID.Text, out int impD) || impD <= 0)
                {
                    MessageBox.Show("Please enter a valid Import ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtImpID.Focus();
                }
                impDetail.ImportID = impD;
                bool isSuccess = ImportDetail.InsertImportDetail(impDetail);
                if (isSuccess)
                {
                    string query = "SELECT * FROM fnSearchImportByImportID(@ImportID)";
                    DataTable resultTable = Helper.SearchByID(query, "@ImportID", impDetail.ImportID);
                    dgvImpDetail.DataSource = null;
                    dgvImpDetail.DataSource = resultTable;
                    decimal totalAmount = CalculateTotalAmount(resultTable);
                    txtTotal.Text = totalAmount.ToString("F2");
                }
                else
                {
                    MessageBox.Show("ImportDetail was not inserted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            cmbStaffID.Enabled = false;
            cmbSupID.Enabled = false;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Import import = CreateImport();
            if (importBindingSource.Current == null)
            {
                MessageBox.Show("Please enter import details first.");
                return;
            }

            if (import != null)
            {
                if (importDetailsTable?.Rows.Count == 0)
                {
                    MessageBox.Show("Please insert at least one book detail.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int rowsAffected;
                int importID = Import.InsertImportWithDetails(import, importDetailsTable!, out rowsAffected);


                MessageBox.Show($"Import record created with ID: {importID}. Rows affected: {rowsAffected}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                importDetailsTable!.Clear();
                importBindingSource.ResetBindings(false);
                BindDataToDataGridView();
            }
            cmbStaffID.Enabled = true;
            cmbSupID.Enabled = true;
            Helper.ClearControls(this);
            dgvImpDetail.ClearSelection();

            isInsertButtonClicked = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Import impData = CreateImport();

                if (impData != null)
                {
                    if (!int.TryParse(txtImpID.Text, out int impD) || impD <= 0)
                    {
                        MessageBox.Show("Please enter a valid Import ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtImpID.Focus();
                    }
                    impData.ImportID = impD;
                    bool isSuccess = Import.UpdateImport(impData);
                    if (isSuccess)
                    {
                        MessageBox.Show("Import Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnNew_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("ImportDetail was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            BindDataToDataGridView();
            dgvImpDetail.ClearSelection();
            cmbStaffID.Enabled = true;
            cmbSupID.Enabled = true;
            isInsertButtonClicked = true;
            Helper.ClearControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DisplayImport(DataRow row)
        {
            txtImpID.Text = row["ImportID"].ToString();
            dtpImpDate.Value = DateTime.Parse(row["ImportDate"].ToString()!);
            txtTotal.Text = ((decimal)row["TotalAmount"]).ToString("F2");
            cmbSupID.Text = row["SupplierID"].ToString();
            txtSupName.Text = row["SupplierName"].ToString();
            cmbStaffID.Text = row["StaffID"].ToString();
            txtStaffName.Text = row["StaffName"].ToString();
            txtStaffPosition.Text = row["StaffPosition"].ToString();
            cmbBCode.Text = row["BookCode"].ToString();
            txtBTitle.Text = row["BookTitle"].ToString();
            txtBookQty.Text = row["ImportQty"].ToString();
            txtUnitPrice.Text = ((decimal)row["UnitPrice"]).ToString("F2");
            txtAmount.Text = ((decimal)row["Amount"]).ToString("F2");
        }
        private void dgvImpDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.AttachNavigationEvents(dgvImpDetail);
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dgvImpDetail.SelectionChanged += dgvImpDetail_SelectionChanged!;
                dgvImpDetail_SelectionChanged(sender, e);
            }
        }

        private void dgvImpDetail_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvImpDetail.SelectedRows.Count > 0)
            {
                if (isInsertButtonClicked == true)
                {
                    DataGridViewRow selectedRow = dgvImpDetail.SelectedRows[0];
                    DataRowView? rowView = selectedRow.DataBoundItem as DataRowView;

                    if (rowView != null)
                    {
                        DataRow row = rowView.Row;
                        DisplayImport(row);
                    }
                }
                else
                {
                    DataGridViewRow selectedRow = dgvImpDetail.SelectedRows[0];
                    cmbBCode.Text = selectedRow.Cells[0].Value.ToString();
                    txtBTitle.Text = selectedRow.Cells[1].Value.ToString();
                    txtBookQty.Text = selectedRow.Cells[2].Value.ToString();
                    txtUnitPrice.Text = selectedRow.Cells[3].Value.ToString();
                    txtAmount.Text = selectedRow.Cells[4].Value.ToString();
                }
            }
        }

        private void cmbSupID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupID.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbSupID.SelectedItem;
                string supName = selectedRow["SupplierName"].ToString()!;
                txtSupName.Text = supName;
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

        private void CalculateAmount()
        {
            if (int.TryParse(txtBookQty.Text, out int bookQty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
            {
                decimal amount = bookQty * unitPrice;
                txtAmount.Text = amount.ToString("0.00");
            }
            else
            {
                txtAmount.Clear();
            }
        }
        private void txtBookQty_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            CalculateAmount();
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

        private void cmbSupID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                cmbSupID_Leave(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                cmbBCode_Leave(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbBCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBCode.SelectedValue != null)
            {
                DataRowView selectedRow = (DataRowView)cmbBCode.SelectedItem;
                string bookTilte = selectedRow["BookTitle"].ToString()!;
                txtBTitle.Text = bookTilte;
            }
            txtUnitPrice.Text = "";
            txtBookQty.Text = "";
            txtAmount.Text = "";
        }

        private void cmbBCode_Leave(object sender, EventArgs e)
        {
            bool isValidate = Helper.ValidateAndFetchData(cmbBCode, txtBTitle, "BookCode", "BookTitle");
            if (!isValidate)
            {
                FormBook book = new FormBook();
                book.ShowDialog();
                LoadBookCodeCmb();
                cmbBCode.SelectedIndex = (cmbBCode.Items.Count) - 1;
            }
        }

        private void cmbSupID_Leave(object sender, EventArgs e)
        {
            bool isValidate = Helper.ValidateAndFetchData(cmbSupID, txtSupName, "SupplierID", "SupplierName");
            if (!isValidate)
            {
                FormSupplier supplier = new FormSupplier();
                supplier.ShowDialog();
                LoadSupplierCmb();
                cmbSupID.SelectedIndex = (cmbSupID.Items.Count) - 1;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            int importID;
            if (!string.IsNullOrEmpty(txtSearch.Text))
            {
                if (int.TryParse(txtSearch.Text.Trim(), out importID))
                {
                    string query = "SELECT * FROM fnSearchImportByImportID(@ImportID)";
                    DataTable resultTable = Helper.SearchByID(query, "@ImportID", importID);
                    dgvImpDetail.DataSource = null;
                    dgvImpDetail.DataSource = resultTable;
                }
                else
                {
                    return;
                }
            }
            else
            {
                btnNew_Click(sender, e);
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                int importID;
                if (int.TryParse(txtSearch.Text.Trim(), out importID))
                {
                    string query = "SELECT * FROM fnSearchImportByImportID(@ImportID)";
                    DataTable resultTable = Helper.SearchByID(query, "@ImportID", importID);

                    if (resultTable != null && resultTable.Rows.Count > 0)
                    {
                        dgvImpDetail.DataSource = null;
                        dgvImpDetail.DataSource = resultTable;
                    }
                    else
                    {
                        MessageBox.Show($"No records found for the provided Import ID {importID}.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid integer value for Import ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnUpdateDetail_Click(object sender, EventArgs e)
        {
            try
            {
                ImportDetail impData = CreateImportDetail();

                if (impData != null)
                {
                    if (!int.TryParse(txtImpID.Text, out int impD) || impD <= 0)
                    {
                        MessageBox.Show("Please enter a valid Import ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtImpID.Focus();
                    }
                    impData.ImportID = impD;
                    bool isSuccess = ImportDetail.UpdateImportDetail(impData);
                    if (isSuccess)
                    {
                        MessageBox.Show("ImportDetail Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        string query = "SELECT * FROM fnSearchImportByImportID(@ImportID)";
                        DataTable resultTable = Helper.SearchByID(query, "@ImportID", impData.ImportID);
                        dgvImpDetail.DataSource = null;
                        dgvImpDetail.DataSource = resultTable;
                    }
                    else
                    {
                        MessageBox.Show("ImportDetail was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

    }
}


//public partial class FormImport : Form
//{
//    private Timer loginTimer = null!;
//    private bool selectionHandlerSubscribed = false;
//    List<ImportDetail> newImp = new List<ImportDetail>();
//    private BindingSource bindingSource = new BindingSource();
//    public FormImport()
//    {
//        InitializeComponent();
//        LoadSupplierCmb();
//        LoadStaffCmb();
//        LoadBookCodeCmb();
//        Helper.ClearControls(this);
//        DataGridView.CheckForIllegalCrossThreadCalls = false;
//        ConfigView();
//    }

//    private void FormImport_Load(object sender, EventArgs e)
//    {
//        LoadImportDetailDataGrid();
//        dgvImpDetail.ClearSelection();
//        cmbStaffID.Refresh();
//        cmbSupID.Refresh();
//        cmbBCode.Refresh();
//        Helper.AttachNavigationEvents(this);
//    }
//    private void LoadSupplierCmb()
//    {
//        string query = "SELECT * FROM vGetSuppliersName";
//        Helper.LoadCombobox(query, "SupplierID", "SupplierID", cmbSupID);
//    }
//    private void LoadStaffCmb()
//    {
//        string query = "SELECT * FROM vGetStaffIDNamePosition";
//        Helper.LoadCombobox(query, "StaffID", "StaffID", cmbStaffID);
//    }
//    private void LoadBookCodeCmb()
//    {
//        string query = "SELECT * FROM vGetBookTitle";
//        Helper.LoadCombobox(query, "BookCode", "BookCode", cmbBCode);
//    }
//    private void RetrieveImports(int impID, int bookCode)
//    {
//        Import imp = new Import();
//        ImportDetail impD = new ImportDetail();
//        Import.RetrieveImport(impID, imp);
//        ImportDetail.RetrieveImportDetail(impID, bookCode, impD);

//        txtImpID.Text = imp.ImportID.ToString();
//        DateTime importDate = imp.ImportDate;
//        if (importDate < dtpImpDate.MinDate || importDate > dtpImpDate.MaxDate)
//        {
//            importDate = DateTime.Today; // Set a default date if invalid
//        }
//        dtpImpDate.Value = importDate;
//        //dtpImpDate.Value = imp.ImportDate;
//        txtTotal.Text = imp.TotalAmount.ToString();
//        cmbSupID.Text = imp.SupplierID.ToString();
//        txtSupName.Text = imp.SupplierName;
//        cmbStaffID.Text = imp.StaffID.ToString();
//        txtStaffName.Text = imp.StaffName;
//        txtStaffPosition.Text = imp.StaffPosition;

//        txtBTitle.Text = impD.BookTitle;
//        txtBookQty.Text = impD.ImportQty.ToString();
//        txtUnitPrice.Text = impD.UnitPrice.ToString();
//        txtAmount.Text = impD.Amount.ToString();
//        cmbBCode.Text = impD.BookCode.ToString();
//    }
//    private void ConfigView()
//    {
//        dgvImpDetail.Columns.Clear();
//        dgvImpDetail.Columns.Add("ColImportID", "Import ID");
//        dgvImpDetail.Columns.Add("ColBCode", "Book Code");
//        dgvImpDetail.Columns.Add("ColBQty", "Book Quantity");
//        dgvImpDetail.Columns.Add("ColUnitPrice", "Unit Price");
//        dgvImpDetail.Columns.Add("ColAmount", "Amount");
//    }
//    private void LoadImportDetailDataGrid()
//    {
//        dgvImpDetail.Rows.Clear();
//        string query = "SELECT * FROM vGetAllImportDetails";
//        List<ImportDetail> impDetails = new List<ImportDetail>();
//        impDetails = ImportDetail.GetAllImportDetail(query);
//        foreach (ImportDetail impDetail in impDetails)
//        {
//            dgvImpDetail.Rows.Add(impDetail.ImportID, impDetail.BookCode, impDetail.ImportQty, impDetail.UnitPrice.ToString("F"), impDetail.Amount.ToString("F"));
//        }
//        dgvImpDetail.ClearSelection();
//    }
//    public bool TryParseImportInputs(out Import imp)
//    {
//        imp = new Import();
//        bool isValid = true;
//        if (cmbStaffID.SelectedItem != null)
//        {
//            imp.StaffID = (short)cmbStaffID.SelectedValue;
//        }
//        else
//        {
//            MessageBox.Show("Please Select StaffID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            isValid = false;
//            return false;
//        }
//        imp.StaffName = txtStaffName.Text;
//        imp.StaffPosition = txtStaffPosition.Text;

//        if (cmbSupID.SelectedItem != null)
//        {
//            imp.SupplierID = (byte)cmbSupID.SelectedValue;
//        }
//        else
//        {
//            MessageBox.Show("Please Select SupplierID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            isValid = false;
//            return false;
//        }
//        imp.SupplierName = txtSupName.Text;
//        imp.ImportDate = DateTime.Now;

//        return isValid;
//    }
//    public bool TryParseImportDetailInputs(out ImportDetail impD)
//    {
//        impD = new ImportDetail();
//        bool isValid = true;
//        int bookCode = 0;
//        if (cmbBCode.SelectedItem != null)
//        {
//            bookCode = (int)cmbBCode.SelectedValue;
//        }
//        else
//        {
//            isValid = false;
//            MessageBox.Show("Please Select Book Code", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
//            cmbBCode.Focus();
//        }
//        string bookTile = null!;
//        if (string.IsNullOrEmpty(txtBTitle.Text))
//        {
//            isValid = false;
//            MessageBox.Show("Invalid Book Title format.");
//            txtBTitle.Focus();
//        }
//        else
//        {
//            bookTile = txtBTitle.Text;
//        }

//        if (newImp.Any(detail => detail.BookCode == bookCode))
//        {
//            isValid = false;
//            MessageBox.Show("This Book Code already exists in the import details list.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
//        }
//        // Validate and parse ImportQty
//        byte importQty;
//        if (!byte.TryParse(txtBookQty.Text, out importQty))
//        {
//            isValid = false;
//            MessageBox.Show("Invalid Book Quantity format.");
//            txtBookQty.Focus();
//        }
//        // Validate and parse UnitPrice
//        decimal unitPrice;
//        if (!decimal.TryParse(txtUnitPrice.Text, out unitPrice))
//        {
//            isValid = false;
//            MessageBox.Show("Invalid Unit Price format.");
//        }
//        decimal amount = importQty * unitPrice;
//        //txtAmount.Text = amount.ToString("F");

//        impD.BookCode = bookCode;
//        impD.BookTitle = bookTile;
//        impD.ImportQty = importQty;
//        impD.UnitPrice = unitPrice;
//        impD.Amount = amount;
//        newImp.Add(impD);

//        return isValid;
//    }
//    private void btnInsertDetail_Click(object sender, EventArgs e)
//    {
//        if (Helper.ValidateComboBoxes(cmbBCode) && Helper.ValidateTextBoxes(txtUnitPrice, txtBookQty))
//        {
//            if (TryParseImportDetailInputs(out ImportDetail newImpDetail))
//            {
//                decimal totalAmount = newImp.Sum(detail => detail.Amount);
//                txtTotal.Text = totalAmount.ToString("F");
//                dgvImpDetail.Rows.Add(newImpDetail.ImportID, newImpDetail.BookCode, newImpDetail.ImportQty, newImpDetail.UnitPrice.ToString("F"), newImpDetail.Amount.ToString("F"));
//            }
//        }
//    }

//    private void btnInsert_Click(object sender, EventArgs e)
//    {
//        //if (Helper.ValidateComboBoxes(cmbSupID, cmbStaffID))
//        //{
//        if (TryParseImportInputs(out Import import))
//        {
//            try
//            {
//                int importID = Import.InsertImport(import);
//                bool isSuccess = ImportDetail.InsertImportDetail(importID, newImp);
//                if (isSuccess)
//                {
//                    newImp.Clear();
//                    bindingSource.ResetBindings(false);

//                    MessageBox.Show("Data inserted successfully.");
//                }
//                else
//                {
//                    MessageBox.Show("Fail to insert ");
//                }
//            }
//            catch (SqlException ex)
//            {
//                MessageBox.Show("An error occurred: " + ex.Message);
//            }
//            //newImp.Add(newImpDetail);

//            //dgvImpDetail.Rows.Add(newImpDetail.ImportID, newImpDetail.BookCode, newImpDetail.ImportQty, newImpDetail.UnitPrice, newImpDetail.Amount);
//            //bool isSuccess = ImportDetail.InsertImportDetail(newImpDetail);
//            //if (isSuccess)
//            //{
//            //    MessageBox.Show("Supplier inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
//            //    LoadImportDetailDataGrid();
//            //    Helper.ClearControls(this);
//            //}
//            //else
//            //{
//            //    MessageBox.Show("Supplier was not inserted...", "Error Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
//            //}
//        }
//        // }
//    }
//    private void btnUpdate_Click(object sender, EventArgs e)
//    {

//    }

//    private void btnNew_Click(object sender, EventArgs e)
//    {
//        new FormImport();
//        dgvImpDetail.ClearSelection();
//        Helper.ClearControls(this);
//    }

//    private void btnClose_Click(object sender, EventArgs e)
//    {
//        Close();
//    }

//    private void dgvImpDetail_CellClick(object sender, DataGridViewCellEventArgs e)
//    {
//        Helper.AttachNavigationEvents(dgvImpDetail);
//        if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
//        {
//            dgvImpDetail.SelectionChanged += dgvImpDetail_SelectionChanged!;
//            dgvImpDetail_SelectionChanged(sender, e);
//        }
//    }

//    private void dgvImpDetail_SelectionChanged(object sender, EventArgs e)
//    {
//        if (dgvImpDetail.CurrentRow != null)
//        {
//            DataGridViewRow selectedRow = dgvImpDetail.CurrentRow;

//            int supID = Convert.ToInt32(selectedRow.Cells["ColImportID"].Value);
//            int bookCode = Convert.ToInt32(selectedRow.Cells["ColBCode"].Value);
//            RetrieveImports(supID, bookCode);

//            if (!selectionHandlerSubscribed)
//            {
//                selectionHandlerSubscribed = true;
//            }
//        }
//    }

//    private void cmbSupID_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        if (cmbSupID.SelectedValue != null)
//        {
//            DataRowView selectedRow = (DataRowView)cmbSupID.SelectedItem;
//            string supName = selectedRow["SupplierName"].ToString()!;
//            txtSupName.Text = supName;
//        }
//    }

//    private void cmbStaffID_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        if (cmbStaffID.SelectedValue != null)
//        {
//            DataRowView selectedRow = (DataRowView)cmbStaffID.SelectedItem;
//            string staffName = selectedRow["StaffName"].ToString()!;
//            string staffPosition = selectedRow["StaffPosition"].ToString()!;
//            txtStaffName.Text = staffName;
//            txtStaffPosition.Text = staffPosition;
//        }
//    }

//    private void CalculateAmount()
//    {
//        if (int.TryParse(txtBookQty.Text, out int bookQty) && decimal.TryParse(txtUnitPrice.Text, out decimal unitPrice))
//        {
//            decimal amount = bookQty * unitPrice;
//            txtAmount.Text = amount.ToString("0.00");
//        }
//        else
//        {
//            txtAmount.Clear();
//        }
//    }
//    private void txtBookQty_TextChanged(object sender, EventArgs e)
//    {
//        CalculateAmount();
//    }

//    private void txtUnitPrice_TextChanged(object sender, EventArgs e)
//    {
//        CalculateAmount();
//    }

//    private void LoginTimer_Tick(object sender, EventArgs e)
//    {
//        loginTimer.Stop();
//        Helper.PerformLogin();
//    }
//    private void btnLogout_Click(object sender, EventArgs e)
//    {
//        DialogResult result = MessageBox.Show("Do You Want to Logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

//        if (result == DialogResult.Yes)
//        {
//            Close();
//            loginTimer = new Timer();
//            loginTimer.Interval = 200;
//            loginTimer.Start();
//            loginTimer.Tick += LoginTimer_Tick!;
//        }
//        else
//        {
//            return;
//        }
//    }

//    private void cmbSupID_KeyDown(object sender, KeyEventArgs e)
//    {
//        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
//        {
//            cmbSupID_Leave(sender, e);
//            e.Handled = true;
//            e.SuppressKeyPress = true;
//        }
//    }

//    private void cmbBCode_KeyDown(object sender, KeyEventArgs e)
//    {
//        if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
//        {
//            cmbBCode_Leave(sender, e);
//            e.Handled = true;
//            e.SuppressKeyPress = true;
//        }
//    }

//    private void cmbBCode_SelectedIndexChanged(object sender, EventArgs e)
//    {
//        if (cmbBCode.SelectedValue != null)
//        {
//            DataRowView selectedRow = (DataRowView)cmbBCode.SelectedItem;
//            string bookTilte = selectedRow["BookTitle"].ToString()!;
//            txtBTitle.Text = bookTilte;
//        }
//        txtUnitPrice.Text = "";
//        txtBookQty.Text = "";
//        txtAmount.Text = "";
//    }

//    private void cmbBCode_Leave(object sender, EventArgs e)
//    {
//        bool isValidate = Helper.ValidateAndFetchData(cmbBCode, txtBTitle, "BookCode", "BookTitle");
//        if (!isValidate)
//        {
//            FormBook book = new FormBook();
//            book.ShowDialog();
//            LoadBookCodeCmb();
//            cmbBCode.SelectedIndex = (cmbBCode.Items.Count) - 1;
//        }
//    }

//    private void cmbSupID_Leave(object sender, EventArgs e)
//    {
//        bool isValidate = Helper.ValidateAndFetchData(cmbSupID, txtSupName, "SupplierID", "SupplierName");
//        if (!isValidate)
//        {
//            FormSupplier supplier = new FormSupplier();
//            supplier.ShowDialog();
//            LoadSupplierCmb();
//            cmbSupID.SelectedIndex = (cmbSupID.Items.Count) - 1;
//        }
//    }
//}