using System.ComponentModel.DataAnnotations;

namespace NewsWebsit.Models
{
    public class News
    {
       [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Date")]
        public DateTime Date { get; set; }

        [Required]
        [Display(Name = "Content")]
        public string Content { get; set; }

     
       
    }

    internal class foriegnKeyAttribute : Attribute
    {
    }
}
