using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Microsoft.EntityFrameworkCore;
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
using Titan.Core.Domain.Entities;
using Titan.Core.Domain.Enums;
using Titan.Core.Utils;
using Titan.Data;
using Titan.WinForms.Models;
using Titan.WinForms.Views;

namespace Titan.WinForms.UserControls
{
    public partial class QuickSaleView : DevExpress.XtraEditors.XtraUserControl
    {
        private readonly TitanContext _context;
        private readonly IServiceProvider _serviceProvider;
        private readonly List<QuikSaleLineModel> lineList = new List<QuikSaleLineModel>();
        public QuickSaleView(TitanContext context, IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _context = context;
            _serviceProvider = serviceProvider;
        }

        private void buttonEditCustomer_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var view = _serviceProvider.GetRequiredService<CustomerListModalView>();
            if (view.ShowDialog() == DialogResult.OK)
            {
                buttonEditCustomer.Text = view.SelectCustomer.Name;
                buttonEditCustomer.Tag = view.SelectCustomer.Id;
            }
        }

        private async void QuickSaleView_Load(object sender, EventArgs e)
        {
            LoadLine();
            await LoadTileItems();
            await LoadRepositoryItems();
        }

        private async Task LoadRepositoryItems()
        {
            #region UnitCode
            RepositoryItemLookUpEdit repoUnit = new RepositoryItemLookUpEdit();
            repoUnit.DisplayMember = "Code";
            repoUnit.ValueMember = "Code";
            repoUnit.NullText = "Seçiniz...";
            repoUnit.PopupFilterMode = PopupFilterMode.Contains;
            repoUnit.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.AutoSearch;
            repoUnit.Columns.Add(new DevExpress.XtraEditors.Controls.LookUpColumnInfo()
            {
                Caption = "Birim Kodu",
                FieldName = "Code"
            });

            repoUnit.DataSource = await _context.Units.ToListAsync();

            gridControlLine.RepositoryItems.Add(repoUnit);
            gridViewLine.Columns["UnitCode"].ColumnEdit = repoUnit;
            #endregion
        }

        private async Task LoadTileItems()
        {
            var items = await _context.Items.ToListAsync();

            TileGroup group = new TileGroup();
            tileControlItems.Groups.Add(group);

            foreach (var item in items)
            {
                TileItem tileItem = new TileItem();
                tileItem.Text = item.Name;
                tileItem.Tag = item.Code;
                tileItem.ItemSize = TileItemSize.Medium;

                tileItem.ItemClick += async (s, e) =>
                {
                    var itemCode = e.Item.Tag.ToString();
                    if (lineList.Where(m => m.ItemCode == itemCode).Any())
                    {
                        var line = lineList.Where(m => m.ItemCode == itemCode).First();
                        line.Quantity += 1;
                        line.LineTotal = line.UnitPrice * line.Quantity;

                        gridControlLine.RefreshDataSource();
                    }
                    else
                    {
                        var selectedItem = await _context.Items.Where(m => m.Code == itemCode).FirstOrDefaultAsync();


                        QuikSaleLineModel model = new QuikSaleLineModel();
                        model.ItemId = selectedItem.Id;
                        model.ItemCode = e.Item.Tag.ToString();
                        model.ItemName = e.Item.Text;
                        model.Quantity = 1;
                        model.UnitPrice = 100;
                        model.TaxRate = 20;
                        model.UnitCode = selectedItem.MainUnitCode;
                        model.LineTotal = 100;
                        model.Currency = "TL";

                        lineList.Add(model);
                        gridControlLine.RefreshDataSource();
                    }

                };

                group.Items.Add(tileItem);
            }
        }

        private void LoadLine()
        {
            gridControlLine.DataSource = lineList;
        }

        private async void simpleButtonPayment_Click(object sender, EventArgs e)
        {
            if (buttonEditCustomer.Tag == null)
            {
                XtraMessageBox.Show("Cari hesap seçiniz!");
                return;
            }

            if (lineList.Count == 0)
            {
                XtraMessageBox.Show("Bir ürün giriniz");
                return;
            }


            decimal subTotal = lineList.Sum(m => m.UnitPrice * m.Quantity);
            decimal discountTotal = 0;
            decimal taxTotal = lineList.Sum(m => (m.UnitPrice * m.Quantity) * (m.TaxRate / 100m));
            decimal grandTotal = subTotal - discountTotal + taxTotal; ;

            QuickSalePaymentView quickSalePaymentView = new QuickSalePaymentView(subTotal,discountTotal,taxTotal,grandTotal);
            if (quickSalePaymentView.ShowDialog() == DialogResult.OK)
            {
                string invoiceNo = "000000000000001";
                if (_context.Invoices.Any())
                {
                    invoiceNo = MainUtils.NextKeyCode(await _context.Invoices.OrderByDescending(m => m.InvoiceNo).Select(m => m.InvoiceNo).FirstOrDefaultAsync());
                }


                Invoice invoice = new Invoice();
                invoice.InvoiceType = InvoiceType.Sales;
                invoice.InvoiceNo = invoiceNo;
                invoice.InvoiceDate = DateTime.UtcNow;
                invoice.CustomerId = Convert.ToInt32(buttonEditCustomer.Tag);
                invoice.Description = "Hızlı Satış";
                invoice.SubTotal = subTotal;
                invoice.DiscountTotal = discountTotal;
                invoice.TaxTotal = taxTotal;
                invoice.GrandTotal = grandTotal;
                invoice.SourceType =TransactionSourceType.Invoice;
                invoice.SourceId = 0;
                invoice.UUID = Guid.NewGuid().ToString();
                invoice.EInvoiceStatusMessage = "";

                foreach (var item in lineList)
                {
                    InvoiceLine invoiceLine = new InvoiceLine();
                    invoiceLine.ItemId = item.ItemId;
                    invoiceLine.Quantity = item.Quantity;
                    invoiceLine.Unit = item.UnitCode;
                    invoiceLine.UnitPrice = item.UnitPrice;
                    invoiceLine.Currency = item.Currency;
                    invoiceLine.TotalForeign = item.Quantity * item.UnitPrice;
                    invoiceLine.TotalLocal = item.Quantity * item.UnitPrice;
                    invoiceLine.Discount = 0;
                    invoiceLine.TaxRate = item.TaxRate;
                    invoiceLine.LineTotal = item.LineTotal;

                    invoice.Lines.Add(invoiceLine);

                    StockTransaction stockTransaction = new StockTransaction();
                    stockTransaction.ItemId = item.ItemId;
                    stockTransaction.WarehouseId = 1; // Varsayılan depo
                    stockTransaction.TransactionType = MaterialTransactionType.SalesOut;
                    stockTransaction.TransactionDate = invoice.InvoiceDate;

                    stockTransaction.Quantity = item.Quantity;
                    stockTransaction.UnitPrice = item.UnitPrice;
                    stockTransaction.Total = item.Quantity * item.UnitPrice;

                    stockTransaction.Currency = item.Currency;
                    stockTransaction.ExchangeRate = 1;
                    stockTransaction.LocalTotal = stockTransaction.Total * stockTransaction.ExchangeRate;

                    stockTransaction.SourceType = TransactionSourceType.Invoice;
                    stockTransaction.SourceId = invoice.Id;
                    stockTransaction.DocumentNo = invoice.InvoiceNo;
                    stockTransaction.Description = "Hızlı Satış Stok Çıkışı";

                    _context.StockTransactions.Add(stockTransaction);
                }

                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

                string transactionNo = "000000000000001";
                if (_context.CustomerTransactions.Any())
                {
                    transactionNo = MainUtils.NextKeyCode(await _context.CustomerTransactions.OrderByDescending(m => m.DocumentNo).Select(m => m.DocumentNo).FirstOrDefaultAsync());
                }

                var customerTransaction = new CustomerTransaction();
                customerTransaction.CustomerId = invoice.CustomerId;
                customerTransaction.TransactionDate = invoice.InvoiceDate;
                customerTransaction.DueDate = invoice.InvoiceDate;
                customerTransaction.DocumentNo = transactionNo;
                customerTransaction.SourceId = invoice.Id;
                customerTransaction.SourceType = TransactionSourceType.Invoice;
                customerTransaction.Amount = invoice.GrandTotal;
                customerTransaction.FlowDirection = MoneyFlowDirection.Outflow;
                customerTransaction.Currency = "TRY";
                customerTransaction.ExchangeRate = 1;
                customerTransaction.Description = "Hızlı Satış Faturası";


                _context.CustomerTransactions.Add(customerTransaction);

                if (quickSalePaymentView.PaymentType != "Cari Hesap")
                {
                    var paymentTransaction = new CustomerTransaction();
                    paymentTransaction.CustomerId = invoice.CustomerId;
                    paymentTransaction.TransactionDate = invoice.InvoiceDate;
                    paymentTransaction.DueDate = invoice.InvoiceDate;
                    paymentTransaction.DocumentNo = MainUtils.NextKeyCode(transactionNo);
                    paymentTransaction.SourceId = invoice.Id;
                    paymentTransaction.SourceType = TransactionSourceType.Receipt;
                    paymentTransaction.Amount = invoice.GrandTotal;
                    paymentTransaction.FlowDirection = MoneyFlowDirection.Inflow;
                    paymentTransaction.Currency = "TRY";
                    paymentTransaction.ExchangeRate = 1;
                    paymentTransaction.Description = "Hızlı Satış Tahsilatı - " + quickSalePaymentView.PaymentType;

                    _context.CustomerTransactions.Add(paymentTransaction);
                }

                await _context.SaveChangesAsync();

                XtraMessageBox.Show("Satış başarılı");

                buttonEditCustomer.Text = "";
                buttonEditCustomer.Tag = null;

                lineList.Clear();
                gridControlLine.RefreshDataSource();
            }

        }
    }
}
