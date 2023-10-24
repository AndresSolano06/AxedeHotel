using Microsoft.EntityFrameworkCore;

namespace Axede.Models
{
    public class HotelDbContext : DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options)
        {
        }

        public DbSet<Hotel> Hoteles { get; set; }
        public DbSet<Reservas>Reservas{ get; set; }
        public DbSet<Valor> Valores { get; set; }
    }
}
