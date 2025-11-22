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
    public class WarehouseMap : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            builder.ToTable("Warehouses");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code).HasMaxLength(20).IsRequired();
            builder.Property(x => x.Name).HasMaxLength(100).IsRequired();
        }
    }
}
