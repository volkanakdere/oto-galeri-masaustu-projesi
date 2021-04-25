using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    public class KasaTipMap : IEntityTypeConfiguration<KasaTip>
    {
        public void Configure(EntityTypeBuilder<KasaTip> builder)
        {
            builder.ToTable(@"KasaTipleri", @"dbo");
            builder.HasKey(a => a.Id);
        }
    }
}
