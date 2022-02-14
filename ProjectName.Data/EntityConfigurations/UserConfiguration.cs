using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProjectName.Data.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.userId);
            // reference 1 - 1
            builder.HasOne(x => x.userDetail)
            .WithOne(x => x.user)
            .HasForeignKey<UserDetail>(x => x.userDetailId)
            .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
