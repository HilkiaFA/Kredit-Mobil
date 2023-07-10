namespace Kredit_Mobil
{
    partial class kredit
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lamakredit = new System.Windows.Forms.TextBox();
            this.txt_angsuran = new System.Windows.Forms.TextBox();
            this.txt_dp = new System.Windows.Forms.TextBox();
            this.btn_batal = new System.Windows.Forms.Button();
            this.btn_simpan = new System.Windows.Forms.Button();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_tambah = new System.Windows.Forms.Button();
            this.id_mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_mobil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kategori = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lama_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.angsuran = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(10, 8);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(98, 25);
            this.btn_kembali.TabIndex = 0;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_mobil,
            this.nama_mobil,
            this.kategori,
            this.harga});
            this.dataGridView1.Location = new System.Drawing.Point(10, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(322, 170);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_kredit,
            this.lama_kredit,
            this.dp,
            this.angsuran});
            this.dataGridView2.Location = new System.Drawing.Point(360, 50);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(428, 170);
            this.dataGridView2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lama Kredit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 293);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angsuran";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(374, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "DP";
            // 
            // txt_lamakredit
            // 
            this.txt_lamakredit.Enabled = false;
            this.txt_lamakredit.Location = new System.Drawing.Point(100, 245);
            this.txt_lamakredit.Multiline = true;
            this.txt_lamakredit.Name = "txt_lamakredit";
            this.txt_lamakredit.Size = new System.Drawing.Size(232, 27);
            this.txt_lamakredit.TabIndex = 9;
            // 
            // txt_angsuran
            // 
            this.txt_angsuran.Enabled = false;
            this.txt_angsuran.Location = new System.Drawing.Point(100, 292);
            this.txt_angsuran.Multiline = true;
            this.txt_angsuran.Name = "txt_angsuran";
            this.txt_angsuran.Size = new System.Drawing.Size(232, 27);
            this.txt_angsuran.TabIndex = 10;
            // 
            // txt_dp
            // 
            this.txt_dp.Enabled = false;
            this.txt_dp.Location = new System.Drawing.Point(410, 245);
            this.txt_dp.Multiline = true;
            this.txt_dp.Name = "txt_dp";
            this.txt_dp.Size = new System.Drawing.Size(232, 27);
            this.txt_dp.TabIndex = 11;
            // 
            // btn_batal
            // 
            this.btn_batal.Enabled = false;
            this.btn_batal.Location = new System.Drawing.Point(578, 349);
            this.btn_batal.Name = "btn_batal";
            this.btn_batal.Size = new System.Drawing.Size(84, 27);
            this.btn_batal.TabIndex = 20;
            this.btn_batal.Text = "Batal";
            this.btn_batal.UseVisualStyleBackColor = true;
            this.btn_batal.Click += new System.EventHandler(this.btn_batal_Click);
            // 
            // btn_simpan
            // 
            this.btn_simpan.Enabled = false;
            this.btn_simpan.Location = new System.Drawing.Point(476, 349);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(84, 27);
            this.btn_simpan.TabIndex = 19;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Location = new System.Drawing.Point(268, 349);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(84, 27);
            this.btn_hapus.TabIndex = 18;
            this.btn_hapus.Text = "Hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(143, 349);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(84, 27);
            this.btn_edit.TabIndex = 17;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_tambah
            // 
            this.btn_tambah.Location = new System.Drawing.Point(24, 349);
            this.btn_tambah.Name = "btn_tambah";
            this.btn_tambah.Size = new System.Drawing.Size(84, 27);
            this.btn_tambah.TabIndex = 16;
            this.btn_tambah.Text = "Tambah";
            this.btn_tambah.UseVisualStyleBackColor = true;
            this.btn_tambah.Click += new System.EventHandler(this.btn_tambah_Click);
            // 
            // id_mobil
            // 
            this.id_mobil.HeaderText = "idmobil";
            this.id_mobil.Name = "id_mobil";
            this.id_mobil.ReadOnly = true;
            this.id_mobil.Visible = false;
            // 
            // nama_mobil
            // 
            this.nama_mobil.HeaderText = "Nama Mobil";
            this.nama_mobil.Name = "nama_mobil";
            this.nama_mobil.ReadOnly = true;
            // 
            // kategori
            // 
            this.kategori.HeaderText = "Kategori";
            this.kategori.Name = "kategori";
            this.kategori.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.HeaderText = "Harga";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // id_kredit
            // 
            this.id_kredit.HeaderText = "id_kredit";
            this.id_kredit.Name = "id_kredit";
            this.id_kredit.ReadOnly = true;
            this.id_kredit.Visible = false;
            // 
            // lama_kredit
            // 
            this.lama_kredit.HeaderText = "Lama Kredit";
            this.lama_kredit.Name = "lama_kredit";
            this.lama_kredit.ReadOnly = true;
            // 
            // dp
            // 
            this.dp.HeaderText = "DP";
            this.dp.Name = "dp";
            this.dp.ReadOnly = true;
            // 
            // angsuran
            // 
            this.angsuran.HeaderText = "Angsuran";
            this.angsuran.Name = "angsuran";
            this.angsuran.ReadOnly = true;
            // 
            // kredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 396);
            this.Controls.Add(this.btn_batal);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_tambah);
            this.Controls.Add(this.txt_dp);
            this.Controls.Add(this.txt_angsuran);
            this.Controls.Add(this.txt_lamakredit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kembali);
            this.Name = "kredit";
            this.Text = "kredit";
            this.Load += new System.EventHandler(this.kredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lamakredit;
        private System.Windows.Forms.TextBox txt_angsuran;
        private System.Windows.Forms.TextBox txt_dp;
        private System.Windows.Forms.Button btn_batal;
        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_tambah;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_mobil;
        private System.Windows.Forms.DataGridViewTextBoxColumn kategori;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn lama_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dp;
        private System.Windows.Forms.DataGridViewTextBoxColumn angsuran;
    }
}