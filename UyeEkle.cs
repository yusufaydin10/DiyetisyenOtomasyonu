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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }
        public static SqlConnection connection = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = diyetUygulaması; Integrated Security=true");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (AdSoyadTb.Text==""||TelefonTb.Text==""||OdemeTb.Text==""||YasTb.Text=="" || CinsiyetTb.Text == "" || RandevuSaatiTb.Text == "" || TcKimlikNoTb.Text == "" || Gun.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else
            {
                try
                {
                    connection.Open();
                    string query = "insert into Hasta values('" + AdSoyadTb.Text + "','" + TelefonTb.Text + "','" + CinsiyetTb.SelectedItem.ToString() + "','" + YasTb.Text + "','" + OdemeTb.Text + "','" + RandevuSaatiTb.SelectedItem.ToString() + "','" + TcKimlikNoTb.Text + "','" + Gun.Text + "')";
                    SqlCommand komut = new SqlCommand(query,connection);
                    komut.ExecuteNonQuery();
                    MessageBox.Show("Hasta Başarıyla Eklendi");
                    connection.Close();

                }
                catch(Exception Ex)
                {
                    MessageBox.Show("Ex.Message");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdSoyadTb.Text = "";
            TelefonTb.Text = "";
            OdemeTb.Text = "";
            YasTb.Text = "";
            CinsiyetTb.Text = "";
            RandevuSaatiTb.Text = "";
            TcKimlikNoTb.Text = "";
            Gun.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
