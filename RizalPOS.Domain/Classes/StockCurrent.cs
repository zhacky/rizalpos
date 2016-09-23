using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class StockCurrent
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int ProductId { get; set; }
        public double Units { get; set; }

    }
}
