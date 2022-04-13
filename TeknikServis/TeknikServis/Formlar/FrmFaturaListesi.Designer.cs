
namespace TeknikServis.Formlar
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.gridViewFaturaListe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.GridCntrlFaturaList = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lookUpEditPersonel = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpEditCari = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.TxtVergiDairesi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSaat = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtTarih = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSıra = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.TxtSeri = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturaListe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridViewFaturaListe
            // 
            this.gridViewFaturaListe.Appearance.Row.BackColor = System.Drawing.Color.ForestGreen;
            this.gridViewFaturaListe.Appearance.Row.BackColor2 = System.Drawing.Color.RoyalBlue;
            this.gridViewFaturaListe.Appearance.Row.Options.UseBackColor = true;
            this.gridViewFaturaListe.DetailHeight = 437;
            this.gridViewFaturaListe.GridControl = this.GridCntrlFaturaList;
            this.gridViewFaturaListe.Name = "gridViewFaturaListe";
            this.gridViewFaturaListe.OptionsView.ShowGroupPanel = false;
            this.gridViewFaturaListe.DoubleClick += new System.EventHandler(this.gridViewFaturaListe_DoubleClick);
            // 
            // GridCntrlFaturaList
            // 
            this.GridCntrlFaturaList.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlFaturaList.Location = new System.Drawing.Point(4, 2);
            this.GridCntrlFaturaList.MainView = this.gridViewFaturaListe;
            this.GridCntrlFaturaList.Margin = new System.Windows.Forms.Padding(4);
            this.GridCntrlFaturaList.Name = "GridCntrlFaturaList";
            this.GridCntrlFaturaList.Size = new System.Drawing.Size(1411, 858);
            this.GridCntrlFaturaList.TabIndex = 15;
            this.GridCntrlFaturaList.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewFaturaListe});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lookUpEditPersonel);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.lookUpEditCari);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.TxtVergiDairesi);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtSaat);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtTarih);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtSıra);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.TxtSeri);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1423, 2);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(498, 858);
            this.groupControl1.TabIndex = 16;
            this.groupControl1.Text = "FATURA İŞLEMLERİ";
            // 
            // lookUpEditPersonel
            // 
            this.lookUpEditPersonel.Location = new System.Drawing.Point(126, 307);
            this.lookUpEditPersonel.Name = "lookUpEditPersonel";
            this.lookUpEditPersonel.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditPersonel.Properties.DisplayMember = "AD";
            this.lookUpEditPersonel.Properties.ValueMember = "ID";
            this.lookUpEditPersonel.Size = new System.Drawing.Size(299, 22);
            this.lookUpEditPersonel.TabIndex = 33;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(49, 310);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(65, 16);
            this.labelControl9.TabIndex = 32;
            this.labelControl9.Text = "PERSONEL:";
            // 
            // lookUpEditCari
            // 
            this.lookUpEditCari.Location = new System.Drawing.Point(126, 270);
            this.lookUpEditCari.Name = "lookUpEditCari";
            this.lookUpEditCari.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditCari.Properties.DisplayMember = "AD";
            this.lookUpEditCari.Properties.ValueMember = "ID";
            this.lookUpEditCari.Size = new System.Drawing.Size(299, 22);
            this.lookUpEditCari.TabIndex = 31;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(81, 276);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(33, 16);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "CARİ:";
            // 
            // TxtVergiDairesi
            // 
            this.TxtVergiDairesi.Location = new System.Drawing.Point(126, 237);
            this.TxtVergiDairesi.Margin = new System.Windows.Forms.Padding(4);
            this.TxtVergiDairesi.Name = "TxtVergiDairesi";
            this.TxtVergiDairesi.Size = new System.Drawing.Size(299, 22);
            this.TxtVergiDairesi.TabIndex = 29;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(23, 240);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 16);
            this.labelControl6.TabIndex = 28;
            this.labelControl6.Text = "VERGİ DAİRESİ:";
            // 
            // TxtSaat
            // 
            this.TxtSaat.Location = new System.Drawing.Point(126, 198);
            this.TxtSaat.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSaat.Name = "TxtSaat";
            this.TxtSaat.Properties.Mask.EditMask = "90:00";
            this.TxtSaat.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSaat.Size = new System.Drawing.Size(299, 22);
            this.TxtSaat.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(77, 201);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(37, 16);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "SAAT:";
            // 
            // TxtTarih
            // 
            this.TxtTarih.Location = new System.Drawing.Point(126, 153);
            this.TxtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTarih.Name = "TxtTarih";
            this.TxtTarih.Properties.Mask.EditMask = "99/99/00";
            this.TxtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtTarih.Size = new System.Drawing.Size(299, 22);
            this.TxtTarih.TabIndex = 25;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(73, 156);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(41, 16);
            this.labelControl4.TabIndex = 24;
            this.labelControl4.Text = "TARİH:";
            // 
            // TxtSıra
            // 
            this.TxtSıra.Location = new System.Drawing.Point(126, 116);
            this.TxtSıra.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSıra.Name = "TxtSıra";
            this.TxtSıra.Properties.Mask.EditMask = "AAAAAA";
            this.TxtSıra.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSıra.Size = new System.Drawing.Size(299, 22);
            this.TxtSıra.TabIndex = 23;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(60, 119);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(54, 16);
            this.labelControl3.TabIndex = 22;
            this.labelControl3.Text = "SIRA NO:";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(126, 38);
            this.TxtID.Margin = new System.Windows.Forms.Padding(4);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(299, 22);
            this.TxtID.TabIndex = 20;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 41);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(93, 16);
            this.labelControl7.TabIndex = 19;
            this.labelControl7.Text = "DEPARTMAN ID:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(126, 605);
            this.BtnListele.Margin = new System.Windows.Forms.Padding(4);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(299, 70);
            this.BtnListele.TabIndex = 18;
            this.BtnListele.Text = "LİSTELE";
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(126, 527);
            this.BtnGuncelle.Margin = new System.Windows.Forms.Padding(4);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(299, 70);
            this.BtnGuncelle.TabIndex = 17;
            this.BtnGuncelle.Text = "GÜNCELLE";
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(126, 449);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(299, 70);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "SİL";
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(126, 372);
            this.BtnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(299, 70);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // TxtSeri
            // 
            this.TxtSeri.Location = new System.Drawing.Point(126, 77);
            this.TxtSeri.Margin = new System.Windows.Forms.Padding(4);
            this.TxtSeri.Name = "TxtSeri";
            this.TxtSeri.Properties.Mask.EditMask = "A";
            this.TxtSeri.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeri.Size = new System.Drawing.Size(299, 22);
            this.TxtSeri.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(82, 80);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(32, 16);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "SERİ:";
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 872);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.GridCntrlFaturaList);
            this.Name = "FrmFaturaListesi";
            this.Text = "FATURA LİSTESİ";
            this.Load += new System.EventHandler(this.FrmFaturaListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewFaturaListe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCntrlFaturaList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditPersonel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditCari.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtVergiDairesi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSaat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSıra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeri.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridViewFaturaListe;
        private DevExpress.XtraGrid.GridControl GridCntrlFaturaList;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtVergiDairesi;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtTarih;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtSıra;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.TextEdit TxtSeri;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditPersonel;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditCari;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}