using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ContactManager.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var contacts = _db.Contacts
               .Include(m => m.Category)
               .OrderBy(m => m.FirstName)
               .ToList();
            return View(contacts);
        }       
    }
}