using BaiTap.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Service.IServicess
{
    public interface IStudentService
    {
        public int CreateStudent(Student st);
        public int UpdateStudent(Student st);
        public int DeleteStudent(int StudentID);
        public List<Student> GetListStudent();
    }
}
