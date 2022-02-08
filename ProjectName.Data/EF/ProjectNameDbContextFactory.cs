using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ProjectName.Data.EF;

namespace ProjectName.Data.EF
{
    public class ProjectNameDbContextFactory : IDesignTimeDbContextFactory<ProjectNameDbContext>
    {
        private const string conectionString = "Server=.;Database=ProjectNameData;Trusted_Connection=True;";
        public ProjectNameDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ProjectNameDbContext>();
            optionsBuilder.UseSqlServer(conectionString);

            return new ProjectNameDbContext(optionsBuilder.Options);
        }
    }
}
