using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectName.Web.Models;
using ProjectName.Data.EF;
using ProjectName.Service.Imp;

namespace ProjectName.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index()
        {
            var product = await _productService.TestRUOWGetAllAsync();

            return View(product);
        }
    }
}
