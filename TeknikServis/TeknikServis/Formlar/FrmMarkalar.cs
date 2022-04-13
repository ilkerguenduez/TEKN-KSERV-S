using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TeknikServis.Formlar
{
    public partial class FrmMarkalar : System.Windows.Forms.Form
    {
        public FrmMarkalar()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmMarkalar_Load(object sender, EventArgs e)
        {
            var degerler = db.TBLURUN.OrderBy(x => x.MARKA).GroupBy(y => y.MARKA).Select(z => new
            {
                Marka = z.Key,
                Toplam = z.Count()
            });
            GridCntrlMarkalar.DataSource = degerler.ToList();
            Fit.FitColums(gridView1);
            lblCntrlToplamUrun.Text = db.TBLURUN.Count().ToString();
            lblCntrlToplamMarka.Text = (from x in db.TBLURUN
                                  select x.MARKA).Distinct().Count().ToString();
            lblCntrlEnYuksekFiyatMarka.Text = (from x in db.TBLURUN
                                  orderby x.SATISFIYATI descending
                                  select x.MARKA).FirstOrDefault();

            lblCntrlEnFazlaÜrünMarka.Text = db.maksurunmarka().FirstOrDefault();

            //chartControl1.Series["Series 1"].Points.AddPoint("Siemens", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Arçelik", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Acer", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Teka", 4);
            //chartControl1.Series["Series 1"].Points.AddPoint("Sony", 4);

            SqlConnection baglanti = new SqlConnection(@"Data Source=GUENDUEZ\SQLEXPRESS2019;
Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA ", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse( dr[1].ToString()));
            }
            baglanti.Close();


            //2.chart
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("SELECT TBLKATEGORI.ADI,COUNT(*) FROM TBLURUN INNER JOIN TBLKATEGORI ON " +
                "TBLKATEGORI.ID = TBLURUN.KATEGORI GROUP BY TBLKATEGORI.ADI ", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                chartControl2.Series["Series 1"].Points.AddPoint(Convert.ToString(dr2[0]), int.Parse(dr2[1].ToString()));
            }
            baglanti.Close();


        }

       
    }
}
