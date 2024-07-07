using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Card
    {
        public int CardID { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ExpiredDate { get; set; }
        public int MemberID { get; set; }
        public string? MemberName { get; set; }
        public short StaffID { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPosition { get; set; }

        public static bool InsertCard(Card card)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertCard", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.Date) { Value = card.CreateDate });
                    command.Parameters.Add(new SqlParameter("@Expire", SqlDbType.Date, 20) { Value = card.ExpiredDate });
                    command.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = card.MemberID });
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = card.StaffID });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Card: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static void RetrieveCardDetails(string? memberName, Card card)
        {
            string query = "SELECT * FROM fnSearchCards (N'" + memberName + "');";
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@MemberName", memberName) };

                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            card.CardID = Convert.ToInt32(reader["CardID"]);
                            card.CreateDate = (DateTime)Convert.ToDateTime(reader["CreateDate"]);
                            card.ExpiredDate = (DateTime)Convert.ToDateTime(reader["Expire"]);
                            card.MemberID = Convert.ToInt32(reader["MemberID"]);
                            card.MemberName = reader["MemberName"].ToString();
                            card.StaffID = Convert.ToInt16(reader["StaffID"]);
                            card.StaffName = reader["StaffName"].ToString();
                            card.StaffPosition = reader["StaffPosition"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
        }
        public static bool SearchCard(string searchTerm, ListBox listBox)
        {
            bool result = false;
            listBox.Items.Clear();
            string query = "SELECT * FROM fnSearchCards (N'" + searchTerm + "');";

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                listBox.Items.Add(reader["MemberName"].ToString()!);
                            }
                            result = true;
                        }
                        else
                        {
                            result = false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result;
        }
        public static bool UpdateCardByID(Card card)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateCardByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@CardID", SqlDbType.Int) { Value = card.CardID });
                    command.Parameters.Add(new SqlParameter("@CreateDate", SqlDbType.Date) { Value = card.CreateDate });
                    command.Parameters.Add(new SqlParameter("@Expire", SqlDbType.Date, 20) { Value = card.ExpiredDate });

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
    }
}
