using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class StockHistory
    {
        public int Id { get; set; }
        public DateTime StockDate { get; set; }
        public int Reason { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public double Units { get; set; }
        public double NewPrice { get; set; }
        public double NewCost { get; set; }
        

    }
}
