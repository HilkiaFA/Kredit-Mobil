namespace Kredit_Mobil
{
    partial class nav
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
            this.btn_mobil = new System.Windows.Forms.Button();
            this.btn_kredit = new System.Windows.Forms.Button();
            this.btn_pelanggan = new System.Windows.Forms.Button();
            this.btn_pegawai = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.btn_pembayaran = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_mobil
            // 
            this.btn_mobil.Location = new System.Drawing.Point(63, 106);
            this.btn_mobil.Name = "btn_mobil";
            this.btn_mobil.Size = new System.Drawing.Size(234, 43);
            this.btn_mobil.TabIndex = 0;
            this.btn_mobil.Text = "Mobil";
            this.btn_mobil.UseVisualStyleBackColor = true;
            this.btn_mobil.Click += new System.EventHandler(this.btn_mobil_Click);
            // 
            // btn_kredit
            // 
            this.btn_kredit.Location = new System.Drawing.Point(63, 163);
            this.btn_kredit.Name = "btn_kredit";
            this.btn_kredit.Size = new System.Drawing.Size(234, 43);
            this.btn_kredit.TabIndex = 1;
            this.btn_kredit.Text = "Kredit";
            this.btn_kredit.UseVisualStyleBackColor = true;
            this.btn_kredit.Click += new System.EventHandler(this.btn_kredit_Click);
            // 
            // btn_pelanggan
            // 
            this.btn_pelanggan.Location = new System.Drawing.Point(63, 218);
            this.btn_pelanggan.Name = "btn_pelanggan";
            this.btn_pelanggan.Size = new System.Drawing.Size(234, 43);
            this.btn_pelanggan.TabIndex = 2;
            this.btn_pelanggan.Text = "Pelanggan";
            this.btn_pelanggan.UseVisualStyleBackColor = true;
            this.btn_pelanggan.Click += new System.EventHandler(this.btn_pelanggan_Click);
            // 
            // btn_pegawai
            // 
            this.btn_pegawai.Location = new System.Drawing.Point(63, 275);
            this.btn_pegawai.Name = "btn_pegawai";
            this.btn_pegawai.Size = new System.Drawing.Size(234, 43);
            this.btn_pegawai.TabIndex = 3;
            this.btn_pegawai.Text = "Pegawai";
            this.btn_pegawai.UseVisualStyleBackColor = true;
            this.btn_pegawai.Click += new System.EventHandler(this.btn_pegawai_Click);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.Location = new System.Drawing.Point(63, 336);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Size = new System.Drawing.Size(234, 43);
            this.btn_transaksi.TabIndex = 4;
            this.btn_transaksi.Text = "Transaksi Kredit";
            this.btn_transaksi.UseVisualStyleBackColor = true;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // btn_pembayaran
            // 
            this.btn_pembayaran.Location = new System.Drawing.Point(63, 395);
            this.btn_pembayaran.Name = "btn_pembayaran";
            this.btn_pembayaran.Size = new System.Drawing.Size(234, 43);
            this.btn_pembayaran.TabIndex = 5;
            this.btn_pembayaran.Text = "Pembayaran";
            this.btn_pembayaran.UseVisualStyleBackColor = true;
            this.btn_pembayaran.Click += new System.EventHandler(this.btn_pembayaran_Click);
            // 
            // nav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 450);
            this.Controls.Add(this.btn_pembayaran);
            this.Controls.Add(this.btn_transaksi);
            this.Controls.Add(this.btn_pegawai);
            this.Controls.Add(this.btn_pelanggan);
            this.Controls.Add(this.btn_kredit);
            this.Controls.Add(this.btn_mobil);
            this.Name = "nav";
            this.Text = "nav";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_mobil;
        private System.Windows.Forms.Button btn_kredit;
        private System.Windows.Forms.Button btn_pelanggan;
        private System.Windows.Forms.Button btn_pegawai;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Button btn_pembayaran;
    }
}