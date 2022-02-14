using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectName.Data.EntityConfigurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role");
            builder.HasKey(x => x.roleId);
        }
    }
}
