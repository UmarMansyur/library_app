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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public static MDIParent1 HomePage;
        Genre genre;
        Form1 login;
        Buku buku;
        Peminjaman peminjaman;
        Pengembalian pengembalian;
        Petugas petugas;

        public MDIParent1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

       

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.login == null)
            {
                this.login = new Form1();
                this.login.FormClosed += new FormClosedEventHandler(login_FormClosed);
                this.login.ShowDialog();
            }
            else
            {
                this.login.Activate();
            }
        }

        void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.login = null;
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            enableAkses();
        }

        public void enableAkses()
        {
            if (Views.Authentication.Level == "admin")
            {
                genreToolStripMenuItem.Enabled = true;
                bukuToolStripMenuItem.Enabled = true;
                petugasToolStripMenuItem.Enabled = true;
                peminjamanToolStripMenuItem.Enabled = true;
                pengembalianToolStripMenuItem.Enabled = true;
            }
            else if (Views.Authentication.Level == "petugas")
            {
                genreToolStripMenuItem.Enabled = true;
                bukuToolStripMenuItem.Enabled = true;
                petugasToolStripMenuItem.Enabled = false;
                peminjamanToolStripMenuItem.Enabled = true;
                pengembalianToolStripMenuItem.Enabled = true;
            } else {
                genreToolStripMenuItem.Enabled = false;
                bukuToolStripMenuItem.Enabled = false;
                petugasToolStripMenuItem.Enabled = false;
                peminjamanToolStripMenuItem.Enabled = false;
                pengembalianToolStripMenuItem.Enabled = false;
            }
            HomePage = this;
        }

        private void bukuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.buku == null)
            {
                this.buku = new Buku();
                this.buku.FormClosed += new FormClosedEventHandler(buku_FormClosed);
                this.buku.ShowDialog();
            }
            else
            {
                this.buku.Activate();
            }
        }

        void buku_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.buku = null;
        }

        private void petugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.petugas == null)
            {
                this.petugas = new Petugas();
                this.petugas.FormClosed += new FormClosedEventHandler(petugas_FormClosed);
                this.petugas.ShowDialog();
            }
            else
            {
                this.petugas.Activate();
            }
        }

        void petugas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.petugas = null;
        }

        private void peminjamanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.peminjaman == null)
            {
                this.peminjaman = new Peminjaman();
                this.peminjaman.FormClosed += new FormClosedEventHandler(peminjaman_FormClosed);
                this.peminjaman.ShowDialog();
            }
            else
            {
                this.peminjaman.Activate();
            }
        }

        void peminjaman_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.peminjaman = null;
        }

        private void pengembalianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.pengembalian == null)
            {
                this.pengembalian = new Pengembalian();
                this.pengembalian.FormClosed += new FormClosedEventHandler(pengembalian_FormClosed);
                this.pengembalian.ShowDialog();
            }
            else
            {
                this.pengembalian.Activate();
            }
        }

        void pengembalian_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.pengembalian = null;
        }

        private void genreToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (this.genre == null)
            {
                this.genre = new Genre();
                this.genre.FormClosed += new FormClosedEventHandler(genre_FormClosed);
                this.genre.ShowDialog();
            }
            else
            {
                this.genre.Activate();
            }
        }

        void genre_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.genre = null;
        }



    }
}
