using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibraryManagementSystem.Model
{
    public class Address
    {
        public int ProID {  get; set; }
        public string? ProName { get; set; }
        public int DisID { get; set; }
        public string? DisName { get; set; }
        public int ComID { get; set; }
        public string? ComName { get; set; }
    }
}
