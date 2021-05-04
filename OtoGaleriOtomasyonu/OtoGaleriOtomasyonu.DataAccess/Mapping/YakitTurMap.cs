using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class YakitTurMap : EntityTypeConfiguration<YakitTur>
    {
        public YakitTurMap()
        {
            ToTable(@"YakitTurleri", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
