using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibraryManagementSystem.Model
{
    public class Supplier
    {
        public byte supplierID { get; set; }
        public string? supplierName { get; set; }
        public string? supplierAddr { get; set; }
        public string? supPhone1 { get; set; }
        public string? supPhone2 { get; set; }

        public static bool InsertSupplier(Supplier sup)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spInsertSupplier", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 100) { Value = sup.supplierName });
                    command.Parameters.Add(new SqlParameter("@SupplierAddress", SqlDbType.NVarChar, 255) { Value = sup.supplierAddr });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.NVarChar, 20) { Value = sup.supPhone1 });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.NVarChar, 20) { Value = sup.supPhone2 });

                    SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@OutputMessage"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Inserting Supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return isSuccess;
        }
        public static void RetrieveSupplierDetails(byte supID, Supplier sup)
        {
            string query = $"SELECT * FROM fnSearchSupplier ({supID})";
            try
            {
                SqlParameter[] parameters = { new SqlParameter("@SupplierName", supID) };

                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddRange(parameters);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            sup.supplierID = Convert.ToByte(reader["SupplierID"]);
                            sup.supplierName = reader["SupplierName"].ToString();
                            sup.supplierAddr = reader["SupplierAddress"].ToString();
                            sup.supPhone1 = reader["PhoneNumber1"].ToString();
                            sup.supPhone2 = reader["PhoneNumber2"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
        }
        public static List<Supplier> GetAllSuppler(string query)
        {
            List<Supplier> suppliers = new List<Supplier>();
            //string query = "SELECT * FROM vGetAllSuppliers";
            try
            {

                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Supplier sup = new Supplier();

                                sup.supplierID = Convert.ToByte(reader["SupplierID"]);
                                sup.supplierName = reader["SupplierName"].ToString();
                                sup.supplierAddr = reader["SupplierAddress"].ToString();
                                sup.supPhone1 = reader["PhoneNumber1"].ToString();
                                sup.supPhone2 = reader["PhoneNumber2"].ToString();

                                suppliers.Add(sup);
                            }
                        }
                        //if (reader.Read())
                        //{
                        //    sup.supplierName = reader["SupplierName"].ToString();
                        //    sup.supplierAddr = reader["SupplierAddress"].ToString();
                        //    sup.supPhone1 = reader["PhoneNumber1"].ToString();
                        //    sup.supPhone2 = reader["PhoneNumber2"].ToString();
                        //}
                    }
                }
            }
            catch (Exception ex)
            {
                Helper.HandleException(ex);
            }
            return suppliers;
        }
        public static bool SearchSupplier(string searchTerm, DataGridView dgv)
        {
            bool result = false;
            dgv.Rows.Clear();
            Supplier sup = new Supplier();
            string query = "SELECT * FROM fnSearchSupplier (N'" + searchTerm + "');";

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
                                sup.supplierID = Convert.ToByte(reader["SupplierID"]);
                                sup.supplierName = reader["SupplierName"].ToString();
                                sup.supplierAddr = reader["SupplierAddress"].ToString();
                                sup.supPhone1 = reader["PhoneNumber1"].ToString();
                                sup.supPhone2 = reader["PhoneNumber2"].ToString();
                                dgv.Rows.Add(sup.supplierID, sup.supplierName, sup.supplierAddr, sup.supPhone1, sup.supPhone2);
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
        public static bool UpdateSupplierByID(Supplier sup)
        {
            bool isSuccess = false;

            try
            {
                using (SqlConnection connection = Helper.OpenConnection())
                using (SqlCommand command = new SqlCommand("spUpdateSupplierByID", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    // Add parameters
                    command.Parameters.Add(new SqlParameter("@SupplierID", SqlDbType.TinyInt) { Value = sup.supplierID });
                    command.Parameters.Add(new SqlParameter("@SupplierName", SqlDbType.NVarChar, 100) { Value = sup.supplierName });
                    command.Parameters.Add(new SqlParameter("@SupplierAddress", SqlDbType.NVarChar, 255) { Value = sup.supplierAddr });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber1", SqlDbType.NVarChar, 20) { Value = sup.supPhone1 });
                    command.Parameters.Add(new SqlParameter("@PhoneNumber2", SqlDbType.NVarChar, 20) { Value = sup.supPhone2 });


                    SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.Bit) { Direction = ParameterDirection.Output };
                    command.Parameters.Add(outputParam);

                    command.ExecuteNonQuery();

                    isSuccess = Convert.ToBoolean(command.Parameters["@OutputMessage"].Value);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Updating Supplier: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isSuccess;
        }
    }
}
