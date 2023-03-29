using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace MotoMondays.Models
{
    public class User : IdentityUser<int>
    {
        public override int Id { get; set; }
        [Required(ErrorMessage = "First Name is Required")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [DisplayName("Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is Required")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Birthdate is required")]
        [DisplayName("Birth date")]
        public DateTime DateOfBirth { get; set; }
        [Required(ErrorMessage = "Phone number is required")]
        [DisplayName("Phone Number")]

        [NotMapped]
        public IList<String> RoleNames { get; set; }

        public User() { }

        public User(int id, string email)
        {
            Id = id;
            Email = email;
        }

        public User(int id, string firstName, string middleName, string lastName, DateTime dateOfBirth, IList<string> roleNames)
            : this(id, firstName)
        {
            MiddleName = middleName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            RoleNames = roleNames;
        }
    }
}
