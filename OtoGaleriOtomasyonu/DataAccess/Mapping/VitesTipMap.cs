using Entities.Domains;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Mapping
{
    class VitesTipMap : IEntityTypeConfiguration<VitesTip>
    {
        public void Configure(EntityTypeBuilder<VitesTip> builder)
        {
            builder.ToTable(@"VitesTipleri", @"dbo");
            builder.HasKey(a => a.Id);

        }
    }
}
