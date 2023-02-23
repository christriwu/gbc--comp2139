using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Enter a valid First name")]
         public string? FirstName { get; set; }
        [Required(ErrorMessage = "Enter valid Last Name")]
         public string? LastName { get; set; }
         [Required(ErrorMessage = "Enter valid Phone number")]
        public string? phone { get; set; }
        [Required(ErrorMessage = "Enter valid Email")]
        public string? Email { get; set; }
         public string? Organization { get; set; }
         public DateTime DateAdded { get; set; }
        [Range(1,4, ErrorMessage = "Please select a valid Category")]
         public int CategoryId { get; set; }

         public Category? Category { get; set; }

         public string Slug => FirstName?.Replace(" ", "-").ToLower() + "-" +
                               LastName?.Replace(" ", "-").ToLower();
    }
}
