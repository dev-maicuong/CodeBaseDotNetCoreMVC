using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace ProjectName.Model.RequestViewModels
{
    public class RequestRegister
    {
        [Display(Name = "Email :")]
        public string email { set; get; }

        [Display(Name = "Mật khẩu :")]
        public string pass { set; get; }


        [Display(Name = "Tên :")]
        public string lastName { set; get; }

        [Display(Name = "Họ :")]
        public string firstName { set; get; }
    }
}
