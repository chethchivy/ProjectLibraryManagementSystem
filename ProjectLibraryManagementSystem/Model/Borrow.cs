using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Borrow
    {
        public int borrowID {  get; set; }
        public DateTime borrowDate { get; set; }
        public short staffID { get; set; }
        public string? staffName { get; set; }
        public string? staffPosition { get; set; }
        public int memberID { get; set; }
        public string? memberName { get; set; }

        public static DataTable GetBorrowDetails(string query)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dataTable;
        }
        public static int InsertBorrowWithDetails(Borrow borrow, DataTable bookDetailsTable, out int rowsAffected)
        {
            int borrowID = 0;
            rowsAffected = 0;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("spInsertBorrowWithDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = borrow.borrowDate });
                    cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = borrow.memberID });
                    cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = borrow.staffID });

                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@BookDetails", bookDetailsTable);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "dbo.BookDetailsType";

                    SqlParameter outputParam = new SqlParameter("@rowAffected", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outputParam);

                    borrowID = (int)cmd.ExecuteScalar();
                    object outputValue = outputParam.Value;
                    if (outputValue != DBNull.Value)
                    {
                        // Convert the output parameter value to an integer
                        rowsAffected = Convert.ToInt32(outputValue);
                    }
                    else
                    {
                        // Handle DBNull (e.g., assign a default value)
                        rowsAffected = 0; // Or any other appropriate default value
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return borrowID;
        }

        public static bool UpdateBorrow(Borrow borrow)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("spUpdateBorrow", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int) { Value = borrow.borrowID });
                    cmd.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = borrow.borrowDate });
                    cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = borrow.staffID });
                    cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = borrow.memberID });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outputParam);

                    cmd.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(cmd.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static byte GetBorowedBookCount(int memberID)
        {
            byte borrowedBookCount = 0;
            string query = "SELECT dbo.fnGetBorrowedBookByMemberID(@MemberID) AS BorrowedBook";
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@MemberID", memberID));
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        borrowedBookCount = Convert.ToByte(result);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return borrowedBookCount;
        }
        public static void LoadBorrowDetailsFromDatabase(int borrowID, DataTable borrowDetailsTable, DataGridView dgv)
        {
            try
            {
                string query = "SELECT * FROM vBorrowDetail;";
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@BorrowID", borrowID);
                    try
                    {
                        borrowDetailsTable.Clear();
                        dataAdapter.Fill(borrowDetailsTable);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataView view = new DataView(borrowDetailsTable);
            view.RowFilter = $"BorrowID = {borrowID}";
            dgv.DataSource = view;
        }
        public static bool InsertBorrow(Borrow borrow, out int newBorrowID, out string errorMessage)
        {
            bool isSuccess = false;
            newBorrowID = 0;
            errorMessage = string.Empty;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertBorrow", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = borrow.borrowDate });
                    command.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = borrow.memberID });
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = borrow.staffID });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    SqlParameter newBorrowIDParam = new SqlParameter("@NewBorrowID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(newBorrowIDParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                    if (isSuccess)
                    {
                        newBorrowID = Convert.ToInt32(command.Parameters["@NewBorrowID"].Value);
                    }
                    else
                    {
                        errorMessage = "Failed to insert borrow record.";
                    }
                }
            }
            catch (Exception ex)
            {
                errorMessage = "Error Inserting Borrow: " + ex.Message;
            }

            return isSuccess;
        }

    }
}
