using BaiTap.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Data.Configurations
{
    public class ClassConfiguration : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.IdClass);
            builder.Property(x => x.IdClass).UseIdentityColumn(4, 1);
            builder.Property(x => x.IdClass).IsRequired();
            builder.Property(x => x.ClassName).HasColumnType("nvarchar(50)");
            builder.Property(x => x.ClassName).IsRequired();
        }
    }
}
