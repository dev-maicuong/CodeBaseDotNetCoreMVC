using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectName.Model.RequestViewModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;
using ProjectName.Service.Imp;

namespace ProjectName.Web.Controllers
{
    public class FileController : Controller
    {
        private readonly IWebHostEnvironment _enviroment;
        private readonly IFileService _fileService;
        public FileController(IWebHostEnvironment enviroment, IFileService fileService)
        {
            _enviroment = enviroment;
            _fileService = fileService;
        }
        public IActionResult ChoseFile()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ChoseFile(RequestFileModel requestFileModel)
        {
            if(!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Vui lòng kiểm tra lỗi và đăng nhập lại!");
                return View();
            }
            var listPathFile = await _fileService.SaveFile(requestFileModel.files, _enviroment.WebRootPath);
            
            return View();
        }
        public async Task<FileResult> GetFile(string fileName)
        {
            var filePath = Path.Combine(_enviroment.WebRootPath, "uploads", fileName);
            var bytes = await System.IO.File.ReadAllBytesAsync(filePath);
            //var contentType = "application/pdf";
            return File(bytes, "image/jpg");
            //return File(bytes, contentType);
        }

    }
}
