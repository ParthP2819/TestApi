using System.ComponentModel.DataAnnotations;

namespace TestApi.Models
{
    public class Login
    {
        [Required(ErrorMessage = "User Name is required")]
        public string  UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
