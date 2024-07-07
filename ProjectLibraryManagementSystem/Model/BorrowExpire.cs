using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class BorrowExpire
    {
        public int borrowExpID {  get; set; }
        public DateTime borrowExpDate { get; set; }
        public int borrowID { get; set; }
        public int memberID { get; set; }
        public string? bookTitle { get; set; }

        public static DataTable LoadData()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM vBorrowExpire";
            dataTable = Helper.ReadData(query);
            return dataTable;
        }
        public static DataTable Search(int memberID)
        {
            string query = $"SELECT * FROM fnSearchByMemberID ({memberID});";
            DataTable dataTable = Helper.ReadData( query);
            return dataTable;
        }
        public static void Update()
        {

        }
    }
}
