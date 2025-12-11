using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("Warehouse")]
    public class Warehouse : BaseEntity, IActivatable, ISoftDeletable, IAuditable
    {
        public string Code { get; set; } = string.Empty;        // AMB001
        public string Name { get; set; } = string.Empty;        // Merkez Depo
        public string Address { get; set; } = string.Empty;
        public byte Active { get; set; } = 1;
        public bool Deleted { get; set; } = false;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
    }
}
