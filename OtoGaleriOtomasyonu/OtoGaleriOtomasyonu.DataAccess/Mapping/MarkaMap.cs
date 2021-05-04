using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataAccess.Mapping
{
    public class MarkaMap : EntityTypeConfiguration<Marka>
    {
        public MarkaMap()
        {
            ToTable(@"Markalar", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
