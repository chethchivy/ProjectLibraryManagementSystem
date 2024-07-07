using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Return
    {
        public int returnID {  get; set; }
        public DateTime ReturnDate { get; set; }
        public short staffID { get; set; }
        public int memberID { get; set; }

        public static decimal GetBookPriceByBookCode(int bookCode)
        {
            decimal lateFee = 0;
            string query = "SELECT dbo.fnPriceByBookCode(@BookCode) AS Price";
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@BookCode", bookCode));
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lateFee = Convert.ToDecimal(result);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lateFee;
        }
        public static decimal GetLateFeeByBookCode(int bookCode)
        {
            decimal lateFee = 0;
            string query = "SELECT dbo.fnGetLateFeeByBookCode(@BookCode) AS LateFee";
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@BookCode", bookCode));
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        lateFee = Convert.ToDecimal(result);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return lateFee;
        }
        public static ReturnDetail GetBorrowAndDueDateByBorrowID(int borrowID, int bookCode)
        {
            ReturnDetail returnDetail = null!;

            string query = "SELECT * FROM dbo.fnGetBorrowAndDueDateByBorrowID(@BorrowID, @BookCode)";
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.Parameters.Add(new SqlParameter("@BorrowID", borrowID));
                    cmd.Parameters.Add(new SqlParameter("@BookCode", bookCode));
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returnDetail = new ReturnDetail
                            {
                                borrowDate = reader.GetDateTime(reader.GetOrdinal("BorrowDate")),
                                dueDate = reader.GetDateTime(reader.GetOrdinal("DueDate"))
                            };
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "LoadData", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            return returnDetail;
        }
        public static int InsertReturnWithDetails(Return r, DataTable returnDetail, out int rowsAffected)
        {
            int returnID = 0;
            rowsAffected = 0;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("spInsertReturnWithDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ReturnDate", SqlDbType.Date) { Value = r.ReturnDate });
                    cmd.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = r.memberID });
                    cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = r.staffID });

                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ReturnDetails", returnDetail);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "dbo.ReturnDetailType";

                    SqlParameter outputParam = new SqlParameter("@rowAffected", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outputParam);

                    SqlParameter returnIDParam = new SqlParameter("@ReturnID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(returnIDParam);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameters
                    rowsAffected = Convert.ToInt32(outputParam.Value);
                    returnID = Convert.ToInt32(returnIDParam.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return returnID;
        }
        public static bool UpdateReturn(Return r)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("spUpdateReturn", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ReturnID", SqlDbType.Int) { Value = r.returnID });
                    cmd.Parameters.Add(new SqlParameter("@ReturnDate", SqlDbType.Date) { Value = r.ReturnDate });
                    cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = r.staffID });

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

    }
}
