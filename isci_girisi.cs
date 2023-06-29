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
    public partial class isci_girisi : Form
    {
        public isci_girisi()
        {
            InitializeComponent();
        }

        SqlBaglanti baglan = new SqlBaglanti();

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand girisyapkomutu = new SqlCommand("select * from isciler_tbl where isci_tc = @isci_tc and isci_sifre = @isci_sifre", baglan.Baglanti());
            girisyapkomutu.Parameters.AddWithValue("@isci_tc", txtisciTC.Text);
            girisyapkomutu.Parameters.AddWithValue("@isci_sifre", txtSifre.Text);
            SqlDataReader dr = girisyapkomutu.ExecuteReader();
            if (dr.Read())
            {
                isci_paneli frm = new isci_paneli();
                frm.isci_tc = txtisciTC.Text;
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

        private void isci_girisi_FormClosed(object sender, FormClosedEventArgs e)
        {
            anasayfa frm = new anasayfa();
            frm.Show();
        }
    }
}
