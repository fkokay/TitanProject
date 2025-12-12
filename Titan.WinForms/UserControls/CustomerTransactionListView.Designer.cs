namespace Titan.WinForms.UserControls
{
    partial class CustomerTransactionListView
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
            gridControlCustomerTransaction = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewCustomerTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDueDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceId = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
            colFlowDirection = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCustomerTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomerTransaction).BeginInit();
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
            barDockControlTop.Size = new System.Drawing.Size(1077, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 671);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(1077, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 651);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1077, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 651);
            // 
            // gridControlCustomerTransaction
            // 
            gridControlCustomerTransaction.DataSource = pLinqInstantFeedbackSource;
            gridControlCustomerTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlCustomerTransaction.Location = new System.Drawing.Point(0, 20);
            gridControlCustomerTransaction.MainView = gridViewCustomerTransaction;
            gridControlCustomerTransaction.MenuManager = barManager;
            gridControlCustomerTransaction.Name = "gridControlCustomerTransaction";
            gridControlCustomerTransaction.Size = new System.Drawing.Size(1077, 651);
            gridControlCustomerTransaction.TabIndex = 4;
            gridControlCustomerTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCustomerTransaction });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "TransactionDate ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.CustomerTransaction);
            // 
            // gridViewCustomerTransaction
            // 
            gridViewCustomerTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCustomerId, colCustomer, colTransactionDate, colDueDate, colDocumentNo, colSourceId, colSourceType, colAmount, colFlowDirection, colCurrency, colExchangeRate, colDescription, colCreatedOnUtc, colUpdatedOnUtc, colId });
            gridViewCustomerTransaction.GridControl = gridControlCustomerTransaction;
            gridViewCustomerTransaction.Name = "gridViewCustomerTransaction";
            gridViewCustomerTransaction.OptionsView.ShowAutoFilterRow = true;
            gridViewCustomerTransaction.OptionsView.ShowGroupPanel = false;
            // 
            // colCustomerId
            // 
            colCustomerId.Caption = "Müşteri Id";
            colCustomerId.FieldName = "CustomerId";
            colCustomerId.Name = "colCustomerId";
            colCustomerId.OptionsColumn.AllowEdit = false;
            colCustomerId.Visible = true;
            colCustomerId.VisibleIndex = 1;
            // 
            // colCustomer
            // 
            colCustomer.Caption = "Cari Hesap Ünvanı";
            colCustomer.FieldName = "Customer.Definition";
            colCustomer.Name = "colCustomer";
            colCustomer.OptionsColumn.AllowEdit = false;
            colCustomer.Visible = true;
            colCustomer.VisibleIndex = 2;
            // 
            // colTransactionDate
            // 
            colTransactionDate.Caption = "Fiş Tarihi";
            colTransactionDate.FieldName = "TransactionDate";
            colTransactionDate.Name = "colTransactionDate";
            colTransactionDate.OptionsColumn.AllowEdit = false;
            colTransactionDate.Visible = true;
            colTransactionDate.VisibleIndex = 3;
            // 
            // colDueDate
            // 
            colDueDate.Caption = "Vade Tarihi";
            colDueDate.FieldName = "DueDate";
            colDueDate.Name = "colDueDate";
            colDueDate.OptionsColumn.AllowEdit = false;
            colDueDate.Visible = true;
            colDueDate.VisibleIndex = 4;
            // 
            // colDocumentNo
            // 
            colDocumentNo.Caption = "Belge No";
            colDocumentNo.FieldName = "DocumentNo";
            colDocumentNo.Name = "colDocumentNo";
            colDocumentNo.OptionsColumn.AllowEdit = false;
            colDocumentNo.Visible = true;
            colDocumentNo.VisibleIndex = 5;
            colDocumentNo.Width = 116;
            // 
            // colSourceId
            // 
            colSourceId.Caption = "Kaynak Id";
            colSourceId.FieldName = "SourceId";
            colSourceId.Name = "colSourceId";
            colSourceId.OptionsColumn.AllowEdit = false;
            colSourceId.Visible = true;
            colSourceId.VisibleIndex = 6;
            colSourceId.Width = 64;
            // 
            // colSourceType
            // 
            colSourceType.Caption = "Kaynak Türü";
            colSourceType.FieldName = "SourceType";
            colSourceType.Name = "colSourceType";
            colSourceType.OptionsColumn.AllowEdit = false;
            colSourceType.Visible = true;
            colSourceType.VisibleIndex = 7;
            colSourceType.Width = 64;
            // 
            // colAmount
            // 
            colAmount.Caption = "Tutar";
            colAmount.DisplayFormat.FormatString = "n2";
            colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colAmount.FieldName = "Amount";
            colAmount.Name = "colAmount";
            colAmount.OptionsColumn.AllowEdit = false;
            colAmount.Visible = true;
            colAmount.VisibleIndex = 8;
            colAmount.Width = 64;
            // 
            // colFlowDirection
            // 
            colFlowDirection.Caption = "Giriş/Çıkış";
            colFlowDirection.FieldName = "FlowDirection";
            colFlowDirection.Name = "colFlowDirection";
            colFlowDirection.OptionsColumn.AllowEdit = false;
            colFlowDirection.Visible = true;
            colFlowDirection.VisibleIndex = 9;
            colFlowDirection.Width = 64;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "Döviz Türü";
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.OptionsColumn.AllowEdit = false;
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 10;
            colCurrency.Width = 64;
            // 
            // colExchangeRate
            // 
            colExchangeRate.Caption = "Döviz Kuru";
            colExchangeRate.DisplayFormat.FormatString = "n4";
            colExchangeRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colExchangeRate.FieldName = "ExchangeRate";
            colExchangeRate.Name = "colExchangeRate";
            colExchangeRate.OptionsColumn.AllowEdit = false;
            colExchangeRate.Visible = true;
            colExchangeRate.VisibleIndex = 11;
            colExchangeRate.Width = 64;
            // 
            // colDescription
            // 
            colDescription.Caption = "Açıklama";
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.OptionsColumn.AllowEdit = false;
            colDescription.Visible = true;
            colDescription.VisibleIndex = 12;
            colDescription.Width = 64;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.Caption = "Kayıt Tarih";
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.OptionsColumn.AllowEdit = false;
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 13;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.Caption = "Güncellenme Tarihi";
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.OptionsColumn.AllowEdit = false;
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 14;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // CustomerTransactionListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlCustomerTransaction);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "CustomerTransactionListView";
            Size = new System.Drawing.Size(1077, 691);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCustomerTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomerTransaction).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlCustomerTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomerTransaction;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDueDate;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceId;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colAmount;
        private DevExpress.XtraGrid.Columns.GridColumn colFlowDirection;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
