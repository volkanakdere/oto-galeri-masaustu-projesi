using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class KasaTipMap : EntityTypeConfiguration<KasaTip>
    {
        public KasaTipMap()
        {
            ToTable(@"KasaTipleri", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
