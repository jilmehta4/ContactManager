using ContactManager.Data;
using ContactManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ContactManager.Controllers
{
    public class ContactController : Controller
    {
        private ApplicationDbContext _db { get; set; }

        public ContactController(ApplicationDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult Add()
        {
            Contact contact = new Contact();
            ViewBag.Action = "Add";
            ViewBag.Categories = _db.Categories.OrderBy(g => g.CategoryName).ToList();
            return View("Edit", contact);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = _db.Categories.OrderBy(g => g.CategoryName).ToList();
            var contact = _db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            if (ModelState.IsValid)
            {
                if (contact.ContactId == 0)
                    _db.Contacts.Add(contact);
                else
                    _db.Contacts.Update(contact);
                _db.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (contact.ContactId == 0) ? "Add" : "Edit";
                ViewBag.Categories = _db.Categories.OrderBy(g => g.CategoryName).ToList();
                return View(contact);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _db.Contacts.Find(id);
            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            _db.Contacts.Remove(contact);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult Details(int id)
        {
            var categories = _db.Categories
                .OrderBy(c => c.CategoryId).ToList();

            Contact contact = _db.Contacts
                .Include(p => p.Category)
                .FirstOrDefault(p => p.ContactId == id);

            // use ViewBag to pass data to view
            ViewBag.Categories = categories;

            // bind product to view
            return View(contact);
        }
    }
}
