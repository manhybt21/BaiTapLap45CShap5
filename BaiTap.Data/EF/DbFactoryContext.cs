using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BaiTap.Data.EF
{
    public class DbFactoryContext:IDesignTimeDbContextFactory<databaseContext>
    {
        public databaseContext CreateDbContext(string[] args)
        {
            IConfiguration configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();

            var connectionString = configuration.GetConnectionString("manhDbLab45");
            var optionBuilder = new DbContextOptionsBuilder<databaseContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new databaseContext(optionBuilder.Options);
        }
    }
}
