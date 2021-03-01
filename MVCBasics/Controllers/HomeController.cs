using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCBasics.Controllers
{
    public class HomeController : Controller
    {
        TruyumContext _context;
        public HomeController()
        {
            _context = new TruyumContext();
        }
        
        public ActionResult Index()
        {
            var futuredate = new DateTime(2020, 01, 01);
            var list = _context.MenuItems.Where(m => m.DateOfLaunch < futuredate).ToList();
            return View(list);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(MenuItem item)
        {
            _context.MenuItems.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Items", new { isAdmin = true });
        }

        public ActionResult Items(bool isAdmin)
        {
            List<MenuItem> list = null;
            if (isAdmin == true)
            {
                list = _context.MenuItems.ToList();
            }
            return View(list);
        }

        public ActionResult Edit(int id)
        {
            var item = _context.MenuItems.Find(id);
            return View(item);
        }
        [HttpPost]
        public ActionResult Edit(MenuItem item)
        {
            _context.MenuItems.Attach(item);
            _context.Entry(item).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return RedirectToAction("Items", new { isAdmin = true });
        }
    }
}