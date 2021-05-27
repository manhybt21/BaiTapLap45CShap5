using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BaiTap.Data.Entities
{
    public class Class
    {
        public int IdClass { get; set; }
        [Display(Name ="Tên Lớp")]
        [Required(ErrorMessage ="Tên Lớp Không Được Bỏ Trống")]
        public  string ClassName { get; set; }
        public List<Student> Students { set; get; }
    }
}
