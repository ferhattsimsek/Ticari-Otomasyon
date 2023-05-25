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

namespace TicariOtomasyon
{
    public partial class frmmail : Form
    {
        public frmmail()
        {
            InitializeComponent();
        }
        public string email;
        private void frmmail_Load(object sender, EventArgs e)
        {
            txtemail.Text= email;   
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            MailMessage mesajım=new MailMessage();  
            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new System.Net.NetworkCredential("ferhat_66_yozgat@hotmail.com","ferhat197");
            smtp.Port = 587;
            smtp.Host = "smtp.live.com";
            smtp.EnableSsl = true;
            mesajım.To.Add(txtemail.Text);
            mesajım.From=new MailAddress("ferhat_66_yozgat@hotmail.com");
            mesajım.Subject=(txtkonu.Text);
            mesajım.Body=rchmesaj.Text;
            smtp.Send(mesajım);

        }
    }
}
