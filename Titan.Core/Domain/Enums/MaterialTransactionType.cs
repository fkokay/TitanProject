using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titan.Core.Domain.Enums
{
    public enum MaterialTransactionType : byte
    {
        Unknown = 0,

        PurchaseIn = 1,        // Satın alma → Depo Girişi
        PurchaseReturn = 2,    // Alış İade

        SalesOut = 3,          // Satış → Depo Çıkış
        SalesReturn = 4,       // Satış İade

        TransferIn = 5,        // Transfer giriş
        TransferOut = 6,       // Transfer çıkış

        ProductionIn = 7,      // Üretimden giriş
        ProductionOut = 8,     // Üretime sarf

        CountingPlus = 9,      // Sayım fazla
        CountingMinus = 10,    // Sayım eksi

        ManualIn = 11,         // Manuel giriş
        ManualOut = 12         // Manuel çıkış
    }
}
