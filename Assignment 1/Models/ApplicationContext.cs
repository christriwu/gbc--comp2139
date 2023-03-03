using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment_1.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        //DbSets
        public DbSet<User> Users { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    UserId = 1,
                    Password = "Password",
                    EmailAddress = "Seller1@gmail.ca",
                    UserType = "seller"
                },
                new User
                {
                    UserId = 2,
                    Password = "password1",
                    EmailAddress = "buyer1@gmail.ca",
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
                    Image = "shoes.png"

                },
                new Item
                {
                    ItemId = 2,
                    ItemName = "Nike",
                    ItemDescription = "really really cool shoes",
                    MinCost = 120.00,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "New",
                    Category = "Shoes",
                    Image = "nike.jpg"

                },
                new Item
                {
                    ItemId = 3,
                    ItemName = "Spider-man Shoes",
                    ItemDescription = "Cool Spider-man shoes",
                    MinCost = 2000.00,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "New",
                    Category = "Shoes",
                    Image = "spiderman.jpg"

                }, 
                new Item
                {
                    ItemId = 4,
                    ItemName = "Bicycle",
                    ItemDescription = "Bicycle",
                    MinCost = 124.99,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "New",
                    Category = "Sports",
                    Image = "bicycle.jpg"

                },
                new Item
                {
                    ItemId = 5,
                    ItemName = "Iphone 13",
                    ItemDescription = "Iphone 13 128GB",
                    MinCost = 1120.00,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "New",
                    Category = "Phone",
                    Image = "iPhone13.png"

                },
                new Item
                {
                    ItemId = 6,
                    ItemName = "Samsung Galaxy 23",
                    ItemDescription = "Samsung Galaxy 23 256GB",
                    MinCost = 2000.00,
                    OpeningDate = DateTime.Now,
                    ClosingDate = DateTime.Now.AddDays(3),
                    Condition = "New",
                    Category = "Phone",
                    Image = "samsung.png"

                }
            );

    }
    }
}
