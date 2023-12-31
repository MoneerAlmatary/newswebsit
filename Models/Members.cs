﻿using System.ComponentModel.DataAnnotations;

namespace NewsWebsit.Models
{
    public class Members
    {

        public int ID { get; set; }
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Job")]
        public string job { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
      
        public string Email { get; set; }

      /*  [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
*/

        [Required]
        [Display(Name = "Image")]
        public string image { get; set; }
        [Required]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

      

    }
}
