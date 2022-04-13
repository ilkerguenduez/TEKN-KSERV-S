using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaDetaylar : System.Windows.Forms.Form
    {
        public FrmArizaDetaylar()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNTAKIP t = new TBLURUNTAKIP();
            t.ACIKLAMA = TxtAcıklama.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.SERINO = TxtSeriNo.Text;
            db.TBLURUNTAKIP.Add(t);
            


            //GÜNCELLEME
            TBLURUNKABUL tb = new TBLURUNKABUL();
            int urunid = int.Parse(id.ToString());
            var deger = db.TBLURUNKABUL.Find(urunid);
            deger.URUNDURUMDETAY = comboBoxAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("ARIZA DETAYLARI EKLENDİ", "BİLGİ",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public string id, serino;
        private void FrmArizaDetaylar_Load(object sender, EventArgs e)
        {
            TxtSeriNo.Text = serino;
        }

        private void TxtSeriNo_Click(object sender, EventArgs e)
        {
            TxtSeriNo.Text = "";
        }

       

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
