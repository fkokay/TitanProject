using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Core.Domain.Entities;

namespace Titan.Data.Mapping
{
    public class InvoiceLineMap : IEntityTypeConfiguration<InvoiceLine>
    {
        public void Configure(EntityTypeBuilder<InvoiceLine> builder)
        {
            builder.ToTable("InvoiceLines");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Invoice)
                .WithMany(x => x.Lines)
                .HasForeignKey(x => x.InvoiceId);

            builder.Property(x => x.Unit).HasMaxLength(10);
            builder.Property(x => x.Quantity).HasPrecision(18, 4);
            builder.Property(x => x.UnitPrice).HasPrecision(18, 2);
            builder.Property(x => x.LineTotal).HasPrecision(18, 2);
        }
    }
}
