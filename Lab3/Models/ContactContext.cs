using Microsoft.EntityFrameworkCore;

namespace Lab3.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext( DbContextOptions<ContactContext> options) : base( options ) { }

        //Dbsets
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Friend" },
                new Category { CategoryId = 2, Name = "Work" }, 
                new Category { CategoryId = 3, Name = "School" },
                new Category { CategoryId = 4, Name = "Home" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "lsdh",
                    LastName = "sh",
                    phone = "sdh",
                    Email = "shdf",
                    CategoryId = 1,
                    DateAdded = DateTime.Now

                }
            );
        }
    }
}
