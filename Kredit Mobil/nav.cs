using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_Mobil
{
    public partial class nav : Form
    {
        public nav()
        {
            InitializeComponent();
        }

        private void btn_mobil_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btn_kredit_Click(object sender, EventArgs e)
        {
            kredit kredit = new kredit();
            kredit.Show();
            this.Hide();
        }

        private void btn_pelanggan_Click(object sender, EventArgs e)
        {
            pelanggan pelanggan = new pelanggan();
            pelanggan.Show();
            this.Hide();
        }

        private void btn_pegawai_Click(object sender, EventArgs e)
        {
            pegawai pegawai = new pegawai();
            pegawai.Show();
            this.Hide();
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            transaksi_kredit transaksi_Kredit = new transaksi_kredit();
            transaksi_Kredit.Show();
            this.Hide();
        }

        private void btn_pembayaran_Click(object sender, EventArgs e)
        {
            pembayaran pembayaran = new pembayaran();
            pembayaran.Show();
            this.Hide();
        }
    }
}
