using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ProjectName.Service.Imp
{
    public interface IFileService
    {
        public Task<List<string>> SaveFile(IFormFile[] files, string path);
    }
    public class FileService : IFileService
    {
        public async Task<List<string>> SaveFile(IFormFile[] files, string path)
        {
            List<string> listPathFile = new List<string>();
            if (files != null)
            {
                foreach (var item in files)
                {
                    // Tao duong dan file
                    var filePath = Path.Combine(path, "uploads", item.FileName);
                    listPathFile.Add(filePath);

                    // Tao file
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        // Coppy noi dung tai ve tren header vao file tao
                        await item.CopyToAsync(fileStream);
                    }
                }
                return listPathFile;
            }
            else return null;
        }
    }
}
