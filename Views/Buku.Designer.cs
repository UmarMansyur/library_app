namespace WindowsFormsApplication8
{
    partial class Buku
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hapus = new System.Windows.Forms.Button();
            this.ubah = new System.Windows.Forms.Button();
            this.tambah = new System.Windows.Forms.Button();
            this.tahun = new System.Windows.Forms.TextBox();
            this.penerbit = new System.Windows.Forms.TextBox();
            this.pengarang = new System.Windows.Forms.TextBox();
            this.judul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodebuku = new System.Windows.Forms.TextBox();
            this.batal = new System.Windows.Forms.Button();
            this.caribuku = new System.Windows.Forms.TextBox();
            this.cari = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.stok = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 298);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(946, 241);
            this.dataGridView1.TabIndex = 27;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // hapus
            // 
            this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.Location = new System.Drawing.Point(886, 240);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(72, 35);
            this.hapus.TabIndex = 2;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // ubah
            // 
            this.ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah.Location = new System.Drawing.Point(795, 240);
            this.ubah.Name = "ubah";
            this.ubah.Size = new System.Drawing.Size(72, 35);
            this.ubah.TabIndex = 1;
            this.ubah.Text = "Ubah";
            this.ubah.UseVisualStyleBackColor = true;
            this.ubah.Click += new System.EventHandler(this.ubah_Click);
            // 
            // tambah
            // 
            this.tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(592, 182);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(142, 35);
            this.tambah.TabIndex = 0;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.button1_Click);
            // 
            // tahun
            // 
            this.tahun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tahun.Location = new System.Drawing.Point(581, 65);
            this.tahun.Multiline = true;
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(353, 33);
            this.tahun.TabIndex = 24;
            this.tahun.TextChanged += new System.EventHandler(this.tahun_TextChanged);
            // 
            // penerbit
            // 
            this.penerbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penerbit.Location = new System.Drawing.Point(581, 20);
            this.penerbit.Multiline = true;
            this.penerbit.Name = "penerbit";
            this.penerbit.Size = new System.Drawing.Size(353, 33);
            this.penerbit.TabIndex = 23;
            this.penerbit.TextChanged += new System.EventHandler(this.penerbit_TextChanged);
            // 
            // pengarang
            // 
            this.pengarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pengarang.Location = new System.Drawing.Point(90, 111);
            this.pengarang.Multiline = true;
            this.pengarang.Name = "pengarang";
            this.pengarang.Size = new System.Drawing.Size(353, 33);
            this.pengarang.TabIndex = 22;
            this.pengarang.TextChanged += new System.EventHandler(this.pengarang_TextChanged);
            // 
            // judul
            // 
            this.judul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.judul.Location = new System.Drawing.Point(90, 65);
            this.judul.Multiline = true;
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(353, 33);
            this.judul.TabIndex = 21;
            this.judul.TextChanged += new System.EventHandler(this.judul_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(493, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Genre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(493, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Penerbit:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(493, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tahun:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Pengarang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Judul:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Kode Buku:";
            // 
            // kodebuku
            // 
            this.kodebuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kodebuku.Enabled = false;
            this.kodebuku.Location = new System.Drawing.Point(90, 20);
            this.kodebuku.Multiline = true;
            this.kodebuku.Name = "kodebuku";
            this.kodebuku.Size = new System.Drawing.Size(353, 33);
            this.kodebuku.TabIndex = 14;
            this.kodebuku.TextChanged += new System.EventHandler(this.kodebuku_TextChanged);
            // 
            // batal
            // 
            this.batal.Enabled = false;
            this.batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.Location = new System.Drawing.Point(816, 182);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(141, 35);
            this.batal.TabIndex = 28;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            this.batal.Click += new System.EventHandler(this.batal_Click);
            // 
            // caribuku
            // 
            this.caribuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caribuku.Location = new System.Drawing.Point(101, 242);
            this.caribuku.Multiline = true;
            this.caribuku.Name = "caribuku";
            this.caribuku.Size = new System.Drawing.Size(292, 33);
            this.caribuku.TabIndex = 29;
            // 
            // cari
            // 
            this.cari.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cari.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cari.Location = new System.Drawing.Point(393, 242);
            this.cari.Name = "cari";
            this.cari.Size = new System.Drawing.Size(72, 33);
            this.cari.TabIndex = 30;
            this.cari.Text = "Cari";
            this.cari.UseVisualStyleBackColor = true;
            this.cari.Click += new System.EventHandler(this.cari_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Cari:";
            // 
            // genre
            // 
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.FormattingEnabled = true;
            this.genre.Location = new System.Drawing.Point(581, 117);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(177, 24);
            this.genre.TabIndex = 48;
            this.genre.SelectedIndexChanged += new System.EventHandler(this.genre_SelectedIndexChanged);
            // 
            // stok
            // 
            this.stok.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stok.Location = new System.Drawing.Point(836, 114);
            this.stok.Multiline = true;
            this.stok.Name = "stok";
            this.stok.Size = new System.Drawing.Size(98, 33);
            this.stok.TabIndex = 50;
            this.stok.TextChanged += new System.EventHandler(this.stok_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(789, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 16);
            this.label8.TabIndex = 49;
            this.label8.Text = "Stok:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stok);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.tahun);
            this.groupBox1.Controls.Add(this.penerbit);
            this.groupBox1.Controls.Add(this.pengarang);
            this.groupBox1.Controls.Add(this.judul);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kodebuku);
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(946, 163);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Buku";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(480, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 35);
            this.button1.TabIndex = 52;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Buku
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cari);
            this.Controls.Add(this.caribuku);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.ubah);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tambah);
            this.Name = "Buku";
            this.Text = "Buku";
            this.Load += new System.EventHandler(this.Buku_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.Button ubah;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.TextBox tahun;
        private System.Windows.Forms.TextBox penerbit;
        private System.Windows.Forms.TextBox pengarang;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodebuku;
        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.TextBox caribuku;
        private System.Windows.Forms.Button cari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.TextBox stok;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}