using Microsoft.AspNetCore.Identity;

namespace Capstone2023.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string PhotoURL { get; set; }
    }
}
