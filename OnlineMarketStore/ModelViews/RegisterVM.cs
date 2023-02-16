using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.ModelViews
{
    public class RegisterVM
    {
        [Key]
        public int CustomerId { get; set; }

        [Display(Name = "First and last name")]
        [Required(ErrorMessage = "Please enter Full Name")]
        public string FullName { get; set; }

        [MaxLength(150)]
        [Required(ErrorMessage = "Please enter Email")]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "ValidateEmail", controller: "Accounts")]
        public string Email { get; set; }

        [MaxLength(11)]
        [Required(ErrorMessage = "Please enter the phone number")]
        [Display(Name = "Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [Remote(action: "ValidatePhone", controller: "Accounts")]
        public string Phone { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please enter a password")]
        [MinLength(6, ErrorMessage = "You need to set a password of at least 6 characters")]
        public string Password { get; set; }

        [MinLength(6, ErrorMessage = "You need to set a password of at least 6 characters")]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password incorrect, please try again")]
        public string ConfirmPassword { get; set; }
    }
}
