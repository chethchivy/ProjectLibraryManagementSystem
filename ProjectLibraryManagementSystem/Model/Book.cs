using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Book
    {
        public int bookCode { get; set; }
        public string? bookTitle { get; set; }
        public string? genres { get; set; }
        public string? author { get; set; }
        public int publishYear { get; set; }
        public byte bookQty { get; set; }
        public decimal lateFee { get; set; }
        public decimal price { get; set; }

        //public static bool InsertBook(Book book)
        //{
        //    bool isSuccess = false;
        //    try
        //    {
        //        using (SqlConnection connection = Helper.OpenConnection())
        //        using (SqlCommand command = new SqlCommand("spInsertBook", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255) { Value = book.bookTitle });
        //            command.Parameters.Add(new SqlParameter("@Genres", SqlDbType.NVarChar, 50) { Value = book.genres });
        //            command.Parameters.Add(new SqlParameter("@Author", SqlDbType.NVarChar, 50) { Value = book.author });
        //            command.Parameters.Add(new SqlParameter("@PublishYear", SqlDbType.SmallInt) { Value = book.publishYear });
        //            command.Parameters.Add(new SqlParameter("@BookQty", SqlDbType.TinyInt) { Value = book.bookQty });
        //            command.Parameters.Add(new SqlParameter("@LateFee", SqlDbType.Money) { Value = book.lateFee });
        //            command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money) { Value = book.price });

        //            SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.Bit) { Direction = ParameterDirection.Output };
        //            command.Parameters.Add(outputParam);

        //            command.ExecuteNonQuery();

        //            isSuccess = Convert.ToBoolean(command.Parameters["@OutputMessage"].Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Inserting Book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return isSuccess;
        //}
        //public static void RetrieveBookDetails(string? bookTitle, Book book)
        //{
        //    string query = "SELECT * FROM fnSearchBookByBookTitle(N'%" + bookTitle + "%');";
        //    try
        //    {
        //        SqlParameter[] parameters = { new SqlParameter("@BookTitle", bookTitle) };

        //        using (SqlConnection connection = Helper.OpenConnection())
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.CommandType = CommandType.Text;
        //            command.Parameters.AddRange(parameters);

        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    book.bookCode = Convert.ToInt32(reader["BookCode"]);
        //                    book.bookTitle = reader["BookTitle"].ToString();
        //                    book.genres = reader["Genres"].ToString();
        //                    book.author = reader["Author"].ToString();
        //                    book.publishYear = Convert.ToInt16(reader["PublishYear"]);
        //                    book.bookQty = Convert.ToByte(reader["BookQty"]);
        //                    book.lateFee = Convert.ToDecimal(reader["LateFee"]);
        //                    book.price = Convert.ToDecimal(reader["Price"]);
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Helper.HandleException(ex);
        //    }
        //}
        //public static bool SearchBooks(string searchTerm, ListBox listBox)
        //{
        //    listBox.Items.Clear();
        //    bool result = false;
        //    string query = "SELECT * FROM fnSearchBookByBookTitle (N'%" + searchTerm + "%');";

        //    try
        //    {
        //        using (SqlConnection connection = Helper.OpenConnection())
        //        using (SqlCommand command = new SqlCommand(query, connection))
        //        {
        //            command.CommandType = CommandType.Text;
        //            command.Parameters.AddWithValue("@SearchTerm", searchTerm);
        //            using (SqlDataReader reader = command.ExecuteReader())
        //            {
        //                if (reader.HasRows)
        //                {
        //                    while (reader.Read())
        //                    {
        //                        listBox.Items.Add(reader["BookTitle"].ToString()!);
        //                    }
        //                    result = true;
        //                }
        //                else
        //                {
        //                    result = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return result;
        //}
        //public static bool UpdateBookByBookCode(Book book)
        //{
        //    bool isSuccess = false;

        //    try
        //    {
        //        using (SqlConnection connection = Helper.OpenConnection())
        //        using (SqlCommand command = new SqlCommand("spUpdateBookByBookCode", connection))
        //        {
        //            command.CommandType = CommandType.StoredProcedure;

        //            // Add parameters
        //            command.Parameters.Add(new SqlParameter("@BookCode", SqlDbType.Int)).Value = book.bookCode;
        //            command.Parameters.Add(new SqlParameter("@BookTitle", SqlDbType.NVarChar, 255)).Value = book.bookTitle;
        //            command.Parameters.Add(new SqlParameter("@Genres", SqlDbType.NVarChar, 50)).Value = book.genres;
        //            command.Parameters.Add(new SqlParameter("@Author", SqlDbType.NVarChar, 50)).Value = book.author;
        //            command.Parameters.Add(new SqlParameter("@PublishYear", SqlDbType.SmallInt)).Value = book.publishYear;
        //            command.Parameters.Add(new SqlParameter("@BookQty", SqlDbType.TinyInt)).Value = book.bookQty;
        //            command.Parameters.Add(new SqlParameter("@LateFee", SqlDbType.Money)).Value = book.lateFee;
        //            command.Parameters.Add(new SqlParameter("@Price", SqlDbType.Money)).Value = book.price;

        //            SqlParameter outputParam = new SqlParameter("@OutputMessage", SqlDbType.Bit) { Direction = ParameterDirection.Output };
        //            command.Parameters.Add(outputParam);

        //            command.ExecuteNonQuery();

        //            isSuccess = Convert.ToBoolean(command.Parameters["@OutputMessage"].Value);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error Updating Book: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //    return isSuccess;
        //}
        
    }
}
