using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.WinForms.Models
{
    public class ItemModel
    {
        public int Id { get; set; }
        public int? VariantId { get; set; }
        public string VariantCode { get; set; } = string.Empty;
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
        public decimal Stock { get; set; } = 0;
        public decimal Vat { get; set; } = 0;
        public decimal SellVat { get; set; } = 0;
        public decimal ReturnVat { get; set; } = 0;
        public byte Active { get; set; } = 1;
        public DateTime CreatedOnUtc { get; set; } 
        public DateTime UpdatedOnUtc { get; set; } 
        public bool HasVariants { get; set; } = false;
    }
}
