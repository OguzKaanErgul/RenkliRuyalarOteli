using Microsoft.EntityFrameworkCore;
using RenkliRuyalarOteli.Entities.Entities.Concrete;
using System.Reflection;

namespace RenkliRuyalarOteli.DAL.Contexts
{
    public class SqlDbContext : DbContext
    {
        public DbSet<Kullanici> Kullanicilar { get; set; }

        public DbSet<Oda> Odalar { get; set; }

        public DbSet<OdaFiyat> OdaFiyatlari { get; set; }

        public DbSet<Rezervasyon> Rezervasyonlar { get; set; }

        public DbSet<RezervasyonDetay> RezervasyonDetaylari { get; set; }

        public DbSet<Musteri> Musteriler { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=RenkliRuyalarOteli;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
