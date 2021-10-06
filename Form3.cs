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
    public partial class Form3 : Form
    {
        SqlConnection baglanti;
        public Form3()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String plaka = aracPlakaSil.Text.Trim();
            baglanti.Open();
            string secmeSorgusu = "SELECT * from araclar where aracPlaka=@aracPlaka";
            SqlCommand sec = new SqlCommand(secmeSorgusu, baglanti);
            sec.Parameters.AddWithValue("@aracPlaka", plaka);
            SqlDataAdapter da = new SqlDataAdapter(sec);
            SqlDataReader dr = sec.ExecuteReader();
            if (dr.Read()) 
            {
                string isim = dr["adSoyad"].ToString();
                string girisTarihi = dr["girisTarihi"].ToString();
                DateTime bugun = DateTime.Today;
                string cikisTarihi = bugun.ToString("d");
                TimeSpan Sonuc = Convert.ToDateTime(cikisTarihi) - Convert.ToDateTime(girisTarihi);
                string gun=Sonuc.TotalDays.ToString();
                int ucret = Int32.Parse(gun) * 10;
                dr.Close();
                DialogResult durum = MessageBox.Show(isim + " kaydının "+ucret+" Tl"+" borcu var,"+" silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                if (DialogResult.Yes == durum) 
                {
                    string sil = "DELETE from araclar where aracPlaka=@aracPlaka";
                    SqlCommand silKomutu = new SqlCommand(sil, baglanti);
                    silKomutu.Parameters.AddWithValue("@aracPlaka", plaka);
                    silKomutu.ExecuteNonQuery();
                    MessageBox.Show("Araç Kaydı Silindi.");
                }
            }
            else
                MessageBox.Show("Araç Bulunamadı.");
            baglanti.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
