using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Import
    {
        public int ImportID { get; set; }
        public DateTime ImportDate { get; set; }
        public decimal TotalAmount { get; set; } = 0;
        public byte SupplierID { get; set; }
        public string? SupplierName { get; set; }
        public short StaffID { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPosition { get; set; }
        public static DataTable GetImportDetails(string query)
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
        public static int InsertImportWithDetails(Import import, DataTable importDetailsTable, out int rowsAffected)
        {
            int importID = 0;
            rowsAffected = 0;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("spInsertImportWithDetails", connection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.Date) { Value = import.ImportDate });
                    cmd.Parameters.Add(new SqlParameter("@TotalAmount", SqlDbType.Money) { Value = import.TotalAmount });
                    cmd.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.Int) { Value = import.SupplierID });
                    cmd.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = import.StaffID });

                    SqlParameter tvpParam = cmd.Parameters.AddWithValue("@ImportDetails", importDetailsTable);
                    tvpParam.SqlDbType = SqlDbType.Structured;
                    tvpParam.TypeName = "dbo.tbImportDetailType";

                    SqlParameter outputParam = new SqlParameter("@rowAffected", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(outputParam);

                    SqlParameter importIDParam = new SqlParameter("@ImportID", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    cmd.Parameters.Add(importIDParam);

                    // Execute the command
                    cmd.ExecuteNonQuery();

                    // Retrieve the output parameters
                    rowsAffected = Convert.ToInt32(outputParam.Value);
                    importID = Convert.ToInt32(importIDParam.Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Submitting", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return importID;
        }
        public static bool UpdateImport(Import imp)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateImport", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@ImportID", SqlDbType.Int) { Value = imp.ImportID });
                    command.Parameters.Add(new SqlParameter("@ImportDate", SqlDbType.Date) { Value = imp.ImportDate});
                    command.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.TinyInt) { Value = imp.SupplierID});
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = imp.StaffID });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Update Import : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }
}
