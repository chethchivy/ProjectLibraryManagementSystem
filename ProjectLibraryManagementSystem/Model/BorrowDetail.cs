using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class BorrowDetail
    {
        public int borrowId {  get; set; }
        public int bookCode {  get; set; }
        public string? bookTitle { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime dueDate { get; set; }
        public static bool UpdateBorrowDetail(BorrowDetail bd)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateBorrowDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int) { Value = bd.borrowId });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = bd.bookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = bd.bookTitle });
                    command.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.Date) { Value = bd.dueDate });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating BorrowDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
        public static bool InsertBorrowDetail(BorrowDetail bd)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertBorrowDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int) { Value = bd.borrowId });
                    command.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = bd.borrowDate });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = bd.bookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = bd.bookTitle });
                    command.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.Date) { Value = bd.dueDate });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Insert BorrowDetail : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            return isSuccess;
        }
    }
}
