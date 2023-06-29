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
    public partial class formen_girisi : Form
    {
        public formen_girisi()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select * from formenler_tbl where formen_tc = @formen_tc and formen_sifre = @formen_sifre", baglan.Baglanti());
            cmd.Parameters.AddWithValue("@formen_tc", txtFormenTC.Text);
            cmd.Parameters.AddWithValue("@formen_sifre", txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                formen_paneli frm = new formen_paneli();
                frm.formen_tc = txtFormenTC.Text;
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC veya şifre girdiniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            baglan.Baglanti().Close();
        }

        private void btnAnasayfa_Click(object sender, EventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
            this.Hide();
        }

        private void formen_girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
        }
    }
}
