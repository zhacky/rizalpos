using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class Ticket
    {
        public int Id { get; set; }
        public User User { get; set; }
        public List<TicketLine> TicketLines { get; set; }
        public Customer Customer { get; set; }
        public DateTime TransactDate { get; set; }
        public double TotalAmount { get; set; }
        public double CashGiven { get; set; }
        public double ChangeReceived { get; set; }
        
    }
}
