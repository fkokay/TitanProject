using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("Currency")]
    public class Currency : BaseEntity, IActivatable
    {
        public string Code { get; set; } = string.Empty;   // USD, TRY, EUR
        public string Name { get; set; } = string.Empty;   // US Dollar, Turkish Lira
        public string Symbol { get; set; } = string.Empty; // $, ₺, €
        public byte Precision { get; set; } = 2;           // Ondalık hassasiyeti, USD=2 EUR=2 JPY=0

        public byte Active { get; set; } = 1;
    }
}
