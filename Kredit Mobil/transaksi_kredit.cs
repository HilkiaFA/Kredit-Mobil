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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace Kredit_Mobil
{
    public partial class transaksi_kredit : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";
        string pilih;
        string sisaKredit;
        public transaksi_kredit()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            nav nav = new nav();
            nav.Show();
            this.Hide();
        }

        private void txt_lamakredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        public void enable()
        {
            txt_noktp.Enabled = true;
            txt_jatutempo.Enabled = true;
            cmb_kodekredit.Enabled = true;
            dateTimePicker1.Enabled = true;
        }
        private void txt_noktp_KeyUp(object sender, KeyEventArgs e)
        {
            lbl_info.Text = string.Empty;
            if (!string.IsNullOrEmpty(txt_noktp.Text))
            {
                SqlConnection connection = new SqlConnection(connectingstring);
                string query = "SELECT nama_pelanggan FROM pelanggan WHERE nomor_ktp = '" + txt_noktp.Text + "'";

                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string buku = reader["nama_pelanggan"].ToString();
                        lbl_info.Text = buku;
                    }
                    else
                    {
                        lbl_info.Text = "Nomor Tidak Tersedia";

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                lbl_info.Text = string.Empty;
            }
        }

        public void nampildata_kredit()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from kredit";
            SqlCommand cmd = new SqlCommand(query, connection);
            /* select m.nama_mobil, k.lama_kredit, k.angsuran, k.DP from mobil m
 inner join kredit k on m.id_mobil = k.id_mobil;*/

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    cmb_kodekredit.Items.Add(reader["kode_kredit"]);
                }
            }
        }

        public void nampildata()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from transaksi_kredit";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["no_transaksi_kredit"], reader["tgl_mulai_kredit"], reader["tgl_jatuh_tempo"], reader["sisa_kredit"], reader["nomor_ktp"]);
                }
            }
        }
        private void transaksi_kredit_Load(object sender, EventArgs e)
        {
            nampildata();
            nampildata_kredit();
        }

        public void enablefalse()
        {
            cmb_kodekredit.SelectedIndex = 0;
            txt_jatutempo.Text = string.Empty;
            txt_noktp.Text = string.Empty;
            pilih = string.Empty;
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {
                var hapus = MessageBox.Show("Yakin menambah data ini?", "information", MessageBoxButtons.YesNo);
                if (hapus == DialogResult.Yes)
                {
                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    DateTime date = dateTimePicker1.Value;
                    string query = "INSERT INTO transaksi_kredit(tgl_mulai_kredit,tgl_jatuh_tempo,nomor_ktp,kode_kredit,sisa_kredit,jumlah_total_kredit) VALUES (@date,'" + txt_jatutempo.Text + "','" + txt_noktp.Text + "','" + cmb_kodekredit.Text + "','" + sisaKredit + "','" + sisaKredit + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@date", date);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        MessageBox.Show("Berhasil ditambah");
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                
            }      
        }

        private void btn_updae_Click(object sender, EventArgs e)
        {

        }
        string id_update;
        private void cmb_kodekredit_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmb_kodekredit.SelectedItem.ToString();
            
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select m.nama_mobil, m.harga from mobil m\r\n inner join kredit k on m.id_mobil = k.id_mobil where kode_kredit=@id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", id);

            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                sisaKredit = reader["harga"].ToString();
            }
        }

        private void txt_noktp_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
