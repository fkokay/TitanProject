using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
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
    public partial class CustomerListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _provider;
        public CustomerListView(TitanContext context, IServiceProvider provider)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;
            _provider = provider;

            barButtonItemCustomerTransaction.ItemClick += BarButtonItemCustomerTransaction_ItemClick;
        }

        private void BarButtonItemCustomerTransaction_ItemClick(object sender, ItemClickEventArgs e)
        {
            var selectedCustomer = gridViewCustomer.GetFocusedRow() as Customer;
            if (selectedCustomer == null) return;

            var form = _provider.GetRequiredService<CustomerTransactionListModalView>();
            form.SelectedCustomer = selectedCustomer;
            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            var db = _context;

            e.Source =
                 db.Customers
                 .AsNoTracking()
                 .Select(c => new Customer
                 {
                     Id = c.Id,
                     Code = c.Code,
                     Name = c.Name,
                     Active = c.Active,
                     Deleted = c.Deleted,
                     CreatedOnUtc = c.CreatedOnUtc,
                     UpdatedOnUtc = c.UpdatedOnUtc,
                     Debit =
                         db.CustomerTransactions
                             .Where(t => t.CustomerId == c.Id && t.FlowDirection == MoneyFlowDirection.Outflow)
                             .Sum(t => (decimal?)t.Amount * t.ExchangeRate) ?? 0,
                     Credit =
                         db.CustomerTransactions
                             .Where(t => t.CustomerId == c.Id && t.FlowDirection == MoneyFlowDirection.Inflow)
                             .Sum(t => (decimal?)t.Amount * t.ExchangeRate) ?? 0,

                 })
                 .AsQueryable();
            e.Tag = db;
        }

        private void barButtonItemAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = _provider.GetRequiredService<CustomerView>();

            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }
        }



        private void gridViewCustomer_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            if (e.Column.FieldName != "Balance")
                return;  // sadece Balance sütununu renklendir

            var value = gridViewCustomer.GetRowCellValue(e.RowHandle, "Balance");

            if (value is DevExpress.Data.NotLoadedObject)
                return;

            if (value == null || value == DBNull.Value)
                return;

            decimal balance = Convert.ToDecimal(value);

            if (balance > 0)
                e.Appearance.ForeColor = Color.Red;   // borç
            else if (balance < 0)
                e.Appearance.ForeColor = Color.Green; // alacak
        }

        private void gridViewCustomer_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var point = gridControlCustomer.PointToScreen(e.Location);
                popupMenu.ShowPopup(point);
            }
        }
    }
}
