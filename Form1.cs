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
    public partial class Form1 : Form
    {
        SqlCommand komut;
        SqlConnection baglanti;
        public Form1()
        {
            InitializeComponent();
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=otopark;Integrated Security=True");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            string kayit = "select adSoyad,aracPlaka,aracCinsi,cepTelefonu,girisTarihi from araclar";
            komut = new SqlCommand(kayit, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
           
            dataGridView1.DataSource = dt;
            baglanti.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form = new Form2();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new Form3();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form form = new Form7();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form form = new Form5();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new Form6();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            baglanti.Open();
            string kayit = "select adSoyad,aracPlaka,aracCinsi,cepTelefonu,girisTarihi from araclar";
            //musteriler tablosundaki tüm kayıtları çekecek olan sql sorgusu.
            komut = new SqlCommand(kayit, baglanti);
            //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
            SqlDataAdapter da = new SqlDataAdapter(komut);
            //SqlDataAdapter sınıfı verilerin databaseden aktarılması işlemini gerçekleştirir.
            DataTable dt = new DataTable();
            da.Fill(dt);
            //Bir DataTable oluşturarak DataAdapter ile getirilen verileri tablo içerisine dolduruyoruz.
            dataGridView1.DataSource = dt;
            //Formumuzdaki DataGridViewin veri kaynağını oluşturduğumuz tablo olarak gösteriyoruz.
            baglanti.Close();
        }
    }
}
