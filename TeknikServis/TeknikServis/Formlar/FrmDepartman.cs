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
    public partial class FrmDepartman : System.Windows.Forms.Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA,
                           };
            GridCntrlDepartman.DataSource = degerler.ToList();
            Fit.FitColums(gridViewDepartman);

            lblCntrlToplamDepartman.Text = db.TBLDEPARTMAN.Count().ToString();
            lblCntrlToplamPersonel.Text = db.TBLPERSONEL.Count().ToString();
            var ali= db.calisansayisiartan()?.FirstOrDefault();
            lblCntrlEnFazlaCalisan.Text = db.calisansayisiartan()?.FirstOrDefault()?.AD;
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLDEPARTMAN t = new TBLDEPARTMAN();

            if (TxtAd.Text.Length <= 50&&TxtAd.Text!=""&&TxtAciklama.Text.Length>=1)
            {
                
            t.AD = TxtAd.Text;
            t.ACIKLAMA = TxtAciklama.Text;
            db.TBLDEPARTMAN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Eklendi", "Bilgi", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("HATALI GİRİŞ YAPTINIZ", "Hata", MessageBoxButtons.OKCancel, 
                    MessageBoxIcon.Error);
            }

        }

       

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from u in db.TBLDEPARTMAN
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.ACIKLAMA
                           };
            GridCntrlDepartman.DataSource = degerler.ToList();
            Fit.FitColums(gridViewDepartman);
        }

       

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLDEPARTMAN.Find(id);
            deger.AD = TxtAd.Text;
            deger.ACIKLAMA = TxtAciklama.Text;
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Güncellendi", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var s = db.TBLDEPARTMAN.Find(id);
            db.TBLDEPARTMAN.Remove(s);
            db.SaveChanges();
            MessageBox.Show("Departman Başarıyla Silindi", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void gridViewDepartman_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridViewDepartman.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridViewDepartman.GetFocusedRowCellValue("AD").ToString();
            TxtAciklama.Text = gridViewDepartman.GetFocusedRowCellValue("ACIKLAMA")?.ToString();
        }
    }
}
