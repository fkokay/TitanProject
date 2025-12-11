using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("InvoiceLine")]
    public class InvoiceLine : BaseEntity
    {
        public int InvoiceId { get; set; }
        public Invoice Invoice { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public int? VariantId { get; set; }
        public ItemVariant Variant { get; set; }
        public decimal Quantity { get; set; }
        public string Unit { get; set; } = "ADET";
        public decimal UnitPrice { get; set; }
        public string Currency { get; set; } = "TRY";
        public decimal ExchangeRate { get; set; } = 1m;
        public decimal TotalForeign { get; set; }             // USD/EUR toplam
        public decimal TotalLocal { get; set; }
        public decimal Discount { get; set; }
        public decimal TaxRate { get; set; }
        public decimal LineTotal { get; set; }
    }
}
