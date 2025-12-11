using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("ItemVariant")]
    public class ItemVariant : BaseEntity
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string VariantCode { get; set; } = string.Empty;
        public string Sku { get; set; } = string.Empty;
        public string Barcode { get; set; } = string.Empty;
        [NotMapped]
        public decimal Stock { get; set; }
        [NotMapped]
        public Dictionary<string, string> Attributes { get; set; } = new Dictionary<string, string>();
        [NotMapped]
        public string AttributesText
        {
            get
            {
                if (Attributes == null || Attributes.Count == 0)
                    return string.Empty;

                return string.Join(", ", Attributes.Select(a => $"{a.Key}: {a.Value}"));
            }
        }

        public byte Active { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
