using Microsoft.AspNetCore.Identity;

namespace Examination_and_Counselling_Process.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? Name { get; set; }

        public string? Address { get; set; }
    }
}
