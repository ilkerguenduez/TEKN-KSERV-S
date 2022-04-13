
namespace TeknikServis.Formlar
{
    partial class FrmFaturaKalemPopup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaKalemPopup));
            this.GridCntrlFaturaKalemleri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.GridCntrlFaturaBilgi = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureEditPdf = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEditExcel = new DevExpress.XtraEditors.PictureEdit();
            this.pictureEditClose = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditPdf.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditExcel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditClose.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCntrlFaturaKalemleri
            // 
            this.GridCntrlFaturaKalemleri.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(10);
            this.GridCntrlFaturaKalemleri.Location = new System.Drawing.Point(2, 320);
            this.GridCntrlFaturaKalemleri.MainView = this.gridView1;
            this.GridCntrlFaturaKalemleri.Margin = new System.Windows.Forms.Padding(10);
            this.GridCntrlFaturaKalemleri.Name = "GridCntrlFaturaKalemleri";
            this.GridCntrlFaturaKalemleri.Size = new System.Drawing.Size(1109, 406);
            this.GridCntrlFaturaKalemleri.TabIndex = 18;
            this.GridCntrlFaturaKalemleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 1065;
            this.gridView1.GridControl = this.GridCntrlFaturaKalemleri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.GridCntrlFaturaBilgi);
            this.groupControl1.Location = new System.Drawing.Point(16, 16);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(5);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1081, 204);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "Fatura Bilgileri";
            // 
            // GridCntrlFaturaBilgi
            // 
            this.GridCntrlFaturaBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridCntrlFaturaBilgi.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(12);
            this.GridCntrlFaturaBilgi.Location = new System.Drawing.Point(2, 28);
            this.GridCntrlFaturaBilgi.MainView = this.gridView2;
            this.GridCntrlFaturaBilgi.Margin = new System.Windows.Forms.Padding(12);
            this.GridCntrlFaturaBilgi.Name = "GridCntrlFaturaBilgi";
            this.GridCntrlFaturaBilgi.Size = new System.Drawing.Size(1077, 174);
            this.GridCntrlFaturaBilgi.TabIndex = 19;
            this.GridCntrlFaturaBilgi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.DetailHeight = 1331;
            this.gridView2.GridControl = this.GridCntrlFaturaBilgi;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Coral;
            this.label1.Location = new System.Drawing.Point(11, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fatura Ait Kalemler";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(2, 226);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1093, 3);
            this.panel1.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(2, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1093, 3);
            this.panel2.TabIndex = 22;
            // 
            // pictureEditPdf
            // 
            this.pictureEditPdf.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditPdf.EditValue = ((object)(resources.GetObject("pictureEditPdf.EditValue")));
            this.pictureEditPdf.Location = new System.Drawing.Point(953, 250);
            this.pictureEditPdf.Margin = new System.Windows.Forms.Padding(5);
            this.pictureEditPdf.Name = "pictureEditPdf";
            this.pictureEditPdf.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditPdf.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditPdf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditPdf.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditPdf.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditPdf.Size = new System.Drawing.Size(62, 65);
            this.pictureEditPdf.TabIndex = 23;
            this.pictureEditPdf.EditValueChanged += new System.EventHandler(this.pictureEditPdf_EditValueChanged);
            this.pictureEditPdf.Click += new System.EventHandler(this.pictureEditPdf_Click);
            // 
            // pictureEditExcel
            // 
            this.pictureEditExcel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditExcel.EditValue = ((object)(resources.GetObject("pictureEditExcel.EditValue")));
            this.pictureEditExcel.Location = new System.Drawing.Point(863, 250);
            this.pictureEditExcel.Margin = new System.Windows.Forms.Padding(6);
            this.pictureEditExcel.Name = "pictureEditExcel";
            this.pictureEditExcel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditExcel.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditExcel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditExcel.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditExcel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditExcel.Size = new System.Drawing.Size(62, 65);
            this.pictureEditExcel.TabIndex = 24;
            this.pictureEditExcel.EditValueChanged += new System.EventHandler(this.pictureEditExcel_EditValueChanged);
            this.pictureEditExcel.Click += new System.EventHandler(this.pictureEditExcel_Click);
            // 
            // pictureEditClose
            // 
            this.pictureEditClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureEditClose.EditValue = ((object)(resources.GetObject("pictureEditClose.EditValue")));
            this.pictureEditClose.Location = new System.Drawing.Point(1035, 250);
            this.pictureEditClose.Margin = new System.Windows.Forms.Padding(6);
            this.pictureEditClose.Name = "pictureEditClose";
            this.pictureEditClose.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEditClose.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEditClose.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEditClose.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditClose.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditClose.Size = new System.Drawing.Size(62, 65);
            this.pictureEditClose.TabIndex = 25;
            this.pictureEditClose.EditValueChanged += new System.EventHandler(this.pictureEditClose_EditValueChanged);
            this.pictureEditClose.Click += new System.EventHandler(this.pictureEditClose_Click);
            // 
            // FrmFaturaKalemPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 739);
            this.Controls.Add(this.pictureEditClose);
            this.Controls.Add(this.pictureEditExcel);
            this.Controls.Add(this.pictureEditPdf);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridCntrlFaturaKalemleri);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFaturaKalemPopup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFaturaKalemPopup";
            this.Load += new System.EventHandler(this.FrmFaturaKalemPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaKalemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditPdf.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditExcel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditClose.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCntrlFaturaKalemleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl GridCntrlFaturaBilgi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.PictureEdit pictureEditPdf;
        private DevExpress.XtraEditors.PictureEdit pictureEditExcel;
        private DevExpress.XtraEditors.PictureEdit pictureEditClose;
    }
}