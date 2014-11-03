using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BlogApplication.Models
{
    public class LoginViewModel
    {
        [Required]
        [DisplayName("Brukernavn")]
        public string UserName { get; set; }
        [Required]
        [DisplayName("Passord")]
        public string Password { get; set; }
        [DisplayName("Husk meg?")]
        public bool RememberMe { get; set; }
    }
}