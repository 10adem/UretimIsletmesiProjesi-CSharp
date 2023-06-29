using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UretimIsletmesi
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void btniscigirisi_Click(object sender, EventArgs e)
        {
            isci_girisi frm = new isci_girisi();
            frm.Show();
            this.Hide();
        }

        private void btnformengirisi_Click(object sender, EventArgs e)
        {
            formen_girisi frm = new formen_girisi();
            frm.Show();
            this.Hide();
        }

        private void btnmudurgirisi_Click(object sender, EventArgs e)
        {
            mudur_girisi frm = new mudur_girisi();
            frm.Show();
            this.Hide();
        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
