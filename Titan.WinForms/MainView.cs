using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Titan.Data;
using Titan.WinForms.UserControls;

namespace Titan.WinForms
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _serviceProvider;
        public MainView(TitanContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;

            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
            // View and ViewModel Lifetime
            fluent.WithEvent(this, nameof(HandleCreated))
                .EventToCommand(x => x.OnCreate);
            fluent.WithEvent(this, nameof(HandleDestroyed))
                .EventToCommand(x => x.OnDestroy);
            // Bind the Title property to the Text
            fluent.SetBinding(this, view => view.Text, x => x.Title);
        }

        private void barButtonItemCustomerList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var view = _serviceProvider.GetRequiredService<CustomerListView>();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
        }

        private void barButtonItemItem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var view = _serviceProvider.GetRequiredService<ItemListView>();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
        }

        private void barButtonItemWarehouse_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            var view = _serviceProvider.GetRequiredService<WarehouseListView>();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
        }

        private void barButtonItemQuikSale_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            panelMain.Controls.Clear();
            var view = _serviceProvider.GetRequiredService<QuickSaleView>();
            view.Dock = DockStyle.Fill;
            panelMain.Controls.Add(view);
        }
    }
}
