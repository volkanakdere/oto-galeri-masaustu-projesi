
using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class KullaniciMap : EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            ToTable(@"Kullanicilar", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
