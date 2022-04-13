using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.İletişim
{
    public partial class FrmGelenMesajlar : System.Windows.Forms.Form
    {
        public FrmGelenMesajlar()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmGelenMesajlar_Load(object sender, EventArgs e)
        {
            lblToplamMesaj.Text = db.TBLILETISIM.Count().ToString();
            lblTesekkürMesaj.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            lblTesekkürMesaj.Text = db.TBLILETISIM.Where(x => x.KONU == "Teşekkür").Count().ToString();
            lblSikayet.Text = db.TBLILETISIM.Where(x => x.KONU == "Şikayet").Count().ToString();

            GridCntrlGelenMesajlar.DataSource = (from x in db.TBLILETISIM
                                       select new
                                       {
                                           x.ID,
                                           x.ADSOYAD,
                                           x.KONU,
                                           x.MAIL,
                                           x.MESAJ
                                       }).ToList();
            Fit.FitColums(gridView1);
        }

        
    }
}
