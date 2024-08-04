using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServiceMetier;

namespace PartageMemoireGatewaye.Models
{
    public class AppDbContext :IdentityDbContext<IdentityUser>
    {
       public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User1> users { get; set; }
        public DbSet<ServiceMetier.Expert> Expert { get; set; } = default!;
    }
}
