using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaSoGood.Model
{
    public class ReturnTransaction
    {
        public int ReturnTransactionID { get; set; }
        public int EmployeeID { get; set; }
        public int MemberID { get; set; }
        public DateTime ReturnDate { get; set; }
        public decimal ReturnAmount { get; set; }
        public decimal FineAmount { get; set; }
        public List<ReturnItem> ReturnItems { get; set; } = new List<ReturnItem>();

    }
}
