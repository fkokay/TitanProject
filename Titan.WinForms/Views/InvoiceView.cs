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
using Titan.Core.Domain.Enums;
using Titan.Data;

namespace Titan.WinForms.Views
{
    public partial class InvoiceView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _serviceProvider;

        public InvoiceType InvoiceType;
        public InvoiceView(TitanContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;
        }

        private void buttonEditCustomerCode_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = _serviceProvider.GetRequiredService<CustomerListModalView>();
            if (view.ShowDialog() == DialogResult.OK)
            {
                buttonEditCustomerCode.Text = view.SelectCustomer.Code;
                buttonEditCustomerName.Text = view.SelectCustomer.Name;
            }
        }

        private void buttonEditCustomerName_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var view = _serviceProvider.GetRequiredService<CustomerListModalView>();
            if (view.ShowDialog() == DialogResult.OK)
            {
                buttonEditCustomerCode.Text = view.SelectCustomer.Code;
                buttonEditCustomerName.Text = view.SelectCustomer.Name;
            }
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {
            if (InvoiceType == InvoiceType.Sales)
            {
                this.Text = "Satış Faturası";
            }
        }
    }
}