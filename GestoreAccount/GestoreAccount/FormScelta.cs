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
    public partial class FormScelta : Form
    {
        private FormGestionale formGestionale;
        private List<Account> accounts;
        private Account temp;

        public FormScelta(FormGestionale formGestionale, List<Account> accounts, Account temp)
        {
            this.formGestionale = formGestionale;
            this.accounts = accounts;
            this.temp = temp;
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btSi_Click(object sender, EventArgs e)
        {
            if (temp != null && accounts.Contains(temp))
            {
                accounts.Remove(temp);
                formGestionale.UpdateTable();
                formGestionale.UpdateTipi();
            }

            this.Visible = false;
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FormScelta_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formGestionale.Close();
        }
    }
}
