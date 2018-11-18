using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement.Domain.Interfaces
{
    public interface IRepositoryBase<T> where T : class
    {
        void Add(T obj);

        T GetById(long id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
