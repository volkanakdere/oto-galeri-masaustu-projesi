using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class SatisMap : EntityTypeConfiguration<Satis>
    {
        public SatisMap()
        {
            ToTable(@"Satislar", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
