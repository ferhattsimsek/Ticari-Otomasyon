using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicariOtomasyon
{
    public partial class frmrehber : Form
    {
        public frmrehber()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frmrehber_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select ad,soyad,telefon,telefon2,mail from tbl_musteriler", bgl.baglanti());
            da.Fill(dt);
            gridControl2.DataSource = dt;
            ////
            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select ad,yetkiliadsoyad,telefon1,telefon2,telefon3,mail,fax from tbl_firmalar", bgl.baglanti());
            da2.Fill(dt2);
            gridControl1.DataSource = dt2;
        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            frmmail mail=new frmmail();
            DataRow dr = gridView2.GetDataRow(gridView2.FocusedRowHandle);
            if (dr != null)
            {
                mail.email=dr["mail"].ToString();
                

            }
            mail.Show();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            frmmail mail = new frmmail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {
                mail.email = dr["mail"].ToString();


            }
            mail.Show();
        }
    }
}
