namespace Titan.WinForms.Views
{
    partial class ItemView
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
            xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            gridControlUnitConversion = new DevExpress.XtraGrid.GridControl();
            pLinqInstantFeedbackSourceUnitConversion = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            gridViewUnitConversion = new DevExpress.XtraGrid.Views.Grid.GridView();
            colItemId = new DevExpress.XtraGrid.Columns.GridColumn();
            colItem = new DevExpress.XtraGrid.Columns.GridColumn();
            colFromUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colToUnitCode = new DevExpress.XtraGrid.Columns.GridColumn();
            colFactor = new DevExpress.XtraGrid.Columns.GridColumn();
            colActive = new DevExpress.XtraGrid.Columns.GridColumn();
            colId = new DevExpress.XtraGrid.Columns.GridColumn();
            xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            lookUpEditUnit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            textEditName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditCode = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).BeginInit();
            xtraTabControl1.SuspendLayout();
            xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlUnitConversion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUnitConversion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEditUnit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonCancel);
            panelControl1.Controls.Add(simpleButtonSave);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 569);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(1111, 48);
            panelControl1.TabIndex = 1;
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
            simpleButtonCancel.Click += simpleButtonCancel_Click;
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
            simpleButtonSave.Click += simpleButtonSave_Click;
            // 
            // xtraTabControl1
            // 
            xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            xtraTabControl1.Location = new System.Drawing.Point(0, 177);
            xtraTabControl1.Name = "xtraTabControl1";
            xtraTabControl1.SelectedTabPage = xtraTabPage1;
            xtraTabControl1.Size = new System.Drawing.Size(1111, 392);
            xtraTabControl1.TabIndex = 11;
            xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { xtraTabPage1, xtraTabPage2 });
            // 
            // xtraTabPage1
            // 
            xtraTabPage1.Controls.Add(gridControlUnitConversion);
            xtraTabPage1.Name = "xtraTabPage1";
            xtraTabPage1.Size = new System.Drawing.Size(1109, 367);
            xtraTabPage1.Text = "Birim Çevrimleri";
            // 
            // gridControlUnitConversion
            // 
            gridControlUnitConversion.DataSource = pLinqInstantFeedbackSourceUnitConversion;
            gridControlUnitConversion.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlUnitConversion.Location = new System.Drawing.Point(0, 0);
            gridControlUnitConversion.MainView = gridViewUnitConversion;
            gridControlUnitConversion.Name = "gridControlUnitConversion";
            gridControlUnitConversion.Size = new System.Drawing.Size(1109, 367);
            gridControlUnitConversion.TabIndex = 0;
            gridControlUnitConversion.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewUnitConversion });
            // 
            // pLinqInstantFeedbackSourceUnitConversion
            // 
            pLinqInstantFeedbackSourceUnitConversion.DefaultSorting = "Id ASC";
            pLinqInstantFeedbackSourceUnitConversion.DesignTimeElementType = typeof(Core.Domain.Entities.ItemUnitConversion);
            // 
            // gridViewUnitConversion
            // 
            gridViewUnitConversion.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colItemId, colItem, colFromUnitCode, colToUnitCode, colFactor, colActive, colId });
            gridViewUnitConversion.GridControl = gridControlUnitConversion;
            gridViewUnitConversion.Name = "gridViewUnitConversion";
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
            // colFromUnitCode
            // 
            colFromUnitCode.FieldName = "FromUnitCode";
            colFromUnitCode.Name = "colFromUnitCode";
            colFromUnitCode.Visible = true;
            colFromUnitCode.VisibleIndex = 3;
            // 
            // colToUnitCode
            // 
            colToUnitCode.FieldName = "ToUnitCode";
            colToUnitCode.Name = "colToUnitCode";
            colToUnitCode.Visible = true;
            colToUnitCode.VisibleIndex = 4;
            // 
            // colFactor
            // 
            colFactor.FieldName = "Factor";
            colFactor.Name = "colFactor";
            colFactor.Visible = true;
            colFactor.VisibleIndex = 5;
            // 
            // colActive
            // 
            colActive.FieldName = "Active";
            colActive.Name = "colActive";
            colActive.Visible = true;
            colActive.VisibleIndex = 6;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // xtraTabPage2
            // 
            xtraTabPage2.Name = "xtraTabPage2";
            xtraTabPage2.Size = new System.Drawing.Size(1109, 367);
            xtraTabPage2.Text = "xtraTabPage2";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(lookUpEditUnit);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(textEditName);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Controls.Add(textEditCode);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl2.Location = new System.Drawing.Point(0, 0);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(1111, 177);
            panelControl2.TabIndex = 12;
            // 
            // lookUpEditUnit
            // 
            lookUpEditUnit.Location = new System.Drawing.Point(20, 128);
            lookUpEditUnit.Name = "lookUpEditUnit";
            lookUpEditUnit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            lookUpEditUnit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Kod"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Ad") });
            lookUpEditUnit.Size = new System.Drawing.Size(324, 20);
            lookUpEditUnit.TabIndex = 16;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(20, 109);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(71, 13);
            labelControl3.TabIndex = 15;
            labelControl3.Text = "Ana Birim Kodu";
            // 
            // textEditName
            // 
            textEditName.Location = new System.Drawing.Point(20, 83);
            textEditName.Name = "textEditName";
            textEditName.Size = new System.Drawing.Size(324, 20);
            textEditName.TabIndex = 14;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(20, 64);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(15, 13);
            labelControl2.TabIndex = 13;
            labelControl2.Text = "Adı";
            // 
            // textEditCode
            // 
            textEditCode.Location = new System.Drawing.Point(20, 38);
            textEditCode.Name = "textEditCode";
            textEditCode.Size = new System.Drawing.Size(324, 20);
            textEditCode.TabIndex = 12;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(20, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(24, 13);
            labelControl1.TabIndex = 11;
            labelControl1.Text = "Kodu";
            // 
            // ItemView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1111, 617);
            Controls.Add(xtraTabControl1);
            Controls.Add(panelControl1);
            Controls.Add(panelControl2);
            Name = "ItemView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Malzeme Tanımlama";
            Load += ItemView_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)xtraTabControl1).EndInit();
            xtraTabControl1.ResumeLayout(false);
            xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlUnitConversion).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewUnitConversion).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)lookUpEditUnit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditUnit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl gridControlUnitConversion;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSourceUnitConversion;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUnitConversion;
        private DevExpress.XtraGrid.Columns.GridColumn colItemId;
        private DevExpress.XtraGrid.Columns.GridColumn colItem;
        private DevExpress.XtraGrid.Columns.GridColumn colFromUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn colToUnitCode;
        private DevExpress.XtraGrid.Columns.GridColumn colFactor;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}