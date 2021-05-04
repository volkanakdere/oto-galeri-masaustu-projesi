using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    class VasitaTurMap : IEntityTypeConfiguration<VasitaTur>
    {
        public void Configure(EntityTypeBuilder<VasitaTur> builder)
        {
            builder.ToTable(@"VasitaTurleri", @"dbo");
            builder.HasKey(a => a.Id);
        }
    }
}
