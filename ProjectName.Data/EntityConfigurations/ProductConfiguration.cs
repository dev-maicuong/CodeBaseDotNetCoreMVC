using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Data.Entities;

namespace ProjectName.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.productId);
            builder.HasOne(x => x.user).WithMany(x => x.products).OnDelete(DeleteBehavior.SetNull);
        }
    }
}
