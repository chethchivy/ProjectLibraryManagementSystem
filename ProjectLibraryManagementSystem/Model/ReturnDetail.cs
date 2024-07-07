using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class ReturnDetail
    {
        public int returnID {  get; set; }
        public int borrowID { get; set; }   
        public int bookCode { get; set; }
        public string? bookTitle { get; set; }
        public DateTime borrowDate { get; set; }
        public DateTime dueDate { get; set; }
        public bool checkRipped { get; set; }
        public decimal fineAmount { get; set; }
        public static bool UpdateReturnDetail(ReturnDetail rd)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateReturnDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@ReturnID", SqlDbType.Int) { Value = rd.returnID });
                    command.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int) { Value = rd.borrowID });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = rd.bookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = rd.bookTitle });
                    command.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = rd.borrowDate });
                    command.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.Date) { Value = rd.dueDate });
                    command.Parameters.Add(new SqlParameter("@Ripped", SqlDbType.Bit) { Value = rd.checkRipped });
                    command.Parameters.Add(new SqlParameter("@FineAmount", SqlDbType.Money) { Value = rd.fineAmount });

                    //SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    //command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();
                    isSuccess = true;
                    //isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating BorrowDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;
        }
        public static bool InsertReturnDetail(ReturnDetail rd)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertReturnDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@ReturnID", SqlDbType.Int) { Value = rd.returnID });
                    command.Parameters.Add(new SqlParameter("@BorrowID", SqlDbType.Int) { Value = rd.borrowID });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = rd.bookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = rd.bookTitle });
                    command.Parameters.Add(new SqlParameter("@BorrowDate", SqlDbType.Date) { Value = rd.borrowDate });
                    command.Parameters.Add(new SqlParameter("@DueDate", SqlDbType.Date) { Value = rd.dueDate });
                    command.Parameters.Add(new SqlParameter("@Ripped", SqlDbType.Bit) { Value = rd.checkRipped });
                    command.Parameters.Add(new SqlParameter("@FineAmount", SqlDbType.Money) { Value = rd.fineAmount });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Insert ReturnDetail : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }
}
