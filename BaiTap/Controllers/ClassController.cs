using BaiTap.Data.EF;
using BaiTap.Data.Entities;
using BaiTap.Service.IServicess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Controllers
{
    public class ClassController : Controller
    {
        // GET: ClassController
        public readonly IClassService _classService;
        public readonly databaseContext _datbaseContext;
        public ClassController(IClassService classService,databaseContext datbaseContext)
        {
            _datbaseContext = datbaseContext;
            _classService = classService;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View(_classService.getAll());
        }
        
        public ActionResult Create()
        { 
            return View();
        }

        // POST: ClassController/Create
        [HttpPost]
        public ActionResult Create(Class cl)
        {
            try
            {
                _classService.CreateClass(cl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        
        public ActionResult Edit(int id)
        {
            var edit = _datbaseContext.Classes.SingleOrDefault(x => x.IdClass == id);
            return View(edit);
        }

        // POST: ClassController/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Class cl)
        {
            try
            {
                _classService.UpdateClass(cl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

       
        public ActionResult Delete(int id)
        {
            var find = _datbaseContext.Classes.Find(id);
            return View(find);
        }

        // POST: ClassController/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Class cl)
        {
            try
            {
                _classService.DeleteClass(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
