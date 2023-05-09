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
    public partial class BesinKalori : Form
    {
        public BesinKalori()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PK0IRCB\\SQLEXPRESS01; Initial Catalog = diyetUygulaması; Integrated Security=true");


        DataTable tbl = new DataTable();
        void Filtrele()
        {
            DataView dv = new DataView();
            dv = tbl.DefaultView;
            dv.RowFilter = "Yiyecek like '" + BesinTb.Text + "%'";
            dataGridView1.DataSource = dv;
        }

        private void BesinKalori_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adtr = new SqlDataAdapter("select *from KaloriCetveli", baglanti);
            adtr.Fill(tbl);
            dataGridView1.DataSource = tbl;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
            this.Hide();
        }

        private void YenileTb_Click(object sender, EventArgs e)
        {
            BesinTb.Text = "";
        }

        private void AraTb_Click(object sender, EventArgs e)
        {
           
            Filtrele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
