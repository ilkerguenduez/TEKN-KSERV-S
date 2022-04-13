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
    public partial class FrmCariListesi : System.Windows.Forms.Form
    {
        public FrmCariListesi()
        {
            InitializeComponent();
        }
        int secilen;
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        void liste()
        {
            GridCntrlCariList.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.ID,
                                           x.AD,
                                           x.SOYAD,
                                           x.TELEFON,
                                           x.MAIL,
                                           x.IL,
                                           x.ILCE,
                                           x.BANKA,
                                           x.VERGIDAIRESI,
                                           x.VERGINO,
                                           x.STATU,
                                           x.ADRES
                                       }).ToList();
            Fit.FitColums(GridWiewCari);


        }
        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            liste();

            lblCntrlToplamCari.Text = db.TBLCARI.Count().ToString();

            lblCntrlToplamİl.Text = db.TBLCARI.Select(x => x.IL).Distinct().Count().ToString();

            lblCntrlToplamİlce.Text = db.TBLCARI.Select(x => x.ILCE).Distinct().Count().ToString();

            lblcntrlMerkezSube.Text = db.enfazlacarııl().FirstOrDefault();

            lookUpEditİL.Properties.DataSource = (from x in db.TBLILLER
                                                 select new
                                                 {
                                                     x.id,
                                                     x.sehir,
                                                 }).ToList();
        }

       

        

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtAd.Text != "" & TxtSoyad.Text != "")
            {
                TBLCARI t = new TBLCARI();
                t.AD = TxtAd.Text;
                t.SOYAD = TxtSoyad.Text;
                t.TELEFON = TxtTelefon.Text;
                t.MAIL = TxtMail.Text;
                t.IL = lookUpEditİL.Text;
                t.ILCE = lookUpEditİlce.Text;
                t.BANKA = TxtBanka.Text;
                t.VERGIDAIRESI = TxtVergiDairesi.Text;
                t.VERGINO = TxtVergiNo.Text;
                t.STATU = TxtStatü.Text;
                t.ADRES = TxtAdres.Text;
                db.TBLCARI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Cari Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                liste();
            }
            else
            {
                MessageBox.Show("HATA");
            }
            
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

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var s = db.TBLCARI.Find(id);
            db.TBLCARI.Remove(s);
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var g = db.TBLCARI.Find(id);
            g.AD = TxtAd.Text;
            g.SOYAD = TxtSoyad.Text;
            g.TELEFON = TxtTelefon.Text;
            g.MAIL = TxtMail.Text;
            g.IL = lookUpEditİL.Text.ToString();
            g.ILCE = lookUpEditİlce.Text.ToString();
            g.BANKA = TxtBanka.Text;
            g.VERGIDAIRESI = TxtVergiDairesi.Text;
            g.VERGINO = TxtVergiNo.Text;
            g.STATU = TxtStatü.Text;
            g.ADRES = TxtAdres.Text;
            db.SaveChanges();
            MessageBox.Show("Cari Başarıyla Güncellendi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            liste();
        }

        private void GridWiewCari_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {
                TxtID.Text = GridWiewCari.GetFocusedRowCellValue("ID").ToString();
                TxtAd.Text = GridWiewCari.GetFocusedRowCellValue("AD").ToString();
                TxtSoyad.Text = GridWiewCari.GetFocusedRowCellValue("SOYAD").ToString();
                TxtTelefon.Text = GridWiewCari.GetFocusedRowCellValue("TELEFON").ToString();
                TxtMail.Text = GridWiewCari.GetFocusedRowCellValue("MAIL").ToString();
                lookUpEditİL.Text = GridWiewCari.GetFocusedRowCellValue("IL").ToString();
                lookUpEditİlce.Text = GridWiewCari.GetFocusedRowCellValue("ILCE").ToString();
                TxtBanka.Text = GridWiewCari.GetFocusedRowCellValue("BANKA").ToString();
                TxtVergiDairesi.Text = GridWiewCari.GetFocusedRowCellValue("VERGIDAIRESI").ToString();
                TxtVergiNo.Text = GridWiewCari.GetFocusedRowCellValue("VERGINO").ToString();
                TxtStatü.Text = GridWiewCari.GetFocusedRowCellValue("STATU").ToString();
                TxtAdres.Text = GridWiewCari.GetFocusedRowCellValue("ADRES")?.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("HATA");
            }
        }
    }
}
