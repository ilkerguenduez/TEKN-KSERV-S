using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace TeknikServis.Formlar
{
    public partial class FrmQRCode : System.Windows.Forms.Form
    {
        public FrmQRCode()
        {
            InitializeComponent();
        }

        private void FrmQRCode_Load(object sender, EventArgs e)
        {
            
        }

       

        private void pictureEdit2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnQRCode_Click(object sender, EventArgs e)
        {
            QRCodeEncoder qr = new QRCodeEncoder();
            pictureEditQRCODE.Image = qr.Encode(TxtSeriNo.Text);
        }
    }
}
