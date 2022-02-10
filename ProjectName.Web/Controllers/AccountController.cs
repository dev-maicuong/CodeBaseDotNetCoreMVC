using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectName.Model.RequestViewModels;

namespace ProjectName.Web.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(RequestLoginModel requestLoginModel)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("","Vui lòng kiểm tra lỗi và đăng nhập lại!");
                return View(requestLoginModel);
            }
            return View(requestLoginModel);
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(RequestRegister requestRegister)
        {
            if(!ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
