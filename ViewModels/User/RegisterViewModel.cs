using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookFace.Models.ViewModels
{
    public class RegisterViewModel
    {
        //https://learn.microsoft.com/en-us/aspnet/core/security/authentication/customize-identity-model?view=aspnetcore-5.0#customize-the-model
        [Required(ErrorMessage = "Please enter a username.")]
        [StringLength(30)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter an email")]
        [RegularExpression(@"^[a-z0-9]+@[a-z]+\.[a-z]{2,3}$",
            ErrorMessage = "Invalid Email")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a password.")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPassword")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please confirm your password.")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; } = string.Empty;

        [Required(ErrorMessage = "First Name is required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Phone 1 is required")]
        [RegularExpression(@"^((\+1|1)?\(?(800|[0-9]{3})(\)?\s?|\s?))?\-?[0-9]{3}(\s|\-)?[0-9]{4}$",
            ErrorMessage = "Invalid Phone Number")]
        [DisplayName("Phone 1")]
        public string Phone1 { get; set; }

        [DisplayName("Customer Since")]
        [DisplayFormat(DataFormatString = "{0:MM-dd-yyyy}")]
        public DateTime CreateDate { get; set; }
    }
}
