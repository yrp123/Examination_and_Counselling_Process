using System.ComponentModel.DataAnnotations;

namespace Examination_and_Counselling_Process.Models
{
    public class LoginViewModel
    {
        [Required, EmailAddress]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }
    }
}
