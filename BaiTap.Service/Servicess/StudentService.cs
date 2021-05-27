using BaiTap.Data.EF;
using BaiTap.Data.Entities;
using BaiTap.Service.IServicess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap.Service.Servicess
{
    public class StudentService:IStudentService
    {
        private readonly databaseContext _databaseContext;
        public StudentService(databaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public StudentService()
        {

        }
        public int CreateStudent(Student st) {
            
            var student = new Student()
            {
                NameStudent= st.NameStudent,
                Mark = st.Mark,
                EmailStudent = st.EmailStudent,
                IdClass = st.IdClass
            };
            _databaseContext.Students.Add(student);
            _databaseContext.SaveChanges();
            return 1;
        }
        public int UpdateStudent(Student st) {
            var findID = _databaseContext.Students.Find(st.IdStudent);
            findID.NameStudent = st.NameStudent;
            findID.Mark = st.Mark;
            findID.EmailStudent = st.EmailStudent;
            findID.IdClass = st.IdClass;
            _databaseContext.Students.Update(findID);
            _databaseContext.SaveChanges();
            return 1;
        }
        public int DeleteStudent(int studentId) {
            var findID =  _databaseContext.Students.Find(studentId);
            _databaseContext.Students.Remove(findID);
            _databaseContext.SaveChanges();
            return 1;
        }
        public List<Student> GetListStudent() {
            var getStudent = _databaseContext.Students.ToList();
            return getStudent;
        }
    }
}
