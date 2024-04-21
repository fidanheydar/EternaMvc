using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext:DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Slide> Slides { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Service> Services { get; set; }   
        public DbSet<Feature> Features { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<TeamIcon> TeamIcons { get; set; }
    }
}
