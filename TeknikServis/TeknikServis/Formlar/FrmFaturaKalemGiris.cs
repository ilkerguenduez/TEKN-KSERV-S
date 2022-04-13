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
    public partial class FrmFaturaKalemGiris : System.Windows.Forms.Form
    {
        public FrmFaturaKalemGiris()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLFATURADETAY t = new TBLFATURADETAY();
            t.URUN = TxtUrun.Text;
            t.ADET = short.Parse(TxtAdet.Text);
            t.FIYAT = decimal.Parse(TxtFiyat.Text);
            t.TUTAR = decimal.Parse(TxtTutar.Text);
            t.FATURAID = int.Parse(TxtFaturaID.Text);
            db.TBLFATURADETAY.Add(t);
            db.SaveChanges();
            MessageBox.Show("Fatura Kalem Girişi Yapıldı", "INFO",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmFaturaKalemGiris_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID,


                           };
            GridCntrlFaturaKalemGiris.DataSource = degerler.ToList();
            Fit.FitColums(gridView1);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLFATURADETAY
                           select new
                           {
                               u.FATURADETAYID,
                               u.URUN,
                               u.ADET,
                               u.FIYAT,
                               u.TUTAR,
                               u.FATURAID,


                           };
            GridCntrlFaturaKalemGiris.DataSource = degerler.ToList();
            Fit.FitColums(gridView1);
        }
    }
}
