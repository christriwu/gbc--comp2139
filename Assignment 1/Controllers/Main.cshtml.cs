using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Assignment_1.Models;

namespace Assignment_1.Pages 
{
    public class IndexModel : PageModel
    {
        private ApplicationContext _db;
        public IndexModel(ApplicationContext db)
        {
            _db = db;
        }

        public List<Item> Items { get; set; }

        public void onGet()
        {
            Items = new List<Item>();
        }

        public async Task AsyncOnPost()
        {
            var searchString = Request.Form["searchString"];
            Items = await _db.Items.Where(x => x.ItemName.Contains(searchString)).ToListAsync();
        }
    }
}