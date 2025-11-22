using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Core.Domain.Enums
{
    public enum InvoiceStatus : byte
    {
        Draft = 0,
        Approved = 1,
        Cancelled = 2,
        EInvoiceSent = 3,
        EArchiveSent = 4
    }
}
