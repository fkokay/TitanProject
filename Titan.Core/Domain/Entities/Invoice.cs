using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Core.Domain.Enums;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    public class Invoice : BaseEntity, IAuditable
    {
        public InvoiceType InvoiceType { get; set; }
        public string InvoiceNo { get; set; } = string.Empty;
        public DateTime InvoiceDate { get; set; } = DateTime.Now;
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public string Description { get; set; } = string.Empty;
        public string Currency { get; set; } = "TRY";
        public decimal ExchangeRate { get; set; } = 1m;
        public decimal SubTotal { get; set; }
        public decimal DiscountTotal { get; set; }
        public decimal TaxTotal { get; set; }
        public decimal GrandTotal { get; set; }
        public int? DispatchNoteId { get; set; }
        public TransactionSourceType SourceType { get; set; } = TransactionSourceType.Unknown;
        public int? SourceId { get; set; }
        public string UUID { get; set; }
        public string EInvoiceStatusMessage { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public DateTime UpdatedOnUtc { get; set; }

        public ICollection<InvoiceLine> Lines { get; set; }
    }
}
