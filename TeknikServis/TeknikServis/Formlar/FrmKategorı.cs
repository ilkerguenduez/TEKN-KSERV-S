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
    public partial class FrmKategorı : System.Windows.Forms.Form
    {
        public FrmKategorı()
        {
            InitializeComponent();
        }

        //private void groupControl1_Paint(object sender, PaintEventArgs e)
        //{

        //}
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmKategorı_Load(object sender, EventArgs e)
        {
            var degerler = from l in db.TBLKATEGORI
                           select new
                           {
                               l.ID,
                               l.ADI
                           };
            GridCntrlKategori.DataSource = degerler.ToList();
            Fit.FitColums(gridViewKategori);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text!=""&& TxtAd.Text.Length<=30)
            {
                TBLKATEGORI k = new TBLKATEGORI();
                k.ADI = TxtAd.Text;
                db.TBLKATEGORI.Add(k);
                db.SaveChanges();
                MessageBox.Show("Kategori başarıyla eklendi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Olamaz ve Kategori Adı 30 Karakterden Fazla Olamaz.");
            }

            
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from l in db.TBLKATEGORI
                           select new
                           {
                               l.ID,
                               l.ADI
                           };
            GridCntrlKategori.DataSource = degerler.ToList();
            Fit.FitColums(gridViewKategori);

        }



        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var g = db.TBLKATEGORI.Find(id);
            g.ADI = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAd.Text = "";
            TxtID.Text = "";
        }

        private void gridViewKategori_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridViewKategori.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridViewKategori.GetFocusedRowCellValue("ADI").ToString();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var s = db.TBLKATEGORI.Find(id);
            db.TBLKATEGORI.Remove(s);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }
    }
}
