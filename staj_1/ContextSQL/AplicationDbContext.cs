using Microsoft.EntityFrameworkCore;
using staj_1.models;

namespace staj_1.ContextSQL
{
    public class AplicationDbContext : DbContext
    {
        
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Door> doors { get; set; }
    }
    
}
    