
namespace TeknikServis.İletişim
{
    partial class FrmRehber
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
            this.GridCntrlRehber = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlRehber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCntrlRehber
            // 
            this.GridCntrlRehber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCntrlRehber.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlRehber.Location = new System.Drawing.Point(0, 0);
            this.GridCntrlRehber.MainView = this.gridView1;
            this.GridCntrlRehber.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlRehber.Name = "GridCntrlRehber";
            this.GridCntrlRehber.Size = new System.Drawing.Size(1924, 872);
            this.GridCntrlRehber.TabIndex = 10;
            this.GridCntrlRehber.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.GridCntrlRehber;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // FrmRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.GridCntrlRehber);
            this.Name = "FrmRehber";
            this.Text = "FrmRehber";
            this.Load += new System.EventHandler(this.FrmRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlRehber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCntrlRehber;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}