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
    public partial class Form2 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        public Form2()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "insert into araclar(adSoyad,aracPlaka,aracCinsi,cepTelefonu,girisTarihi,odenenUcret) values (@adSoyad,@aracPlaka,@aracCinsi,@cepTelefonu,@girisTarihi,@odenenUcret)";
            komut = new SqlCommand(kayit, baglanti);
            String plaka = aracPlakaKayit.Text.Trim();
            String adSoyad = adSoyadKayit.Text.Trim();
            String aracCins = aracCinsKayit.Text.Trim();
            String cepTelefonu = cepTelefonuKayit.Text.Trim();
            DateTime girisTarihi = girisTarihiKayit.Value.Date;
            komut.Parameters.AddWithValue("@adSoyad", adSoyad);
            komut.Parameters.AddWithValue("@aracPlaka", plaka);
            komut.Parameters.AddWithValue("@aracCinsi", aracCins);
            komut.Parameters.AddWithValue("@cepTelefonu", cepTelefonu);
            komut.Parameters.AddWithValue("@girisTarihi", girisTarihi);
            komut.Parameters.AddWithValue("@odenenUcret", 0);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Araç Kayıt İşlemi Gerçekleşti.");
            aracPlakaKayit.Text = "";
            adSoyadKayit.Text = "";
            aracCinsKayit.Text = "";
            cepTelefonuKayit.Text = "";
            this.Hide();
        }
    }
}
