using Slon.Model;
using Slon.Persistence;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Slon.DataAccess.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private SlonDBContext context;

        public CategoryRepository(SlonDBContext context)
        {
            this.context = context;
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return context.Categories.Find(id);
        }

        public void Create(Category category)
        {
            context.Categories.Add(category);
        }

        public void Update(Category category)
        {
            context.Entry(category).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var item = context.Categories.Find(id);
            if (item != null)
            {
                context.Categories.Remove(item);
            }
        }
    }
}
