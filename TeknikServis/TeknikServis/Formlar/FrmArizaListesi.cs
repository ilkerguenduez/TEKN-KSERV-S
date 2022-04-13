using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmArizaListesi : System.Windows.Forms.Form
    {

        public FrmArizaListesi()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaListesi_Load(object sender, EventArgs e)
        {
            
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            GrdCntrlArizaList.DataSource = degerler.ToList();
            Fit.FitColums(GridWiewArizaList);

            lblcntrlarizaliurun.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == true).ToString(); //lambda sorgusu
            lblcntrltamiribitmis.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUM == false).ToString(); //lambda sorgusu
            lblcntrltoplamurun.Text = db.TBLURUN.Count().ToString();
            lblcntrlparcabekleyen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Parça Bekleniyor").ToString();
            lblcntrldonusbeklenen.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "Müşteriden Geri Dönüş Bekleniyor").ToString();
            lblcntrliptal.Text = db.TBLURUNKABUL.Count(x => x.URUNDURUMDETAY == "İptal Bekleniyor").ToString();


            SqlConnection baglanti = new SqlConnection(@"Data Source=GUENDUEZ\SQLEXPRESS2019;
Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT URUNDURUMDETAY,COUNT(*) FROM TBLURUNKABUL GROUP BY URUNDURUMDETAY ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString(dr[0]), int.Parse(dr[1].ToString()));
            }
            baglanti.Close();
        }

        private void GridWiewArizaList_DoubleClick(object sender, EventArgs e)
        {
            FrmArizaDetaylar fr = new FrmArizaDetaylar();
            fr.id = GridWiewArizaList.GetFocusedRowCellValue("ISLEMID").ToString();
            fr.serino = GridWiewArizaList.GetFocusedRowCellValue("URUNSERINO").ToString();
            
            fr.Show();
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            var degerler = from x in db.TBLURUNKABUL
                           select new
                           {
                               x.ISLEMID,
                               CARİ = x.TBLCARI.AD + " " + x.TBLCARI.SOYAD,
                               PERSONEL = x.TBLPERSONEL.AD + " " + x.TBLPERSONEL.SOYAD,
                               x.GELISTARIHI,
                               x.CIKISTARIHI,
                               x.URUNSERINO,
                               x.URUNDURUMDETAY
                           };
            GrdCntrlArizaList.DataSource = degerler.ToList();
        }

    }
}
