namespace Titan.WinForms.UserControls
{
    partial class StockTransactionListView
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
            bar1 = new DevExpress.XtraBars.Bar();
            barButtonItemAdd = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemEdit = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemDelete = new DevExpress.XtraBars.BarButtonItem();
            barButtonItemRefresh = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            gridControlStockTransaction = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewStockTransaction = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            colWarehouseId = new DevExpress.XtraGrid.Columns.GridColumn();
            colWarehouse = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            colTransactionDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            colExchangeRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colLocalTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceType = new DevExpress.XtraGrid.Columns.GridColumn();
            colSourceId = new DevExpress.XtraGrid.Columns.GridColumn();
            colDocumentNo = new DevExpress.XtraGrid.Columns.GridColumn();
            colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlStockTransaction).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStockTransaction).BeginInit();
            SuspendLayout();
            // 
            // barManager
            // 
            barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] { bar1, bar3 });
            barManager.DockControls.Add(barDockControlTop);
            barManager.DockControls.Add(barDockControlBottom);
            barManager.DockControls.Add(barDockControlLeft);
            barManager.DockControls.Add(barDockControlRight);
            barManager.Form = this;
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemAdd, barButtonItemEdit, barButtonItemDelete, barButtonItemRefresh });
            barManager.MainMenu = bar1;
            barManager.MaxItemId = 4;
            barManager.StatusBar = bar3;
            // 
            // bar1
            // 
            bar1.BarName = "Main menu";
            bar1.DockCol = 0;
            bar1.DockRow = 0;
            bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEdit), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemRefresh) });
            bar1.OptionsBar.MultiLine = true;
            bar1.OptionsBar.UseWholeRow = true;
            bar1.Text = "Main menu";
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
            barDockControlTop.Size = new System.Drawing.Size(1322, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 645);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(1322, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 625);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1322, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 625);
            // 
            // gridControlStockTransaction
            // 
            gridControlStockTransaction.DataSource = pLinqInstantFeedbackSource;
            gridControlStockTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlStockTransaction.Location = new System.Drawing.Point(0, 20);
            gridControlStockTransaction.MainView = gridViewStockTransaction;
            gridControlStockTransaction.MenuManager = barManager;
            gridControlStockTransaction.Name = "gridControlStockTransaction";
            gridControlStockTransaction.Size = new System.Drawing.Size(1322, 625);
            gridControlStockTransaction.TabIndex = 4;
            gridControlStockTransaction.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewStockTransaction });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Id ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.StockTransaction);
            // 
            // gridViewStockTransaction
            // 
            gridViewStockTransaction.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemId, colItem, colWarehouseId, colWarehouse, colTransactionType, colTransactionDate, colQuantity, colUnitPrice, colTotal, colCurrency, colExchangeRate, colLocalTotal, colSourceType, colSourceId, colDocumentNo, colDescription, colActive, colDeleted, colCreatedOnUtc, colUpdatedOnUtc, colId });
            gridViewStockTransaction.GridControl = gridControlStockTransaction;
            gridViewStockTransaction.Name = "gridViewStockTransaction";
            // 
            // colItemId
            // 
            colItemId.FieldName = "ItemId";
            colItemId.Name = "colItemId";
            colItemId.Visible = true;
            colItemId.VisibleIndex = 1;
            // 
            // colItem
            // 
            colItem.FieldName = "Item";
            colItem.Name = "colItem";
            colItem.Visible = true;
            colItem.VisibleIndex = 2;
            // 
            // colWarehouseId
            // 
            colWarehouseId.FieldName = "WarehouseId";
            colWarehouseId.Name = "colWarehouseId";
            colWarehouseId.Visible = true;
            colWarehouseId.VisibleIndex = 3;
            // 
            // colWarehouse
            // 
            colWarehouse.FieldName = "Warehouse";
            colWarehouse.Name = "colWarehouse";
            colWarehouse.Visible = true;
            colWarehouse.VisibleIndex = 4;
            // 
            // colTransactionType
            // 
            colTransactionType.FieldName = "TransactionType";
            colTransactionType.Name = "colTransactionType";
            colTransactionType.Visible = true;
            colTransactionType.VisibleIndex = 5;
            // 
            // colTransactionDate
            // 
            colTransactionDate.FieldName = "TransactionDate";
            colTransactionDate.Name = "colTransactionDate";
            colTransactionDate.Visible = true;
            colTransactionDate.VisibleIndex = 6;
            // 
            // colQuantity
            // 
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 7;
            // 
            // colUnitPrice
            // 
            colUnitPrice.FieldName = "UnitPrice";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 8;
            // 
            // colTotal
            // 
            colTotal.FieldName = "Total";
            colTotal.Name = "colTotal";
            colTotal.Visible = true;
            colTotal.VisibleIndex = 9;
            // 
            // colCurrency
            // 
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 10;
            // 
            // colExchangeRate
            // 
            colExchangeRate.FieldName = "ExchangeRate";
            colExchangeRate.Name = "colExchangeRate";
            colExchangeRate.Visible = true;
            colExchangeRate.VisibleIndex = 11;
            // 
            // colLocalTotal
            // 
            colLocalTotal.FieldName = "LocalTotal";
            colLocalTotal.Name = "colLocalTotal";
            colLocalTotal.Visible = true;
            colLocalTotal.VisibleIndex = 12;
            // 
            // colSourceType
            // 
            colSourceType.FieldName = "SourceType";
            colSourceType.Name = "colSourceType";
            colSourceType.Visible = true;
            colSourceType.VisibleIndex = 13;
            // 
            // colSourceId
            // 
            colSourceId.FieldName = "SourceId";
            colSourceId.Name = "colSourceId";
            colSourceId.Visible = true;
            colSourceId.VisibleIndex = 14;
            // 
            // colDocumentNo
            // 
            colDocumentNo.FieldName = "DocumentNo";
            colDocumentNo.Name = "colDocumentNo";
            colDocumentNo.Visible = true;
            colDocumentNo.VisibleIndex = 15;
            // 
            // colDescription
            // 
            colDescription.FieldName = "Description";
            colDescription.Name = "colDescription";
            colDescription.Visible = true;
            colDescription.VisibleIndex = 16;
            // 
            // colActive
            // 
            colActive.FieldName = "Active";
            colActive.Name = "colActive";
            colActive.Visible = true;
            colActive.VisibleIndex = 17;
            // 
            // colDeleted
            // 
            colDeleted.FieldName = "Deleted";
            colDeleted.Name = "colDeleted";
            colDeleted.Visible = true;
            colDeleted.VisibleIndex = 18;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 19;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 20;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // StockTransactionListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlStockTransaction);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "StockTransactionListView";
            Size = new System.Drawing.Size(1322, 665);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlStockTransaction).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewStockTransaction).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem barButtonItemAdd;
        private DevExpress.XtraBars.BarButtonItem barButtonItemEdit;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDelete;
        private DevExpress.XtraBars.BarButtonItem barButtonItemRefresh;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraGrid.GridControl gridControlStockTransaction;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewStockTransaction;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouseId;
        private DevExpress.XtraGrid.Columns.GridColumn colWarehouse;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionDate;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
        private DevExpress.XtraGrid.Columns.GridColumn colExchangeRate;
        private DevExpress.XtraGrid.Columns.GridColumn colLocalTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceType;
        private DevExpress.XtraGrid.Columns.GridColumn colSourceId;
        private DevExpress.XtraGrid.Columns.GridColumn colDocumentNo;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
