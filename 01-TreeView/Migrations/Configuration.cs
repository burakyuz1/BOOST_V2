namespace _01_TreeView.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<_01_TreeView.TreeViewDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(_01_TreeView.TreeViewDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            if (!context.Places.Any())
            {
                context.Places.Add(new Place("World") {
                Children = new List<Place>()
                {
                    new Place("Turkey")
                    {
                        Children = new List<Place>()
                        {
                            new Place("Kars"),
                            new Place("Hakkari"),
                            new Place("Ankara")
                            {
                                Children = new List<Place>()
                                {
                                    new Place("Polatli"),
                                    new Place("Golbasi"),
                                    new Place("Cankaya")
                                    {
                                        Children = new List<Place>()
                                        {
                                            new Place("Bilkent"),
                                            new Place("Cayyolu")
                                            {
                                                Children = new List<Place>()
                                                {
                                                    new Place("Yasamkent Mah."),
                                                    new Place("Koru Mah."),
                                                    new Place("Dodurga Mah.")
                                                }
                                            },
                                            new Place("Kizilay"),
                                        }
                                    }
                                }
                            }
                        }
                    },
                    new Place("USA")
                    {
                        Children = new List<Place>()
                        {
                            new Place("California"),
                            new Place("Texas"),
                            new Place("Pensilvania")
                        }
                    }
                }
                });
            }
        }
    }
}
