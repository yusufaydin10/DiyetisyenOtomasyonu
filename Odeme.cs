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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = diyetUygulaması; Integrated Security=true");
        private void Uyeler()
        {
            baglanti.Open();
            string query = "select *from OdemeTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder();
            var ds = new DataSet();
            sda.Fill(ds);
            OdemeDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void FillName()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select TcKimlikNo from Hasta", baglanti);
            SqlDataReader rdr;
            rdr = komut.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("TcKimlikNo", typeof(string));
            dt.Load(rdr);
            AdSoyadCb.ValueMember = "TcKimlikNo";
            AdSoyadCb.DataSource = dt;
            baglanti.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdSoyadCb.Text = "";
            OdemeTb.Text = "";
            Periyot.Text = "";
           
        }

        private void Odeme_Load(object sender, EventArgs e)
        {
            Uyeler();
            FillName();
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
           
            if(AdSoyadCb.Text==""|| OdemeTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi!");
            }
            else
            {
                string odemeperiyot = Periyot.Value.Month.ToString() + Periyot.Value.Year.ToString();
                baglanti.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select count(*) from OdemeTbl where Uye ='" + AdSoyadCb.SelectedValue.ToString() + "' and Ay ='" + odemeperiyot + "' ", baglanti);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Ödeme Zaten Yapıldı");
                }
                else
                {
                    string query = "insert into OdemeTbl values ('" + odemeperiyot+"','"+AdSoyadCb.SelectedValue.ToString()+"','" + OdemeTb.Text +"')";
                    SqlCommand komut = new SqlCommand(query,baglanti);
                  
                    komut.ExecuteNonQuery();
                   
                    MessageBox.Show("Tutar Başarıyla Ödendi");

                } baglanti.Close();
                Uyeler();
                
                
               
            }
        }

        private void AdSoyadCb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
