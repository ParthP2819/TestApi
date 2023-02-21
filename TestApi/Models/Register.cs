using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Register
    {
        [Required(ErrorMessage ="User Name is required")]
        public string Uname { get; set; }
        [EmailAddress]
        [Required(ErrorMessage ="Email is required")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Password is required")]
        public string Password { get; set; }        
    }
}
