using RizalPOS.Domain.Classes;

namespace RizalPOS.Domain.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<RizalPOS.Domain.Context.PosContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(RizalPOS.Domain.Context.PosContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            
            //-- create encryption tool
            //var encryptor = new Encryption();
            //var encryptedPassword = encryptor.GetEncrypted("admin");
            //-- create locations
            //context.Locations.AddOrUpdate(
            //    c=>c.Name,
            //    new Location { Name = "Main",Address = "Gomiza Ave., Marawi City"}
            //    );
            //-- create user
            //context.Users.AddOrUpdate(
            //    c=>c.Username,
            //    new User { Username = "admin", Password = encryptedPassword,Role = Role.Administrator}
            //    );

            //-- create default customer
            //context.Customers.AddOrUpdate(
           //   c=>c.CustomerCode,
           //     new Customer { CustomerCode = "A1",EntryDate = DateTime.Now,Name = "Cash"}
            //    );
            //-- create categories
            //context.Categories.AddOrUpdate(
            //    c => c.Name,
            //    new Category {Name = "Beverage"},
            //    new Category { Name = "Food"},
            //    new Category {Name = "General"},
            //    new Category { Name = "Office Supplies"}
            //    );
            //-- save changes
            //context.SaveChanges();
            //-- create dictionary
            //var category = context.Categories.FirstOrDefault(c => c.Name == "Office Supplies" );
            //var categories = context.Categories.ToDictionary(c => c.Name, c => c.Id);

            //if (category != null)
            
                
            //context.Products.AddOrUpdate(
            //        p => p.Barcode,
            //        new Product
            //        {
            //            Barcode = "4902505089213",
            //            Name = "PILOT Wytebord Marker Refill Ink",
            //            UnitCost = 20,
            //            UnitPrice = 45,
            //            Category =  context.Categories.FirstOrDefault(c=>c.Id == category.Id)
            //            //Category_Id = categories["Office Supplies"]
            //        }
            //        );
            //----endif
            
            
        }
    }
}
