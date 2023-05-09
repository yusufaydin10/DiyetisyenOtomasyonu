using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace diyet_Uygulaması
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UyeEkle UyeEkle = new UyeEkle();
            UyeEkle.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GüncelleSil GüncelleSil = new GüncelleSil();
            GüncelleSil.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UyeleriGoruntule UyeleriGoruntule = new UyeleriGoruntule();
            UyeleriGoruntule.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odeme Odeme = new Odeme();
            Odeme.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kitleİndeksi Kitleİndeksi = new Kitleİndeksi();
            Kitleİndeksi.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            İdealKilo İdealKilo = new İdealKilo();
            İdealKilo.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BesinKalori BesinKalori = new BesinKalori();
            BesinKalori.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BesinKalori besinKalori = new BesinKalori();
            besinKalori.Show();
            this.Hide();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            BazalMetabolizma bz = new BazalMetabolizma();
            bz.Show();
            this.Hide();
        }
    }
}
