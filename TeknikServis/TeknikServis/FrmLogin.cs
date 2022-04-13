using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis
{
    public partial class FrmLogin : System.Windows.Forms.Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.TBLADMIN
                        where x.KULLANICIAD == TxtKullaniciAd.Text &
  x.SIFRE == TxtSifre.Text
                        select x;
            if (sorgu.Any())
            {
                FrmAnaPage frm = new FrmAnaPage();
                frm.Show();
                this.Hide();
            }
            else
            {
                XtraMessageBox.Show("Hatalı Giriş");
            }
        }
    }
}
