using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYS_Proje
{
    public partial class Frm_Urun : Form
    {
        public Frm_Urun()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost ; port = 5432 ; database = VTYS_Proje ; user Id = postgres ; password = 1234");
        private void Frm_Urun_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlDataAdapter dau = new NpgsqlDataAdapter("Select * From kategoriler",baglanti);
            DataTable dt = new DataTable();
            dau.Fill(dt);
            comboBox1.DisplayMember = "kategori_ad";
            comboBox1.ValueMember = "kategori_id";
            comboBox1.DataSource = dt;
            baglanti.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            string srg = "Select * From urunler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(srg, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string srg3 = "insert into urunler (urun_id,urun_ad,urun_stok,satis_fiyati,alis_fiyati,gorsel,kategoriler_id) " +
                "values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)";
            NpgsqlCommand komutekle = new NpgsqlCommand(srg3, baglanti);
            komutekle.Parameters.AddWithValue("@p1", int.Parse(Txt_UrunID.Text));
            komutekle.Parameters.AddWithValue("@p2", Txt_UrunAd.Text);
            komutekle.Parameters.AddWithValue("@p3", int.Parse(numericUpDown1.Text));
            komutekle.Parameters.AddWithValue("@p4", double.Parse(Txt_Satis.Text));
            komutekle.Parameters.AddWithValue("@p5", double.Parse(Txt_Alis.Text));
            komutekle.Parameters.AddWithValue("@p6", Txt_Gorsel.Text );
            komutekle.Parameters.AddWithValue("@p7", int.Parse(comboBox1.SelectedValue.ToString() ));
           
            komutekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün Eklendi !!!","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();
            
            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komutsil = new NpgsqlCommand("Delete From urunler where urun_ad = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", Txt_UrunAd.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Txt_UrunAd.Text + " Adlı Ürün Silindi !!");
            }
            
        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "update urunler set urun_ad=@p1 , urun_stok=@p2 , alis_fiyati=@p3 , satis_fiyati=@p4 , kategoriler_id = @p6 where urun_id=@p5";
            NpgsqlCommand komutguncelle = new NpgsqlCommand(sorgu, baglanti);
               
            komutguncelle.Parameters.AddWithValue("@p1", Txt_UrunAd.Text);
            komutguncelle.Parameters.AddWithValue("@p2", int.Parse(numericUpDown1.Value.ToString()));
            komutguncelle.Parameters.AddWithValue("@p3", double.Parse(Txt_Alis.Text));
            komutguncelle.Parameters.AddWithValue("@p4", double.Parse(Txt_Satis.Text));
            komutguncelle.Parameters.AddWithValue("@p5", int.Parse(Txt_UrunID.Text));
            komutguncelle.Parameters.AddWithValue("@p6", int.Parse(comboBox1.SelectedValue.ToString()));
            komutguncelle.ExecuteNonQuery();
            
            MessageBox.Show("İstenilen Ürün GÜncellendi !!!");
            baglanti.Close();
        }

        private void Btn_ayrinti_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "Select * From urunlerlistesi";
            NpgsqlCommand komut_ayrinti = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut_ayrinti);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void Btn_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from urunler where urun_ad = '"+Txt_UrunAd.Text+"'";
            NpgsqlCommand komut_ara = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(komut_ara);
            DataSet dt = new DataSet();
            da.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select max(urunler.satis_fiyati) from urunler";
            NpgsqlCommand komut_yuksek = new NpgsqlCommand(sorgu, baglanti);
            NpgsqlDataReader oku = komut_yuksek.ExecuteReader();
            while (oku.Read())
            {
                Txt_Fiyat.Text = oku[0].ToString();
            }
            baglanti.Close();
        }

        private void Btn_adet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string srg = "Select * from urunsayisi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(srg, baglanti);
            DataSet dsa = new DataSet();
            da.Fill(dsa);
            dataGridView1.DataSource = dsa.Tables[0];
            baglanti.Close();
        }
    }
}
