
namespace TeknikServis.Formlar
{
    partial class FrmSatislar
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
            this.GridCntrlSatislar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlSatislar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCntrlSatislar
            // 
            this.GridCntrlSatislar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCntrlSatislar.Location = new System.Drawing.Point(0, 0);
            this.GridCntrlSatislar.MainView = this.gridView1;
            this.GridCntrlSatislar.Name = "GridCntrlSatislar";
            this.GridCntrlSatislar.Size = new System.Drawing.Size(1924, 872);
            this.GridCntrlSatislar.TabIndex = 4;
            this.GridCntrlSatislar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.GridCntrlSatislar;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.GridCntrlSatislar);
            this.Name = "FrmSatislar";
            this.Text = "SATIŞ LİSTESİ";
            this.Load += new System.EventHandler(this.FrmSatislar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlSatislar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCntrlSatislar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}