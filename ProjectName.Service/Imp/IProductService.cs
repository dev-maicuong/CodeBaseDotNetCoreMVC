using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Common.Model;
using System.Threading.Tasks;

namespace ProjectName.Service.Imp
{
    public interface IProductService
    {
        public Task<List<ProductModel>> GetAllAsync();
    }
}
