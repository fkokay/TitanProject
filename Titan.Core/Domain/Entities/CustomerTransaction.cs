using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Core.Domain.Enums;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("CustomerTransaction")]
    public class CustomerTransaction : BaseEntity, IAuditable
    {
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime DueDate { get; set; }
        public string DocumentNo { get; set; } = string.Empty;
        public int SourceId { get; set; }
        public TransactionSourceType SourceType { get; set; }
        public decimal Amount { get; set; }
        public MoneyFlowDirection FlowDirection { get; set; }
        public string Currency { get; set; } = string.Empty;
        public decimal ExchangeRate { get; set; }
        public string Description { get; set; } = string.Empty;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
    }
}
