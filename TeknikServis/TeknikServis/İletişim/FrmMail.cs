using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;

namespace TeknikServis.İletişim
{
    public partial class FrmMail : System.Windows.Forms.Form
    {
        public FrmMail()
        {
            InitializeComponent();
        }

        private void FrmMail_Load(object sender, EventArgs e)
        {

        }

        private void BtnGonder_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage();
            string frommail = "ilkergndz3500@gmail.com";
            string password = "1207,Lkrgndzz10097362122110guenduez23";
            string tomail = TxtAlici.Text;
            string subject = TxtKonu.Text;
            string content = TxtIcerik.Text;
            mail.From = new MailAddress(frommail);
            mail.To.Add(tomail);
            mail.Subject = subject;
            mail.Body = content;
            mail.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(frommail, password);
            smtp.EnableSsl = true;
            smtp.Send(mail);
            MessageBox.Show("Mail Gönderildi");
        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
