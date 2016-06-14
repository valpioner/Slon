namespace Slon.DataAccess.Migrations
{
    using Model;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Slon.DataAccess.SlonDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Slon.DataAccess.SlonDBContext context)
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

            #region Categories & Items

            var categories = new List<Category> {
                new Category() {
                    Name = "Фрукти", DisplayOrder = 1, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Банани", Description = "This is Item1 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true},
                        new Item() { Name = "Апельсини", Description = "This is Item2 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Мандарини", Description = "This is Item3 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Овочі", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Випічка", DisplayOrder = 3, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item111", Description = "This is Item111 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item222", Description = "This is Item222 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item333", Description = "This is Item333 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Алкоголь", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Вода", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Сигарети", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Мясо", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Риба", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Солодощі", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                },

                new Category() {
                    Name = "Пріколи", DisplayOrder = 2, Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                    Items = new List<Item>() {
                        new Item() { Name = "Item11", Description = "This is Item11 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 12.95M, IsAvailable = true },
                        new Item() { Name = "Item22", Description = "This is Item22 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 13.95M, IsAvailable = true },
                        new Item() { Name = "Item33", Description = "This is Item33 description", Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                            Price = 14.95M, IsAvailable = true } }
                }
            };

            categories.ForEach(s => context.Categories.AddOrUpdate(c => c.Name, s));
            context.SaveChanges();

            #endregion
        }
    }
}
