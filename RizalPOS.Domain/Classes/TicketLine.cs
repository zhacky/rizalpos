using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class TicketLine
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public double ItemPrice { get; set; }
        public double Quantity { get; set; }
        public double TotalAmount { get; set; }

    }
}
