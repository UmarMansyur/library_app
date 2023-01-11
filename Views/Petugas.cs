using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Petugas : Form
    {

        private bool isClick = false;


        public Petugas()
        {
            InitializeComponent();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();
        }

        

        private void Petugas_Load(object sender, EventArgs e)
        {
            tampilkanButtonUbah(false);
            displayPetugas();
            EnabledForm(false);
            level.Items.Add("admin");
            level.Items.Add("petugas");
        }

        private void tampilkanButtonUbah(bool status)
        {
            ubah.Visible = status;
            hapus.Visible = status;
            ubah.Enabled = status;
            hapus.Enabled = status;

        }

        public void displayPetugas()
        {
            dataGridView1.DataSource = Koneksi.display("SELECT id, nama as `Nama`, username as `Username`, password as `Password`, alamat as `Alamat`, hp as `No. HP`, role as `Level` FROM petugas");
            dataGridView1.Columns[0].Visible = false;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void disableButtonTambah()
        {
            if(nama.Text == "" || username.Text == "" || password.Text == "" || alamat.Text == "" || hp.Text == "" || password.Text == "" || konfirmasi.Text == "" || level.Text == "") {
                tambah.Enabled = false;
            } else {
                tambah.Enabled = true;
            }
            disableButtonBatal();
        }

        private void disableButtonBatal() {
            if(nama.Text == "" && username.Text == "" && password.Text == "" && alamat.Text == "" && hp.Text == "" && password.Text == "" && konfirmasi.Text == "" && level.Text == "") {
                batal.Enabled = false;
            } else {
                batal.Enabled = true;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void tambah_Click(object sender, EventArgs e)
        {
            if (tambah.Text == "Tambah")
            {
                EnabledForm(true);
                tambah.Text = "Simpan";
            }
            else if (isClick)
            {
               if(password.Text == konfirmasi.Text) {
                    string command = "UPDATE petugas SET nama = '" + nama.Text + "', username = '" + username.Text + "', password = '" + password.Text + "', alamat = '" + alamat.Text + "', hp = '" + hp.Text + "', role = '" + level.Text + "' WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                    Koneksi.Query(command);
                    MessageBox.Show("Data berhasil diubah");
                } else {
                    MessageBox.Show("Password tidak sama");
                }
                isClick = false;
                tambah.Text = "Tambah";
                tampilkanButtonUbah(false);
                clearForm();
                EnabledForm(false);
                displayPetugas();

            }
            else
            {
                if(password.Text == konfirmasi.Text) {
                    string command = "INSERT INTO petugas (nama, username, password, alamat, hp, role) VALUES ('" + nama.Text + "', '" + username.Text + "', '" + password.Text + "', '" + alamat.Text + "', '" + hp.Text + "', '" + level.Text + "')";
                    Koneksi.Query(command);
                    MessageBox.Show("Data berhasil ditambahkan");
                } else {
                    MessageBox.Show("Password tidak sama");
                }
            }

            disableButtonTambah();
            tampilkanButtonUbah(false);
            clearForm();
            displayPetugas();
                
        }

        private void clearForm()
        {
            nama.Text = "";
            username.Text = "";
            password.Text = "";
            alamat.Text = "";
            hp.Text = "";
            level.Text = "";
            konfirmasi.Text = "";
        }

        private void EnabledForm(bool status)
        {
            nama.Enabled = status;
            username.Enabled = status;
            password.Enabled = status;
            alamat.Enabled = status;
            hp.Enabled = status;
            level.Enabled = status;
            konfirmasi.Enabled = status;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nama.Text = dataGridView1.CurrentRow.Cells["Nama"].Value.ToString();
            username.Text = dataGridView1.CurrentRow.Cells["Username"].Value.ToString();
            password.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            alamat.Text = dataGridView1.CurrentRow.Cells["Alamat"].Value.ToString();
            hp.Text = dataGridView1.CurrentRow.Cells["No. HP"].Value.ToString();
            level.Text = dataGridView1.CurrentRow.Cells["Level"].Value.ToString();
            konfirmasi.Text = dataGridView1.CurrentRow.Cells["Password"].Value.ToString();
            tampilkanButtonUbah(true);
        }

        private void ubah_Click(object sender, EventArgs e)
        {
            EnabledForm(true);
            isClick = true;
            tambah.Text = "Simpan";
            ubah.Enabled = false;
            hapus.Enabled = false;

        }

        private void hapus_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                string command = "DELETE FROM petugas WHERE id = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil dihapus");
                displayPetugas();
            }
        }

        private void batal_Click(object sender, EventArgs e)
        {
            clearForm();
            EnabledForm(false);
            tampilkanButtonUbah(false);
            tambah.Text = "Tambah";
        }

        private void hp_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }

        private void alamat_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }

        private void password_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }

        private void konfirmasi_TextChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }

        private void level_SelectedIndexChanged(object sender, EventArgs e)
        {
            disableButtonTambah();

        }
    }
}
