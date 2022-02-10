using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using ProjectName.Model.Validation;

namespace ProjectName.Model.RequestViewModels
{
    public class RequestFileModel
    {
        [Display(Name ="Chọn các file cần thêm: ")]
        [CheckFileImage]
        public IFormFile[] files { set; get; }
    }
}
