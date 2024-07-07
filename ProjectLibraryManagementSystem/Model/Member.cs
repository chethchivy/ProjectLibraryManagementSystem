using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Member:Person
    {
        public int MemberID { get; set; }
        public string? MemberName { get; set; }
        public string? PhoneNumber { get; set; }
        public Image? Photo { get; set; }
        public static bool InsertMember(Member member, PictureBox pic)
        {
            byte[] photoData = null!;

            if (pic.Image != null)
            {
                photoData = ImageToByteArray(pic.Image);
            }
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = member.FirstName });
                    command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = member.LastName });
                    command.Parameters.Add(new SqlParameter("@Sex", SqlDbType.NChar, 6) { Value = member.Sex });
                    command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = member.BirthDate });
                    command.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50) { Value = member.Sangkat });
                    command.Parameters.Add(new SqlParameter("@Khann", SqlDbType.NVarChar, 50) { Value = member.Khann });
                    command.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 50) { Value = member.Province });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 20) { Value = member.PhoneNumber });
                    command.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary) { Value = (object)photoData ?? DBNull.Value });

                    SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@OutputMessage"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static void RetrieveMemberDetails(string? memberName, Member member)
        {
            string query = "SELECT * FROM fnSearchMembers (N'%" + memberName + "%');";
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
                            member.MemberID = Convert.ToInt32(reader["MemberID"]);
                            member.FirstName = reader["FirstName"].ToString();
                            member.LastName = reader["LastName"].ToString();
                            member.Sex = reader["Sex"].ToString() ;
                            member.BirthDate = (DateTime)(reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : (DateTime?)null!);
                            member.Province = reader["Province"].ToString();
                            member.Khann = reader["Khann"].ToString(); 
                            member.Sangkat = reader["Sangkat"].ToString();
                            member.PhoneNumber = reader["PhoneNumber"].ToString();
                            member.Photo = reader["Photo"] != DBNull.Value ? ByteArrayToImage((byte[])reader["Photo"]) : null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
        }
        public static bool SearchMember(string searchTerm, ListBox listBox)
        {
            bool result = false;
            listBox.Items.Clear();
            string query = "SELECT * FROM fnSearchMember (N'%" + searchTerm + "%');";

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
        public static bool UpdateMemberByID(Member member, PictureBox pic)
        {
            byte[] photoData = null!;

            if (pic.Image != null)
            {
                photoData = ImageToByteArray(pic.Image);
            }
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateMember", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@MemberID", SqlDbType.Int) { Value = member.MemberID });
                    command.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = member.FirstName });
                    command.Parameters.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = member.LastName });
                    command.Parameters.Add(new SqlParameter("@Sex", SqlDbType.NChar, 6) { Value = member.Sex });
                    command.Parameters.Add(new SqlParameter("@BirthDate", SqlDbType.Date) { Value = member.BirthDate });
                    command.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50) { Value = member.Sangkat });
                    command.Parameters.Add(new SqlParameter("@Khann", SqlDbType.NVarChar, 50) { Value = member.Khann });
                    command.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 50) { Value = member.Province });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber", SqlDbType.NVarChar, 20) { Value = member.PhoneNumber });
                    command.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary) { Value = (object)photoData ?? DBNull.Value });

                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Member: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
        private static Image ByteArrayToImage(byte[] byteArray)
        {
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
        private static byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }

    }
}
