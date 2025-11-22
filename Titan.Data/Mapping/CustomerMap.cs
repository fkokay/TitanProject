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
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.ToTable("Customers");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Code)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(200);

            // BaseEntity alanları (Active, Deleted, PeriodId, vs.)
            builder.Property(x => x.Active)
                   .HasDefaultValue((byte)1);

            builder.Property(x => x.Deleted)
                   .HasDefaultValue(false);
        }
    }
}
