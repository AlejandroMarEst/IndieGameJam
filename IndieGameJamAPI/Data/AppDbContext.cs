using IndieGameJamAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace IndieGameJamAPI.Data
{
    public class AppDbContext
    {
        public DbSet<Games> Games { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
    }
}
