using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    class MusteriMap : IEntityTypeConfiguration<Musteri>
    {

        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.ToTable(@"Musteri", @"dbo");
            builder.HasKey(a => a.Id);
        }
    }
}
