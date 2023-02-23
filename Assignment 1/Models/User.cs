using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }

        [Required(ErrorMessage = "Enter valid Password")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "Enter valid Email")]
        public string? Email { get; set; }

        [Required(ErrorMessage= "valid user type required")]
        public string? UserType { get; set; }


    }
}
