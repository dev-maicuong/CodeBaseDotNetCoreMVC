using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ProjectName.Data.EF;
using Microsoft.EntityFrameworkCore;
using ProjectName.Service.Imp;
using Microsoft.Extensions.Logging;
using ProjectName.Data.Infrastructure;

namespace ProjectName.Web
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddFilter(DbLoggerCategory.Query.Name, LogLevel.Information);
            //builder.AddFilter(DbLoggerCategory.Database.Name, LogLevel.Information);
            builder.AddConsole();
        });

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddDbContext<ProjectNameDbContext>(options => {
                string connectstring = Configuration.GetConnectionString("ProjectNameContext");
                // hien thi cau truy van ra cua so console
                options.UseLoggerFactory(loggerFactory);
                options.UseSqlServer(connectstring);
            });

            services.AddTransient<IProductService, ProductService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IAccountService, AccountService>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapAreaControllerRoute(
                    name: "ManageOwnerUser",
                    pattern: "ManageOwner/{controller}/{action=Index}/{id?}",
                    areaName: "ManageOwner");

                endpoints.MapAreaControllerRoute(
                    name: "ManageMarketingHome",
                    pattern: "ManageMarketing/{controller}/{action=Index}/{id?}",
                    areaName: "ManageMarketing");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
