using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication8
{
    public partial class Buku : Form
    {
        private bool isClick = false;

        public Buku()
        {
            InitializeComponent();
            display();
            addColumnGenre();

        }
        public void addColumnGenre() {
            string command = "SELECT nama FROM genre";
            MySqlDataReader reader = Koneksi.Query(command);
            while (reader.Read()) {
                genre.Items.Add(reader.GetString("nama"));
            }
        }
        public void display()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Koneksi.display("SELECT buku.id, kode_buku as `Kode Buku`, judul as `Judul`, pengarang as `Pengarang`, penerbit as `Penerbit`, tahun as `Tahun`, genre.nama as `Genre`, stock as `Stock` FROM buku INNER JOIN genre ON buku.id_genre = genre.id;");
            dataGridView1.Columns["id"].Visible = false;
        }

        private void Buku_Load(object sender, EventArgs e)
        {
            ubah.Visible = false;
            hapus.Visible = false;
            groupBox1.Enabled = false;
        }

        private void disableButtonSimpan() {
            if(kodebuku.Text == "" || pengarang.Text == "" || penerbit.Text == "" || tahun.Text == "" || genre.Text == "" || judul.Text == "") {
                tambah.Enabled = false;
            } else {
                tambah.Enabled = true;
                
            }
            disableButtonBatal();
        }

        private void disableButtonBatal() {
            if(kodebuku.Text == "" && pengarang.Text == "" && penerbit.Text == "" && tahun.Text == "" && genre.Text == "" && judul.Text == "") {
                batal.Enabled = false;
            } else {
                batal.Enabled = true;
            }
        }

        private void clearForm() {
            kodebuku.Clear();
            judul.Clear();
            pengarang.Clear();
            penerbit.Clear();
            tahun.Clear();
            genre.Text = "";
            stok.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tambah.Text == "Tambah")
            {
                groupBox1.Enabled = true;
                tambah.Text = "Simpan";
                string kode_buku = "BKI" + (dataGridView1.Rows.Count + 1).ToString().PadLeft(3, '0');
                kodebuku.Text = kode_buku;

            }
            else if (isClick)
            {
                string command = "UPDATE buku SET kode_buku = '" + kodebuku.Text + "', judul = '" + judul.Text + "', pengarang = '" + pengarang.Text + "', penerbit = '" + penerbit.Text + "', tahun = '" + tahun.Text + "', stock = '" + stok.Text + "' WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil diubah");
                isClick = false;
                tambah.Text = "Tambah";
                clearForm();
                tambah.Enabled = true;
                groupBox1.Enabled = false;
                tampilkanButtonUbah(false);

            }
            else
            {
                string command = "SELECT id FROM genre WHERE nama = '" + genre.Text + "'";
                MySqlDataReader data = Koneksi.Query(command);
                data.Read();
                int genreId = data.GetInt32("id");
                command = "INSERT INTO buku (kode_buku, judul, pengarang, penerbit, tahun, id_genre, stock) VALUES ('" + kodebuku.Text + "', '" + judul.Text + "', '" + pengarang.Text + "', '" + penerbit.Text + "', '" + tahun.Text + "', '" + genreId + "', '" + stok.Text + "')";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil ditambahkan");
                tambah.Text = "Tambah";
                clearForm();
                tambah.Enabled = true;
                groupBox1.Enabled = false;

            }
            disableButtonBatal();

            display();
        }

        private void disableTambah()
        {
            tambah.Enabled = false;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kodebuku.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            judul.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pengarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            penerbit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tahun.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            genre.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            tampilkanButtonUbah(true);
            batal.Enabled = false;
        }

        private void batal_Click(object sender, EventArgs e)
        {
            clearForm();
            groupBox1.Enabled = false;
            tambah.Text = "Tambah";
            tambah.Enabled = true;
            tampilkanButtonUbah(false);

        }

        private void ubah_Click(object sender, EventArgs e)
        {
            isClick = true;
            groupBox1.Enabled = true;
            tambah.Text = "Simpan";
            disableButtonSimpan();
            ubah.Enabled = false;
            hapus.Enabled = false;
        }

        private void tampilkanButtonUbah(bool status) {
            ubah.Visible = status;
            hapus.Visible = status;
            ubah.Enabled = status;
            hapus.Enabled = status;
            
        }

        private void kodebuku_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();
        }

        private void judul_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();
        }

        private void pengarang_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();

        }

        private void penerbit_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();

        }

        private void tahun_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();

        }

        private void genre_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();

        }

        private void stok_TextChanged(object sender, EventArgs e)
        {
            disableButtonSimpan();

        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                string command = "DELETE FROM buku WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil dihapus");
                display();
                clearForm();
                tampilkanButtonUbah(false);
                batal.Enabled = false;
                tambah.Enabled = true;
            }
        }

        private void cari_Click(object sender, EventArgs e)
        {
            string command = "SELECT buku.id, buku.kode_buku, buku.judul, buku.pengarang, buku.penerbit, buku.tahun, genre.nama AS genre, buku.stock FROM buku INNER JOIN genre ON buku.id_genre = genre.id WHERE buku.kode_buku LIKE '%" + caribuku.Text + "%' OR buku.judul LIKE '%" + caribuku.Text + "%' OR buku.pengarang LIKE '%" + caribuku.Text + "%' OR buku.penerbit LIKE '%" + caribuku.Text + "%' OR buku.tahun LIKE '%" + caribuku.Text + "%' OR genre.nama LIKE '%" + caribuku.Text + "%'";
            dataGridView1.DataSource = Koneksi.display(command);
            tampilkanButtonUbah(false);
            clearForm();
            tambah.Enabled = true;
            disableButtonBatal();
            groupBox1.Enabled = false;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            display();
            clearForm();
            tampilkanButtonUbah(false);
            tambah.Enabled = true;

        }
    }
}
