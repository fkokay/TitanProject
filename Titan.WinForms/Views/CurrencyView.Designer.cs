namespace Titan.WinForms.Views
{
    partial class CurrencyView
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
            textEditName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            textEditCode = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEditSymbol = new DevExpress.XtraEditors.TextEdit();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            spinEditPrecision = new DevExpress.XtraEditors.SpinEdit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditSymbol.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinEditPrecision.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonCancel);
            panelControl1.Controls.Add(simpleButtonSave);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 226);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(388, 48);
            panelControl1.TabIndex = 3;
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
            // textEditName
            // 
            textEditName.Location = new System.Drawing.Point(12, 76);
            textEditName.Name = "textEditName";
            textEditName.Size = new System.Drawing.Size(324, 20);
            textEditName.TabIndex = 20;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(12, 57);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(15, 13);
            labelControl2.TabIndex = 19;
            labelControl2.Text = "Adı";
            // 
            // textEditCode
            // 
            textEditCode.Location = new System.Drawing.Point(12, 31);
            textEditCode.Name = "textEditCode";
            textEditCode.Size = new System.Drawing.Size(324, 20);
            textEditCode.TabIndex = 18;
            // 
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(24, 13);
            labelControl1.TabIndex = 17;
            labelControl1.Text = "Kodu";
            // 
            // textEditSymbol
            // 
            textEditSymbol.Location = new System.Drawing.Point(12, 121);
            textEditSymbol.Name = "textEditSymbol";
            textEditSymbol.Size = new System.Drawing.Size(324, 20);
            textEditSymbol.TabIndex = 22;
            // 
            // labelControl3
            // 
            labelControl3.Location = new System.Drawing.Point(12, 102);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(34, 13);
            labelControl3.TabIndex = 21;
            labelControl3.Text = "Sembol";
            // 
            // labelControl4
            // 
            labelControl4.Location = new System.Drawing.Point(12, 147);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(92, 13);
            labelControl4.TabIndex = 23;
            labelControl4.Text = "Ondalık Hassasiyeti";
            // 
            // spinEditPrecision
            // 
            spinEditPrecision.EditValue = new decimal(new int[] { 0, 0, 0, 0 });
            spinEditPrecision.Location = new System.Drawing.Point(12, 166);
            spinEditPrecision.Name = "spinEditPrecision";
            spinEditPrecision.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            spinEditPrecision.Properties.DisplayFormat.FormatString = "n0";
            spinEditPrecision.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEditPrecision.Properties.EditFormat.FormatString = "n0";
            spinEditPrecision.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            spinEditPrecision.Size = new System.Drawing.Size(324, 20);
            spinEditPrecision.TabIndex = 24;
            // 
            // CurrencyView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(388, 274);
            Controls.Add(spinEditPrecision);
            Controls.Add(labelControl4);
            Controls.Add(textEditSymbol);
            Controls.Add(labelControl3);
            Controls.Add(textEditName);
            Controls.Add(labelControl2);
            Controls.Add(textEditCode);
            Controls.Add(labelControl1);
            Controls.Add(panelControl1);
            Name = "CurrencyView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            Text = "Para Birimi Tanımlama";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditSymbol.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinEditPrecision.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditSymbol;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit spinEditPrecision;
    }
}