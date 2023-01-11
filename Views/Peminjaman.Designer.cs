namespace WindowsFormsApplication8
{
    partial class Peminjaman
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
            this.label7 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.caribuku = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.alamat = new System.Windows.Forms.TextBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.nama = new System.Windows.Forms.TextBox();
            this.pengarang = new System.Windows.Forms.TextBox();
            this.judul = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.kodebuku = new System.Windows.Forms.TextBox();
            this.tahun = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.caripeminjam = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.labelPenerbit = new System.Windows.Forms.Label();
            this.penerbit = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 16);
            this.label7.TabIndex = 51;
            this.label7.Text = "Cari:";
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(302, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(67, 33);
            this.button5.TabIndex = 50;
            this.button5.Text = "Cari";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // caribuku
            // 
            this.caribuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caribuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caribuku.Location = new System.Drawing.Point(103, 268);
            this.caribuku.Multiline = true;
            this.caribuku.Name = "caribuku";
            this.caribuku.Size = new System.Drawing.Size(201, 33);
            this.caribuku.TabIndex = 49;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(852, 216);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 35);
            this.button4.TabIndex = 48;
            this.button4.Text = "Batal";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 323);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(432, 246);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(641, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 32;
            this.button1.Text = "Simpan";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alamat
            // 
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.Location = new System.Drawing.Point(641, 106);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(353, 55);
            this.alamat.TabIndex = 46;
            // 
            // hp
            // 
            this.hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.Location = new System.Drawing.Point(641, 64);
            this.hp.Multiline = true;
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(353, 33);
            this.hp.TabIndex = 45;
            // 
            // nama
            // 
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(641, 22);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(266, 33);
            this.nama.TabIndex = 44;
            // 
            // pengarang
            // 
            this.pengarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pengarang.Enabled = false;
            this.pengarang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pengarang.Location = new System.Drawing.Point(103, 117);
            this.pengarang.Multiline = true;
            this.pengarang.Name = "pengarang";
            this.pengarang.Size = new System.Drawing.Size(353, 33);
            this.pengarang.TabIndex = 43;
            // 
            // judul
            // 
            this.judul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.judul.Enabled = false;
            this.judul.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.judul.Location = new System.Drawing.Point(103, 67);
            this.judul.Multiline = true;
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(353, 33);
            this.judul.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(477, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Alamat:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(477, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 39;
            this.label4.Text = "Nama Peminjam:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(477, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 40;
            this.label5.Text = "No. Hp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 38;
            this.label3.Text = "Pengarang:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Judul:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 36;
            this.label1.Text = "Kode Buku:";
            // 
            // kodebuku
            // 
            this.kodebuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kodebuku.Enabled = false;
            this.kodebuku.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kodebuku.Location = new System.Drawing.Point(103, 22);
            this.kodebuku.Multiline = true;
            this.kodebuku.Name = "kodebuku";
            this.kodebuku.Size = new System.Drawing.Size(353, 33);
            this.kodebuku.TabIndex = 35;
            // 
            // tahun
            // 
            this.tahun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tahun.Enabled = false;
            this.tahun.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahun.Location = new System.Drawing.Point(349, 163);
            this.tahun.Multiline = true;
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(107, 33);
            this.tahun.TabIndex = 53;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(256, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 52;
            this.label8.Text = "Tahun Terbit:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(21, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 54;
            this.label9.Text = "Genre:";
            // 
            // genre
            // 
            this.genre.Enabled = false;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.FormattingEnabled = true;
            this.genre.Location = new System.Drawing.Point(103, 169);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(147, 24);
            this.genre.TabIndex = 55;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(641, 171);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(352, 22);
            this.dateTimePicker1.TabIndex = 56;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(477, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 16);
            this.label10.TabIndex = 57;
            this.label10.Text = "Waktu Peminjaman:";
            // 
            // caripeminjam
            // 
            this.caripeminjam.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.caripeminjam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caripeminjam.Location = new System.Drawing.Point(906, 22);
            this.caripeminjam.Name = "caripeminjam";
            this.caripeminjam.Size = new System.Drawing.Size(88, 33);
            this.caripeminjam.TabIndex = 58;
            this.caripeminjam.Text = "Cari";
            this.caripeminjam.UseVisualStyleBackColor = true;
            this.caripeminjam.Click += new System.EventHandler(this.caripeminjam_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(921, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 35);
            this.button3.TabIndex = 34;
            this.button3.Text = "Hapus";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(384, 267);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 35);
            this.button7.TabIndex = 59;
            this.button7.Text = "Buku";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(550, 323);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(443, 246);
            this.dataGridView2.TabIndex = 60;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // labelPenerbit
            // 
            this.labelPenerbit.AutoSize = true;
            this.labelPenerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenerbit.Location = new System.Drawing.Point(21, 216);
            this.labelPenerbit.Name = "labelPenerbit";
            this.labelPenerbit.Size = new System.Drawing.Size(61, 16);
            this.labelPenerbit.TabIndex = 61;
            this.labelPenerbit.Text = "Penerbit:";
            // 
            // penerbit
            // 
            this.penerbit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penerbit.Enabled = false;
            this.penerbit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penerbit.Location = new System.Drawing.Point(103, 206);
            this.penerbit.Multiline = true;
            this.penerbit.Name = "penerbit";
            this.penerbit.Size = new System.Drawing.Size(201, 33);
            this.penerbit.TabIndex = 62;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(314, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 35);
            this.button6.TabIndex = 63;
            this.button6.Text = "Tambah";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Peminjaman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 607);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.penerbit);
            this.Controls.Add(this.labelPenerbit);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.caripeminjam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.genre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tahun);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.caribuku);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.pengarang);
            this.Controls.Add(this.judul);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.kodebuku);
            this.Name = "Peminjaman";
            this.Text = "Peminjaman";
            this.Load += new System.EventHandler(this.Peminjaman_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox caribuku;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.TextBox pengarang;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox kodebuku;
        private System.Windows.Forms.TextBox tahun;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button caripeminjam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label labelPenerbit;
        private System.Windows.Forms.TextBox penerbit;
        private System.Windows.Forms.Button button6;
    }
}