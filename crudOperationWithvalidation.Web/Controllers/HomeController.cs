using crudOperationWithvalidation.Web.Data;
using crudOperationWithvalidation.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace crudOperationWithvalidation.Web.Controllers
{
    public class HomeController : Controller
    {

        private SchoolContext schoolContext;
        public HomeController(SchoolContext sc)
        {
            schoolContext = sc;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Teacher teacher)
        {
            if (ModelState.IsValid)
            {
                schoolContext.Teachers.Add(teacher);
                schoolContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
                return View();
        }


    }

    
    
}
