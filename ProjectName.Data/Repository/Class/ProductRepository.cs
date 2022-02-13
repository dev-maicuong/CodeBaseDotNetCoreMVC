using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Infrastructure;
using ProjectName.Data.Entities;
using ProjectName.Data.Repository.Interface;
using System.Threading.Tasks;
using ProjectName.Data.EF;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Data.Repository.Class
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ProjectNameDbContext context, ILogger logger) : base (context,logger)
        {

        }
        public override async Task<IEnumerable<Product>> All()
        {
            try
            {
                return await dbSet.ToListAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex,"{Repository} All method error", typeof(ProductRepository));
                return new List<Product>();
            }
        }
        public override async Task<bool> Edit(Product entity)
        {
            try
            {
                var product = await dbSet.FirstOrDefaultAsync(x => x.productId == entity.productId);
                if (product == null) return false;
                product.productName = entity.productName;
                product.userId = entity.userId;
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repository} All method error", typeof(ProductRepository));
                return false;
            }
        }
        public override async Task<bool> Delete(int id)
        {
            try
            {
                var product = await dbSet.FirstOrDefaultAsync(x => x.productId == id);
                if (product == null) return false;
                dbSet.Remove(product);
                return true;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "{Repository} All method error", typeof(ProductRepository));
                return false;
            }
        }
        public Task<string> GetName(int id)
        {
            throw new NotImplementedException();
        }
    }
}
