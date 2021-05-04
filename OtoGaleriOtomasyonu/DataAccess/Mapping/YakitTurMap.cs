using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    class YakitTurMap : IEntityTypeConfiguration<YakitTur>
    {
        public void Configure(EntityTypeBuilder<YakitTur> builder)
        {
            builder.ToTable(@"YakitTurleri", @"dbo");
            builder.HasKey(a => a.Id);
        }
    }
}
