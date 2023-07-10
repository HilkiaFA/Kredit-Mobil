using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kredit_Mobil
{
    public partial class Form1 : Form
    {
        string connectingstring = "Data Source=DELL-01\\SQLEXPRESS;Initial Catalog=KreditMobil;Integrated Security=true";
        string pilih;
        public Form1()
        {
            InitializeComponent();
        }

        public void enable()
        {
            txt_mobil.Enabled = true;
            txt_kategori.Enabled = true;
            txt_harga.Enabled = true;
            btn_carifoto.Enabled = true;
            btn_simpan.Enabled = true;
            btn_batal.Enabled = true;

            btn_tambah.Enabled = false;
            btn_edit.Enabled = false;
            btn_hapus.Enabled = false;
        }

        public void enablefalse()
        {
            txt_mobil.Enabled = false;
            txt_kategori.Enabled = false;
            txt_harga.Enabled = false;
            btn_carifoto.Enabled = false;
            btn_simpan.Enabled = false;
            btn_batal.Enabled = false;

            btn_tambah.Enabled = true;
            btn_edit.Enabled = true;
            btn_hapus.Enabled = true;
            txt_mobil.Text = string.Empty;
            txt_harga.Text = string.Empty;
            txt_kategori.Text = string.Empty;
            pictureBox1.Image = null;
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

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mobil.Text) || string.IsNullOrEmpty(txt_kategori.Text) || string.IsNullOrEmpty(txt_harga.Text) || pictureBox1.Image == null)
            {
                MessageBox.Show("silahkan lengkapi");
            }
            else
            {
                if (pilih == "tambah")
                {
                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string location = pindah.ToString();
                    string query = "INSERT INTO mobil(nama_mobil,kategori,harga,foto) VALUES ('" + txt_mobil.Text + "','" + txt_kategori.Text + "','" + txt_harga.Text + "','" + location + "')";
                    SqlCommand cmd = new SqlCommand(query, connection);

                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        savegambar();
                        MessageBox.Show("Berhasil ditambah");
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                }
                else if (pilih == "edit")
                {
                    SqlConnection conn = new SqlConnection(connectingstring);
                    conn.Open();
                    string location = pindah.ToString();
                    string query = "update mobil set nama_mobil='" + txt_mobil.Text + "', kategori='" + txt_kategori.Text + "', harga='" + txt_harga.Text + "', foto='" + location + "' where id_mobil=@id";
                    SqlCommand command = new SqlCommand(query, conn);
                    command.Parameters.Add("@id", kode_mobil);

                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        enablefalse();
                        savegambar();
                        MessageBox.Show("berhasil diedit");
                        dataGridView1.Rows.Clear();
                        nampildata();
                    }
                }
            }

        }

        string lokasifile;
        string pindah;
        private void btn_carifoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.InitialDirectory = "C:\\";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                lokasifile = openFileDialog.FileName;
                string namafile = Path.GetFileName(lokasifile);
                string random = Path.GetRandomFileName();
                string extion = Path.GetExtension(lokasifile);

                pindah = Path.Combine("C:\\Users\\Dell 01\\source\\repos\\Kredit Mobil\\Kredit Mobil\\foto_mobil", random + extion);
            }
        }
        public void savegambar()
        {
            try
            {
                string fileawal = lokasifile;
                string lokasidituju = pindah;

                File.Copy(fileawal, lokasidituju);
            }
            catch
            {


            }
        }

        public void nampildata()
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
        private void Form1_Load(object sender, EventArgs e)
        {
            nampildata();
        }

        string kode_mobil;
        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                pilih = "edit";
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
                    txt_mobil.Text = reader["nama_mobil"].ToString();
                    txt_harga.Text = reader["harga"].ToString();
                    txt_kategori.Text = reader["kategori"].ToString();
                    kode_mobil = reader["id_mobil"].ToString();
                    pindah = reader["foto"].ToString();
                    pictureBox1.Image = Image.FromFile(reader["foto"].ToString());
                }
            }
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            var hapus = MessageBox.Show("Yakin menghapus data ini?","information",MessageBoxButtons.YesNo);
            if (hapus == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    var id = dataGridView1.SelectedRows[0].Cells["id_mobil"].Value;

                    SqlConnection connection = new SqlConnection(connectingstring);
                    connection.Open();
                    string query = "delete from mobil where id_mobil=@id";
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
