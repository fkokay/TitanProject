using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titan.Core.Domain.Enums;
using TitanProject.Core.Common;

namespace Titan.Core.Domain.Entities
{
    public class StockTransaction : BaseEntity, IActivatable, ISoftDeletable, IAuditable
    {
        // Malzeme
        public int ItemId { get; set; }
        public Item Item { get; set; }

        // Depo / Ambar
        public int WarehouseId { get; set; }
        public Warehouse Warehouse { get; set; }

        // Hareket tipi (giriş–çıkış)
        public MaterialTransactionType TransactionType { get; set; }

        public DateTime TransactionDate { get; set; }

        // Miktar
        public decimal Quantity { get; set; }

        // Birim fiyat
        public decimal UnitPrice { get; set; }

        // Toplam
        public decimal Total { get; set; }

        // Döviz desteği
        public string Currency { get; set; } = "TRY";
        public decimal ExchangeRate { get; set; } = 1m;
        public decimal LocalTotal { get; set; }

        // Hareket sonrası stok bakiyesi (FIFO/LIFO için)
        public decimal StockBalance { get; set; }

        // Kaynak ilişki (Fatura / İrsaliye / Sipariş / Üretim)
        public TransactionSourceType SourceType { get; set; }
        public int? SourceId { get; set; }

        public string DocumentNo { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public byte Active { get; set; } = 1;
        public bool Deleted { get; set; } = false;
        public DateTime CreatedOnUtc { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedOnUtc { get; set; } = DateTime.UtcNow;
    }
}
