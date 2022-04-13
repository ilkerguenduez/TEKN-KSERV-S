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
    public partial class FrmArizaliUrunKaydi : System.Windows.Forms.Form
    {
        public FrmArizaliUrunKaydi()
        {
            InitializeComponent();
        }

       
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        
        private void BtnKaydet_Click(object sender, EventArgs e)
        {



            TBLURUNKABUL t = new TBLURUNKABUL();
            t.CARI = int.Parse(lookUpEditCari.EditValue.ToString());
            t.GELISTARIHI = DateTime.Parse(TxtTarih.Text);
            t.PERSONEL = short.Parse(lookUpEditPersonel.EditValue.ToString());
            t.URUNSERINO = TxtSeriNo.Text;
            t.URUNDURUM =bool.Parse(txtUrunDurum.Text);
            t.URUNDURUMDETAY = "Ürün Kaydoldu";
            db.TBLURUNKABUL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Arıza Kaydı Yapıldı", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmArizaliUrunKaydi_Load(object sender, EventArgs e)
        {
            //Müşteri
            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
            //Personel
            lookUpEditPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtTarih_Click(object sender, EventArgs e)
        {
            TxtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVeriGetir_Click(object sender, EventArgs e)
        {
            var verigetir = db.TBLURUNHAREKET.SingleOrDefault(x => x.URUNSERINO == TxtSeriNo.Text);
            if (verigetir != null)
            {
                lookUpEditCari.Text = verigetir.TBLCARI.AD.ToString() + " " + verigetir.TBLCARI.SOYAD.ToString();
                lookUpEditPersonel.Text = verigetir.TBLPERSONEL.AD.ToString() + " " + verigetir.TBLPERSONEL.SOYAD.ToString();

            }
        }
    }
}
