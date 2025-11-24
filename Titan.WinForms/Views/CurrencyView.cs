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
using Titan.Core.Domain.Entities;
using Titan.Data;

namespace Titan.WinForms.Views
{
    public partial class CurrencyView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public CurrencyView(TitanContext context)
        {
            InitializeComponent();
            _context = context; 
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e)
        {
            var currency = new Currency
            {
                Code = textEditCode.Text,
                Name = textEditName.Text,
                Symbol = textEditSymbol.Text,
                Precision = Convert.ToByte(spinEditPrecision.Value),
                Active = 1
            };

            _context.Currencies.Add(currency);
            await _context.SaveChangesAsync();

            XtraMessageBox.Show("Kayıt başarıyla oluşturuldu.");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void simpleButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}