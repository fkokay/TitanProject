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
    public class CustomerTransactionMap : IEntityTypeConfiguration<CustomerTransaction>
    {
        public void Configure(EntityTypeBuilder<CustomerTransaction> builder)
        {
            builder.ToTable("CustomerTransactions");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.DocumentNo).HasMaxLength(50);
            builder.Property(x => x.Currency).HasMaxLength(5);

            builder.HasOne(x => x.Customer)
                   .WithMany()
                   .HasForeignKey(x => x.CustomerId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
