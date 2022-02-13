using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Data.Infrastructure
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> All();
        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Edit(T entity);
        Task<bool> Delete(int id);

    }
}
