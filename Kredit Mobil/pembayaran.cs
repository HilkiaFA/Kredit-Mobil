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

namespace Kredit_Mobil
{
    public partial class pembayaran : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";

        public pembayaran()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            nav nav = new nav();
            nav.Show();
            this.Hide();
        }
        public void nampildata_kredit()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from pegawai";
            SqlCommand cmd = new SqlCommand(query, connection);
            /* select m.nama_mobil, k.lama_kredit, k.angsuran, k.DP from mobil m
 inner join kredit k on m.id_mobil = k.id_mobil;*/

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmb_pegawai.Items.Add(reader["nama_pegawai"]);
                }
            }
        }

        public void nampildata()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select t.no_transaksi_kredit, p.nama_pelanggan,t.nomor_ktp, t.jumlah_total_kredit, t.sisa_kredit,m.nama_mobil from transaksi_kredit t\r\ninner join kredit k on t.kode_kredit = k.kode_kredit\r\ninner join mobil m on k.id_mobil = m.id_mobil\r\ninner join pelanggan p on t.nomor_ktp = p.nomor_ktp";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["no_transaksi_kredit"], reader["nomor_ktp"], reader["nama_pelanggan"], reader["jumlah_total_kredit"], reader["nama_mobil"], reader["sisa_kredit"]);
                }
            }
        }

        private void pembayaran_Load(object sender, EventArgs e)
        {
            nampildata_kredit();
            nampildata();
        }
        string kode_pegawai;
        private void cmb_kodekredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmb_pegawai.SelectedItem.ToString();

            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from pegawai where nama_pegawai=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                kode_pegawai = reader["id_pegawai"].ToString();
            }
        }

        string no_transaksi;
        string sisakredit;

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            no_transaksi = row.Cells["no_transkasi"].Value.ToString();
            sisakredit = row.Cells["sisa_kredit"].Value.ToString();
        }

        public void updatesisakredit()
        {
            int sisa = Convert.ToInt32(sisakredit);
            int bayar = Convert.ToInt32(txt_jumlahbayar.Text);

            int hasil = sisa - bayar;

            SqlConnection conn = new SqlConnection(connectingstring);
            conn.Open();
            string query = "update transaksi_kredit set sisa_kredit=@hasil where no_transaksi_kredit=@id";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.Add("@hasil", hasil.ToString());
            command.Parameters.Add("@id", no_transaksi);
            command.ExecuteNonQuery();
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_jumlahbayar.Text) || string.IsNullOrEmpty(cmb_pegawai.Text))
            {
                MessageBox.Show("silahkan lengkapi terlebih dahuu");
            }
            else
            {
                SqlConnection connection = new SqlConnection(connectingstring);
                connection.Open();
                DateTime date = dateTimePicker1.Value;
                string query = "INSERT INTO pembayaran(tgl_pembayaran,jumlah_bayar,no_transaksi_kredit,id_pegawai) VALUES (@date,'" + txt_jumlahbayar.Text + "',@notransaksi,@kodepegawai)";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.Add("@date", date);
                cmd.Parameters.Add("@notransaksi", no_transaksi);
                cmd.Parameters.Add("@kodepegawai", kode_pegawai);

                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                {
                    updatesisakredit();
                    MessageBox.Show("Berhasil Terbayar");
                    dataGridView1.Rows.Clear();
                    nampildata();
                }
            }
        }
    }
}
