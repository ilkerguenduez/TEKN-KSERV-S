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
    public partial class FrmRehber : System.Windows.Forms.Form
    {
        public FrmRehber()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db =new DBTEKNIKSERVISEntities();
        private void FrmRehber_Load(object sender, EventArgs e)
        {
            GridCntrlRehber.DataSource = (from x in db.TBLCARI
                                       select new
                                       {
                                           x.AD,
                                           x.SOYAD,
                                           x.TELEFON,
                                           x.MAIL,

                                       }).ToList();
            Fit.FitColums(gridView1);
        }
    }
}
