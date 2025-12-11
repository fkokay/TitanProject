using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    public class Item : BaseEntity, IActivatable, IAuditable
    {
        public string Code { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Name2 { get; set; } = string.Empty;
        public string Name3 { get; set; } = string.Empty;
        public string Name4 { get; set; } = string.Empty;
        public string MainUnitCode { get; set; } = "ADET";
        public string SpeCode { get; set; } = string.Empty;
        public string SpeCode2 { get; set; } = string.Empty;
        public string SpeCode3 { get; set; } = string.Empty;
        public string SpeCode4 { get; set; } = string.Empty;
        public string SpeCode5 { get; set; } = string.Empty;
        public string CyphCode { get; set; } = string.Empty;
        public string GroupCode { get; set; } = string.Empty;
        public string ManufacturerCode { get; set; } = string.Empty;

        [NotMapped]
        public decimal Stock { get; set; }
        public decimal Vat { get; set; } 
        public decimal SellVat { get; set; }
        public decimal ReturnVat { get; set; }
        public byte Active { get; set; } = 1;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
    }
}
