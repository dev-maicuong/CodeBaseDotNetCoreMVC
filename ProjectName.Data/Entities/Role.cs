using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Data.Entities
{
    public class Role
    {
        public int roleId { set; get; }
        public string roleName { set; get; }
        public string description { set; get; }
        //reference
        List<UserRole> userRoles { set; get; }
    }
}
