
namespace TeknikServis.Formlar
{
    partial class FrmNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNotlar));
            this.gridViewİncelenmeyen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridCntrlİncelenmeyen = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl28 = new DevExpress.XtraEditors.LabelControl();
            this.TxtIcerik = new DevExpress.XtraEditors.TextEdit();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtBaslık = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new System.Windows.Forms.Label();
            this.GridCntrlİncelenen = new DevExpress.XtraGrid.GridControl();
            this.gridViewİncelenen = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewİncelenmeyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlİncelenmeyen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIcerik.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslık.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlİncelenen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewİncelenen)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewİncelenmeyen
            // 
            this.gridViewİncelenmeyen.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridViewİncelenmeyen.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridViewİncelenmeyen.Appearance.Row.Options.UseBackColor = true;
            this.gridViewİncelenmeyen.DetailHeight = 437;
            this.gridViewİncelenmeyen.GridControl = this.GridCntrlİncelenmeyen;
            this.gridViewİncelenmeyen.Name = "gridViewİncelenmeyen";
            this.gridViewİncelenmeyen.OptionsView.ShowGroupPanel = false;
            this.gridViewİncelenmeyen.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridViewİncelenmeyen_FocusedRowChanged);
            // 
            // GridCntrlİncelenmeyen
            // 
            this.GridCntrlİncelenmeyen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlİncelenmeyen.Location = new System.Drawing.Point(4, 47);
            this.GridCntrlİncelenmeyen.MainView = this.gridViewİncelenmeyen;
            this.GridCntrlİncelenmeyen.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlİncelenmeyen.Name = "GridCntrlİncelenmeyen";
            this.GridCntrlİncelenmeyen.Size = new System.Drawing.Size(1514, 349);
            this.GridCntrlİncelenmeyen.TabIndex = 20;
            this.GridCntrlİncelenmeyen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewİncelenmeyen});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl28);
            this.groupControl1.Controls.Add(this.TxtIcerik);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtBaslık);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1526, 13);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(395, 847);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "AJANDA İŞLEMLERİ";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(112, 159);
            this.TxtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Mask.EditMask = "d";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.TxtTarih.Size = new System.Drawing.Size(247, 22);
            this.TxtTarih.TabIndex = 25;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(51, 162);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 16);
            this.labelControl3.TabIndex = 24;
            this.labelControl3.Text = "TARİH:";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(112, 196);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "OKUNDU";
            this.checkEdit1.Size = new System.Drawing.Size(94, 24);
            this.checkEdit1.TabIndex = 23;
            // 
            // labelControl28
            // 
            this.labelControl28.Location = new System.Drawing.Point(51, 200);
            this.labelControl28.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl28.Name = "labelControl28";
            this.labelControl28.Size = new System.Drawing.Size(47, 16);
            this.labelControl28.TabIndex = 22;
            this.labelControl28.Text = "DURUM:";
            // 
            // TxtIcerik
            // 
            this.TxtIcerik.Location = new System.Drawing.Point(112, 122);
            this.TxtIcerik.Margin = new System.Windows.Forms.Padding(4);
            this.TxtIcerik.Name = "TxtIcerik";
            this.TxtIcerik.Size = new System.Drawing.Size(247, 22);
            this.TxtIcerik.TabIndex = 21;
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(112, 42);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(247, 22);
            this.TxtID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(51, 45);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(46, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "NOT ID:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(112, 460);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(247, 70);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(112, 382);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(247, 70);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(112, 304);
            this.BtnSil.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(247, 70);
            this.BtnSil.TabIndex = 16;
            this.BtnSil.Text = "SİL";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(112, 227);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(247, 70);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(51, 125);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "İÇERİK:";
            // 
            // TxtBaslık
            // 
            this.TxtBaslık.Location = new System.Drawing.Point(112, 81);
            this.TxtBaslık.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBaslık.Name = "TxtBaslık";
            this.TxtBaslık.Size = new System.Drawing.Size(247, 22);
            this.TxtBaslık.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(51, 84);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "BAŞLIK:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 34);
            this.label3.TabIndex = 24;
            this.label3.Text = "İNCELENMEYEN NOTLAR";
            // 
            // GridCntrlİncelenen
            // 
            this.GridCntrlİncelenen.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlİncelenen.Location = new System.Drawing.Point(4, 445);
            this.GridCntrlİncelenen.MainView = this.gridViewİncelenen;
            this.GridCntrlİncelenen.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlİncelenen.Name = "GridCntrlİncelenen";
            this.GridCntrlİncelenen.Size = new System.Drawing.Size(1514, 415);
            this.GridCntrlİncelenen.TabIndex = 25;
            this.GridCntrlİncelenen.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewİncelenen});
            // 
            // gridViewİncelenen
            // 
            this.gridViewİncelenen.Appearance.Row.BackColor = System.Drawing.Color.Red;
            this.gridViewİncelenen.Appearance.Row.BackColor2 = System.Drawing.Color.White;
            this.gridViewİncelenen.Appearance.Row.Options.UseBackColor = true;
            this.gridViewİncelenen.DetailHeight = 437;
            this.gridViewİncelenen.GridControl = this.GridCntrlİncelenen;
            this.gridViewİncelenen.Name = "gridViewİncelenen";
            this.gridViewİncelenen.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 34);
            this.label1.TabIndex = 26;
            this.label1.Text = "İNCELENEN NOTLAR";
            // 
            // FrmNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridCntrlİncelenen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridCntrlİncelenmeyen);
            this.Name = "FrmNotlar";
            this.Text = "NOT VE HATIRLATMALAR";
            this.Load += new System.EventHandler(this.FrmNotlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewİncelenmeyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlİncelenmeyen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIcerik.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBaslık.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlİncelenen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewİncelenen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridViewİncelenmeyen;
        private DevExpress.XtraGrid.GridControl GridCntrlİncelenmeyen;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl28;
        private DevExpress.XtraEditors.TextEdit TxtIcerik;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtBaslık;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.GridControl GridCntrlİncelenen;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewİncelenen;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}