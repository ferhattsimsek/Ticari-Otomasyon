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
    public partial class frmfirmalar : Form
    {
        public frmfirmalar()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        void firmalar()
        {
            DataTable dt = new DataTable(); 
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_firmalar",bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource=dt;
        }
        void kodlar()
        {
            SqlCommand komut2=new SqlCommand("select firmakod1 from tbl_kodlar",bgl.baglanti());
            SqlDataReader dr=komut2.ExecuteReader();
            while (dr.Read())
            {
                rchkod1.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();
        }
        void temizle()
        {
            txtid.Text = "";
            txtad.Text = "";
            txtgorev.Text = "";
            txtyetkili.Text = "";
            msktc.Text = "";
            msktel1.Text = "";
            msktel2.Text = "";
            msktel3.Text = "";
            txtsektor.Text = "";
            txtmail.Text = "";
            mskfax.Text = "";
            cmbil.Text = "";
            cmbilce.Text = "";
            txtvergidaire.Text = "";
            rchadres.Text = "";
            txtkod1.Text = "";
            txtkod2.Text = "";
            txtkod3.Text = "";
        }
        void iller()
        {

            SqlCommand komut = new SqlCommand("select sehir from tbl_iller", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbil.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }
        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmfirmalar_Load(object sender, EventArgs e)
        {
            
            firmalar();
            temizle();
            iller();
            kodlar();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            if (dr != null)
            {

                txtid.Text = dr["id"].ToString();
                txtad.Text = dr["ad"].ToString();
                txtgorev.Text = dr["yetkilistatu"].ToString();
                txtyetkili.Text = dr["yetkiliadsoyad"].ToString();
                msktc.Text = dr["yetkilitc"].ToString();
                msktel1.Text = dr["telefon1"].ToString();
                msktel2.Text = dr["telefon2"].ToString();
                msktel3.Text = dr["telefon3"].ToString();
                txtsektor.Text = dr["sektor"].ToString();
                txtmail.Text = dr["mail"].ToString();
                mskfax.Text = dr["fax"].ToString();
                cmbil.Text = dr["il"].ToString();
                cmbilce.Text = dr["ilce"].ToString();
                txtvergidaire.Text = dr["vergidaire"].ToString();
                rchadres.Text = dr["adres"].ToString();
                txtkod1.Text = dr["ozelkod1"].ToString();
                txtkod2.Text = dr["ozelkod2"].ToString();
                txtkod3.Text = dr["ozelkod3"].ToString();
            }



        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_firmalar (ad,yetkilistatu,yetkiliadsoyad,yetkilitc,telefon1,telefon2,telefon3,sektor,mail,fax,il,ilce,vergidaire,adres,ozelkod1,ozelkod2,ozelkod3) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11,@p12,@p13,@p14,@p15,@p16,@p17)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtgorev.Text);
            komut.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut.Parameters.AddWithValue("@p4", msktc.Text);
            komut.Parameters.AddWithValue("@p5", msktel1.Text);
            komut.Parameters.AddWithValue("@p6", msktel2.Text);
            komut.Parameters.AddWithValue("@p7", msktel3.Text);
            komut.Parameters.AddWithValue("@p8", txtsektor.Text);
            komut.Parameters.AddWithValue("@p9", txtmail.Text);
            komut.Parameters.AddWithValue("@p10", mskfax.Text);
            komut.Parameters.AddWithValue("@p11", cmbil.Text);
            komut.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut.Parameters.AddWithValue("@p13", txtvergidaire.Text);
            komut.Parameters.AddWithValue("@p14", rchadres.Text);
            komut.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            firmalar();
            MessageBox.Show("Firma eklenmiştir", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbilce.Properties.Items.Clear();
            SqlCommand cmd = new SqlCommand("select  ilce from tbl_ilceler where sehir=@p1", bgl.baglanti());
            cmd.Parameters.AddWithValue("@p1", cmbil.SelectedIndex+1);
            SqlDataReader dr=cmd.ExecuteReader();
            while (dr.Read())
            {
                cmbilce.Properties.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_firmalar where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma silinmiştir", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            firmalar();
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut3 = new SqlCommand("update tbl_firmalar set ad=@p1,yetkilistatu=@p2,yetkiliadsoyad=@p3,yetkilitc=@p4,telefon1=@p5,telefon2=@p6,telefon3=@p7,sektor=@p8,mail=@p9,fax=@p10,il=@p11,ilce=@p12,vergidaire=@p13,adres=@p14,ozelkod1=@p15,ozelkod2=@p16,ozelkod3=@p17 where id=@p18", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", txtad.Text);
            komut3.Parameters.AddWithValue("@p2", txtgorev.Text);
            komut3.Parameters.AddWithValue("@p3", txtyetkili.Text);
            komut3.Parameters.AddWithValue("@p4", msktc.Text);
            komut3.Parameters.AddWithValue("@p5", msktel1.Text);
            komut3.Parameters.AddWithValue("@p6", msktel2.Text);
            komut3.Parameters.AddWithValue("@p7", msktel3.Text);
            komut3.Parameters.AddWithValue("@p8", txtsektor.Text);
            komut3.Parameters.AddWithValue("@p9", txtmail.Text);
            komut3.Parameters.AddWithValue("@p10", mskfax.Text);
            komut3.Parameters.AddWithValue("@p11", cmbil.Text);
            komut3.Parameters.AddWithValue("@p12", cmbilce.Text);
            komut3.Parameters.AddWithValue("@p13", txtvergidaire.Text);
            komut3.Parameters.AddWithValue("@p14", rchadres.Text);
            komut3.Parameters.AddWithValue("@p15", txtkod1.Text);
            komut3.Parameters.AddWithValue("@p16", txtkod2.Text);
            komut3.Parameters.AddWithValue("@p17", txtkod3.Text);
            komut3.Parameters.AddWithValue("@p18",txtid.Text);
            komut3.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Firma güncellenmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            firmalar();
            temizle();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
