using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebAutoApp11.Data.Domain;

namespace WebAutoApp11.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Cars> Cars { get; set; } = null!;

        public DbSet<Client> Clients { get; set; } = null!;

        public DbSet<Order> Orders { get; set; } = null!;
    }
}
