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
    public partial class pegawai : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";
        string pilih;
        public pegawai()
        {
            InitializeComponent();
        }
        public void enable()
        {
            txt_nama.Enabled= true;
            txt_alamat.Enabled= true;
            dateTimePicker2.Enabled= true;
            txt_email.Enabled= true;
            txt_nohp.Enabled= true;
            dateTimePicker1.Enabled= true;
            cmb_jabatan.Enabled= true;
            txt_usia.Enabled= true;
            btn_simpan.Enabled= true;
            btn_batal.Enabled= true;

            btn_edit.Enabled= false;
            btn_tambah.Enabled= false;
            btn_hapus.Enabled= false;
        }
        public void enablefalse()
        {
            txt_nama.Enabled = false;
            txt_alamat.Enabled = false;
            dateTimePicker2.Enabled = false;
            txt_email.Enabled = false;
            txt_nohp.Enabled = false;
            dateTimePicker1.Enabled = false;
            cmb_jabatan.Enabled = false;
            txt_usia.Enabled = false;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;

            btn_edit.Enabled = true;
            btn_tambah.Enabled = true;
            btn_hapus.Enabled = true;

            txt_nama.Text=string.Empty;
            txt_email.Text=string.Empty;
            txt_alamat.Text=string.Empty;
            dateTimePicker1.Text=string.Empty;
            txt_usia.Text=string.Empty;
            txt_nohp.Text=string.Empty;
            pilih = string.Empty;
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            enable();
            pilih = "tambah";
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            enablefalse();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_nama.Text) || string.IsNullOrEmpty(txt_alamat.Text) || string.IsNullOrEmpty(txt_nohp.Text) || string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(cmb_jabatan.Text) || string.IsNullOrEmpty(txt_usia.Text))
            {
                MessageBox.Show("Lengkappi data!!");
            }
            else
            {
                if (pilih == "tambah")
                {
                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    DateTime date = dateTimePicker1.Value;
                    DateTime date2 = dateTimePicker2.Value;
                    string query = "INSERT INTO pegawai(nama_pegawai,alamat_pegawai,no_telp,email,jabatan,tgl_lahir,usia,bekerja_sejak) VALUES ('" + txt_nama.Text + "','" + txt_alamat.Text + "','" + txt_nohp.Text + "','" + txt_email.Text + "','" + cmb_jabatan.Text + "',@date,'" + txt_usia.Text + "',@date2)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@date", date);
                    cmd.Parameters.Add("@date2", date2);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        MessageBox.Show("Berhasil ditambah");
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                }
                else if (pilih == "edit")
                {
                    SqlConnection conn = new SqlConnection(connectingstring);
                    conn.Open();
                    DateTime date = dateTimePicker1.Value;
                    DateTime date2 = dateTimePicker2.Value;
                    string query = "update pegawai set nama_pegawai='" + txt_nama.Text + "', alamat_pegawai='" + txt_alamat.Text + "', no_telp='" + txt_nohp.Text + "', email='" + txt_email.Text + "', jabatan='" + cmb_jabatan.Text + "', tgl_lahir=@date, usia='" + txt_usia.Text + "', bekerja_sejak=@date2 where id_pegawai=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.Add("@id", kode_pegawai);
                    command.Parameters.Add("@date", date);
                    command.Parameters.Add("@date2", date2);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        MessageBox.Show("berhasil diedit");
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                }
            }
            
        }
        string kode_pegawai;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pilih = "edit";
                enable();
                var id = dataGridView1.SelectedRows[0].Cells["id_pegawai"].Value;

                SqlConnection connection = new SqlConnection(connectingstring);
                connection.Open();
                string query = "select * from pegawai where id_pegawai=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    kode_pegawai = reader["id_pegawai"].ToString();
                    txt_nama.Text = reader["nama_pegawai"].ToString();
                    txt_alamat.Text = reader["alamat_pegawai"].ToString();
                    txt_nohp.Text = reader["no_telp"].ToString();
                    txt_email.Text = reader["email"].ToString();
                    cmb_jabatan.Text = reader["jabatan"].ToString();
                    dateTimePicker1.Text = reader["tgl_lahir"].ToString();
                    txt_usia.Text = reader["usia"].ToString();
                    dateTimePicker2.Text = reader["bekerja_sejak"].ToString();
                }
            }
        }

        public void nampildata()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from pegawai";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_pegawai"], reader["nama_pegawai"], reader["alamat_pegawai"], reader["no_telp"], reader["jabatan"], reader["email"]);
                }
            }
        }
        private void pegawai_Load(object sender, EventArgs e)
        {
            nampildata();
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = MessageBox.Show("Yakin menghapus data ini?", "information", MessageBoxButtons.YesNo);
            if (hapus == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    var id = dataGridView1.SelectedRows[0].Cells["id_pegawai"].Value;

                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string query = "delete from pegawai where id_pegawai=@id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add("@id", id);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                }
            }
        }

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            nav nav = new nav();
            nav.Show();
            this.Hide();
        }
    }
}
