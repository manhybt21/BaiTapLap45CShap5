using BaiTap.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Data.Extentions
{
    public static class ModelBuilderExtention
    {
        public static void Seed(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Class>().HasData(
                new Class() { IdClass=1,ClassName="IT" },
                new Class() { IdClass=2,ClassName="Du Lịch" },
                new Class() { IdClass=3,ClassName="Thiết Kế Đồ Hoạ"}
                );
            modelBuilder.Entity<Student>().HasData(
                new Student() { IdClass=1,IdStudent=1,NameStudent="Mạnh",Mark=8,EmailStudent="manhldph10164@fpt.edu.vn"},
                new Student() { IdClass = 1, IdStudent = 2, NameStudent = "Tuấn", Mark = 9, EmailStudent = "luongtuan@gmail.com" }
                );
        }
    }
}
