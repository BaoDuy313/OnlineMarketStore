using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineMarketStore.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [MaxLength(100)]
        [Required(ErrorMessage = "Please enter your email")]
        [Display(Name = "Email")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your phone pasword")]
        [Display(Name = "Password")]
        [MinLength(6,ErrorMessage = "You need to set a password of at least 6 characters")]
        public string Password { get; set; }
    }
}
