using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectName.Data.Entities
{
    public class UserDetail
    {
        public int userDetailId { set; get; }
        public DateTime createDay { set; get; }
        public DateTime updateDay { set; get; }
        //reference
        public User user { set; get; }
    }
}
