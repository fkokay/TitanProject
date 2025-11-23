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
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            panelControl2 = new DevExpress.XtraEditors.PanelControl();
            buttonEditCustomer = new DevExpress.XtraEditors.ButtonEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            tileControl1 = new DevExpress.XtraEditors.TileControl();
            panelControl3 = new DevExpress.XtraEditors.PanelControl();
            simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl2).BeginInit();
            panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)buttonEditCustomer.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl3).BeginInit();
            panelControl3.SuspendLayout();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(gridControl1);
            panelControl1.Controls.Add(panelControl2);
            panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            panelControl1.Location = new System.Drawing.Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new System.Drawing.Size(545, 729);
            panelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            gridControl1.Location = new System.Drawing.Point(2, 75);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new System.Drawing.Size(541, 652);
            gridControl1.TabIndex = 1;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            // 
            // panelControl2
            // 
            panelControl2.Controls.Add(buttonEditCustomer);
            panelControl2.Controls.Add(labelControl1);
            panelControl2.Dock = System.Windows.Forms.DockStyle.Top;
            panelControl2.Location = new System.Drawing.Point(2, 2);
            panelControl2.Name = "panelControl2";
            panelControl2.Size = new System.Drawing.Size(541, 73);
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
            // tileControl1
            // 
            tileControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            tileControl1.Location = new System.Drawing.Point(545, 0);
            tileControl1.Name = "tileControl1";
            tileControl1.Size = new System.Drawing.Size(580, 729);
            tileControl1.TabIndex = 1;
            tileControl1.Text = "tileControl1";
            // 
            // panelControl3
            // 
            panelControl3.Controls.Add(simpleButton2);
            panelControl3.Controls.Add(simpleButton1);
            panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            panelControl3.Location = new System.Drawing.Point(545, 677);
            panelControl3.Name = "panelControl3";
            panelControl3.Size = new System.Drawing.Size(580, 52);
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
            // simpleButton1
            // 
            simpleButton1.Location = new System.Drawing.Point(6, 5);
            simpleButton1.Name = "simpleButton1";
            simpleButton1.Size = new System.Drawing.Size(100, 40);
            simpleButton1.TabIndex = 0;
            simpleButton1.Text = "Kaydet";
            simpleButton1.Click += simpleButton1_Click;
            // 
            // QuickSaleView
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            Controls.Add(panelControl3);
            Controls.Add(tileControl1);
            Controls.Add(panelControl1);
            Name = "QuickSaleView";
            Size = new System.Drawing.Size(1125, 729);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.TileControl tileControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ButtonEdit buttonEditCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}
