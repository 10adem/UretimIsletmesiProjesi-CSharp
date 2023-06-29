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
    public partial class formen_paneli : Form
    {
        public formen_paneli()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        public string formen_tc;

        private void formen_paneli_Load(object sender, EventArgs e)
        {
            veriyukle();
            lblFormenTC.Text = formen_tc;

            SqlCommand command = new SqlCommand("select formen_ad, formen_soyad from formenler_tbl where formen_tc = @formen_tc", baglan.Baglanti());
            command.Parameters.AddWithValue("@formen_tc", lblFormenTC.Text);
            SqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglan.Baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from formenler_tbl where formen_tc =" + formen_tc, baglan.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGorusmeAl_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into formengorusmeleri_tbl (ad, soyad, gorusulecek_mudur, gorusme_tarihi) values (@ad, @soyad, @gorusulecek_mudur, @gorusme_tarihi)", baglan.Baglanti());
            command.Parameters.AddWithValue("@ad", txtAd.Text);
            command.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            command.Parameters.AddWithValue("@gorusulecek_mudur", txtGorusulecekMudur.Text);
            command.Parameters.AddWithValue("@gorusme_tarihi", txtGorusmeTarihi.Text);
            command.ExecuteNonQuery();
            MessageBox.Show("Görüşme talebiniz başarıyla alındı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Temizle();
            veriyukle();
        }

        public void Temizle()
        {
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtGorusulecekMudur.Text = "";
            txtGorusmeTarihi.Text = "";
        }

        public void veriyukle()
        {
            this.formengorusmeleri_tblTableAdapter.Fill(this.uretimIsletmesiDataSet.formengorusmeleri_tbl);
        }

        private void formen_paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            formen_girisi frm = new formen_girisi();
            frm.Show();
        }
    }
}
