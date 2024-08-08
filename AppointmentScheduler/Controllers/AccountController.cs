using AppointmentScheduler.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppointmentScheduler.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _db;

        public AccountController(ApplicationDbContext db)
        {
            db = _db;

        }
        public IActionResult Login()
        {

            return View();
        }

        public IActionResult Register()
        {

            return View();
        }
    }
}
