using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using CevikMetalTeknik.Model;

#nullable disable

namespace CevikMetalTeknik.Data
{
    public partial class CevikTeknikMetalDb_context : DbContext
    {
        public CevikTeknikMetalDb_context()
        {
        }

        public CevikTeknikMetalDb_context(DbContextOptions<CevikTeknikMetalDb_context> options)
            : base(options)
        {
        }

        public virtual DbSet<BorcAlacak> BorcAlacaks { get; set; }
        public virtual DbSet<Cari> Caris { get; set; }
        public virtual DbSet<Hareket> Harekets { get; set; }
        public virtual DbSet<Parabirimi> Parabirimis { get; set; }
        public virtual DbSet<Stok> Stoks { get; set; }
        public virtual DbSet<StokGrub> StokGrubs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source =192.168.1.62; Initial Catalog = CevikTeknikMetal; Persist Security Info = false; User ID = sa; Password = 1234");// bunun için sordum veri tabanında güncelleme yaptın mı diye
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BorcAlacak>(entity =>
            {
                entity.ToTable("BorcAlacak");

                entity.HasOne(d => d.Hareket)
                    .WithMany(p => p.BorcAlacaks)
                    .HasForeignKey(d => d.Hareketid)
                    .HasConstraintName("FK_BorcAlacak_Hareket");

                entity.HasOne(d => d.Parabirimi)
                    .WithMany(p => p.BorcAlacaks)
                    .HasForeignKey(d => d.Parabirimiid)
                    .HasConstraintName("FK_BorcAlacak_Parabirimi");

                entity.HasOne(d => d.Stok)
                    .WithMany(p => p.BorcAlacaks)
                    .HasForeignKey(d => d.Stokid)
                    .HasConstraintName("FK_BorcAlacak_Stok");
            });

            modelBuilder.Entity<Cari>(entity =>
            {
                entity.ToTable("Cari");

                entity.Property(e => e.CariAdi).HasMaxLength(50);

                entity.Property(e => e.CariKodu).HasMaxLength(50);

                entity.Property(e => e.Cariislem).HasMaxLength(50);

                entity.Property(e => e.Cariislemtarih).HasColumnType("datetime");

                entity.HasOne(d => d.Parabirimi)
                    .WithMany(p => p.Caris)
                    .HasForeignKey(d => d.Parabirimiid)
                    .HasConstraintName("FK_Cari_Parabirimi");
            });

            modelBuilder.Entity<Hareket>(entity =>
            {
                entity.ToTable("Hareket");

                entity.Property(e => e.İslemTarihi).HasColumnType("datetime");

                entity.Property(e => e.İslemYapılanCariAd).HasMaxLength(50);

                entity.Property(e => e.İslemYapılanCariAd1).HasMaxLength(50);

                entity.HasOne(d => d.Stok)
                    .WithMany(p => p.Harekets)
                    .HasForeignKey(d => d.Stokid)
                    .HasConstraintName("FK_Hareket_Stok");
            });

            modelBuilder.Entity<Parabirimi>(entity =>
            {
                entity.ToTable("Parabirimi");

                entity.Property(e => e.ParabirimiAdi).HasMaxLength(50);

                entity.Property(e => e.Simge).HasMaxLength(50);
            });

            modelBuilder.Entity<Stok>(entity =>
            {
                entity.ToTable("Stok");

                entity.Property(e => e.StokAdi).HasMaxLength(50);

                entity.Property(e => e.StokKodu).HasMaxLength(50);

                entity.Property(e => e.StokResim1).HasColumnType("image");

                entity.Property(e => e.Urunislemturu)
                    .HasMaxLength(50)
                    .HasColumnName("urunislemturu");

                entity.HasOne(d => d.Cari)
                    .WithMany(p => p.Stoks)
                    .HasForeignKey(d => d.CariId)
                    .HasConstraintName("FK_Stok_Cari");

                entity.HasOne(d => d.Parabirimi)
                    .WithMany(p => p.Stoks)
                    .HasForeignKey(d => d.Parabirimiid)
                    .HasConstraintName("FK_Stok_Parabirimi");

                entity.HasOne(d => d.StokGrub)
                    .WithMany(p => p.Stoks)
                    .HasForeignKey(d => d.StokGrubid)
                    .HasConstraintName("FK_Stok_StokGrub");
            });

            modelBuilder.Entity<StokGrub>(entity =>
            {
                entity.ToTable("StokGrub");

                entity.Property(e => e.StokGrubAd).HasMaxLength(50);

                entity.Property(e => e.StokGrubKod).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
