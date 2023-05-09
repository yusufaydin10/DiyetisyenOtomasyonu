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
   

    public partial class YeniKayıt : Form
    {
        SqlConnection connection = Form1.connection;
    
       
       
        public YeniKayıt()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "KULLANICI ADI")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "KULLANICI ADI";
                textBox1.ForeColor = Color.Silver;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {

            if (textBox2.Text == "ŞİFRE")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
                textBox2.PasswordChar = '*';
            }
        }
        char? none = null;
        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "ŞİFRE";
                textBox2.ForeColor = Color.Silver;
                textBox2.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "ŞİFRE TEKRARI")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.White;
                textBox3.PasswordChar = '*';
            }
        }
       
        private void textBox3_Leave(object sender, EventArgs e)
        {
            char? none = null;
            if (textBox3.Text == "")
            {
                textBox3.Text = "ŞİFRE TEKRARI";
                textBox3.ForeColor = Color.Silver;
                textBox3.PasswordChar = Convert.ToChar(none);
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "E-MAİL")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.White;
            }
        }
        
        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "E-MAİL";
                textBox4.ForeColor = Color.Silver;
            }
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            if (textBox5.Text == "TELEFON NUMARASI")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.White;
            }
        }
      
        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "TELEFON NUMARASI";
                textBox1.ForeColor = Color.Silver;
            }
        }

        bool move;
        int mouse_x;
        int mouse_y;
        private void YeniKayıt_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            mouse_x = e.X;
            mouse_y = e.Y;
        }

        private void YeniKayıt_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void YeniKayıt_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
            {
                this.SetDesktopLocation(MousePosition.X - mouse_x, MousePosition.Y - mouse_y);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Insert into Kayıt(username,password,re_pass,e_mail,phone) values ('" + cryptology.Encryption(textBox1.Text, 2) + "','" + cryptology.Encryption(textBox2.Text, 2) + "', '" + cryptology.Encryption(textBox3.Text, 2) + "', '" + cryptology.Encryption(textBox4.Text, 2) + "', '" + cryptology.Encryption(textBox5.Text, 2) + "')", connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("KAYIT BAŞARILI","Program");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
            this.Hide();
        }

        private void YeniKayıt_Load(object sender, EventArgs e)
        {

        }
    }
}
