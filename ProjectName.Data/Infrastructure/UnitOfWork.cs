using ProjectName.Data.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectName.Data.EF;
using Microsoft.Extensions.Logging;
using ProjectName.Data.Repository.Class;

namespace ProjectName.Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private ProjectNameDbContext _context;
        private ILogger _logger;
        public IProductRepository product { private set; get; }

        public UnitOfWork(ProjectNameDbContext context, ILoggerFactory logger)
        {
            _context = context;
            _logger = logger.CreateLogger("logs");
            product = new ProductRepository(_context, _logger);
        }
        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
