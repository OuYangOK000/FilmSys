using FilmSys.Models;
using Microsoft.AspNetCore.Mvc;

namespace FilmSys.Controllers
{
    public class EmployeeController : Controller
    {
        FilmDbContext db;
        public EmployeeController(FilmDbContext db_)
        {
            db = db_;
        }
        public IActionResult EmployeeMain()
        {
            List<Employee> emps = new List<Employee>();
            foreach (var emp in db.Employees)
            {
                emps.Add(emp);
            }
            return View("EmployeeMain", emps);
        }
    }
}
