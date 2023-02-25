using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc;

namespace Assignment_1.Models
{
    public class User
    {
        [Key] 
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please enter a username.")]
        [RegularExpression("^a-zA-Z0-9 ]+$")]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Enter valid Password")]
        [Compare("ConfirmPassword")]
        [StringLength(25, ErrorMessage = "Password is maximum 25 Characters")]
        public string? Password { get; set; } = string.empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [Display(Name = ConfirmPassword)]
        [NotMapped]
        public string ConfirmPassword { get; set; } = string.empty;

        
        [Required(ErrorMessage = "Enter valid Email")]
        [Remote("CheckEmail", "Validation")]
        [Display(Name = "Emal Address")]
        public string? Email { get; set; } = string.empty;

        [Required(ErrorMessage= "valid user type required")]
        public string? UserType { get; set; }


    }
}
