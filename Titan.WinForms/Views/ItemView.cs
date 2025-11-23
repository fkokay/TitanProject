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
using Microsoft.EntityFrameworkCore;

namespace Titan.WinForms.Views
{
    public partial class ItemView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public ItemView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSourceUnitConversion.GetEnumerable += PLinqInstantFeedbackSourceUnitConversion_GetEnumerable; ;
       }

        private void PLinqInstantFeedbackSourceUnitConversion_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.ItemUnitConversions.AsQueryable();
            e.Tag = _context;
        }

        private async void simpleButtonSave_Click(object sender, EventArgs e)
        {
            var item = new Item();
            item.Code = textEditCode.Text;
            item.Name = textEditName.Text;
            item.MainUnitCode = lookUpEditUnit.EditValue.ToString();
            item.Active = 1;

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

        private async void ItemView_Load(object sender, EventArgs e)
        {
            await LoadUnits();
        }

        private async Task LoadUnits()
        {
            try
            {
                var units = await _context.Units.ToListAsync();
                lookUpEditUnit.Properties.DataSource = units;
                lookUpEditUnit.Properties.DisplayMember = "Name";
                lookUpEditUnit.Properties.ValueMember = "Code";
                lookUpEditUnit.Properties.NullText = "Seçiniz...";
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }
    }
}