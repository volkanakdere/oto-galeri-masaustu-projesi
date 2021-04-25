using System;
using System.Collections.Generic;
using System.Text;
using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Mapping
{
    public class AracMap : IEntityTypeConfiguration<Arac>
    {
        public void Configure(EntityTypeBuilder<Arac> builder)
        {
            builder.ToTable(@"Araclar",@"dbo");
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).HasColumnName("Id");
            builder.Property(a => a.Aciklama).HasColumnName("Aciklama");
            builder.Property(a => a.Fiyat).HasColumnName("Fiyat");
            builder.Property(a => a.HasarKaydiTutari).HasColumnName("HasarKaydiTutari");
            builder.Property(a => a.HasarKaydiVarMi).HasColumnName("HasarKaydiVarMi");
            builder.Property(a => a.KasaTipId).HasColumnName("KasaTipId");
            builder.Property(a => a.Kilometre).HasColumnName("Kilometre");
            builder.Property(a => a.MarkaId).HasColumnName("MarkaId");
            builder.Property(a => a.ModelId).HasColumnName("ModelId");
            builder.Property(a => a.ModelYili).HasColumnName("ModelYili");
            builder.Property(a => a.MotorGucu).HasColumnName("MotorGucu");
            builder.Property(a => a.MotorHacmi).HasColumnName("MotorHacmi");
            builder.Property(a => a.Plaka).HasColumnName("Plaka");
            builder.Property(a => a.Renk).HasColumnName("Renk");
            builder.Property(a => a.RuhsatNo).HasColumnName("RuhsatNo");
            builder.Property(a => a.SasiNo).HasColumnName("SasiNo");
            builder.Property(a => a.SatildiMi).HasColumnName("SatildiMi");
            builder.Property(a => a.SonBakimTarihi).HasColumnName("SonBakimTarihi");
            builder.Property(a => a.SonMuayeneTarihi).HasColumnName("SonMuayeneTarihi");
            builder.Property(a => a.VasitaTurId).HasColumnName("VasitaTurId");
            builder.Property(a => a.VitesTipId).HasColumnName("VitesTipId");
            builder.Property(a => a.YakitTurId).HasColumnName("YakitTurId");
            
        }
    }
}
