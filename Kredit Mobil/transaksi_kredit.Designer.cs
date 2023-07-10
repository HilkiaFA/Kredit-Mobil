namespace Kredit_Mobil
{
    partial class transaksi_kredit
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
            this.btn_simpan = new System.Windows.Forms.Button();
            this.txt_noktp = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.no_transkasi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_mulai_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tgl_jatuh_tempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sisa_kredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no_ktp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmb_kodekredit = new System.Windows.Forms.ComboBox();
            this.txt_jatutempo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_simpan
            // 
            this.btn_simpan.Location = new System.Drawing.Point(663, 412);
            this.btn_simpan.Name = "btn_simpan";
            this.btn_simpan.Size = new System.Drawing.Size(127, 26);
            this.btn_simpan.TabIndex = 31;
            this.btn_simpan.Text = "Simpan";
            this.btn_simpan.UseVisualStyleBackColor = true;
            this.btn_simpan.Click += new System.EventHandler(this.btn_simpan_Click);
            // 
            // txt_noktp
            // 
            this.txt_noktp.Location = new System.Drawing.Point(168, 214);
            this.txt_noktp.Multiline = true;
            this.txt_noktp.Name = "txt_noktp";
            this.txt_noktp.Size = new System.Drawing.Size(232, 27);
            this.txt_noktp.TabIndex = 29;
            this.txt_noktp.TextChanged += new System.EventHandler(this.txt_noktp_TextChanged);
            this.txt_noktp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lamakredit_KeyPress);
            this.txt_noktp.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_noktp_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tanggal mulai kredit";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 219);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nomor KTP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no_transkasi,
            this.tgl_mulai_kredit,
            this.tgl_jatuh_tempo,
            this.sisa_kredit,
            this.no_ktp});
            this.dataGridView1.Location = new System.Drawing.Point(10, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(781, 150);
            this.dataGridView1.TabIndex = 26;
            // 
            // no_transkasi
            // 
            this.no_transkasi.HeaderText = "no_transaksi";
            this.no_transkasi.Name = "no_transkasi";
            this.no_transkasi.ReadOnly = true;
            this.no_transkasi.Visible = false;
            // 
            // tgl_mulai_kredit
            // 
            this.tgl_mulai_kredit.HeaderText = "Tanggal Mulai Kredit";
            this.tgl_mulai_kredit.Name = "tgl_mulai_kredit";
            this.tgl_mulai_kredit.ReadOnly = true;
            // 
            // tgl_jatuh_tempo
            // 
            this.tgl_jatuh_tempo.HeaderText = "Tanggal Jatuh Tempo";
            this.tgl_jatuh_tempo.Name = "tgl_jatuh_tempo";
            this.tgl_jatuh_tempo.ReadOnly = true;
            // 
            // sisa_kredit
            // 
            this.sisa_kredit.HeaderText = "Sisa Kredit";
            this.sisa_kredit.Name = "sisa_kredit";
            this.sisa_kredit.ReadOnly = true;
            // 
            // no_ktp
            // 
            this.no_ktp.HeaderText = "Nomor KTP";
            this.no_ktp.Name = "no_ktp";
            this.no_ktp.ReadOnly = true;
            // 
            // btn_kembali
            // 
            this.btn_kembali.Location = new System.Drawing.Point(12, 10);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(93, 25);
            this.btn_kembali.TabIndex = 25;
            this.btn_kembali.Text = "Kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Kode Kredit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tanggal jatu tempo";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(168, 293);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 20);
            this.dateTimePicker1.TabIndex = 34;
            this.dateTimePicker1.Value = new System.DateTime(2023, 6, 18, 0, 0, 0, 0);
            // 
            // cmb_kodekredit
            // 
            this.cmb_kodekredit.FormattingEnabled = true;
            this.cmb_kodekredit.Location = new System.Drawing.Point(168, 335);
            this.cmb_kodekredit.Name = "cmb_kodekredit";
            this.cmb_kodekredit.Size = new System.Drawing.Size(233, 21);
            this.cmb_kodekredit.TabIndex = 35;
            this.cmb_kodekredit.SelectedIndexChanged += new System.EventHandler(this.cmb_kodekredit_SelectedIndexChanged);
            // 
            // txt_jatutempo
            // 
            this.txt_jatutempo.Location = new System.Drawing.Point(168, 372);
            this.txt_jatutempo.Multiline = true;
            this.txt_jatutempo.Name = "txt_jatutempo";
            this.txt_jatutempo.Size = new System.Drawing.Size(232, 27);
            this.txt_jatutempo.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(25, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Nama";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info.Location = new System.Drawing.Point(165, 254);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 16);
            this.lbl_info.TabIndex = 40;
            // 
            // transaksi_kredit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_jatutempo);
            this.Controls.Add(this.cmb_kodekredit);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_simpan);
            this.Controls.Add(this.txt_noktp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_kembali);
            this.Name = "transaksi_kredit";
            this.Text = "transaksi_kredit";
            this.Load += new System.EventHandler(this.transaksi_kredit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_simpan;
        private System.Windows.Forms.TextBox txt_noktp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmb_kodekredit;
        private System.Windows.Forms.TextBox txt_jatutempo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_transkasi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_mulai_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn tgl_jatuh_tempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn sisa_kredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn no_ktp;
    }
}