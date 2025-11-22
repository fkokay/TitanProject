using DevExpress.XtraEditors;
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

namespace Titan.WinForms.UserControls
{
    public partial class CurrencyListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        public CurrencyListView(TitanContext context)
        {
            InitializeComponent();
            _context = context;

            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.Currencies.AsQueryable();
            e.Tag = _context;
        }
    }
}
