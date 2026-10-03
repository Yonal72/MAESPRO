using MAESPRO.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MAESPRO.Persistence.Context;

public class MaesproDbContext:DbContext
{
    public MaesproDbContext(DbContextOptions<MaesproDbContext> options) : base(options)
    {
    }

    public DbSet<Musteri> Musteriler => Set<Musteri>();
    public DbSet<Parca> Parcalar => Set<Parca>();
    public DbSet<Teklif> Teklifler => Set<Teklif>();    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Tablo bazlı özel konfigürasyonlar ve ilişkiler (Fluent API)

        // Customer Konfigürasyonu
        modelBuilder.Entity<Musteri>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Code).IsRequired().HasMaxLength(50);
            entity.Property(c => c.MusteriAdi).IsRequired().HasMaxLength(200);
        });

        // Quotation Konfigürasyonu
        modelBuilder.Entity<Teklif>(entity =>
        {
            entity.HasKey(q => q.Id);
            entity.Property(q => q.TeklifNo).IsRequired().HasMaxLength(50);

            entity.HasOne(q => q.Parca)
                  .WithOne(c => c.Teklif)
                  .HasForeignKey<Parca>(q => q.Id)
                  .OnDelete(DeleteBehavior.Restrict);
        });
        
        // Product Konfigürasyonu
        modelBuilder.Entity<Parca>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.ParcaNo).IsRequired().HasMaxLength(50);
            entity.Property(p => p.ParcaAdi).IsRequired().HasMaxLength(150);

            entity.HasOne(p => p.Musteri)
                  .WithMany(c => c.Parcalar)
                  .HasForeignKey(p => p.MusteriId)
                  .OnDelete(DeleteBehavior.Restrict);
        });
    }
}