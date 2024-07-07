using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibraryManagementSystem.Model
{
    public class Invoice
    {
        public int invoiceNo {  get; set; }
        public DateTime invoiceDate { get; set; }
        public decimal totalAmount { get; set; }
        public decimal paidAmount { get; set; }
        public int returnID { get; set; }
        public short staffID { get; set; }
        public int memberID { get; set; }

        public static int InsertInvoice(Invoice invoice)
        {
            int invoiceNo = 0;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@TotalAmount", invoice.totalAmount));
                    command.Parameters.Add(new SqlParameter("@PaidAmount", invoice.paidAmount));
                    command.Parameters.Add(new SqlParameter("@MemberID", invoice.memberID));
                    command.Parameters.Add(new SqlParameter("@ReturnID", invoice.returnID));
                    command.Parameters.Add(new SqlParameter("@StaffID", invoice.staffID));

                    SqlParameter outputParam = new SqlParameter("@InvoiceNo", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    invoiceNo = (int)outputParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Renew: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return invoiceNo;
        }
        public static bool UpdateInvoiceByNo(Invoice invoice)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateInvoice", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@InvoiceNo", invoice.invoiceNo));
                    command.Parameters.Add(new SqlParameter("@PaidAmount", invoice.paidAmount));
                    command.Parameters.Add(new SqlParameter("@MemberID", invoice.memberID));
                    command.Parameters.Add(new SqlParameter("@ReturnID", invoice.returnID));
                    command.Parameters.Add(new SqlParameter("@StaffID", invoice.staffID));

                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Invoice : " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;
        }

    }
}
