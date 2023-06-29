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
    public partial class isci_paneli : Form
    {
        public isci_paneli()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();
        public string isci_tc;

        private void isci_paneli_Load(object sender, EventArgs e)
        {

            veriyukle();
            lbl_isciTC.Text = isci_tc;

            SqlCommand cmd = new SqlCommand("select isci_ad, isci_soyad from isciler_tbl where isci_tc = @isci_tc", baglan.Baglanti());
            cmd.Parameters.AddWithValue("@isci_tc", lbl_isciTC.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            baglan.Baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from isciler_tbl where isci_tc =" + isci_tc, baglan.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnGorusmeAl_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("insert into iscigorusmeleri_tbl (ad, soyad, gorusulecek_mudur, gorusme_tarihi) values (@ad, @soyad, @gorusulecek_mudur, @gorusme_tarihi)", baglan.Baglanti());
            cmd.Parameters.AddWithValue("@ad", txtAd.Text);
            cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@gorusulecek_mudur", txtGorusulecekMudur.Text);
            cmd.Parameters.AddWithValue("@gorusme_tarihi", txtGorusmeTarihi.Text);
            cmd.ExecuteNonQuery();
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
            this.iscigorusmeleri_tblTableAdapter.Fill(this.uretimIsletmesiDataSet2.iscigorusmeleri_tbl);
        }

        private void isci_paneli_FormClosed(object sender, FormClosedEventArgs e)
        {
            isci_girisi frm = new isci_girisi();
            frm.Show();
        }
    }
}
