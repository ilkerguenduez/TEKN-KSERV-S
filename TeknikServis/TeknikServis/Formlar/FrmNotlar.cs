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
    public partial class FrmNotlar : System.Windows.Forms.Form
    {
        public FrmNotlar()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void FrmNotlar_Load(object sender, EventArgs e)
        {
            GridCntrlİncelenmeyen.DataSource = db.TBLNOTLARIM.Where(x => x.DURUMU == false).ToList();
            Fit.FitColums(gridViewİncelenmeyen);
            GridCntrlİncelenen.DataSource = db.TBLNOTLARIM.Where(y => y.DURUMU == true).ToList();
            Fit.FitColums(gridViewİncelenen);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLNOTLARIM t = new TBLNOTLARIM();
            t.BASLIK = TxtBaslık.Text;
            t.ICERIK = TxtIcerik.Text;
            t.DURUMU = false;
            t.TARIH =DateTime.Parse(TxtTarih.Text);
            db.TBLNOTLARIM.Add(t);
            db.SaveChanges();
            MessageBox.Show("Not Eklendi", "Bilgi", 
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            GridCntrlİncelenmeyen.DataSource = db.TBLNOTLARIM.Where(x => x.DURUMU == false).ToList();
            Fit.FitColums(gridViewİncelenmeyen);
            GridCntrlİncelenen.DataSource = db.TBLNOTLARIM.Where(y => y.DURUMU == true).ToList();
            Fit.FitColums(gridViewİncelenen);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            if (checkEdit1.Checked==true)
            {
                int id = int.Parse(TxtID.Text);
                var deger = db.TBLNOTLARIM.Find(id);
                deger.DURUMU = true;
                db.SaveChanges();
                MessageBox.Show("Not Durumu Değişti", "Bilgi",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void gridViewİncelenmeyen_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridViewİncelenmeyen.GetFocusedRowCellValue("ID").ToString();
        }
    }
}
