using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    class SatisMap : IEntityTypeConfiguration<Satis>
    {
        public void Configure(EntityTypeBuilder<Satis> builder)
        {
            builder.ToTable(@"Satislar", @"dbo");
            builder.HasKey(a => a.Id);

        }
    }
}
