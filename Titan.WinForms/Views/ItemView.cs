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
using Titan.Core.Domain.Entities;

namespace Titan.WinForms.Views
{
    public partial class ItemView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public ItemView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e)
        {
            var item = new Item
            {
                Code = textEditCode.Text,
                Name = textEditName.Text,
                Active = 1
            };

            _context.Items.Add(item);
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