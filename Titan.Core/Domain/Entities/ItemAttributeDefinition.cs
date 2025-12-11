using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("ItemAttributeDefinition")]
    public class ItemAttributeDefinition : BaseEntity
    {
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string AttributeName { get; set; } = string.Empty;
        public string DisplayName { get; set; } = string.Empty;
    }
}
