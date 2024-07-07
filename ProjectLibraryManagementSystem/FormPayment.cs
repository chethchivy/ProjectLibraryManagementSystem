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
    public partial class FormPayment : Form
    {
        private Timer loginTimer = null!;
        public FormPayment(int returnID, int memberID, short staffID, decimal paidAmount)
        {
            InitializeComponent();
            txtReturnID.Text = returnID.ToString();
            cmbMemberID.Text = memberID.ToString();
            cmbStaffID.Text = staffID.ToString();
            txtPaidAmount.Text = paidAmount.ToString();
            cmbMemberID.SelectedIndex = -1;
            cmbStaffID.SelectedIndex = -1;

            LoadMemberCmb();
            LoadStaffCmb();
            cmbMemberID.SelectedValue = memberID;
            cmbStaffID.SelectedValue = staffID;
            Helper.AttachNavigationEvents(this);
        }
        public FormPayment()
        {
            InitializeComponent();
            LoadMemberCmb();
            LoadStaffCmb();
            Helper.ClearControls(this);
            Helper.AttachNavigationEvents(this);
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

        private void FormPayment_Load(object sender, EventArgs e)
        {
            cmbMemberID.Refresh();
            cmbStaffID.Refresh();
        }
        private Payment CreatePayment()
        {
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

            return new Payment
            {
                payDate = DateTime.Now,
                paidAmount = paidAmount,
                returnID = returnID,
                memberID = memberID,
                staffID = staffID
            };
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


        private void DisplayPaymentDetails(int paymentNo)
        {
            string query = "SELECT * FROM fnSearchPayment(@PaymentNo)";
            DataTable paymentDetails = Helper.SearchByID(query, "@PaymentNo", paymentNo);

            if (paymentDetails.Rows.Count > 0)
            {
                DataRow row = paymentDetails.Rows[0]; // Assuming there is only one row

                txtPaymentNo.Text = row["PaymentNo"].ToString();
                dtpPaidDate.Text = ((DateTime)row["PaymentDate"]).ToString("yyyy-MM-dd"); // Example date format
                txtPaidAmount.Text = ((decimal)row["PaidAmount"]).ToString("F2");
                cmbMemberID.Text = row["MemberID"].ToString();
                txtReturnID.Text = row["ReturnID"].ToString();
                cmbStaffID.Text = row["StaffID"].ToString();
                txtStaffPosition.Text = row["StaffPosition"].ToString();
                txtStaffName.Text = row["StaffName"].ToString();
            }
            else
            {
                MessageBox.Show("No Payment details found for PaymentNo: " + paymentNo, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Helper.ClearControls(this);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int search;
            if (!string.IsNullOrEmpty(txtPaymentNo.Text))
            {
                if (!int.TryParse(txtPaymentNo.Text, out search))
                {
                    MessageBox.Show("Invalide PaymentNo ........", "Search Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPaymentNo.Focus();
                    return;
                }
                else
                {
                    DisplayPaymentDetails(search);
                }
            }
            else
            {
                MessageBox.Show("Please Enter PaymentNo to search ........", "Search Payment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPaymentNo.Focus();
                return;
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                Payment pay = CreatePayment();
                if (pay != null)
                {
                    int payID = Payment.InsertPayment(pay);

                    if (payID > 0)
                    {
                        MessageBox.Show($"Insert PaymentNo : {payID} Successfully...", "Insert Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Payment payData = CreatePayment();

                if (payData != null)
                {
                    if (!int.TryParse(txtPaymentNo.Text, out int payNo) || payNo <= 0)
                    {
                        MessageBox.Show("Please enter a valid Payment ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPaymentNo.Focus();
                    }
                    payData.paymentNo = payNo;
                    Payment.UpdatePaymentByNo(payData);
                    MessageBox.Show($"Payment record updated with ID: {payNo}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void cmbMemberID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.PageDown)
            {
                DataTable resultTable = new DataTable();
                bool isValidate = Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void cmbMemberID_Leave(object sender, EventArgs e)
        {
            DataTable resultTable;
            bool isValidate = Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
        }

        private void txtPaymentNo_KeyDown(object sender, KeyEventArgs e)
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
