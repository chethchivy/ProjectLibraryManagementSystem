using ProjectLibraryManagementSystem.Model;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormRenew : Form
    {
        private Timer loginTimer = null!;
        public FormRenew()
        {
            InitializeComponent();
            Helper.AttachNavigationEvents(this);
        }

        private void FormRenew_Load(object sender, EventArgs e)
        {
            LoadMemberCmb();
            LoadStaffCmb();
            cmbStaffID.Refresh();
            Helper.ClearControls(this);
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
        private Renew GetRenewDataFromForm()
        {
            DateTime renewDate;
            DateTime newDueDate;
            int memberID;
            int bookCode;
            int borrowID;
            short staffID;

            // Validate RenewDate
            if (!DateTime.TryParse(dtpRenewDate.Text, out renewDate))
            {
                MessageBox.Show("Please enter a valid Renew Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpRenewDate.Focus();
                return null!;
            }

            // Validate NewDueDate
            if (!DateTime.TryParse(dtpNewDueDate.Text, out newDueDate) || newDueDate <= renewDate)
            {
                MessageBox.Show("Please enter a valid New Due Date that is after the Renew Date.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNewDueDate.Focus();
                return null!;
            }

            // Validate MemberID
            if (!int.TryParse(cmbMemberID.Text, out memberID) || memberID <= 0)
            {
                MessageBox.Show("Please enter a valid Member ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbMemberID.Focus();
                return null!;
            }
            if (!int.TryParse(cmbBorrowID.Text, out borrowID) || borrowID <= 0)
            {
                MessageBox.Show("Please enter a valid Borrow ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBorrowID.Focus();
                return null!;
            }

            // Validate BookCode
            if (!int.TryParse(cmbBookCode.Text, out bookCode) || bookCode <= 0)
            {
                MessageBox.Show("Please enter a valid Book Code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBookCode.Focus();
                return null!;
            }

            // Validate StaffID
            if (!short.TryParse(cmbStaffID.Text, out staffID) || staffID <= 0)
            {
                MessageBox.Show("Please enter a valid Staff ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbStaffID.Focus();
                return null!;
            }

            // Create and return a new Renew instance
            return new Renew
            {
                renewDate = renewDate,
                newDueDate = newDueDate,
                memberID = memberID,
                BorrowID = borrowID,
                bookCode = bookCode,
                staffID = staffID
            };
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                // Extract data from form controls and create a Renew object
                Renew renewData = GetRenewDataFromForm();
                if (renewData != null)
                {
                    // Insert the Renew data into the database and get the generated RenewID
                    int renewID = Renew.InsertRenew(renewData);

                    if (renewID > 0)
                    {
                        int borrowID = renewData.BorrowID; // Ensure you have this information
                        int bookCode = renewData.bookCode;
                        DateTime newDueDate = renewData.newDueDate;// Ensure you have this information
                        MessageBox.Show("Insert Renew Successfully...", "Insert Renew", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.UpdateDueDate(borrowID, bookCode, newDueDate);
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
                Renew renewData = GetRenewDataFromForm();

                if (renewData != null)
                {
                    if (!int.TryParse(txtRenewID.Text, out int renewID) || renewID <= 0)
                    {
                        MessageBox.Show("Please enter a valid Renew ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtRenewID.Focus();
                    }
                    renewData.renewID = renewID;
                    Renew.UpdateRenewByID(renewData);
                    MessageBox.Show($"Renew record updated with ID: {renewID}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            cmbBookCode.Text = "";
            Helper.ClearControls(this);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
                int selectedMemberID = (int)cmbMemberID.SelectedValue;
                DataRowView selectedRow = (DataRowView)cmbMemberID.SelectedItem;
                string memberName = selectedRow["MemberName"].ToString()!;
                txtMemberName.Text = memberName;
                cmbBorrowID.Text = "";
                string query = "SELECT BorrowID FROM fnGetBorrowByMemberID(@MemberID)";
                DataTable resultTable = Helper.SearchByID(query, "@MemberID", selectedMemberID);
                Helper.ShowInCombobox(resultTable, cmbBorrowID, "BorrowID");
            }
        }
        private void cmbBorrowID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBorrowID.SelectedValue != null)
            {
                int selectedBorrowID = (int)cmbBorrowID.SelectedValue;
                cmbBookCode.Text = "";
                string query = "SELECT BookCode FROM fnGetBookByBorrowID(@BorrowID)";
                DataTable resultTable = Helper.SearchByID(query, "@BorrowID", selectedBorrowID);
                Helper.ShowInCombobox(resultTable, cmbBookCode, "BookCode");
            }
        }

        private void DisplayRenewDetails(int renewID)
        {
            string query = "SELECT * FROM fnGetRenewByID(@RenewID)";
            DataTable renewDetails = Helper.SearchByID(query, "@RenewID", renewID);

            if (renewDetails.Rows.Count > 0)
            {
                DataRow row = renewDetails.Rows[0]; // Assuming there is only one row

                // Populate TextBoxes
                txtRenewID.Text = row["RenewID"].ToString();
                dtpRenewDate.Text = ((DateTime)row["RenewDate"]).ToString("yyyy-MM-dd"); // Example date format
                dtpNewDueDate.Text = ((DateTime)row["NewDueDate"]).ToString("yyyy-MM-dd"); // Example date format
                cmbMemberID.Text = row["MemberID"].ToString();
                cmbBorrowID.Text = row["BorrowID"].ToString();
                cmbBookCode.Text = row["BookCode"].ToString();
                cmbStaffID.Text = row["StaffID"].ToString();
                txtStaffPosition.Text = row["StaffPosition"].ToString();
                txtMemberName.Text = row["MemberName"].ToString();
                txtStaffName.Text = row["StaffName"].ToString();
            }
            else
            {
                // Display a message if no records are found
                MessageBox.Show("No renew details found for RenewID: " + renewID, "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear all controls if no data found
                Helper.ClearControls(this);
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnInsert.Enabled = false;
            if (int.TryParse(txtRenewID.Text, out int renewID))
            {
                DisplayRenewDetails(renewID);
            }
            else
            {
                MessageBox.Show("Please enter a valid RenewID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbBookCode.Text = "";
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
            DataTable resultTable;
            bool isValidate = Helper.ValidateAndFetchMemberData(cmbMemberID, txtMemberName, out resultTable);
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
    }
}
