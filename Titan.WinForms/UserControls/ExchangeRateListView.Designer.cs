namespace Titan.WinForms.UserControls
{
    partial class ExchangeRateListView
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
            barButtonItemUpdateRates = new DevExpress.XtraBars.BarButtonItem();
            bar3 = new DevExpress.XtraBars.Bar();
            barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            gridControlExchangeRate = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewExchangeRate = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCurrencyCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colRateDate = new DevExpress.XtraGrid.Columns.GridColumn();
            colBuyingRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colSellingRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlExchangeRate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewExchangeRate).BeginInit();
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
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemAdd, barButtonItemEdit, barButtonItemDelete, barButtonItemRefresh, barButtonItemUpdateRates });
            barManager.MainMenu = bar2;
            barManager.MaxItemId = 5;
            barManager.StatusBar = bar3;
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEdit), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemRefresh), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemUpdateRates) });
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
            // barButtonItemUpdateRates
            // 
            barButtonItemUpdateRates.Caption = "Kurları Güncelle";
            barButtonItemUpdateRates.Id = 4;
            barButtonItemUpdateRates.Name = "barButtonItemUpdateRates";
            barButtonItemUpdateRates.ItemClick += barButtonItemUpdateRates_ItemClick;
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
            barDockControlTop.Size = new System.Drawing.Size(970, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 536);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(970, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 516);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(970, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 516);
            // 
            // gridControlExchangeRate
            // 
            gridControlExchangeRate.DataSource = pLinqInstantFeedbackSource;
            gridControlExchangeRate.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlExchangeRate.Location = new System.Drawing.Point(0, 20);
            gridControlExchangeRate.MainView = gridViewExchangeRate;
            gridControlExchangeRate.MenuManager = barManager;
            gridControlExchangeRate.Name = "gridControlExchangeRate";
            gridControlExchangeRate.Size = new System.Drawing.Size(970, 516);
            gridControlExchangeRate.TabIndex = 4;
            gridControlExchangeRate.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewExchangeRate });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Id ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.ExchangeRate);
            // 
            // gridViewExchangeRate
            // 
            gridViewExchangeRate.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCurrencyCode, colRateDate, colBuyingRate, colSellingRate, colId });
            gridViewExchangeRate.GridControl = gridControlExchangeRate;
            gridViewExchangeRate.Name = "gridViewExchangeRate";
            // 
            // colCurrencyCode
            // 
            colCurrencyCode.Caption = "Para Birimi";
            colCurrencyCode.FieldName = "CurrencyCode";
            colCurrencyCode.Name = "colCurrencyCode";
            colCurrencyCode.Visible = true;
            colCurrencyCode.VisibleIndex = 1;
            // 
            // colRateDate
            // 
            colRateDate.Caption = "Kur Tarihi";
            colRateDate.FieldName = "RateDate";
            colRateDate.Name = "colRateDate";
            colRateDate.Visible = true;
            colRateDate.VisibleIndex = 2;
            // 
            // colBuyingRate
            // 
            colBuyingRate.Caption = "Alış Kuru";
            colBuyingRate.FieldName = "BuyingRate";
            colBuyingRate.Name = "colBuyingRate";
            colBuyingRate.Visible = true;
            colBuyingRate.VisibleIndex = 3;
            // 
            // colSellingRate
            // 
            colSellingRate.Caption = "Satış Kuru";
            colSellingRate.FieldName = "SellingRate";
            colSellingRate.Name = "colSellingRate";
            colSellingRate.Visible = true;
            colSellingRate.VisibleIndex = 4;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // ExchangeRateListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlExchangeRate);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "ExchangeRateListView";
            Size = new System.Drawing.Size(970, 556);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlExchangeRate).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewExchangeRate).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlExchangeRate;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewExchangeRate;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrencyCode;
        private DevExpress.XtraGrid.Columns.GridColumn colRateDate;
        private DevExpress.XtraGrid.Columns.GridColumn colBuyingRate;
        private DevExpress.XtraGrid.Columns.GridColumn colSellingRate;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraBars.BarButtonItem barButtonItemUpdateRates;
    }
}
