namespace Titan.WinForms.Views
{
    partial class QuickSalePaymentView
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
            tileControl = new DevExpress.XtraEditors.TileControl();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            labelControlGrandTotal = new DevExpress.XtraEditors.LabelControl();
            labelControlTaxTotal = new DevExpress.XtraEditors.LabelControl();
            labelControlDiscountTotal = new DevExpress.XtraEditors.LabelControl();
            labelControlSubTotal = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            SuspendLayout();
            // 
            // tileControl
            // 
            tileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            tileControl.Location = new System.Drawing.Point(522, 0);
            tileControl.MaxId = 1;
            tileControl.Name = "tileControl";
            tileControl.Size = new System.Drawing.Size(616, 749);
            tileControl.TabIndex = 0;
            tileControl.Text = "tileControl1";
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Controls.Add(labelControl1);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(522, 749);
            panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            panelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            panelControl2.Controls.Add(labelControlGrandTotal);
            panelControl2.Controls.Add(labelControlTaxTotal);
            panelControl2.Controls.Add(labelControlDiscountTotal);
            panelControl2.Controls.Add(labelControlSubTotal);
            panelControl2.Controls.Add(labelControl5);
            panelControl2.Controls.Add(labelControl4);
            panelControl2.Controls.Add(labelControl3);
            panelControl2.Controls.Add(labelControl2);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl2.Location = new System.Drawing.Point(2, 421);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(518, 326);
            panelControl2.TabIndex = 9;
            // 
            // labelControlGrandTotal
            // 
            labelControlGrandTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            labelControlGrandTotal.Appearance.ForeColor = System.Drawing.Color.Firebrick;
            labelControlGrandTotal.Appearance.Options.UseFont = true;
            labelControlGrandTotal.Appearance.Options.UseForeColor = true;
            labelControlGrandTotal.Location = new System.Drawing.Point(357, 258);
            labelControlGrandTotal.Name = "labelControlGrandTotal";
            labelControlGrandTotal.Size = new System.Drawing.Size(117, 39);
            labelControlGrandTotal.TabIndex = 16;
            labelControlGrandTotal.Text = "0,00 TL";
            // 
            // labelControlTaxTotal
            // 
            labelControlTaxTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControlTaxTotal.Appearance.Options.UseFont = true;
            labelControlTaxTotal.Location = new System.Drawing.Point(357, 190);
            labelControlTaxTotal.Name = "labelControlTaxTotal";
            labelControlTaxTotal.Size = new System.Drawing.Size(106, 39);
            labelControlTaxTotal.TabIndex = 15;
            labelControlTaxTotal.Text = "0,00 TL";
            // 
            // labelControlDiscountTotal
            // 
            labelControlDiscountTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControlDiscountTotal.Appearance.Options.UseFont = true;
            labelControlDiscountTotal.Location = new System.Drawing.Point(357, 122);
            labelControlDiscountTotal.Name = "labelControlDiscountTotal";
            labelControlDiscountTotal.Size = new System.Drawing.Size(106, 39);
            labelControlDiscountTotal.TabIndex = 14;
            labelControlDiscountTotal.Text = "0,00 TL";
            // 
            // labelControlSubTotal
            // 
            labelControlSubTotal.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControlSubTotal.Appearance.Options.UseFont = true;
            labelControlSubTotal.Location = new System.Drawing.Point(357, 54);
            labelControlSubTotal.Name = "labelControlSubTotal";
            labelControlSubTotal.Size = new System.Drawing.Size(106, 39);
            labelControlSubTotal.TabIndex = 13;
            labelControlSubTotal.Text = "0,00 TL";
            // 
            // labelControl5
            // 
            labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControl5.Appearance.Options.UseFont = true;
            labelControl5.Location = new System.Drawing.Point(34, 258);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new System.Drawing.Size(224, 39);
            labelControl5.TabIndex = 12;
            labelControl5.Text = "GENEL TOPLAM";
            // 
            // labelControl4
            // 
            labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControl4.Appearance.Options.UseFont = true;
            labelControl4.Location = new System.Drawing.Point(34, 190);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new System.Drawing.Size(61, 39);
            labelControl4.TabIndex = 11;
            labelControl4.Text = "KDV";
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Location = new System.Drawing.Point(34, 122);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new System.Drawing.Size(124, 39);
            labelControl3.TabIndex = 10;
            labelControl3.Text = "İNDİRİM";
            // 
            // labelControl2
            // 
            labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControl2.Appearance.Options.UseFont = true;
            labelControl2.Location = new System.Drawing.Point(34, 54);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new System.Drawing.Size(188, 39);
            labelControl2.TabIndex = 9;
            labelControl2.Text = "ARA TOPLAM";
            // 
            // labelControl1
            // 
            labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 24F);
            labelControl1.Appearance.Options.UseFont = true;
            labelControl1.Location = new System.Drawing.Point(23, 45);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new System.Drawing.Size(262, 39);
            labelControl1.TabIndex = 0;
            labelControl1.Text = "ÖDEME BİLGİLERİ";
            // 
            // QuickSalePaymentView
            // 
            Appearance.BackColor = System.Drawing.SystemColors.MenuBar;
            Appearance.Options.UseBackColor = true;
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1138, 749);
            ControlBox = false;
            Controls.Add(tileControl);
            Controls.Add(panelControl1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QuickSalePaymentView";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Ödeme Yöntemleri";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            Load += QuickSalePaymentView_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)panelControl2).EndInit();
            panelControl2.ResumeLayout(false);
            panelControl2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.TileControl tileControl;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControlGrandTotal;
        private DevExpress.XtraEditors.LabelControl labelControlTaxTotal;
        private DevExpress.XtraEditors.LabelControl labelControlDiscountTotal;
        private DevExpress.XtraEditors.LabelControl labelControlSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}