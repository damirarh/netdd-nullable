using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Entities
{
    public class PlayerDbContextFactory : IDesignTimeDbContextFactory<PlayerDbContext>
    {
        public PlayerDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<PlayerDbContext>();
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Entities;Trusted_Connection=True;");

            return new PlayerDbContext(optionsBuilder.Options);
        }
    }
}
