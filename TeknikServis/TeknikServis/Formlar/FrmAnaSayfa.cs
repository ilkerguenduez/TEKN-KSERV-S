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
    public partial class FrmAnaSayfa : System.Windows.Forms.Form
    {
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {
            GridCntrlKritik.DataSource = (from x in db.TBLURUN
                                       select new
                                       {
                                           x.AD,
                                           x.STOK
                                       }).Where(x => x.STOK < 30).ToList();
            Fit.FitColums(GridWiewKritik);
            GridCntrlFihrist.DataSource = (from y in db.TBLCARI
                                       select new
                                       {
                                           y.AD,
                                           y.SOYAD,
                                           y.IL
                                       }).ToList();

            GridCntrlKatUrun.DataSource = db.urunkategori().ToList();
            Fit.FitColums(GridWiewKatUrun);

            DateTime bugun = DateTime.Today;
            var deger = (from x in db.TBLNOTLARIM.OrderBy(y => y.ID)
                         where (x.TARIH == bugun)
                         select new { x.BASLIK, x.ICERIK });
            GridCntrlIsler.DataSource = deger.ToList();
            Fit.FitColums(GridWiewIsler);

            string konu1, ad1, konu2, ad2, konu3, ad3, konu4, ad4, konu5, ad5;
            konu1 = db.TBLILETISIM.FirstOrDefault(x => x.ID == 1).KONU;
            ad1 = db.TBLILETISIM.FirstOrDefault(x => x.ID == 1).ADSOYAD;
            label1.Text = konu1 + " -- " + ad1;
        }
    }
}
