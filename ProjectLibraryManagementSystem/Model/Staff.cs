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
    public class Staff:Person
    {
        public short StaffID { get; set; }
        public string? StaffName { get; set; }
        public string? StaffPosition { get; set; }
        public string? HouseNo { get; set; }
        public string? StreetNo { get; set;}
        public string? ContactNumber { get; set; }
        public string? PersonalNumber { get; set; }
        public decimal Salary { get; set; }
        public DateTime HiredDate { get; set; }
        public Image? Photo { get; set; }
        public bool StopWork { get; set; }

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
        public static bool InsertStaff(Staff staff, PictureBox pic)
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
                using (SqlCommand command = new SqlCommand("spInsertStaff", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@sfn", SqlDbType.NVarChar, 50) { Value = staff.FirstName });
                    command.Parameters.Add(new SqlParameter("@sln", SqlDbType.NVarChar, 50) { Value = staff.LastName });
                    command.Parameters.Add(new SqlParameter("@ss", SqlDbType.NChar, 6) { Value = staff.Sex });
                    command.Parameters.Add(new SqlParameter("@sbd", SqlDbType.Date) { Value = staff.BirthDate });
                    command.Parameters.Add(new SqlParameter("@sp", SqlDbType.NVarChar, 100) { Value = staff.StaffPosition });
                    command.Parameters.Add(new SqlParameter("@hn", SqlDbType.NVarChar, 15) { Value = staff.HouseNo });
                    command.Parameters.Add(new SqlParameter("@StrNo", SqlDbType.NVarChar, 25) { Value = staff.StreetNo });
                    command.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50) { Value = staff.Sangkat });
                    command.Parameters.Add(new SqlParameter("@Khann", SqlDbType.NVarChar, 50) { Value = staff.Khann });
                    command.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 50) { Value = staff.Province });
                    command.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 20) { Value = staff.ContactNumber });
                    command.Parameters.Add(new SqlParameter("@PersonalNumber", SqlDbType.NVarChar, 20) { Value = staff.PersonalNumber });
                    command.Parameters.Add(new SqlParameter("@HiredDate", SqlDbType.Date) { Value = staff.HiredDate });
                    command.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money) { Value = staff.Salary });
                    command.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary) { Value = (object)photoData ?? DBNull.Value });
                    command.Parameters.Add(new SqlParameter("@StopWork", SqlDbType.Bit) { Value = staff.StopWork });


                    SqlParameter outputParam = new SqlParameter("@isSuccess", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@isSuccess"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Staff: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static void RetrieveStaffDetails(string? staffName, Staff staff)
        {
            string query = "SELECT * FROM fnSearchStaffs (N'%" + staffName + "%');";
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@StaffName", staffName) };

                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            staff.StaffID = Convert.ToInt16(reader["StaffID"]);
                            staff.FirstName = reader["FirstName"] != DBNull.Value ? reader["FirstName"].ToString() : null;
                            staff.LastName = reader["LastName"] != DBNull.Value ? reader["LastName"].ToString() : null;
                            staff.Sex = reader["Sex"] != DBNull.Value ? reader["Sex"].ToString() : null;
                            staff.BirthDate = (DateTime)(reader["BirthDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["BirthDate"]) : null);
                            staff.StaffPosition = reader["StaffPosition"] != DBNull.Value ? reader["StaffPosition"].ToString() : null;
                            staff.HouseNo = reader["HouseNo"] != DBNull.Value ? reader["HouseNo"].ToString() : null;
                            staff.StreetNo = reader["StreetNo"] != DBNull.Value ? reader["StreetNo"].ToString() : null;
                            staff.Province = reader["Province"] != DBNull.Value ? reader["Province"].ToString() : null;
                            staff.Khann = reader["Khann"] != DBNull.Value ? reader["Khann"].ToString() : null;
                            staff.Sangkat = reader["Sangkat"] != DBNull.Value ? reader["Sangkat"].ToString() : null;
                            staff.ContactNumber = reader["ContactNumber"] != DBNull.Value ? reader["ContactNumber"].ToString() : null;
                            staff.PersonalNumber = reader["PersonalNumber"] != DBNull.Value ? reader["PersonalNumber"].ToString() : null;
                            staff.Salary = reader["Salary"] != DBNull.Value ? Convert.ToDecimal(reader["Salary"]) : default(decimal);
                            staff.HiredDate = (DateTime)(reader["HireDate"] != DBNull.Value ? (DateTime?)Convert.ToDateTime(reader["HireDate"]) : null);
                            staff.Photo = reader["Photo"] != DBNull.Value ? ByteArrayToImage((byte[])reader["Photo"]) : null;
                            staff.StopWork = reader["StopWork"] != DBNull.Value ? Convert.ToBoolean(reader["StopWork"]) : default(bool);
                            //staff.StaffID = Convert.ToInt16(reader["StaffID"]);
                            //staff.FirstName = reader["FirstName"].ToString();
                            //staff.LastName = reader["LastName"].ToString();
                            //staff.Sex = reader["Sex"].ToString();
                            //staff.BirthDate = (DateTime)(reader["BirthDate"] != DBNull.Value ? Convert.ToDateTime(reader["BirthDate"]) : (DateTime?)null!);
                            //staff.StaffPosition = reader["StaffPosition"].ToString();
                            //staff.HouseNo = reader["HouseNo"].ToString();
                            //staff.StreetNo = reader["StreetNo"].ToString();
                            //staff.Province = reader["Province"].ToString();
                            //staff.Khann = reader["Khann"].ToString();
                            //staff.Sangkat = reader["Sangkat"].ToString();
                            //staff.ContactNumber = reader["ContactNumber"].ToString();
                            //staff.PersonalNumber = reader["PersonalNumber"].ToString();
                            //staff.Salary = Convert.ToDecimal(reader["Salary"]);
                            //staff.HiredDate = (DateTime)(reader["HireDate"] != DBNull.Value ? Convert.ToDateTime(reader["HireDate"]) : (DateTime?)null!);
                            //staff.Photo = reader["Photo"] != DBNull.Value ? ByteArrayToImage((byte[])reader["Photo"]) : null;
                            //staff.StopWork = Convert.ToBoolean(reader["StopWork"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
        }
        public static bool SearchStaff(string searchTerm, ListBox listBox)
        {
            bool result = false;
            listBox.Items.Clear();
            string query = "SELECT * FROM fnSearchStaff (N'%" + searchTerm + "%');";

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
                                listBox.Items.Add(reader["StaffName"].ToString()!);
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
        public static bool UpdateStaffByID(Staff staff, PictureBox pic)
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
                using (SqlCommand command = new SqlCommand("spUpdateStaffByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@sID", SqlDbType.SmallInt) { Value = staff.StaffID });
                    command.Parameters.Add(new SqlParameter("@sfn", SqlDbType.NVarChar, 50) { Value = staff.FirstName });
                    command.Parameters.Add(new SqlParameter("@sln", SqlDbType.NVarChar, 50) { Value = staff.LastName });
                    command.Parameters.Add(new SqlParameter("@ss", SqlDbType.NChar, 6) { Value = staff.Sex });
                    command.Parameters.Add(new SqlParameter("@sbd", SqlDbType.Date) { Value = staff.BirthDate });
                    command.Parameters.Add(new SqlParameter("@sp", SqlDbType.NVarChar, 100) { Value = staff.StaffPosition });
                    command.Parameters.Add(new SqlParameter("@hn", SqlDbType.NVarChar, 15) { Value = staff.HouseNo });
                    command.Parameters.Add(new SqlParameter("@StrNo", SqlDbType.NVarChar, 25) { Value = staff.StreetNo });
                    command.Parameters.Add(new SqlParameter("@Sangkat", SqlDbType.NVarChar, 50) { Value = staff.Sangkat });
                    command.Parameters.Add(new SqlParameter("@Khann", SqlDbType.NVarChar, 50) { Value = staff.Khann });
                    command.Parameters.Add(new SqlParameter("@Province", SqlDbType.NVarChar, 50) { Value = staff.Province });
                    command.Parameters.Add(new SqlParameter("@ContactNumber", SqlDbType.NVarChar, 20) { Value = staff.ContactNumber });
                    command.Parameters.Add(new SqlParameter("@PersonalNumber", SqlDbType.NVarChar, 20) { Value = staff.PersonalNumber });
                    command.Parameters.Add(new SqlParameter("@HiredDate", SqlDbType.Date) { Value = staff.HiredDate });
                    command.Parameters.Add(new SqlParameter("@Salary", SqlDbType.Money) { Value = staff.Salary });
                    command.Parameters.Add(new SqlParameter("@Photo", SqlDbType.VarBinary) { Value = (object)photoData ?? DBNull.Value });
                    command.Parameters.Add(new SqlParameter("@StopWork", SqlDbType.Bit) { Value = staff.StopWork });

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

    }
}
