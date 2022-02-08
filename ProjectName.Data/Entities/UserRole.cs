using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ProjectName.Data.Entities
{
    public class UserRole
    {
        [ForeignKey("userId")]
        public User user { set; get; }
        [ForeignKey("roleId")]
        public Role Role { set; get; }
        public int userId { set; get; }
        public int roleId { set; get; }
    }
}
