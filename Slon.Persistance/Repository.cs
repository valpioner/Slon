//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;

//namespace Slon.Persistence
//{
//    public class Repository<T> where T : class
//    {
//        internal SlonDBContext context;
//        internal DbSet<T> dbSet;

//        public Repository(SlonDBContext context)
//        {
//            this.context = context;
//            this.dbSet = context.Set<TEntity>();
//        }

//        public ReadOnlyRepository(ApplicationDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public virtual T GetById(int id)
//        {
//            return _dbContext.Set<T>().Find(id);
//        }

//        public virtual IEnumerable<T> List()
//        {
//            return _dbContext.Set<T>().AsEnumerable();
//        }

//        public virtual IEnumerable<T> List(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
//        {
//            return _dbContext.Set<T>()
//                   .Where(predicate)
//                   .AsEnumerable();
//        }

//        public void Insert(T entity)
//        {
//            _dbContext.Set<T>().Add(entity);
//            _dbContext.SaveChanges();
//        }

//        public void Update(T entity)
//        {
//            _dbContext.Entry(entity).State = EntityState.Modified;
//            _dbContext.SaveChanges();
//        }

//        public void Delete(T entity)
//        {
//            _dbContext.Set<T>().Remove(entity);
//            _dbContext.SaveChanges();
//        }
//    }
//}