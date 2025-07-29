using System.Collections.Generic;

namespace DataAccessLayer.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Delete(T entity);
        List<T> GetAll();
        T GetById(int id);
        void Insert(T entity);
        void Update(T entity);
    }
}