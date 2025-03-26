using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestoreAccount
{
    public partial class FormAddAccount : Form
    {
        private FormGestionale formGestionale;
        private List<Account> temp;

        public FormAddAccount(FormGestionale formGestionale, List<Account> temp)
        {
            this.formGestionale = formGestionale;
            this.temp = temp;
            InitializeComponent();
            InizializzaCbTipi();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbEmail.PlaceholderText = "Email";
            tbPassword.PlaceholderText = "Password";
        }

        private void btGeneraPsd_Click(object sender, EventArgs e)
        {
            tbPassword.Text = Password.GeneratePassword(Convert.ToInt32(tbLunghezzaPsd.Value));
        }

        public void InizializzaCbTipi()
        {
            HashSet<String> tipi = new HashSet<String>();

            foreach (Account a in temp)
            {
                tipi.Add(a.Tipo);
            }

            cbTipo.DataSource = tipi.ToList();
            cbTipo.SelectedIndex = -1;
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            string tipo = "";

            if (cbTipo.SelectedIndex != -1)
            {
                tipo = cbTipo.Text;
            }
            else if (!string.IsNullOrEmpty(tbTipo.Text))
            {
                tipo = tbTipo.Text;
            }
            if (cbTipo.SelectedIndex != -1 && tbTipo.Text != "" && !string.IsNullOrEmpty(tbPassword.Text) && !string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Si prega di selezionare o un tipo già presente oppure inserirne uno nuovo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(tbEmail.Text) || string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Si prega di inserire un'email e una password valide.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Account a = new Account(tipo, new Email(tbEmail.Text), new Password(tbPassword.Text), tbComments.Text);
            temp.Add(a);
            //formGestionale.Gestore.Logged.AddAcc(a);
            formGestionale.UpdateTable();
            formGestionale.UpdateTipi();
            this.Visible = false;
            formGestionale.Visible = true;
        }

        private void FormAddAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formGestionale.Close();
        }

        private void btIndietro_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            formGestionale.Visible = true;
        }

        private void btValida_Click(object sender, EventArgs e)
        {
            if (Email.IsAcceptable(tbEmail.Text) == false)
            {
                MessageBox.Show("Si prega di inserire un'email valida.", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Validazione superata.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
