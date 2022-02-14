using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectName.Web.Models;
using ProjectName.Data.EF;
using ProjectName.Service.Imp;
using ProjectName.Model.RequestViewModels;

namespace ProjectName.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly IAccountService _accountService;
        public ProductController(IProductService productService, IAccountService accountService)
        {
            _productService = productService;
            _accountService = accountService;
        }
        public async Task<IActionResult> Index()
        {
            var product = await _productService.GetAllAsync();

            return View(product);
        }
    }
}
