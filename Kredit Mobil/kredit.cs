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
    public partial class kredit : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";
        string pilih;
        public kredit()
        {
            InitializeComponent();
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            nav nav = new nav();
            nav.Show();
            this.Hide();
        }
        public void nampildata_mobil()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from mobil";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_mobil"], reader["nama_mobil"], reader["kategori"], reader["harga"]);
                }
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
                    dataGridView2.Rows.Add(reader["kode_kredit"], reader["lama_kredit"], reader["DP"], reader["angsuran"]);
                }
            }
        }
        private void kredit_Load(object sender, EventArgs e)
        {
            nampildata_mobil();
            nampildata_kredit();
        }

        public void enable()
        {
            txt_angsuran.Enabled = true;
            txt_dp.Enabled = true;
            txt_lamakredit.Enabled = true;
            btn_simpan.Enabled = true;
            btn_batal.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
        }

        string kode_mobil;
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pilih = "tambah";
                enable();
                var id = dataGridView1.SelectedRows[0].Cells["id_mobil"].Value;

                SqlConnection connection = new SqlConnection(connectingstring);
                connection.Open();
                string query = "select * from mobil where id_mobil=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kode_mobil = reader["id_mobil"].ToString();
                }
            }
        }

        public void enablefalse()
        {
            txt_angsuran.Enabled = false;
            txt_lamakredit.Enabled = false;
            txt_dp.Enabled = false;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;

            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            txt_angsuran.Text = string.Empty;
            txt_dp.Text = string.Empty;
            txt_lamakredit.Text = string.Empty;
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            enablefalse();
        }

        string kode_kredit;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {
                pilih = "edit";
                enable();
                var id = dataGridView2.SelectedRows[0].Cells["id_kredit"].Value;

                SqlConnection connection = new SqlConnection(connectingstring);
                connection.Open();
                string query = "select * from kredit where kode_kredit=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kode_kredit = reader["kode_kredit"].ToString();
                    txt_angsuran.Text = reader["angsuran"].ToString();
                    txt_dp.Text = reader["DP"].ToString();
                    txt_lamakredit.Text = reader["lama_kredit"].ToString();
                }
            }
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_lamakredit.Text) || string.IsNullOrEmpty(txt_angsuran.Text) || string.IsNullOrEmpty(txt_dp.Text))
            {
                MessageBox.Show("silahkan lengkapi");
            }
            else
            {
                if (pilih == "tambah")
                {
                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string query = "INSERT INTO kredit(lama_kredit,angsuran,DP,id_mobil) VALUES ('" + txt_lamakredit.Text + "','" + txt_angsuran.Text + "','" + txt_dp.Text + "',@kodemobil)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@kodemobil", kode_mobil);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        MessageBox.Show("Berhasil ditambah");
                        dataGridView2.Rows.Clear();
                        nampildata_kredit();
                    }
                }
                else if (pilih == "edit")
                {
                    SqlConnection conn = new SqlConnection(connectingstring);
                    conn.Open();
                    string query = "update kredit set lama_kredit='" + txt_lamakredit.Text + "', angsuran='" + txt_angsuran.Text + "', DP='" + txt_dp.Text + "' where kode_kredit=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.Add("@id", kode_kredit);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        MessageBox.Show("berhasil diedit");
                        dataGridView2.Rows.Clear();
                        nampildata_kredit();
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = MessageBox.Show("Yakin menghapus data ini?", "information", MessageBoxButtons.YesNo);
            if (hapus == DialogResult.Yes)
            {
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    var id = dataGridView2.SelectedRows[0].Cells["id_kredit"].Value;

                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string query = "delete from kredit where kode_kredit=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", id);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dataGridView2.Rows.Clear();
                        nampildata_kredit();
                    }
                }
            }
        }
    }
}
