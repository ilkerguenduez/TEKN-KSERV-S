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
    public partial class Frmİstatistik : System.Windows.Forms.Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

       
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {//Linq Sorgular ile
            lblCntrlToplamUrun.Text = db.TBLURUN.Count().ToString();

            lblCntrlToplamKategori.Text = db.TBLKATEGORI.Count().ToString(); //burda kategori tablosundaki verileri saydırıp string formatında labela kaydettim.

            lblCntrlStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();

            //alblCntrlKritik.Text = "10";
 
            dataGridView1.DataSource= (from x in db.TBLURUN
                                       orderby x.STOK ascending
                                       select new 
                                       {
                                           x.AD,
                                           x.STOK
                                          
                                       }).Where(x => x.STOK < 30).ToList();
            

            lblCntrlEnFazlaStok.Text = (from x in db.TBLURUN
                                   orderby x.STOK descending
                                   select x.AD).FirstOrDefault();

            lblCntrlEnAzStok.Text = (from y in db.TBLURUN
                                   orderby y.STOK ascending
                                   select y.AD).FirstOrDefault();

            lblCntrlEnYükseFiyat.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYATI descending
                                   select x.AD).FirstOrDefault();

            lblCntrlEnDüsükFiyat.Text = (from x in db.TBLURUN
                                   orderby x.SATISFIYATI ascending
                                   select x.AD).FirstOrDefault();

            var deger2 = (from x in db.TBLURUN
                          orderby x.STOK ascending
                          select new
                          {
                              x.AD,
                              x.STOK
                          }).Where(x => x.STOK < 30).FirstOrDefault().AD;
            lblCntrlKritik.Text = deger2.ToString(); 
            


            lblCntrlBeyazEsya.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();

            lblCntrlBilgisayar.Text = db.TBLURUN.Count(x => x.KATEGORI ==1).ToString();

            lblCntrlKücükEvAletleri.Text = db.TBLURUN.Count(x => x.KATEGORI ==3).ToString();

            lblCntrlToplamMarka.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();

            lblCntrlArızalıUrunSayi.Text = db.TBLURUNKABUL.Count().ToString();

            var deger1 = (from a in db.TBLURUN.GroupBy(u => u.MARKA)
                          orderby a.Count() descending
                          select new
                          {
                              a.Key,
                              Toplam = a.Count()
                          }).Select(a => a.Key).FirstOrDefault();

            lblCntrlEnFazlaÜrünOlanMarka.Text = deger1.ToString();

            lblCntrlEnFazlaUrunKategori.Text = db.makskategoriurun().FirstOrDefault();

            lblCntrlSatılanUrunSayisi.Text = db.TBLURUNHAREKET.Count().ToString();

            lblCntrlArızalıUrunSayi.Text = db.TBLURUNKABUL.Count().ToString();

            lblCntrlTamir.Text= db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekleniyor").ToString();
        }

     
    }
}
