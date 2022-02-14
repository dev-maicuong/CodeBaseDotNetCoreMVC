using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProjectName.Data.Entities;

namespace ProjectName.Data.Extensions
{
    public static class ModelBuiderExtension
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Product>().HasData(
                new Product 
                { 
                    productId = 1,
                    productName = "Sản phẩm 1",
                },
                new Product 
                {
                    productId = 2,
                    productName = "Sản phẩm 2",
                    userId = 1,
                });
            builder.Entity<Role>().HasData(
                new Role
                {
                    roleId = 1,
                    roleName = "Vai trò 1",
                    description = "Mô tả vai trò 1",

                },
                new Role
                {
                    roleId = 2,
                    roleName = "Vai trò 2",
                    description = "Mô tả vai trò 2",

                });
            builder.Entity<User>().HasData(
                new User
                {
                    userId = 1,
                    email = "hoangmaicuong99@gmail.com",
                    pass = "123",
                    firstName = "Cuong",
                    lastName = "Hoang",
                });
            builder.Entity<UserRole>().HasData(
                new UserRole
                {
                    userId = 1,
                    roleId = 1,
                });
            builder.Entity<UserDetail>().HasData(
                new UserDetail
                {
                    userDetailId = 1,
                    createDay = DateTime.ParseExact("2022-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture),
                    updateDay = DateTime.ParseExact("2022-05-08 14:40:52,531", "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture),
                });
        }
    }
}
