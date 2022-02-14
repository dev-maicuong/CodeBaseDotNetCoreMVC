using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectName.Data.Entities;

namespace ProjectName.Data.EntityConfigurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.ToTable("UserRole");
            builder.HasKey(x => new { x.roleId, x.userId });
        }
    }
}
