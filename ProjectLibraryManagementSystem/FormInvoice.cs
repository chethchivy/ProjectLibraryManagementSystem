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
    public partial class FormInvoice : Form
    {
        private Timer loginTimer = null!;
        public FormInvoice(int memberID, int staffID, int returnID, decimal totalFineAmount)
        {
            InitializeComponent();
            txtReturnID.Text = returnID.ToString();
            cmbMemberID.Text = memberID.ToString();
            cmbStaffID.Text = staffID.ToString();
            txtTotalAmount.Text = totalFineAmount.ToString();
            cmbMemberID.SelectedIndex = -1;
            cmbStaffID.SelectedIndex = -1;

            LoadMemberCmb();
            LoadStaffCmb();
            cmbMemberID.SelectedValue = memberID;
            cmbStaffID.SelectedValue = staffID;

            Helper.AttachNavigationEvents(this);
        }
        public FormInvoice()
        {
            InitializeComponent();
            LoadMemberCmb();
            LoadStaffCmb();
            Helper.ClearControls(this);
            Helper.AttachNavigationEvents(this);
        }

        private void FormInvoice_Load(object sender, EventArgs e)
        {
            cmbMemberID.Refresh();
            cmbStaffID.Refresh();
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

        private void cmbMemberID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMemberID.SelectedValue != null)
            {
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

        private void cmbMemberID_Leave(object sender, EventArgs e)
        {
            DataTable resultTable = new DataTable();
            Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
        }

        private void cmbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                DataTable resultTable = new DataTable();
                Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private Invoice CreateInvoice()
        {
            DateTime invoiceDate = dtpInvoiceDate.Value;

            int memberID;
            if (cmbMemberID.SelectedValue == null || cmbMemberID.SelectedValue == DBNull.Value || !int.TryParse(cmbMemberID.Text.ToString(), out memberID))
            {
                MessageBox.Show("Invalid Member ID.");
                cmbMemberID.Focus();
                return null!;
            }

            short staffID;
            if (cmbStaffID.SelectedValue == null || cmbStaffID.SelectedValue == DBNull.Value || !short.TryParse(cmbStaffID.Text, out staffID))
            {
                MessageBox.Show("Invalid Staff ID.");
                cmbStaffID.Focus();
                return null!;
            }

            decimal totalAmount = 0;
            if (!decimal.TryParse(txtTotalAmount.Text, out totalAmount))
            {
                MessageBox.Show("Invalid Total amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTotalAmount.Focus();
                return null!;
            }

            decimal paidAmount = 0;
            if (!decimal.TryParse(txtPaidAmount.Text, out paidAmount))
            {
                MessageBox.Show("Invalid paid amount. Please enter a valid numeric value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaidAmount.Focus();
                return null!;
            }

            int returnID;
            if (!int.TryParse(txtReturnID.Text, out returnID))
            {
                MessageBox.Show("Invalid Return ID.");
                txtReturnID.Focus();
                return null!;
            }

            return new Invoice
            {
                invoiceDate = invoiceDate,
                totalAmount = totalAmount,
                paidAmount = paidAmount,
                returnID = returnID,
                memberID = memberID,
                staffID = staffID
            };
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoiceData = CreateInvoice();
                if (invoiceData != null)
                {
                    int invoiceID = Invoice.InsertInvoice(invoiceData);

                    if (invoiceID > 0)
                    {
                        MessageBox.Show($"Insert InvoiceNo : {invoiceID} Successfully...", "Insert Invoice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FormPayment formPayment = new FormPayment(invoiceData.returnID, invoiceData.memberID, invoiceData.staffID, invoiceData.paidAmount);
                        formPayment.ShowDialog();
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
            Helper.ClearControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Invoice invoiceData = CreateInvoice();

                if (invoiceData != null)
                {
                    if (!int.TryParse(txtInvoiceNo.Text, out int invoiceNo) || invoiceNo <= 0)
                    {
                        MessageBox.Show("Please enter a valid Payment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtInvoiceNo.Focus();
                    }
                    invoiceData.invoiceNo = invoiceNo;
                    Invoice.UpdateInvoiceByNo(invoiceData);
                    MessageBox.Show($"Invoice record updated with ID: {invoiceNo}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void DisplayInvoiceDetails(int invoiceNo)
        {
            string query = "SELECT * FROM fnSearchInvoice(@InvoiceNo)";
            DataTable invoiceDetails = Helper.SearchByID(query, "@InvoiceNo", invoiceNo);

            if (invoiceDetails.Rows.Count > 0)
            {
                DataRow row = invoiceDetails.Rows[0]; // Assuming there is only one row

                txtInvoiceNo.Text = row["InvoiceNo"].ToString();
                dtpInvoiceDate.Text = ((DateTime)row["InvoiceDate"]).ToString("yyyy-MM-dd"); // Example date format
                txtTotalAmount.Text = ((decimal)row["TotalAmount"]).ToString("F2");
                txtPaidAmount.Text = ((decimal)row["PaidAmount"]).ToString("F2");
                cmbMemberID.Text = row["MemberID"].ToString();
                txtReturnID.Text = row["ReturnID"].ToString();
                cmbStaffID.Text = row["StaffID"].ToString();
                txtStaffPosition.Text = row["StaffPosition"].ToString();
                txtStaffName.Text = row["StaffName"].ToString();
            }
            else
            {
                MessageBox.Show("No Invoice details found for InvoiceNo: " + invoiceNo, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper.ClearControls(this);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int search;
            if (!string.IsNullOrEmpty(txtInvoiceNo.Text))
            {
                if (!int.TryParse(txtInvoiceNo.Text, out search))
                {
                    MessageBox.Show("Invalide InvoiceNo ........", "Search Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtInvoiceNo.Focus();
                    return;
                }
                else
                {
                    DisplayInvoiceDetails(search);
                }
            }
            else
            {
                MessageBox.Show("Please Enter InvoiceNo to search ........", "Search Invoice", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInvoiceNo.Focus();
                return;
            }
        }

        private void txtInvoiceNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                btnSearch_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
