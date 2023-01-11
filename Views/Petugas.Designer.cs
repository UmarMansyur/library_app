namespace WindowsFormsApplication8
{
    partial class Petugas
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
            this.batal = new System.Windows.Forms.Button();
            this.ubah = new System.Windows.Forms.Button();
            this.hapus = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tambah = new System.Windows.Forms.Button();
            this.konfirmasi = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.alamat = new System.Windows.Forms.TextBox();
            this.hp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // batal
            // 
            this.batal.Enabled = false;
            this.batal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batal.Location = new System.Drawing.Point(888, 196);
            this.batal.Name = "batal";
            this.batal.Size = new System.Drawing.Size(142, 35);
            this.batal.TabIndex = 45;
            this.batal.Text = "Batal";
            this.batal.UseVisualStyleBackColor = true;
            // 
            // ubah
            // 
            this.ubah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubah.Location = new System.Drawing.Point(880, 238);
            this.ubah.Name = "ubah";
            this.ubah.Size = new System.Drawing.Size(72, 35);
            this.ubah.TabIndex = 30;
            this.ubah.Text = "Ubah";
            this.ubah.UseVisualStyleBackColor = true;
            this.ubah.Click += new System.EventHandler(this.ubah_Click);
            // 
            // hapus
            // 
            this.hapus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hapus.Location = new System.Drawing.Point(958, 238);
            this.hapus.Name = "hapus";
            this.hapus.Size = new System.Drawing.Size(72, 35);
            this.hapus.TabIndex = 31;
            this.hapus.Text = "Hapus";
            this.hapus.UseVisualStyleBackColor = true;
            this.hapus.Click += new System.EventHandler(this.hapus_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 241);
            this.dataGridView1.TabIndex = 44;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tambah
            // 
            this.tambah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tambah.Location = new System.Drawing.Point(677, 196);
            this.tambah.Name = "tambah";
            this.tambah.Size = new System.Drawing.Size(142, 35);
            this.tambah.TabIndex = 29;
            this.tambah.Text = "Tambah";
            this.tambah.UseVisualStyleBackColor = true;
            this.tambah.Click += new System.EventHandler(this.tambah_Click);
            // 
            // konfirmasi
            // 
            this.konfirmasi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.konfirmasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.konfirmasi.Location = new System.Drawing.Point(677, 105);
            this.konfirmasi.Multiline = true;
            this.konfirmasi.Name = "konfirmasi";
            this.konfirmasi.PasswordChar = '*';
            this.konfirmasi.Size = new System.Drawing.Size(353, 33);
            this.konfirmasi.TabIndex = 43;
            this.konfirmasi.TextChanged += new System.EventHandler(this.konfirmasi_TextChanged);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(677, 66);
            this.password.Multiline = true;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(353, 33);
            this.password.TabIndex = 42;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(677, 27);
            this.username.Multiline = true;
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(353, 33);
            this.username.TabIndex = 41;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // alamat
            // 
            this.alamat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.alamat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alamat.Location = new System.Drawing.Point(132, 118);
            this.alamat.Multiline = true;
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(353, 113);
            this.alamat.TabIndex = 40;
            this.alamat.TextChanged += new System.EventHandler(this.alamat_TextChanged);
            // 
            // hp
            // 
            this.hp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hp.Location = new System.Drawing.Point(132, 72);
            this.hp.Multiline = true;
            this.hp.Name = "hp";
            this.hp.Size = new System.Drawing.Size(353, 33);
            this.hp.TabIndex = 39;
            this.hp.TextChanged += new System.EventHandler(this.hp_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(535, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 16);
            this.label6.TabIndex = 38;
            this.label6.Text = "Konfirmasi Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(535, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 16);
            this.label4.TabIndex = 36;
            this.label4.Text = "Username:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(535, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Hp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nama Petugas:";
            // 
            // nama
            // 
            this.nama.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nama.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nama.Location = new System.Drawing.Point(132, 27);
            this.nama.Multiline = true;
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(353, 33);
            this.nama.TabIndex = 32;
            this.nama.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(535, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 46;
            this.label7.Text = "Level:";
            // 
            // level
            // 
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.level.FormattingEnabled = true;
            this.level.Location = new System.Drawing.Point(677, 150);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(353, 24);
            this.level.TabIndex = 47;
            this.level.SelectedIndexChanged += new System.EventHandler(this.level_SelectedIndexChanged);
            // 
            // Petugas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 546);
            this.Controls.Add(this.level);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.batal);
            this.Controls.Add(this.ubah);
            this.Controls.Add(this.hapus);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tambah);
            this.Controls.Add(this.konfirmasi);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.hp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nama);
            this.Name = "Petugas";
            this.Text = "Petugas";
            this.Load += new System.EventHandler(this.Petugas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button batal;
        private System.Windows.Forms.Button ubah;
        private System.Windows.Forms.Button hapus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button tambah;
        private System.Windows.Forms.TextBox konfirmasi;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox alamat;
        private System.Windows.Forms.TextBox hp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nama;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox level;
    }
}