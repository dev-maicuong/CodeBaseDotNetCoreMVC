using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectName.Service.Imp
{
    public interface IAccountService
    {
        public Task<bool> SignIn(string email, string pass);
    }
}
