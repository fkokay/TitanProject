namespace Titan.WinForms.UserControls
{
    partial class ItemListView
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
            bar2 = new DevExpress.XtraBars.Bar();
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
            gridControlItem = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSource = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewItem = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colName = new DevExpress.XtraGrid.Columns.GridColumn();
            colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colCreatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colUpdatedOnUtc = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)barManager).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridControlItem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewItem).BeginInit();
            SuspendLayout();
            // 
            // bar2
            // 
            bar2.BarName = "Main menu";
            bar2.DockCol = 0;
            bar2.DockRow = 0;
            bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            bar2.OptionsBar.MultiLine = true;
            bar2.OptionsBar.UseWholeRow = true;
            bar2.Text = "Main menu";
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
            barDockControlTop.Size = new System.Drawing.Size(955, 20);
            // 
            // barDockControlBottom
            // 
            barDockControlBottom.CausesValidation = false;
            barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            barDockControlBottom.Location = new System.Drawing.Point(0, 501);
            barDockControlBottom.Manager = barManager;
            barDockControlBottom.Size = new System.Drawing.Size(955, 20);
            // 
            // barDockControlLeft
            // 
            barDockControlLeft.CausesValidation = false;
            barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            barDockControlLeft.Manager = barManager;
            barDockControlLeft.Size = new System.Drawing.Size(0, 481);
            // 
            // barDockControlRight
            // 
            barDockControlRight.CausesValidation = false;
            barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            barDockControlRight.Location = new System.Drawing.Point(955, 20);
            barDockControlRight.Manager = barManager;
            barDockControlRight.Size = new System.Drawing.Size(0, 481);
            // 
            // gridControlItem
            // 
            gridControlItem.DataSource = pLinqInstantFeedbackSource;
            gridControlItem.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlItem.Location = new System.Drawing.Point(0, 20);
            gridControlItem.MainView = gridViewItem;
            gridControlItem.MenuManager = barManager;
            gridControlItem.Name = "gridControlItem";
            gridControlItem.Size = new System.Drawing.Size(955, 481);
            gridControlItem.TabIndex = 4;
            gridControlItem.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewItem });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Code ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Titan.Core.Domain.Entities.Item);
            // 
            // gridViewItem
            // 
            gridViewItem.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colCode, colName, colActive, colCreatedOnUtc, colUpdatedOnUtc, colId });
            gridViewItem.GridControl = gridControlItem;
            gridViewItem.Name = "gridViewItem";
            // 
            // colCode
            // 
            colCode.FieldName = "Code";
            colCode.Name = "colCode";
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.Visible = true;
            colName.VisibleIndex = 2;
            // 
            // colActive
            // 
            colActive.FieldName = "Active";
            colActive.Name = "colActive";
            colActive.Visible = true;
            colActive.VisibleIndex = 3;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 4;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 5;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // ItemListView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(gridControlItem);
            Controls.Add(barDockControlLeft);
            Controls.Add(barDockControlRight);
            Controls.Add(barDockControlBottom);
            Controls.Add(barDockControlTop);
            Name = "ItemListView";
            Size = new System.Drawing.Size(955, 521);
            ((System.ComponentModel.ISupportInitialize)barManager).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridControlItem).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewItem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
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
        private DevExpress.XtraGrid.GridControl gridControlItem;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewItem;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}
