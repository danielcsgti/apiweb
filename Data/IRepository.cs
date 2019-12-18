using System.Collections.Generic;

namespace appWebApi.Data
{
    public interface IRepository<T>
    {
        bool CreatePost(T entity);
        T GetId(long id);
        IEnumerable<T> GetAll();
        bool Update(T entity);
        bool Delete(T entity);

    }
}
