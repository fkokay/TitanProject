namespace Titan.WinForms.UserControls
{
    partial class InvoiceListView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            barManager = new DevExpress.XtraBars.BarManager(components);
            bar2 = new DevExpress.XtraBars.Bar();
            barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            gridControlInvoice = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewInvoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            colInvoiceType = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceNo = new DevExpress.XtraGrid.Columns.GridColumn();
            colInvoiceDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colDiscountTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colTaxTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colGrandTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colDispatchNoteId = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceId = new DevExpress.XtraGrid.Columns.GridColumn();
            colUUID = new DevExpress.XtraGrid.Columns.GridColumn();
            colEInvoiceStatusMessage = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlInvoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewInvoice).BeginInit();
            SuspendLayout();
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar2, bar3 });
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemAdd, barButtonItemEdit, barButtonItemDelete, barButtonItemRefresh });
            barManager.MainMenu = bar2;
            barManager.MaxItemId = 4;
            barManager.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEdit), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemRefresh) });
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
            // 
            // barButtonItemAdd
            // 
            barButtonItemAdd.Caption = "Yeni";
            barButtonItemAdd.Id = 0;
            barButtonItemAdd.Name = "barButtonItemAdd";
            // 
            // barButtonItemEdit
            // 
            barButtonItemEdit.Caption = "Düzenle";
            barButtonItemEdit.Id = 1;
            barButtonItemEdit.Name = "barButtonItemEdit";
            barButtonItemEdit.ItemClick += barButtonItemEdit_ItemClick;
            // 
            // barButtonItemDelete
            // 
            barButtonItemDelete.Caption = "Sil";
            barButtonItemDelete.Id = 2;
            barButtonItemDelete.Name = "barButtonItemDelete";
            // 
            // barButtonItemRefresh
            // 
            barButtonItemRefresh.Caption = "Yenile";
            barButtonItemRefresh.Id = 3;
            barButtonItemRefresh.Name = "barButtonItemRefresh";
            // 
            // bar3
            // 
            bar3.BarName = "Status bar";
            bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            bar3.DockCol = 0;
            bar3.DockRow = 0;
            bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            bar3.OptionsBar.AllowQuickCustomization = false;
            bar3.OptionsBar.DrawDragBorder = false;
            bar3.OptionsBar.UseWholeRow = true;
            bar3.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            barDockControlTop.CausesValidation = false;
            barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            barDockControlTop.Location = new System.Drawing.Point(0, 0);
            barDockControlTop.Manager = barManager;
            barDockControlTop.Size = new System.Drawing.Size(1024, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 673);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(1024, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 653);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1024, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 653);
            // 
            // gridControlInvoice
            // 
            gridControlInvoice.DataSource = pLinqInstantFeedbackSource;
            gridControlInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlInvoice.Location = new System.Drawing.Point(0, 20);
            gridControlInvoice.MainView = gridViewInvoice;
            gridControlInvoice.MenuManager = barManager;
            gridControlInvoice.Name = "gridControlInvoice";
            gridControlInvoice.Size = new System.Drawing.Size(1024, 653);
            gridControlInvoice.TabIndex = 4;
            gridControlInvoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewInvoice });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Id ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.Invoice);
            // 
            // gridViewInvoice
            // 
            gridViewInvoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colInvoiceType, colInvoiceNo, colInvoiceDate, colCustomerId, colCustomer, colDescription, colCurrency, colExchangeRate, colSubTotal, colDiscountTotal, colTaxTotal, colGrandTotal, colDispatchNoteId, colSourceType, colSourceId, colUUID, colEInvoiceStatusMessage, colCreatedOnUtc, colUpdatedOnUtc, colId });
            gridViewInvoice.GridControl = gridControlInvoice;
            gridViewInvoice.Name = "gridViewInvoice";
            gridViewInvoice.OptionsView.ShowAutoFilterRow = true;
            gridViewInvoice.OptionsView.ShowGroupPanel = false;
            gridViewInvoice.DoubleClick += gridViewInvoice_DoubleClick;
            // 
            // colInvoiceType
            // 
            colInvoiceType.FieldName = "InvoiceType";
            colInvoiceType.Name = "colInvoiceType";
            colInvoiceType.OptionsColumn.AllowEdit = false;
            colInvoiceType.Visible = true;
            colInvoiceType.VisibleIndex = 1;
            colInvoiceType.Width = 49;
            // 
            // colInvoiceNo
            // 
            colInvoiceNo.FieldName = "InvoiceNo";
            colInvoiceNo.Name = "colInvoiceNo";
            colInvoiceNo.OptionsColumn.AllowEdit = false;
            colInvoiceNo.Visible = true;
            colInvoiceNo.VisibleIndex = 2;
            colInvoiceNo.Width = 49;
            // 
            // colInvoiceDate
            // 
            colInvoiceDate.FieldName = "InvoiceDate";
            colInvoiceDate.Name = "colInvoiceDate";
            colInvoiceDate.OptionsColumn.AllowEdit = false;
            colInvoiceDate.Visible = true;
            colInvoiceDate.VisibleIndex = 3;
            colInvoiceDate.Width = 49;
            // 
            // colCustomerId
            // 
            colCustomerId.FieldName = "CustomerId";
            colCustomerId.Name = "colCustomerId";
            colCustomerId.OptionsColumn.AllowEdit = false;
            colCustomerId.Visible = true;
            colCustomerId.VisibleIndex = 4;
            colCustomerId.Width = 49;
            // 
            // colCustomer
            // 
            colCustomer.Caption = "Cari Hesap Ünvanı";
            colCustomer.FieldName = "Customer.Definition";
            colCustomer.Name = "colCustomer";
            colCustomer.OptionsColumn.AllowEdit = false;
            colCustomer.Visible = true;
            colCustomer.VisibleIndex = 5;
            colCustomer.Width = 197;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.OptionsColumn.AllowEdit = false;
            colDescription.Visible = true;
            colDescription.VisibleIndex = 6;
            colDescription.Width = 38;
            // 
            // colCurrency
            // 
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.OptionsColumn.AllowEdit = false;
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 7;
            colCurrency.Width = 38;
            // 
            // colExchangeRate
            // 
            colExchangeRate.FieldName = "ExchangeRate";
            colExchangeRate.Name = "colExchangeRate";
            colExchangeRate.OptionsColumn.AllowEdit = false;
            colExchangeRate.Visible = true;
            colExchangeRate.VisibleIndex = 8;
            colExchangeRate.Width = 38;
            // 
            // colSubTotal
            // 
            colSubTotal.FieldName = "SubTotal";
            colSubTotal.Name = "colSubTotal";
            colSubTotal.OptionsColumn.AllowEdit = false;
            colSubTotal.Visible = true;
            colSubTotal.VisibleIndex = 9;
            colSubTotal.Width = 38;
            // 
            // colDiscountTotal
            // 
            colDiscountTotal.FieldName = "DiscountTotal";
            colDiscountTotal.Name = "colDiscountTotal";
            colDiscountTotal.OptionsColumn.AllowEdit = false;
            colDiscountTotal.Visible = true;
            colDiscountTotal.VisibleIndex = 10;
            colDiscountTotal.Width = 38;
            // 
            // colTaxTotal
            // 
            colTaxTotal.FieldName = "TaxTotal";
            colTaxTotal.Name = "colTaxTotal";
            colTaxTotal.OptionsColumn.AllowEdit = false;
            colTaxTotal.Visible = true;
            colTaxTotal.VisibleIndex = 11;
            colTaxTotal.Width = 38;
            // 
            // colGrandTotal
            // 
            colGrandTotal.FieldName = "GrandTotal";
            colGrandTotal.Name = "colGrandTotal";
            colGrandTotal.OptionsColumn.AllowEdit = false;
            colGrandTotal.Visible = true;
            colGrandTotal.VisibleIndex = 12;
            colGrandTotal.Width = 38;
            // 
            // colDispatchNoteId
            // 
            colDispatchNoteId.FieldName = "DispatchNoteId";
            colDispatchNoteId.Name = "colDispatchNoteId";
            colDispatchNoteId.OptionsColumn.AllowEdit = false;
            colDispatchNoteId.Visible = true;
            colDispatchNoteId.VisibleIndex = 13;
            colDispatchNoteId.Width = 38;
            // 
            // colSourceType
            // 
            colSourceType.FieldName = "SourceType";
            colSourceType.Name = "colSourceType";
            colSourceType.OptionsColumn.AllowEdit = false;
            colSourceType.Visible = true;
            colSourceType.VisibleIndex = 14;
            colSourceType.Width = 38;
            // 
            // colSourceId
            // 
            colSourceId.FieldName = "SourceId";
            colSourceId.Name = "colSourceId";
            colSourceId.OptionsColumn.AllowEdit = false;
            colSourceId.Visible = true;
            colSourceId.VisibleIndex = 15;
            colSourceId.Width = 38;
            // 
            // colUUID
            // 
            colUUID.FieldName = "UUID";
            colUUID.Name = "colUUID";
            colUUID.OptionsColumn.AllowEdit = false;
            colUUID.Width = 38;
            // 
            // colEInvoiceStatusMessage
            // 
            colEInvoiceStatusMessage.FieldName = "EInvoiceStatusMessage";
            colEInvoiceStatusMessage.Name = "colEInvoiceStatusMessage";
            colEInvoiceStatusMessage.OptionsColumn.AllowEdit = false;
            colEInvoiceStatusMessage.Visible = true;
            colEInvoiceStatusMessage.VisibleIndex = 16;
            colEInvoiceStatusMessage.Width = 38;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.OptionsColumn.AllowEdit = false;
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 17;
            colCreatedOnUtc.Width = 38;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.OptionsColumn.AllowEdit = false;
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 18;
            colUpdatedOnUtc.Width = 63;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            colId.Width = 49;
            // 
            // InvoiceListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlInvoice);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "InvoiceListView";
            Size = new System.Drawing.Size(1024, 693);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlInvoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewInvoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlInvoice;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewInvoice;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceType;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceNo;
        private DevExpress.XtraGrid.Columns.GridColumn colInvoiceDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colGrandTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colDispatchNoteId;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceId;
        private DevExpress.XtraGrid.Columns.GridColumn colUUID;
        private DevExpress.XtraGrid.Columns.GridColumn colEInvoiceStatusMessage;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
