using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment_1.Models;

namespace Assignment_1.Controllers
{
    public class SearchController : Controller
    {
        private readonly ApplicationContext _context;

        public SearchController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var objItemList = _context.Items.ToList();
            return View(objItemList);
        }

/*        public Task<IActionResult> _SearchSection()
        {

            var objCategoryList = await _context.Items.Select(x => x.Category).Distinct().ToListAsync();
            return View(objCategoryList);
        }*/


    }
}
