using Microsoft.EntityFrameworkCore;
using WebAPI.Models;

namespace WebAPI
{
    public class OkulContext : DbContext
    {
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<OgretimElemani> OgretimElemanlari { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SKYN\\SQLEXPRESS; Initial Catalog=OkulWebAPI; Integrated Security=True; Encrypt=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ders>()
                .HasMany(d => d.DersiAlanOgrenciler)
                .WithMany(o => o.AldigiDersler);

            modelBuilder.Entity<Ders>()
                .HasOne(d => d.DersiVerenOgretimElemani)
                .WithMany(oe => oe.VerdigiDersler);
        }
    }
}
