namespace WindowsFormsApplication8
{
    partial class Pengembalian
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
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.nama = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.kodebuku = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.judul = new System.Windows.Forms.TextBox();
            this.pengarang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tahun = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.genre = new System.Windows.Forms.ComboBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.TextBox();
            this.dendanya = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.simpan = new System.Windows.Forms.Button();
            this.kembali = new System.Windows.Forms.TextBox();
            this.bayar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(296, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 35);
            this.button4.TabIndex = 74;
            this.button4.Text = "Batal";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 271);
            this.dataGridView1.TabIndex = 73;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(86, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 35);
            this.button1.TabIndex = 58;
            this.button1.Text = "Tambah";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nama
            // 
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama.Enabled = false;
            this.nama.Location = new System.Drawing.Point(171, 10);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(275, 33);
            this.nama.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Nama Peminjam:";
            // 
            // button6
            // 
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(452, 10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(72, 33);
            this.button6.TabIndex = 97;
            this.button6.Text = "Cari";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(575, 320);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(448, 104);
            this.dataGridView2.TabIndex = 98;
            // 
            // kodebuku
            // 
            this.kodebuku.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kodebuku.Enabled = false;
            this.kodebuku.Location = new System.Drawing.Point(85, 19);
            this.kodebuku.Multiline = true;
            this.kodebuku.Name = "kodebuku";
            this.kodebuku.Size = new System.Drawing.Size(353, 33);
            this.kodebuku.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 85;
            this.label1.Text = "Kode Buku:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 86;
            this.label2.Text = "Judul:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Pengarang:";
            // 
            // judul
            // 
            this.judul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.judul.Enabled = false;
            this.judul.Location = new System.Drawing.Point(85, 64);
            this.judul.Multiline = true;
            this.judul.Name = "judul";
            this.judul.Size = new System.Drawing.Size(353, 33);
            this.judul.TabIndex = 88;
            // 
            // pengarang
            // 
            this.pengarang.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pengarang.Enabled = false;
            this.pengarang.Location = new System.Drawing.Point(85, 114);
            this.pengarang.Multiline = true;
            this.pengarang.Name = "pengarang";
            this.pengarang.Size = new System.Drawing.Size(353, 33);
            this.pengarang.TabIndex = 89;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(238, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 16);
            this.label8.TabIndex = 90;
            this.label8.Text = "Tahun Terbit:";
            // 
            // tahun
            // 
            this.tahun.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tahun.Enabled = false;
            this.tahun.Location = new System.Drawing.Point(331, 165);
            this.tahun.Multiline = true;
            this.tahun.Name = "tahun";
            this.tahun.Size = new System.Drawing.Size(107, 33);
            this.tahun.TabIndex = 91;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 16);
            this.label9.TabIndex = 92;
            this.label9.Text = "Genre:";
            // 
            // genre
            // 
            this.genre.Enabled = false;
            this.genre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genre.FormattingEnabled = true;
            this.genre.Location = new System.Drawing.Point(85, 165);
            this.genre.Name = "genre";
            this.genre.Size = new System.Drawing.Size(147, 32);
            this.genre.TabIndex = 93;
            // 
            // hp
            // 
            this.hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp.Enabled = false;
            this.hp.Location = new System.Drawing.Point(171, 54);
            this.hp.Multiline = true;
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(353, 33);
            this.hp.TabIndex = 111;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 16);
            this.label7.TabIndex = 110;
            this.label7.Text = "Alamat:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(7, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 16);
            this.label12.TabIndex = 109;
            this.label12.Text = "No. Hp:";
            // 
            // alamat
            // 
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alamat.Enabled = false;
            this.alamat.Location = new System.Drawing.Point(171, 96);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(353, 152);
            this.alamat.TabIndex = 112;
            // 
            // dendanya
            // 
            this.dendanya.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dendanya.Enabled = false;
            this.dendanya.Location = new System.Drawing.Point(654, 430);
            this.dendanya.Multiline = true;
            this.dendanya.Name = "dendanya";
            this.dendanya.Size = new System.Drawing.Size(369, 55);
            this.dendanya.TabIndex = 114;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 449);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 113;
            this.label6.Text = "Denda:";
            // 
            // simpan
            // 
            this.simpan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpan.Location = new System.Drawing.Point(881, 556);
            this.simpan.Name = "simpan";
            this.simpan.Size = new System.Drawing.Size(142, 35);
            this.simpan.TabIndex = 115;
            this.simpan.Text = "Simpan";
            this.simpan.UseVisualStyleBackColor = true;
            this.simpan.Click += new System.EventHandler(this.simpan_Click);
            // 
            // kembali
            // 
            this.kembali.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kembali.Enabled = false;
            this.kembali.Location = new System.Drawing.Point(876, 501);
            this.kembali.Multiline = true;
            this.kembali.Name = "kembali";
            this.kembali.Size = new System.Drawing.Size(147, 33);
            this.kembali.TabIndex = 119;
            // 
            // bayar
            // 
            this.bayar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bayar.Location = new System.Drawing.Point(655, 501);
            this.bayar.Multiline = true;
            this.bayar.Name = "bayar";
            this.bayar.Size = new System.Drawing.Size(146, 33);
            this.bayar.TabIndex = 118;
            this.bayar.TextChanged += new System.EventHandler(this.bayar_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(813, 509);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 117;
            this.label10.Text = "Kembali:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 509);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 16);
            this.label11.TabIndex = 116;
            this.label11.Text = "Bayar:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.genre);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tahun);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.pengarang);
            this.groupBox1.Controls.Add(this.judul);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.kodebuku);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(575, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(448, 261);
            this.groupBox1.TabIndex = 120;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buku";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(478, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(72, 35);
            this.button3.TabIndex = 94;
            this.button3.Text = "Refresh";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alamat);
            this.groupBox2.Controls.Add(this.hp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.nama);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(7, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 261);
            this.groupBox2.TabIndex = 121;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Biodata";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(951, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(72, 35);
            this.button5.TabIndex = 122;
            this.button5.Text = "Hapus";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Pengembalian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 626);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.kembali);
            this.Controls.Add(this.bayar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.simpan);
            this.Controls.Add(this.dendanya);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Pengembalian";
            this.Text = "gr";
            this.Load += new System.EventHandler(this.Pengembalian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox kodebuku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox judul;
        private System.Windows.Forms.TextBox pengarang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tahun;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox genre;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox dendanya;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button simpan;
        private System.Windows.Forms.TextBox kembali;
        private System.Windows.Forms.TextBox bayar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button5;

    }
}