using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    [Table("Unit")]
    public class Unit : BaseEntity, IActivatable
    {
        public string Code { get; set; } = string.Empty;   // ADET, KG, LT, M2
        public string Name { get; set; } = string.Empty;   // adet, kilogram
        public byte Precision { get; set; } = 2;           // Ondalık hassasiyeti
        public byte Active { get; set; }
    }
}
