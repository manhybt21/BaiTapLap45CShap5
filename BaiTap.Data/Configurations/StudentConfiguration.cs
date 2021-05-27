using BaiTap.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Data.Configurations
{
    public class StudentConfiguration:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Student");
            builder.HasKey(x => x.IdStudent);
            builder.Property(x => x.IdStudent).IsRequired().UseIdentityColumn(3, 1);
            builder.Property(x => x.NameStudent).IsRequired().HasColumnType("nvarchar(50)");
            builder.Property(x => x.Mark).IsRequired().HasColumnType("float");
            builder.Property(x => x.EmailStudent).HasColumnType("nvarchar(100)");
            builder.HasOne(x => x.Class).WithMany(y => y.Students).HasForeignKey(z => z.IdClass);
        }
    }
}
