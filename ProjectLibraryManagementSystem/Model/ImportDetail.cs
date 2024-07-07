using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProjectLibraryManagementSystem.Model
{
    public class ImportDetail
    {
        public int ImportID { get; set; }
        public int BookCode { get; set; }
        public string? BookTitle { get; set; }
        public byte ImportQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Amount { get; set; }

        public static bool UpdateImportDetail(ImportDetail impD)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateImportDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int) { Value = impD.ImportID });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = impD.BookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = impD.BookTitle });
                    command.Parameters.Add(new SqlParameter("@NewImportQty", SqlDbType.TinyInt) { Value = impD.ImportQty });
                    command.Parameters.Add(new SqlParameter("@NewUnitPrice", SqlDbType.Money) { Value = impD.UnitPrice });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Card: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
        public static bool InsertImportDetail(ImportDetail impD)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertImportDetail", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int) { Value = impD.ImportID });
                    command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int) { Value = impD.BookCode });
                    command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = impD.BookTitle });
                    command.Parameters.Add(new SqlParameter("@ImportQty", SqlDbType.TinyInt) { Value = impD.ImportQty });
                    command.Parameters.Add(new SqlParameter("@UnitPrice", SqlDbType.Money) { Value = impD.UnitPrice });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Insert ImportDetail : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }
}
