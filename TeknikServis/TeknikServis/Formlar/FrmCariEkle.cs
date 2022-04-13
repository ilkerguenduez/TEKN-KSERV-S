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
    public partial class FrmCariEkle : System.Windows.Forms.Form
    {
        public FrmCariEkle()
        {
            InitializeComponent();
        }

        
        int secilen;
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        
        private void FrmCariEkle_Load(object sender, EventArgs e)
        {
            lookUpEditİL.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir
                                                 }).ToList();
        }

       

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLCARI t = new TBLCARI();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.TELEFON = TxtTelefon.Text;
            t.MAIL = TxtMail.Text;
            t.IL = lookUpEditİlce.Text;
            t.ILCE = lookUpEditİL.Text;
            t.BANKA = TxtBanka.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.VERGINO = TxtVergiNo.Text;
            t.STATU = TxtStatü.Text;
            t.ADRES = TxtAdres.Text;
            db.TBLCARI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Yeni Cari Başarıyla Eklendi", 
                "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

      

      

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
       

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lookUpEditİL_EditValueChanged(object sender, EventArgs e)
        {
            secilen = int.Parse(lookUpEditİL.EditValue.ToString());
            lookUpEditİlce.Properties.DataSource = (from y in db.TBLILCELER
                                                    select new
                                                    {
                                                        y.id,
                                                        y.ilce,
                                                        y.sehir
                                                    }).Where(z => z.sehir == secilen).ToList();
        }
    }
}
