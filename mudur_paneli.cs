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

namespace UretimIsletmesi
{
    public partial class mudur_paneli : Form
    {
        public mudur_paneli()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        public string mudur_tc;

        private void mudur_paneli_Load(object sender, EventArgs e)
        {
            lblMudurTC.Text = mudur_tc;

            SqlCommand komut = new SqlCommand("select mudur_ad, mudur_soyad from mudur_tbl where mudur_tc = @mudur_tc",baglan.Baglanti());
            komut.Parameters.AddWithValue("@mudur_tc", lblMudurTC.Text);
            SqlDataReader rd = komut.ExecuteReader();
            while (rd.Read())
            {
                lblAdSoyad.Text = rd[0] + " " + rd[1];
            }
            baglan.Baglanti().Close();

            DataTable td = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from mudur_tbl where mudur_tc=" + mudur_tc, baglan.Baglanti());
            da.Fill(td);
            dataGridView1.DataSource = td;
        }

        private void mudur_paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            mudur_girisi frm = new mudur_girisi();
            frm.Show();
        }

        private void btnisci_islemleri_Click(object sender, EventArgs e)
        {
            isci_islemleri page = new isci_islemleri();
            page.Show();
            this.Hide();
        }

        private void btnformen_islemleri_Click(object sender, EventArgs e)
        {
            formen_islemleri page = new formen_islemleri();
            page.Show();
            this.Hide();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            anasayfa cikis = new anasayfa();
            cikis.Show();
            this.Hide();
        }
    }
}
