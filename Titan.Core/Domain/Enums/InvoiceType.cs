using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Core.Domain.Enums
{
    public enum InvoiceType : byte
    {
        Sales = 1,          // Satış Faturası
        Purchase = 2,       // Alış Faturası
        ReturnSales = 3,    // Satış İade
        ReturnPurchase = 4, // Alış İade
        Proforma = 5,
        EArchive = 6,
        EInvoice = 7
    }
}
