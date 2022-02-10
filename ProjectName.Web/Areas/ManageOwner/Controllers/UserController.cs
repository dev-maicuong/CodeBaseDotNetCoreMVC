using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectName.Web.Areas.ManageOwner.Controllers
{
    [Area("ManageOwner")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
