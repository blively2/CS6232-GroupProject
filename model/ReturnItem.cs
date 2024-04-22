using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaSoGood.Model
{
    public class ReturnItem
    {
        public int ReturnItemID { get; set; }
        public int ReturnTransactionID { get; set; }
        public int RentalItemID { get; set; }
        public int FurnitureID { get; set; }
        public int QuantityReturned { get; set; }
    }
}
