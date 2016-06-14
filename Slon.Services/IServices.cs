using Slon.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slon.Services
{
    public interface IServices<T> where T : class
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        int Create(T category);
        bool Update(int id, T category);
        bool Delete(int id);
    }
}
