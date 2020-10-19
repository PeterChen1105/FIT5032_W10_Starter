using Microsoft.EntityFrameworkCore;

namespace FIT5032_W10_Starter.Models
{
    public class UnitContext : DbContext
    {
        public UnitContext(DbContextOptions<UnitContext> options)
            : base(options)
        {
        }

        public DbSet<Unit> Units { get; set; }
    }
}
