using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otopark
{
    public partial class Form4 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        public Form4()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");

        }
        public string aracPlakası,cinsi,ad,telefonu,id;

        private void button1_Click_1(object sender, EventArgs e)
        {
            baglanti.Open();
            String plaka = aracPlakaGuncelle.Text.Trim();
            String adSoyad = adSoyadGuncelle.Text.Trim();
            String aracCinsi = aracCinsGuncelle.Text.Trim();
            String cepTelefonu = cepTelefonuGuncelle.Text.Trim();
            string odeme = "update araclar set aracPlaka=@plaka,aracCinsi=@aracCinsi,adSoyad=@adSoyad,cepTelefonu=@cepTelefonu where id=@id";
            komut = new SqlCommand(odeme, baglanti);
            komut.Parameters.AddWithValue("@id", id);
            komut.Parameters.AddWithValue("@plaka", plaka);
            komut.Parameters.AddWithValue("@aracCinsi", aracCinsi);
            komut.Parameters.AddWithValue("@adSoyad", adSoyad);
            komut.Parameters.AddWithValue("@cepTelefonu", cepTelefonu);
            komut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler Güncellendi.");
            baglanti.Close();
            cepTelefonuGuncelle.Text = "";
            aracCinsGuncelle.Text = "";
            adSoyadGuncelle.Text = "";
            aracPlakaGuncelle.Text = "";
            this.Hide();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }



        private void Form4_Load(object sender, EventArgs e)
        {
            cepTelefonuGuncelle.Text = telefonu.ToString();
            aracCinsGuncelle.Text = cinsi.ToString();
            adSoyadGuncelle.Text = ad.ToString();
            aracPlakaGuncelle.Text = aracPlakası.ToString();
        }
    }
}
