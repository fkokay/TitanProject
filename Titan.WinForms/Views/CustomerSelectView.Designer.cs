namespace Titan.WinForms.Views
{
    partial class CustomerSelectView
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
            simpleButtonSelect = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControlCustomer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonSelect);
            panelControl1.Controls.Add(simpleButtonCancel);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 503);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(991, 36);
            panelControl1.TabIndex = 0;
            // 
            // simpleButtonSelect
            // 
            simpleButtonSelect.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            simpleButtonSelect.Appearance.Options.UseBackColor = true;
            simpleButtonSelect.Location = new System.Drawing.Point(903, 6);
            simpleButtonSelect.Name = "simpleButtonSelect";
            simpleButtonSelect.Size = new System.Drawing.Size(75, 23);
            simpleButtonSelect.TabIndex = 1;
            simpleButtonSelect.Text = "Seç";
            simpleButtonSelect.Click += simpleButtonSelect_Click;
            // 
            // simpleButtonCancel
            // 
            simpleButtonCancel.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger;
            simpleButtonCancel.Appearance.Options.UseBackColor = true;
            simpleButtonCancel.Location = new System.Drawing.Point(822, 6);
            simpleButtonCancel.Name = "simpleButtonCancel";
            simpleButtonCancel.Size = new System.Drawing.Size(75, 23);
            simpleButtonCancel.TabIndex = 0;
            simpleButtonCancel.Text = "Vazgeç";
            simpleButtonCancel.Click += simpleButtonCancel_Click;
            // 
            // gridControlCustomer
            // 
            gridControlCustomer.DataSource = pLinqInstantFeedbackSource;
            gridControlCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControlCustomer.Location = new System.Drawing.Point(0, 0);
            gridControlCustomer.MainView = gridViewCustomer;
            gridControlCustomer.Name = "gridControlCustomer";
            gridControlCustomer.Size = new System.Drawing.Size(991, 503);
            gridControlCustomer.TabIndex = 1;
            gridControlCustomer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridViewCustomer });
            // 
            // pLinqInstantFeedbackSource
            // 
            pLinqInstantFeedbackSource.DefaultSorting = "Code ASC";
            pLinqInstantFeedbackSource.DesignTimeElementType = typeof(Core.Domain.Entities.Customer);
            // 
            // gridViewCustomer
            // 
            gridViewCustomer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { colId, colCode, colName, colActive, colDeleted, colCreatedOnUtc, colUpdatedOnUtc });
            gridViewCustomer.GridControl = gridControlCustomer;
            gridViewCustomer.Name = "gridViewCustomer";
            // 
            // colCode
            // 
            colCode.FieldName = "Code";
            colCode.Name = "colCode";
            colCode.OptionsColumn.AllowEdit = false;
            colCode.Visible = true;
            colCode.VisibleIndex = 1;
            // 
            // colName
            // 
            colName.FieldName = "Name";
            colName.Name = "colName";
            colName.OptionsColumn.AllowEdit = false;
            colName.Visible = true;
            colName.VisibleIndex = 2;
            // 
            // colActive
            // 
            colActive.FieldName = "Active";
            colActive.Name = "colActive";
            colActive.OptionsColumn.AllowEdit = false;
            colActive.Visible = true;
            colActive.VisibleIndex = 3;
            // 
            // colDeleted
            // 
            colDeleted.FieldName = "Deleted";
            colDeleted.Name = "colDeleted";
            colDeleted.OptionsColumn.AllowEdit = false;
            colDeleted.Visible = true;
            colDeleted.VisibleIndex = 4;
            // 
            // colCreatedOnUtc
            // 
            colCreatedOnUtc.FieldName = "CreatedOnUtc";
            colCreatedOnUtc.Name = "colCreatedOnUtc";
            colCreatedOnUtc.OptionsColumn.AllowEdit = false;
            colCreatedOnUtc.Visible = true;
            colCreatedOnUtc.VisibleIndex = 5;
            // 
            // colUpdatedOnUtc
            // 
            colUpdatedOnUtc.FieldName = "UpdatedOnUtc";
            colUpdatedOnUtc.Name = "colUpdatedOnUtc";
            colUpdatedOnUtc.OptionsColumn.AllowEdit = false;
            colUpdatedOnUtc.Visible = true;
            colUpdatedOnUtc.VisibleIndex = 6;
            // 
            // colId
            // 
            colId.FieldName = "Id";
            colId.Name = "colId";
            colId.OptionsColumn.AllowEdit = false;
            colId.Visible = true;
            colId.VisibleIndex = 0;
            // 
            // CustomerSelectView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(991, 539);
            Controls.Add(gridControlCustomer);
            Controls.Add(panelControl1);
            Name = "CustomerSelectView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cari Hesap Seçiniz";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControlCustomer).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridViewCustomer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gridControlCustomer;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCustomer;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colActive;
        private DevExpress.XtraGrid.Columns.GridColumn colDeleted;
        private DevExpress.XtraGrid.Columns.GridColumn colCreatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colUpdatedOnUtc;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSelect;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}