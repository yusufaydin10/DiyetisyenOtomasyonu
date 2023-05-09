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
    public partial class BazalMetabolizma : Form
    {
        public BazalMetabolizma()
        {
            InitializeComponent();
        }

        private void BazalMetabolizma_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || CinsiyetTb.Text == "" || CinsiyetTb.Text == "")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else {
                int kilo, boy, yas;
                double sonuc;
                string cinsiyet;

                kilo = Convert.ToInt32(textBox2.Text);
                boy = Convert.ToInt32(textBox1.Text);
                yas = Convert.ToInt32(textBox3.Text);
                sonuc = 0;
                if (CinsiyetTb.Text == "Kadın")
                {
                    sonuc = (655.1 + (9.56 * kilo) + (1.85 * boy) - (4.68 * yas));

                    label1.Text = "Bazal Metabolizma Hızınız : " + sonuc + "Kcal/Gün";


                }
                else
                {
                    sonuc = (66.5 + (13.75 * kilo) + (5.03 * boy) - (6.75 * yas));
                    label1.Text = "Bazal Metabolizma Hızınız : " + sonuc + "Kcal/Gün";

                }
            }
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            CinsiyetTb.Text = "";
        }
    }
}

