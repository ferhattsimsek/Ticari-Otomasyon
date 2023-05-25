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
    public partial class frmgiderler : Form
    {
        public frmgiderler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        void listele()
        {
            DataTable dt=new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_giderler", bgl.baglanti());
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void rchadres_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbil_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_giderler (ay,yıl,elektrik,su,dogalgaz,internet,ekstra,notlar)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            komut.Parameters.AddWithValue("@p2", cmbyıl.Text);
            komut.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komut.Parameters.AddWithValue("@p4", txtsu.Text);
            komut.Parameters.AddWithValue("@p5", txtdogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", txtinternet.Text);
            komut.Parameters.AddWithValue("@p7", txtekstra.Text);
            komut.Parameters.AddWithValue("@p8", rchnotlar.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();





        }

        private void frmgiderler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["id"].ToString();
            txtelektrik.Text = dr["elektrik"].ToString();
            txtsu.Text = dr["su"].ToString();
            txtdogalgaz.Text = dr["dogalgaz"].ToString();
            cmbay.Text = dr["ay"].ToString();
            cmbyıl.Text = dr["yıl"].ToString();
            txtinternet.Text = dr["internet"].ToString();
            txtekstra.Text = dr["ekstra"].ToString();
            rchnotlar.Text = dr["notlar"].ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("delete from tbl_giderler where id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider silindi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_giderler set ay=@p1,yıl=@p2,elektrik=@p3,su=@p4,dogalgaz=@p5,internet=@p6,ekstra=@p7,notlar=@p8 where id=@p9",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbay.Text);
            komut.Parameters.AddWithValue("@p2", cmbyıl.Text);
            komut.Parameters.AddWithValue("@p3", txtelektrik.Text);
            komut.Parameters.AddWithValue("@p4", txtsu.Text);
            komut.Parameters.AddWithValue("@p5", txtdogalgaz.Text);
            komut.Parameters.AddWithValue("@p6", txtinternet.Text);
            komut.Parameters.AddWithValue("@p7", txtekstra.Text);
            komut.Parameters.AddWithValue("@p8", rchnotlar.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Gider güncellenmiştir","bilgi",MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }
    }
}
