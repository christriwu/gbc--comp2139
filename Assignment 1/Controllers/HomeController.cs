using Assignment_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Assignment_1.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
           // ViewBid.
            return View();
        }



/*        [HttpPost]
        public IActionResult Index(Item item)
        {
            if (ModelState.IsValid)
            //ViewBid
        }*/
    }
}