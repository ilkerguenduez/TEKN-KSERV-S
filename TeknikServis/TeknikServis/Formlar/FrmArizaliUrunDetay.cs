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
    public partial class FrmArizaliUrunDetay : System.Windows.Forms.Form
    {
        public FrmArizaliUrunDetay()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmArizaliUrunDetay_Load(object sender, EventArgs e)
        {
            GridCntrlUrunDetay.DataSource = (from x in db.TBLURUNTAKIP
                                      select new
                                      {
                                          x.TAKIPID,
                                          x.SERINO,
                                          x.TARIH,
                                          x.ACIKLAMA
                                      }).ToList();
            Fit.FitColums(gridView1);
        }
    }
}
