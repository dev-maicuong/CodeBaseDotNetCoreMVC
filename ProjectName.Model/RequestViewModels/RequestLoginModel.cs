using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectName.Model.RequestViewModels
{
    public class RequestLoginModel
    {
        [Display(Name = "Email: ")]
        [EmailAddress(ErrorMessage ="Vui lòng nhập đúng định dạng email!")]
        public string email { set; get; }

        [Display(Name ="Mật khẩu: ")]
        [Required(ErrorMessage ="Mật khẩu không được để trống!")]
        [DataType(DataType.Password)]
        public string pass { set; get; }
    }
}
