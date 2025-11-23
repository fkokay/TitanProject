using DevExpress.XtraEditors;
using Microsoft.EntityFrameworkCore;
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

namespace Titan.WinForms.UserControls
{
    public partial class InvoiceListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        public InvoiceType InvoiceType;
        public InvoiceListView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;

        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.Invoices.Include(m => m.Customer).Where(m => m.InvoiceType == InvoiceType).AsQueryable();
            e.Tag = _context;
        }
    }
}
