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
    public partial class Pengembalian : Form
    {
        private DataTable pengembalianTable = new DataTable();

        public Pengembalian()
        {
            InitializeComponent();
        }

        private void Pengembalian_Load(object sender, EventArgs e)
        {
            displayPeminjam();
            dataGridView2.DataSource = displayPengembalian();
            dataGridView2.Columns["id"].Visible = false;
        }

        public DataTable displayPengembalian()
        {
            this.pengembalianTable.Columns.Add("id");
            this.pengembalianTable.Columns.Add("Nama Peminjam");
            this.pengembalianTable.Columns.Add("Kode Buku");
            this.pengembalianTable.Columns.Add("Judul");
            this.pengembalianTable.Columns.Add("Genre");
            this.pengembalianTable.Columns.Add("Pengarang");
            this.pengembalianTable.Columns.Add("Penerbit");
            this.pengembalianTable.Columns.Add("Tahun");
            this.pengembalianTable.Columns.Add("Tanggal Pinjam");
            this.pengembalianTable.Columns.Add("Tanggal Kembali");
            this.pengembalianTable.Columns.Add("Tanggal Dikembalikan");
            this.pengembalianTable.Columns.Add("Denda");

            return this.pengembalianTable;
        }

        private void displayPeminjam()
        {
            string command =
                "SELECT peminjam.nama as `Nama Peminjam`, peminjam.alamat as `Alamat`, peminjam.hp as 'Hp', buku.kode_buku as `Kode Buku`, buku.judul as `Judul`, buku.pengarang as `Pengarang`, buku.penerbit as `Penerbit`, buku.tahun as `Tahun`, genre.nama as 'Genre', peminjaman.tgl_pinjam as `Tanggal Pinjam`, peminjaman.tgl_kembali as `Tanggal Kembali`, peminjaman.status as `Peminjaman Status` FROM detail_peminjaman INNER JOIN peminjaman ON detail_peminjaman.id_peminjaman = peminjaman.id INNER JOIN peminjam ON peminjaman.id_peminjam = peminjam.id INNER JOIN buku ON detail_peminjaman.id_buku = buku.id INNER JOIN genre ON buku.id_genre = genre.id WHERE peminjaman.status = 'Dipinjam';";
            dataGridView1.DataSource = Koneksi.display(command);
        }

        private void dataGridView1_CellClick(
            object sender,
            DataGridViewCellEventArgs e
        )
        {
            nama.Text =
                dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            alamat.Text =
                dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            hp.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            kodebuku.Text =
                dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            judul.Text =
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            pengarang.Text =
                dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            tahun.Text =
                dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            genre.Text =
                dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                nama.Text == "" ||
                alamat.Text == "" ||
                hp.Text == "" ||
                kodebuku.Text == "" ||
                judul.Text == "" ||
                pengarang.Text == "" ||
                tahun.Text == "" ||
                genre.Text == ""
            )
            {
                MessageBox.Show("Data belum lengkap");
            }
            else
            {
                string command =
                    "SELECT DATE_FORMAT(tgl_pinjam, '%Y-%m-%d'), DATE_FORMAT(tgl_kembali, '%Y-%m-%d'), buku.penerbit, peminjaman.id, peminjam.nama as `Nama Peminjam` FROM peminjaman INNER JOIN detail_peminjaman ON peminjaman.id = detail_peminjaman.id_peminjaman INNER JOIN buku ON detail_peminjaman.id_buku = buku.id INNER JOIN peminjam ON peminjaman.id_peminjam = peminjam.id WHERE buku.kode_buku = '" +
                    kodebuku.Text +
                    "' AND peminjam.nama = '" +
                    nama.Text +
                    "' AND peminjam.alamat = '" +
                    alamat.Text +
                    "' AND peminjam.hp = '" +
                    hp.Text +
                    "' AND peminjaman.status = 'Dipinjam';";
                MySqlDataReader reader = Koneksi.Query(command);
                reader.Read();
                string tgl_pinjam = reader.GetString(0);
                string tgl_kembali = reader.GetString(1);
                string penerbit = reader.GetString(2);
                string id_peminjam = reader.GetString(3);
                string nama_peminjam = reader.GetString(4);
                command = "SELECT DATE_FORMAT(NOW(), '%Y-%m-%d')";
                MySqlDataReader response = Koneksi.Query(command);
                response.Read();
                string dikembalikan = response.GetString(0);

                string denda = cekDenda(dikembalikan, tgl_kembali).ToString();

                string[] data =
                    new string[] {
                        id_peminjam,
                        nama_peminjam,
                        kodebuku.Text,
                        judul.Text,
                        genre.Text,
                        pengarang.Text,
                        penerbit,
                        tahun.Text,
                        tgl_pinjam,
                        tgl_kembali,
                        dikembalikan,
                        denda
                    };
                this.pengembalianTable.Rows.Add(data);
                dendanya.Text = cekTotalDenda().ToString();
            }
        }

        private double cekDenda(string dikembalikan, string tanggal_kembali)
        {
            DateTime tgl_kembali = DateTime.Parse(tanggal_kembali);
            DateTime tgl_dikembalikan = DateTime.Parse(dikembalikan);

            if (tgl_dikembalikan > tgl_kembali)
            {
                TimeSpan selisih = tgl_dikembalikan - tgl_kembali;
                int selisih_hari = selisih.Days;
                return selisih_hari * 1000;
            }
            else
            {
                return 0;
            }
        }

        private double cekTotalDenda() {
            double total = 0;
            foreach (DataRow row in this.pengembalianTable.Rows) {
                total += double.Parse(row["Denda"].ToString());
            }
            return total;
        }

        private void bayar_TextChanged(object sender, EventArgs e)
        {
            if(bayar.Text != "") {
                double total = double.Parse(dendanya.Text);
                double pay = double.Parse(this.bayar.Text);
                kembali.Text = (pay - total).ToString();
                if (pay < total)
                {
                    kembali.Text = "0";
                    simpan.Enabled = false;
                }
                else
                {
                    simpan.Enabled = true;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                pengembalianTable.Rows.RemoveAt(pengembalianTable.Rows.Count - 1);
                dendanya.Text = cekTotalDenda().ToString();
            }
        }

        private void simpan_Click(object sender, EventArgs e)
        {
            if (pengembalianTable.Rows.Count > 0)
            {
                foreach (DataRow row in this.pengembalianTable.Rows)
                {
                    string petugasId = Views.Authentication.Id;
                    string command =
                        "UPDATE peminjaman SET status = 'Dikembalikan' WHERE id = '" +
                        row["id"].ToString() +
                        "';";
                    Koneksi.Query(command);
                    command = "INSERT INTO pengembalian (`id_peminjaman`, `id_petugas`, `tgl_kembali`, `denda`) VALUES ('" +
                        row["id"].ToString() +
                        "', '" +
                        petugasId +
                        "', '" +
                        row["Tanggal Dikembalikan"].ToString() +
                        "', '" +
                        row["Denda"].ToString() +
                        "');";
                    Koneksi.Query(command);

                    command = "UPDATE buku SET stock = stock + 1 WHERE kode_buku = '" +
                        row["Kode Buku"].ToString() +
                        "';";

                    Koneksi.Query(command);

                }
                MessageBox.Show("Data berhasil disimpan");
                this.pengembalianTable.Rows.Clear();
                this.dendanya.Text = "0";
                this.bayar.Text = "";
                this.kembali.Text = "";
                displayPeminjam();
            }
        }
    }
}
