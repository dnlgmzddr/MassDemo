using WebApplication1.Models;

namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApplication1.Models.MassContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WebApplication1.Models.MassContext context)
        {

            context.Products.AddOrUpdate(new Product
            {
                Nombre = "Sample 1",
                Precio = 10,
                Referencia = "S1",

            },

            new Product
            {
                Nombre = "Sample 2",
                Precio = 20,
                Referencia = "S2",

            },
                new Product
                {
                    Nombre = "Sample 3",
                    Precio = 30,
                    Referencia = "S3",

                },
            new Product
            {
                Nombre = "Sample 4",
                Precio = 40,
                Referencia = "S4",

            });




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
        }
    }
}
