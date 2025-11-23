using DevExpress.XtraEditors;
using DevExpress.XtraSpreadsheet.Utils;
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
using Titan.WinForms.Models;

namespace Titan.WinForms.Views
{
    public partial class QuickSalePaymentView : DevExpress.XtraEditors.XtraForm
    {
        public string PaymentType = string.Empty;
        public QuickSalePaymentView(decimal subTotal, decimal discountTotal, decimal taxTotal, decimal grandTotal)
        {
            InitializeComponent();

            labelControlSubTotal.Text = subTotal.ToString("n2");
            labelControlDiscountTotal.Text = discountTotal.ToString("n2");
            labelControlTaxTotal.Text = taxTotal.ToString("n2");
            labelControlGrandTotal.Text = grandTotal.ToString("n2");
        }

        private void QuickSalePaymentView_Load(object sender, EventArgs e)
        {
            TileGroup group = new TileGroup();
            tileControl.Groups.Add(group);

            TileItem tileItemNakit = new TileItem();
            tileItemNakit.Text = "Nakit";
            tileItemNakit.Tag = "Nakit";
            tileItemNakit.ItemSize = TileItemSize.Large;
            tileItemNakit.AppearanceItem.Normal.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            tileItemNakit.TextAlignment = TileItemContentAlignment.MiddleCenter;


            tileItemNakit.ItemClick += (s, e) =>
            {
                PaymentType = tileItemNakit.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            group.Items.Add(tileItemNakit);

            TileItem tileItemPos = new TileItem();
            tileItemPos.Text = "Kredi Kartı";
            tileItemPos.Tag = "Pos";
            tileItemPos.ItemSize = TileItemSize.Large;
            tileItemPos.AppearanceItem.Normal.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            tileItemPos.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileItemPos.ItemClick += (s, e) =>
            {
                PaymentType = tileItemNakit.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            group.Items.Add(tileItemPos);

            TileItem tileItemHavele = new TileItem();
            tileItemHavele.Text = "Havale";
            tileItemHavele.Tag = "Havale";
            tileItemHavele.ItemSize = TileItemSize.Large;
            tileItemHavele.AppearanceItem.Normal.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            tileItemHavele.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileItemHavele.ItemClick += (s, e) =>
            {
                PaymentType = tileItemHavele.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            group.Items.Add(tileItemHavele);

            TileItem tileItemCari = new TileItem();
            tileItemCari.Text = "Cari Hesap";
            tileItemCari.Tag = "Cari Hesap";
            tileItemCari.ItemSize = TileItemSize.Large;
            tileItemCari.AppearanceItem.Normal.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            tileItemCari.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileItemCari.ItemClick += (s, e) =>
            {
                PaymentType = tileItemCari.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            };

            group.Items.Add(tileItemCari);


            TileItem tileItemCancel = new TileItem();
            tileItemCancel.Text = "Vazgeç";
            tileItemCancel.Tag = "Vazgeç";
            tileItemCancel.ItemSize = TileItemSize.Large;
            tileItemCancel.AppearanceItem.Normal.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            tileItemCancel.TextAlignment = TileItemContentAlignment.MiddleCenter;

            tileItemCancel.ItemClick += (s, e) =>
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            };

            group.Items.Add(tileItemCancel);
        }
    }
}