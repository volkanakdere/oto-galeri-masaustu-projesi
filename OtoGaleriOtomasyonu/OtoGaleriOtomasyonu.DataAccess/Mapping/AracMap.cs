using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class AracMap : EntityTypeConfiguration<Arac>
    {
        public AracMap()
        {
            ToTable(@"Araclar", @"dbo");
            HasKey(a => a.Id);

            Property(a => a.Id).HasColumnName("Id");
            Property(a => a.Aciklama).HasColumnName("Aciklama");
            Property(a => a.Fiyat).HasColumnName("Fiyat");
            Property(a => a.HasarKaydiTutari).HasColumnName("HasarKaydiTutari");
            Property(a => a.HasarKaydiVarMi).HasColumnName("HasarKaydiVarMi");
            Property(a => a.KasaTipId).HasColumnName("KasaTipId");
            Property(a => a.Kilometre).HasColumnName("Kilometre");
            Property(a => a.MarkaId).HasColumnName("MarkaId");
            Property(a => a.ModelId).HasColumnName("ModelId");
            Property(a => a.ModelYili).HasColumnName("ModelYili");
            Property(a => a.MotorGucu).HasColumnName("MotorGucu");
            Property(a => a.MotorHacmi).HasColumnName("MotorHacmi");
            Property(a => a.Plaka).HasColumnName("Plaka");
            Property(a => a.Renk).HasColumnName("Renk");
            Property(a => a.RuhsatNo).HasColumnName("RuhsatNo");
            Property(a => a.SasiNo).HasColumnName("SasiNo");
            Property(a => a.SatildiMi).HasColumnName("SatildiMi");
            Property(a => a.SonBakimTarihi).HasColumnName("SonBakimTarihi");
            Property(a => a.SonMuayeneTarihi).HasColumnName("SonMuayeneTarihi");
            Property(a => a.VasitaTurId).HasColumnName("VasitaTurId");
            Property(a => a.VitesTipId).HasColumnName("VitesTipId");
            Property(a => a.YakitTurId).HasColumnName("YakitTurId");
        }
    }
}
