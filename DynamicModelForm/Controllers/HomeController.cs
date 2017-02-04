using DynamicModelForm.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicModelForm.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View(new StudentModel());
        }
        [HttpPost]
        public ActionResult Index(StudentModel stu)
        {
            //var subjects = form["Subject"].Split(',');
            //var modelsubjects = new List<SubjectModel>();
            //foreach (var subject in subjects)
            //{
            //    modelsubjects.Add(new SubjectModel() { Subject = subject });
            //}

            //var model = new StudentModel();
            //model.Name = form["Name"];
            //model.Grade = form["Grade"];
            //model.Tutor = form["Tutor"];
            //model.Subjects = modelsubjects;

            //Here I get the model from a dynamic form
            if (ModelState.IsValid)
            {
                //db operations
                return RedirectToAction("Index");
            }
            return View(stu);
        }
        public ActionResult Subjects(int count)
        {
            ViewBag.count = count;
            return PartialView("SubjectPV");
        }
    }
}