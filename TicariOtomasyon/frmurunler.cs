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
    public partial class frmurunler : Form
    {
        public frmurunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();  
        void listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_urunler", bgl.baglanti()); ;
            da.Fill(dt);
            gridControl1.DataSource = dt;
        }
        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void frmurunler_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("insert into tbl_urunler (urunad,marka,model,yıl,adet,alisfiyat,satisfiyat,detay) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2",txtmarka.Text);
            komut.Parameters.AddWithValue("@p3",txtmodel.Text);
            komut.Parameters.AddWithValue("@p4",mskdyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nupadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6",decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", rchdetay.Text);
            komut.ExecuteNonQuery();
            listele();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün başarıyla eklendi", "bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            SqlCommand komutsil = new SqlCommand("delete from tbl_urunler where id=@p1", bgl.baglanti());
            komutsil.Parameters.AddWithValue("@p1",txtid.Text);
            komutsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Ürün silindi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            listele();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_urunler set urunad=@p1,marka=@p2,model=@p3,yıl=@p4,adet=@p5,alisfiyat=@p6,satisfiyat=@p7,detay=@p8 where id=@p9", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtad.Text);
            komut.Parameters.AddWithValue("@p2", txtmarka.Text);
            komut.Parameters.AddWithValue("@p3", txtmodel.Text);
            komut.Parameters.AddWithValue("@p4", mskdyil.Text);
            komut.Parameters.AddWithValue("@p5", int.Parse((nupadet.Value).ToString()));
            komut.Parameters.AddWithValue("@p6", decimal.Parse(txtalis.Text));
            komut.Parameters.AddWithValue("@p7", decimal.Parse(txtsatis.Text));
            komut.Parameters.AddWithValue("@p8", rchdetay.Text);
            komut.Parameters.AddWithValue("@p9", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close(); 
            MessageBox.Show("Ürün güncellendi","bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            listele();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            // verileri textboxlara çekme
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            txtid.Text = dr["id"].ToString();
            txtad.Text = dr["urunad"].ToString();
            txtmarka.Text = dr["marka"].ToString();
            txtmodel.Text=dr["model"].ToString();
            mskdyil.Text = dr["yıl"].ToString();
           nupadet.Value = decimal.Parse(dr["adet"].ToString());
            txtalis.Text = dr["alisfiyat"].ToString();
            txtsatis.Text = dr["satisfiyat"].ToString();
            rchdetay.Text = dr["detay"].ToString();

        }
    }
}
