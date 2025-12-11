using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("ItemVariantAttribute")]
    public class ItemVariantAttribute : BaseEntity
    {
        public int VariantId { get; set; }
        public ItemVariant Variant { get; set; }
        public string AttributeName { get; set; } = string.Empty;
        public string AttributeValue { get; set; } = string.Empty;

    }
}
