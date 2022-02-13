using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Model.Dtos;
using ProjectName.Data.EF;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectName.Data.Infrastructure;

namespace ProjectName.Service.Imp
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetAllAsync();
        public Task<List<ProductDto>> TestRUOWGetAllAsync();
    }
    public class ProductService: IProductService
    {
        private readonly ProjectNameDbContext _db;
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(ProjectNameDbContext db, IUnitOfWork unitOfWork)
        {
            _db = db;
            _unitOfWork = unitOfWork;
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            // Dùng select để tham chiếu đến các đối tượng vẫn tạo ra left join
            var list = await _db.Products.Select(x => new ProductDto
            {
                productName = x.productName,
                userName = $"{x.user.firstName} {x.user.lastName}"
            }).ToListAsync();

            return list;
        }

        public async Task<List<ProductDto>> TestRUOWGetAllAsync()
        {
            var list = await _unitOfWork.product.All();
            return list.Select(x=> new ProductDto {
                productName = x.productName,
                userName = $"1"
            }).ToList();
        }
    }
}
