
namespace TeknikServis.Formlar
{
    partial class FrmQRCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQRCode));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSeriNo = new DevExpress.XtraEditors.TextEdit();
            this.pictureEditQRCODE = new DevExpress.XtraEditors.PictureEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnQRCode = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureEdit2 = new DevExpress.XtraEditors.PictureEdit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCODE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Unispace", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(23, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(360, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "SERİ NO İÇİN QR CODE OLUŞTURMA";
            // 
            // TxtSeriNo
            // 
            this.TxtSeriNo.Location = new System.Drawing.Point(99, 71);
            this.TxtSeriNo.Name = "TxtSeriNo";
            this.TxtSeriNo.Properties.Appearance.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.TxtSeriNo.Properties.Appearance.Options.UseBackColor = true;
            this.TxtSeriNo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.TxtSeriNo.Properties.Mask.EditMask = "AAAAA";
            this.TxtSeriNo.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Simple;
            this.TxtSeriNo.Size = new System.Drawing.Size(246, 20);
            this.TxtSeriNo.TabIndex = 2;
            // 
            // pictureEditQRCODE
            // 
            this.pictureEditQRCODE.Location = new System.Drawing.Point(99, 181);
            this.pictureEditQRCODE.Name = "pictureEditQRCODE";
            this.pictureEditQRCODE.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEditQRCODE.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditQRCODE.Size = new System.Drawing.Size(246, 188);
            this.pictureEditQRCODE.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Unispace", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(81, 18);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "SERİ NO: ";
            // 
            // BtnQRCode
            // 
            this.BtnQRCode.Appearance.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnQRCode.Appearance.ForeColor = System.Drawing.Color.Red;
            this.BtnQRCode.Appearance.Options.UseFont = true;
            this.BtnQRCode.Appearance.Options.UseForeColor = true;
            this.BtnQRCode.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnQRCode.ImageOptions.Image")));
            this.BtnQRCode.Location = new System.Drawing.Point(126, 104);
            this.BtnQRCode.Name = "BtnQRCode";
            this.BtnQRCode.Size = new System.Drawing.Size(196, 55);
            this.BtnQRCode.TabIndex = 5;
            this.BtnQRCode.Text = "QR Code Oluştur";
            this.BtnQRCode.Click += new System.EventHandler(this.BtnQRCode_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(99, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 1);
            this.panel1.TabIndex = 6;
            // 
            // pictureEdit2
            // 
            this.pictureEdit2.EditValue = ((object)(resources.GetObject("pictureEdit2.EditValue")));
            this.pictureEdit2.Location = new System.Drawing.Point(389, -1);
            this.pictureEdit2.Name = "pictureEdit2";
            this.pictureEdit2.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit2.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit2.Size = new System.Drawing.Size(38, 37);
            this.pictureEdit2.TabIndex = 7;
            this.pictureEdit2.Click += new System.EventHandler(this.pictureEdit2_Click);
            // 
            // FrmQRCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(426, 381);
            this.Controls.Add(this.pictureEdit2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnQRCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.pictureEditQRCODE);
            this.Controls.Add(this.TxtSeriNo);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmQRCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQRCode";
            this.Load += new System.EventHandler(this.FrmQRCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSeriNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEditQRCODE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit TxtSeriNo;
        private DevExpress.XtraEditors.PictureEdit pictureEditQRCODE;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnQRCode;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.PictureEdit pictureEdit2;
    }
}