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
    public partial class FrmPersonel : System.Windows.Forms.Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        private void liste()
        {
            var degerler = from u in db.TBLPERSONEL
                           select new
                           {
                               u.ID,
                               u.AD,
                               u.SOYAD,
                               u.FOTOĞRAF,
                               u.MAIL,
                               u.TELEFON
                           };
            GridCntrlPersonel.DataSource = degerler.ToList();
            Fit.FitColums(gridView1);
        }
        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            liste();
            /* db.TBLPERSONEL.Select(u => new
             {
                 u.ID,
                 u.AD,
                 u.SOYAD,
                 u.FOTOĞRAF,
                 u.MAIL,
                 u.TELEFON
             });*/




            lookUpEditDepartman.Properties.DataSource = (from u in db.TBLDEPARTMAN
                                                select new
                                                {
                                                    u.ID,
                                                    u.AD
                                                }).ToList();

            string ad1, soyad1;
            ad1 = db.TBLPERSONEL.First(x => x.ID == 1).AD;
            soyad1 = db.TBLPERSONEL.First(x => x.ID == 1).SOYAD;
            lblControlMail.Text = db.TBLPERSONEL.FirstOrDefault(x => x.ID == 1)?.MAIL;
            lblCntrlDepartman.Text = db.TBLPERSONEL.First(x => x.ID == 1).TBLDEPARTMAN.AD;
            lblCntrlAdSoyad.Text = ad1 + " " + soyad1;
            

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLPERSONEL t = new TBLPERSONEL();
            t.AD = TxtAd.Text;
            t.SOYAD = TxtSoyad.Text;
            t.DEPARTMAN = byte.Parse(lookUpEditDepartman.EditValue.ToString());
            db.TBLPERSONEL.Add(t);
            db.SaveChanges();
            MessageBox.Show("Personel Başarıyla Eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            liste();
        }
    }
}
