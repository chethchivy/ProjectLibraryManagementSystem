using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class User
    {
        public int UserID { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public short StaffID { get; set; }
        public string? StaffName { get; set;}
        public string? StaffPosition { get; set; }
        public static bool ValidateUser(string username, string password)
        {
            int result = 0;
            try
            {
                using (SqlConnection con = Helper.OpenConnection())
                using (SqlCommand cmd = new SqlCommand("ValidateUser", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    result = (int)cmd.ExecuteScalar();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error inserting supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return result == 1;
        }

        public static bool InsertUser(User user)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertUser", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 20) { Value = user.UserName });
                    command.Parameters.Add(new SqlParameter("@UserPassword", SqlDbType.VarChar, 20) { Value = user.Password });
                    command.Parameters.Add(new SqlParameter("@StaffID", SqlDbType.SmallInt) { Value = user.StaffID });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static void RetrieveUserDetails(string? userName, User user)
        {
            string query = "SELECT * FROM fnSearchUsers (N'" + userName + "');";
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@UserName", userName) };

                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            user.UserID = Convert.ToInt32(reader["UserID"]);
                            user.UserName = reader["UserName"].ToString();
                            user.Password = reader["UserPassword"].ToString();
                            user.StaffID = Convert.ToInt16(reader["StaffID"]);
                            user.StaffName = reader["StaffName"].ToString();
                            user.StaffPosition = reader["StaffPosition"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
        }
        public static bool SearchUser(string searchTerm, ListBox listBox)
        {
            bool result = false;
            listBox.Items.Clear();
            string query = "SELECT * FROM fnSearchUser (N'" + searchTerm + "');";

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
                                listBox.Items.Add(reader["UserName"].ToString()!);
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
        public static bool UpdateUserByID(User user)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateUserByUserID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int) { Value = user.UserID });
                    command.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar, 20) { Value = user.UserName });
                    command.Parameters.Add(new SqlParameter("@UserPassword", SqlDbType.VarChar, 20) { Value = user.Password });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating User: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }

}
