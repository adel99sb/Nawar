using Microsoft.AspNetCore.Identity;

namespace Infrastructure.Core.Entities
{
    public class AppUser : IdentityUser<Guid>
    {
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }

}
