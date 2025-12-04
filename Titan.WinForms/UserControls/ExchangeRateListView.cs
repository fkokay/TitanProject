using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Titan.Core.Domain.Entities;
using Titan.Data;

namespace Titan.WinForms.UserControls
{
    public partial class ExchangeRateListView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        public ExchangeRateListView(TitanContext context)
        {
            InitializeComponent();
            _context = context;
            this.pLinqInstantFeedbackSource.GetEnumerable += PLinqInstantFeedbackSource_GetEnumerable; ;
        }

        private void PLinqInstantFeedbackSource_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {
            e.Source = _context.ExchangeRates.AsQueryable();
            e.Tag = _context;
        }

        private async void barButtonItemUpdateRates_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            try
            {
                if (XtraMessageBox.Show("Döviz Kurları Merkez Bankasından Güncellenecek Emin Misin?","",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var http = new HttpClient())
                    {
                        string url = "https://www.tcmb.gov.tr/kurlar/today.xml";

                        var xmlData = await http.GetStringAsync(url);
                        var xml = XDocument.Parse(xmlData);

                        var today = DateTime.Today;

                        var rates = xml.Descendants("Currency")
                            .Where(x => x.Attribute("CurrencyCode") != null)
                            .Select(x => new ExchangeRate
                            {
                                CurrencyCode = x.Attribute("CurrencyCode")!.Value,
                                RateDate = today,
                                BuyingRate = ToDecimal(x.Element("ForexBuying")?.Value),
                                SellingRate = ToDecimal(x.Element("ForexSelling")?.Value)
                            })
                            .ToList();


                        _context.ExchangeRates.AddRange(rates);
                        await _context.SaveChangesAsync();

                        MessageBox.Show("Kurlar başarıyla güncellendi!",
                            "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        pLinqInstantFeedbackSource.Refresh();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private decimal ToDecimal(string? value)
        {
            if (decimal.TryParse(value, NumberStyles.Any,
                CultureInfo.InvariantCulture, out decimal result))
            {
                return result;
            }

            return 0;
        }
    }
}
