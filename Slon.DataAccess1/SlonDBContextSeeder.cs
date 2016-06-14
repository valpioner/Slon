using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Slon.Model;

namespace Slon.DataAccess
{
    public class SlonDBContextSeeder : DropCreateDatabaseIfModelChanges<SlonDBContext>
    {
        protected override void Seed(SlonDBContext context)
        {
            Category category1 = new Category()
            {
                Name = "Category1",
                Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                DisplayOrder = 1,
                Items = new List<Item>()
                {
                    new Item()
                    {
                        Name = "Item1", Description = "This is Item1 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 12.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item2", Description = "This is Item2 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 13.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item3", Description = "This is Item3 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 14.95M, IsAvailable = true
                    }
                }
            };

            Category category2 = new Category()
            {
                Name = "Category2",
                Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                DisplayOrder = 2,
                Items = new List<Item>()
                {
                    new Item()
                    {
                        Name = "Item11", Description = "This is Item11 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 12.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item22", Description = "This is Item22 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 13.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item33", Description = "This is Item33 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 14.95M, IsAvailable = true
                    }
                }
            };

            Category category3 = new Category()
            {
                Name = "Category3",
                Img = "https://veggiesandmore.com/wp-content/uploads/2016/03/fruit-copia-200x200.jpg",
                DisplayOrder = 3,
                Items = new List<Item>()
                {
                    new Item()
                    {
                        Name = "Item11", Description = "This is Item11 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 12.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item22", Description = "This is Item22 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 13.95M, IsAvailable = true
                    },
                    new Item()
                    {
                        Name = "Item33", Description = "This is Item33 description",
                        Img = "http://cloudfall.com.ua/image/cache/catalog/flavors/apple-200x200.jpg",
                        Price = 14.95M, IsAvailable = true
                    }
                }
            };

            //context.Categories.Add(category1);
            //context.Categories.Add(category2);
            //context.Categories.Add(category3);
            //base.Seed(context);
        }
    }
}