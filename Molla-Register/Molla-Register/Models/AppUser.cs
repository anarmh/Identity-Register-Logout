using Microsoft.AspNetCore.Identity;

namespace Molla_Register.Models
{
    public class AppUser: IdentityUser
    {
        public string FullName { get; set; }
    }
}
