
    using Microsoft.EntityFrameworkCore;
namespace Web_Api_Sinqia.Models
{
    
        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options)
                : base(options)
            {
            }

            public DbSet<Musica> TodaMusicas { get; set; }
        }
    }

