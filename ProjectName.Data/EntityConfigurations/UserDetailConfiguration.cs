using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Data.Entities;

namespace ProjectName.Data.EntityConfigurations
{
    public class UserDetailConfiguration : IEntityTypeConfiguration<UserDetail>
    {
        public void Configure(EntityTypeBuilder<UserDetail> builder)
        {
            builder.ToTable("UserDetail");
            builder.HasKey(x => x.userDetailId);
        }
    }
}
