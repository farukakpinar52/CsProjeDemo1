using CsProjeDemo1.Entities;
using CsProjeDemo1.Entities.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace Presentation.DAL
{
    public class LibraryDbContext : DbContext
    {
        DbSet<Uye> Uyeler { get; set; }
        DbSet<Kitap> Kitaplar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-P7KA77K\SQLEXPRESS;Database=Demo1;User Id=sa;Password=1234; ;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kitap>().UseTpcMappingStrategy();
            modelBuilder.Entity<Kitap>().HasKey(k => k.ISBN);

            modelBuilder.Entity<Uye>().HasKey(u => u.Id);

            modelBuilder.Entity<Kitap>()
                .HasOne(k => k.Uye)
                .WithMany(u => u.OduncKitaplar)
                .HasForeignKey(k => k.UyeId);
        }

    }
}
