using Feane.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Feane.Data
{
    public class FeaneDbContext : IdentityDbContext<AppUser>
    {
        public FeaneDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> products { get; set; }
    }
}
