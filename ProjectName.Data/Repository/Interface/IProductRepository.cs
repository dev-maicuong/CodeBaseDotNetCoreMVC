using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Infrastructure;
using ProjectName.Data.Entities;
using System.Threading.Tasks;

namespace ProjectName.Data.Repository.Interface
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<string> GetName(int id);
    }
}
