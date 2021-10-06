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
    public partial class Form7 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        public Form7()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String plaka = aracPlakaSecGuncelle.Text.Trim();
            baglanti.Open();
            string sorgula = "SELECT * from araclar where aracPlaka=@plaka";
            komut = new SqlCommand(sorgula, baglanti);
            komut.Parameters.AddWithValue("@plaka", plaka);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                string id = dr["id"].ToString();
                string aracPlaka = dr["aracPlaka"].ToString();
                string aracCinsi = dr["aracCinsi"].ToString();
                string adSoyad = dr["adSoyad"].ToString();
                string cepTelefonu = dr["cepTelefonu"].ToString();

                dr.Close();
                Form4 form = new Form4();
                form.aracPlakası = aracPlaka;
                form.ad = adSoyad;
                form.telefonu = cepTelefonu;
                form.cinsi = aracCinsi;
                form.id = id;
                form.Show();
                this.Hide();
                
            }
            else
                MessageBox.Show("Araç Bulunamadı.");
            baglanti.Close();

        }

        private void aracPlakaSecGuncelle_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
