using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataAccess.Mapping
{
    public class MusteriMap : EntityTypeConfiguration<Musteri>
    {

        public MusteriMap()
        {
            ToTable(@"Musteri", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
