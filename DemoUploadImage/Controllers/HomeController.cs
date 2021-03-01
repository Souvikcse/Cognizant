using DemoUploadImage.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoUploadImage.Controllers
{
    public class HomeController : Controller
    {
        // GET: Student
        // GET: Student
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details()
        {
            return View(db.Students.ToList());
        }

        [HttpPost]
        public ActionResult Add(Student s, HttpPostedFileBase ImageUpload)
        {
            string myfilename = Path.Combine(Server.MapPath("~/Images"), Path.GetFileName(ImageUpload.FileName));
            ImageUpload.SaveAs(myfilename);
            s.sphoto = "~/Images/" + Path.GetFileName(ImageUpload.FileName);
            db.Students.Add(s);
            db.SaveChanges();
            return RedirectToAction("Details");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}