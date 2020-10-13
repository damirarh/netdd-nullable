using Microsoft.EntityFrameworkCore;

namespace Entities
{
    public class PlayerDbContext : DbContext
    {
        public PlayerDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Player> Players { get; set; } = null!;
    }
}
