using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizalPOS.Domain.Classes
{
    public class Product
    {
        public int Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public Category Category { get; set; }



    }

    public class DeletedProduct
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public DateTime DateDeleted { get; set; }
        public string Barcode { get; set; }
        public double UnitPrice { get; set; }
        public double UnitCost { get; set; }
        public Category Category { get; set; }
    }
}
