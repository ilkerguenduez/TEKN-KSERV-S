
namespace TeknikServis.İletişim
{
    partial class FrmMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMail));
            this.TxtAlici = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGonder = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TxtKonu = new DevExpress.XtraEditors.TextEdit();
            this.pictureEdit3 = new DevExpress.XtraEditors.PictureEdit();
            this.panel3 = new System.Windows.Forms.Panel();
            this.TxtIcerik = new DevExpress.XtraEditors.TextEdit();
            this.BtnVazgec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlici.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIcerik.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtAlici
            // 
            this.TxtAlici.EditValue = "Alıcı...";
            this.TxtAlici.Location = new System.Drawing.Point(63, 65);
            this.TxtAlici.Name = "TxtAlici";
            this.TxtAlici.Properties.Appearance.BackColor = System.Drawing.Color.Coral;
            this.TxtAlici.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAlici.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtAlici.Properties.Appearance.Options.UseBackColor = true;
            this.TxtAlici.Properties.Appearance.Options.UseFont = true;
            this.TxtAlici.Properties.Appearance.Options.UseForeColor = true;
            this.TxtAlici.Size = new System.Drawing.Size(296, 34);
            this.TxtAlici.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(63, 102);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(296, 5);
            this.panel1.TabIndex = 1;
            // 
            // BtnGonder
            // 
            this.BtnGonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.BtnGonder.Location = new System.Drawing.Point(63, 244);
            this.BtnGonder.Name = "BtnGonder";
            this.BtnGonder.Size = new System.Drawing.Size(145, 76);
            this.BtnGonder.TabIndex = 0;
            this.BtnGonder.Text = "GÖNDER";
            this.BtnGonder.Click += new System.EventHandler(this.BtnGonder_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(9, 53);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Size = new System.Drawing.Size(48, 54);
            this.pictureEdit1.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.White;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(22, 8);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(283, 39);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mail Gönderme Paneli";
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(9, 119);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(48, 53);
            this.pictureEdit2.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(63, 167);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 5);
            this.panel2.TabIndex = 5;
            // 
            // TxtKonu
            // 
            this.TxtKonu.EditValue = "Konu...";
            this.TxtKonu.Location = new System.Drawing.Point(63, 130);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Properties.Appearance.BackColor = System.Drawing.Color.Coral;
            this.TxtKonu.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtKonu.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtKonu.Properties.Appearance.Options.UseBackColor = true;
            this.TxtKonu.Properties.Appearance.Options.UseFont = true;
            this.TxtKonu.Properties.Appearance.Options.UseForeColor = true;
            this.TxtKonu.Size = new System.Drawing.Size(296, 34);
            this.TxtKonu.TabIndex = 4;
            // 
            // pictureEdit3
            // 
            this.pictureEdit3.EditValue = ((object)(resources.GetObject("pictureEdit3.EditValue")));
            this.pictureEdit3.Location = new System.Drawing.Point(9, 185);
            this.pictureEdit3.Name = "pictureEdit3";
            this.pictureEdit3.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit3.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit3.Size = new System.Drawing.Size(48, 53);
            this.pictureEdit3.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(63, 233);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(296, 5);
            this.panel3.TabIndex = 4;
            // 
            // TxtIcerik
            // 
            this.TxtIcerik.EditValue = "İçerik...";
            this.TxtIcerik.Location = new System.Drawing.Point(63, 196);
            this.TxtIcerik.Name = "TxtIcerik";
            this.TxtIcerik.Properties.Appearance.BackColor = System.Drawing.Color.Coral;
            this.TxtIcerik.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtIcerik.Properties.Appearance.ForeColor = System.Drawing.Color.White;
            this.TxtIcerik.Properties.Appearance.Options.UseBackColor = true;
            this.TxtIcerik.Properties.Appearance.Options.UseFont = true;
            this.TxtIcerik.Properties.Appearance.Options.UseForeColor = true;
            this.TxtIcerik.Size = new System.Drawing.Size(296, 34);
            this.TxtIcerik.TabIndex = 3;
            // 
            // BtnVazgec
            // 
            this.BtnVazgec.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.BtnVazgec.Location = new System.Drawing.Point(214, 244);
            this.BtnVazgec.Name = "BtnVazgec";
            this.BtnVazgec.Size = new System.Drawing.Size(145, 76);
            this.BtnVazgec.TabIndex = 7;
            this.BtnVazgec.Text = "VAZGEÇ";
            this.BtnVazgec.Click += new System.EventHandler(this.BtnVazgec_Click);
            // 
            // FrmMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(397, 368);
            this.Controls.Add(this.BtnVazgec);
            this.Controls.Add(this.pictureEdit3);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TxtIcerik);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.TxtKonu);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.BtnGonder);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TxtAlici);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMail";
            this.Load += new System.EventHandler(this.FrmMail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtAlici.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtKonu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtIcerik.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit TxtAlici;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton BtnGonder;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.TextEdit TxtKonu;
        private DevExpress.XtraEditors.PictureEdit pictureEdit3;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraEditors.TextEdit TxtIcerik;
        private DevExpress.XtraEditors.SimpleButton BtnVazgec;
    }
}