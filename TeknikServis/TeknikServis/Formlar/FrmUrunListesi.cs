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
    public partial class FrmUrunListesi : System.Windows.Forms.Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }

        


        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void listele()
        {
            var degerler = from u in db.TBLURUN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.MARKA,
                               KATEGORI = u.TBLKATEGORI.ADI,
                               u.STOK,
                               u.ALISFIYATI,
                               u.SATISFIYATI,
                           };
            GridCntrlUrunListesi.DataSource = degerler.ToList();
            Fit.FitColums(gridViewUrunListesi);
        }
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            //Listeleme ToList Add Remove
            //var degerler = db.TBLURUN.ToList();
            listele();
            lookUpEditKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.ADI
                                                 }).ToList();

        }

      

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLURUN k = new TBLURUN();
            k.AD = TxtUrunAd.Text;
            k.MARKA = TxtMarka.Text;
            k.ALISFIYATI = decimal.Parse(TxtAlisFiyat.Text);
            k.SATISFIYATI = decimal.Parse(TxtSatisFiyat.Text);
            k.STOK = short.Parse(TxtStok.Text);
            k.DURUM = false;
            k.KATEGORI = byte.Parse(lookUpEditKategori.EditValue.ToString());
            db.TBLURUN.Add(k);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Eklendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

       
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var g = db.TBLURUN.Find(id);
            g.AD = TxtUrunAd.Text;
            g.STOK = short.Parse(TxtStok.Text);
            g.MARKA = TxtMarka.Text;
            g.ALISFIYATI = decimal.Parse(TxtAlisFiyat.Text);
            g.SATISFIYATI = decimal.Parse(TxtSatisFiyat.Text);
            g.KATEGORI = byte.Parse(lookUpEditKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAlisFiyat.Text = "";
            TxtID.Text = "";
            TxtMarka.Text = "";
            TxtSatisFiyat.Text = "";
            TxtStok.Text = "";
            TxtUrunAd.Text = "";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var s = db.TBLURUN.Find(id);
            db.TBLURUN.Remove(s);
            db.SaveChanges();
            MessageBox.Show("Ürün Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void gridViewUrunListesi_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = gridViewUrunListesi.GetFocusedRowCellValue("ID").ToString();
                TxtUrunAd.Text = gridViewUrunListesi.GetFocusedRowCellValue("AD").ToString();
                TxtMarka.Text = gridViewUrunListesi.GetFocusedRowCellValue("MARKA").ToString();
                TxtAlisFiyat.Text = gridViewUrunListesi.GetFocusedRowCellValue("ALISFIYATI").ToString();
                TxtSatisFiyat.Text = gridViewUrunListesi.GetFocusedRowCellValue("SATISFIYATI").ToString();
                TxtStok.Text = gridViewUrunListesi.GetFocusedRowCellValue("STOK").ToString();
                lookUpEditKategori.Text = gridViewUrunListesi.GetFocusedRowCellValue("KATEGORI").ToString();
            }
            catch (Exception)
            {

                MessageBox.Show("HATA");
            }
        }
    }
}
