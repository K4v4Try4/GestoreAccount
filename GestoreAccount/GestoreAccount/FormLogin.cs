using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestoreAccount
{
    public partial class FormLogin : Form
    {
        private Gestore g;
        private FormGestionale formGestionale;
        private String path;

        public FormLogin(Gestore g)
        {
            this.g = g;
            this.formGestionale = new FormGestionale(this, this.g);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbUser.PlaceholderText = "Utente";
            tbPsd.PlaceholderText = "Password";
        }

        public FormLogin(String path)
        {
            this.path = path;
            this.g = new Gestore();
            this.formGestionale = new FormGestionale(this, this.g);
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbUser.PlaceholderText = "Utente";
            tbPsd.PlaceholderText = "Password";
            this.Carica(path);
        }

        private void btMostra_Click(object sender, EventArgs e)
        {
            if (tbPsd.PasswordChar != '\0')
            {
                tbPsd.PasswordChar = '\0';
            }
            else
            {
                tbPsd.PasswordChar = '*';
            }
        }

        private void btRegistrati_Click(object sender, EventArgs e)
        {
            if (g.Utenti.Count(u => u.Username.Equals(tbUser.Text)) != 0)
            {
                return;
            }

            g.Logout();

            g.AddUtente(new Utente(tbUser.Text));
            g.Login(tbUser.Text, tbPsd.Text);


            formGestionale.Open();
            this.Visible = false;
        }

        private void btAccedi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbUser.Text) && string.IsNullOrEmpty(tbPsd.Text))
            {
                MessageBox.Show("Si prega di inserire un utente", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            g.Logout();
            g.Login(tbUser.Text, tbPsd.Text);
            if (g.Logged == null)
            {
                return;
            }
            formGestionale.Open();
            this.Visible = false;
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAccedi_Click(sender, e);
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbPsd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btAccedi_Click(sender, e);
            }
        }

        public void Salva(String path)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(this.g.Save());
            sw.Close();
            this.path = path;
        }

        public void Carica(String path)
        {
            StreamReader sw = new StreamReader(path);
            String s = sw.ReadToEnd();
            this.g.Load(s);
            sw.Close();
            this.path = path;
        }

        private void salvaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Salva(this.path);
        }

        private void salvaEEsciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Salva(this.path);
            this.Close();
        }

        private void salvaConNomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog ofd = new SaveFileDialog();
            ofd.InitialDirectory = this.path;
            ofd.Filter = "ker uaf (*.kwj)|*.kwj";
            ofd.FilterIndex = 1;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.path = ofd.FileName;
                this.Salva(this.path);
            }
        }

        private void caricaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = this.path;
            ofd.Filter = "ker uaf (*.kwj)|*.kwj";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            ofd.RestoreDirectory = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.path = ofd.FileName;
                this.Carica(this.path);
            }
        }
    }
}
