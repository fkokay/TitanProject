namespace Titan.WinForms.Views
{
    partial class CustomerView
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
            simpleButtonSave = new DevExpress.XtraEditors.SimpleButton();
            simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            textEditCode = new DevExpress.XtraEditors.TextEdit();
            textEditName = new DevExpress.XtraEditors.TextEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(simpleButtonCancel);
            panelControl1.Controls.Add(simpleButtonSave);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl1.Location = new System.Drawing.Point(0, 136);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(511, 48);
            panelControl1.TabIndex = 0;
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
            // labelControl1
            // 
            labelControl1.Location = new System.Drawing.Point(12, 12);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(24, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Kodu";
            // 
            // textEditCode
            // 
            textEditCode.Location = new System.Drawing.Point(12, 31);
            textEditCode.Name = "textEditCode";
            textEditCode.Size = new System.Drawing.Size(324, 20);
            textEditCode.TabIndex = 2;
            // 
            // textEditName
            // 
            textEditName.Location = new System.Drawing.Point(12, 76);
            textEditName.Name = "textEditName";
            textEditName.Size = new System.Drawing.Size(324, 20);
            textEditName.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Location = new System.Drawing.Point(12, 57);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(31, 13);
            labelControl2.TabIndex = 3;
            labelControl2.Text = "Ünvan";
            // 
            // CustomerView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(511, 184);
            Controls.Add(textEditName);
            Controls.Add(labelControl2);
            Controls.Add(textEditCode);
            Controls.Add(labelControl1);
            Controls.Add(panelControl1);
            Name = "CustomerView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Cari Hesap Tanımlama";
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)textEditCode.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEditName.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSave;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}