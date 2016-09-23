using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.Entity;
using RizalPOS.Domain.Classes;

namespace RizalPOS.Domain.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public sealed class PosContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<TicketLine> Ticketlines { get; set; }
        public DbSet<DeletedProduct> DeletedProducts { get; set; }
        public DbSet<StockCurrent>  StockCurrents { get; set; }
        public DbSet<StockHistory> StockHistories { get; set; }
        public DbSet<StockLevel> StockLevels { get; set; }


        public PosContext()
            : base("server=localhost;port=3306;database=rizalpos;uid=root;password=feedback")
        {
            Configuration.LazyLoadingEnabled = true;
        }
    }
}
