using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjectName.Data.Entities
{
    public class Product
    {
        public int productId { set; get; }
        public string productName { set; get; }
        [ForeignKey("userId")]
        public User user { set; get; }
        public int? userId { set; get; }
    }
}
