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
    public partial class FrmAnaPage : Form
    {
        public FrmAnaPage()
        {
            InitializeComponent();
        }



        Formlar.FrmAnaSayfa frana;
        private void FrmAnaPage_Load(object sender, EventArgs e)
        {
            frana = new Formlar.FrmAnaSayfa();
            frana.MdiParent = this;
            frana.Show();

        }

        Formlar.FrmKategorı frkat;
        private void BtnKategoriList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frkat == null || frkat.IsDisposed)
            {
                frkat = new Formlar.FrmKategorı();
                frkat.MdiParent = this;
                frkat.Show();
            }
        }

        Formlar.FrmYeniKategori fryenikat;
        private void BtnYeniKategori_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fryenikat == null || fryenikat.IsDisposed)
            {
                fryenikat = new Formlar.FrmYeniKategori();
                fryenikat.Show();
            }
        }

        Formlar.FrmUrunListesi frurun;
        private void BtnÜrünListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frurun == null || frurun.IsDisposed)
            {
                frurun = new Formlar.FrmUrunListesi();
                frurun.MdiParent = this;
                frurun.Show();
            }
        }

        Formlar.FrmYenıUrun fryenıurun;
        private void BtnYeniÜrün_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fryenıurun == null || fryenıurun.IsDisposed)
            {
                fryenıurun = new Formlar.FrmYenıUrun();
                fryenıurun.Show();
            }
        }

        Formlar.Frmİstatistik frist;
        private void BtnUrunİstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frist == null || frist.IsDisposed)
            {
                frist = new Formlar.Frmİstatistik();
                frist.MdiParent = this;
                frist.Show();
            }
        }

        Formlar.FrmMarkalar frmarka;
        private void BtnMarkaİstatistikleri_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmarka == null || frmarka.IsDisposed)
            {
                frmarka = new Formlar.FrmMarkalar();
                frmarka.MdiParent = this;
                frmarka.Show();
            }
        }

        Formlar.FrmArizaListesi frariza;
        private void BtnArizaliUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frariza == null || frariza.IsDisposed)
            {
                frariza = new Formlar.FrmArizaListesi();
                frariza.MdiParent = this;
                frariza.Show();
            }
        }

        Formlar.FrmArizaliUrunKaydi frarizaliurunkaydi;
        private void BtnArizaliÜrünKaydi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frarizaliurunkaydi == null || frarizaliurunkaydi.IsDisposed)
            {
                frarizaliurunkaydi = new Formlar.FrmArizaliUrunKaydi();
                frarizaliurunkaydi.Show();
            }
        }

        Formlar.FrmArizaDetaylar frarizadetaylar;
        private void BtnArizaliUrunAciklama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frarizadetaylar == null || frarizadetaylar.IsDisposed)
            {
                frarizadetaylar = new Formlar.FrmArizaDetaylar();
                frarizadetaylar.Show();
            }
        }

        Formlar.FrmQRCode frqrcode;
        private void BtnQRCode_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frqrcode == null || frqrcode.IsDisposed)
            {
                frqrcode = new Formlar.FrmQRCode();
                frqrcode.Show();
            }
        }

        Formlar.FrmCariEkle frcariekle;
        private void BtnCariEkle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frcariekle == null || frcariekle.IsDisposed)
            {
                frcariekle = new Formlar.FrmCariEkle();
                frcariekle.Show();
            }
        }

        Formlar.FrmCariListesi frcarilist;
        private void BtnCariListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frcarilist == null || frcarilist.IsDisposed)
            {
                frcarilist = new Formlar.FrmCariListesi();
                frcarilist.MdiParent = this;
                frcarilist.Show();
            }
        }

        Formlar.FrmCariİller frcariil;
        private void BtnCariİl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frcariil == null || frcariil.IsDisposed)
            {
                frcariil = new Formlar.FrmCariİller();
                frcariil.MdiParent = this;
                frcariil.Show();
            }
        }

        Formlar.FrmUrunSatis frurunsatis;
        private void BtnYeniUrunSatis_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frurunsatis == null || frurunsatis.IsDisposed)
            {
                frurunsatis = new Formlar.FrmUrunSatis();
                frurunsatis.Show();
            }
        }

        Formlar.FrmSatislar frsatislar;
        private void BtnSatisListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frsatislar == null || frsatislar.IsDisposed)
            {
                frsatislar = new Formlar.FrmSatislar();
                frsatislar.MdiParent = this;
                frsatislar.Show();
            }
        }

        Formlar.FrmFaturaListesi frfaturalist;
        private void BtnFaturaListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frfaturalist == null || frfaturalist.IsDisposed)
            {
                frfaturalist = new Formlar.FrmFaturaListesi();
                frfaturalist.MdiParent = this;
                frfaturalist.Show();
            }
        }

        Formlar.FrmFaturaKalemGiris frkalem;
        private void BtnFaturaKalemGiris_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frkalem == null || frkalem.IsDisposed)
            {
                frkalem = new Formlar.FrmFaturaKalemGiris();
                frkalem.MdiParent = this;
                frkalem.Show();
            }

        }

        Formlar.FrmFormKalemleri frformkalemleri;
        private void BtnDetaylıFaturaSorgulama_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frformkalemleri == null || frformkalemleri.IsDisposed)
            {
                frformkalemleri = new Formlar.FrmFormKalemleri();
                frformkalemleri.MdiParent = this;
                frformkalemleri.Show();
            }
        }

        Formlar.FrmPersonel frpersonel;
        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frpersonel == null || frpersonel.IsDisposed)
            {
                frpersonel = new Formlar.FrmPersonel();
                frpersonel.MdiParent = this;
                frpersonel.Show();
            }
        }

        Formlar.FrmDepartman frdepartman;
        private void BtnDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frdepartman == null || frdepartman.IsDisposed)
            {
                frdepartman = new Formlar.FrmDepartman();
                frdepartman.MdiParent = this;
                frdepartman.Show();
            }
        }

        Formlar.FrmYeniDepartman fryenidepartman;
        private void BtnYeniDepartman_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fryenidepartman == null || fryenidepartman.IsDisposed)
            {
                fryenidepartman = new Formlar.FrmYeniDepartman();
                fryenidepartman.Show();
            }
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        Formlar.FrmNotlar frnotlar;
        private void BtnAjanda_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frnotlar == null || frnotlar.IsDisposed)
            {
                frnotlar = new Formlar.FrmNotlar();
                frnotlar.MdiParent = this;
                frnotlar.Show();
            }
        }

        Formlar.FrmKurlar frkurlar;
        private void FrmKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frkurlar == null || frkurlar.IsDisposed)
            {
                frkurlar = new Formlar.FrmKurlar();
                frkurlar.MdiParent = this;
                frkurlar.Show();
            }
        }

        Formlar.FrmYoutube fryoutube;
        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fryoutube == null || fryoutube.IsDisposed)
            {
                fryoutube = new Formlar.FrmYoutube();
                fryoutube.MdiParent = this;
                fryoutube.Show();
            }
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");
        }

        Formlar.FrmGauge frgauge;
        private void BtnGauge_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgauge == null || frgauge.IsDisposed)
            {
                frgauge = new Formlar.FrmGauge();
                frgauge.MdiParent = this;
                frgauge.Show();
            }
        }

        Formlar.FrmHarita frharita;
        private void BtnHarita_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frharita == null || frharita.IsDisposed)
            {
                frharita = new Formlar.FrmHarita();
                frharita.MdiParent = this;
                frharita.Show();
            }
        }

        Formlar.FrmRaporlar frraporlar;
        private void BtnRapor_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frraporlar == null || frraporlar.IsDisposed)
            {
                frraporlar = new Formlar.FrmRaporlar();
                //frraporlar.MdiParent = this;
                frraporlar.Show();
            }
        }

        İletişim.FrmRehber frrehber;
        private void BtnRehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frrehber == null || frrehber.IsDisposed)
            {
                frrehber = new İletişim.FrmRehber();
                frrehber.MdiParent = this;
                frrehber.Show();
            }
        }

        İletişim.FrmGelenMesajlar frgelen;
        private void BtnGelenMesajlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frgelen == null || frgelen.IsDisposed)
            {
                frgelen = new İletişim.FrmGelenMesajlar();
                frgelen.MdiParent = this;
                frgelen.Show();
            }
        }

        İletişim.FrmMail frmail;
        private void BtnMailYeni_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frmail == null || frmail.IsDisposed)
            {
                frmail = new İletişim.FrmMail();
                frmail.Show();
            }
        }

        Formlar.FrmAnaSayfa franasayfa;
        private void BtnAnaSayfa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (franasayfa==null||franasayfa.IsDisposed)
            {
                franasayfa = new Formlar.FrmAnaSayfa();
                franasayfa.MdiParent = this;
                franasayfa.Show();
            }
        }

        Formlar.FrmArizaliUrunDetay frarizaliurundetay;
        private void BtnArizaliUrunDetay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (frarizaliurundetay == null || frarizaliurundetay.IsDisposed)
            {
                frarizaliurundetay = new Formlar.FrmArizaliUrunDetay();
                frarizaliurundetay.MdiParent = this;
                frarizaliurundetay.Show();
            }
        }
    }
}
