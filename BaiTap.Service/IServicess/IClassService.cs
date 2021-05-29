using BaiTap.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTap.Service.IServicess
{
    public interface IClassService
    {
        public List<Class> getAll();
        public int CreateClass(Class cl);
        public int DeleteClass(int idClass);
        public int UpdateClass(Class cl);
    }
}
