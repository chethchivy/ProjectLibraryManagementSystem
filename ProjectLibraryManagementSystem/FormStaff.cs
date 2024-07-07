using ProjectLibraryManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormStaff : Form
    {
        private Timer loginTimer = null!;
        public FormStaff()
        {
            InitializeComponent();
            Helper.LoadProvinceComboBox(cmbStaffProvince);
            cmbStaffProvince.SelectedIndexChanged += cmbProvince_SelectedIndexChanged!;
            cmbStaffKhann.SelectedIndexChanged += cmbKhann_SelectedIndexChanged!;
        }
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }
        private void FormStaff_Load(object sender, EventArgs e)
        {
            // LoadStaffName();
            Helper.AttachNavigationEvents(this);
            Helper.ClearControls(this);
            string query = "SELECT * FROM vGetStaffIDNamePosition";
            Helper.LoadListBoxData(ltbStaffDisplay, query, "StaffName");
        }
        private void cmbProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbStaffKhann.Items.Clear();
            if (cmbStaffProvince.SelectedItem != null)
            {
                int selectedProvinceID = ((ComboBoxItem)cmbStaffProvince.SelectedItem).ID;
                Helper.LoadDistrictComboBox(selectedProvinceID, cmbStaffKhann);
            }
            cmbStaffKhann.Text = "";
            cmbSangkat.Text = "";
        }

        private void cmbKhann_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSangkat.Items.Clear();
            if (cmbStaffKhann.SelectedItem != null)
            {
                int selectedKhannID = ((ComboBoxItem)cmbStaffKhann.SelectedItem).ID;
                Helper.LoadCommuneComboBox(selectedKhannID, cmbSangkat);
            }
            cmbSangkat.Text = "";
        }
        private Staff CreateStaff()
        {
            try
            {
                Helper.ValidateTextBoxes(txtFirstName, txtLastName, txtStaffPosition, txtPersonalTel);

                // Determine sex
                string sex = rdbFemale.Checked ? rdbFemale.Text : rdbMale.Text;

                // Validate and parse Birthdate
                if (!DateTime.TryParse(dtpBirthdate.Value.ToString(), out DateTime birthDate))
                {
                    MessageBox.Show("Invalid BirthDate. Please enter a valid date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpBirthdate.Focus();
                    return null;
                }

                if (birthDate >= DateTime.Now)
                {
                    MessageBox.Show("BirthDate cannot be in the future.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpBirthdate.Focus();
                    return null;
                }

                // Validate and parse HiredDate
                if (!DateTime.TryParse(dtpHiredDate.Value.ToString(), out DateTime hiredDate) || hiredDate > DateTime.Now)
                {
                    MessageBox.Show("Invalid HiredDate. Please enter a valid date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    dtpHiredDate.Focus();
                    return null;
                }

                // Validate Salary
                if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
                {
                    MessageBox.Show("Invalid Salary. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSalary.Focus();
                    return null;
                }

                // Validate ComboBoxes
                if (cmbSangkat.SelectedItem == null || cmbStaffKhann.SelectedItem == null || cmbStaffProvince.SelectedItem == null)
                {
                    MessageBox.Show("Please select values for Sangkat, Khann, and Province.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                // Determine stopWork
                bool stopWork = checkStopWork.Checked;

                // Create and return the Staff object
                return new Staff
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Sex = sex,
                    BirthDate = birthDate,
                    StaffPosition = txtStaffPosition.Text,
                    HouseNo = txtHouseNo.Text ?? "", // Set to empty string if null
                    StreetNo = txtStreetNo.Text ?? "", // Set to empty string if null
                    Sangkat = cmbSangkat.SelectedItem.ToString(),
                    Khann = cmbStaffKhann.SelectedItem.ToString(),
                    Province = cmbStaffProvince.SelectedItem.ToString(),
                    ContactNumber = txtContactTel.Text,
                    PersonalNumber = txtPersonalTel.Text,
                    Salary = salary,
                    HiredDate = hiredDate,
                    Photo = ptbPhoto.Image ?? null, // Use a default image if ptbPhoto.Image is null
                    StopWork = stopWork
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            //try
            //{
            //    Helper.ValidateTextBoxes(txtFirstName, txtLastName, txtStaffPosition, txtPersonalTel);

            //    // Determine sex
            //    string sex = rdbFemale.Checked ? rdbFemale.Text : rdbMale.Text;
            //    if (DateTime.TryParse(dtpBirthdate.Value.ToString(), out DateTime birthDate) && birthDate < DateTime.Now)
            //    {
            //    }
            //    else
            //    {
            //        dtpBirthdate.Focus();
            //        MessageBox.Show("Invalid BirthDate. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }

            //    // Validate and parse Birthdate
            //    //if (!DateTime.TryParse(dtpBirthdate.Value.ToString(), out DateTime birthDate) || birthDate >= DateTime.Now)
            //    //{
            //    //    MessageBox.Show("Invalid BirthDate. Please enter a valid date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    //    dtpBirthdate.Focus();
            //    //    return null;
            //    //}

            //    // Validate and parse HiredDate
            //    if (!DateTime.TryParse(dtpHiredDate.Value.ToString(), out DateTime hiredDate) || hiredDate > DateTime.Now)
            //    {
            //        MessageBox.Show("Invalid HiredDate. Please enter a valid date.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        dtpHiredDate.Focus();
            //        return null;
            //    }

            //    // Validate Salary
            //    if (!decimal.TryParse(txtSalary.Text, out decimal salary) || salary <= 0)
            //    {
            //        MessageBox.Show("Invalid Salary. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtSalary.Focus();
            //        return null;
            //    }

            //    // Validate ComboBoxes
            //    if (cmbSangkat.SelectedItem == null)
            //    {
            //        MessageBox.Show("Invalid SangKat. Please select a valid value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        cmbSangkat.Focus();
            //        return null;
            //    }

            //    if (cmbStaffKhann.SelectedItem == null)
            //    {
            //        MessageBox.Show("Invalid Khann. Please select a valid value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        cmbStaffKhann.Focus();
            //        return null;
            //    }

            //    if (cmbStaffProvince.SelectedItem == null)
            //    {
            //        MessageBox.Show("Invalid Province. Please select a valid value.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        cmbStaffProvince.Focus();
            //        return null;
            //    }

            //    // Determine stopWork
            //    bool stopWork = checkStopWork.Checked;

            //    // Create and return the Staff object
            //    return new Staff
            //    {
            //        FirstName = txtFirstName.Text,
            //        LastName = txtLastName.Text,
            //        Sex = sex,
            //        BirthDate = birthDate,
            //        StaffPosition = txtStaffPosition.Text,
            //        HouseNo = txtHouseNo.Text,
            //        StreetNo = txtStreetNo.Text,
            //        Sangkat = cmbSangkat.SelectedItem.ToString(),
            //        Khann = cmbStaffKhann.SelectedItem.ToString(),
            //        Province = cmbStaffProvince.SelectedItem.ToString(),
            //        ContactNumber = txtContactTel.Text,
            //        PersonalNumber = txtPersonalTel.Text,
            //        Salary = salary,
            //        HiredDate = hiredDate,
            //        Photo = ptbPhoto.Image, // Assuming Staff class can handle Image object
            //        StopWork = stopWork
            //    };
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return null;
            //}
        }

        // Display staff details in control boxes
        private void DisplayStaffDetail(DataRow staffRow)
        {
            if (staffRow != null)
            {
                txtStaffID.Text = staffRow["StaffID"]?.ToString() ?? "";
                txtFirstName.Text = staffRow["FirstName"]?.ToString() ?? "";
                txtLastName.Text = staffRow["LastName"]?.ToString() ?? "";
                string sex = staffRow["Sex"]?.ToString() ?? "";
                if (sex == "ប្រុស")
                {
                    rdbMale.Checked = true;
                }
                else if (sex == "ស្រី")
                {
                    rdbFemale.Checked = true;
                }
                else
                {
                    rdbMale.Checked = false;
                    rdbFemale.Checked = false;
                }
                txtStaffPosition.Text = staffRow["StaffPosition"]?.ToString() ?? "";
                dtpBirthdate.Value = staffRow["BirthDate"] != DBNull.Value ? Convert.ToDateTime(staffRow["BirthDate"]) : DateTime.Now;
                txtHouseNo.Text = staffRow["HouseNo"]?.ToString() ?? "";
                txtStreetNo.Text = staffRow["StreetNo"]?.ToString() ?? "";
                cmbSangkat.Text = staffRow["Sangkat"]?.ToString() ?? "";
                cmbStaffKhann.Text = staffRow["Khann"]?.ToString() ?? "";
                cmbStaffProvince.Text = staffRow["Province"]?.ToString() ?? "";
                txtContactTel.Text = staffRow["ContactNumber"]?.ToString() ?? "";
                txtPersonalTel.Text = staffRow["PersonalNumber"]?.ToString() ?? "";
                txtSalary.Text = staffRow["Salary"]?.ToString() ?? "";
                dtpHiredDate.Value = staffRow["HireDate"] != DBNull.Value ? Convert.ToDateTime(staffRow["HireDate"]) : DateTime.Now;

                if (staffRow["Photo"] != DBNull.Value)
                {
                    byte[] photoArray = (byte[])staffRow["Photo"];
                    ptbPhoto.Image = ByteArrayToImage(photoArray); // Assuming picStaffPhoto is a PictureBox control
                }
                else
                {
                    ptbPhoto.Image = null; // No photo available
                }

                checkStopWork.Checked = staffRow["StopWork"] != DBNull.Value && (bool)staffRow["StopWork"];
            }
            else
            {
                Helper.ClearControls(this);
            }
        }

        private DataTable ConvertToDataTable(Staff staff)
        {
            if (staff == null)
            {
                throw new ArgumentNullException(nameof(staff), "The book object is null.");
            }
            DataTable dataTable = new DataTable();

            // Add columns to the DataTable
            dataTable.Columns.Add("StaffID", typeof(short));
            dataTable.Columns.Add("FirstName", typeof(string));
            dataTable.Columns.Add("LastName", typeof(string));
            dataTable.Columns.Add("Sex", typeof(string));
            dataTable.Columns.Add("StaffPosition", typeof(string));
            dataTable.Columns.Add("BirthDate", typeof(DateTime));
            dataTable.Columns.Add("HouseNo", typeof(string));
            dataTable.Columns.Add("StreetNo", typeof(string));
            dataTable.Columns.Add("Sangkat", typeof(string));
            dataTable.Columns.Add("Khann", typeof(string));
            dataTable.Columns.Add("Province", typeof(string));
            dataTable.Columns.Add("ContactNumber", typeof(string));
            dataTable.Columns.Add("PersonalNumber", typeof(string));
            dataTable.Columns.Add("Salary", typeof(decimal));
            dataTable.Columns.Add("HireDate", typeof(DateTime));
            dataTable.Columns.Add("Photo", typeof(byte[])); // Assuming photo is converted to byte[]
            dataTable.Columns.Add("StopWork", typeof(bool));

            // Add a row with the data
            DataRow row = dataTable.NewRow();
            //row["StaffID"] = staff.StaffID;
            row["FirstName"] = staff.StaffName;
            row["LastName"] = staff.LastName;
            row["Sex"] = staff.Sex;
            row["StaffPosition"] = staff.StaffPosition;
            row["BirthDate"] = staff.BirthDate;
            row["HouseNo"] = staff.HouseNo;
            row["StreetNo"] = staff.StreetNo;
            row["Sangkat"] = staff.Sangkat;
            row["Khann"] = staff.Khann;
            row["Province"] = staff.Province;
            row["ContactNumber"] = staff.ContactNumber;
            row["PersonalNumber"] = staff.PersonalNumber;
            row["Salary"] = staff.Salary;
            row["HireDate"] = staff.HiredDate;
            row["Photo"] = staff.Photo != null ? ImageToByteArray(staff.Photo) : null; // Convert image to byte array
            row["StopWork"] = staff.StopWork;
            dataTable.Rows.Add(row);

            return dataTable;
        }
        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
        private void LoadStaffName()
        {
            string query = "SELECT * FROM vGetStaffIDNamePosition"; // Adjust the query as needed
            DataTable dt = Helper.ReadData(query);

            ltbStaffDisplay.DisplayMember = "StaffName"; // Assuming "BookTitle" is the name of the column
            ltbStaffDisplay.ValueMember = "StaffID"; // Assuming "BookID" is the primary key column
            ltbStaffDisplay.DataSource = dt;
            ltbStaffDisplay.ClearSelected();

            btnInsert.Enabled = true;
        }
        public bool TryParseStaffInputs(out Staff staff)
        {
            staff = new Staff();
            bool isValid = true;
            staff.FirstName = txtFirstName.Text;
            staff.LastName = txtLastName.Text;
            if (rdbFemale.Checked)
            {
                staff.Sex = rdbFemale.Text;
            }
            else
            {
                staff.Sex = rdbMale.Text;
            }
            if (DateTime.TryParse(dtpBirthdate.Value.ToString(), out DateTime birthDate) && birthDate < DateTime.Now)
            {
                staff.BirthDate = birthDate;
            }
            else
            {
                MessageBox.Show("Invalid BirthDate. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            staff.StaffPosition = txtStaffPosition.Text;
            staff.HouseNo = txtHouseNo.Text;
            staff.StreetNo = txtStreetNo.Text;
            if (cmbSangkat.SelectedItem != null)
            {
                staff.Sangkat = cmbSangkat.Text;
            }
            else
            {
                MessageBox.Show("Invalid SangKat. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbStaffKhann.SelectedItem != null)
            {
                staff.Khann = cmbStaffKhann.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Khann. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (cmbStaffProvince.SelectedItem != null)
            {
                staff.Province = cmbStaffProvince.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Invalid Province. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (DateTime.TryParse(dtpHiredDate.Value.ToString(), out DateTime hiredDate) && hiredDate < DateTime.Now)
            {
                staff.HiredDate = hiredDate;
            }
            else
            {
                MessageBox.Show("Invalid BirthDate. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (decimal.TryParse((txtSalary.Text), out decimal salary) && salary > 0)
            {
                staff.Salary = salary;
            }
            else
            {
                MessageBox.Show("Invalid Salary. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (staff.Photo != null)
            {
                staff.Photo = ptbPhoto.Image;
            }

            staff.PersonalNumber = txtPersonalTel.Text;
            staff.ContactNumber = txtContactTel.Text;
            if (checkStopWork.Checked)
            {
                staff.StopWork = true;
            }
            else
            {
                staff.StopWork = false;
            }

            return isValid;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM vGetStaffIDNamePosition";
                if (Helper.ValidateTextBoxes(txtFirstName, txtLastName, txtStaffPosition, txtPersonalTel, txtSalary))
                {
                    if (TryParseStaffInputs(out Staff newStaff))
                    {
                        MessageBox.Show(newStaff.Khann);
                        MessageBox.Show(newStaff.Sangkat);
                        bool isSuccess = Staff.InsertStaff(newStaff, ptbPhoto);
                        if (isSuccess)
                        {
                            MessageBox.Show("Staff inserted successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Helper.LoadListBoxData(ltbStaffDisplay, query, "StaffName");
                            Helper.ClearControls(this);
                            ptbPhoto.Image = null;
                        }
                        else
                        {
                            MessageBox.Show("Staff Already exited, Insert Staff Fail...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            bool isSuccess = false;
            string query = "SELECT * FROM vGetStaffIDNamePosition";
            if (Helper.ValidateTextBoxes(txtFirstName, txtLastName, txtStaffPosition, txtPersonalTel, txtSalary))
            {
                if (TryParseStaffInputs(out Staff newStaff))
                {
                    if (short.TryParse(txtStaffID.Text, out short staffID))
                    {
                        newStaff.StaffID = staffID;
                        isSuccess = Staff.UpdateStaffByID(newStaff, ptbPhoto);
                    }
                    else
                    {
                        MessageBox.Show("Invalid Staff ID. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    if (isSuccess)
                    {
                        MessageBox.Show("Staff Update successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.LoadListBoxData(ltbStaffDisplay, query, "StaffName");
                        Helper.ClearControls(this);
                        ptbPhoto.Image = null;
                    }
                    else
                    {
                        MessageBox.Show("Staff was not Updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            ltbStaffDisplay.ClearSelected();
            ptbPhoto.Image = null;
            btnInsert.Enabled = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void RetrieveStaffDetails(string? staffName)
        {
            Staff staff = new Staff();
            Staff.RetrieveStaffDetails(staffName, staff);

            txtStaffID.Text = staff.StaffID.ToString();
            txtFirstName.Text = staff.FirstName;
            txtLastName.Text = staff.LastName;
            if (staff.Sex != null && (staff.Sex.ToString().Trim() == "F" || staff.Sex.ToString().Trim() == "ស្រី"))
            { rdbFemale.Checked = true; }
            else { rdbMale.Checked = true; }
            DateTime validDate = staff.BirthDate;

            if (validDate < dtpBirthdate.MinDate || validDate > dtpBirthdate.MaxDate)
            {
                MessageBox.Show("Invalid BirthDate", "Error BirthDate", MessageBoxButtons.OK, MessageBoxIcon.Warning); // or any other default value within the valid range
            }
            else { dtpBirthdate.Value = validDate; }

            txtStaffPosition.Text = staff.StaffPosition;
            txtHouseNo.Text = staff.HouseNo;
            txtStreetNo.Text = staff.StreetNo;
            cmbStaffProvince.Text = staff.Province;
            cmbStaffKhann.Text = staff.Khann;
            cmbSangkat.Text = staff.Sangkat;
            txtPersonalTel.Text = staff.PersonalNumber;
            txtContactTel.Text = staff.ContactNumber;
            txtSalary.Text = staff.Salary.ToString();
            DateTime hiredDate = staff.HiredDate;

            if (hiredDate < dtpBirthdate.MinDate || hiredDate > dtpBirthdate.MaxDate)
            {
                MessageBox.Show("Invalid HiredDate", "Error HiredDate", MessageBoxButtons.OK, MessageBoxIcon.Warning); // or any other default value within the valid range
            }
            else
            {
                dtpBirthdate.Value = hiredDate;
            }
            if (staff != null && staff.Photo != null)
            {
                ptbPhoto.Image = staff.Photo;
            }
            else
            {
                ptbPhoto.Image = null;
            }
            if (staff != null && staff.StopWork == true) { checkStopWork.Checked = true; }
            else { checkStopWork.Checked = false; }
        }

        private void ltbStaffDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbStaffDisplay.SelectedItem != null)
            {
                string? selectedStaff = ltbStaffDisplay.SelectedItem.ToString();
                RetrieveStaffDetails(selectedStaff);
                btnInsert.Enabled = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            Staff.SearchStaff(searchTerm, ltbStaffDisplay);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                bool result = Staff.SearchStaff(searchTerm, ltbStaffDisplay);
                if (!result)
                {
                    MessageBox.Show($"No Staff found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSearch.Clear();
                }
                e.SuppressKeyPress = true;
            }
        }

        private void btnChoosePhoto_Click(object sender, EventArgs e)
        {
            Helper.SelectPhoto(openFileDialogPhoto, ptbPhoto);
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
