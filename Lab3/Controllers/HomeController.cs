using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Controllers
{
    public class HomeController : Controller
    {
        private ContactContext _contactContext { get; set; }

        public HomeController(ContactContext ctx)
        {
            _contactContext = ctx;
        }
        [HttpGet]
        public IActionResult Index()
        {
           var contacts = _contactContext.Contacts.
               Include(c=>c.Category).
               OrderBy(c=> c.FirstName).ToList();


            //read list contacts
            return View(contacts);
        }


    }
}