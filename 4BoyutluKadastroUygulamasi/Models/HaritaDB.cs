using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace _4BoyutluKadastroUygulamasi.Models
{
  public partial class HaritaDB : DbContext
  {
    public HaritaDB()
        : base("name=HaritaDB")
    {
    }

    public virtual DbSet<C2D> C2D { get; set; }
    public virtual DbSet<C3D> C3D { get; set; }
    public virtual DbSet<C4D> C4D { get; set; }
    public virtual DbSet<C5D> C5D { get; set; }
    public virtual DbSet<DegisiklikTipi> DegisiklikTipi { get; set; }
    public virtual DbSet<GenelBilgiler> GenelBilgiler { get; set; }
    public virtual DbSet<ImarDurumu> ImarDurumu { get; set; }
    public virtual DbSet<ImarDurumuBaslik> ImarDurumuBaslik { get; set; }
    public virtual DbSet<ilceler> ilceler { get; set; }
    public virtual DbSet<iller> iller { get; set; }
    public virtual DbSet<ParseldeMeydanaGelenDegisiklikler> ParseldeMeydanaGelenDegisiklikler { get; set; }
    public virtual DbSet<TescilNesneTipi> TescilNesneTipi { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
      modelBuilder.Entity<C2D>()
          .Property(e => e.ParselinGeometrikSekli)
          .IsUnicode(false);

      modelBuilder.Entity<C4D>()
          .Property(e => e.DegisikliginAciklamasi1)
          .IsUnicode(false);

      modelBuilder.Entity<C4D>()
          .Property(e => e.DegisikliginAciklamasi2)
          .IsUnicode(false);

      modelBuilder.Entity<C4D>()
          .Property(e => e.DegisikliginAciklamasi3)
          .IsUnicode(false);

      modelBuilder.Entity<C4D>()
          .Property(e => e.DegisikliginAciklamasi4)
          .IsUnicode(false);

      modelBuilder.Entity<C4D>()
          .Property(e => e.DigerAciklama)
          .IsUnicode(false);

      modelBuilder.Entity<C5D>()
          .Property(e => e.Mahalle)
          .IsUnicode(false);

      modelBuilder.Entity<C5D>()
          .Property(e => e.CepheAlinanCadde_Sokak)
          .IsUnicode(false);

      modelBuilder.Entity<DegisiklikTipi>()
          .Property(e => e.Aciklama)
          .IsUnicode(false);

      modelBuilder.Entity<DegisiklikTipi>()
          .HasMany(e => e.C4D)
          .WithOptional(e => e.DegisiklikTipi1)
          .HasForeignKey(e => e.DegisiklikTipi);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.Mahalle_Koy)
          .IsUnicode(false);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.Mevkii)
          .IsUnicode(false);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.Adres)
          .IsUnicode(false);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.Malik)
          .IsUnicode(false);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.BabaAdi)
          .IsUnicode(false);

      modelBuilder.Entity<GenelBilgiler>()
          .Property(e => e.Nitelik)
          .IsUnicode(false);

      modelBuilder.Entity<ImarDurumu>()
          .Property(e => e.ImarDurumuAciklama)
          .IsUnicode(false);

      modelBuilder.Entity<ImarDurumu>()
          .Property(e => e.Fotograf)
          .IsUnicode(false);

      modelBuilder.Entity<ImarDurumuBaslik>()
          .Property(e => e.Aciklama)
          .IsUnicode(false);

      modelBuilder.Entity<ImarDurumuBaslik>()
          .HasMany(e => e.ImarDurumu)
          .WithOptional(e => e.ImarDurumuBaslik1)
          .HasForeignKey(e => e.ImarDurumuBaslik);

      modelBuilder.Entity<ilceler>()
          .HasMany(e => e.GenelBilgiler)
          .WithOptional(e => e.ilceler)
          .HasForeignKey(e => e.Ilce);

      modelBuilder.Entity<iller>()
          .HasMany(e => e.GenelBilgiler)
          .WithOptional(e => e.iller)
          .HasForeignKey(e => e.Sehir);

      modelBuilder.Entity<iller>()
          .HasMany(e => e.ilceler)
          .WithRequired(e => e.iller)
          .HasForeignKey(e => e.sehir)
          .WillCascadeOnDelete(false);

      modelBuilder.Entity<ParseldeMeydanaGelenDegisiklikler>()
          .Property(e => e.Aciklama)
          .IsUnicode(false);

      modelBuilder.Entity<ParseldeMeydanaGelenDegisiklikler>()
          .HasMany(e => e.C4D)
          .WithOptional(e => e.ParseldeMeydanaGelenDegisiklikler1)
          .HasForeignKey(e => e.ParseldeMeydanaGelenDegisiklikler);

      modelBuilder.Entity<TescilNesneTipi>()
          .Property(e => e.NesneTipi)
          .IsUnicode(false);

      modelBuilder.Entity<TescilNesneTipi>()
          .HasMany(e => e.C3D)
          .WithOptional(e => e.TescilNesneTipi1)
          .HasForeignKey(e => e.TescilNesneTipi);
    }
  }
}
