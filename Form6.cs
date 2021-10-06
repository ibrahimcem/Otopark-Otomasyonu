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
    public partial class Form6 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        public Form6()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            String plaka = aracPlakaOdeme.Text.Trim();
            String ucret = ucretOdeme.Text.Trim();
            string sorgula = "SELECT * from araclar where aracPlaka=@plaka";
            SqlCommand ara = new SqlCommand(sorgula, baglanti);
            ara.Parameters.AddWithValue("@plaka", plaka);
            SqlDataAdapter da = new SqlDataAdapter(ara);
            SqlDataReader dr = ara.ExecuteReader();
            if (dr.Read())
            {
                dr.Close();
                string odeme = "update araclar set odenenUcret=@odenenUcret where aracPlaka=@plaka";
                komut = new SqlCommand(odeme, baglanti);
                komut.Parameters.AddWithValue("@odenenUcret", ucret);
                komut.Parameters.AddWithValue("@plaka", plaka);
                komut.ExecuteNonQuery();
                MessageBox.Show("Ödeme Gerçekleşti.");
                this.Hide();
            }
            else
                MessageBox.Show("Araç Bulunamadı.");
            baglanti.Close();

        }
    }
}
