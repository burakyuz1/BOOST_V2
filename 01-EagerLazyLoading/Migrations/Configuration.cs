namespace _01_EagerLazyLoading.Migrations
{
    using _01_EagerLazyLoading.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_01_EagerLazyLoading.Data.AppDbContext>
    {
        public Configuration() => AutomaticMigrationsEnabled = false;
        protected override void Seed(_01_EagerLazyLoading.Data.AppDbContext context)
        {
            if (!context.Categories.Any())
            {
                context.Categories.Add(new Models.Category()
                {
                    CategoryName = "Daily Products",
                    Products = new List<Product>(){
                        new Product()
                        {
                            ProductName = "Milk",
                            UnitPrice = 20
                        },
                         new Product()
                        {
                            ProductName = "Bread",
                            UnitPrice = 2.5m
                        }
                    }
                });
                context.Categories.Add(new Models.Category()
                {
                    CategoryName = "Meat Products",
                    Products = new List<Product>(){
                        new Product()
                        {
                            ProductName = "Chicken Meat",
                            UnitPrice = 35.4m
                        },
                         new Product()
                        {
                            ProductName = "Cow Meat",
                            UnitPrice = 99.3m
                        }
                    }
                });
            }
        }
    }
}
