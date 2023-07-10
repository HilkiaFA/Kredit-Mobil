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
    public partial class pelanggan : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";
        string pilih;
        public pelanggan()
        {
            InitializeComponent();
        }

        public void enable()
        {
            txt_nama.Enabled = true;
            txt_kota.Enabled = true;
            txt_noktp.Enabled = true;
            rdo_laki.Enabled = true;
            rdo_perempuan.Enabled = true;
            txt_alamat.Enabled = true;
            txt_email.Enabled = true;
            txt_nohp.Enabled = true;
            dateTimePicker1.Enabled = true;
            txt_usia.Enabled = true;
            btn_simpan.Enabled = true;
            btn_batal.Enabled = true;

            btn_edit.Enabled = false;
            btn_tambah.Enabled = false;
            btn_hapus.Enabled = false;
        }

        public void enablefalse()
        {
            txt_nama.Enabled = false;
            txt_kota.Enabled = false;
            txt_noktp.Enabled = false;
            rdo_laki.Enabled = false;
            rdo_perempuan.Enabled = false;
            txt_alamat.Enabled = false;
            txt_email.Enabled = false;
            txt_nohp.Enabled = false;
            dateTimePicker1.Enabled = false;
            txt_usia.Enabled = false;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;

            btn_edit.Enabled = true;
            btn_tambah.Enabled = true;
            btn_hapus.Enabled = true;

            txt_nama.Text = string.Empty;
            rdo_laki.Checked = false;
            rdo_perempuan.Checked = false;
            txt_email.Text = string.Empty;
            txt_alamat.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            txt_usia.Text = string.Empty;
            txt_nohp.Text = string.Empty;
            txt_noktp.Text = string.Empty;
            txt_kota.Text = string.Empty;
            pilih = string.Empty;
        }
        private void btn_tambah_Click(object sender, EventArgs e)
        {
            pilih = "tambah";
            enable();
        }

        private void btn_batal_Click(object sender, EventArgs e)
        {
            enablefalse();
        }
        string nomor_ktp;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pilih = "edit";
                enable();
                txt_noktp.Enabled = false;
                var id = dataGridView1.SelectedRows[0].Cells["no_ktp"].Value;

                SqlConnection connection = new SqlConnection(connectingstring);
                connection.Open();
                string query = "select * from pelanggan where nomor_ktp=@id";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.Add("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    nomor_ktp = reader["nomor_ktp"].ToString();
                    txt_noktp.Text = reader["nomor_ktp"].ToString();
                    txt_nama.Text = reader["nama_pelanggan"].ToString();
                    dateTimePicker1.Text = reader["tgl_lahir"].ToString();
                    txt_usia.Text = reader["usia"].ToString();
                    txt_alamat.Text = reader["alamat"].ToString();
                    txt_kota.Text = reader["kota"].ToString();
                    txt_nohp.Text = reader["no_hp"].ToString();
                    txt_email.Text = reader["email"].ToString();

                    string gender = reader["jenisKelamin"].ToString();
                    if (gender == "laki-laki")
                    {
                        rdo_laki.Checked = true;
                    }
                    else if (gender == "perempuan")
                    {
                        rdo_perempuan.Checked = true;
                    }
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = MessageBox.Show("Yakin menghapus data ini?", "information", MessageBoxButtons.YesNo);
            if (hapus == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    var id = dataGridView1.SelectedRows[0].Cells["no_ktp"].Value;

                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string query = "delete from pelanggan where nomor_ktp=@id";
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
        public void nampildata()
        {
            SqlConnection connection = new SqlConnection(connectingstring);
            connection.Open();
            string query = "select * from pelanggan";
            SqlCommand cmd = new SqlCommand(query, connection);

            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["nomor_ktp"], reader["nama_pelanggan"], reader["jenisKelamin"], reader["alamat"], reader["kota"], reader["no_hp"], reader["email"]);
                }
            }
        }
        private void pelanggan_Load(object sender, EventArgs e)
        {
            nampildata();
        }

        string gender;
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_noktp.Text) || string.IsNullOrEmpty(txt_nama.Text) || string.IsNullOrEmpty(txt_usia.Text) || string.IsNullOrEmpty(txt_alamat.Text) || string.IsNullOrEmpty(txt_kota.Text) || string.IsNullOrEmpty(txt_nohp.Text) || string.IsNullOrEmpty(txt_email.Text) || (rdo_laki.Checked && rdo_perempuan.Checked))
            {
                MessageBox.Show("silahkan lengkapi");
            }
            else
            {
                if (pilih == "tambah")
                {
                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();

                    if (rdo_laki.Checked == true)
                    {
                        gender = "laki-laki";
                    }
                    else if (rdo_perempuan.Checked == true)
                    {
                        gender = "perempuan";
                    }
                    DateTime date = dateTimePicker1.Value;
                    string query = "INSERT INTO pelanggan(nomor_ktp,nama_pelanggan,jenisKelamin,tgl_lahir,usia,alamat,kota,no_hp,email) VALUES ('" + txt_noktp.Text + "','" + txt_nama.Text + "',@gender,@date,'" + txt_usia.Text + "','" + txt_alamat.Text + "','" + txt_kota.Text + "','" + txt_nohp.Text + "','" + txt_email.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.Add("@date", date);
                    cmd.Parameters.Add("@gender", gender);

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

                    if (rdo_laki.Checked == true)
                    {
                        gender = "laki-laki";
                    }
                    else if (rdo_perempuan.Checked == true)
                    {
                        gender = "perempuan";
                    }
                    DateTime date = dateTimePicker1.Value;
                    string query = "update pelanggan set nama_pelanggan='" + txt_nama.Text + "', jenisKelamin=@gender, tgl_lahir=@date, usia='" + txt_usia.Text + "', alamat='" + txt_alamat.Text + "', kota='" + txt_kota.Text + "', no_hp='" + txt_nohp.Text + "', email='" + txt_email.Text + "' where nomor_ktp=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.Add("@id", nomor_ktp);
                    command.Parameters.Add("@date", date);
                    command.Parameters.Add("@gender", gender);

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

        private void button1_Click(object sender, EventArgs e)
        {
            nav nav = new nav();
            nav.Show();
            this.Hide();
        }

        private void dateTimePicker1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime tanggalLahir = dateTimePicker1.Value;

            DateTime tanggalSekarang = DateTime.Now;
            int umur = tanggalSekarang.Year - tanggalLahir.Year;

            if (tanggalSekarang < tanggalLahir.AddYears(umur))
            {
                umur--;
            }
            txt_usia.Text= umur.ToString();
        }
    }
}
