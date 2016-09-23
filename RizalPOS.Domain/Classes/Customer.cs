using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CustomerCode { get; set; }
        public DateTime EntryDate { get; set; }
    }
}
