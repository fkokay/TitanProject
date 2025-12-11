using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("ExchangeRate")]
    public class ExchangeRate : BaseEntity
    {
        public string CurrencyCode { get; set; } = string.Empty;
        public DateTime RateDate { get; set; }
        public decimal BuyingRate { get; set; }
        public decimal SellingRate { get; set; }
    }
}
