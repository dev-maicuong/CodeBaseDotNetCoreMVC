﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ProjectName.Data.EF;
using Microsoft.EntityFrameworkCore;

namespace ProjectName.Service.Imp
{
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