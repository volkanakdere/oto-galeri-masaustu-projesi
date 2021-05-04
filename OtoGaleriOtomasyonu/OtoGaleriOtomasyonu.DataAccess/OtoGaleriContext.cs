using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DataAccess
{
    public class OtoGaleriContext : DbContext
    {
        public OtoGaleriContext()
        {
            Database.SetInitializer<OtoGaleriContext>(null);
        }

        public DbSet<Arac> Araclar { get; set; }
        public DbSet<KasaTip> KasaTipleri { get; set; }
        public DbSet<Kullanici> Kullanicilar { get; set; }
        public DbSet<Marka> Markalar { get; set; }
        public DbSet<Model> Modeller { get; set; }
        public DbSet<Musteri> Musteriler { get; set; }
        public DbSet<Satis> Satislar { get; set; }
        public DbSet<VasitaTur> VasitaTurleri { get; set; }
        public DbSet<VitesTip> VitesTipleri { get; set; }
        public DbSet<YakitTur> YakitTurleri { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
