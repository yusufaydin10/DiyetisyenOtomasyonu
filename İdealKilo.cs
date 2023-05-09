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
    public partial class İdealKilo : Form
    {
        public İdealKilo()
        {
            InitializeComponent();
        }

        private void İdealKilo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kilo, boy, sonuc;
            kilo = Convert.ToInt32(textBox2.Text);
            boy = Convert.ToInt32(textBox1.Text);
            sonuc = 0;
            sonuc = boy - (((150 - boy) / 4) + 110);
            if (kilo > sonuc)
            {
                label1.Text = "Fazla Kilolusunuz. İdeal Kilonuzdan " + Math.Abs(Convert.ToInt32(sonuc - kilo)) + " kg fazlanız var";
            }
            else if (kilo < sonuc)
            {
                label1.Text = "Zayıfsınız. İdeal Kilonuzdan " + Convert.ToInt32(sonuc - kilo) + "kg eksiğiniz var";
            }
            else
            {
                label1.Text = "Tebrikler İdeal Kilodasınız...";
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
    }
}
