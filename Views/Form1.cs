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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "SELECT id, username, password, role FROM petugas  WHERE username = '" + textBox1.Text + "' AND password = '" + textBox2.Text + "'";
            MySqlDataReader reader = Koneksi.Query(command);
            if (reader.Read())
            {
                MessageBox.Show("Login Berhasil");
                Views.Authentication.Id = reader.GetString(0);
                Views.Authentication.Level = reader.GetString(3);
                MDIParent1.HomePage.enableAkses();
                MDIParent1.HomePage.loginToolStripMenuItem.Enabled = false;
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Gagal");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
