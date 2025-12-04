namespace Titan.WinForms.UserControls
{
    partial class CustomerListView
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
            barButtonItemCustomerTransaction = new DevExpress.XtraBars.BarButtonItem();
            gridControlCustomer = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewCustomer = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colDeleted = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            popupMenu = new DevExpress.XtraBars.PopupMenu(components);
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).BeginInit();
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
            barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItemAdd, barButtonItemEdit, barButtonItemDelete, barButtonItemRefresh, barButtonItemCustomerTransaction });
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
            barButtonItemAdd.ItemClick += barButtonItemAdd_ItemClick;
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
            barDockControlTop.Size = new System.Drawing.Size(1306, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 718);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(1306, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 698);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(1306, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 698);
            // 
            // barButtonItemCustomerTransaction
            // 
            barButtonItemCustomerTransaction.Caption = "Cari Hesap Hareketleri";
            barButtonItemCustomerTransaction.Id = 4;
            barButtonItemCustomerTransaction.Name = "barButtonItemCustomerTransaction";
            // 
            // gridControlCustomer
            // 
            gridControlCustomer.DataSource = pLinqInstantFeedbackSource;
            gridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlCustomer.Location = new System.Drawing.Point(0, 20);
            gridControlCustomer.MainView = gridViewCustomer;
            gridControlCustomer.MenuManager = barManager;
            gridControlCustomer.Name = "gridControlCustomer";
            gridControlCustomer.Size = new System.Drawing.Size(1306, 698);
            gridControlCustomer.TabIndex = 4;
            gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCustomer });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Code ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.Customer);
            // 
            // gridViewCustomer
            // 
            gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCode, colName, colActive, colDeleted, colCreatedOnUtc, colUpdatedOnUtc, colId, gridColumn1, gridColumn2, gridColumn3 });
            gridViewCustomer.GridControl = gridControlCustomer;
            gridViewCustomer.Name = "gridViewCustomer";
            gridViewCustomer.OptionsView.ShowAutoFilterRow = true;
            gridViewCustomer.OptionsView.ShowGroupPanel = false;
            gridViewCustomer.RowCellStyle += gridViewCustomer_RowCellStyle;
            gridViewCustomer.MouseUp += gridViewCustomer_MouseUp;
            // 
            // colCode
            // 
            colCode.Caption = "Kod";
            colCode.FieldName = "Code";
            colCode.Name = "colCode";
            colCode.OptionsColumn.AllowEdit = false;
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            // 
            // colName
            // 
            colName.Caption = "Cari Ünvan";
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.OptionsColumn.AllowEdit = false;
            colName.Visible = true;
            colName.VisibleIndex = 2;
            colName.Width = 300;
            // 
            // colActive
            // 
            colActive.Caption = "Aktif";
            colActive.FieldName = "Active";
            colActive.Name = "colActive";
            colActive.OptionsColumn.AllowEdit = false;
            colActive.Visible = true;
            colActive.VisibleIndex = 3;
            // 
            // colDeleted
            // 
            colDeleted.Caption = "Silindi";
            colDeleted.FieldName = "Deleted";
            colDeleted.Name = "colDeleted";
            colDeleted.OptionsColumn.AllowEdit = false;
            colDeleted.Visible = true;
            colDeleted.VisibleIndex = 4;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.Caption = "Kayıt Tarihi";
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.OptionsColumn.AllowEdit = false;
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 8;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.Caption = "Güncellenme Tarihi";
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.OptionsColumn.AllowEdit = false;
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 9;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Borç";
            gridColumn1.DisplayFormat.FormatString = "n2";
            gridColumn1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn1.FieldName = "Debit";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Alacak";
            gridColumn2.DisplayFormat.FormatString = "n2";
            gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn2.FieldName = "Credit";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.AllowEdit = false;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Bakiye";
            gridColumn3.DisplayFormat.FormatString = "n2";
            gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            gridColumn3.FieldName = "Balance";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.AllowEdit = false;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 7;
            // 
            // popupMenu
            // 
            popupMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] { new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemEdit), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemDelete), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemAdd), new DevExpress.XtraBars.LinkPersistInfo(barButtonItemCustomerTransaction, true) });
            popupMenu.Manager = barManager;
            popupMenu.Name = "popupMenu";
            // 
            // CustomerListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlCustomer);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "CustomerListView";
            Size = new System.Drawing.Size(1306, 738);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)popupMenu).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlCustomer;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraBars.BarButtonItem barButtonItemCustomerTransaction;
        private DevExpress.XtraBars.PopupMenu popupMenu;
    }
}
