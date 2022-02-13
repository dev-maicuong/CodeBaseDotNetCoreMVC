using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ProjectName.Data.EF;

namespace ProjectName.Data.Infrastructure
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected ProjectNameDbContext _context;
        protected DbSet<T> dbSet;
        protected ILogger _logger;

        public GenericRepository(ProjectNameDbContext context, ILogger logger)
        {
            _context = context;
            _logger = logger;
            dbSet = _context.Set<T>();
        }

        public virtual async Task<bool> Add(T entity)
        {
            var result = await dbSet.AddAsync(entity);
            return true;
        }

        public virtual async Task<IEnumerable<T>> All()
        {
            var result = await dbSet.ToListAsync();
            return result;
        }

        public virtual Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public virtual Task<bool> Edit(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> GetById(int id)
        {
            var result = await dbSet.FindAsync(id);
            return result;
        }
    }
}
