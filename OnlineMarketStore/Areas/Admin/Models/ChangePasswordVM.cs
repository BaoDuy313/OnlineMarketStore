using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.Areas.Admin.Models
{
    public class ChangePasswordVM
    {
        [Key]
        public int AccountId { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter your email")]
        public string Email { get; set; }

        [Display(Name = "Current password")]
        [Required(ErrorMessage = "Please enter your current password")]
        public string PasswordNow { get; set; }

        [Display(Name = "A new password")]
        [Required(ErrorMessage = "Please enter a new password")]
        [MinLength(6, ErrorMessage = "You need to set a password of at least 6 characters")]
        public string Password { get; set; }

        [MinLength(6, ErrorMessage = "You need to set a password of at least 6 characters")]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "Password incorrect, please try again")]
        public string ConfirmPassword { get; set; }
    }
}
