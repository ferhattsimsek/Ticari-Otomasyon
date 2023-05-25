using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicariOtomasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        frmurunler fr;
        private void btnurunler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (fr == null) { 
            fr = new frmurunler();
            fr.MdiParent = this;
            fr.Show();
        }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        frmmusteriler musteri;
        private void btnmusteriler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (musteri == null)
            {
                musteri = new frmmusteriler();
                musteri.MdiParent = this;
                musteri.Show();
            }
        }
        frmfirmalar firmalar;
        private void btnfirmalar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(firmalar == null)
            {
                firmalar= new frmfirmalar();
                firmalar.MdiParent = this;
                firmalar.Show();    
            }   
        }
        frmpersoneller personeller;
        private void btnpersoneller_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (personeller == null)
            {
                personeller = new frmpersoneller();
                personeller.MdiParent = this;
                personeller.Show();
            }

        }
        frmrehber rehber;
        private void btnrehber_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(rehber == null)
            {
                rehber=new frmrehber();
                rehber.MdiParent = this;
                rehber.Show();
            }

        }
        frmgiderler frmgiderler;
        private void btngiderler_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmgiderler=new frmgiderler();
            frmgiderler.MdiParent = this;
            frmgiderler.Show();

        }
    }
}
