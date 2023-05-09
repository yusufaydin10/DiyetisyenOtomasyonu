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

namespace diyet_Uygulaması
{
    public partial class GüncelleSil : Form
    {
        public GüncelleSil()
        {
            InitializeComponent();
        }
        SqlDataAdapter da;
        SqlConnection baglanti;
        SqlCommand komut;
        DataSet ds;
        void griddoldur()
        {
            baglanti = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = diyetUygulaması; Integrated Security=true");
            da = new SqlDataAdapter("Select *From Hasta", baglanti);
            ds = new DataSet();
            baglanti.Open();
            da.Fill(ds, "Hasta");
            dataGridView1.DataSource = ds.Tables["Hasta"];
            baglanti.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void GüncelleSil_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void SIFIRLA_Click(object sender, EventArgs e)
        {
             AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            OdemeTb.Text = "";
            YasTb.Text = "";
            CinsiyetTb.Text = "";
            RandevuSaatiTb.Text = "";
            TcKimlikNoTb.Text = "";
        }

        private void SİL_Click(object sender, EventArgs e)
        {
            string sorgu = "delete from Hasta where TcKimlikNo =@tc";
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            komut.Parameters.AddWithValue("@tc", TcKimlikNoTb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Hasta Başarıyla Silindi");

        }

        private void GuncelleTb_Click(object sender, EventArgs e)
        {
            string sorgu = "Update Hasta set AdSoyad=@ad,Telefon =@tel,Cinsiyet=@cinsiyet,Yas=@yas,Odeme=@odeme,RandevuSaati=@saat where TcKimlikNo=@tc";
           SqlCommand komut = new SqlCommand(sorgu,baglanti);
            komut.Parameters.AddWithValue("@ad", AdSoyadTb.Text);
            komut.Parameters.AddWithValue("@tel", TelefonTb.Text);
            komut.Parameters.AddWithValue("@cinsiyet", CinsiyetTb.Text);
            komut.Parameters.AddWithValue("@yas", YasTb.Text);
            komut.Parameters.AddWithValue("@odeme", OdemeTb.Text);
            komut.Parameters.AddWithValue("@saat", RandevuSaatiTb.Text);
            komut.Parameters.AddWithValue("@tc", TcKimlikNoTb.Text);
            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();
            griddoldur();
            MessageBox.Show("Hasta Başarıyla Güncellendi");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            AdSoyadTb.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            TelefonTb.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            CinsiyetTb.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            YasTb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            OdemeTb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            RandevuSaatiTb.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            TcKimlikNoTb.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }
    }
}
