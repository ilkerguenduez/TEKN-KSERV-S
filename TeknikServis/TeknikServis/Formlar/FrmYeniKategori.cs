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
    public partial class FrmYeniKategori : System.Windows.Forms.Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }

        private void FrmYeniKategori_Load(object sender, EventArgs e)
        {

        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtKategoriAd.Text!=""&&TxtKategoriAd.Text.Length<=30)
            {
                TBLKATEGORI t = new TBLKATEGORI();
                t.ADI = TxtKategoriAd.Text;
                db.TBLKATEGORI.Add(t);
                db.SaveChanges();
                MessageBox.Show("Kategori Başarıyla Kaydedildi");
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Olamaz", "HATA",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void BtnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
