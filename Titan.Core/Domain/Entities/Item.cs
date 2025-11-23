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
        public string MainUnitCode { get; set; } = "ADET";
        [NotMapped]
        public decimal Stock { get; set; }
        public byte Active { get; set; } = 1;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
    }
}
