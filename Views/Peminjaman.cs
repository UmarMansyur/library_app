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
    public partial class Peminjaman : Form
    {

        private DataTable dataBuku = new DataTable();

        public Peminjaman()
        {
            InitializeComponent();
        }

        

        private void Peminjaman_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            display();
            dataGridView2.DataSource = addColumnPeminjaman();

            button3.Visible = false;
        }

        

         public void display()
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DataSource = Koneksi.display("SELECT buku.id, kode_buku as `Kode Buku`, judul as `Judul`, pengarang as `Pengarang`, penerbit as `Penerbit`, tahun as `Tahun`, genre.nama as `Genre`, stock as `Stock` FROM buku INNER JOIN genre ON buku.id_genre = genre.id;");
            dataGridView1.Columns["id"].Visible = false;
        }

        private DataTable addColumnPeminjaman() {
            
            this.dataBuku.Columns.Add("Kode Buku");
            this.dataBuku.Columns.Add("Judul");
            this.dataBuku.Columns.Add("Genre");
            this.dataBuku.Columns.Add("Pengarang");
            this.dataBuku.Columns.Add("Penerbit");
            this.dataBuku.Columns.Add("Tahun");


            return this.dataBuku;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            kodebuku.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            judul.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            pengarang.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            penerbit.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            tahun.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            genre.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (kodebuku.Text == "" || judul.Text == "" || pengarang.Text == "" || labelPenerbit.Text == "" || tahun.Text == "" || genre.Text == "")
            {
                MessageBox.Show("Pilih buku terlebih dahulu");
            }
            else
            {
                // jika stok kosong maka tidak bisa dipinjam

                string command = "SELECT stock FROM buku WHERE kode_buku = '" + kodebuku.Text + "'";
                MySqlDataReader reader = Koneksi.Query(command);
                reader.Read();
                int stock = reader.GetInt32("stock");
                if (stock == 0)
                {
                    MessageBox.Show("Stok buku kosong");
                } else {
                    string[] data = new string[]{
                        kodebuku.Text,
                        judul.Text,
                        genre.Text,
                        pengarang.Text,
                        labelPenerbit.Text,
                        tahun.Text
                    };
                    dataBuku.Rows.Add(data);
                }

                
                clearForm();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string command = "SELECT buku.id, buku.kode_buku, buku.judul, buku.pengarang, buku.penerbit, buku.tahun, genre.nama AS genre, buku.stock FROM buku INNER JOIN genre ON buku.id_genre = genre.id WHERE buku.kode_buku LIKE '%" + caribuku.Text + "%' OR buku.judul LIKE '%" + caribuku.Text + "%' OR buku.pengarang LIKE '%" + caribuku.Text + "%' OR buku.penerbit LIKE '%" + caribuku.Text + "%' OR buku.tahun LIKE '%" + caribuku.Text + "%' OR genre.nama LIKE '%" + caribuku.Text + "%'";
            dataGridView1.DataSource = Koneksi.display(command);
            clearForm();
        }

        private void clearForm() {
            kodebuku.Text = "";
            judul.Text = "";
            pengarang.Text = "";
            labelPenerbit.Text = "";
            tahun.Text = "";
            genre.Text = "";
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.CurrentRow.Cells[0].Value != null)
            {
                dataBuku.Rows.RemoveAt(dataGridView2.CurrentRow.Index);
            }
            else
            {
                MessageBox.Show("Pilih buku terlebih dahulu");
            }
        }

        private void caripeminjam_Click(object sender, EventArgs e)
        {
            string command = "SELECT nama FROM peminjam WHERE nama LIKE '%" + nama.Text + "%'";
            dataGridView1.DataSource = Koneksi.display(command);
            clearForm();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.AllowUserToAddRows = false;
            if (nama.Text == "" || alamat.Text == "" || hp.Text == "")
            {
                MessageBox.Show("Data peminjam tidak boleh kosong");
            }
            else
            {
                string command = "INSERT INTO peminjam (nama, alamat, hp) VALUES ('" + nama.Text + "', '" + alamat.Text + "', '" + hp.Text + "'); SELECT LAST_INSERT_ID()";
                MySqlDataReader reader = Koneksi.Query(command);
                reader.Read();
                string peminjamId = reader.GetString(0);
                reader.Close();
                string petugasId = Views.Authentication.Id;
                command = "INSERT INTO peminjaman (id_petugas, id_peminjam, tgl_pinjam, tgl_kembali, status) VALUES ('" + petugasId + "', '" + peminjamId + "', DATE(NOW()), '" + dateTimePicker1.Text + "', 'Dipinjam'); SELECT LAST_INSERT_ID()";
                reader = Koneksi.Query(command);
                reader.Read();
                string peminjamanId = reader.GetString(0);
                reader.Close();
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    string command3 = "SELECT id FROM buku WHERE kode_buku = '" + dataGridView2.Rows[i].Cells[0].Value.ToString() + "'";
                    reader = Koneksi.Query( command3);
                    reader.Read();
                    string id_buku = reader.GetString(0);
                    string command2 = "INSERT INTO detail_peminjaman (id_peminjaman, id_buku) VALUES ('" + peminjamanId + "', '" + id_buku + "')";
                    Koneksi.Query(command2);

                    command = "UPDATE buku SET stock = stock - 1 WHERE id = '" + id_buku + "'";
                    Koneksi.Query(command);
                }

                MessageBox.Show("Data peminjam berhasil ditambahkan");
                clearForm();
                dataBuku.Rows.Clear();

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
