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
using Titan.Core.Domain.Enums;
using Titan.Data;
using Titan.WinForms.Views;

namespace Titan.WinForms.UserControls
{
    public partial class InvoiceListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _provider;
        public InvoiceType InvoiceType;
        public InvoiceListView(TitanContext context, IServiceProvider provider)
        {
            InitializeComponent();
            _context = context;
            _provider = provider;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;

        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.Invoices.Include(m => m.Customer).Where(m => m.InvoiceType == InvoiceType).AsQueryable();
            e.Tag = _context;
        }

        private void barButtonItemEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var form = _provider.GetRequiredService<InvoiceView>();
            var invoiceId = Convert.ToInt32(gridViewInvoice.GetFocusedRowCellValue("Id"));
            form.EditInvoice = _context.Invoices.Include(m => m.Customer).FirstOrDefault(i => i.Id == invoiceId);
            form.InvoiceType = InvoiceType;
            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }

        }

        private void gridViewInvoice_DoubleClick(object sender, EventArgs e)
        {
            var form = _provider.GetRequiredService<InvoiceView>();
            var invoiceId = Convert.ToInt32(gridViewInvoice.GetFocusedRowCellValue("Id"));
            form.EditInvoice = _context.Invoices.Include(m => m.Customer).FirstOrDefault(i => i.Id == invoiceId);
            form.InvoiceType = InvoiceType;
            if (form.ShowDialog() == DialogResult.OK)
            {
                pLinqInstantFeedbackSource.Refresh();
            }
        }
    }
}
