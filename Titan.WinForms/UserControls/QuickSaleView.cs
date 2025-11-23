using DevExpress.XtraEditors;
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
using Titan.WinForms.Views;

namespace Titan.WinForms.UserControls
{
    public partial class QuickSaleView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly IServiceProvider _serviceProvider;
        public QuickSaleView(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonEditCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var view = _serviceProvider.GetRequiredService<CustomerSelectView>();
            if (view.ShowDialog() == DialogResult.OK)
            {
                buttonEditCustomer.Text = view.SelectCustomer.Name;
            }
        }
    }
}
