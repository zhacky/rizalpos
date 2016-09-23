using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class StockLevel
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public double Security { get; set; }
        public double Maximum { get; set; }
    }
}
