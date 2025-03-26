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
    public partial class FormModifica : Form
    {
        private FormGestionale formGestionale;
        private Account temp;

        public FormModifica(FormGestionale formGestionale, Account temp)
        {
            this.formGestionale = formGestionale;
            this.temp = temp;
            InitializeComponent();
            SetModifier();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            tbEmail.PlaceholderText = "Email";
            tbPassword.PlaceholderText = "Password";
        }

        private void SetModifier()
        {
            tbEmail.Text = temp.Mail.Mail;
            tbPassword.Text = temp.Psd.Psd;
            tbComments.Text = temp.Comments;
        }

        private void btSaveAccount_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEmail.Text) && string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Si prega di inserire l'email e la password", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(tbEmail.Text))
            {
                MessageBox.Show("Si prega di inserire una email", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrEmpty(tbPassword.Text))
            {
                MessageBox.Show("Si prega di inserire una password", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            temp.Mail.Mail = tbEmail.Text;
            temp.Psd.Psd = tbPassword.Text;
            temp.Comments = tbComments.Text;

            formGestionale.UpdateTable();

            this.Visible = false;
            formGestionale.Visible = true;
        }

        private void btGeneraPsd_Click(object sender, EventArgs e)
        {
            tbPassword.Text = Password.GeneratePassword(Convert.ToInt32(tbLunghezzaPsd.Value));
        }

        private void FormModifica_FormClosed(object sender, FormClosedEventArgs e)
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
