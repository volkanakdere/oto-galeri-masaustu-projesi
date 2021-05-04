using OtoGaleriOtomasyonu.Entities.Domains;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Text;

namespace DataAccess.Mapping
{
    public class ModelMap : EntityTypeConfiguration<Model>
    {
        public ModelMap()
        {
            ToTable(@"Modeller", @"dbo");
            HasKey(a => a.Id);
        }
    }
}
