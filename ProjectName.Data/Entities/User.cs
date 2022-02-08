using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Data.Entities
{
    public class User
    {
        public int userId { set; get; }
        public string email { set; get; }
        public string pass { set; get; }
        public string firstName { set; get; }
        public string lastName { set; get; }
        //reference
        public UserDetail userDetail { set; get; }
        public List<UserRole> userRoles { set; get; }
        public List<Product> products { set; get; }



    }
}
