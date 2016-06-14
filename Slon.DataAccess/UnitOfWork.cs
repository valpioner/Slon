using Slon.DataAccess.Repositories;
using Slon.Model;
using Slon.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Slon.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private SlonDBContext context;
        private ItemRepository itemRepository;
        private CategoryRepository categoryRepository;

        public UnitOfWork(/*string connectionString*/)
        {
            context = new SlonDBContext(/*connectionString*/);
        }

        public IRepository<Item> Items
        {
            get
            {
                if (itemRepository == null)
                {
                    itemRepository = new ItemRepository(context);
                }
                return itemRepository;
            }
        }

        public IRepository<Category> Categories
        {
            get
            {
                if (categoryRepository == null)
                {
                    categoryRepository = new CategoryRepository(context);
                }
                return categoryRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}