using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace OtoGaleriOtomasyonu.DataAccess.Mapping
{
    public class VitesTipMap : EntityTypeConfiguration<VitesTip>
    {
        public VitesTipMap()
        {
            ToTable(@"VitesTipleri", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
