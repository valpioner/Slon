using Slon.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slon.Persistence
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Item> Items { get; }
        IRepository<Category> Categories { get; }
        void Save();
    }
}
