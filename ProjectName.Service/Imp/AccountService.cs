using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectName.Data.EF;
using Microsoft.EntityFrameworkCore;
using ProjectName.Model.RequestViewModels;
using ProjectName.Data.Entities;

namespace ProjectName.Service.Imp
{
    public interface IAccountService
    {
        public Task<bool> SignIn(string email, string pass);
    }
    public class AccountService : IAccountService
    {
        private readonly ProjectNameDbContext _db;
        public AccountService(ProjectNameDbContext db)
        {
            _db = db;
        }
        public async Task<bool> SignIn(string email, string pass)
        {
            var result = await _db.Users.SingleOrDefaultAsync(x => x.email == email && x.pass == pass);
            return true;
        }
    }
}
