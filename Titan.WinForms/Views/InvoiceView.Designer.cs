namespace Titan.WinForms.Views
{
    partial class InvoiceView
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            gridControlLine = new DevExpress.XtraGrid.GridControl();
            gridViewLine = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            textEditDescription = new DevExpress.XtraEditors.TextEdit();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            dateEditInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            buttonEditCustomerName = new DevExpress.XtraEditors.ButtonEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            buttonEditCustomerCode = new DevExpress.XtraEditors.ButtonEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditInvoiceNo = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLine).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditDescription.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties.CalendarTimeProperties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomerName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomerCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditInvoiceNo.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonCancel);
            panelControl1.Controls.Add(simpleButtonSave);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 816);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1302, 48);
            panelControl1.TabIndex = 2;
            // 
            // simpleButtonCancel
            // 
            simpleButtonCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButtonCancel.Appearance.Options.UseBackColor = true;
            simpleButtonCancel.Location = new System.Drawing.Point(93, 13);
            simpleButtonCancel.Name = "simpleButtonCancel";
            simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            simpleButtonCancel.TabIndex = 1;
            simpleButtonCancel.Text = "Vazgeç";
            // 
            // simpleButtonSave
            // 
            simpleButtonSave.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            simpleButtonSave.Appearance.Options.UseBackColor = true;
            simpleButtonSave.Location = new System.Drawing.Point(12, 13);
            simpleButtonSave.Name = "simpleButtonSave";
            simpleButtonSave.Size = new System.Drawing.Size(75, 23);
            simpleButtonSave.TabIndex = 0;
            simpleButtonSave.Text = "Kaydet";
            // 
            // gridControlLine
            // 
            gridControlLine.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlLine.Location = new System.Drawing.Point(0, 167);
            gridControlLine.MainView = gridViewLine;
            gridControlLine.Name = "gridControlLine";
            gridControlLine.Size = new System.Drawing.Size(1302, 649);
            gridControlLine.TabIndex = 3;
            gridControlLine.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewLine });
            // 
            // gridViewLine
            // 
            gridViewLine.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3, gridColumn4, gridColumn5, gridColumn6, gridColumn7, gridColumn8, gridColumn9 });
            gridViewLine.GridControl = gridControlLine;
            gridViewLine.Name = "gridViewLine";
            gridViewLine.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Kodu";
            gridColumn1.FieldName = "Item.Code";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Açıklama";
            gridColumn2.FieldName = "Item.Name";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Miktar";
            gridColumn3.FieldName = "Quantity";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Birim";
            gridColumn4.FieldName = "Unit";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Birim Fiyatı";
            gridColumn5.FieldName = "UnitPrice";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            gridColumn6.Caption = "KDV(%)";
            gridColumn6.FieldName = "TaxRate";
            gridColumn6.Name = "gridColumn6";
            gridColumn6.Visible = true;
            gridColumn6.VisibleIndex = 5;
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(textEditDescription);
            panelControl2.Controls.Add(labelControl5);
            panelControl2.Controls.Add(dateEditInvoiceDate);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Controls.Add(buttonEditCustomerName);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(buttonEditCustomerCode);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(textEditInvoiceNo);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl2.Location = new System.Drawing.Point(0, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1302, 167);
            panelControl2.TabIndex = 4;
            // 
            // textEditDescription
            // 
            textEditDescription.Location = new System.Drawing.Point(12, 121);
            textEditDescription.Name = "textEditDescription";
            textEditDescription.Size = new System.Drawing.Size(258, 20);
            textEditDescription.TabIndex = 10;
            // 
            // labelControl5
            // 
            labelControl5.Location = new System.Drawing.Point(12, 102);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(57, 13);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "Sipariş Notu";
            // 
            // dateEditInvoiceDate
            // 
            dateEditInvoiceDate.EditValue = null;
            dateEditInvoiceDate.Location = new System.Drawing.Point(12, 76);
            dateEditInvoiceDate.Name = "dateEditInvoiceDate";
            dateEditInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEditInvoiceDate.Size = new System.Drawing.Size(258, 20);
            dateEditInvoiceDate.TabIndex = 8;
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(343, 57);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(88, 13);
            labelControl4.TabIndex = 7;
            labelControl4.Text = "Cari Hesap Ünvanı";
            // 
            // buttonEditCustomerName
            // 
            buttonEditCustomerName.Location = new System.Drawing.Point(343, 76);
            buttonEditCustomerName.Name = "buttonEditCustomerName";
            buttonEditCustomerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            buttonEditCustomerName.Size = new System.Drawing.Size(321, 20);
            buttonEditCustomerName.TabIndex = 6;
            buttonEditCustomerName.ButtonClick += buttonEditCustomerName_ButtonClick;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(343, 12);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(79, 13);
            labelControl3.TabIndex = 5;
            labelControl3.Text = "Cari Hesap Kodu";
            // 
            // buttonEditCustomerCode
            // 
            buttonEditCustomerCode.Location = new System.Drawing.Point(343, 31);
            buttonEditCustomerCode.Name = "buttonEditCustomerCode";
            buttonEditCustomerCode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton() });
            buttonEditCustomerCode.Size = new System.Drawing.Size(321, 20);
            buttonEditCustomerCode.TabIndex = 4;
            buttonEditCustomerCode.ButtonClick += buttonEditCustomerCode_ButtonClick;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(12, 57);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(61, 13);
            labelControl2.TabIndex = 2;
            labelControl2.Text = "Fatura Tarihi";
            // 
            // textEditInvoiceNo
            // 
            textEditInvoiceNo.Location = new System.Drawing.Point(12, 31);
            textEditInvoiceNo.Name = "textEditInvoiceNo";
            textEditInvoiceNo.Size = new System.Drawing.Size(258, 20);
            textEditInvoiceNo.TabIndex = 1;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(48, 13);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "Fatura No";
            // 
            // gridColumn7
            // 
            gridColumn7.Caption = "Tutarı";
            gridColumn7.FieldName = "TotalLocal";
            gridColumn7.Name = "gridColumn7";
            gridColumn7.Visible = true;
            gridColumn7.VisibleIndex = 6;
            // 
            // gridColumn8
            // 
            gridColumn8.Caption = "KDV Tutarı";
            gridColumn8.Name = "gridColumn8";
            gridColumn8.Visible = true;
            gridColumn8.VisibleIndex = 7;
            // 
            // gridColumn9
            // 
            gridColumn9.Caption = "Net Tutar";
            gridColumn9.FieldName = "LineTotal";
            gridColumn9.Name = "gridColumn9";
            gridColumn9.Visible = true;
            gridColumn9.VisibleIndex = 8;
            // 
            // InvoiceView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1302, 864);
            Controls.Add(gridControlLine);
            Controls.Add(panelControl2);
            Controls.Add(panelControl1);
            Name = "InvoiceView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "InvoiceView";
            Load += InvoiceView_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewLine).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)textEditDescription.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEditInvoiceDate.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomerName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomerCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditInvoiceNo.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraGrid.GridControl gridControlLine;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLine;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ButtonEdit buttonEditCustomerName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ButtonEdit buttonEditCustomerCode;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditInvoiceNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dateEditInvoiceDate;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
    }
}