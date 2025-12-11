using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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

        public ItemListView(TitanContext context, IServiceProvider provider )
        {
            InitializeComponent();
            _context = context;
            _provider = provider;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            var db = _context;

            e.Source = db.Items
            .Select(m => new Item
            {
                Id = m.Id,
                Code = m.Code,
                Name = m.Name,
                Active = m.Active,
                MainUnitCode = m.MainUnitCode,
                CreatedOnUtc = m.CreatedOnUtc,
                UpdatedOnUtc = m.UpdatedOnUtc,
                Stock = db.StockTransactions
                    .Where(t => t.ItemId == m.Id && t.VariantId == null)
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
            })
            .AsNoTracking()
            .AsQueryable();
            e.Tag = db;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = _provider.GetRequiredService<ItemView>();
            form.EditItem = null;

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

        private void gridViewItem_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            using var db = _provider.GetRequiredService<TitanContext>();

            int itemId = Convert.ToInt32(gridViewItem.GetRowCellValue(e.RowHandle, "Id"));

            var variantList = db.ItemVariants
                .Where(v => v.ItemId == itemId)
                .AsNoTracking()
                .ToList();

            if (!variantList.Any())
            {
                e.ChildList = new List<ItemVariant>();
                return;
            }

            var variantIds = variantList.Select(v => v.Id).ToList();

            var stockList = db.StockTransactions
                .Where(s => s.VariantId != null && variantIds.Contains(s.VariantId.Value))
                .AsNoTracking()
                .ToList();

            var attrList = db.ItemVariantAttributes
                .Where(a => variantIds.Contains(a.VariantId))
                .AsNoTracking()
                .ToList();

            var result = variantList.Select(v => new ItemVariant
            {
                Id = v.Id,
                VariantCode = v.VariantCode,
                Barcode = v.Barcode,
                Active = v.Active,

                Stock = stockList
                    .Where(s => s.VariantId == v.Id)
                    .Sum(s =>
                        (decimal?)s.Quantity *
                        (
                            s.TransactionType == MaterialTransactionType.PurchaseIn ||
                            s.TransactionType == MaterialTransactionType.TransferIn ||
                            s.TransactionType == MaterialTransactionType.ProductionIn ||
                            s.TransactionType == MaterialTransactionType.CountingPlus ||
                            s.TransactionType == MaterialTransactionType.ManualIn
                                ? 1 : -1
                        )
                    ) ?? 0,

                Attributes = attrList
                    .Where(a => a.VariantId == v.Id)
                    .ToDictionary(a => a.AttributeName, a => a.AttributeValue)
            })
            .ToList();

            e.ChildList = result;
        }

        private void ItemListView_Load(object sender, EventArgs e)
        {
            GridView detailView = new GridView(gridControlItem);
            gridControlItem.LevelTree.Nodes.Add("Variants", detailView);

            detailView.ViewCaption = "Varyantlar";
            detailView.OptionsView.ShowGroupPanel = false;

            detailView.Columns.AddVisible("VariantCode", "Varyant Kodu");
            detailView.Columns.AddVisible("Barcode", "Barkod");
            detailView.Columns.AddVisible("Stock", "Stok");
            detailView.Columns.AddVisible("AttributesText", "Özellikler");

            gridViewItem.MasterRowGetRelationCount += (s, args) =>
            {
                args.RelationCount = 1;
            };

            gridViewItem.MasterRowGetRelationName += (s, args) =>
            {
                args.RelationName = "Variants";
            };

            gridViewItem.MasterRowEmpty += GridViewItem_MasterRowEmpty; ;
        }

        private void GridViewItem_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            if (e.RowHandle < 0)
            {
                e.IsEmpty = true;
                return;
            }

            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            var item = view.GetRow(e.RowHandle) as Item;

            if (item == null)
            {
                e.IsEmpty = true;
                return;
            }

            using var db = _provider.GetRequiredService<TitanContext>();
            bool hasVariants = db.ItemVariants.Any(v => v.ItemId == item.Id);

            e.IsEmpty = !hasVariants;
        }
    }
}
