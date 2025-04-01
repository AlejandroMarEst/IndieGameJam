using IndieGameJamAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace IndieGameJamAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Games> Games { get; set; }
        public DbSet<User> User { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            string connection = configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connection);
        }
    }
}
