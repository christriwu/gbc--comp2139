using System.Reflection.Metadata.Ecma335;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Controllers
{
    public class ContactController : Controller
    {
        private ContactContext _contactContext { get; set; }

        public ContactController(ContactContext ctx)
        {
            _contactContext = ctx;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
           var contact =  _contactContext.Contacts.Include(c => c.Category).
                FirstOrDefault(c => c.CategoryId == id);
            return View(contact);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Categories = _contactContext.Categories.
                OrderBy(c => c.Name).ToList();

            return View("Edit", new Contact());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Categories = _contactContext.Categories.
                OrderBy(c => c.Name).ToList();
            var contact = _contactContext.Contacts.Include(c => c.CategoryId == id);

            return View(contact);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var contact = _contactContext.Contacts.Include(c => c.CategoryId == id);

            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact c)
        {
            string action = (c.ContactId == 0) ? "Add" : "Edit";

            if (!ModelState.IsValid)
            {
                ViewBag.Action = action;
                ViewBag.Categories = _contactContext.Categories.OrderBy(c=>c.Name).ToList();
                return View(c);
            }

            if (action == "Add")
            {
                c.DateAdded = DateTime.Now;
                _contactContext.Contacts.Add(c);
            }
            else
            {
                _contactContext.Contacts.Update(c);
            }
            _contactContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Delete(Contact C)
        {
            _contactContext.Contacts.Remove(C);
            _contactContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
}
}
