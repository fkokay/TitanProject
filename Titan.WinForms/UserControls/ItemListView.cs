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

            e.Source = db.Items.AsNoTracking().AsQueryable();
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
    }
}
