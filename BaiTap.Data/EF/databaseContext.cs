using BaiTap.Data.Configurations;
using BaiTap.Data.Entities;
using BaiTap.Data.Extentions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Data.EF
{
    public class databaseContext:DbContext
    {
        public databaseContext(DbContextOptions<databaseContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClassConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.Seed();
        }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
