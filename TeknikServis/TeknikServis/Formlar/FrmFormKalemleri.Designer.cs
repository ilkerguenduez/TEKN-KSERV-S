
namespace TeknikServis.Formlar
{
    partial class FrmFormKalemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFormKalemleri));
            this.GridCntrlFormKalemleri = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnAra = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSıraNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFormKalemleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // GridCntrlFormKalemleri
            // 
            this.GridCntrlFormKalemleri.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlFormKalemleri.Location = new System.Drawing.Point(13, 79);
            this.GridCntrlFormKalemleri.MainView = this.gridView1;
            this.GridCntrlFormKalemleri.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlFormKalemleri.Name = "GridCntrlFormKalemleri";
            this.GridCntrlFormKalemleri.Size = new System.Drawing.Size(1898, 667);
            this.GridCntrlFormKalemleri.TabIndex = 18;
            this.GridCntrlFormKalemleri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.DetailHeight = 437;
            this.gridView1.GridControl = this.GridCntrlFormKalemleri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BtnAra
            // 
            this.BtnAra.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BtnAra.ImageOptions.SvgImage")));
            this.BtnAra.Location = new System.Drawing.Point(940, 10);
            this.BtnAra.Name = "BtnAra";
            this.BtnAra.Size = new System.Drawing.Size(156, 53);
            this.BtnAra.TabIndex = 4;
            this.BtnAra.Text = "ARA";
            this.BtnAra.Click += new System.EventHandler(this.BtnAra_Click);
            // 
            // TxtSıraNo
            // 
            this.TxtSıraNo.Location = new System.Drawing.Point(748, 18);
            this.TxtSıraNo.Name = "TxtSıraNo";
            this.TxtSıraNo.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSıraNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSıraNo.Properties.Mask.EditMask = "000000";
            this.TxtSıraNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSıraNo.Size = new System.Drawing.Size(151, 28);
            this.TxtSıraNo.TabIndex = 3;
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(427, 22);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSeriNo.Properties.Appearance.Options.UseFont = true;
            this.TxtSeriNo.Properties.Mask.EditMask = "A";
            this.TxtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNo.Size = new System.Drawing.Size(161, 28);
            this.TxtSeriNo.TabIndex = 2;
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(138, 22);
            this.TxtID.Name = "TxtID";
            this.TxtID.Properties.Appearance.Font = new System.Drawing.Font("Unispace", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtID.Properties.Appearance.Options.UseFont = true;
            this.TxtID.Size = new System.Drawing.Size(161, 28);
            this.TxtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(35, 21);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(97, 29);
            this.labelControl1.TabIndex = 19;
            this.labelControl1.Text = "Fatura ID:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(324, 21);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(97, 29);
            this.labelControl2.TabIndex = 20;
            this.labelControl2.Text = "Seri No:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(645, 19);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 29);
            this.labelControl3.TabIndex = 21;
            this.labelControl3.Text = "Sıra No:";
            // 
            // FrmFormKalemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.TxtSıraNo);
            this.Controls.Add(this.BtnAra);
            this.Controls.Add(this.GridCntrlFormKalemleri);
            this.Name = "FrmFormKalemleri";
            this.Text = "DETAYLI FATURA";
            this.Load += new System.EventHandler(this.FrmFormKalemleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFormKalemleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıraNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GridCntrlFormKalemleri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnAra;
        private DevExpress.XtraEditors.TextEdit TxtSıraNo;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}