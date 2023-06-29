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
    public partial class formen_islemleri : Form
    {
        public formen_islemleri()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void formen_islemleri_Load(object sender, EventArgs e)
        {
            verileriGetir();
        }

        private void btnFormenEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into formenler_tbl (formen_tc, formen_sifre, formen_ad, formen_soyad, formen_dogumyeri, formen_maas, formen_bolum, formen_medenidurum, formen_cinsiyet) values (@formen_tc, @formen_sifre, @formen_ad, @formen_soyad, @formen_dogumyeri, @formen_maas, @formen_bolum, @formen_medenidurum, @formen_cinsiyet)", baglan.Baglanti());
            ekle.Parameters.AddWithValue("@formen_tc", txtFormenTC.Text);
            ekle.Parameters.AddWithValue("@formen_sifre", txtSıfre.Text);
            ekle.Parameters.AddWithValue("@formen_ad", txtAd.Text);
            ekle.Parameters.AddWithValue("@formen_soyad", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@formen_dogumyeri", cbDogumYeri.Text);
            ekle.Parameters.AddWithValue("@formen_maas", txtMaas.Text);
            ekle.Parameters.AddWithValue("@formen_bolum", txtBolum.Text);
            if (rdboEvli.Checked == true)
            {
                ekle.Parameters.AddWithValue("@formen_medenidurum", "Evli");
            }
            if (rdboBekar.Checked == true)
            {
                ekle.Parameters.AddWithValue("@formen_medenidurum", "Bekar");
            }
            ekle.Parameters.AddWithValue("@formen_cinsiyet", txtCinsiyet.Text);

            ekle.ExecuteNonQuery();

            baglan.Baglanti().Close();

            MessageBox.Show("Formen başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            verileriTemizle();

            verileriGetir();
        }
        public void verileriTemizle()
        {
            txtFormenTC.Text = "";
            txtSıfre.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cbDogumYeri.Text = "";
            txtMaas.Text = "";
            txtBolum.Text = "";
            txtCinsiyet.Text = "";
            rdboEvli.Checked = false;
            rdboBekar.Checked = false;
        }

        public void verileriGetir()
        {
            DataTable dtf = new DataTable();
            SqlDataAdapter daf = new SqlDataAdapter("select * from formenler_tbl", baglan.Baglanti());
            daf.Fill(dtf);
            dataGridView1.DataSource = dtf;
        }

        private void btnPaneleDon_Click(object sender, EventArgs e)
        {
            mudur_paneli panel = new mudur_paneli();
            panel.mudur_tc = txtMudurTC.Text;
            panel.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            verileriTemizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtFormenTC.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtSıfre.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            cbDogumYeri.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            if (dataGridView1.Rows[sec].Cells[8].Value.ToString() == "Evli")
            {
                rdboEvli.Checked = true;
            }
            if (dataGridView1.Rows[sec].Cells[8].Value.ToString() == "Bekar")
            {
                rdboBekar.Checked = true;
            }
            txtCinsiyet.Text = dataGridView1.Rows[sec].Cells[9].Value.ToString();
        }

        private void btnFormenGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update formenler_tbl set formen_tc = @formen_tc, formen_sifre = @formen_sifre, formen_ad = @formen_ad, formen_soyad = @formen_soyad, formen_dogumyeri = @formen_dogumyeri, formen_maas = @formen_maas, formen_bolum = @formen_bolum, formen_medenidurum = @formen_medenidurum, formen_cinsiyet = @formen_cinsiyet where formen_tc =" + txtFormenTC.Text.ToString(), baglan.Baglanti());
            guncelle.Parameters.AddWithValue("@formen_tc", txtFormenTC.Text);
            guncelle.Parameters.AddWithValue("@formen_sifre", txtSıfre.Text);
            guncelle.Parameters.AddWithValue("@formen_ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@formen_soyad", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@formen_dogumyeri", cbDogumYeri.Text);
            guncelle.Parameters.AddWithValue("@formen_maas", txtMaas.Text);
            guncelle.Parameters.AddWithValue("@formen_bolum", txtBolum.Text);
            if (rdboEvli.Checked == true)
            {
                guncelle.Parameters.AddWithValue("@formen_medenidurum", "Evli");
            }
            if (rdboBekar.Checked == true)
            {
                guncelle.Parameters.AddWithValue("@formen_medenidurum", "Bekar");
            }
            guncelle.Parameters.AddWithValue("@formen_cinsiyet", txtCinsiyet.Text);

            guncelle.ExecuteNonQuery();

            baglan.Baglanti().Close();

            MessageBox.Show("Formen başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            verileriTemizle();

            verileriGetir();
        }

        private void btnFormenSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from formenler_tbl where formen_tc = @formen_tc", baglan.Baglanti());
            sil.Parameters.AddWithValue("@formen_tc", txtFormenTC.Text);

            DialogResult confirm = MessageBox.Show("Formeni silmek istediğinize emin misiniz ?", "Formen Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "Formen Silme İptali");
            }
            else
            {
                int result = sil.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("Formen başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silme işlemi yapılamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            baglan.Baglanti().Close();

            verileriTemizle();

            verileriGetir();
        }

        private void btnFormenListele_Click(object sender, EventArgs e)
        {
            verileriGetir();
            MessageBox.Show("Formen listeleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
