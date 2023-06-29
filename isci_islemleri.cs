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
    public partial class isci_islemleri : Form
    {
        public isci_islemleri()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void isci_islemleri_Load(object sender, EventArgs e)
        {
            verileriYukle();
        }

        private void btnisciEkle_Click(object sender, EventArgs e)
        {
            SqlCommand ekle = new SqlCommand("insert into isciler_tbl (isci_tc, isci_sifre, isci_ad, isci_soyad, isci_dogumyeri, isci_maas, isci_bolum, isci_medenidurum, isci_cinsiyet) values (@isci_tc, @isci_sifre, @isci_ad, @isci_soyad, @isci_dogumyeri, @isci_maas, @isci_bolum, @isci_medenidurum, @isci_cinsiyet)", baglan.Baglanti());
            ekle.Parameters.AddWithValue("@isci_tc", txtisciTC.Text);
            ekle.Parameters.AddWithValue("@isci_sifre", txtSıfre.Text);
            ekle.Parameters.AddWithValue("@isci_ad", txtAd.Text);
            ekle.Parameters.AddWithValue("@isci_soyad", txtSoyad.Text);
            ekle.Parameters.AddWithValue("@isci_dogumyeri", cboDogumYeri.Text);
            ekle.Parameters.AddWithValue("@isci_maas", txtMaas.Text);
            ekle.Parameters.AddWithValue("@isci_bolum", txtBolum.Text);
            if (rdbEvli.Checked == true)
            {
                ekle.Parameters.AddWithValue("@isci_medenidurum", "Evli");
            }
            if (rdbBekar.Checked == true)
            {
                ekle.Parameters.AddWithValue("@isci_medenidurum", "Bekar");
            }
            ekle.Parameters.AddWithValue("@isci_cinsiyet", txtCinsiyet.Text);

            ekle.ExecuteNonQuery();

            baglan.Baglanti().Close();

            MessageBox.Show("İşçi başarıyla eklendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ogeleriTemizle();

            verileriYukle();


        }

        public void ogeleriTemizle()
        {
            txtisciTC.Text = "";
            txtSıfre.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            cboDogumYeri.Text = "";
            txtMaas.Text = "";
            txtBolum.Text = "";
            txtCinsiyet.Text = "";
            rdbEvli.Checked = false;
            rdbEvli.Checked = false;
        }

        public void verileriYukle()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from isciler_tbl", baglan.Baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnPaneleDon_Click(object sender, EventArgs e)
        {
            mudur_paneli mdrpnl = new mudur_paneli();
            mdrpnl.mudur_tc = txtMudurTC.Text;
            mdrpnl.Show();
            this.Hide();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            ogeleriTemizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sec = dataGridView1.SelectedCells[0].RowIndex;
            txtisciTC.Text = dataGridView1.Rows[sec].Cells[1].Value.ToString();
            txtSıfre.Text = dataGridView1.Rows[sec].Cells[2].Value.ToString();
            txtAd.Text = dataGridView1.Rows[sec].Cells[3].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[sec].Cells[4].Value.ToString();
            cboDogumYeri.Text = dataGridView1.Rows[sec].Cells[5].Value.ToString();
            txtMaas.Text = dataGridView1.Rows[sec].Cells[6].Value.ToString();
            txtBolum.Text = dataGridView1.Rows[sec].Cells[7].Value.ToString();
            if (dataGridView1.Rows[sec].Cells[8].Value.ToString() == "Evli")
            {
                rdbEvli.Checked = true;
            }
            if (dataGridView1.Rows[sec].Cells[8].Value.ToString() == "Bekar")
            {
                rdbBekar.Checked = true;
            }
            txtCinsiyet.Text = dataGridView1.Rows[sec].Cells[9].Value.ToString();
        }

        private void btnisciGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("update isciler_tbl set isci_tc = @isci_tc, isci_sifre = @isci_sifre, isci_ad = @isci_ad, isci_soyad = @isci_soyad, isci_dogumyeri = @isci_dogumyeri, isci_maas = @isci_maas, isci_bolum = @isci_bolum, isci_medenidurum = @isci_medenidurum, isci_cinsiyet = @isci_cinsiyet where isci_tc =" + txtisciTC.Text, baglan.Baglanti());
            guncelle.Parameters.AddWithValue("@isci_tc", txtisciTC.Text);
            guncelle.Parameters.AddWithValue("@isci_sifre", txtSıfre.Text);
            guncelle.Parameters.AddWithValue("@isci_ad", txtAd.Text);
            guncelle.Parameters.AddWithValue("@isci_soyad", txtSoyad.Text);
            guncelle.Parameters.AddWithValue("@isci_dogumyeri", cboDogumYeri.Text);
            guncelle.Parameters.AddWithValue("@isci_maas", txtMaas.Text);
            guncelle.Parameters.AddWithValue("@isci_bolum", txtBolum.Text);
            if (rdbEvli.Checked == true)
            {
                guncelle.Parameters.AddWithValue("@isci_medenidurum", "Evli");
            }
            if (rdbBekar.Checked == true)
            {
                guncelle.Parameters.AddWithValue("@isci_medenidurum", "Bekar");
            }
            guncelle.Parameters.AddWithValue("@isci_cinsiyet", txtCinsiyet.Text);

            guncelle.ExecuteNonQuery();

            baglan.Baglanti().Close();

            MessageBox.Show("İşçi başarıyla güncellendi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ogeleriTemizle();

            verileriYukle();
        }

        private void btnisciSil_Click(object sender, EventArgs e)
        {
            SqlCommand sil = new SqlCommand("delete from isciler_tbl where isci_tc = @isci_tc", baglan.Baglanti());
            sil.Parameters.AddWithValue("@isci_tc", txtisciTC.Text);

            DialogResult confirm = MessageBox.Show("İşçiyi silmek istediğinize emin misiniz ?", "İşçi Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.No)
            {
                MessageBox.Show("Silme işlemi iptal edildi.", "İşçi Silme İptali");
            }
            else
            {
                int result = sil.ExecuteNonQuery();
                if (result == 1)
                {
                    MessageBox.Show("İşçi başarıyla silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Silme işlemi yapılamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            baglan.Baglanti().Close();

            ogeleriTemizle();

            verileriYukle();
        }

        private void btnisciListele_Click(object sender, EventArgs e)
        {
            verileriYukle();
            MessageBox.Show("İşçi listeleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
