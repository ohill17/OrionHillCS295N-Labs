using AllAboutWeezer.Models;
using Microsoft.EntityFrameworkCore;

namespace AllAboutWeezer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Message> Message { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
