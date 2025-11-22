using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Core.Domain.Enums
{
    public enum TransactionSourceType : byte
    {
        Unknown = 0,
        Invoice = 1,
        Receipt = 2,
        Order = 3,
        StockTransaction = 4,
        Manual = 5,
        OpeningBalance = 6
    }
}
