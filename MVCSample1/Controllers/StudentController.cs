using MVCSample1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCSample1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student st = new Student() { Name = "John Smith", Institution = "Abbott College" };
            return View(st);
        }
    }
}