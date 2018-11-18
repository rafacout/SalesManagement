using System.Collections.Generic;

namespace SalesManagement.Application.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        void Add(T obj);

        T GetById(int id);

        IEnumerable<T> GetAll();

        void Update(T obj);

        void Remove(T obj);

        void Dispose();
    }
}
