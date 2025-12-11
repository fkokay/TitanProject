using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("ItemUnitConversion")]
    public class ItemUnitConversion : BaseEntity
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string FromUnitCode { get; set; } = string.Empty;   // KOLİ
        public string ToUnitCode { get; set; } = string.Empty;     // ADET
        public decimal Factor { get; set; }    // 1 KOLİ = 12 ADET → Factor = 12
        public byte Active { get; set; } = 1;
    }
}
