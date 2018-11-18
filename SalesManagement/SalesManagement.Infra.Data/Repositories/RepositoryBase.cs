using SalesManagement.Domain.Interfaces;
using System;
using System.Collections.Generic;
using SalesManagement.Infra.Data.Context;
using System.Linq;

namespace SalesManagement.Infra.Data.Repositories
{
    public class RepositoryBase<T> : IDisposable, IRepositoryBase<T> where T : class
    {
        protected SalesManagementContext dbContext = new SalesManagementContext();


        public void Add(T obj)
        {
            dbContext.Set<T>().Add(obj);
            dbContext.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return dbContext.Set<T>().ToList();
        }

        public T GetById(long id)
        {
            return dbContext.Set<T>().Find(id);
        }

        public void Remove(T obj)
        {
            dbContext.Set<T>().Remove(obj);
            dbContext.SaveChanges();
        }

        public void Update(T obj)
        {
            dbContext.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
