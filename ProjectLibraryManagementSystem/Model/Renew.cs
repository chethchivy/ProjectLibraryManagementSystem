using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Renew
    {
        public int renewID { get; set; }
        public DateTime renewDate { get; set; }
        public DateTime newDueDate { get; set; }
        public int bookCode { get; set; }
        public short staffID { get; set; }
        public int memberID { get; set; }
        public int BorrowID { get; set; }

        public static int InsertRenew(Renew renew)
        {
            int renewID = 0;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertRenew", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RenewDate", renew.renewDate));
                    command.Parameters.Add(new SqlParameter("@NewDueDate", renew.newDueDate));
                    command.Parameters.Add(new SqlParameter("@MemberID", renew.memberID));
                    command.Parameters.Add(new SqlParameter("@BorrowID", renew.BorrowID));
                    command.Parameters.Add(new SqlParameter("@BookCode", renew.bookCode));
                    command.Parameters.Add(new SqlParameter("@StaffID", renew.staffID));

                    SqlParameter outputParam = new SqlParameter("@RenewID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    renewID = (int)outputParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Renew: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return renewID;
        }
        public static bool UpdateRenewByID(Renew renew)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateRenew", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@RenewID", renew.renewID));
                    command.Parameters.Add(new SqlParameter("@RenewDate", renew.renewDate));
                    command.Parameters.Add(new SqlParameter("@NewDueDate", renew.newDueDate));
                    command.Parameters.Add(new SqlParameter("@MemberID", renew.memberID));
                    command.Parameters.Add(new SqlParameter("@BorrowID", renew.BorrowID));
                    command.Parameters.Add(new SqlParameter("@BookCode", renew.bookCode));
                    command.Parameters.Add(new SqlParameter("@StaffID", renew.staffID));

                    command.ExecuteNonQuery();
                    isSuccess=true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;
        }
        public static void LoadBookCodesByMemberID(int memberID, ComboBox cmb)
        {
            using (SqlConnection connection = Helper.OpenConnection())
            {
                string query = "SELECT BookCode FROM fnGetBorrowByMemberID(@MemberID)";

                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection))
                {
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@MemberID", memberID);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    if (dataTable.Columns.Contains("BookCode"))
                    {
                        cmb.DisplayMember = "BookCode";
                        cmb.ValueMember = "BookCode";
                        cmb.DataSource = dataTable;
                    }
                    else
                    {
                        MessageBox.Show("The column 'BookCode' was not found in the result set.", "Column Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
