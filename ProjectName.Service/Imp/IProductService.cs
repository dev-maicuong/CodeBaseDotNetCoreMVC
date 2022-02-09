﻿using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Model.Dtos;
using System.Threading.Tasks;

namespace ProjectName.Service.Imp
{
    public interface IProductService
    {
        public Task<List<ProductDto>> GetAllAsync();
    }
}
