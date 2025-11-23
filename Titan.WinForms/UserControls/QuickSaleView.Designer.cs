namespace Titan.WinForms.UserControls
{
    partial class QuickSaleView
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
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            gridControlLine = new DevExpress.XtraGrid.GridControl();
            gridViewLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            colTaxRate = new DevExpress.XtraGrid.Columns.GridColumn();
            colLineTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            buttonEditCustomer = new DevExpress.XtraEditors.ButtonEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tileControlItems = new DevExpress.XtraEditors.TileControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonPayment = new DevExpress.XtraEditors.SimpleButton();
            colCurrency = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControlLine);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1099, 768);
            panelControl1.TabIndex = 0;
            // 
            // gridControlLine
            // 
            gridControlLine.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlLine.Location = new System.Drawing.Point(2, 75);
            gridControlLine.MainView = gridViewLine;
            gridControlLine.Name = "gridControlLine";
            gridControlLine.Size = new System.Drawing.Size(1095, 691);
            gridControlLine.TabIndex = 1;
            gridControlLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewLine });
            // 
            // gridViewLine
            // 
            gridViewLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemCode, colItemName, colQuantity, colUnitCode, colUnitPrice, colCurrency, colTaxRate, colLineTotal });
            gridViewLine.GridControl = gridControlLine;
            gridViewLine.Name = "gridViewLine";
            gridViewLine.OptionsView.ShowAutoFilterRow = true;
            gridViewLine.OptionsView.ShowFooter = true;
            gridViewLine.OptionsView.ShowGroupPanel = false;
            // 
            // colItemCode
            // 
            colItemCode.Caption = "Malzeme Kodu";
            colItemCode.FieldName = "ItemCode";
            colItemCode.Name = "colItemCode";
            colItemCode.Visible = true;
            colItemCode.VisibleIndex = 0;
            colItemCode.Width = 161;
            // 
            // colItemName
            // 
            colItemName.Caption = "Malzeme Adı";
            colItemName.FieldName = "ItemName";
            colItemName.Name = "colItemName";
            colItemName.Visible = true;
            colItemName.VisibleIndex = 1;
            colItemName.Width = 517;
            // 
            // colQuantity
            // 
            colQuantity.Caption = "Miktar";
            colQuantity.DisplayFormat.FormatString = "N4";
            colQuantity.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colQuantity.FieldName = "Quantity";
            colQuantity.Name = "colQuantity";
            colQuantity.Visible = true;
            colQuantity.VisibleIndex = 2;
            colQuantity.Width = 163;
            // 
            // colUnitCode
            // 
            colUnitCode.Caption = "Birim";
            colUnitCode.FieldName = "UnitCode";
            colUnitCode.Name = "colUnitCode";
            colUnitCode.Visible = true;
            colUnitCode.VisibleIndex = 3;
            colUnitCode.Width = 163;
            // 
            // colUnitPrice
            // 
            colUnitPrice.Caption = "Birim Fiyat";
            colUnitPrice.DisplayFormat.FormatString = "n2";
            colUnitPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colUnitPrice.FieldName = "UnitPrice";
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.Visible = true;
            colUnitPrice.VisibleIndex = 4;
            colUnitPrice.Width = 163;
            // 
            // colTaxRate
            // 
            colTaxRate.Caption = "Kdv Oranı";
            colTaxRate.DisplayFormat.FormatString = "n0";
            colTaxRate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colTaxRate.FieldName = "TaxRate";
            colTaxRate.Name = "colTaxRate";
            colTaxRate.Visible = true;
            colTaxRate.VisibleIndex = 6;
            colTaxRate.Width = 135;
            // 
            // colLineTotal
            // 
            colLineTotal.Caption = "Satır Toplam";
            colLineTotal.DisplayFormat.FormatString = "n2";
            colLineTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            colLineTotal.FieldName = "LineTotal";
            colLineTotal.Name = "colLineTotal";
            colLineTotal.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum) });
            colLineTotal.Visible = true;
            colLineTotal.VisibleIndex = 7;
            colLineTotal.Width = 156;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(buttonEditCustomer);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl2.Location = new System.Drawing.Point(2, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1095, 73);
            panelControl2.TabIndex = 0;
            // 
            // buttonEditCustomer
            // 
            buttonEditCustomer.Location = new System.Drawing.Point(19, 35);
            buttonEditCustomer.Name = "buttonEditCustomer";
            buttonEditCustomer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            buttonEditCustomer.Size = new System.Drawing.Size(498, 20);
            buttonEditCustomer.TabIndex = 1;
            buttonEditCustomer.ButtonClick += buttonEditCustomer_ButtonClick;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(19, 16);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(52, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Cari Hesap";
            // 
            // tileControlItems
            // 
            tileControlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            tileControlItems.Location = new System.Drawing.Point(1099, 0);
            tileControlItems.Name = "tileControlItems";
            tileControlItems.Size = new System.Drawing.Size(412, 768);
            tileControlItems.TabIndex = 1;
            tileControlItems.Text = "tileControl1";
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(simpleButton2);
            panelControl3.Controls.Add(simpleButtonPayment);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl3.Location = new System.Drawing.Point(1099, 716);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(412, 52);
            panelControl3.TabIndex = 2;
            // 
            // simpleButton2
            // 
            simpleButton2.Location = new System.Drawing.Point(112, 5);
            simpleButton2.Name = "simpleButton2";
            simpleButton2.Size = new System.Drawing.Size(100, 40);
            simpleButton2.TabIndex = 1;
            simpleButton2.Text = "Vageç";
            // 
            // simpleButtonPayment
            // 
            simpleButtonPayment.Location = new System.Drawing.Point(6, 5);
            simpleButtonPayment.Name = "simpleButtonPayment";
            simpleButtonPayment.Size = new System.Drawing.Size(100, 40);
            simpleButtonPayment.TabIndex = 0;
            simpleButtonPayment.Text = "Ödeme";
            simpleButtonPayment.Click += simpleButtonPayment_Click;
            // 
            // colCurrency
            // 
            colCurrency.Caption = "Döviz Türü";
            colCurrency.FieldName = "Currency";
            colCurrency.Name = "colCurrency";
            colCurrency.Visible = true;
            colCurrency.VisibleIndex = 5;
            colCurrency.Width = 157;
            // 
            // QuickSaleView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl3);
            Controls.Add(tileControlItems);
            Controls.Add(panelControl1);
            Name = "QuickSaleView";
            Size = new System.Drawing.Size(1511, 768);
            Load += QuickSaleView_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomer.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).EndInit();
            panelControl3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLine;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TileControl tileControlItems;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButtonPayment;
        private DevExpress.XtraEditors.ButtonEdit buttonEditCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colItemCode;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colLineTotal;
        private DevExpress.XtraGrid.Columns.GridColumn colTaxRate;
        private DevExpress.XtraGrid.Columns.GridColumn colCurrency;
    }
}
