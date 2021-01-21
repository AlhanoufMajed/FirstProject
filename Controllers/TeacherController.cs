using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SMProject.DAL;
using SMProject.Models;

namespace SMProject.Controllers
{
	public class TeacherController : Controller
	{

		private SchoolContext db = new SchoolContext();

		public ActionResult Index()
		{

			var list = db.Teachers.ToList(); // جبت البيانات من الموديل 
			return View(list);
		}


		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create([Bind(Include = "Id,Name,Course,NumCourses")] Teacher teacher)
		{
			if (ModelState.IsValid)
			{
				db.Teachers.Add(teacher);
				db.SaveChanges();
				return RedirectToAction("Index");
			}

			return View(teacher);
		}

		public ActionResult Edit(int id)

		{
			return View(db.Teachers.Find(id));

		}

		[HttpPost]
		public ActionResult Edit(Teacher T)
		{

			if (ModelState.IsValid)
			{
				db.Entry(T).State = EntityState.Modified;
			db.SaveChanges();
			return RedirectToAction("Index");
		}

		return View(T);
	
	}



	}
}