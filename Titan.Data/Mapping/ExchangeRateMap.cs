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
    public class ExchangeRateMap : IEntityTypeConfiguration<ExchangeRate>
    {
        public void Configure(EntityTypeBuilder<ExchangeRate> builder)
        {
            builder.ToTable("ExchangeRates");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.CurrencyCode).HasMaxLength(3).IsRequired();
        }
    }
}
