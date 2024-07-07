
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProjectLibraryManagementSystem.Model;
using System.Data;

namespace ProjectLibraryManagementSystem
{
    public static class Helper
    {
        public static string ConnectionStringKey { get; set; } = "ConnectionString";
        public static IConfiguration? Configuration { get; set; } = null;
        public static SqlConnection? Connection { get; private set; } = null;
        public static void LoadConfiguration(string jsonFile)
        {
            var builder = new ConfigurationBuilder()
              .AddJsonFile(jsonFile, optional: false, reloadOnChange: true);
            Configuration = builder.Build();
        }
        public static SqlConnection OpenConnection()
        {
            try
            {
                string connStr = Configuration.GetRequiredSection(ConnectionStringKey).Value;
                var conn = new SqlConnection(connStr);
                conn.Open();
                Connection = conn;
                return conn;
            }
            catch (Exception ex)
            {
                Connection = null;
                throw new Exception($"Failed to connect to the server > {ex.Message}");
            }
        }
        public static void HandleException(Exception ex)
        {
            MessageBox.Show("An error occurred: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        public static bool ValidateTextBoxes(params TextBox[] textboxes)
        {
            foreach (var textbox in textboxes)
            {
                if (string.IsNullOrWhiteSpace(textbox.Text))
                {
                    MessageBox.Show($"{textbox.Tag} cannot be empty.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textbox.Focus();
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateComboBoxes(params ComboBox[] comboBoxes)
        {
            foreach (var comboBox in comboBoxes)
            {
                if (comboBox.SelectedIndex == -1)
                {
                    MessageBox.Show($"Please Select {comboBox.Tag} First.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox.Focus();
                    return false;
                }
            }
            return true;
        }
        public static void ClearControls(this Control control)
        {
            foreach (Control childControl in control.Controls)
            {
                ClearControls(childControl);
            }
            if (control is TextBox textBox)
            {
                if (textBox.Tag?.ToString() != "search")
                {
                    textBox.Clear();
                }
            }
            else if (control is ComboBox)
            {
                ((ComboBox)control).SelectedIndex = -1;
                ((ComboBox)control).Text = "";
            }
            else if (control is CheckBox)
            {
                ((CheckBox)control).Checked = false;
            }
        }
        public static void AttachNavigationEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if(!(control is DataGridView || control is ListBox))
                {
                    control.KeyDown += Control_KeyDown!;
                    if (control.HasChildren)
                    {
                        AttachNavigationEvents(control);
                    }
                }
            }
        }
        public static void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Down)
            {
                e.SuppressKeyPress = true;
                MoveFocusToNextControl((Control)sender);
            }
            else if (e.KeyCode == Keys.Up)
            {
                e.SuppressKeyPress = true;
                MoveFocusToPreviousControl((Control)sender);
            }
        }
        public static void AttachClickEvents(Dictionary<Control, Type> formMapping)
        {
            foreach (var entry in formMapping)
            {
                entry.Key.Click += (sender, e) => Generic_Click(sender!, e, formMapping);
            }
        }

        private static void Generic_Click(object sender, EventArgs e, Dictionary<Control, Type> formMapping)
        {
            if (sender is Control control && formMapping.TryGetValue(control, out Type? formType))
            {
                control.BackColor = Color.LightGray;
                Form formInstance = (Form)Activator.CreateInstance(formType)!;
                formInstance.ShowDialog();
            }
            else
            {
                MessageBox.Show("Control or FormType not found.", "ALERT", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private static void MoveFocusToNextControl(Control currentControl)
        {
            currentControl.FindForm()?.SelectNextControl(currentControl, true, true, true, true);
        }

        private static void MoveFocusToPreviousControl(Control currentControl)
        {
            currentControl.FindForm()?.SelectNextControl(currentControl, false, true, true, true);
        }

        public static void LoadBookData(List<Book> bookList, ComboBox cmb)
        {
            string query = "SELECT * FROM vGetBookTitle";
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        bookList.Add(new Book
                        {
                            bookCode = reader.GetInt32(0),
                            bookTitle = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
            // Bind the ComboBox
            cmb.DataSource = bookList;
            cmb.DisplayMember = "BookTitle";
            cmb.ValueMember = "BookCode";
        }
        public static void LoadSupplierIDName(List<Supplier> supList, ComboBox cmb)
        {
            string query = "SELECT * FROM vGetSuppliersName";
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        supList.Add(new Supplier
                        {
                            supplierID = reader.GetByte(0),
                            supplierName = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            cmb.DataSource = supList;
            cmb.DisplayMember = "supplierID";
            cmb.ValueMember = "supplierID";
        }
        public static void LoadStaffData(List<Staff> staffList, ComboBox cmb)
        {
            string query = "SELECT * FROM vGetStaffIDNamePosition";
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        staffList.Add(new Staff
                        {
                            StaffID = reader.GetInt16(0),
                            StaffName = reader.GetString(1),
                            StaffPosition = reader.GetString(2)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            cmb.DataSource = staffList;
            cmb.DisplayMember = "StaffID";
            cmb.ValueMember = "StaffID";
        }
        public static void LoadMemberData(List<Member> memberList, ComboBox cmb)
        {
            string query = "SELECT * FROM vGetMemberIDName";
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        memberList.Add(new Member
                        {
                            MemberID = reader.GetInt32(0),
                            MemberName = reader.GetString(1)
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
            // Bind the ComboBox
            cmb.DataSource = memberList;
            cmb.DisplayMember = "MemberID";
            cmb.ValueMember = "MemberID";
        }
        public static void LoadCombobox(string query, string disMember, string valMember, ComboBox cmb)
        {
            using (SqlConnection connection = OpenConnection())
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    cmb.Tag = dataTable.Copy();
                    cmb.DisplayMember = disMember;
                    cmb.ValueMember = valMember;
                    cmb.DataSource = dataTable;
                }
            }
        }
        public static void ValidateCmbStaffSelection(List<Staff> staffList, ComboBox cmbStaffID, TextBox txtStaffName, TextBox txtStaffPosition)
        {
            if (!staffList.Any(s => s.StaffID.ToString() != cmbStaffID.Text))
            {
                MessageBox.Show("Please select a valid Staff ID from the list.");
                txtStaffName.Clear();
                txtStaffPosition.Clear();
                cmbStaffID.Focus();
            }
        }
        public static void ValidateCmbSupSelection(List<Supplier> supList, ComboBox cmbSupID, TextBox txtSupName)
        {
            if (!supList.Any(s => s.supplierID.ToString() != cmbSupID.Text))
            {
                MessageBox.Show("Please select a valid Staff ID from the list.");
                txtSupName.Clear();
                cmbSupID.Focus();
            }
        }
        public static void ValidateCmbMemberSelection(List<Member> memberList, ComboBox cmbMemberID, TextBox txtMemberName)
        {
            if (!memberList.Any(s => s.MemberID.ToString() != cmbMemberID.Text))
            {
                MessageBox.Show("Please select a valid Staff ID from the list.");
                txtMemberName.Clear();
                cmbMemberID.Focus();
            }
        }
        public static bool ValidateAndFetchMemberData(ComboBox cmb, TextBox txt, out DataTable resultTable)
        {
            bool isValidate = false;
            resultTable = new DataTable();
            if (!string.IsNullOrEmpty(cmb.Text))
            {
                int selectedMemberID;
                if (int.TryParse(cmb.Text, out selectedMemberID))
                {
                    // Assuming cmbMemberID is bound to a DataTable or DataView.
                    DataTable? dataSource = (cmb.DataSource as DataView)?.Table ?? cmb.DataSource as DataTable;
                    if (dataSource != null)
                    {
                        DataRow[] foundRows = dataSource.Select("MemberID = " + selectedMemberID);
                        if (foundRows.Length > 0)
                        {
                            DataRow selectedRow = foundRows[0];
                            string memberName = selectedRow["MemberName"].ToString()!;
                            txt.Text = memberName;
                            string query = "SELECT * FROM fnGetBorrowByMemberID(@MemberID)";

                            // Fetching results based on the selected MemberID.
                            resultTable = SearchByID(query, "@MemberID", selectedMemberID);
                            isValidate = true;
                        }
                        else
                        {   
                            isValidate = false;
                            MessageBox.Show("No member found with the entered MemberID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    isValidate = false;
                    MessageBox.Show("Invalid Member ID entered.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txt.Text = "";
                }
            }
            return isValidate;
        }
        public static bool ValidateAndFetchData(ComboBox cmb, TextBox txt, string cmbVal, string txtVal)
        {
            bool isValidate = false;
            if (!string.IsNullOrEmpty(cmb.Text))
            {
                int selectedMemberID;
                if (int.TryParse(cmb.Text, out selectedMemberID))
                {
                    DataTable? dataSource = (cmb.DataSource as DataView)?.Table ?? cmb.DataSource as DataTable;
                    if (dataSource != null)
                    {
                        DataRow[] foundRows = dataSource.Select($"{cmbVal} = " + selectedMemberID);
                        if (foundRows.Length > 0)
                        {
                            DataRow selectedRow = foundRows[0];
                            string memberName = selectedRow[txtVal].ToString()!;
                            txt.Text = memberName;
                            isValidate = true;
                        }
                        else
                        {
                            MessageBox.Show($"No {cmbVal} found with the entered {cmb.Text} . Please Insert correct {cmbVal}.");
                            txt.Text = "";
                            isValidate = false;
                        }
                    }
                }
                else
                {
                    MessageBox.Show($"Invalid {cmbVal} entered.");
                    txt.Text = "";
                    isValidate = false;
                }
            }
            return isValidate;
        }
        public static void LoadListBoxData(ListBox ltbDisplay, string query, string item)
        {
            ltbDisplay.Items.Clear();
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ltbDisplay.Items.Add(reader[item].ToString()!);
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        public static bool IsBookAlreadyInDetails(int bookCode, DataTable dataTable)
        {
            if (dataTable == null)
            {
                //MessageBox.Show($"Please search before insert more to Existed DATA.", "Warnning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            foreach (DataRow row in dataTable.Rows)
            {
                if (row.Field<int>("BookCode") == bookCode)
                {
                    return true;
                }
            }
            return false;
            //foreach (DataRow row in dataTable.Rows)
            //{
            //    if (row[cellName] != DBNull.Value && (int)row[cellName] == bookCode)
            //    {
            //        return true;
            //    }
            //}
            //return false;
        }
        public static void LoadAddressComboBox(ComboBox cmb, string query, string Code, string Name)
        {
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader[Code]);
                        string name = reader[Name].ToString()!;
                        cmb.Items.Add(new ComboBoxItem(id, name));
                    }
                }
            }
            catch (Exception ex)
            {
                HandleException(ex);
            }
        }
        public static void LoadProvinceComboBox(ComboBox cmb)
        {
            Address addr = new Address();
            string query = "SELECT * FROM vGetProvinceName";
            LoadAddressComboBox(cmb, query, "ProvinceCode", "ProvinceName");
        }
        public static void LoadDistrictComboBox(int provinceID, ComboBox cmb)
        {
            string query = $"SELECT * FROM vDistrictNameByProvinceID WHERE ProvinceCode = {provinceID}";
            LoadAddressComboBox(cmb, query, "DistrictCode", "DistrictName");
        }
        public static void LoadCommuneComboBox(int districtID, ComboBox cmb)
        {
            string query = $"SELECT * FROM vCommuneNameByDistrictID WHERE DistrictCode = {districtID}";
            LoadAddressComboBox(cmb, query, "CommuneCode", "CommuneName");
        }
        public static bool CheckBorrowExpired(int memberID, int bookCode, out bool hasExpired)
        {
            hasExpired = false;
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand("spCheckBorrowExpired", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = memberID });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = bookCode });
                    SqlParameter expiredParam = new SqlParameter("@HasExpired", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(expiredParam);

                    command.ExecuteNonQuery();
                    hasExpired = Convert.ToBoolean(command.Parameters["@HasExpired"].Value);
                }
            }
            catch (Exception ex)
            {
                hasExpired = false;
                MessageBox.Show("Error Checking Borrow Expired: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return hasExpired;
        }
        public static bool CheckMemberExists(int memberID, out bool memberExists)
        {
            memberExists = false;
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand("spCheckMemberExists", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = memberID });
                    SqlParameter expiredParam = new SqlParameter("@Exists", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(expiredParam);

                    command.ExecuteNonQuery();
                    memberExists = Convert.ToBoolean(command.Parameters["@Exists"].Value);
                }
            }
            catch (Exception ex)
            {
                memberExists = false;
                MessageBox.Show("Error Checking Member Existence: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return memberExists;
        }
        public static void SelectPhoto(OpenFileDialog photoFile, PictureBox image)
        {
            DialogResult result;
            result = photoFile.ShowDialog();

            if (result == DialogResult.OK)
            {
                image.Image = Image.FromFile(photoFile.FileName);
            }
        }
        public static void SetFocusToControl(Form f, Control con)
        {
            f.BeginInvoke(new Action(() =>
            {
                con.Focus();
            }));
        }

        public static void DisableOtherControls(Form f, Control name)
        {
            foreach (Control control in f.Controls)
            {
                if (control == name)
                {
                    control.Enabled = true;
                }
                else
                {
                    control.Enabled = false;
                }
            }
        }
        public static void SetFocusAndDisableOtherControls(Form f, Control controlToFocus)
        {
            DisableOtherControls(f, controlToFocus);
            controlToFocus.Enabled = true;  // Ensure the control is enabled
            SetFocusToControl(f, controlToFocus);
        }

        public static bool Insert(DataTable Table, string proName, string inPar, string type)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (var cmd = new SqlCommand(proName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var batchPara = cmd.Parameters.AddWithValue(inPar, Table);
                    batchPara.SqlDbType = SqlDbType.Structured;
                    batchPara.TypeName = type;

                    var para = new SqlParameter("@rowsAffected", SqlDbType.Int);
                    para.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(para);
                    int result = cmd.ExecuteNonQuery();
                    int rowsAffectedValue = (int)para.Value;

                    if (rowsAffectedValue > 0)
                    {
                        isSuccess = true;
                    }
                    // MessageBox.Show("Sucessfully Submitted", "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Table.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                isSuccess=false;
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSuccess;
        }

        public static bool Update(DataTable Table, string proName, string inPar, string type)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (var cmd = new SqlCommand(proName, connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    var batchPara = cmd.Parameters.AddWithValue(inPar, Table);
                    batchPara.SqlDbType = SqlDbType.Structured;
                    batchPara.TypeName = type;

                    var para = new SqlParameter("@rowsAffected", SqlDbType.Int);
                    para.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(para);
                    int result = cmd.ExecuteNonQuery();
                    Table.Rows.Clear();
                    isSuccess = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSuccess;
        }

        public static DataTable ReadData(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (var cmd = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return dt;
        }

        public static bool Search(string searchTerm, ListBox ltb, string query, string displayMem, string valMem)
        {
            DataTable dt = ReadData(query);

            if (dt.Rows.Count > 0)
            {
                ltb.DataSource = dt;
                ltb.DisplayMember = displayMem;
                ltb.ValueMember = valMem;
                return true;
            }
            else
            {
                //MessageBox.Show("No books found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ltb.DataSource = null;
                return false;
            }
        }
        public static DataTable SearchByID(string query, string var, int search)
        {
            DataTable resultTable = new DataTable();
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue(var, search);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(resultTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultTable;
        }
        public static void ShowInCombobox(DataTable resultTable, ComboBox cmb, string item)
        {
            if (resultTable != null)
            {
                if (resultTable.Columns.Contains(item))
                {
                    cmb.DisplayMember = item;
                    cmb.ValueMember = item;
                    cmb.DataSource = resultTable;
                }
                else
                {
                    MessageBox.Show($"The column {item} was not found in the result set.", "Column Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public static void DeleteBookFromBorrowDetail(int borrowID, int bookCode)
        {
            try
            {
                using (SqlConnection connection = OpenConnection())
                using (SqlCommand command = new SqlCommand("spDeleteBorrowDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@BorrowID", borrowID));
                    command.Parameters.Add(new SqlParameter("@BookCode", bookCode));

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Delete Book From BorrowDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void UpdateDueDate(int borrowID, int bookCode, DateTime NewDueDate)
        {
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateDueDate", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@BorrowID", borrowID));
                    command.Parameters.Add(new SqlParameter("@BookCode", bookCode));
                    command.Parameters.Add(new SqlParameter("@NewDueDate", NewDueDate));

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update Book DueDate From BorrowDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void PerformLogin()
        {
            using (FormLogin loginForm = new FormLogin())
            {
                loginForm.ShowDialog();
                if (loginForm.DialogResult != DialogResult.OK)
                {
                    Application.Exit();
                }
                //else
                //{
                //    fMain.Show();
                //}
            }
        }
    }
}
