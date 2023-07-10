namespace Kredit_Mobil
{
    partial class pembayaran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_kembali = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_jumlahbayar = new System.Windows.Forms.TextBox();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmb_pegawai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.no_transkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_ktp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_pelanggan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah_total_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisa_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(9, 10);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(93, 25);
            this.btn_kembali.TabIndex = 0;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(22, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tanggal Pembayaran";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 254);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Jumlah bayar";
            // 
            // txt_jumlahbayar
            // 
            this.txt_jumlahbayar.Location = new System.Drawing.Point(165, 253);
            this.txt_jumlahbayar.Multiline = true;
            this.txt_jumlahbayar.Name = "txt_jumlahbayar";
            this.txt_jumlahbayar.Size = new System.Drawing.Size(232, 27);
            this.txt_jumlahbayar.TabIndex = 23;
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(661, 365);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(127, 26);
            this.btn_simpan.TabIndex = 24;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 215);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(232, 20);
            this.dateTimePicker1.TabIndex = 25;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 19, 0, 0, 0, 0);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_transkasi,
            this.no_ktp,
            this.nama_pelanggan,
            this.jumlah_total_kredit,
            this.nama_mobil,
            this.sisa_kredit});
            this.dataGridView1.Location = new System.Drawing.Point(9, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 150);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmb_pegawai
            // 
            this.cmb_pegawai.FormattingEnabled = true;
            this.cmb_pegawai.Location = new System.Drawing.Point(165, 300);
            this.cmb_pegawai.Name = "cmb_pegawai";
            this.cmb_pegawai.Size = new System.Drawing.Size(233, 21);
            this.cmb_pegawai.TabIndex = 37;
            this.cmb_pegawai.SelectedIndexChanged += new System.EventHandler(this.cmb_kodekredit_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 305);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 36;
            this.label2.Text = "Pegawai";
            // 
            // no_transkasi
            // 
            this.no_transkasi.HeaderText = "no_transaksi";
            this.no_transkasi.Name = "no_transkasi";
            this.no_transkasi.ReadOnly = true;
            this.no_transkasi.Visible = false;
            // 
            // no_ktp
            // 
            this.no_ktp.HeaderText = "Nomor KTP";
            this.no_ktp.Name = "no_ktp";
            this.no_ktp.ReadOnly = true;
            // 
            // nama_pelanggan
            // 
            this.nama_pelanggan.HeaderText = "Nama Pelanggan";
            this.nama_pelanggan.Name = "nama_pelanggan";
            this.nama_pelanggan.ReadOnly = true;
            // 
            // jumlah_total_kredit
            // 
            this.jumlah_total_kredit.HeaderText = "Jumlah Total Kredit";
            this.jumlah_total_kredit.Name = "jumlah_total_kredit";
            this.jumlah_total_kredit.ReadOnly = true;
            // 
            // nama_mobil
            // 
            this.nama_mobil.HeaderText = "Nama mobil";
            this.nama_mobil.Name = "nama_mobil";
            this.nama_mobil.ReadOnly = true;
            // 
            // sisa_kredit
            // 
            this.sisa_kredit.HeaderText = "Sisa kredit";
            this.sisa_kredit.Name = "sisa_kredit";
            this.sisa_kredit.ReadOnly = true;
            // 
            // pembayaran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.cmb_pegawai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_jumlahbayar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_kembali);
            this.Name = "pembayaran";
            this.Text = "pembayaran";
            this.Load += new System.EventHandler(this.pembayaran_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_jumlahbayar;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmb_pegawai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_transkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_ktp;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_pelanggan;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah_total_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisa_kredit;
    }
}