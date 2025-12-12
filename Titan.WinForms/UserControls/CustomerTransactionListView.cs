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
using Titan.Data;
using Titan.WinForms.Views;

namespace Titan.WinForms.UserControls
{
    public partial class CustomerTransactionListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _provider;
        public CustomerTransactionListView(TitanContext context, IServiceProvider provider)
        {
            InitializeComponent();
            _context = context;
            _provider = provider;

            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.CustomerTransactions.Include(m => m.Customer).AsQueryable();
            e.Tag = _context;
        }

        private void gridControlCustomerTransaction_DoubleClick(object sender, EventArgs e)
        {
            var transactionId = Convert.ToInt32(gridViewCustomerTransaction.GetFocusedRowCellValue("Id"));
            var transaction = _context.CustomerTransactions.Include(m => m.Customer).FirstOrDefault(i => i.Id == transactionId);
            if (transaction.SourceType == Core.Domain.Enums.TransactionSourceType.Invoice)
            {
                var invoice = _context.Invoices.Include(m => m.Customer).Where(m => m.Id == transaction.SourceId).FirstOrDefault();
                if (invoice != null)
                {
                    var form = _provider.GetRequiredService<InvoiceView>();
                    form.EditInvoice = invoice;
                    form.InvoiceType = invoice.InvoiceType;
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        pLinqInstantFeedbackSource.Refresh();
                    }
                }
            }

        }
    }
}
