using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Entities;

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

        // Khai báo kết nối data nhanh.
        //private const string conectionString = "Server=.;Database=ProjectNameData;Trusted_Connection=True;";
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(conectionString);
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserDetail>(entity => {
                entity.ToTable("UserDetail");
                entity.HasKey(x => x.userDetailId);
            }); 

            modelBuilder.Entity<User>(entity => {
                entity.ToTable("User");
                entity.HasKey(x=>x.userId);
                // reference 1 - 1
                entity.HasOne(x => x.userDetail)
                .WithOne(x => x.user)
                .HasForeignKey<UserDetail>(x => x.userDetailId)
                .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<Role>(entity => {
                entity.ToTable("Role");
                entity.HasKey(x => x.roleId);

            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.ToTable("UserRole");
                entity.HasKey(x => new { x.roleId, x.userId });
            });
            modelBuilder.Entity<Product>(entity => {
                entity.HasKey(x=>x.productId);
                entity.HasOne(x => x.user).WithMany(x => x.products).OnDelete(DeleteBehavior.SetNull);
            });
        }
    }
}
