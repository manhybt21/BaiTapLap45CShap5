using BaiTap.Data.EF;
using BaiTap.Data.Entities;
using BaiTap.Service.IServicess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaiTap.Service.Servicess
{
    public class ClassService : IClassService

    {
        private readonly databaseContext _context;
        public ClassService(databaseContext context)
        {
            _context = context;
        }
        public int CreateClass(Class cl)
        {
            var Create = new Class()
            {
                ClassName = cl.ClassName
            };
            _context.Classes.Add(Create);
            _context.SaveChanges();
            return 0;
        }

        public int DeleteClass(int idClass)
        {
            var find = _context.Classes.Find(idClass);
            _context.Classes.Remove(find);
            _context.SaveChanges();
            return 0;
        }

        public List<Class> getAll()
        {
            var getAll = _context.Classes.ToList();
            return getAll;
        }

        public int UpdateClass(Class cl)
        {
            var update = _context.Classes.Find(cl.IdClass);
            update.ClassName = cl.ClassName;
            _context.Classes.Update(update);
            _context.SaveChanges();
                return 0;
        }
    }
}
