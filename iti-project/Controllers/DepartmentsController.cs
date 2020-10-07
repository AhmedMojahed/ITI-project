using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;

using iti_project.Models;

namespace iti_project.Controllers
{
    public class DepartmentsController : Controller
    {

        ApplicationDbContext _context = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View(_context.Departments.ToList());
        }


        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                var department = _context.Departments.Include(c => c.Courses).FirstOrDefault(c => c.ID == id);
                if (department != null)
                {
                    return View(department);
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
        public ActionResult Create(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Departments.Add(department);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(department);
        }





        //  
        // GET: /CRUD/Edit/5  

        public ActionResult Edit(string id = null)
        {
            Department department = _context.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        //  
        // POST 

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Department department)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(department).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(department);
        }

        //  
        // GET: /CRUD/Delete/5  

        public ActionResult Delete(string id = null)
        {
            Department department = _context.Departments.Find(id);
            if (department == null)
            {
                return HttpNotFound();
            }
            return View(department);
        }

        //  
        // POST: /CRUD/Delete/5  

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Department department = _context.Departments.Find(id);
            _context.Departments.Remove(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}