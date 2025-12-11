using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Titan.Core.Domain.Entities;
using Titan.Core.Domain.Enums;
using Titan.Data;
using Titan.WinForms.Views;

namespace Titan.WinForms.UserControls
{
    public partial class ItemListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _provider;
        public ItemListView(TitanContext context, IServiceProvider provider)
        {
            InitializeComponent();
            _context = context;
            _provider = provider;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            var db = _context;

            e.Source = db.Items.Select(m => new Item()
            {
                Active = m.Active,
                Code = m.Code,
                CreatedOnUtc = m.CreatedOnUtc,
                Id = m.Id,
                MainUnitCode = m.MainUnitCode,
                Name = m.Name,
                Stock = db.StockTransactions
                .Where(t => t.ItemId == m.Id)
                .Sum(t =>
                    (decimal?)t.Quantity *
                    (
                        t.TransactionType == MaterialTransactionType.PurchaseIn ||
                        t.TransactionType == MaterialTransactionType.TransferIn ||
                        t.TransactionType == MaterialTransactionType.ProductionIn ||
                        t.TransactionType == MaterialTransactionType.CountingPlus ||
                        t.TransactionType == MaterialTransactionType.ManualIn
                            ? 1 : -1
                    )
                ) ?? 0,
                UpdatedOnUtc = m.UpdatedOnUtc
            }).AsNoTracking().AsQueryable();
            e.Tag = db;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = _provider.GetRequiredService<ItemView>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = _provider.GetRequiredService<ItemView>();
            var itemId = Convert.ToInt32(gridViewItem.GetFocusedRowCellValue("Id"));
            form.EditItem = _context.Items.FirstOrDefault(i => i.Id == itemId);
            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }
        }

        private void barButtonItemDelete_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var itemId = Convert.ToInt32(gridViewItem.GetFocusedRowCellValue("Id"));
            var item = _context.Items.FirstOrDefault(i => i.Id == itemId);
            if (item != null)
            {
                var result = XtraMessageBox.Show($"'{item.Name}' öğesini silmek istediğinizden emin misiniz?", "Onayla", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    _context.Items.Remove(item);
                    _context.SaveChanges();
                    pLinqInstantFeedbackSource.Refresh();
                }
            }

        }

        private void barButtonItemRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            pLinqInstantFeedbackSource.Refresh();
        }
    }
}
