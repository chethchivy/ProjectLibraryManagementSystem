using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Payment
    {
        public int paymentNo { get; set; }
        public DateTime payDate { get; set; }
        public decimal paidAmount { get; set; }
        public int returnID { get; set; }
        public short staffID { get; set; }
        public int memberID { get; set; }

        public static int InsertPayment(Payment pay)
        {
            int paymentNo = 0;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertPayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@PaidAmount", pay.paidAmount));
                    command.Parameters.Add(new SqlParameter("@MemberID", pay.memberID));
                    command.Parameters.Add(new SqlParameter("@ReturnID", pay.returnID));
                    command.Parameters.Add(new SqlParameter("@StaffID", pay.staffID));

                    SqlParameter outputParam = new SqlParameter("@PaymentNo", SqlDbType.Int) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    paymentNo = (int)outputParam.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return paymentNo;
        }
        public static bool UpdatePaymentByNo(Payment pay)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdatePayment", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@PaymentNo", pay.paymentNo));
                    command.Parameters.Add(new SqlParameter ("@PaidAmount", pay.paidAmount));
                    command.Parameters.Add(new SqlParameter("@MemberID", pay.memberID));
                    command.Parameters.Add(new SqlParameter("@ReturnID", pay.returnID));
                    command.Parameters.Add(new SqlParameter("@StaffID", pay.staffID));

                    command.ExecuteNonQuery();
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Payment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                isSuccess = false;
            }

            return isSuccess;
        }
    }
}
