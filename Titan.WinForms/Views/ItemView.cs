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
using Titan.Core.Utils;

namespace Titan.WinForms.Views
{
    public partial class ItemView : DevExpress.XtraEditors.XtraForm
    {
        private readonly TitanContext _context;
        public Item EditItem = null;
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
            if (EditItem == null)
            {
                var item = new Item();
                item.Code = textEditCode.Text;
                item.Name = textEditName.Text;
                item.Name2 = textEditName2.Text;
                item.Name3 = textEditName3.Text;
                item.Name4 = "";
                item.MainUnitCode = lookUpEditUnit.EditValue.ToString();
                item.Active = Convert.ToByte(comboBoxEditActive.SelectedIndex);
                item.SpeCode = textEditSpecode.Text;
                item.CyphCode = textEditCyphCode.Text;
                item.GroupCode = textEditGroupCode.Text;
                item.ManufacturerCode = textEditManufacturerCode.Text;
                item.SpeCode2 = textEditSpeCode2.Text;
                item.SpeCode3 = textEditSpeCode3.Text;
                item.SpeCode4 = textEditSpeCode4.Text;
                item.SpeCode5 = textEditSpeCode5.Text;
                item.Vat = textEditVat.Value;
                item.SellVat = textEditSellVat.Value;
                item.ReturnVat = textEditReturnVat.Value;


                _context.Items.Add(item);
                await _context.SaveChangesAsync();

                XtraMessageBox.Show("Kayıt başarıyla oluşturuldu.");
            }
            else
            {
                EditItem.Code = textEditCode.Text;
                EditItem.Name = textEditName.Text;
                EditItem.Name2 = textEditName2.Text;
                EditItem.Name3 = textEditName3.Text;
                EditItem.MainUnitCode = lookUpEditUnit.EditValue.ToString();
                EditItem.Active = Convert.ToByte(comboBoxEditActive.SelectedIndex);
                EditItem.SpeCode = textEditSpecode.Text;
                EditItem.CyphCode = textEditCyphCode.Text;
                EditItem.GroupCode = textEditGroupCode.Text;
                EditItem.ManufacturerCode = textEditManufacturerCode.Text;
                EditItem.SpeCode2 = textEditSpeCode2.Text;
                EditItem.SpeCode3 = textEditSpeCode3.Text;
                EditItem.SpeCode4 = textEditSpeCode4.Text;
                EditItem.SpeCode5 = textEditSpeCode5.Text;
                EditItem.Vat = textEditVat.Value;
                EditItem.SellVat = textEditSellVat.Value;
                EditItem.ReturnVat = textEditReturnVat.Value;
                await _context.SaveChangesAsync();
                XtraMessageBox.Show("Kayıt başarıyla güncellendi.");
            }

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
            await LoadCode();
            LoadForm();
        }

        private async Task LoadCode()
        {
            if (EditItem == null)
            {
                var lastItem = await _context.Items.OrderByDescending(i => i.CreatedOnUtc).FirstOrDefaultAsync();
                if (lastItem != null)
                {
                    textEditCode.Text = MainUtils.NextKeyCode(lastItem.Code);
                }
                else
                {
                    textEditCode.Text = "000000000000000000000001";
                }
            }
        }

        private void LoadForm()
        {
            if (EditItem != null)
            {
                textEditCode.Text = EditItem.Code;
                textEditName.Text = EditItem.Name;
                textEditName2.Text = EditItem.Name2;
                textEditName3.Text = EditItem.Name3;
                lookUpEditUnit.EditValue = EditItem.MainUnitCode;
                comboBoxEditActive.SelectedIndex = EditItem.Active;
                textEditSpecode.Text = EditItem.SpeCode;
                textEditCyphCode.Text = EditItem.CyphCode;
                textEditGroupCode.Text = EditItem.GroupCode;
                textEditManufacturerCode.Text = EditItem.ManufacturerCode;
                textEditSpeCode2.Text = EditItem.SpeCode2;
                textEditSpeCode3.Text = EditItem.SpeCode3;
                textEditSpeCode4.Text = EditItem.SpeCode4;
                textEditSpeCode5.Text = EditItem.SpeCode5;
                textEditVat.Value = EditItem.Vat;
                textEditSellVat.Value = EditItem.SellVat;
                textEditReturnVat.Value = EditItem.ReturnVat;
            }
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