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
    public partial class FrmYenıUrun : System.Windows.Forms.Form
    {
        public FrmYenıUrun()
        {
            InitializeComponent();
        }

       

        private void FrmYenıUrun_Load(object sender, EventArgs e)
        {
            lookUpEditKategori.Properties.DataSource = (from x in db.TBLKATEGORI
                                                 select new
                                                 {
                                                     x.ID,
                                                     x.ADI
                                                 }).ToList();
        }

        

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
           // fr.Hide();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.ALISFIYATI = decimal.Parse( TxtAlısFıyat.Text);
            t.SATISFIYATI = decimal.Parse(TxtSatısFıyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            //t.KATEGORI = byte.Parse(TxtKategori.Text);
            t.KATEGORI = byte.Parse(lookUpEditKategori.EditValue.ToString());
            t.MARKA = TxtMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla kaydedildi.");
        }

        

        private void TxtUrunAd_Click(object sender, EventArgs e)
        {
            TxtUrunAd.Text = "";
            TxtUrunAd.Focus();
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
