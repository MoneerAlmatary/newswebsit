using System.ComponentModel.DataAnnotations;

namespace NewsWebsit.Models
{
    public class Contact
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Subject")]
        public string Sucject { get; set; }

        [Required]
        [Display(Name = "Messages")]
        public string Message { get; set; }

        [Required]
        [Display(Name = "Gender")]
        public string Gen { get; set; }
    }
}
