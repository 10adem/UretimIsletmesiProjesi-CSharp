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
    public partial class mudur_girisi : Form
    {
        public mudur_girisi()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from mudur_tbl where mudur_tc = @mudur_tc and mudur_sifre = @mudur_sifre", baglan.Baglanti());
            command.Parameters.AddWithValue("@mudur_tc", txtMudurTC.Text);
            command.Parameters.AddWithValue("@mudur_sifre", txtSifre.Text);
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                mudur_paneli frm = new mudur_paneli();
                frm.mudur_tc = txtMudurTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglan.Baglanti().Close();
        }

        private void mudur_girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
        }
    }
}
