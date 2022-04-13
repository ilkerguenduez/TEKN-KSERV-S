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
    public partial class FrmFaturaListesi : System.Windows.Forms.Form
    {
        public FrmFaturaListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmFaturaListesi_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRESI,
                               CARİ=u.TBLCARI.AD+" "+u.TBLCARI.SOYAD,
                               PERSONEL=u.TBLPERSONEL.AD+" "+u.TBLPERSONEL.SOYAD

                           };
            
            
            GridCntrlFaturaList.DataSource = degerler.ToList();
            Fit.FitColums(gridViewFaturaListe);

            lookUpEditCari.Properties.DataSource = (from x in db.TBLCARI
                                                 select new
                                                 {
                                                     x.ID,
                                                     ad=x.AD+" "+x.SOYAD
                                                 }).ToList();

            lookUpEditPersonel.Properties.DataSource = (from x in db.TBLPERSONEL
                                                 select new
                                                 {
                                                     x.ID,
                                                     ad = x.AD + " " + x.SOYAD
                                                 }).ToList();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURABILGI
                           select new
                           {
                               u.ID,
                               u.SERI,
                               u.SIRANO,
                               u.TARIH,
                               u.SAAT,
                               u.VERGIDAIRESI,
                               CARİ = u.TBLCARI.AD+" " + u.TBLCARI.SOYAD,
                               PERSONEL = u.TBLPERSONEL.AD+" " + u.TBLPERSONEL.SOYAD

                           };
            GridCntrlFaturaList.DataSource = degerler.ToList();
            Fit.FitColums(gridViewFaturaListe);

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURABILGI t = new TBLFATURABILGI();
            t.SERI = TxtSeri.Text;
            t.SIRANO = TxtSıra.Text;
            t.TARIH = DateTime.Parse(TxtTarih.Text);
            t.SAAT = TxtSaat.Text;
            t.VERGIDAIRESI = TxtVergiDairesi.Text;
            t.CARI =int.Parse( lookUpEditCari.EditValue.ToString());
            t.PERSONEL = short.Parse(lookUpEditPersonel.EditValue.ToString());
            db.TBLFATURABILGI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Başarıyla Kaydedildi,Kalem Girişi Yapılabilir.", "INFO",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void gridViewFaturaListe_DoubleClick(object sender, EventArgs e)
        {
            FrmFaturaKalemPopup fr = new FrmFaturaKalemPopup();
            fr.id = int.Parse(gridViewFaturaListe.GetFocusedRowCellValue("ID").ToString());
            fr.Show();
        }
    } 
}
