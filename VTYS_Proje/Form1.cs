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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server = localhost ; port = 5432 ; database = VTYS_Proje ; user Id = postgres ; password = 1234");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string srg = "Select * From kategoriler";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(srg, baglanti);
            DataSet dsa = new DataSet();
            da.Fill(dsa);
            dataGridView1.DataSource = dsa.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string srg2 = "insert into kategoriler (kategori_id , kategori_ad) values(@p1,@p2)";
            NpgsqlCommand komutekle = new NpgsqlCommand(srg2,baglanti);
            komutekle.Parameters.AddWithValue("@p1", int.Parse(Txt_KatID.Text));
            komutekle.Parameters.AddWithValue("@p2", Txt_KatAd.Text);
            komutekle.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kategori Eklendi !!!");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            string srg = "Select * From kategorisayisi";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(srg, baglanti);
            DataSet dsa = new DataSet();
            da.Fill(dsa);
            dataGridView1.DataSource = dsa.Tables[0];
            baglanti.Close();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            DialogResult dr = new DialogResult();

            dr = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                baglanti.Open();
                NpgsqlCommand komutsil = new NpgsqlCommand("Delete From kategoriler where kategori_ad = @p1", baglanti);
                komutsil.Parameters.AddWithValue("@p1", Txt_KatAd.Text);
                komutsil.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show(Txt_KatAd.Text + " Adlı Ürün Silindi !!");
            }
        }
    }
}
