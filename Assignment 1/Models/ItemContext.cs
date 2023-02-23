using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_1.Models
{
    public class ItemContext : DbContext
    {
        public ItemContext(DbContextOptions<ItemContext> options) : base(options) { }

        //DbSets
        public DbSet<User> User { get; set; }
        public DbSet<Item> Item { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Password = "Password",
                    Email = "Seller1@gmail.ca",
                    UserType = "seller"
                },
                new User()
                {
                    UserId = 2,
                    Password = "password1",
                    Email = "buyer1@gmail.ca",
                    UserType = "buyer"
                }
            );
            modelBuilder.Entity<Item>().HasData(
                new Item
                {   ItemId = 1,
                    ItemName = "Air Jordan",
                    ItemDescription = "really cool shoes",
                    MinCost = 100.00,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "Used",
                    Category = "Shoes",
                    Image = "~\\Images\\shoes.png"

                }
            );

    }
    }
}
