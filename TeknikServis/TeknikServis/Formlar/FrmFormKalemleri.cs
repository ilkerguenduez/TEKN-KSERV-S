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
    public partial class FrmFormKalemleri : System.Windows.Forms.Form
    {
        public FrmFormKalemleri()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void BtnAra_Click(object sender, EventArgs e)
        {
            int id = 0;



            if (int.TryParse(TxtID.Text, out id))
            {

                var degerler = (from u in db.TBLFATURADETAY
                                select new
                                {
                                    u.FATURADETAYID,
                                    u.URUN,
                                    u.ADET,
                                    u.FIYAT,
                                    u.TUTAR,
                                    u.FATURAID

                                }).Where(x => x.FATURAID == id);
                GridCntrlFormKalemleri.DataSource = degerler.ToList();
                Fit.FitColums(gridView1);


            }
            else
            {
                var val2 = (from i in db.TBLFATURADETAY.Where(m => m.TBLFATURABILGI.SERI ==
                    TxtSeriNo.Text.ToLower() || m.TBLFATURABILGI.SIRANO == TxtSıraNo.Text)
                            select new
                            {
                                i.URUN,
                                i.ADET,
                                i.FIYAT,
                                i.TUTAR,
                                cari = i.TBLFATURABILGI.TBLCARI.AD + " " + i.TBLFATURABILGI.TBLPERSONEL.SOYAD,
                                i.TBLFATURABILGI.SERI,
                                i.TBLFATURABILGI.SIRANO,
                                i.FATURAID
                            });
                GridCntrlFormKalemleri.DataSource = val2.ToList();
                Fit.FitColums(gridView1);

            }



        }

        private void FrmFormKalemleri_Load(object sender, EventArgs e)
        {

        }

        /*private void simpleButton1_Click(object sender, EventArgs e)
        {
            var val2 = (from i in db.TBLFATURADETAY.Where(m => m.TBLFATURABILGI.SERI ==
                        TxtSeriNo.Text.ToLower() | m.TBLFATURABILGI.SIRANO == TxtSıraNo.Text)
                        select new
                        {
                            i.URUN,
                            i.ADET,
                            i.FIYAT,
                            i.TUTAR,
                            cari = i.TBLFATURABILGI.TBLCARI.AD + " " + i.TBLFATURABILGI.TBLPERSONEL.SOYAD,
                            i.TBLFATURABILGI.SERI,
                            i.TBLFATURABILGI.SIRANO,
                            i.FATURAID
                        });
            GridCntrlFormKalemleri.DataSource = val2.ToList();*/

    }
}
