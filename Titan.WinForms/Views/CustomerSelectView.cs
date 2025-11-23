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
using Titan.Core.Domain.Enums;
using Titan.Data;

namespace Titan.WinForms.Views
{
    public partial class CustomerSelectView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public Customer SelectCustomer;
        public CustomerSelectView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            e.Source =
                 _context.Customers
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
                         _context.CustomerTransactions
                             .Where(t => t.CustomerId == c.Id && t.FlowDirection == MoneyFlowDirection.Outflow)
                             .Sum(t => (decimal?)t.Amount * t.ExchangeRate) ?? 0,
                     Credit =
                         _context.CustomerTransactions
                             .Where(t => t.CustomerId == c.Id && t.FlowDirection == MoneyFlowDirection.Inflow)
                             .Sum(t => (decimal?)t.Amount * t.ExchangeRate) ?? 0,

                 })
                 .AsQueryable();
            e.Tag = _context;
        }

        private void simpleButtonSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer = (Customer)gridViewCustomer.GetFocusedRow();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void gridViewCustomer_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewCustomer.GetFocusedRow()  == null)
            {
                return;
            }

            SelectCustomer = (Customer)gridViewCustomer.GetFocusedRow();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}