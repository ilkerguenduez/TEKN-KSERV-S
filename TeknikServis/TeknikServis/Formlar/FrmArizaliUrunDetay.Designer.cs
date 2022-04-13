
namespace TeknikServis.Formlar
{
    partial class FrmArizaliUrunDetay
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
            this.GridCntrlUrunDetay = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlUrunDetay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCntrlUrunDetay
            // 
            this.GridCntrlUrunDetay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCntrlUrunDetay.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlUrunDetay.Location = new System.Drawing.Point(0, 0);
            this.GridCntrlUrunDetay.MainView = this.gridView1;
            this.GridCntrlUrunDetay.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlUrunDetay.Name = "GridCntrlUrunDetay";
            this.GridCntrlUrunDetay.Size = new System.Drawing.Size(1924, 872);
            this.GridCntrlUrunDetay.TabIndex = 10;
            this.GridCntrlUrunDetay.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Moccasin;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Moccasin;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.GridCntrlUrunDetay;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            // 
            // FrmArizaliUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.GridCntrlUrunDetay);
            this.Name = "FrmArizaliUrunDetay";
            this.Text = "ARIZALI ÜRÜN DETAYLARI";
            this.Load += new System.EventHandler(this.FrmArizaliUrunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlUrunDetay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCntrlUrunDetay;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}