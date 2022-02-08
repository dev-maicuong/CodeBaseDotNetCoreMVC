using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Common.Model;
using ProjectName.Data.EF;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Service.Imp
{
    public class ProductService: IProductService
    {
        private readonly ProjectNameDbContext _db;
        public ProductService(ProjectNameDbContext db)
        {
            _db = db;
        }

        public async Task<List<ProductModel>> GetAllAsync()
        {
            var list = await _db.Products.Select(x => new ProductModel
            {
                productName = x.productName,
                userName = $"{x.user.firstName} {x.user.lastName}"
            }).ToListAsync();

            return list;
        }
    }
}
