using Microsoft.AspNetCore.Identity;

namespace Nawar.API.Core.Entities
{
    public class AppUser : IdentityUser<Guid>
    {

        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }
}
