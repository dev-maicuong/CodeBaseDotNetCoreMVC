using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Entities;
using ProjectName.Data.EntityConfigurations;
using ProjectName.Data.Extensions;

namespace ProjectName.Data.EF
{
    public class ProjectNameDbContext : DbContext
    {

        public DbSet<User> Users { set; get; }
        public DbSet<Role> Roles { set; get; }
        public DbSet<UserDetail> UserDetails { set; get; }
        public DbSet<UserRole> UserRoles { set; get; }
        public DbSet<Product> Products { set; get; }
        public ProjectNameDbContext(DbContextOptions<ProjectNameDbContext> options) : base(options)
        {
            // Phương thức khởi tạo này chứa options để kết nối đến MS SQL Server
            // Thực hiện điều này khi Inject trong dịch vụ hệ thống
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserDetailConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
