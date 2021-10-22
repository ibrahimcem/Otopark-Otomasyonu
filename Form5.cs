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
    public partial class Form5 : Form
    {
        SqlConnection baglanti;
        public Form5()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String plaka = aracPlakaBorc.Text.Trim();
            baglanti.Open();
            string secmeSorgusu = "SELECT * from araclar where aracPlaka=@aracPlaka";
            SqlCommand sec = new SqlCommand(secmeSorgusu, baglanti);
            sec.Parameters.AddWithValue("@aracPlaka", plaka);
            SqlDataAdapter da = new SqlDataAdapter(sec);
            SqlDataReader dr = sec.ExecuteReader();
            if (dr.Read())
            {
                string girisTarihi = dr["girisTarihi"].ToString();
                string odenenUcret = dr["odenenUcret"].ToString();
                DateTime bugun = DateTime.Today;
                string cikisTarihi = bugun.ToString("d");
                TimeSpan Sonuc = Convert.ToDateTime(cikisTarihi) - Convert.ToDateTime(girisTarihi);
                string gun=Sonuc.TotalDays.ToString();
                int ucret = Int32.Parse(gun) * 10;
                ucret = ucret - Int32.Parse(odenenUcret);
                dr.Close();
                label2.Text = ucret + " TL";
                baglanti.Close();
                
            }
            else
                MessageBox.Show("Araç Bulunamadı.");
            baglanti.Close();
        }

    }
}
