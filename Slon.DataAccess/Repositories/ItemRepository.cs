using Slon.Model;
using Slon.Persistence;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Slon.DataAccess.Repositories
{
    public class ItemRepository : IRepository<Item>
    {
        private SlonDBContext context;

        public ItemRepository(SlonDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Item> GetAll()
        {
            return context.Items.ToList();
        }

        public Item GetByID(int id)
        {
            return context.Items.Find(id);
        }

        public void Create(Item item)
        {
            context.Items.Add(item);
        }

        public void Update(Item entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var item = context.Items.Find(id);
            if (item != null)
            {
                context.Items.Remove(item);
            }
        }
    }
}