using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BaiTap.Data.Entities
{
    public class Student
    {
        public int IdStudent { get; set; }
        [Display(Name ="Họ Tên Sinh Viên")]
        public string NameStudent { get; set; }
        [Display(Name = "Điểm")]
        public double Mark { get; set; }
        [Display(Name = "Email")]
        [EmailAddress(ErrorMessage = "Vui Lòng Nhập Đúng Dịnh Dạng Email")]
        public string EmailStudent { get; set; }
        [Display(Name = "Tên Lớp")]
        public int IdClass { get; set; }
        public Class Class { get; set; }
    }
}
