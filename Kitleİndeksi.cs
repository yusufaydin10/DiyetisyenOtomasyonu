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
    public partial class Kitleİndeksi : Form
    {
        public Kitleİndeksi()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double boy, kilo, vki;
            boy = Convert.ToDouble(textBox1.Text);
            kilo = Convert.ToDouble(textBox2.Text);
            vki = kilo / (boy * boy);
            label1.Text = vki.ToString();
            if (vki < 18)
            {
                label2.Text = "Zayıf";
            }
            else if (vki >= 18 && vki < 25)
            {
                label2.Text = "Normal";
            }
            else if (vki >= 25 && vki < 30)
            {
                label2.Text = "Kilolu";
            }
            else if (vki >= 30 && vki < 35)
            {
                label2.Text = "Obez";
            }
            else
            {
                label2.Text = "Ciddi Obez";
            }
        }

        private void Kitleİndeksi_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }
    }
    }

