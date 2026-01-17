using Microsoft.AspNetCore.Identity;

namespace Feane.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }
        public bool IsActivated { get; set; }

    }
}
