using FilmSys.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;

namespace FilmSys.Controllers
{
    public class UserController : Controller
    {
        FilmDbContext db;
        public UserController(FilmDbContext db_)
        {
            db = db_;
        }
        public IActionResult UserMain()
        {
            List<UInformation> us = new List<UInformation>();
            foreach (var u in db.UInformations)
            {
                us.Add(u);
            }
            return View("UserMain", us);
        }
    }
}
