using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Slon.Model;
//using Slon.Model.Enums;

namespace Slon.DataAccess
{
    public class SlonDBContext : DbContext
    {
        //SET CONNECTION STRING NAME FOR DataBase Name :
        public SlonDBContext() : base("SlonDB") { }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<ItemOrder> ItemOrders { get; set; }
        public DbSet<ItemSize> ItemSizes { get; set; }
        public DbSet<ItemType> ItemTypes { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //self-referencing accosiations:
            modelBuilder.Entity<Category>()
                .HasOptional(c => c.ParentCategory)
                .WithMany()
                .HasForeignKey(pc => pc.ParentCategoryId);

            //many - to - namy approach
            //modelBuilder.Entity<Item>()
            //    .HasMany(t => t.Orders)
            //    .WithMany(t => t.Items)
            //    .Map(m => 
            //    {
            //        m.ToTable("ItemOrders");
            //        m.MapLeftKey("ItemId");
            //        m.MapRightKey("OrderId");
            //    });

            //modelBuilder.Entity<Item>().MapToStoredProcedures();// - if want to use SP instead

            base.OnModelCreating(modelBuilder);
        }
    }
}