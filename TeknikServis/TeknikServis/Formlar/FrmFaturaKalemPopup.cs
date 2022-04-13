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
    public partial class FrmFaturaKalemPopup : System.Windows.Forms.Form
    {
        public FrmFaturaKalemPopup()
        {
            InitializeComponent();
        }

        public int id;
        private void FrmFaturaKalemPopup_Load(object sender, EventArgs e)
        {
            //label1.Text = id.ToString();
            DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
            GridCntrlFaturaKalemleri.DataSource = db.TBLFATURADETAY.Where(x => x.FATURAID == id).ToList();
            GridCntrlFaturaBilgi.DataSource = db.TBLFATURABILGI.Where(x => x.ID == id).ToList();
        }


        private void pictureEditExcel_EditValueChanged(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            GridCntrlFaturaKalemleri.ExportToXls(path);
        }

        private void pictureEditPdf_EditValueChanged(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            GridCntrlFaturaKalemleri.ExportToPdf(path);
        }

        private void pictureEditClose_EditValueChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEditExcel_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.xls";
            GridCntrlFaturaKalemleri.ExportToXls(path);
        }

        private void pictureEditPdf_Click(object sender, EventArgs e)
        {
            string path = "Dosya1.Pdf";
            GridCntrlFaturaKalemleri.ExportToPdf(path);
        }

        private void pictureEditClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
