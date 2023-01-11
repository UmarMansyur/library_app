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
    public partial class Genre : Form
    {
        private bool isEdit = false;
        public Genre()
        {
            InitializeComponent();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            display();

        }

        private void display() {
            string command = "SELECT id, nama as `Genre` FROM genre;";
            dataGridView1.DataSource = Koneksi.display(command);
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                string command = "UPDATE genre SET nama = '" + textBox6.Text + "' WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'";
                Koneksi.Query(command);
                isEdit = false;
                button2.Enabled = true;
                button1.Enabled = true;
                MessageBox.Show("Data berhasil diubah");
            }
            else
            {
                string command = "INSERT INTO genre (nama) VALUES ('" + textBox6.Text + "')";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil ditambahkan");
            }
            textBox6.Text = "";
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           isEdit = true;
           button2.Enabled = false;
           button1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                string command = "DELETE FROM genre WHERE id = '" + dataGridView1.CurrentRow.Cells["id"].Value.ToString() + "'";
                Koneksi.Query(command);
                MessageBox.Show("Data berhasil dihapus");
                display();
            }
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if(textBox6.Text == "") {
                button6.Enabled = false;
            } else {
                button6.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox6.Text = dataGridView1.CurrentRow.Cells["Genre"].Value.ToString();
        }
    }
}
