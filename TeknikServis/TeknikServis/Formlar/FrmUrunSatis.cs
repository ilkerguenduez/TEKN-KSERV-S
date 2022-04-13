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
    public partial class FrmUrunSatis : System.Windows.Forms.Form
    {
        public FrmUrunSatis()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUNHAREKET t = new TBLURUNHAREKET();

            t.URUN =int.Parse( lookUpEditUrun.EditValue.ToString());
            t.MUSTERI =int.Parse( lookUpEditCari.EditValue.ToString());
            t.PERSONEL =short.Parse( lookUpEditPersonel.EditValue.ToString());
            t.TARIH =DateTime.Parse( TxtTarih.Text);
            t.ADET =short.Parse( TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtSatisFiyati.Text);
            t.URUNSERINO = TxtSeriNo.Text;
            db.TBLURUNHAREKET.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Satışı Başarıyla Yapıldı.", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void FrmUrunSatis_Load(object sender, EventArgs e)
        {
            lookUpEditUrun.Properties.DataSource = (from x in db.TBLURUN
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.AD
                                                 }).ToList();

            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     AD=x.AD+" "+x.SOYAD
                                                 }).ToList();

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

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
