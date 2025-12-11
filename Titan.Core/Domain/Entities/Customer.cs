using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    public class Customer : BaseEntity, IActivatable, ISoftDeletable, IAuditable
    {
        public string Code { get; set; } = string.Empty;
        public string Definition { get; set; } = string.Empty;
        public string Definition2 { get; set; } = string.Empty;
        public string Address1  { get; set; } = string.Empty;
        public string Address2 { get; set; } = string.Empty;
        public string District { get; set; } = string.Empty;
        public string Town { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string EmailAddress { get; set; } = string.Empty;
        public string TaxNumber { get; set; } = string.Empty;
        public string TaxOffice { get; set; } = string.Empty;
        public bool IsCompany { get; set; } = true;
        public string TckNo { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string SpeCode { get; set; } = string.Empty;
        public string SpeCode2 { get; set; } = string.Empty;
        public string SpeCode3 { get; set; } = string.Empty;
        public string SpeCode4 { get; set; } = string.Empty;
        public string SpeCode5 { get; set; } = string.Empty;
        public string CyphCode { get; set; } = string.Empty;
        public string Incharge { get; set; } = string.Empty;
        [NotMapped]
        public decimal Debit { get; set; }
        [NotMapped]
        public decimal Credit { get; set; }
        [NotMapped]
        public decimal Balance
        {
            get
            {
                return Debit - Credit;
            }
        }
        public byte Active { get; set; } = 1;
        public bool Deleted { get; set; } = false;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;

    }
}
