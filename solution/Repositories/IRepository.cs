using System.Collections.Generic;

namespace Repositories
{
    public interface IRepository<T> where T : Entity
    {
        T Get(T entity);

        void Add(T entity);

        List<T> SortById(List<T> collection);

    }
}
