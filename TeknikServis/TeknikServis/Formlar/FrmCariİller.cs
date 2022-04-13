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
    public partial class FrmCariİller : System.Windows.Forms.Form
    {
        public FrmCariİller()
        {
            InitializeComponent();
        }

       
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        SqlConnection baglanti = new SqlConnection(@"Data Source=GUENDUEZ\SQLEXPRESS2019;Initial Catalog=DBTEKNIKSERVIS;Integrated Security=True");
        private void FrmCariİller_Load(object sender, EventArgs e)
        {
            //chartControl1.Series["Series 1"].Points.AddPoint("Ankara", 22);
            //chartControl1.Series["Series 1"].Points.AddPoint("İstanbul", 34);
            //chartControl1.Series["Series 1"].Points.AddPoint("Gaziantep", 27);
            //chartControl1.Series["Series 1"].Points.AddPoint("Elazığ", 23);

            GridCntrlCariİller.DataSource = db.TBLCARI.OrderBy(x => x.IL).
                GroupBy(y => y.IL).
                Select(z => new { İl = z.Key, Toplam = z.Count() }).ToList();
            Fit.FitColums(gridView1);

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select IL,COUNT(*) FROM TBLCARI group by IL", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartControl1.Series["Series 1"].Points.AddPoint(Convert.ToString( dr[0]),int.Parse( dr[1].ToString()));
            }
            baglanti.Close();
        }

       
    }
}
