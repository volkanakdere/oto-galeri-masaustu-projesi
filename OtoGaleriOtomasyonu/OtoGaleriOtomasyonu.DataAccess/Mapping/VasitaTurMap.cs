using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class VasitaTurMap : EntityTypeConfiguration<VasitaTur>
    {
        public VasitaTurMap()
        {
            ToTable(@"VasitaTurleri", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
