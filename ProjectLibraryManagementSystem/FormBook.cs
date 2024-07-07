using Microsoft.Data.SqlClient;
using ProjectLibraryManagementSystem.Model;
using System.Data;
using Timer = System.Windows.Forms.Timer;

namespace ProjectLibraryManagementSystem
{
    public partial class FormBook : Form
    {
        private Timer loginTimer = null!;
        public FormBook()
        {
            InitializeComponent();
            btnLogout.Click += new EventHandler(btnLogout_Click!);
        }
        private void LoginTimer_Tick(object sender, EventArgs e)
        {
            loginTimer.Stop();
            Helper.PerformLogin();
        }

        private void FormBook_Load(object sender, EventArgs e)
        {
            LoadBookTitles();
            Helper.AttachNavigationEvents(this);
            Helper.ClearControls(this); 
        }
        public void LoadBookTitles()
        {
            string query = "SELECT * FROM vGetAllBooks";
            DataTable dt = Helper.ReadData(query);
            ltbBookDisplay.DisplayMember = "BookTitle"; 
            ltbBookDisplay.ValueMember = "BookCode";
            ltbBookDisplay.DataSource = dt;
            ltbBookDisplay.ClearSelected();
        }
        private Book CreateBookFromTextBoxes()
        {
            string bookTitle = txtBookTitle.Text;
            string genres = txtGenres.Text;
            string author = txtAuthor.Text;
            short publishYear;
            byte bookQty;
            decimal lateFee;
            decimal price;

            if (string.IsNullOrEmpty(txtBookTitle.Text.Trim()))
            {
                MessageBox.Show("Please enter a book title.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBookTitle.Focus();
                return null!;
            }

            if (string.IsNullOrEmpty(txtGenres.Text.Trim()))
            {
                MessageBox.Show("Please enter genres for the book.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGenres.Focus();
                return null!; 
            }

            if (string.IsNullOrEmpty(txtAuthor.Text.Trim()))
            {
                MessageBox.Show("Please enter the author's name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return null!;
            }
            
            if (!short.TryParse(txtPublishYear.Text, out publishYear) || publishYear > DateTime.Now.Year)
            {
                MessageBox.Show("Please enter a valid publish year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPublishYear.Focus();
                return null!;
            }
            if (string.IsNullOrEmpty(txtBookQty.Text.Trim()))
            {
                bookQty = 0;
            }
            else
            {
                if (!byte.TryParse(txtBookQty.Text, out bookQty) || bookQty < 0 || bookQty > 255)
                {
                    MessageBox.Show("Please enter a valid book quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtBookQty.Focus();
                    return null!;
                }
            }
            if (!decimal.TryParse(txtLateFee.Text, out lateFee) || lateFee < 0)
            {
                MessageBox.Show("Please enter a valid late fee.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLateFee.Focus();
                return null!; 
            }
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                price = 0;
            }
            else
            {
                if (!decimal.TryParse(txtPrice.Text, out price) || price < 0)
                {
                    MessageBox.Show("Please enter a valid price.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPrice.Focus();
                    return null!;
                }
            }

            return new Book
            {
                bookTitle = bookTitle,
                genres = genres,
                author = author,
                publishYear = publishYear,
                bookQty = bookQty,
                lateFee = lateFee,
                price = price
            };
        }
        private void DisplayDetail(DataRow bookRow)
        {
            if (bookRow != null)
            {
                txtBookCode.Text = bookRow["BookCode"]?.ToString() ?? "";
                txtBookTitle.Text = bookRow["BookTitle"]?.ToString() ?? "";
                txtGenres.Text = bookRow["Genres"]?.ToString() ?? "";
                txtAuthor.Text = bookRow["Author"]?.ToString() ?? "";
                txtPublishYear.Text = bookRow["PublishYear"]?.ToString() ?? "";
                txtBookQty.Text = bookRow["BookQty"]?.ToString() ?? "";
                txtLateFee.Text = bookRow["LateFee"] is decimal lateFee ? lateFee.ToString("F2") : "0.00";
                txtPrice.Text = bookRow["Price"] is decimal price ? price.ToString("F2") : "0.00";
            }
            else
            {
                Helper.ClearControls(this);
            }
        }

        private DataTable ConvertToDataTable(Book book)
        {
            if (book == null)
            {
                throw new ArgumentNullException(nameof(book), "The book object is null.");
            }
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("BookCode", typeof(int));
            dataTable.Columns.Add("BookTitle", typeof(string));
            dataTable.Columns.Add("Genres", typeof(string));
            dataTable.Columns.Add("Author", typeof(string));
            dataTable.Columns.Add("PublishYear", typeof(short));
            dataTable.Columns.Add("BookQty", typeof(byte));
            dataTable.Columns.Add("LateFee", typeof(decimal));
            dataTable.Columns.Add("Price", typeof(decimal));

            DataRow row = dataTable.NewRow();
            row["BookTitle"] = book.bookTitle;
            row["Genres"] = book.genres;
            row["Author"] = book.author;
            row["PublishYear"] = book.publishYear;
            row["BookQty"] = book.bookQty;
            row["LateFee"] = book.lateFee;
            row["Price"] = book.price;
            dataTable.Rows.Add(row);

            return dataTable;
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            Book newBook = CreateBookFromTextBoxes();
            if (newBook == null)
            {
                return;
            }

            DataTable bookData = ConvertToDataTable(newBook);

            bool insertionResult = Helper.Insert(bookData, "spInsertBooks", "@Books", "dbo.BookType");

            if (insertionResult)
            {
                MessageBox.Show("Successfully inserted data!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBookTitles();
                Helper.ClearControls(this);
            }
            else
            {
                MessageBox.Show("Failed to insert data!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBookCode.Text.Trim(), out int bookCode) || string.IsNullOrWhiteSpace(txtBookCode.Text))
            {
                MessageBox.Show("Invalid Book Code. Please enter a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Book newBook = CreateBookFromTextBoxes();
                if (newBook == null)
                {
                    return;
                }
                DataTable bookData = ConvertToDataTable(newBook);
                if (bookData != null && bookData.Rows.Count > 0)
                {
                    bookData.Rows[0]["BookCode"] = bookCode;

                    bool isSuccess = Helper.Update(bookData, "spUpdateBooks", "@Books", "dbo.BookType");
                    if (isSuccess)
                    {
                        MessageBox.Show("Book updated successfully...", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ltbBookDisplay.ClearSelected();
                        Helper.ClearControls(this);
                    }
                    else
                    {
                        MessageBox.Show("Book was not updated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Table is not correctly populated.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Helper.ClearControls(this);
            ltbBookDisplay.ClearSelected();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ltbBookDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ltbBookDisplay.SelectedValue != null)
            {
                int bookID = (int)ltbBookDisplay.SelectedValue;
                string query = $"SELECT * FROM fnSearchBookByBookTitle (N'{bookID}')"; 
                DataTable dt = Helper.ReadData(query);

                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    DisplayDetail(row);
                }
                else
                {
                    Helper.ClearControls(this);
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(searchTerm))
            {
                string query = $"SELECT * FROM fnSearchBookByBookTitle(N'%{searchTerm}%')";
                bool result = Helper.Search(searchTerm, ltbBookDisplay, query, "BookTitle", "BookCode");
                if (!result)
                {
                    Helper.ClearControls(this);
                }
            }
            else
            {
                LoadBookTitles();
                ltbBookDisplay.ClearSelected();
                Helper.ClearControls(this);
            }
        }
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string searchTerm = txtSearch.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    string query = $"SELECT * FROM fnSearchBookByBookTitle(N'%{searchTerm}%')";

                    bool result = Helper.Search(searchTerm, ltbBookDisplay, query, "BookTitle", "BookCode");
                    if (!result)
                    {
                        MessageBox.Show($"No Book found for the given search {searchTerm}.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookTitles();
                        txtSearch.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("Please enter BookCode or BookTitle to search", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                e.SuppressKeyPress = true;
            }
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


        ///////////////////// Code In Helper class /////////////////
        public static bool Insert(DataTable Table, string proName, string inPar, string type)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
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
                    Table.Rows.Clear();
                }

            }
            catch (Exception ex)
            {
                isSuccess = false;
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return isSuccess;
        }

        public static bool Update(DataTable Table, string proName, string inPar, string type)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
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
                using (SqlConnection connection = Helper.OpenConnection())
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

        ////////////////////////////////////////////////////////////////////////////
    }
}

