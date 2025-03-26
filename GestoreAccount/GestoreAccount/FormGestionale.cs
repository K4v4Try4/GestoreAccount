using Model;
using System.Drawing.Text;
using System.Windows.Forms;

namespace GestoreAccount
{
    public partial class FormGestionale : Form
    {
        private FormLogin formLogin;
        private Gestore g;
        private const String TUTTI = "TUTTI";
        private List<Account> accountsView = null;
        private Boolean isElimina = true;

        public Gestore Gestore { get { return g; } set { this.g = value; } }

        public FormGestionale(FormLogin formLogin, Gestore g)
        {
            this.formLogin = formLogin;
            this.g = g;
            InitializeComponent();
            dgvGestore.ReadOnly = true;
            dgvGestore.AllowUserToResizeColumns = false;
            this.accountsView = null;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        public void UpdateTable()
        {
            if (listBoxTipi.SelectedIndex < 0 || listBoxTipi.SelectedItem.Equals(TUTTI))
            {
                accountsView = g.Logged.Accs.Where(a => true).ToList();
                dgvGestore.DataSource = accountsView;
                dgvGestore.Columns["Tipo"].Visible = true;
            }
            else
            {
                accountsView = g.Logged.Accs.Where(a => a.Tipo.Equals(listBoxTipi.SelectedItem)).ToList();
                dgvGestore.DataSource = accountsView;
                dgvGestore.Columns["Tipo"].Visible = false;
            }
            dgvGestore.Update();
        }

        public void UpdateTipi()
        {
            HashSet<String> tipi = new HashSet<String>();
            tipi.Add(TUTTI);

            foreach (Account a in g.Logged.Accs)
            {
                tipi.Add(a.Tipo);
            }

            listBoxTipi.DataSource = tipi.ToList();
        }

        private void dgvGestore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (isElimina == true && (e.ColumnIndex == 0 && e.RowIndex >= 0))
            {
                FormModifica f;
                f = new FormModifica(this, accountsView[e.RowIndex]);
                f.Visible = true;
                this.Visible = false;
            }
            if (isElimina == false && (e.ColumnIndex == 0 && e.RowIndex >= 0))
            {
                FormScelta f;
                f = new FormScelta(this, g.Logged.Accs, accountsView[e.RowIndex]);
                f.Visible = true;
            }
        }

        private void dgvGestore_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        public void Open()
        {
            UpdateTable();
            UpdateTipi();
            this.Visible = true;
        }

        private void listBoxTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void FormGestionale_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.formLogin.Close();
        }

        private void btAddAccount_Click(object sender, EventArgs e)
        {
            FormAddAccount f = new FormAddAccount(this, g.Logged.Accs);
            f.Visible = true;
            this.Visible = false;
        }

        private void btRemoveAccount_Click(object sender, EventArgs e)
        {
            if (btnModifica.HeaderText == "MODIFICA")
            {
                isElimina = false;
                btnModifica.HeaderText = "RIMUOVI";
                btRemoveAccount.Text = "ANNULLA";
            }
            else
            {
                isElimina = true;
                btnModifica.HeaderText = "MODIFICA";
                btRemoveAccount.Text = "RIMUOVI ACCOUNT";
            }
        }

        private void disconnettiti_Click(object sender, EventArgs e)
        {
            g.Save();
            g.Logout();
            this.Visible = false;
            formLogin.Visible = true;
        }

        private void tbCercaNEmail_TextChanged(object sender, EventArgs e)
        {
            nEmail.Text = Convert.ToString(g.Logged.GetNSameEmails((tbCercaNEmail.Text).ToLower()));
            nEmail.Visible = true;
        }

        private void tbCercaAccount_TextChanged(object sender, EventArgs e)
        {
            accountsView = g.Logged.GetSameEmails(tbCercaAccount.Text);
            dgvGestore.DataSource = accountsView;
            if (string.IsNullOrEmpty(tbCercaAccount.Text))
            {
                UpdateTable();
            }
        }
    }
}