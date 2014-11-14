namespace TestLibPrj.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using TestLibPrj.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebAPIRc.Models.BookStore>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebAPIRc.Models.BookStore context)
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
            //
            context.Books.AddOrUpdate(
                new Book { Name = "Mil Años de Soledad", Price = 343.36M  },
                new Book { Name = "C# For Dummies Special Edition", Price = 1002.35M },
                new Book() { Name = "MVC4 RC Early Release", Price = 220 },
                new Book() { Name = "Entity FrameWork", Price = 350M },
                new Book() { Name = "Azure Getting Started", Price = 540M }
            );
        }
    }
}
