using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

using iti_project.Models;




namespace iti_project.Controllers
{
    public class CoursesController : Controller
    {
        ApplicationDbContext _context = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View(_context.Courses.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                var course = _context.Courses.FirstOrDefault(c => c.ID == id);
                if (course != null)
                {
                    return View(course);
                }
            }

            return RedirectToAction("Index");
        }




        // GET: /CRUD/Create  
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        //  
        // POST: /CRUD/Create  

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Courses.Add(course);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(course);
        }

        //  
        // GET: /CRUD/Edit 

        public ActionResult Edit(string id = null)
        {
            Course course = _context.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        //  
        // POST 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(course).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(course);
        }

        //  
        // GET: /CRUD/Delete 

        public ActionResult Delete(string id = null)
        {
            Course course = _context.Courses.Find(id);
            if (course == null)
            {
                return HttpNotFound();
            }
            return View(course);
        }

        //  
        // POST: /CRUD/Delete 

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Course course = _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }


        //Search 
        public ActionResult Search(string Search_Data)
        {
            var course = from courses in _context.Courses select courses;
            if (!String.IsNullOrEmpty(Search_Data))
            {
                course = course.Where(c => c.Name.ToUpper().Contains(Search_Data.ToUpper()));
            }
            return View(course.ToList());
        }

        /*
        public ActionResult Search(string Sorting_Order, string Search_Data, string Filter_Value, int? Page_No)
        {
            ViewBag.CurrentSortOrder = Sorting_Order;
            ViewBag.SortingName = String.IsNullOrEmpty(Sorting_Order) ? "Name_Description" : "";
            int Size_Of_Page = 4;

            if (Search_Data != null)
            {
                Page_No = 1;
            }
            else
            {
                Search_Data = Filter_Value;
            }

            ViewBag.FilterValue = Search_Data;

            var course = from courses in _context.Courses select courses;
            if (!String.IsNullOrEmpty(Search_Data))
            {
                course = course.Where(c => c.Name.ToUpper().Contains(Search_Data.ToUpper()));
            }
            switch (Sorting_Order)
            {
                case "Name_Description":
                    course = course.OrderByDescending(c => c.Name)
                        .Skip((int)((Page_No - 1) * Size_Of_Page))
                        .Take(Size_Of_Page);
                    break;

                default:
                    course = course.OrderBy(c => c.Name)
                        .Skip((int)((Page_No - 1) * Size_Of_Page))
                        .Take(Size_Of_Page);
                    ;
                    break;
            }
            int No_Of_Page = (Page_No ?? 1);
            return View(course.ToPagedList(No_Of_Page, Size_Of_Page));
        }*/
    }

}