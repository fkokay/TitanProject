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
using Titan.Core.Domain.Entities;
using Titan.Data;

namespace Titan.WinForms.Views
{
    public partial class CustomerTransactionListModalView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public Customer SelectedCustomer;
        public CustomerTransactionListModalView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;


        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.CustomerTransactions.Where(m => m.CustomerId == SelectedCustomer.Id).Include(m => m.Customer).AsQueryable();
            e.Tag = _context;
        }

        private void CustomerTransactionListModalView_Load(object sender, EventArgs e)
        {
            this.Text = SelectedCustomer.Name + " " + "Cari Hesap Hareketleri";
        }
    }
}
